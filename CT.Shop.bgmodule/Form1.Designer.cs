namespace CT.Shop.bgmodule
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.codeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.itemBox = new System.Windows.Forms.TextBox();
            this.logBox = new System.Windows.Forms.TextBox();
            this.pauseBar = new System.Windows.Forms.ProgressBar();
            this.loadLbl = new System.Windows.Forms.Label();
            this.thread2 = new System.ComponentModel.BackgroundWorker();
            this.restartBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.incostBox = new System.Windows.Forms.TextBox();
            this.outcostBox = new System.Windows.Forms.TextBox();
            this.countBox = new System.Windows.Forms.TextBox();
            this.autoAdd = new System.Windows.Forms.CheckBox();
            this.buyBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.posEditLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.countDD = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.costDD = new System.Windows.Forms.NumericUpDown();
            this.ticketEdit = new System.Windows.Forms.GroupBox();
            this.r5btn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.discDD = new System.Windows.Forms.NumericUpDown();
            this.saveGoodBtn = new System.Windows.Forms.Button();
            this.delGoodBtn = new System.Windows.Forms.Button();
            this.r100btn = new System.Windows.Forms.Button();
            this.r50btn = new System.Windows.Forms.Button();
            this.r0btn = new System.Windows.Forms.Button();
            this.r10btn = new System.Windows.Forms.Button();
            this.p10Btn = new System.Windows.Forms.Button();
            this.pBxbtn = new System.Windows.Forms.Button();
            this.p15Btn = new System.Windows.Forms.Button();
            this.p5Btn = new System.Windows.Forms.Button();
            this.p3Btn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.posCntLbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gdsCntLbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ttlCstLbl = new System.Windows.Forms.Label();
            this.closeTiBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.showTicketsBtn = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.totDsLbl = new System.Windows.Forms.Label();
            this.totGdLbl = new System.Windows.Forms.Label();
            this.midTiLbl = new System.Windows.Forms.Label();
            this.totTiLbl = new System.Windows.Forms.Label();
            this.totCashLbl = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.totalDiscLbl = new System.Windows.Forms.Label();
            this.newTiBtn = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.newDayBtn = new System.Windows.Forms.Button();
            this.closeDayBtn = new System.Windows.Forms.Button();
            this.changeUserBtn = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.clrTiBtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.waitThread = new System.ComponentModel.BackgroundWorker();
            this.userBox = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.ticketNumLbl = new System.Windows.Forms.Label();
            this.buyCountBox = new System.Windows.Forms.ListBox();
            this.BuyCostBox = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.debugBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.countDD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costDD)).BeginInit();
            this.ticketEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discDD)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.debugBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // codeBox
            // 
            this.codeBox.Location = new System.Drawing.Point(37, 6);
            this.codeBox.Name = "codeBox";
            this.codeBox.Size = new System.Drawing.Size(109, 20);
            this.codeBox.TabIndex = 0;
            this.codeBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Код:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Товар:";
            // 
            // itemBox
            // 
            this.itemBox.Location = new System.Drawing.Point(193, 6);
            this.itemBox.Name = "itemBox";
            this.itemBox.ReadOnly = true;
            this.itemBox.Size = new System.Drawing.Size(288, 20);
            this.itemBox.TabIndex = 3;
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(9, 105);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logBox.Size = new System.Drawing.Size(198, 59);
            this.logBox.TabIndex = 4;
            // 
            // pauseBar
            // 
            this.pauseBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pauseBar.ForeColor = System.Drawing.Color.Gold;
            this.pauseBar.Location = new System.Drawing.Point(104, 45);
            this.pauseBar.Name = "pauseBar";
            this.pauseBar.Size = new System.Drawing.Size(745, 10);
            this.pauseBar.TabIndex = 5;
            // 
            // loadLbl
            // 
            this.loadLbl.AutoSize = true;
            this.loadLbl.Location = new System.Drawing.Point(104, 29);
            this.loadLbl.Name = "loadLbl";
            this.loadLbl.Size = new System.Drawing.Size(54, 13);
            this.loadLbl.TabIndex = 6;
            this.loadLbl.Text = "Загрузка";
            // 
            // thread2
            // 
            this.thread2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Thread2_DoWork);
            this.thread2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.Thread2_ProgressChanged);
            // 
            // restartBtn
            // 
            this.restartBtn.Location = new System.Drawing.Point(9, 32);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(86, 23);
            this.restartBtn.TabIndex = 7;
            this.restartBtn.Text = "Перезапуск";
            this.restartBtn.UseVisualStyleBackColor = true;
            this.restartBtn.Click += new System.EventHandler(this.RestartBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(487, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Вх:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(564, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Вых:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(649, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ост:";
            // 
            // incostBox
            // 
            this.incostBox.Location = new System.Drawing.Point(505, 6);
            this.incostBox.Name = "incostBox";
            this.incostBox.ReadOnly = true;
            this.incostBox.Size = new System.Drawing.Size(53, 20);
            this.incostBox.TabIndex = 3;
            this.incostBox.Text = "0";
            // 
            // outcostBox
            // 
            this.outcostBox.Location = new System.Drawing.Point(590, 6);
            this.outcostBox.Name = "outcostBox";
            this.outcostBox.ReadOnly = true;
            this.outcostBox.Size = new System.Drawing.Size(53, 20);
            this.outcostBox.TabIndex = 3;
            this.outcostBox.Text = "0";
            this.outcostBox.TextChanged += new System.EventHandler(this.OutcostBox_TextChanged);
            // 
            // countBox
            // 
            this.countBox.Location = new System.Drawing.Point(675, 6);
            this.countBox.Name = "countBox";
            this.countBox.ReadOnly = true;
            this.countBox.Size = new System.Drawing.Size(53, 20);
            this.countBox.TabIndex = 3;
            this.countBox.Text = "0";
            // 
            // autoAdd
            // 
            this.autoAdd.AutoSize = true;
            this.autoAdd.Checked = true;
            this.autoAdd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoAdd.Location = new System.Drawing.Point(735, 8);
            this.autoAdd.Name = "autoAdd";
            this.autoAdd.Size = new System.Drawing.Size(74, 17);
            this.autoAdd.TabIndex = 8;
            this.autoAdd.Text = "Автовнос";
            this.autoAdd.UseVisualStyleBackColor = true;
            // 
            // buyBox
            // 
            this.buyBox.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyBox.FormattingEnabled = true;
            this.buyBox.Items.AddRange(new object[] {
            "Откройте смену",
            "Создайте новый чек",
            "Пробейте товар"});
            this.buyBox.Location = new System.Drawing.Point(217, 75);
            this.buyBox.Name = "buyBox";
            this.buyBox.Size = new System.Drawing.Size(302, 251);
            this.buyBox.TabIndex = 9;
            this.buyBox.SelectedIndexChanged += new System.EventHandler(this.BuyBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Позиция:";
            // 
            // posEditLbl
            // 
            this.posEditLbl.AutoSize = true;
            this.posEditLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.posEditLbl.Location = new System.Drawing.Point(137, 16);
            this.posEditLbl.Name = "posEditLbl";
            this.posEditLbl.Size = new System.Drawing.Size(14, 13);
            this.posEditLbl.TabIndex = 2;
            this.posEditLbl.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Цена:";
            // 
            // countDD
            // 
            this.countDD.Location = new System.Drawing.Point(164, 39);
            this.countDD.Name = "countDD";
            this.countDD.Size = new System.Drawing.Size(53, 20);
            this.countDD.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(119, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Кол-во:";
            // 
            // costDD
            // 
            this.costDD.Location = new System.Drawing.Point(53, 41);
            this.costDD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.costDD.Name = "costDD";
            this.costDD.Size = new System.Drawing.Size(53, 20);
            this.costDD.TabIndex = 10;
            this.costDD.ValueChanged += new System.EventHandler(this.CostDD_ValueChanged1);
            this.costDD.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CostDD_ValueChanged);
            // 
            // ticketEdit
            // 
            this.ticketEdit.Controls.Add(this.r5btn);
            this.ticketEdit.Controls.Add(this.label6);
            this.ticketEdit.Controls.Add(this.costDD);
            this.ticketEdit.Controls.Add(this.label13);
            this.ticketEdit.Controls.Add(this.label12);
            this.ticketEdit.Controls.Add(this.label7);
            this.ticketEdit.Controls.Add(this.discDD);
            this.ticketEdit.Controls.Add(this.countDD);
            this.ticketEdit.Controls.Add(this.label8);
            this.ticketEdit.Controls.Add(this.posEditLbl);
            this.ticketEdit.Controls.Add(this.saveGoodBtn);
            this.ticketEdit.Controls.Add(this.delGoodBtn);
            this.ticketEdit.Controls.Add(this.r100btn);
            this.ticketEdit.Controls.Add(this.r50btn);
            this.ticketEdit.Controls.Add(this.r0btn);
            this.ticketEdit.Controls.Add(this.r10btn);
            this.ticketEdit.Controls.Add(this.p10Btn);
            this.ticketEdit.Controls.Add(this.pBxbtn);
            this.ticketEdit.Controls.Add(this.p15Btn);
            this.ticketEdit.Controls.Add(this.p5Btn);
            this.ticketEdit.Controls.Add(this.p3Btn);
            this.ticketEdit.Location = new System.Drawing.Point(626, 61);
            this.ticketEdit.Name = "ticketEdit";
            this.ticketEdit.Size = new System.Drawing.Size(223, 169);
            this.ticketEdit.TabIndex = 11;
            this.ticketEdit.TabStop = false;
            this.ticketEdit.Text = "Редактирование";
            // 
            // r5btn
            // 
            this.r5btn.Location = new System.Drawing.Point(45, 96);
            this.r5btn.Name = "r5btn";
            this.r5btn.Size = new System.Drawing.Size(45, 23);
            this.r5btn.TabIndex = 11;
            this.r5btn.Text = "0";
            this.r5btn.UseVisualStyleBackColor = true;
            this.r5btn.Click += new System.EventHandler(this.R5Btn_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(0, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(220, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Без окр. /  до 5  /  до 10  /  до 50  / до 100";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Скидка:";
            // 
            // discDD
            // 
            this.discDD.Location = new System.Drawing.Point(53, 67);
            this.discDD.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.discDD.Name = "discDD";
            this.discDD.Size = new System.Drawing.Size(53, 20);
            this.discDD.TabIndex = 10;
            this.discDD.ValueChanged += new System.EventHandler(this.CostDD_ValueChanged1);
            // 
            // saveGoodBtn
            // 
            this.saveGoodBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.saveGoodBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveGoodBtn.Location = new System.Drawing.Point(3, 140);
            this.saveGoodBtn.Name = "saveGoodBtn";
            this.saveGoodBtn.Size = new System.Drawing.Size(148, 23);
            this.saveGoodBtn.TabIndex = 7;
            this.saveGoodBtn.Text = "Сохранить";
            this.saveGoodBtn.UseVisualStyleBackColor = false;
            this.saveGoodBtn.Click += new System.EventHandler(this.SaveGoodBtn_Click);
            // 
            // delGoodBtn
            // 
            this.delGoodBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.delGoodBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delGoodBtn.Location = new System.Drawing.Point(154, 140);
            this.delGoodBtn.Name = "delGoodBtn";
            this.delGoodBtn.Size = new System.Drawing.Size(63, 23);
            this.delGoodBtn.TabIndex = 7;
            this.delGoodBtn.Text = "Удалить";
            this.delGoodBtn.UseVisualStyleBackColor = false;
            this.delGoodBtn.Click += new System.EventHandler(this.DelGoodBtn_Click);
            // 
            // r100btn
            // 
            this.r100btn.Location = new System.Drawing.Point(177, 96);
            this.r100btn.Name = "r100btn";
            this.r100btn.Size = new System.Drawing.Size(45, 23);
            this.r100btn.TabIndex = 7;
            this.r100btn.Text = "0";
            this.r100btn.UseVisualStyleBackColor = true;
            this.r100btn.Click += new System.EventHandler(this.R100btn_Click);
            // 
            // r50btn
            // 
            this.r50btn.Location = new System.Drawing.Point(133, 96);
            this.r50btn.Name = "r50btn";
            this.r50btn.Size = new System.Drawing.Size(45, 23);
            this.r50btn.TabIndex = 7;
            this.r50btn.Text = "0";
            this.r50btn.UseVisualStyleBackColor = true;
            this.r50btn.Click += new System.EventHandler(this.R50btn_Click);
            // 
            // r0btn
            // 
            this.r0btn.Location = new System.Drawing.Point(1, 96);
            this.r0btn.Name = "r0btn";
            this.r0btn.Size = new System.Drawing.Size(45, 23);
            this.r0btn.TabIndex = 7;
            this.r0btn.Text = "0";
            this.r0btn.UseVisualStyleBackColor = true;
            this.r0btn.Click += new System.EventHandler(this.R0btn_Click);
            // 
            // r10btn
            // 
            this.r10btn.Location = new System.Drawing.Point(89, 96);
            this.r10btn.Name = "r10btn";
            this.r10btn.Size = new System.Drawing.Size(45, 23);
            this.r10btn.TabIndex = 7;
            this.r10btn.Text = "0";
            this.r10btn.UseVisualStyleBackColor = true;
            this.r10btn.Click += new System.EventHandler(this.R10btn_Click);
            // 
            // p10Btn
            // 
            this.p10Btn.Location = new System.Drawing.Point(138, 65);
            this.p10Btn.Name = "p10Btn";
            this.p10Btn.Size = new System.Drawing.Size(27, 23);
            this.p10Btn.TabIndex = 7;
            this.p10Btn.Text = "10";
            this.p10Btn.UseVisualStyleBackColor = true;
            this.p10Btn.Click += new System.EventHandler(this.P10Btn_Click);
            // 
            // pBxbtn
            // 
            this.pBxbtn.Location = new System.Drawing.Point(190, 65);
            this.pBxbtn.Name = "pBxbtn";
            this.pBxbtn.Size = new System.Drawing.Size(27, 23);
            this.pBxbtn.TabIndex = 7;
            this.pBxbtn.Text = "Вх";
            this.pBxbtn.UseVisualStyleBackColor = true;
            this.pBxbtn.Click += new System.EventHandler(this.PBxbtn_Click);
            // 
            // p15Btn
            // 
            this.p15Btn.Location = new System.Drawing.Point(164, 65);
            this.p15Btn.Name = "p15Btn";
            this.p15Btn.Size = new System.Drawing.Size(27, 23);
            this.p15Btn.TabIndex = 7;
            this.p15Btn.Text = "15";
            this.p15Btn.UseVisualStyleBackColor = true;
            this.p15Btn.Click += new System.EventHandler(this.P15Btn_Click);
            // 
            // p5Btn
            // 
            this.p5Btn.Location = new System.Drawing.Point(124, 65);
            this.p5Btn.Name = "p5Btn";
            this.p5Btn.Size = new System.Drawing.Size(15, 23);
            this.p5Btn.TabIndex = 7;
            this.p5Btn.Text = "5";
            this.p5Btn.UseVisualStyleBackColor = true;
            this.p5Btn.Click += new System.EventHandler(this.P5Btn_Click);
            // 
            // p3Btn
            // 
            this.p3Btn.Location = new System.Drawing.Point(110, 65);
            this.p3Btn.Name = "p3Btn";
            this.p3Btn.Size = new System.Drawing.Size(15, 23);
            this.p3Btn.TabIndex = 7;
            this.p3Btn.Text = "3";
            this.p3Btn.UseVisualStyleBackColor = true;
            this.p3Btn.Click += new System.EventHandler(this.P3Btn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(815, 6);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(34, 23);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "+";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(212, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Позиций:";
            // 
            // posCntLbl
            // 
            this.posCntLbl.AutoSize = true;
            this.posCntLbl.Enabled = false;
            this.posCntLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.posCntLbl.Location = new System.Drawing.Point(289, 342);
            this.posCntLbl.Name = "posCntLbl";
            this.posCntLbl.Size = new System.Drawing.Size(18, 20);
            this.posCntLbl.TabIndex = 2;
            this.posCntLbl.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(214, 364);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Товаров:";
            this.label10.Click += new System.EventHandler(this.Label10_Click);
            // 
            // gdsCntLbl
            // 
            this.gdsCntLbl.AutoSize = true;
            this.gdsCntLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gdsCntLbl.Location = new System.Drawing.Point(289, 364);
            this.gdsCntLbl.Name = "gdsCntLbl";
            this.gdsCntLbl.Size = new System.Drawing.Size(18, 20);
            this.gdsCntLbl.TabIndex = 2;
            this.gdsCntLbl.Text = "0";
            this.gdsCntLbl.Click += new System.EventHandler(this.GdsCntLbl_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(393, 364);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Итого:";
            // 
            // ttlCstLbl
            // 
            this.ttlCstLbl.AutoSize = true;
            this.ttlCstLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ttlCstLbl.Location = new System.Drawing.Point(454, 364);
            this.ttlCstLbl.Name = "ttlCstLbl";
            this.ttlCstLbl.Size = new System.Drawing.Size(19, 20);
            this.ttlCstLbl.TabIndex = 2;
            this.ttlCstLbl.Text = "0";
            // 
            // closeTiBtn
            // 
            this.closeTiBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.closeTiBtn.Enabled = false;
            this.closeTiBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeTiBtn.Location = new System.Drawing.Point(534, 337);
            this.closeTiBtn.Name = "closeTiBtn";
            this.closeTiBtn.Size = new System.Drawing.Size(86, 47);
            this.closeTiBtn.TabIndex = 7;
            this.closeTiBtn.Text = "Завершить\r\nчек";
            this.closeTiBtn.UseVisualStyleBackColor = false;
            this.closeTiBtn.Click += new System.EventHandler(this.CloseTiBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.showTicketsBtn);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.totDsLbl);
            this.groupBox2.Controls.Add(this.totGdLbl);
            this.groupBox2.Controls.Add(this.midTiLbl);
            this.groupBox2.Controls.Add(this.totTiLbl);
            this.groupBox2.Controls.Add(this.totCashLbl);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Location = new System.Drawing.Point(626, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 95);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Статистика дня";
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(106, 60);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "null";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(106, 37);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "null";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // showTicketsBtn
            // 
            this.showTicketsBtn.Enabled = false;
            this.showTicketsBtn.Location = new System.Drawing.Point(106, 14);
            this.showTicketsBtn.Name = "showTicketsBtn";
            this.showTicketsBtn.Size = new System.Drawing.Size(111, 23);
            this.showTicketsBtn.TabIndex = 3;
            this.showTicketsBtn.Text = "Чеки";
            this.showTicketsBtn.UseVisualStyleBackColor = true;
            this.showTicketsBtn.Click += new System.EventHandler(this.ShowTicketsBtn_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 71);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(51, 13);
            this.label26.TabIndex = 2;
            this.label26.Text = "Скинуто:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 58);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(54, 13);
            this.label24.TabIndex = 2;
            this.label24.Text = "Продано:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 45);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Средний:";
            // 
            // totDsLbl
            // 
            this.totDsLbl.AutoSize = true;
            this.totDsLbl.Location = new System.Drawing.Point(57, 73);
            this.totDsLbl.Name = "totDsLbl";
            this.totDsLbl.Size = new System.Drawing.Size(13, 13);
            this.totDsLbl.TabIndex = 2;
            this.totDsLbl.Text = "0";
            // 
            // totGdLbl
            // 
            this.totGdLbl.AutoSize = true;
            this.totGdLbl.Location = new System.Drawing.Point(57, 60);
            this.totGdLbl.Name = "totGdLbl";
            this.totGdLbl.Size = new System.Drawing.Size(13, 13);
            this.totGdLbl.TabIndex = 2;
            this.totGdLbl.Text = "0";
            // 
            // midTiLbl
            // 
            this.midTiLbl.AutoSize = true;
            this.midTiLbl.Location = new System.Drawing.Point(57, 47);
            this.midTiLbl.Name = "midTiLbl";
            this.midTiLbl.Size = new System.Drawing.Size(13, 13);
            this.midTiLbl.TabIndex = 2;
            this.midTiLbl.Text = "0";
            // 
            // totTiLbl
            // 
            this.totTiLbl.AutoSize = true;
            this.totTiLbl.Location = new System.Drawing.Point(57, 33);
            this.totTiLbl.Name = "totTiLbl";
            this.totTiLbl.Size = new System.Drawing.Size(13, 13);
            this.totTiLbl.TabIndex = 2;
            this.totTiLbl.Text = "0";
            // 
            // totCashLbl
            // 
            this.totCashLbl.AutoSize = true;
            this.totCashLbl.Location = new System.Drawing.Point(57, 19);
            this.totCashLbl.Name = "totCashLbl";
            this.totCashLbl.Size = new System.Drawing.Size(13, 13);
            this.totCashLbl.TabIndex = 2;
            this.totCashLbl.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Чеков:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Касса:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(343, 341);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(114, 20);
            this.label14.TabIndex = 2;
            this.label14.Text = "Сумм. скидка:";
            // 
            // totalDiscLbl
            // 
            this.totalDiscLbl.AutoSize = true;
            this.totalDiscLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalDiscLbl.Location = new System.Drawing.Point(454, 342);
            this.totalDiscLbl.Name = "totalDiscLbl";
            this.totalDiscLbl.Size = new System.Drawing.Size(18, 20);
            this.totalDiscLbl.TabIndex = 2;
            this.totalDiscLbl.Text = "0";
            this.totalDiscLbl.Click += new System.EventHandler(this.GdsCntLbl_Click);
            // 
            // newTiBtn
            // 
            this.newTiBtn.BackColor = System.Drawing.Color.Honeydew;
            this.newTiBtn.Enabled = false;
            this.newTiBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newTiBtn.Location = new System.Drawing.Point(9, 170);
            this.newTiBtn.Name = "newTiBtn";
            this.newTiBtn.Size = new System.Drawing.Size(94, 47);
            this.newTiBtn.TabIndex = 7;
            this.newTiBtn.Text = "Новый \r\nчек";
            this.newTiBtn.UseVisualStyleBackColor = false;
            this.newTiBtn.Click += new System.EventHandler(this.NewTiBtn_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(12, 89);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(26, 13);
            this.label21.TabIndex = 6;
            this.label21.Text = "Лог";
            // 
            // newDayBtn
            // 
            this.newDayBtn.BackColor = System.Drawing.Color.Lime;
            this.newDayBtn.Enabled = false;
            this.newDayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newDayBtn.Location = new System.Drawing.Point(626, 337);
            this.newDayBtn.Name = "newDayBtn";
            this.newDayBtn.Size = new System.Drawing.Size(68, 47);
            this.newDayBtn.TabIndex = 7;
            this.newDayBtn.Text = "Открыть смену";
            this.newDayBtn.UseVisualStyleBackColor = false;
            this.newDayBtn.Click += new System.EventHandler(this.NewDayBtn_Click);
            // 
            // closeDayBtn
            // 
            this.closeDayBtn.BackColor = System.Drawing.Color.HotPink;
            this.closeDayBtn.Enabled = false;
            this.closeDayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeDayBtn.Location = new System.Drawing.Point(703, 337);
            this.closeDayBtn.Name = "closeDayBtn";
            this.closeDayBtn.Size = new System.Drawing.Size(68, 47);
            this.closeDayBtn.TabIndex = 7;
            this.closeDayBtn.Text = "Закрыть смену";
            this.closeDayBtn.UseVisualStyleBackColor = false;
            this.closeDayBtn.Click += new System.EventHandler(this.CloseDayBtn_Click);
            // 
            // changeUserBtn
            // 
            this.changeUserBtn.BackColor = System.Drawing.Color.Aqua;
            this.changeUserBtn.Enabled = false;
            this.changeUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeUserBtn.Location = new System.Drawing.Point(780, 337);
            this.changeUserBtn.Name = "changeUserBtn";
            this.changeUserBtn.Size = new System.Drawing.Size(69, 47);
            this.changeUserBtn.TabIndex = 7;
            this.changeUserBtn.Text = "Передать смену";
            this.changeUserBtn.UseVisualStyleBackColor = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 65);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(60, 13);
            this.label22.TabIndex = 1;
            this.label22.Text = "Продавец:";
            // 
            // clrTiBtn
            // 
            this.clrTiBtn.BackColor = System.Drawing.Color.Silver;
            this.clrTiBtn.Enabled = false;
            this.clrTiBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clrTiBtn.Location = new System.Drawing.Point(109, 170);
            this.clrTiBtn.Name = "clrTiBtn";
            this.clrTiBtn.Size = new System.Drawing.Size(98, 47);
            this.clrTiBtn.TabIndex = 7;
            this.clrTiBtn.Text = "Очистить \r\nчек";
            this.clrTiBtn.UseVisualStyleBackColor = false;
            this.clrTiBtn.Click += new System.EventHandler(this.ClrTiBtn_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(139, 20);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "4609104405153\tЛОЖЬ\tHUSKY Double ice 30ml Siberian black 20mg \tИСТИНА\t200\t220\t75\t3" +
    "50\tЛОЖЬ\t\t\t\t1\t1\t\t";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 45);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(139, 20);
            this.textBox3.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(151, 20);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(41, 23);
            this.button6.TabIndex = 13;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // waitThread
            // 
            this.waitThread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.WaitThread_DoWork);
            // 
            // userBox
            // 
            this.userBox.FormattingEnabled = true;
            this.userBox.Items.AddRange(new object[] {
            "Debug"});
            this.userBox.Location = new System.Drawing.Point(68, 62);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(139, 21);
            this.userBox.TabIndex = 14;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(365, 58);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 13);
            this.label18.TabIndex = 15;
            this.label18.Text = "Чек № ";
            // 
            // ticketNumLbl
            // 
            this.ticketNumLbl.AutoSize = true;
            this.ticketNumLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ticketNumLbl.Location = new System.Drawing.Point(406, 58);
            this.ticketNumLbl.Name = "ticketNumLbl";
            this.ticketNumLbl.Size = new System.Drawing.Size(14, 13);
            this.ticketNumLbl.TabIndex = 15;
            this.ticketNumLbl.Text = "0";
            // 
            // buyCountBox
            // 
            this.buyCountBox.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyCountBox.FormattingEnabled = true;
            this.buyCountBox.Location = new System.Drawing.Point(518, 75);
            this.buyCountBox.Name = "buyCountBox";
            this.buyCountBox.Size = new System.Drawing.Size(52, 251);
            this.buyCountBox.TabIndex = 9;
            this.buyCountBox.SelectedIndexChanged += new System.EventHandler(this.BuyCountBox_SelectedIndexChanged);
            // 
            // BuyCostBox
            // 
            this.BuyCostBox.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyCostBox.FormattingEnabled = true;
            this.BuyCostBox.Location = new System.Drawing.Point(569, 75);
            this.BuyCostBox.Name = "BuyCostBox";
            this.BuyCostBox.Size = new System.Drawing.Size(52, 251);
            this.BuyCostBox.TabIndex = 9;
            this.BuyCostBox.SelectedIndexChanged += new System.EventHandler(this.BuyCostBox_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 75);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(112, 53);
            this.textBox1.TabIndex = 16;
            // 
            // debugBox
            // 
            this.debugBox.Controls.Add(this.textBox2);
            this.debugBox.Controls.Add(this.textBox1);
            this.debugBox.Controls.Add(this.textBox3);
            this.debugBox.Controls.Add(this.button6);
            this.debugBox.Location = new System.Drawing.Point(6, 223);
            this.debugBox.Name = "debugBox";
            this.debugBox.Size = new System.Drawing.Size(200, 155);
            this.debugBox.TabIndex = 17;
            this.debugBox.TabStop = false;
            this.debugBox.Text = "DebugBox";
            this.debugBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 392);
            this.Controls.Add(this.debugBox);
            this.Controls.Add(this.ticketNumLbl);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ticketEdit);
            this.Controls.Add(this.BuyCostBox);
            this.Controls.Add(this.buyCountBox);
            this.Controls.Add(this.buyBox);
            this.Controls.Add(this.totalDiscLbl);
            this.Controls.Add(this.gdsCntLbl);
            this.Controls.Add(this.posCntLbl);
            this.Controls.Add(this.ttlCstLbl);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.autoAdd);
            this.Controls.Add(this.changeUserBtn);
            this.Controls.Add(this.closeDayBtn);
            this.Controls.Add(this.newDayBtn);
            this.Controls.Add(this.clrTiBtn);
            this.Controls.Add(this.newTiBtn);
            this.Controls.Add(this.closeTiBtn);
            this.Controls.Add(this.restartBtn);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.loadLbl);
            this.Controls.Add(this.pauseBar);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.countBox);
            this.Controls.Add(this.outcostBox);
            this.Controls.Add(this.incostBox);
            this.Controls.Add(this.itemBox);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codeBox);
            this.Name = "Form1";
            this.Text = ">>Cattus Code  Касса v 1.0 preAlpha";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.countDD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costDD)).EndInit();
            this.ticketEdit.ResumeLayout(false);
            this.ticketEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discDD)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.debugBox.ResumeLayout(false);
            this.debugBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox codeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox itemBox;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.ProgressBar pauseBar;
        private System.Windows.Forms.Label loadLbl;
        private System.ComponentModel.BackgroundWorker thread2;
        private System.Windows.Forms.Button restartBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox incostBox;
        private System.Windows.Forms.TextBox outcostBox;
        private System.Windows.Forms.TextBox countBox;
        private System.Windows.Forms.CheckBox autoAdd;
        private System.Windows.Forms.ListBox buyBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label posEditLbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown countDD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown costDD;
        private System.Windows.Forms.GroupBox ticketEdit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown discDD;
        private System.Windows.Forms.Button delGoodBtn;
        private System.Windows.Forms.Button r100btn;
        private System.Windows.Forms.Button r50btn;
        private System.Windows.Forms.Button r0btn;
        private System.Windows.Forms.Button r10btn;
        private System.Windows.Forms.Button p10Btn;
        private System.Windows.Forms.Button pBxbtn;
        private System.Windows.Forms.Button p15Btn;
        private System.Windows.Forms.Button p5Btn;
        private System.Windows.Forms.Button p3Btn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label posCntLbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label gdsCntLbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label ttlCstLbl;
        private System.Windows.Forms.Button closeTiBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label midTiLbl;
        private System.Windows.Forms.Label totTiLbl;
        private System.Windows.Forms.Label totCashLbl;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label totalDiscLbl;
        private System.Windows.Forms.Button newTiBtn;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button showTicketsBtn;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label totDsLbl;
        private System.Windows.Forms.Label totGdLbl;
        private System.Windows.Forms.Button newDayBtn;
        private System.Windows.Forms.Button closeDayBtn;
        private System.Windows.Forms.Button changeUserBtn;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button clrTiBtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button6;
        private System.ComponentModel.BackgroundWorker waitThread;
        private System.Windows.Forms.Button r5btn;
        private System.Windows.Forms.ComboBox userBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label ticketNumLbl;
        private System.Windows.Forms.ListBox buyCountBox;
        private System.Windows.Forms.ListBox BuyCostBox;
        private System.Windows.Forms.Button saveGoodBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox debugBox;
    }
}

