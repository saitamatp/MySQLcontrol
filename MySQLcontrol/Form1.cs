using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQLcontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (DateTime.Now.Day == 1 || DateTime.Now.Day == 2 || DateTime.Now.Day == 3 || DateTime.Now.Day == 4||DateTime.Now.Day == 5)
            {
                button5.Enabled = true;
            }else
            {
                button5.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{execute(1)}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{execute(3)}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{execute(2)}");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{execute(100)}");
        }
        public static string execute(int a)
        {
            string mysql_fun = @"D:\rust_src\mysql_fun\target\debug\mysql_fun.exe";
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = mysql_fun;
            p.StartInfo.Arguments =$"{a}";
            p.Start();
            //p.Start();
            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            return output;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{execute(4)}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{execute(5)}");

        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to TP's Ledger Utility ;) ");
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Reads Data From CSV file and loads to tmp Table",button1);
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Reads data from tmp table and loads to base Table", button2);
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Clears temporary table", button3);
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Loads data to misc credit table from file", button4);
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Runs Period End Stored procedure-Will be enabled on 1,2,3 and 4th of every Month", button5);
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Test Connection", button6);
        }
    }
}
