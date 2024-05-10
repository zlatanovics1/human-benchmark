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
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            userControl11 = new UserControl1();
            userControl21 = new UserControl2();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(208, 445);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(50, 240);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Tag = "1";
            button2.Text = "Home";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(50, 308);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Tag = "0";
            button1.Text = "Settings";
            button1.UseVisualStyleBackColor = true;
            // 
            // userControl11
            // 
            userControl11.BackColor = SystemColors.ActiveCaption;
            userControl11.Location = new Point(214, 1);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(584, 471);
            userControl11.TabIndex = 1;
            userControl11.Visible = false;
            // 
            // userControl21
            // 
            userControl21.BackColor = Color.FromArgb(255, 192, 128);
            userControl21.Location = new Point(214, 1);
            userControl21.Name = "userControl21";
            userControl21.Size = new Size(584, 445);
            userControl21.TabIndex = 2;
            userControl21.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(userControl11);
            Controls.Add(panel1);
            Controls.Add(userControl21);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button button1;
        private UserControl1 userControl11;
        private UserControl2 userControl21;
    }
}
