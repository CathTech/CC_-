using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CT.Shop.bgmodule
{
    public partial class tickets : Form
    {
        ticket currentTicket = new ticket();
        List<ticket> ticketList = new List<ticket>();
        public tickets()
        {
            InitializeComponent();
        }

        public void get(List<ticket> tL)
        {
            ticketList = tL;
        }
        private void TicketSelect_ValueChanged(object sender, EventArgs e)
        {
            currentTicket = ticketList[Convert.ToInt32(ticketSelect.Value - 1)];
            updateTicket();
        }

        void updateTicket()
        {
            buyBox.Items.Clear();
            buyCountBox.Items.Clear();
            BuyCostBox.Items.Clear();
            gdsCntLbl.Text = "0";
            ttlCstLbl.Text = "0";
           //posCntLbl.Text = "0";
            totalDiscLbl.Text = "0";

            for (int i = 0; i < currentTicket.goods.Count; i++)
            {
                //ID код наименование цена стоимость количество разница
                buyBox.Items.Add((currentTicket.goods[i].content[0]) + "|" + currentTicket.goods[i].content[2]);
                buyCountBox.Items.Add(currentTicket.goods[i].content[5] + "шт.");
                BuyCostBox.Items.Add(currentTicket.goods[i].content[4] + "р.");
                //textBox1.AppendText(">"+currentTicket.goods[i].content[0] + currentTicket.goods[i].content[2] + Environment.NewLine);
                //gd.content[0] = Convert.ToString(Convert.ToInt32(gd.content[0]) + 1);
                ttlCstLbl.Text = Convert.ToString(Convert.ToInt32(ttlCstLbl.Text) + Convert.ToInt32(currentTicket.goods[i].content[4]));
                currentTicket.refresh();

                ticket tk = new ticket();
                tk.goods = currentTicket.goods;
                //if (i > 0) posCntLbl.Text = Convert.ToString(i + 1 - tk.dupl(currentTicket.goods[i])); else posCntLbl.Text = "1";
                //textBox1.AppendText(tk.dupl(currentTicket.goods[i]) + Environment.NewLine);
                gdsCntLbl.Text = Convert.ToString(Convert.ToInt32(gdsCntLbl.Text) + Convert.ToInt32(currentTicket.goods[i].content[5]));
                totalDiscLbl.Text = Convert.ToString(Convert.ToInt32(totalDiscLbl.Text) + (Convert.ToInt32(currentTicket.goods[i].content[3]) - Convert.ToInt32(currentTicket.goods[i].content[4])));
            }
        }

        private void Tickets_Shown(object sender, EventArgs e)
        {
            currentTicket = ticketList[Convert.ToInt32(ticketSelect.Value - 1)];
            updateTicket();
        }
    }
}
