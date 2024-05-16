using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using FontAwesome.Sharp;
using HumanBenchmark;
using System.Reflection;

namespace WinFormsAppGameVerse
{
    internal class HomeController
    {
        Form1 mainForm;
        
        IconButton[] Buttons;
   
        public HomeController(Form1 mainForm)
        {
            this.mainForm = mainForm;
            Buttons = [mainForm.HomeButton, mainForm.GamesButton, mainForm.StatsButton, mainForm.SettingsButton, mainForm.SupportButton];

            Init();
        }

        public void Init()
        {
            foreach(var button in Buttons)
            {
                button.Click += HandleButtonClick!;
            }
            foreach(var screen in mainForm.Screens)
            {
                mainForm.Controls.Add(screen);
               
                screen.Width = mainForm.ClientRectangle.Width;
                screen.Height = mainForm.ClientRectangle.Height;
                screen.Location = new Point(mainForm.Sidebar.Width, mainForm.TopBar.Height); 
                screen.BackColor = CustomColor.SecondaryColor;
                screen.Hide();
            }
            mainForm.Screens[0].Show();
            mainForm.Screens[0].BringToFront();


        }
       
        public void HandleButtonClick(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            int index = Convert.ToInt32(button.Tag);

            foreach (UserControl screen in mainForm.Screens)
            {
                screen.Hide();
            }

            mainForm.Screens[index].Show();
            mainForm.Screens[index].BringToFront();

            mainForm.Text = button.Text;
        }
    }
}
