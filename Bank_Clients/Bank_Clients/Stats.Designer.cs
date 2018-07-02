namespace Bank_Clients
{
    partial class Stats
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.Sn = new System.Windows.Forms.TextBox();
            this.Nm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Rt = new System.Windows.Forms.TextBox();
            this.Currency_name = new System.Windows.Forms.ListBox();
            this.Rt_func = new System.Windows.Forms.ListBox();
            this.Сумма = new System.Windows.Forms.Label();
            this.Sm_func = new System.Windows.Forms.ListBox();
            this.Sm = new System.Windows.Forms.TextBox();
            this.Срок = new System.Windows.Forms.Label();
            this.Tr_func = new System.Windows.Forms.ListBox();
            this.Tr_val = new System.Windows.Forms.TextBox();
            this.Cancl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Валюта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 8;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(18, 465);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(154, 36);
            this.exit.TabIndex = 9;
            this.exit.Text = "Применить";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Sn
            // 
            this.Sn.Location = new System.Drawing.Point(167, 13);
            this.Sn.Name = "Sn";
            this.Sn.Size = new System.Drawing.Size(121, 20);
            this.Sn.TabIndex = 10;
            this.Sn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Sn_KeyPress);
            // 
            // Nm
            // 
            this.Nm.Location = new System.Drawing.Point(167, 40);
            this.Nm.Name = "Nm";
            this.Nm.Size = new System.Drawing.Size(121, 20);
            this.Nm.TabIndex = 11;
            this.Nm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nm_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ставка";
            // 
            // Rt
            // 
            this.Rt.Location = new System.Drawing.Point(225, 155);
            this.Rt.Name = "Rt";
            this.Rt.Size = new System.Drawing.Size(63, 20);
            this.Rt.TabIndex = 13;
            this.Rt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Rt_KeyPress);
            // 
            // Currency_name
            // 
            this.Currency_name.FormattingEnabled = true;
            this.Currency_name.Items.AddRange(new object[] {
            "Рубли",
            "Доллары",
            "Евро",
            "Злотые",
            "Кроны",
            "Франки",
            "Фунты Стерлингов",
            "Гривны"});
            this.Currency_name.Location = new System.Drawing.Point(168, 69);
            this.Currency_name.Name = "Currency_name";
            this.Currency_name.Size = new System.Drawing.Size(120, 69);
            this.Currency_name.TabIndex = 14;
            // 
            // Rt_func
            // 
            this.Rt_func.FormattingEnabled = true;
            this.Rt_func.Items.AddRange(new object[] {
            "=",
            ">",
            "<",
            ">=",
            "<="});
            this.Rt_func.Location = new System.Drawing.Point(167, 155);
            this.Rt_func.Name = "Rt_func";
            this.Rt_func.Size = new System.Drawing.Size(52, 43);
            this.Rt_func.TabIndex = 15;
            // 
            // Сумма
            // 
            this.Сумма.AutoSize = true;
            this.Сумма.Location = new System.Drawing.Point(16, 241);
            this.Сумма.Name = "Сумма";
            this.Сумма.Size = new System.Drawing.Size(41, 13);
            this.Сумма.TabIndex = 16;
            this.Сумма.Text = "Сумма";
            // 
            // Sm_func
            // 
            this.Sm_func.FormattingEnabled = true;
            this.Sm_func.Items.AddRange(new object[] {
            "=",
            ">",
            "<",
            ">=",
            "<="});
            this.Sm_func.Location = new System.Drawing.Point(167, 241);
            this.Sm_func.Name = "Sm_func";
            this.Sm_func.Size = new System.Drawing.Size(52, 43);
            this.Sm_func.TabIndex = 17;
            // 
            // Sm
            // 
            this.Sm.Location = new System.Drawing.Point(225, 241);
            this.Sm.Name = "Sm";
            this.Sm.Size = new System.Drawing.Size(63, 20);
            this.Sm.TabIndex = 18;
            this.Sm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Sm_KeyPress);
            // 
            // Срок
            // 
            this.Срок.AutoSize = true;
            this.Срок.Location = new System.Drawing.Point(16, 322);
            this.Срок.Name = "Срок";
            this.Срок.Size = new System.Drawing.Size(32, 13);
            this.Срок.TabIndex = 19;
            this.Срок.Text = "Срок";
            // 
            // Tr_func
            // 
            this.Tr_func.FormattingEnabled = true;
            this.Tr_func.Items.AddRange(new object[] {
            "=",
            ">",
            "<",
            ">=",
            "<="});
            this.Tr_func.Location = new System.Drawing.Point(167, 322);
            this.Tr_func.Name = "Tr_func";
            this.Tr_func.Size = new System.Drawing.Size(52, 43);
            this.Tr_func.TabIndex = 20;
            // 
            // Tr_val
            // 
            this.Tr_val.Location = new System.Drawing.Point(226, 322);
            this.Tr_val.Name = "Tr_val";
            this.Tr_val.Size = new System.Drawing.Size(62, 20);
            this.Tr_val.TabIndex = 21;
            this.Tr_val.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Rt_val_KeyPress);
            // 
            // Cancl
            // 
            this.Cancl.Location = new System.Drawing.Point(179, 465);
            this.Cancl.Name = "Cancl";
            this.Cancl.Size = new System.Drawing.Size(109, 36);
            this.Cancl.TabIndex = 22;
            this.Cancl.Text = "Отмена";
            this.Cancl.UseVisualStyleBackColor = true;
            this.Cancl.Click += new System.EventHandler(this.Cancl_Click);
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 526);
            this.Controls.Add(this.Cancl);
            this.Controls.Add(this.Tr_val);
            this.Controls.Add(this.Tr_func);
            this.Controls.Add(this.Срок);
            this.Controls.Add(this.Sm);
            this.Controls.Add(this.Sm_func);
            this.Controls.Add(this.Сумма);
            this.Controls.Add(this.Rt_func);
            this.Controls.Add(this.Currency_name);
            this.Controls.Add(this.Rt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nm);
            this.Controls.Add(this.Sn);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Stats";
            this.Text = "Фильтры";
            this.Load += new System.EventHandler(this.Stats_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox Sn;
        private System.Windows.Forms.TextBox Nm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Rt;
        private System.Windows.Forms.ListBox Currency_name;
        private System.Windows.Forms.ListBox Rt_func;
        private System.Windows.Forms.Label Сумма;
        private System.Windows.Forms.ListBox Sm_func;
        private System.Windows.Forms.TextBox Sm;
        private System.Windows.Forms.Label Срок;
        private System.Windows.Forms.ListBox Tr_func;
        private System.Windows.Forms.TextBox Tr_val;
        private System.Windows.Forms.Button Cancl;
    }
}