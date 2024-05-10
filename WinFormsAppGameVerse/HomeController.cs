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
        public UserControl[] screens = { new UserControl1(), new UserControl2() };
        public HomeController(Form1 mainForm) {
            this.mainForm = mainForm;
            init();
        }

        public void init()
        {
            mainForm.Button1.Click += HandleButtonClick!;
            mainForm.Button2.Click += HandleButtonClick!;

            
            foreach (var screen in screens)
            {
                this.mainForm.Controls.Add(screen);
                screen.Width = this.mainForm.ClientRectangle.Width - this.mainForm.Panel1.Width;
                screen.Height = this.mainForm.ClientRectangle.Height;
                screen.Location = new Point(this.mainForm.Panel1.Width, 0);
                screen.Hide();

            }
            screens[0].Show();
            ((UserControl1)screens[0]).sayHello();
        }
        public void HandleButtonClick(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            int index = Convert.ToInt32(button.Tag);
            foreach( UserControl screen in screens)
            {
                screen.Hide();
            }
            screens[index].Show();
            screens[index].BringToFront();
            this.mainForm.Text = button.Text;
        }
    }
}
