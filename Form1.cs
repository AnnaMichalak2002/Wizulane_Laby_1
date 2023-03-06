namespace Wizulane_Laby_1
{
    public partial class DigitalClock : Form
    {
        public DigitalClock()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}