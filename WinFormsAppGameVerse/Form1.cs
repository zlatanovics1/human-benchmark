namespace WinFormsAppGameVerse
{
    public partial class Form1 : Form
    {
        

        public Button Button1 => button1;
        public Button Button2 => button2;
        public Panel Panel1 => panel1;

        
       
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
            _ = new HomeController(this);

        }

 
    }
}
