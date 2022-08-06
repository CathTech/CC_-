namespace CT.Shop.bgmodule
{
    partial class tickets
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tiTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BuyCostBox = new System.Windows.Forms.ListBox();
            this.buyCountBox = new System.Windows.Forms.ListBox();
            this.buyBox = new System.Windows.Forms.ListBox();
            this.ticketSelect = new System.Windows.Forms.NumericUpDown();
            this.totalDiscLbl = new System.Windows.Forms.Label();
            this.gdsCntLbl = new System.Windows.Forms.Label();
            this.ttlCstLbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tiTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // tiTabs
            // 
            this.tiTabs.Controls.Add(this.tabPage1);
            this.tiTabs.Controls.Add(this.tabPage2);
            this.tiTabs.Location = new System.Drawing.Point(1, 1);
            this.tiTabs.Name = "tiTabs";
            this.tiTabs.SelectedIndex = 0;
            this.tiTabs.Size = new System.Drawing.Size(408, 353);
            this.tiTabs.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.totalDiscLbl);
            this.tabPage1.Controls.Add(this.gdsCntLbl);
            this.tabPage1.Controls.Add(this.ttlCstLbl);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.ticketSelect);
            this.tabPage1.Controls.Add(this.BuyCostBox);
            this.tabPage1.Controls.Add(this.buyCountBox);
            this.tabPage1.Controls.Add(this.buyBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(400, 327);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Чеки";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(400, 327);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Продажи";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BuyCostBox
            // 
            this.BuyCostBox.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyCostBox.FormattingEnabled = true;
            this.BuyCostBox.Location = new System.Drawing.Point(349, 0);
            this.BuyCostBox.Name = "BuyCostBox";
            this.BuyCostBox.Size = new System.Drawing.Size(52, 251);
            this.BuyCostBox.TabIndex = 10;
            // 
            // buyCountBox
            // 
            this.buyCountBox.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyCountBox.FormattingEnabled = true;
            this.buyCountBox.Location = new System.Drawing.Point(298, 0);
            this.buyCountBox.Name = "buyCountBox";
            this.buyCountBox.Size = new System.Drawing.Size(52, 251);
            this.buyCountBox.TabIndex = 11;
            // 
            // buyBox
            // 
            this.buyBox.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyBox.FormattingEnabled = true;
            this.buyBox.Items.AddRange(new object[] {
            "Откройте смену",
            "Создайте новый чек",
            "Пробейте товар"});
            this.buyBox.Location = new System.Drawing.Point(0, 0);
            this.buyBox.Name = "buyBox";
            this.buyBox.Size = new System.Drawing.Size(299, 251);
            this.buyBox.TabIndex = 12;
            // 
            // ticketSelect
            // 
            this.ticketSelect.Location = new System.Drawing.Point(340, 284);
            this.ticketSelect.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ticketSelect.Name = "ticketSelect";
            this.ticketSelect.Size = new System.Drawing.Size(46, 20);
            this.ticketSelect.TabIndex = 13;
            this.ticketSelect.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ticketSelect.ValueChanged += new System.EventHandler(this.TicketSelect_ValueChanged);
            // 
            // totalDiscLbl
            // 
            this.totalDiscLbl.AutoSize = true;
            this.totalDiscLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalDiscLbl.Location = new System.Drawing.Point(118, 257);
            this.totalDiscLbl.Name = "totalDiscLbl";
            this.totalDiscLbl.Size = new System.Drawing.Size(18, 20);
            this.totalDiscLbl.TabIndex = 14;
            this.totalDiscLbl.Text = "0";
            // 
            // gdsCntLbl
            // 
            this.gdsCntLbl.AutoSize = true;
            this.gdsCntLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gdsCntLbl.Location = new System.Drawing.Point(119, 301);
            this.gdsCntLbl.Name = "gdsCntLbl";
            this.gdsCntLbl.Size = new System.Drawing.Size(18, 20);
            this.gdsCntLbl.TabIndex = 15;
            this.gdsCntLbl.Text = "0";
            // 
            // ttlCstLbl
            // 
            this.ttlCstLbl.AutoSize = true;
            this.ttlCstLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ttlCstLbl.Location = new System.Drawing.Point(118, 279);
            this.ttlCstLbl.Name = "ttlCstLbl";
            this.ttlCstLbl.Size = new System.Drawing.Size(19, 20);
            this.ttlCstLbl.TabIndex = 16;
            this.ttlCstLbl.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(57, 279);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "Итого:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(45, 301);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Товаров:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(7, 256);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(114, 20);
            this.label14.TabIndex = 19;
            this.label14.Text = "Сумм. скидка:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Чек:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Пусто блеать";
            // 
            // tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 360);
            this.Controls.Add(this.tiTabs);
            this.Name = "tickets";
            this.Text = "Просмотр чеков";
            this.Shown += new System.EventHandler(this.Tickets_Shown);
            this.tiTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketSelect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tiTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox BuyCostBox;
        private System.Windows.Forms.ListBox buyCountBox;
        private System.Windows.Forms.ListBox buyBox;
        private System.Windows.Forms.NumericUpDown ticketSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalDiscLbl;
        private System.Windows.Forms.Label gdsCntLbl;
        private System.Windows.Forms.Label ttlCstLbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
    }
}