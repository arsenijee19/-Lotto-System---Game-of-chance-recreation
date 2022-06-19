namespace Maturski_rad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var myForm2 = new Form2();
            myForm2.Show();
            this.Visible = false; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}