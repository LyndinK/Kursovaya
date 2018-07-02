using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Bank_Clients
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
        }
        public static RegistryKey key;

        private void Form1_Load(object sender, EventArgs e)
        {
            key = Registry.CurrentUser.CreateSubKey("Bank_Clients");
            if ((string)key.GetValue("password") == "777")
            {
                Form2 f2 = new Form2();
                f2.ShowDialog();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "777")
            {
                key.SetValue("password", "777");
                Form2 f2 = new Form2();
                f2.ShowDialog();
                this.Close();
            }
            else MessageBox.Show("неверный пароль");
        }
    }
}
