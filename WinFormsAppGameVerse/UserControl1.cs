﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppGameVerse
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public void sayHello()
        {
            textBox1.Text = "Hello world";
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
