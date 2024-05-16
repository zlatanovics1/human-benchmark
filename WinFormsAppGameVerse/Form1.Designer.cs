namespace WinFormsAppGameVerse
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel7 = new Panel();
            menuButton = new FontAwesome.Sharp.IconButton();
            panel4 = new Panel();
            panel5 = new Panel();
            homeButton = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            gamesButton = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            statsButton = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            settingsButton = new FontAwesome.Sharp.IconButton();
            panel6 = new Panel();
            supportButton = new FontAwesome.Sharp.IconButton();
            panel8 = new Panel();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            flowLayoutPanel1.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(23, 24, 29);
            flowLayoutPanel1.Controls.Add(panel7);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel6);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(302, 673);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Controls.Add(menuButton);
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(254, 85);
            panel7.TabIndex = 4;
            // 
            // menuButton
            // 
            menuButton.BackColor = Color.FromArgb(24, 23, 29);
            menuButton.Cursor = Cursors.Hand;
            menuButton.FlatAppearance.BorderSize = 0;
            menuButton.IconChar = FontAwesome.Sharp.IconChar.CaretDown;
            menuButton.IconColor = Color.White;
            menuButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuButton.IconSize = 40;
            menuButton.ImageAlign = ContentAlignment.TopLeft;
            menuButton.Location = new Point(-21, -18);
            menuButton.Name = "menuButton";
            menuButton.Padding = new Padding(28, 25, 0, 0);
            menuButton.Size = new Size(310, 124);
            menuButton.TabIndex = 6;
            menuButton.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Location = new Point(3, 94);
            panel4.Name = "panel4";
            panel4.Size = new Size(254, 85);
            panel4.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.Controls.Add(homeButton);
            panel5.Location = new Point(3, 185);
            panel5.Name = "panel5";
            panel5.Size = new Size(305, 85);
            panel5.TabIndex = 3;
            // 
            // homeButton
            // 
            homeButton.BackColor = Color.FromArgb(23, 24, 29);
            homeButton.Cursor = Cursors.Hand;
            homeButton.FlatAppearance.BorderSize = 0;
            homeButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            homeButton.ForeColor = Color.White;
            homeButton.IconChar = FontAwesome.Sharp.IconChar.HomeLgAlt;
            homeButton.IconColor = Color.White;
            homeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            homeButton.IconSize = 36;
            homeButton.ImageAlign = ContentAlignment.MiddleLeft;
            homeButton.Location = new Point(-8, -10);
            homeButton.Name = "homeButton";
            homeButton.Padding = new Padding(24, 0, 0, 0);
            homeButton.Size = new Size(343, 103);
            homeButton.TabIndex = 6;
            homeButton.Tag = "0";
            homeButton.Text = "   Home";
            homeButton.TextAlign = ContentAlignment.MiddleLeft;
            homeButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            homeButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(gamesButton);
            panel1.Location = new Point(3, 276);
            panel1.Name = "panel1";
            panel1.Size = new Size(305, 85);
            panel1.TabIndex = 1;
            // 
            // gamesButton
            // 
            gamesButton.BackColor = Color.FromArgb(23, 24, 29);
            gamesButton.Cursor = Cursors.Hand;
            gamesButton.FlatAppearance.BorderSize = 0;
            gamesButton.Font = new Font("Segoe UI", 14F);
            gamesButton.ForeColor = Color.White;
            gamesButton.IconChar = FontAwesome.Sharp.IconChar.Gamepad;
            gamesButton.IconColor = Color.White;
            gamesButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            gamesButton.IconSize = 36;
            gamesButton.ImageAlign = ContentAlignment.MiddleLeft;
            gamesButton.Location = new Point(-7, -13);
            gamesButton.Name = "gamesButton";
            gamesButton.Padding = new Padding(24, 0, 0, 0);
            gamesButton.Size = new Size(324, 119);
            gamesButton.TabIndex = 5;
            gamesButton.Tag = "1";
            gamesButton.Text = "   Games";
            gamesButton.TextAlign = ContentAlignment.MiddleLeft;
            gamesButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            gamesButton.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(statsButton);
            panel2.Location = new Point(3, 367);
            panel2.Name = "panel2";
            panel2.Size = new Size(335, 85);
            panel2.TabIndex = 2;
            // 
            // statsButton
            // 
            statsButton.BackColor = Color.FromArgb(23, 24, 29);
            statsButton.Cursor = Cursors.Hand;
            statsButton.FlatAppearance.BorderSize = 0;
            statsButton.Font = new Font("Segoe UI", 14F);
            statsButton.ForeColor = Color.White;
            statsButton.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            statsButton.IconColor = Color.White;
            statsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            statsButton.IconSize = 36;
            statsButton.ImageAlign = ContentAlignment.MiddleLeft;
            statsButton.Location = new Point(-7, -10);
            statsButton.Name = "statsButton";
            statsButton.Padding = new Padding(24, 0, 0, 0);
            statsButton.Size = new Size(349, 108);
            statsButton.TabIndex = 4;
            statsButton.Tag = "2";
            statsButton.Text = "   Stats";
            statsButton.TextAlign = ContentAlignment.MiddleLeft;
            statsButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            statsButton.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(settingsButton);
            panel3.Location = new Point(3, 458);
            panel3.Name = "panel3";
            panel3.Size = new Size(317, 85);
            panel3.TabIndex = 3;
            // 
            // settingsButton
            // 
            settingsButton.BackColor = Color.FromArgb(23, 24, 29);
            settingsButton.Cursor = Cursors.Hand;
            settingsButton.FlatAppearance.BorderSize = 0;
            settingsButton.Font = new Font("Segoe UI", 14F);
            settingsButton.ForeColor = Color.White;
            settingsButton.IconChar = FontAwesome.Sharp.IconChar.Gear;
            settingsButton.IconColor = Color.White;
            settingsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            settingsButton.IconSize = 36;
            settingsButton.ImageAlign = ContentAlignment.MiddleLeft;
            settingsButton.Location = new Point(-7, -12);
            settingsButton.Name = "settingsButton";
            settingsButton.Padding = new Padding(24, 0, 0, 0);
            settingsButton.Size = new Size(324, 108);
            settingsButton.TabIndex = 3;
            settingsButton.Tag = "3";
            settingsButton.Text = "   Settings";
            settingsButton.TextAlign = ContentAlignment.MiddleLeft;
            settingsButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            settingsButton.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(supportButton);
            panel6.Location = new Point(3, 549);
            panel6.Name = "panel6";
            panel6.Size = new Size(305, 85);
            panel6.TabIndex = 3;
            // 
            // supportButton
            // 
            supportButton.BackColor = Color.FromArgb(23, 24, 29);
            supportButton.Cursor = Cursors.Hand;
            supportButton.FlatAppearance.BorderSize = 0;
            supportButton.Font = new Font("Segoe UI", 14F);
            supportButton.ForeColor = Color.White;
            supportButton.IconChar = FontAwesome.Sharp.IconChar.Users;
            supportButton.IconColor = Color.White;
            supportButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            supportButton.IconSize = 36;
            supportButton.ImageAlign = ContentAlignment.MiddleLeft;
            supportButton.Location = new Point(-7, -11);
            supportButton.Name = "supportButton";
            supportButton.Padding = new Padding(24, 0, 0, 0);
            supportButton.Size = new Size(342, 108);
            supportButton.TabIndex = 2;
            supportButton.Tag = "4";
            supportButton.Text = "   Support";
            supportButton.TextAlign = ContentAlignment.MiddleLeft;
            supportButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            supportButton.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(23, 24, 35);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(302, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(1077, 56);
            panel8.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(375, 175);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1079, 512);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1379, 673);
            Controls.Add(pictureBox1);
            Controls.Add(panel8);
            Controls.Add(flowLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private FontAwesome.Sharp.IconButton supportButton;
        private Panel panel4;
        private Panel panel5;
        private FontAwesome.Sharp.IconButton gamesButton;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton statsButton;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton settingsButton;
        private Panel panel6;
        private FontAwesome.Sharp.IconButton homeButton;
        private Panel panel7;
        private Panel panel8;
        private FontAwesome.Sharp.IconButton menuButton;
        private System.Windows.Forms.Timer sidebarTimer;
        private Home userControl11;
        private Games userControl21;
        private PictureBox pictureBox1;
    }
}
