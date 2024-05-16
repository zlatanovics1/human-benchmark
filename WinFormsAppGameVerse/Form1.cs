using FontAwesome.Sharp;
using HumanBenchmark.controllers;
using HumanBenchmark.views;
using System.Drawing.Text;
using System.Windows.Forms;

namespace WinFormsAppGameVerse
{
    public partial class Form1 : Form
    {

        public UserControl[] Screens = [new Home(), new Games(),new Stats(),new Settings(),new Support()];
        public IconButton MenuButton => menuButton;
        public IconButton HomeButton => homeButton;
        public IconButton GamesButton => gamesButton;
        public IconButton StatsButton => statsButton;
        public IconButton SettingsButton => settingsButton;
        public IconButton SupportButton => supportButton;



        public FlowLayoutPanel Sidebar => flowLayoutPanel1;
        public Panel TopBar => panel8;

        public System.Windows.Forms.Timer SidebarTimer => sidebarTimer;

        public static Font customFont;
        public static PrivateFontCollection privateFontCollection = new();


        public Form1()
        {
            InitializeComponent();
            LoadRobotoFont();
            
            //
            // styling OBAVEZNO PRE ZVANJE KONTROLERI DA NE KORISTI MANJI WIDTH/HEIGHT
            //
            this.WindowState = FormWindowState.Maximized;
            //this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen!.Bounds;

            //
            // controllers
            //
            _ = new TransitionController(this);
            _ = new HomeController(this);

        }

        private void LoadRobotoFont()
        {
            string fontFilePath = "C:\\Users\\zlata\\Downloads\\Montserrat\\Montserrat-VariableFont_wght.ttf";
            privateFontCollection.AddFontFile(fontFilePath);
            customFont = new Font(privateFontCollection.Families[0], 14, FontStyle.Regular);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadRobotoFont();
            initComponents();
            
            homeButton.Font = customFont;
            
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
