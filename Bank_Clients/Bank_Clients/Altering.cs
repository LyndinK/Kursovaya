using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Bank_Clients
{
    public partial class Altering : Form
    {
        public Altering()
        {
            InitializeComponent();
            Nm.MaxLength = 15;
            Sur.MaxLength = 15;
            Summa.MaxLength = 8;
            rateB.MaxLength = 2;
            termB.MaxLength = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Nm.Text=="" | Sur.Text=="" | Cur.Text=="" | Summa.Text=="" | rateB.Text=="" | termB.Text == "" | Summa.Text == "0" | rateB.Text == "0" | termB.Text == "0")
            {
                MessageBox.Show("заполнены не все данные");
            }
            else {
                Form2.SetName = Nm.Text;
                Form2.SetSurname = Sur.Text;
                Form2.SetCurrency = Cur.Text;
                Form2.SetSum = Convert.ToInt32(Summa.Text);
                Form2.SetRate = Convert.ToInt32(rateB.Text);
                Form2.SetTerm = Convert.ToInt32(termB.Text);
                Form2.SetDate = monthCalendar1.SelectionRange.Start.ToShortDateString();
                Form2.confirm = true;
                this.Close();
            }

        }

        private void Altering_Load(object sender, EventArgs e)
        {
            Nm.Text = Form2.SetName;
            Sur.Text = Form2.SetSurname;
            Cur.Text = Form2.SetCurrency;
            Summa.Text = Form2.SetSum.ToString();
            termB.Text = Form2.SetTerm.ToString();
            rateB.Text = Form2.SetRate.ToString();
            monthCalendar1.SetDate(Convert.ToDateTime(Form2.SetDate));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Nm_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.')
            {
                e.Handled = true;
            }
        }

        private void Sur_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.')
            {
                e.Handled = true;
            }
        }

        private void Summa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void rateB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void termB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
