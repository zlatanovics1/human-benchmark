using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsAppGameVerse;

namespace HumanBenchmark
{
    public class CustomScreen:UserControl
    {
        protected Label headingLabel;
        public CustomScreen()
        {
            headingLabel = new Label();
            string fontFilePath = "C:\\Users\\zlata\\Downloads\\Montserrat\\Montserrat-VariableFont_wght.ttf";
            Form1.privateFontCollection.AddFontFile(fontFilePath);
        }
        public void init(string name)
        {
            Controls.Add(headingLabel);
            headingLabel.Location = new Point(15,30);
            headingLabel.Font = new Font(Font.FontFamily, 48, FontStyle.Bold);
            headingLabel.ForeColor = Color.White;
            headingLabel.AutoSize = true;
            headingLabel.Text = name;

           
            
        }
    }
}
