using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;
using System.Timers;

namespace CT.Shop.bgmodule
{
    public partial class Form1 : Form
    {
        #region var system
        HotKey hkey = new HotKey(System.Windows.Forms.Keys.End, KeyModifiers.None);
        string accName = "theclouderss37";
        string accPwd = "CloudCloud";
        string accTel = "+79950100654";
        string posit;
        string[] tabLine = new string[16];
        static ChromeOptions opt = new ChromeOptions();
        public static WebDriver driver;
        #endregion
        bool debug = false;
        //bool debug = true;

        #region var продажи
        bool isOpen = false;
        string currentUser = "Debug";
        bool activeTicket = false;
        string logPath = "C:/Logs/";

        //Счетчики дня
        int totalCash = 0;
        int ticketCount = 0;
        int midTiCount = 0;
        int goodCount = 0;
        int discCount = 0;

        //Чеки
       public  List<ticket> ticketList = new List<ticket>();
        ticket currentTicket = new ticket();
        good currentGood = new good();
        int currentGoodCount = 0;
        //int currentCost = 0;
        //int currentPosCount = 0;
        //int currentDiscCount = 0;
        int currentPcsCount = 1;
        //bool editing = false;

        #endregion


        #region processHide
        Process[] processes = Process.GetProcessesByName("chromedriver");
        private const int SW_MAXIMIZE = 3;
        private const int SW_MINIMIZE = 6;
        [DllImport("user32.dll", EntryPoint = "FindWindow")]
        public static extern IntPtr FindWindowByCaption(IntPtr ZeroOnly, string lpWindowName);
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        public void MinimizeWindow()
        {

            foreach (Process p in processes)
            {
                IntPtr windowHandle = p.MainWindowHandle;
                ShowWindow(windowHandle, SW_MINIMIZE);

                // do something with windowHandle
            }
        }



        #endregion
        #region Timer

