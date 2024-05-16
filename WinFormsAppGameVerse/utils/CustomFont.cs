using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanBenchmark
{
    internal class CustomFont
    {
        public static Font LoadFont(int size = 14, FontStyle style = FontStyle.Regular)
        {
            PrivateFontCollection privateFontCollection = new();
            string fontFilePath = "C:\\Users\\zlata\\Downloads\\Montserrat\\Montserrat-VariableFont_wght.ttf";
            privateFontCollection.AddFontFile(fontFilePath);
            Font customFont = new(privateFontCollection.Families[0], size, style);

            return customFont;
        }
    }
}
