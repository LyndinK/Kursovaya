namespace Bank_Clients
{
    partial class SQLmode
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
            this.Query_field = new System.Windows.Forms.RichTextBox();
            this.Execute = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Button();
            this.Cancl = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Query_field
            // 
            this.Query_field.Location = new System.Drawing.Point(12, 12);
            this.Query_field.Name = "Query_field";
            this.Query_field.Size = new System.Drawing.Size(492, 313);
            this.Query_field.TabIndex = 0;
            this.Query_field.Text = "";
            // 
            // Execute
            // 
            this.Execute.Location = new System.Drawing.Point(12, 331);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(354, 42);
            this.Execute.TabIndex = 1;
            this.Execute.Text = "Выполнить";
            this.Execute.UseVisualStyleBackColor = true;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // Help
            // 
            this.Help.Location = new System.Drawing.Point(372, 331);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(132, 42);
            this.Help.TabIndex = 2;
            this.Help.Text = "справка по SQL";
            this.Help.UseVisualStyleBackColor = true;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // Cancl
            // 
            this.Cancl.Location = new System.Drawing.Point(511, 331);
            this.Cancl.Name = "Cancl";
            this.Cancl.Size = new System.Drawing.Size(147, 42);
            this.Cancl.TabIndex = 3;
            this.Cancl.Text = "Отмена";
            this.Cancl.UseVisualStyleBackColor = true;
            this.Cancl.Click += new System.EventHandler(this.Cancl_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "id",
            "name",
            "surname",
            "currency",
            "sum",
            "date",
            "rate",
            "term"});
            this.listBox1.Location = new System.Drawing.Point(511, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(147, 147);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "SELECT",
            "WHERE",
            "DELETE",
            "UPDATE",
            "INSERT",
            "GROUP BY",
            "SET"});
            this.listBox2.Location = new System.Drawing.Point(511, 171);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(147, 147);
            this.listBox2.TabIndex = 6;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // SQLmode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 385);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Cancl);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.Execute);
            this.Controls.Add(this.Query_field);
            this.Name = "SQLmode";
            this.Text = "Создать запрос";
            this.Load += new System.EventHandler(this.SQLmode_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Query_field;
        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.Button Cancl;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}