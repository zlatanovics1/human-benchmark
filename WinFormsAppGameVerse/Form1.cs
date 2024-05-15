using FontAwesome.Sharp;
using HumanBenchmark.controllers;

namespace WinFormsAppGameVerse
{
    public partial class Form1 : Form
    {


        public IconButton MenuButton => menuButton;
        public IconButton HomeButton => homeButton;
        public IconButton GamesButton => gamesButton;
        public IconButton StatsButton => statsButton;
        public IconButton SettingsButton => settingsButton;
        public IconButton SupportButton => supportButton;



        public FlowLayoutPanel Sidebar => flowLayoutPanel1;

        public System.Windows.Forms.Timer SidebarTimer => sidebarTimer;
       
      

        public Form1()
        {
            InitializeComponent();
            
            //
            // styling
            //
            this.WindowState = FormWindowState.Maximized;
            //this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen!.Bounds;

            //
            // controllers
            //
            // _ = new HomeController(this);
            _ = new TransitionController(this);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initComponents();
        }

        public void initComponents()
        {
            //panel8.Width = ClientRectangle.Width - flowLayoutPanel1.Width;
        }

        private void menuButton_Click(object sender, EventArgs e)
        {

        }
    }
}
