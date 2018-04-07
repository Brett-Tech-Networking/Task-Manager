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

namespace Task_Manager
{
    public partial class New_Task : Form
    {
        public New_Task()
        {
            InitializeComponent();
        }

        private void ubuntuButtonOrange1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ubuntuTextBox1.Text))
            {
                try
                {
                    System.Diagnostics.Process proc = new Process();
                    proc.StartInfo.FileName = ubuntuTextBox1.Text;
                    proc.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
