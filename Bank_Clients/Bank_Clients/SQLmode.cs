using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Bank_Clients
{
    public partial class SQLmode : Form
    {
        public SQLmode()
        {
            InitializeComponent();
            Query_field.Text = "SELECT * FROM clients";
        }

        private void Cancl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            Form2.query = Query_field.Text;
            this.Close();
            Form2.confirm = true;
        }

        private void Help_Click(object sender, EventArgs e)
        {
            string url = "https://www.w3schools.com/sql/";
            Process.Start( url ); 
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Query_field.Text += listBox1.Text;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Query_field.Text += listBox2.Text;
        }

        private void SQLmode_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
