﻿namespace siga_desktop.view
{
    partial class SplashScreen
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            panel1 = new Panel();
            panel_list = new Panel();
            timer = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel_list);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 418);
            panel1.Name = "panel1";
            panel1.Size = new Size(616, 32);
            panel1.TabIndex = 0;
            // 
            // panel_list
            // 
            panel_list.BackColor = Color.FromArgb(28, 34, 68);
            panel_list.Location = new Point(9, 6);
            panel_list.Name = "panel_list";
            panel_list.Size = new Size(61, 21);
            panel_list.TabIndex = 0;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 30;
            timer.Tick += timer_Tick_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.siga_logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(101, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(415, 107);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(168, 258);
            label1.Name = "label1";
            label1.Size = new Size(295, 54);
            label1.TabIndex = 0;
            label1.Text = "Carregando...";
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(616, 450);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SplashScreen";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel_list;
        private System.Windows.Forms.Timer timer;
        private PictureBox pictureBox1;
        private Label label1;
    }
}