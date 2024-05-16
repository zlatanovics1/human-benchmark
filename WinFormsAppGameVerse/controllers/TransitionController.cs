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
        readonly Form1 mainForm;
        bool sideBarHide = false;
        IconButton[] Buttons;
        IconButton activeButton;

        public TransitionController(Form1 form) {
            this.mainForm = form;
            activeButton = mainForm.HomeButton;
            Buttons = [mainForm.HomeButton, mainForm.GamesButton, mainForm.StatsButton, mainForm.SettingsButton, mainForm.SupportButton];
            init();
        }

        public void init()
        {
            mainForm.BackColor = CustomColor.SecondaryColor;
            mainForm.Sidebar.BackColor = CustomColor.PrimaryColor;
            mainForm.TopBar.BackColor = CustomColor.PrimaryColor;
            mainForm.MenuButton.BackColor = CustomColor.PrimaryColor;
            mainForm.MenuButton.IconChar = IconChar.CaretRight;


            foreach(IconButton button in Buttons)
            {

                button.MouseEnter += handleButtonEnter!;
                button.MouseLeave += handleButtonLeave!;
                button.Click += handleButtonClick!;
                button.BackColor = CustomColor.PrimaryColor;
            }
            activateButton(activeButton);

            this.mainForm.MenuButton.Click += handleMenuButtonClick!;
            
            /// sidebar animation

            mainForm.SidebarTimer.Interval = 1;
            mainForm.SidebarTimer.Tick += handleSidebarTimerTick!;

         

        }
        public void resetButton(IconButton button)
        {
            button.BackColor = CustomColor.PrimaryColor;
            button.IconColor = Color.White;
            button.ForeColor = Color.White;
            button.Padding = new Padding(24, 0, 0, 0);
        }

        public void activateButton(IconButton button)
        {
            button.BackColor = CustomColor.ActiveColor;
            button.ForeColor = ColorTranslator.FromHtml("#6366f1");
            button.IconColor = ColorTranslator.FromHtml("#6366f1");
            button.Padding = new Padding(24 + 5, 0, 0, 0);
        

        }


        public void handleSidebarTimerTick(object sender, EventArgs e)
        {
            if (sideBarHide)
            {

                if(mainForm.Sidebar.Width - 25 < 80)
                {
                    mainForm.Sidebar.Width = 80;
                    mainForm.SidebarTimer.Stop();
                   
                }
                else mainForm.Sidebar.Width -= 25;
               
            }
            else
            {
                if(mainForm.Sidebar.Width + 25 > 300)
                {
                    mainForm.Sidebar.Width = 300;
                    mainForm.SidebarTimer.Stop();
                    
                }
                else mainForm.Sidebar.Width += 25;
            }
            foreach(var screen in mainForm.Screens)
            {
                screen.Location = new Point(mainForm.Sidebar.Width, mainForm.TopBar.Height);
            }

        }

       

        public void handleMenuButtonClick(object sender, EventArgs e)
        {
            //mainForm.Sidebar.BringToFront();
            sideBarHide = !sideBarHide;
            mainForm.SidebarTimer.Start();
            if (sideBarHide) mainForm.MenuButton.IconChar = IconChar.CaretDown;           
            else mainForm.MenuButton.IconChar = IconChar.CaretRight;           
        }

        public void handleButtonEnter(object sender, EventArgs e)
        {
            IconButton button = (IconButton)sender;
            if (button == activeButton) return;
            button.ForeColor = CustomColor.HoverColor;
            button.IconColor = CustomColor.HoverColor;
            button.Padding = new Padding(button.Padding.Left + 3, 0, 0, 0);
                        

        }
        public void handleButtonLeave(object sender, EventArgs e)
        {
            IconButton button = (IconButton)sender;
            if (button == activeButton) return;
            resetButton(button);

            
        }

        public void handleButtonClick(object sender, EventArgs e)
        {

            IconButton button = (IconButton)sender;
            if(activeButton == button) return;

            // reset active button
            resetButton(activeButton);

            activateButton(button);
            activeButton = button;
        }
    }
}