        System.Timers.Timer tmr = new System.Timers.Timer(100);
        static int barV = 0;
        void waitBar(int max, string line)
        {
            this.Invoke(new Action(() => this.Activate()));
            loadLbl.Invoke(new Action(() => loadLbl.Text = line));
            pauseBar.Invoke(new Action(() => pauseBar.Maximum = max));
            pauseBar.Invoke(new Action(() => pauseBar.Minimum = 0));
            pauseBar.Invoke(new Action(() => pauseBar.Value = 0));
            barV = 0;
            tmr.Start();
            //pauseBar.Invoke(new Action(() => pauseBar.Value))
            while (pauseBar.Value < max)
            {
                try
                {
                    if (pauseBar.Value == pauseBar.Maximum) break;
                    pauseBar.Invoke(new Action(() => pauseBar.Value = barV));
                    this.Invoke(new Action(() => this.Update()));
                }
                catch(Exception ex) { break; };
            }
            tmr.Stop();
            loadLbl.Invoke(new Action(() => loadLbl.Text += " | Завершнено"));
        }
        private void WaitThread_DoWork(object sender, DoWorkEventArgs e)
        {
        }
        private static void tmr_t(Object source, ElapsedEventArgs e)
        { barV++; }
        #endregion
        #region остальные функции 
        void endPress()//триггер на ввод штрихкода
        {
            this.Activate();
            codeBox.Clear();
            this.TopMost = true;
            codeBox.Focus();
        }
        void findElement(string line)//поиск позиции в таблице
        {
            OpenQA.Selenium.Interactions.Actions action = new OpenQA.Selenium.Interactions.Actions(driver);

            try
            {
                action.KeyDown(OpenQA.Selenium.Keys.Control).Build().Perform();
                action.KeyDown("f").Build().Perform();
                waitBar(1, "Отправка комбинации1");
                action.KeyUp("f").Build().Perform();
                action.KeyUp(OpenQA.Selenium.Keys.Control).Build().Perform();
                waitBar(10, "Отправка комбинации2");

                driver.FindElement(By.XPath("//input[@aria-label='Найти на листе']")).SendKeys(line);
                waitBar(5, "Отправка кода");

                action.SendKeys(OpenQA.Selenium.Keys.Enter).Build().Perform();
                waitBar(10, "Загрузка позиции");

                driver.FindElement(By.XPath("//div[@aria-label='Закрыть']")).Click();
                waitBar(2, "Извлечение позиции");

                action.KeyDown(OpenQA.Selenium.Keys.LeftShift).Build().Perform();
                for (int i = 0; i < 15; i++)
                {
                    action.KeyDown(OpenQA.Selenium.Keys.ArrowRight).Build().Perform();
                }
                action.KeyUp(OpenQA.Selenium.Keys.LeftShift).Build().Perform();

                waitBar(1, "Извлечение позиции 2");
                action.KeyDown(OpenQA.Selenium.Keys.Control).Build().Perform();
                action.KeyDown("c").Build().Perform();
                action.KeyUp("c").Build().Perform();
                action.KeyUp(OpenQA.Selenium.Keys.Control).Build().Perform();
                waitBar(1, "Извлечение позиции 3");
                action.KeyDown(OpenQA.Selenium.Keys.Escape).Build().Perform();
                action.KeyUp(OpenQA.Selenium.Keys.Escape).Build().Perform();

                posit = Clipboard.GetText();
                parsePos(posit);
                waitBar(1, "Получение");
            }
            catch (Exception ex1) { logBox.Invoke(new Action(() => logBox.AppendText("## " + ex1.Message + Environment.NewLine))); }

        }
        void parsePos(string line)
        {
            outcostBox.Text = "null";
            codeBox.Clear();
            itemBox.Clear();
            countBox.Clear();
            incostBox.Clear();

            //driver.Quit();
            codeBox.Invoke(new Action(() => codeBox.Clear()));
            //waitBar(10, "Извлечение позиции 5");
            tabLine = line.Split('	');
            //waitBar(10, "Деление");
            foreach (string ln in tabLine)
            {
                textBox3.AppendText(ln + "|");
                // waitBar(10, "Вывод");
            }
            //waitBar(1, "Заполнение");
            codeBox.Invoke(new Action(() => codeBox.Text = tabLine[0]));
            itemBox.Invoke(new Action(() => itemBox.Text = tabLine[2]));
            incostBox.Invoke(new Action(() => incostBox.Text = tabLine[5]));
            outcostBox.Invoke(new Action(() => outcostBox.Text = tabLine[7]));
            countBox.Invoke(new Action(() => countBox.Text = tabLine[13]));
        }
        void startup()
        {

            logBox.Invoke(new Action(() => logBox.AppendText("> Инициализация" + Environment.NewLine)));

            MinimizeWindow();

            tmr.Elapsed += tmr_t; //настройки второпоточного таймера
            tmr.AutoReset = true;
            tmr.Enabled = true;

            if (!debug)
                try
                {

                    this.Invoke(new Action(() => this.Activate()));
                    waitBar(10, "Запуск Chrome");
                    logBox.Invoke(new Action(() => logBox.AppendText("> Открытие таблицы" + Environment.NewLine)));
                    driver.Navigate().GoToUrl("https://docs.google.com/spreadsheets/d/1yWta8YYzee1AvAfhPqmjZnBw-udgA6uBiQD1Si5r7Dk/edit#gid=0");

                    waitBar(70, "Загрузка авторизации");
                    logBox.Invoke(new Action(() => logBox.AppendText("> Авторизация" + Environment.NewLine)));
                    driver.FindElement(By.XPath("//input[@type='email']")).SendKeys(accName + Environment.NewLine);

                    waitBar(70, "Прогрузка экрана авторизации");
                    driver.FindElement(By.XPath("//input[@type='password']")).SendKeys(accPwd + Environment.NewLine);
                    logBox.Invoke(new Action(() => logBox.AppendText("> Авторизация 2" + Environment.NewLine)));
                    waitBar(50, "Поиск подтверждения ");
                    try
                    {
                        logBox.Invoke(new Action(() => logBox.AppendText("> Авторизация 3" + Environment.NewLine)));
                        driver.FindElement(By.XPath("//*[text()[contains(.,'резервный')]]")).Click();
                        waitBar(20, "Процедура подтверждения 1");
                        logBox.Invoke(new Action(() => logBox.AppendText("> Авторизация 4" + Environment.NewLine)));
                        driver.FindElement(By.XPath("//input[@type='tel']")).SendKeys(accTel + Environment.NewLine);
                        waitBar(20, "Процедура подтверждения 2");
                        waitBar(100, "Загрузка таблицы");
                    }
#pragma warning disable CS0168 // Переменная объявлена, но не используется
                    catch (Exception ex1) { logBox.Invoke(new Action(() => logBox.AppendText("> Подтверждение не требуется" + Environment.NewLine))); }
#pragma warning restore CS0168 // Переменная объявлена, но не используется

                    waitBar(1, "Загрузка таблицы");
                    logBox.Invoke(new Action(() => logBox.AppendText("> Начало работы" + Environment.NewLine)));

                }
                catch (Exception ex1)
                { logBox.Invoke(new Action(() => logBox.AppendText(ex1.Message + Environment.NewLine))); }

            restartBtn.Invoke(new Action(() => restartBtn.Enabled = true));
            newDayBtn.Invoke(new Action(() => newDayBtn.Enabled = true));
        }
        void addPosition()
        {
            currentGood = new good();

            if (!activeTicket) NewTiBtn_Click(this, null);

            currentGoodCount++;
            costDD.Value = Convert.ToInt32(outcostBox.Text);
            //textBox1.Text = currentTicket.
            //ID код наименование цена стоимость количество разница
            currentGood.content[0] = Convert.ToString(currentGoodCount);
            currentGood.content[1] = codeBox.Text;
            currentGood.content[2] = itemBox.Text;
            currentGood.content[3] = outcostBox.Text;
            currentGood.content[4] = outcostBox.Text;
            currentGood.content[5] = Convert.ToString(currentPcsCount);
            currentTicket.goods.Add(currentGood);
            //debug
            textBox1.AppendText(currentGood.content[0]+ currentGood.content[2]+ Environment.NewLine);
            clrTiBtn.Enabled = true;



            
            updateTicket();

        }

