using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Clients
{
    public partial class Stats : Form
    {
        public Stats()
        {
            InitializeComponent();
        }
        List<string> vessel = new List<string>();
        private void Stats_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
        public void Conc (string closure ,string str)
        {
            if (str != "") vessel.Add(string.Format(closure, str));
        }
            
        private void exit_Click(object sender, EventArgs e)
        {
            Conc(" surname = '{0}'",Sn.Text);
            Conc(" name = '{0}'" , Nm.Text);
            Conc(" currency = '{0}'", Currency_name.Text);
            Conc(" rate " + Rt_func.Text+ "{0}", Rt.Text);
            Conc(" sum "+Sm_func.Text + "{0}", Sm.Text);
            Conc(" term "+Tr_func.Text+"{0}", Tr_val.Text);
            Form2.stats += string.Join(" AND ", vessel);
            Form2.confirm = true;
            this.Close();
        }

        private void Sn_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.')
            {
                e.Handled = true;
            }
        }

        private void Nm_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.')
            {
                e.Handled = true;
            }
        }

        private void Rt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void Sm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void Rt_val_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void Cancl_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
