namespace TrollButon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Random RND= new Random();
          button1.Top= RND.Next(700);
            button1.Left = RND.Next(500, 1500);
        }
    }
}