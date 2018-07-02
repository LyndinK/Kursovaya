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
using System.IO;
using Microsoft.Win32;
using System.Diagnostics;

namespace Bank_Clients
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            CenterToScreen();
        }
        public static string ReadReg()
        {
            key = Registry.CurrentUser.CreateSubKey("Bank_Clients");
            if (key.GetValue("path") == null)
            {
                System.Data.SQLite.SQLiteConnection.CreateFile("database.db3");
                key.SetValue("path", "database.db3");
                way = "Data source="+(string)key.GetValue("path");
            }
            else way = "Data source=" + (string)key.GetValue("path");
            return way;
        }
        public static string way = ReadReg();
        SQLiteConnection conn = new SQLiteConnection(way);
        SQLiteCommand comm = new SQLiteCommand();
        DataTable dt = new DataTable();
        public static string SetName;
        public static string SetSurname;
        public static string SetCurrency;
        public static string SetDate;
        public static int SetTerm;
        public static int SetRate;
        public static int SetSum;
        public static Boolean confirm;
        public static RegistryKey key;
        string filename = "";
        public static string query;
        public static void Nullify()
        {
            SetName = "";
            SetSurname = "";
            SetCurrency = "";
            SetSum = 0;
            SetDate = DateTime.Now.ToString("d/M/yyyy"); 
            SetTerm = 0;
            SetRate = 0;
            confirm = false;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            conn.Open();
            RefreshTable();
        }
        public void RefreshTable()
        {
            dt.Clear();
            comm = conn.CreateCommand();
            comm.CommandText = create;
            comm.ExecuteNonQuery();
            SQLiteDataAdapter sq = new SQLiteDataAdapter(select, conn);
            sq.Fill(dt);
            table.ReadOnly = true;
            table.DataSource = dt;
        }
        string create = "CREATE TABLE IF NOT EXISTS [clients]" +
            " ([id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT," +
            "[name] TEXT NOT NULL," +
            "[surname] TEXT NOT NULL," +
            "[currency] TEXT NOT NULL," +
            "[sum] INTEGER NOT NULL," +
            "[date] TEXT NOT NULL," +
            "[rate] INTEGER NOT NULL," +
            "[term] INTEGER NOT NULL)";
        public string add = "INSERT INTO clients (name,surname,currency,sum, date, rate, term) values ('{0}','{1}','{2}',{3},'{4}', {5} , {6} );";
        string delete = "DELETE FROM clients WHERE id={0}";
        string select = "SELECT * FROM clients";
        string update = "UPDATE clients " +
            "SET name='{0}', surname='{1}', currency='{2}', sum={3}, date='{4}', rate={5}, term = {6} "  +
            "WHERE id={7}";

        private void button1_Click(object sender, EventArgs e)
        {
            Nullify();
            Altering f3 = new Altering();
            f3.ShowDialog();
            if (confirm == true)
            {
                comm = conn.CreateCommand();
                comm.CommandText = String.Format(add, SetName, SetSurname, SetCurrency, SetSum, SetDate, SetRate, SetTerm);
                comm.ExecuteNonQuery();
                RefreshTable();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            key.SetValue("password", "000");
            this.Close();
        }

        private void Del_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить выделенную запись?", "Удаление", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                comm = conn.CreateCommand();
                comm.CommandText = String.Format(delete, Convert.ToString(table.CurrentRow.Cells[0].Value));
                comm.ExecuteNonQuery();
                RefreshTable();
            }
        }

        private void Alter_Click(object sender, EventArgs e)
        {
            Nullify();
            SetName = Convert.ToString(table.CurrentRow.Cells[1].Value);
            SetSurname = Convert.ToString(table.CurrentRow.Cells[2].Value);
            SetSum = Convert.ToInt32(table.CurrentRow.Cells[4].Value);
            SetCurrency = Convert.ToString(table.CurrentRow.Cells[3].Value);
            SetRate = Convert.ToInt32(table.CurrentRow.Cells[6].Value);
            SetTerm = Convert.ToInt32(table.CurrentRow.Cells[7].Value);
            SetDate = (string)table.CurrentRow.Cells[5].Value;
            Altering f3 = new Altering();
            f3.ShowDialog();
            if (confirm == true)
            {
                comm = conn.CreateCommand();
                comm.CommandText = String.Format(update, SetName, SetSurname, SetCurrency, SetSum, SetDate, SetRate, SetTerm,
                    Convert.ToString(table.CurrentRow.Cells[0].Value));
                comm.ExecuteNonQuery();
                RefreshTable();
            }

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog viewer = new OpenFileDialog();
            viewer.Filter = "db3 files (*.db3)|*.db3";
            viewer.AddExtension = true;
            viewer.InitialDirectory = Application.StartupPath;
            viewer.Title = "Выберите файл";
            if (viewer.ShowDialog() == DialogResult.OK)
            {
                filename = Path.GetFileName(viewer.FileName);
                key.SetValue("path", (string)filename);
                Application.Restart();
            }
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saver = new SaveFileDialog();
            saver.Filter = "db3 files (*.db3)|*.db3";
            saver.AddExtension = true;
            saver.InitialDirectory = Directory.GetCurrentDirectory();
            saver.Title = "Выберите, куда сохранить файл";
            if (saver.ShowDialog() == DialogResult.OK)
            {
                File.Copy(Path.Combine(Convert.ToString(Directory.GetCurrentDirectory()), (string)key.GetValue("path")), saver.FileName);
            }
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saver = new SaveFileDialog();
            saver.Filter = "db3 files (*.db3)|*.db3";
            saver.AddExtension = true;
            saver.InitialDirectory = Application.StartupPath;
            saver.Title = "создать новый файл";

            if (saver.ShowDialog() == DialogResult.OK)
            {
                filename = Path.GetFileName(saver.FileName);
                System.Data.SQLite.SQLiteConnection.CreateFile(filename);
                key.SetValue("path", (string)filename);
                Application.Restart();
                
            }
        }
        public static string stats;
        private void stats_Click(object sender, EventArgs e)
        {
            confirm = false;
            stats = "SELECT * FROM clients WHERE ";
            Stats f4 = new Stats();
            f4.ShowDialog();
            if (confirm == true)
            {
                comm = conn.CreateCommand();
                string sel = String.Format(stats);
                DataTable dtstat = new DataTable();
                SQLiteDataAdapter sq1 = new SQLiteDataAdapter(sel, conn);
                sq1.Fill(dtstat);
                table.ReadOnly = true;
                table.DataSource = dtstat;
            }
        }

        private void Refr_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void импортироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saver = new SaveFileDialog();
            saver.Filter = "db3 files (*.db3)|*.db3";
            saver.AddExtension = true;
            saver.InitialDirectory = Directory.GetCurrentDirectory();
            saver.Title = "Выберите, куда сохранить файл";
            if (saver.ShowDialog() == DialogResult.OK)
            {
                File.Copy(saver.FileName, Path.Combine(Application.StartupPath, Path.GetFileName(saver.FileName)));
            }
        }

        private void SQLmode_Click(object sender, EventArgs e)
        {
            confirm = false;
            query = "";
            SQLmode f5 = new SQLmode();
            f5.ShowDialog();
            if (confirm == true)
            {
                try
                {
                    comm = conn.CreateCommand();
                    string sel = query;
                    DataTable dtstat = new DataTable();
                    SQLiteDataAdapter sq1 = new SQLiteDataAdapter(sel, conn);
                    sq1.Fill(dtstat);
                    table.ReadOnly = true;
                    table.DataSource = dtstat;
                }
                catch
                {
                    MessageBox.Show("Запрос составлен неверно");
                    RefreshTable();
                }
            }
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Help.txt");
        }
    }
}
