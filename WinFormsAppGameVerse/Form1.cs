namespace WinFormsAppGameVerse
{
    public partial class Form1 : Form
    {
        UserControl screen1 = new UserControl1();
        UserControl screen2 = new UserControl2();
        public Form1()
        {
            InitializeComponent();

            // Add user controls to the form
            this.Controls.Add(screen1);
            this.Controls.Add(screen2);

            screen1.Width = ClientRectangle.Width - panel1.Width;
            screen1.Location = new Point(panel1.Width, 0);
            screen2.Width = ClientRectangle.Width - panel1.Width;
            screen2.Location = new Point(panel1.Width, 0);
            
        }

        UserControl[] screens = { new UserControl1(), new UserControl2() };
        private void button2_Click(object sender, EventArgs e)
        {
            /*foreach (var screen in screens)
            {
                screen.Hide();
            }*/
            screen1.Hide();
            screen2.Show();
            screen2.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*foreach (var screen in screens)
            {
                screen.Hide();
            }*/
            screen2.Hide();
            screen1.Show();
            screen1.BringToFront();
        }

        private void userControl21_Load(object sender, EventArgs e)
        {

        }
    }
}
