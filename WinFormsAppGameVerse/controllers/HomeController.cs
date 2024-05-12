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
            init();
            

        }

        public async void init()
        {
            UserClient userClient = new UserClient();
            User[] users = await userClient.GetUsers();

            string str = "";
            string str2 = "";
            foreach(User user in users)
            {
                str += " "  + user.name;
                str2 += "\n " + user.email;
            }
            ((UserControl1)screens[0]).SayHello(str,str2);

            mainForm.Button1.Click += HandleButtonClick!;
            mainForm.Button2.Click += HandleButtonClick!;


            foreach (var screen in screens)
            {
                // init screens
                mainForm.Controls.Add(screen);
                screen.Width = mainForm.ClientRectangle.Width - mainForm.Panel1.Width;
                screen.Height = mainForm.ClientRectangle.Height;
                screen.Location = new Point(mainForm.Panel1.Width, 0);
                screen.Hide();

            }
            screens[0].Show();
            
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