        void updateTicket()
        {
            buyBox.Items.Clear();
            buyCountBox.Items.Clear();
            BuyCostBox.Items.Clear();
            gdsCntLbl.Text = "0";
            ttlCstLbl.Text = "0";
            posCntLbl.Text = "0";
            totalDiscLbl.Text = "0";
            
            for (int i = 0; i< currentTicket.goods.Count; i++)
            { 
                //ID код наименование цена стоимость количество разница
                buyBox.Items.Add((currentTicket.goods[i].content[0]) + "|" + currentTicket.goods[i].content[2]);
                buyCountBox.Items.Add(currentTicket.goods[i].content[5] + "шт.");
                BuyCostBox.Items.Add(currentTicket.goods[i].content[4]+"р.");
                //textBox1.AppendText(">"+currentTicket.goods[i].content[0] + currentTicket.goods[i].content[2] + Environment.NewLine);
                //gd.content[0] = Convert.ToString(Convert.ToInt32(gd.content[0]) + 1);
                ttlCstLbl.Text = Convert.ToString(Convert.ToInt32(ttlCstLbl.Text) + Convert.ToInt32(currentTicket.goods[i].content[4]));
                currentTicket.refresh();

                ticket tk = new ticket();
                tk.goods = currentTicket.goods;
                if (i > 0) posCntLbl.Text = Convert.ToString(i + 1 - tk.dupl(currentTicket.goods[i])); else posCntLbl.Text = "1";
                textBox1.AppendText(tk.dupl(currentTicket.goods[i]) +Environment.NewLine);
                gdsCntLbl.Text = Convert.ToString(Convert.ToInt32(gdsCntLbl.Text) + Convert.ToInt32(currentTicket.goods[i].content[5]));
                totalDiscLbl.Text = Convert.ToString(Convert.ToInt32(totalDiscLbl.Text) + (Convert.ToInt32(currentTicket.goods[i].content[3]) - Convert.ToInt32(currentTicket.goods[i].content[4])));
            }
        }   


