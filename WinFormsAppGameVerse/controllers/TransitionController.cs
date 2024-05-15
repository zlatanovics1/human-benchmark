using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WinFormsAppGameVerse;

namespace HumanBenchmark.controllers
{
    internal class TransitionController
    {
        Form1 mainForm;
        bool sideBarHide = false;
        IconButton[] Buttons;


        public TransitionController(Form1 form) {
            this.mainForm = form;

            Buttons = [mainForm.HomeButton, mainForm.GamesButton, mainForm.StatsButton, mainForm.SettingsButton, mainForm.SupportButton];
            init();
        }

        public void init()
        {
            

            foreach(IconButton button in Buttons)
            {

                button.MouseEnter += handleButtonEnter!;
                button.MouseLeave += handleButtonLeave!;
            }


            this.mainForm.MenuButton.Click += handleMenuButtonClick!;

            /// sidebar animation

            mainForm.SidebarTimer.Interval = 1;
            mainForm.SidebarTimer.Tick += handleSidebarTimerTick!;

         

        }

        public void handleSidebarTimerTick(object sender, EventArgs e)
        {
            if (sideBarHide)
            {

                if(mainForm.Sidebar.Width - 25 < 70)
                {
                    mainForm.Sidebar.Width = 70;
                    mainForm.SidebarTimer.Stop();
                    return;
                }
                mainForm.Sidebar.Width -= 25;
            }
            else
            {
                if(mainForm.Sidebar.Width + 25 > 300)
                {
                    mainForm.Sidebar.Width = 300;
                    mainForm.SidebarTimer.Stop();
                    return;
                }
                mainForm.Sidebar.Width += 25;
            }

        }

       

        public void handleMenuButtonClick(object sender, EventArgs e)
        {
            sideBarHide = !sideBarHide;
            mainForm.SidebarTimer.Start();
            if (sideBarHide) mainForm.MenuButton.IconChar = FontAwesome.Sharp.IconChar.CaretDown;           
            else mainForm.MenuButton.IconChar = FontAwesome.Sharp.IconChar.CaretRight;           
        }

        public void handleButtonEnter(object sender, EventArgs e)
        {
            IconButton button = (IconButton)sender;
            button.BackColor = ColorTranslator.FromHtml("#6d28d9");
            button.Padding = new Padding(button.Padding.Left + 3, 0, 0, 0);
                        

        }
        public void handleButtonLeave(object sender, EventArgs e)
        {
            IconButton button = (IconButton)sender;
            button.BackColor = Color.FromArgb(24, 23, 29); 
            button.Padding = new Padding(24, 0, 0, 0);
            
        }
    }
}
