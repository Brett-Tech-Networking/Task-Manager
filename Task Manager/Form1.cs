using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace Task_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Task Manager List
        Process[] proc;
        void GetAllProcess()
        {
            proc = Process.GetProcesses();
            faderListBox1.Items.Clear();
            foreach (Process p in proc)
                faderListBox1.Items.Add(p.ProcessName);
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TaskMgrTimer_Tick(object sender, EventArgs e)
        {
            GetAllProcess();
            TaskMgrTimer.Stop();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetAllProcess();
            TaskMgrTimer.Stop();
        }

        private void ubuntuButtonOrange1_Click(object sender, EventArgs e)
        {
            faderListBox1.SelectedItems.Clear();
            for (int i = faderListBox1.Items.Count - 1; i >= 0; i--)
            {
                if (faderListBox1.Items[i].ToString().ToLower().Contains(ubuntuTextBox1.Text.ToLower()))
                {
                    faderListBox1.SetSelected(i, true);
                }
            }
            label1.Text = faderListBox1.SelectedItems.Count.ToString() + " Items Found";
        }

        private void newTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Task nt = new New_Task();
            nt.Show();
        }

        private void ubuntuTheme1_Click(object sender, EventArgs e)
        {

        }

        private void RAMCPU_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            float fcpu = pCPU.NextValue();
            float fram = pRAM.NextValue();
            metroProgressBar1.Value = (int)fcpu;
            metroProgressBar2.Value = (int)fram;
            faderLabel3.Text = string.Format("{0:0.00}%", fcpu);
            faderLabel4.Text = string.Format("{0:0.00}%", fram);
            chart1.Series["CPU"].Points.AddY(fcpu);
            chart1.Series["RAM"].Points.AddY(fram);
        }
    }
    }