        int rRound(int num, int to)
        {
            int tmp;
            if ((tmp = num % to) != 0)
                num += num > -1 ? (to - tmp) : -tmp;
            return num;

        }
        #endregion
        #region внутренние функции объектов

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                findElement(codeBox.Text);
            }
        }
        private void RestartBtn_Click(object sender, EventArgs e)
        {
            restartBtn.Invoke(new Action(() => restartBtn.Enabled = false));
            logBox.AppendText("> Перезапуск Вкладки ");
            startup();
            restartBtn.Invoke(new Action(() => restartBtn.Enabled = true));
        }

        void selectGood(int index)
        {
            //ID код наименование цена стоимость количество разница

            ticketEdit.Enabled = true;
            currentGood = new good();
            currentGood = currentTicket.goods[index];
            posEditLbl.Text = Convert.ToString(index + 1);

            costDD.Value = Convert.ToInt32(currentGood.content[4]);
            countDD.Value = Convert.ToInt32(currentGood.content[5]);
        }




        #endregion
        #region Второй поток
        private void Thread2_DoWork(object sender, DoWorkEventArgs e)
        {
            restartBtn.Invoke(new Action(() => restartBtn.Enabled = false));
            startup();
        }
        private void Thread2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }
        #endregion
        #region функции формы
        public Form1()
        {
            InitializeComponent();
            opt.AddArgument("--window-size=100,100");
            driver = new ChromeDriver(opt);

            if (debug) debugBox.Show();
            thread2.WorkerReportsProgress = true;
            thread2.WorkerSupportsCancellation = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        { }
        //Начальный сценарий
        private void Form1_Shown(object sender, EventArgs e)
        {

            thread2.RunWorkerAsync();
            hkey.Pressed += (o, d) => { endPress(); d.Handled = true; };
            hkey.Register(this);//Hotkey init
            this.Activate();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isOpen)
            {
                hkey.Unregister();
                driver.Quit();
            }
            else
            {
                e.Cancel=true;
                MessageBox.Show(
                    "Закройте смену перед выходом",
                    "Смена не закрыта",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
             }
        }

        #endregion
        #region мелкие функции объектов интерфейса
        private void P3Btn_Click(object sender, EventArgs e)
        { discDD.Value = 3; }
        private void P5Btn_Click(object sender, EventArgs e)
        { discDD.Value = 5; }
        private void P10Btn_Click(object sender, EventArgs e)
        { discDD.Value = 10; }
        private void P15Btn_Click(object sender, EventArgs e)
        { discDD.Value = 15; }
        private void PBxbtn_Click(object sender, EventArgs e)
        { costDD.Value = Convert.ToInt32(incostBox.Text); }
        private void CostDD_ValueChanged(object sender, MouseEventArgs e)
        { CostDD_ValueChanged1(this, null); }
        private void R0btn_Click(object sender, EventArgs e)
        { costDD.Value = Convert.ToInt32(r0btn.Text); }
        private void R5Btn_Click(object sender, EventArgs e)
        { costDD.Value = Convert.ToInt32(r5btn.Text); }
        private void R10btn_Click(object sender, EventArgs e)
        { costDD.Value = Convert.ToInt32(r10btn.Text); }
        private void R50btn_Click(object sender, EventArgs e)
        { costDD.Value = Convert.ToInt32(r50btn.Text); }
        private void R100btn_Click(object sender, EventArgs e)
        { costDD.Value = Convert.ToInt32(r100btn.Text); }
        private void GdsCntLbl_Click(object sender, EventArgs e)
        {

        }
        private void Label10_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region более важные функции элементов интерфейса
        private void OutcostBox_TextChanged(object sender, EventArgs e)
        {
            if (outcostBox.Text != "null")
            {
                if (autoAdd.Checked)
                {
                    addPosition();
                }
            }
        }
        private void CostDD_ValueChanged1(object sender, EventArgs e)
        {
            int tmp = Convert.ToInt32(Math.Round(Convert.ToInt32(outcostBox.Text) - (Convert.ToInt32(outcostBox.Text) * Convert.ToInt32(discDD.Value) * 0.01)));
            r0btn.Text = Convert.ToString(tmp);
            r5btn.Text = Convert.ToString(rRound(tmp, 5));
            r10btn.Text = Convert.ToString(rRound(tmp, 10));
            r50btn.Text = Convert.ToString(rRound(tmp, 50));
            r100btn.Text = Convert.ToString(rRound(tmp, 100));
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            addPosition();
        }
        private void NewTiBtn_Click(object sender, EventArgs e)
        {
            activeTicket = true;

            ticket currentTicket = new ticket();

            ticketCount++;
            ticketNumLbl.Text = Convert.ToString(ticketCount);

            closeTiBtn.Enabled = true;
            ticketEdit.Enabled = true;

            buyBox.Items.Clear();
            BuyCostBox.Items.Clear();
            buyCountBox.Items.Clear();
            currentTicket.goods.Clear();

            currentGoodCount = 0;
            discCount = 0;
            costDD.Value = 0;
            countDD.Value = 0;

            this.Update();
            ticketEdit.Enabled = false;

        }
        private void NewDayBtn_Click(object sender, EventArgs e)
        {
            isOpen = true;
            totalCash = 0;
            ticketCount = 0;
            midTiCount = 0;
            newTiBtn.Enabled = true;
            newDayBtn.Enabled = false;
            closeDayBtn.Enabled = true;
            logBox.AppendText("> Смена открыта"+Environment.NewLine);
        }
        private void CloseTiBtn_Click(object sender, EventArgs e)
        {
            ticket tt = new ticket();
            currentTicket.preheader = "============TheClouders VapeShop ============";
            currentTicket.header = "=========Чек № " + ticketNumLbl.Text + " ==============";

            currentTicket.footer = "=========footer============================";
            currentTicket.postfooter = "======postfooter===============================";
            currentTicket.timeStamp = Convert.ToString(DateTime.Now);
            if (currentTicket.goods.Count > 0) {tt = currentTicket; ticketList.Add(tt); }

            currentTicket = new ticket();

            showTicketsBtn.Enabled = true;
            activeTicket = false;
            ticketNumLbl.Text = "-";
            goodCount += Convert.ToInt32(gdsCntLbl.Text);
            totalCash += Convert.ToInt32(ttlCstLbl.Text);
            discCount += Convert.ToInt32(totalDiscLbl.Text);

            if (ticketCount > 0) midTiCount = totalCash / ticketCount;

            totCashLbl.Text = Convert.ToString(totalCash);
            midTiLbl.Text = Convert.ToString(midTiCount);
            totTiLbl.Text = Convert.ToString(ticketCount);
            totGdLbl.Text = Convert.ToString(goodCount);
            totDsLbl.Text = Convert.ToString(discCount);

            clrTiBtn.Enabled = false;
            ttlCstLbl.Text = "0";
            posCntLbl.Text = "0";
            gdsCntLbl.Text = "0";
            totalDiscLbl.Text = "0";
            posEditLbl.Text = "0";
            costDD.Value = 0;
            countDD.Value = 0;
            updateTicket();
            this.Update();
            ticketEdit.Enabled = false;
        }
        private void SaveGoodBtn_Click(object sender, EventArgs e)
        {
            //ID код наименование цена стоимость количество разница
            if (currentTicket.goods.Count > 0)
            {
                currentGood.content[4] = Convert.ToString(costDD.Value);
                currentGood.content[5] = Convert.ToString(countDD.Value);
                currentTicket.goods[Convert.ToInt32(currentGood.content[0]) - 1] = currentGood;
                updateTicket();
            }
            else
                posEditLbl.Text = "0";

            costDD.Value = 0;
            countDD.Value = 0;
            ticketEdit.Enabled = false;
        }
        private void ClrTiBtn_Click(object sender, EventArgs e)
        {

            currentTicket = new ticket();
            clrTiBtn.Enabled = false;
            ttlCstLbl.Text = "0";
            posCntLbl.Text = "0";
            gdsCntLbl.Text = "0";
            totalDiscLbl.Text = "0";
            posEditLbl.Text = "0";
            costDD.Value = 0;
            countDD.Value = 0;
            this.Update();
            ticketEdit.Enabled = false;
            updateTicket();
        }
        private void DelGoodBtn_Click(object sender, EventArgs e)
        {
            currentTicket.goods.Remove(currentTicket.goods[Convert.ToInt32(currentGood.content[0]) - 1]);
            currentTicket.refresh();
            updateTicket();
            costDD.Value = 0;
            countDD.Value = 0;
            posEditLbl.Text = "0";
            this.Update();
            ticketEdit.Enabled = false;
        }
        private void ShowTicketsBtn_Click(object sender, EventArgs e)
        {
            tickets tiForm = new tickets();
            tiForm.get(ticketList);
            tiForm.Show();
        }

        private void CloseDayBtn_Click(object sender, EventArgs e)
        {
            if (ticketCount > 0)
            {
                List<string> lines = new List<string>();
                int dbl = 0;
                string fPath = logPath + "log" + DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + "_" + DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second + "_" + DateTime.Now.Millisecond + ".txt";
                //string fPath = logPath + "log" + DateTime.Now + ".txt";
                foreach (ticket t in ticketList)
                {
                    lines.AddRange(t.getTicket());
                }
                try { Directory.CreateDirectory(logPath); }
                catch (Exception ex) { }
                try
                {
                    File.WriteAllLines(fPath, lines);
                }
                catch (Exception ex) { logBox.AppendText(ex.Message + Environment.NewLine); }
            }

            ticketList = new List<ticket>();
            ClrTiBtn_Click(this, null);
            isOpen = false;
            newTiBtn.Enabled = false;
            closeTiBtn.Enabled = false;
            clrTiBtn.Enabled = false;
            newDayBtn.Enabled = true;

            totalCash = 0;
            ticketCount = 0;
            midTiCount = 0;
            goodCount = 0;
            discCount = 0;

            totCashLbl.Text = Convert.ToString(totalCash);
            midTiLbl.Text = Convert.ToString(midTiCount);
            totTiLbl.Text = Convert.ToString(ticketCount);
            totGdLbl.Text = Convert.ToString(goodCount);
            totDsLbl.Text = Convert.ToString(discCount);


            this.Update();
            logBox.AppendText("> Смена закрыта" + Environment.NewLine);
        }

        #region выделение строк
        int selectedIndex = 0;
        private void BuyBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndex = buyBox.SelectedIndex;
            BuyCostBox.SelectedIndex = selectedIndex;
            buyCountBox.SelectedIndex = selectedIndex;
            selectGood(selectedIndex);
            ticketEdit.Enabled = true;
        }
        private void BuyCountBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndex = buyCountBox.SelectedIndex;
            buyBox.SelectedIndex = selectedIndex;
            BuyCostBox.SelectedIndex = selectedIndex;
            selectGood(selectedIndex);
            ticketEdit.Enabled = true;
        }
        private void BuyCostBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndex = BuyCostBox.SelectedIndex;
            buyBox.SelectedIndex = selectedIndex;
            buyCountBox.SelectedIndex = selectedIndex;
            selectGood(selectedIndex);
            ticketEdit.Enabled = true;
        }
        #endregion

        #endregion
        //debug
        private void Button6_Click(object sender, EventArgs e)
        {
            parsePos(textBox2.Text);
        }//debug

    }

    #region чек
    public class ticket
        {
        public string preheader;
        public string header;
        
        public List<good> goods = new List<good>();
        public string footer;
        public string timeStamp;
        public string postfooter;
        int posCnt = 0;
        int summCnt = 0;
        int diffCnt = 0;

        public void refresh()
        {
            for(int i = 0; i<goods.Count;i++)
            {
                goods[i].content[0] = Convert.ToString(i+1);
            }
        }


        public int dupl(good gd)
        {
            int dup = 0;
            foreach (good gdd in goods)
            {
               if ((gd.content[2] == gdd.content[2])&&(gd != gdd)) dup++;
            }
            return dup;
        }

        public List<string> getTicket()
        {
            posCnt = 0;
            summCnt = 0;

            List <string> outData = new List<string>();
            outData.Add(preheader);
            outData.Add(timeStamp);
            outData.Add(header);
            foreach (good gd in goods)
            {
                //ID код наименование цена стоимость количество разница
                outData.Add(Convert.ToInt32(posCnt+1)+"| " + gd.content[2] + " " + gd.content[4] + "Руб. " + gd.content[5]+"шт. ");
                posCnt += Convert.ToInt32(gd.content[5]);
                summCnt += Convert.ToInt32(gd.content[4]);
            }
            outData.Add("==== Товаров: "+ posCnt + " ==== Итого: "+summCnt + " ====");
            outData.Add(footer);
            outData.Add(postfooter);
            outData.Add(" ");

            return outData;
        }


 
        public MyEnumerator GetEnumerator()
        {
            return new MyEnumerator(this);
        }
    }
    #endregion
    #region enum
    // Declare the enumerator class:  
    public class MyEnumerator
    {


        int nIndex;
        ticket collection;
        public MyEnumerator(ticket coll)
        {
            collection = coll;
            nIndex = -1;
        }

        public bool MoveNext()
        {
            nIndex++;
            return (nIndex < collection.goods.Count);
        }

        public good Current => collection.goods[nIndex];
    }

    #endregion
    #region позиция
    public class good
    {
        //ID код наименование цена стоимость количество разница
        public string[] content = new string[7];
        public void lost()
        {
            content[6] = Convert.ToString( Convert.ToInt32(content[3]) - Convert.ToInt32(content[4]));
        }
        public void clear()
        {
            content[0] = "";
            content[1] = "";
            content[2] = "";
            content[3] = "";
            content[4] = "";
            content[5] = "";
            content[6] = "";
        }
    }
    #endregion
    #region keybind
    /// <summary>
    /// Specifies key modifiers.
    /// </summary>
    [Flags]
    public enum KeyModifiers : uint
    {
        /// <summary>
        /// Empty modifiers
        /// </summary>
        None = 0x0000,
        /// <summary>
        /// Either ALT key must be held down.
        /// </summary>
        Alt = 0x0001,
        /// <summary>
        /// Either CTRL key must be held down.
        /// </summary>
        Control = 0x0002,
        /// <summary>
        /// Either SHIFT key must be held down.
        /// </summary>
        Shift = 0x0004,
        /// <summary>
        /// Either WINDOWS key was held down. 
        /// These keys are labeled with the Windows logo. 
        /// Keyboard shortcuts that involve the WINDOWS key are reserved for use by the operating system.
        /// </summary>
        Windows = 0x0008,
        //IgnoreAllModifier   = 0x0400,
        //OnKeyUp             = 0x0800,
        //MouseRight          = 0x4000,
        //MouseLeft           = 0x8000,
    }

    public class HotKey : IMessageFilter, IDisposable
    {
        #region Extern
        const int WM_HOTKEY = 0x312;
        const int ERROR_HOTKEY_ALREADY_REGISTERED = 0x581;

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool RegisterHotKey(IntPtr hWnd, IntPtr id, KeyModifiers fsModifiers,System.Windows.Forms.Keys vk);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool UnregisterHotKey(IntPtr hWnd, IntPtr id);
        #endregion

        private IntPtr windowHandle;
        public event HandledEventHandler Pressed;

        public HotKey()
            : this(System.Windows.Forms.Keys.None, KeyModifiers.None)
        {
        }

        public HotKey(System.Windows.Forms.Keys keyCode, KeyModifiers modifiers)
        {
            this.KeyCode = keyCode;
            this.Modifiers = modifiers;
            Application.AddMessageFilter(this);
        }

        ~HotKey()
        {
            this.Dispose();
        }

        public void Dispose()
        {
            if (this.IsRegistered)
                this.Unregister();

            this.windowHandle = IntPtr.Zero;
            this.Modifiers = KeyModifiers.None;
            this.KeyCode = System.Windows.Forms.Keys.None;
            this.Tag = 0;
        }

        private bool OnPressed()
        {
            HandledEventArgs e = new HandledEventArgs(false);
            if (this.Pressed != null)
                this.Pressed(this, e);

            return e.Handled;
        }

        /// <summary>
        /// Filters out a message before it is dispatched.
        /// </summary>
        /// <param name="message">
        /// The message to be dispatched. You cannot modify this message.
        /// </param>
        /// <returns>
        /// true to filter the message and stop it from being dispatched;
        /// false to allow the message to continue to the next filter or control.
        /// </returns>
        public bool PreFilterMessage(ref Message message)
        {
            if (message.Msg != WM_HOTKEY || !this.IsRegistered)
                return false;

            if (message.WParam == this.Guid)
                return this.OnPressed();

            return false;
        }

        /// <summary>
        /// Defines a system-wide hot key.
        /// </summary>
        /// <param name="windowControl">
        /// A handle to the window that will receive messages generated by the hot key. 
        /// </param>
        public void Register(Control window)
        {
            if (this.IsRegistered)
                throw new NotSupportedException("You cannot register a hotkey that is already registered");

            if (this.IsEmpty)
                throw new NotSupportedException("You cannot register an empty hotkey");

            if (window.IsDisposed)
                throw new ArgumentNullException("window");

            this.windowHandle = window.Handle;

            if (!RegisterHotKey(this.windowHandle, this.Guid, this.Modifiers, this.KeyCode))
            {
                if (Marshal.GetLastWin32Error() != ERROR_HOTKEY_ALREADY_REGISTERED)
                    throw new Win32Exception();
            }
            this.IsRegistered = true;
        }

        /// <summary>
        /// Frees a hot key previously registered by the calling thread.
        /// </summary>
        public void Unregister()
        {
            if (!this.IsRegistered)
                return;

            if (!UnregisterHotKey(this.windowHandle, this.Guid))
                throw new Win32Exception();

            this.IsRegistered = false;
        }

        public bool HasModifier(KeyModifiers modifiers)
        {
            return (this.Modifiers & modifiers) != 0;
        }

        public static HotKey Parse(object content)
        {
            if (content == null)
                return new HotKey();

            return Parse(content.ToString());
        }

        #region Fields

        private IntPtr Guid
        {
            get { return new IntPtr((int)Modifiers << 16 | (int)KeyCode & 0xFFFF); }
        }

        public bool IsEmpty
        {
            get { return (this.KeyCode == System.Windows.Forms.Keys.None); }
        }

        public bool IsRegistered { get; private set; }

        public KeyModifiers Modifiers { get; private set; }

        public System.Windows.Forms.Keys KeyCode { get; private set; }

        public int Tag { get; set; }

        #endregion
    }
    #endregion
   

}

