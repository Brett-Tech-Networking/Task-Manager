namespace Task_Manager
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ubuntuTheme1 = new Ubuntu_Theme.UbuntuTheme();
            this.label1 = new System.Windows.Forms.Label();
            this.faderTabControl1 = new Fader_Theme.FaderTabControl();
            this.Processes = new System.Windows.Forms.TabPage();
            this.faderListBox1 = new Fader_Theme.FaderListBox();
            this.ubuntuButtonGray1 = new Ubuntu_Theme.UbuntuButtonGray();
            this.ubuntuButtonOrange1 = new Ubuntu_Theme.UbuntuButtonOrange();
            this.ubuntuTextBox1 = new Ubuntu_Theme.UbuntuTextBox();
            this.RAMCPU = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.faderLabel2 = new Fader_Theme.FaderLabel();
            this.metroProgressBar2 = new MetroFramework.Controls.MetroProgressBar();
            this.faderLabel4 = new Fader_Theme.FaderLabel();
            this.faderLabel3 = new Fader_Theme.FaderLabel();
            this.faderLabel1 = new Fader_Theme.FaderLabel();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.ubuntuControlBox1 = new Ubuntu_Theme.UbuntuControlBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TaskMgrTimer = new System.Windows.Forms.Timer(this.components);
            this.pRAM = new System.Diagnostics.PerformanceCounter();
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.ubuntuTheme1.SuspendLayout();
            this.faderTabControl1.SuspendLayout();
            this.Processes.SuspendLayout();
            this.RAMCPU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            this.SuspendLayout();
            // 
            // ubuntuTheme1
            // 
            this.ubuntuTheme1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ubuntuTheme1.Controls.Add(this.label1);
            this.ubuntuTheme1.Controls.Add(this.faderTabControl1);
            this.ubuntuTheme1.Controls.Add(this.ubuntuControlBox1);
            this.ubuntuTheme1.Controls.Add(this.menuStrip1);
            this.ubuntuTheme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ubuntuTheme1.Location = new System.Drawing.Point(0, 0);
            this.ubuntuTheme1.Name = "ubuntuTheme1";
            this.ubuntuTheme1.Size = new System.Drawing.Size(399, 531);
            this.ubuntuTheme1.TabIndex = 0;
            this.ubuntuTheme1.Text = "Task Manager | Moradi Development";
            this.ubuntuTheme1.Click += new System.EventHandler(this.ubuntuTheme1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(278, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Status";
            // 
            // faderTabControl1
            // 
            this.faderTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.faderTabControl1.Controls.Add(this.Processes);
            this.faderTabControl1.Controls.Add(this.RAMCPU);
            this.faderTabControl1.ItemSize = new System.Drawing.Size(100, 35);
            this.faderTabControl1.Location = new System.Drawing.Point(1, 52);
            this.faderTabControl1.Name = "faderTabControl1";
            this.faderTabControl1.SelectedIndex = 0;
            this.faderTabControl1.Size = new System.Drawing.Size(398, 479);
            this.faderTabControl1.TabIndex = 2;
            // 
            // Processes
            // 
            this.Processes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.Processes.Controls.Add(this.faderListBox1);
            this.Processes.Controls.Add(this.ubuntuButtonGray1);
            this.Processes.Controls.Add(this.ubuntuButtonOrange1);
            this.Processes.Controls.Add(this.ubuntuTextBox1);
            this.Processes.Location = new System.Drawing.Point(4, 39);
            this.Processes.Name = "Processes";
            this.Processes.Padding = new System.Windows.Forms.Padding(3);
            this.Processes.Size = new System.Drawing.Size(390, 436);
            this.Processes.TabIndex = 0;
            this.Processes.Text = "Processes";
            // 
            // faderListBox1
            // 
            this.faderListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.faderListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.faderListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.faderListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.faderListBox1.ForeColor = System.Drawing.Color.White;
            this.faderListBox1.FormattingEnabled = true;
            this.faderListBox1.ItemHeight = 20;
            this.faderListBox1.Location = new System.Drawing.Point(2, 3);
            this.faderListBox1.Name = "faderListBox1";
            this.faderListBox1.Size = new System.Drawing.Size(385, 400);
            this.faderListBox1.TabIndex = 0;
            // 
            // ubuntuButtonGray1
            // 
            this.ubuntuButtonGray1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ubuntuButtonGray1.BackColor = System.Drawing.Color.Transparent;
            this.ubuntuButtonGray1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(84)))), ((int)(((byte)(82)))));
            this.ubuntuButtonGray1.Location = new System.Drawing.Point(311, 410);
            this.ubuntuButtonGray1.Name = "ubuntuButtonGray1";
            this.ubuntuButtonGray1.Size = new System.Drawing.Size(75, 23);
            this.ubuntuButtonGray1.TabIndex = 3;
            this.ubuntuButtonGray1.Text = "End Task";
            // 
            // ubuntuButtonOrange1
            // 
            this.ubuntuButtonOrange1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ubuntuButtonOrange1.BackColor = System.Drawing.Color.Transparent;
            this.ubuntuButtonOrange1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ubuntuButtonOrange1.Location = new System.Drawing.Point(234, 409);
            this.ubuntuButtonOrange1.Name = "ubuntuButtonOrange1";
            this.ubuntuButtonOrange1.Size = new System.Drawing.Size(74, 23);
            this.ubuntuButtonOrange1.TabIndex = 5;
            this.ubuntuButtonOrange1.Text = "Search";
            this.ubuntuButtonOrange1.Click += new System.EventHandler(this.ubuntuButtonOrange1_Click);
            // 
            // ubuntuTextBox1
            // 
            this.ubuntuTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ubuntuTextBox1.BackColor = System.Drawing.Color.White;
            this.ubuntuTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ubuntuTextBox1.Location = new System.Drawing.Point(2, 407);
            this.ubuntuTextBox1.MaxLength = 32767;
            this.ubuntuTextBox1.Name = "ubuntuTextBox1";
            this.ubuntuTextBox1.Size = new System.Drawing.Size(228, 26);
            this.ubuntuTextBox1.TabIndex = 4;
            this.ubuntuTextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.ubuntuTextBox1.UseSystemPasswordChar = false;
            // 
            // RAMCPU
            // 
            this.RAMCPU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.RAMCPU.Controls.Add(this.chart1);
            this.RAMCPU.Controls.Add(this.faderLabel2);
            this.RAMCPU.Controls.Add(this.metroProgressBar2);
            this.RAMCPU.Controls.Add(this.faderLabel4);
            this.RAMCPU.Controls.Add(this.faderLabel3);
            this.RAMCPU.Controls.Add(this.faderLabel1);
            this.RAMCPU.Controls.Add(this.metroProgressBar1);
            this.RAMCPU.Location = new System.Drawing.Point(4, 39);
            this.RAMCPU.Name = "RAMCPU";
            this.RAMCPU.Padding = new System.Windows.Forms.Padding(3);
            this.RAMCPU.Size = new System.Drawing.Size(390, 436);
            this.RAMCPU.TabIndex = 1;
            this.RAMCPU.Text = "RAM & CPU";
            this.RAMCPU.Click += new System.EventHandler(this.RAMCPU_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(-15, 79);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "CPU";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.ErrorBar;
            series2.Legend = "Legend1";
            series2.Name = "RAM";
            series2.YValuesPerPoint = 3;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(409, 349);
            this.chart1.TabIndex = 4;
            // 
            // faderLabel2
            // 
            this.faderLabel2.BackColor = System.Drawing.Color.Transparent;
            this.faderLabel2.Border = true;
            this.faderLabel2.Location = new System.Drawing.Point(7, 42);
            this.faderLabel2.Name = "faderLabel2";
            this.faderLabel2.Size = new System.Drawing.Size(50, 30);
            this.faderLabel2.TabIndex = 3;
            this.faderLabel2.Text = "RAM:";
            // 
            // metroProgressBar2
            // 
            this.metroProgressBar2.Location = new System.Drawing.Point(62, 44);
            this.metroProgressBar2.Name = "metroProgressBar2";
            this.metroProgressBar2.Size = new System.Drawing.Size(254, 28);
            this.metroProgressBar2.TabIndex = 1;
            // 
            // faderLabel4
            // 
            this.faderLabel4.BackColor = System.Drawing.Color.Transparent;
            this.faderLabel4.Border = true;
            this.faderLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.faderLabel4.Location = new System.Drawing.Point(322, 43);
            this.faderLabel4.Name = "faderLabel4";
            this.faderLabel4.Size = new System.Drawing.Size(62, 30);
            this.faderLabel4.TabIndex = 3;
            this.faderLabel4.Text = "0%";
            // 
            // faderLabel3
            // 
            this.faderLabel3.BackColor = System.Drawing.Color.Transparent;
            this.faderLabel3.Border = true;
            this.faderLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.faderLabel3.Location = new System.Drawing.Point(322, 8);
            this.faderLabel3.Name = "faderLabel3";
            this.faderLabel3.Size = new System.Drawing.Size(62, 30);
            this.faderLabel3.TabIndex = 3;
            this.faderLabel3.Text = "0%";
            // 
            // faderLabel1
            // 
            this.faderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.faderLabel1.Border = true;
            this.faderLabel1.Location = new System.Drawing.Point(7, 6);
            this.faderLabel1.Name = "faderLabel1";
            this.faderLabel1.Size = new System.Drawing.Size(50, 30);
            this.faderLabel1.TabIndex = 3;
            this.faderLabel1.Text = "CPU:";
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(62, 8);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(254, 28);
            this.metroProgressBar1.TabIndex = 1;
            // 
            // ubuntuControlBox1
            // 
            this.ubuntuControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ubuntuControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.ubuntuControlBox1.Font = new System.Drawing.Font("Marlett", 7F);
            this.ubuntuControlBox1.Location = new System.Drawing.Point(333, 3);
            this.ubuntuControlBox1.Name = "ubuntuControlBox1";
            this.ubuntuControlBox1.Size = new System.Drawing.Size(75, 23);
            this.ubuntuControlBox1.TabIndex = 0;
            this.ubuntuControlBox1.Text = "ubuntuControlBox1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(1, 27);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(106, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTaskToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newTaskToolStripMenuItem
            // 
            this.newTaskToolStripMenuItem.Name = "newTaskToolStripMenuItem";
            this.newTaskToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.newTaskToolStripMenuItem.Text = "New Task";
            this.newTaskToolStripMenuItem.Click += new System.EventHandler(this.newTaskToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // TaskMgrTimer
            // 
            this.TaskMgrTimer.Enabled = true;
            this.TaskMgrTimer.Tick += new System.EventHandler(this.TaskMgrTimer_Tick);
            // 
            // pRAM
            // 
            this.pRAM.CategoryName = "Memory";
            this.pRAM.CounterName = "% Committed Bytes In Use";
            // 
            // pCPU
            // 
            this.pCPU.CategoryName = "Processor";
            this.pCPU.CounterName = "% Processor Time";
            this.pCPU.InstanceName = "_Total";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 531);
            this.Controls.Add(this.ubuntuTheme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ubuntuTheme1.ResumeLayout(false);
            this.ubuntuTheme1.PerformLayout();
            this.faderTabControl1.ResumeLayout(false);
            this.Processes.ResumeLayout(false);
            this.RAMCPU.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Ubuntu_Theme.UbuntuTheme ubuntuTheme1;
        private Ubuntu_Theme.UbuntuControlBox ubuntuControlBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private Fader_Theme.FaderTabControl faderTabControl1;
        private System.Windows.Forms.TabPage Processes;
        private System.Windows.Forms.TabPage RAMCPU;
        private Ubuntu_Theme.UbuntuButtonOrange ubuntuButtonOrange1;
        private Ubuntu_Theme.UbuntuTextBox ubuntuTextBox1;
        private Ubuntu_Theme.UbuntuButtonGray ubuntuButtonGray1;
        private Fader_Theme.FaderListBox faderListBox1;
        private System.Windows.Forms.Timer TaskMgrTimer;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Diagnostics.PerformanceCounter pRAM;
        private System.Diagnostics.PerformanceCounter pCPU;
        private Fader_Theme.FaderLabel faderLabel2;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar2;
        private Fader_Theme.FaderLabel faderLabel4;
        private Fader_Theme.FaderLabel faderLabel3;
        private Fader_Theme.FaderLabel faderLabel1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

