namespace Task_Manager
{
    partial class New_Task
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
            this.ubuntuTheme1 = new Ubuntu_Theme.UbuntuTheme();
            this.ubuntuTextBox1 = new Ubuntu_Theme.UbuntuTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ubuntuButtonOrange1 = new Ubuntu_Theme.UbuntuButtonOrange();
            this.ubuntuControlBox1 = new Ubuntu_Theme.UbuntuControlBox();
            this.ubuntuTheme1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ubuntuTheme1
            // 
            this.ubuntuTheme1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ubuntuTheme1.Controls.Add(this.ubuntuControlBox1);
            this.ubuntuTheme1.Controls.Add(this.ubuntuButtonOrange1);
            this.ubuntuTheme1.Controls.Add(this.label1);
            this.ubuntuTheme1.Controls.Add(this.ubuntuTextBox1);
            this.ubuntuTheme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ubuntuTheme1.Location = new System.Drawing.Point(0, 0);
            this.ubuntuTheme1.Name = "ubuntuTheme1";
            this.ubuntuTheme1.Size = new System.Drawing.Size(455, 114);
            this.ubuntuTheme1.TabIndex = 0;
            this.ubuntuTheme1.Text = "Run New Task";
            // 
            // ubuntuTextBox1
            // 
            this.ubuntuTextBox1.BackColor = System.Drawing.Color.White;
            this.ubuntuTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ubuntuTextBox1.Location = new System.Drawing.Point(12, 57);
            this.ubuntuTextBox1.MaxLength = 32767;
            this.ubuntuTextBox1.Name = "ubuntuTextBox1";
            this.ubuntuTextBox1.Size = new System.Drawing.Size(431, 26);
            this.ubuntuTextBox1.TabIndex = 0;
            this.ubuntuTextBox1.Text = "ubuntuTextBox1";
            this.ubuntuTextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.ubuntuTextBox1.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Run New Task:";
            // 
            // ubuntuButtonOrange1
            // 
            this.ubuntuButtonOrange1.BackColor = System.Drawing.Color.Transparent;
            this.ubuntuButtonOrange1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ubuntuButtonOrange1.Location = new System.Drawing.Point(368, 88);
            this.ubuntuButtonOrange1.Name = "ubuntuButtonOrange1";
            this.ubuntuButtonOrange1.Size = new System.Drawing.Size(75, 23);
            this.ubuntuButtonOrange1.TabIndex = 2;
            this.ubuntuButtonOrange1.Text = "Run ";
            this.ubuntuButtonOrange1.Click += new System.EventHandler(this.ubuntuButtonOrange1_Click);
            // 
            // ubuntuControlBox1
            // 
            this.ubuntuControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ubuntuControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.ubuntuControlBox1.Font = new System.Drawing.Font("Marlett", 7F);
            this.ubuntuControlBox1.Location = new System.Drawing.Point(389, 3);
            this.ubuntuControlBox1.Name = "ubuntuControlBox1";
            this.ubuntuControlBox1.Size = new System.Drawing.Size(75, 23);
            this.ubuntuControlBox1.TabIndex = 3;
            this.ubuntuControlBox1.Text = "ubuntuControlBox1";
            // 
            // New_Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 114);
            this.Controls.Add(this.ubuntuTheme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "New_Task";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New_Task";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.ubuntuTheme1.ResumeLayout(false);
            this.ubuntuTheme1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Ubuntu_Theme.UbuntuTheme ubuntuTheme1;
        private Ubuntu_Theme.UbuntuButtonOrange ubuntuButtonOrange1;
        private System.Windows.Forms.Label label1;
        private Ubuntu_Theme.UbuntuTextBox ubuntuTextBox1;
        private Ubuntu_Theme.UbuntuControlBox ubuntuControlBox1;
    }
}