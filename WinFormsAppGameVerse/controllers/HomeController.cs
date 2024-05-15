using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WinFormsAppGameVerse
{
    internal class HomeController
    {
        Form1 mainForm;
        public UserControl[] screens = [new UserControl1(), new UserControl2()];
   
        public HomeController(Form1 mainForm)
        {
            this.mainForm = mainForm;
        

        }

       
        public void HandleButtonClick(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            int index = Convert.ToInt32(button.Tag);

            foreach (UserControl screen in screens)
            {
                screen.Hide();
            }

            screens[index].Show();
            screens[index].BringToFront();

            mainForm.Text = button.Text;
        }
    }
}
