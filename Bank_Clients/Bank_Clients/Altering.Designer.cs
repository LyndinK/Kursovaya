namespace Bank_Clients
{
    partial class Altering
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
            this.Nm = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Sur = new System.Windows.Forms.TextBox();
            this.Summa = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rateB = new System.Windows.Forms.TextBox();
            this.termB = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.Cur = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Nm
            // 
            this.Nm.Location = new System.Drawing.Point(133, 36);
            this.Nm.Margin = new System.Windows.Forms.Padding(2);
            this.Nm.Name = "Nm";
            this.Nm.Size = new System.Drawing.Size(192, 20);
            this.Nm.TabIndex = 0;
            this.Nm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nm_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 537);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Записать и закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 209);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Валюта";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Сумма";
            // 
            // Sur
            // 
            this.Sur.Location = new System.Drawing.Point(133, 74);
            this.Sur.Margin = new System.Windows.Forms.Padding(2);
            this.Sur.Name = "Sur";
            this.Sur.Size = new System.Drawing.Size(192, 20);
            this.Sur.TabIndex = 6;
            this.Sur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Sur_KeyPress);
            // 
            // Summa
            // 
            this.Summa.Location = new System.Drawing.Point(133, 106);
            this.Summa.Margin = new System.Windows.Forms.Padding(2);
            this.Summa.Name = "Summa";
            this.Summa.Size = new System.Drawing.Size(192, 20);
            this.Summa.TabIndex = 8;
            this.Summa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Summa_KeyPress);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(237, 537);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 31);
            this.button2.TabIndex = 9;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 485);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Дата Внесения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ставка";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Срок";
            // 
            // rateB
            // 
            this.rateB.Location = new System.Drawing.Point(133, 143);
            this.rateB.Name = "rateB";
            this.rateB.Size = new System.Drawing.Size(192, 20);
            this.rateB.TabIndex = 13;
            this.rateB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rateB_KeyPress);
            // 
            // termB
            // 
            this.termB.Location = new System.Drawing.Point(133, 177);
            this.termB.Name = "termB";
            this.termB.Size = new System.Drawing.Size(192, 20);
            this.termB.TabIndex = 14;
            this.termB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.termB_KeyPress);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(161, 336);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 15;
            // 
            // Cur
            // 
            this.Cur.FormattingEnabled = true;
            this.Cur.Items.AddRange(new object[] {
            "Рубли",
            "Доллары",
            "Евро",
            "Злотые",
            "Кроны",
            "Франки",
            "Фунты Стерлингов",
            "Гривны"});
            this.Cur.Location = new System.Drawing.Point(133, 209);
            this.Cur.Name = "Cur";
            this.Cur.Size = new System.Drawing.Size(192, 95);
            this.Cur.TabIndex = 16;
            // 
            // Altering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 579);
            this.Controls.Add(this.Cur);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.termB);
            this.Controls.Add(this.rateB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Summa);
            this.Controls.Add(this.Sur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Nm);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Altering";
            this.Text = "Изменение записи";
            this.Load += new System.EventHandler(this.Altering_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Sur;
        private System.Windows.Forms.TextBox Summa;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox rateB;
        private System.Windows.Forms.TextBox termB;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ListBox Cur;
    }
}