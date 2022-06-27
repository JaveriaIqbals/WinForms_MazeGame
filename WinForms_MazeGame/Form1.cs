namespace WinForms_MazeGame
{
    public partial class Form1 : Form
    {
        Point stPos;
        int countSeconds;

        public Form1()
        {
            InitializeComponent();
            countSeconds = 0;

            StartGame();
        }

        void StartGame()
        {
            // set Mouse at a location
            stPos = panel1.Location;
            Cursor.Position = PointToScreen(stPos);

            timer1.Start();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label19_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("You have touched the wall, restart the game");
            StartGame();
        }

        private void lbl_stop_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("You are the WINNER!");
            //timer1.Stop();
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Text = countSeconds.ToString();
            countSeconds++;
            if (countSeconds == 15)
            {
                MessageBox.Show("You have LOST the game");
                countSeconds = 0;
                StartGame();
            }
        }
    }
}