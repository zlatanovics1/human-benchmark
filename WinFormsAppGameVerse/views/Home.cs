using HumanBenchmark;
using System;
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
    public partial class Home : CustomScreen
    {
        public Home()
        {
            InitializeComponent();
            init("Home");
        }

        int typed = 0;

         KeysConverter keysConverter = new KeysConverter();

        private void UserControl1_Load(object sender, EventArgs e)
        {
            this.KeyDown += handleTyping!;
            richTextBox1.Text = "Lorem IPSUM sit dolor amet gi rogld fosls forsld".ToLower();
            // stop focus event
            richTextBox1.ReadOnly = true;
            richTextBox1.TabStop = false;
            //styling
            richTextBox1.BackColor = this.BackColor;
            richTextBox1.ForeColor = Color.White;
            richTextBox1.Width = ClientRectangle.Width;
            richTextBox1.Font = new Font(Font.FontFamily,30,FontStyle.Italic);
            richTextBox1.Font = Form1.customFont;
            richTextBox1.Location = new Point(50, this.ClientRectangle.Height / 2 - 50);
            richTextBox1.BorderStyle = BorderStyle.None;
        }
        

        private void handleTyping(object sender, KeyEventArgs e)
        {

            if (typed > richTextBox1.Text.Length - 1) return;

            string letter = keysConverter.ConvertToString(e.KeyCode)!.ToLower();
            string currentLetter  = Convert.ToString(richTextBox1.Text[typed]);


            richTextBox1.Select(typed++, 1);
            if (letter != currentLetter)
                richTextBox1.SelectionColor = ColorTranslator.FromHtml("#ef4444");
            else
                richTextBox1.SelectionColor = ColorTranslator.FromHtml("#86efac");

            richTextBox1.Select(0,typed);
            richTextBox1.SelectionFont = new Font(Font.FontFamily, 30, FontStyle.Regular);
            richTextBox1.DeselectAll();

        }

    }
}
