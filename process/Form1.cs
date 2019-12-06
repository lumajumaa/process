using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace process
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Clear();
            try
            {
                Process p = Process.GetCurrentProcess();
                dataGridView1.Rows.Add(p.Id, p.ProcessName);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

      
        private void button2_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Clear();
            try
            {
                Process [] p = Process.GetProcesses();
                foreach (Process i in p)
                {
                    dataGridView1.Rows.Add(i.Id, i.ProcessName);
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                dataGridView1.Rows.Clear();
                Process p = Process.GetProcessById(Convert.ToInt16(textBox1.Text));
                dataGridView1.Rows.Add(p.Id, p.ProcessName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process p = Process.GetProcessById(Convert.ToInt16(textBox1.Text));
            p.Kill();
            MessageBox.Show("process that has is " + p.Id);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(textBox1.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "-s -t 00");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.google.com/");
        }
    }
}
