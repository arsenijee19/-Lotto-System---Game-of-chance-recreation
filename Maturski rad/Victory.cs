using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maturski_rad
{
    public partial class Victory : Form
    {
        public Victory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var myForm1 = new Form1();
            myForm1.Show();
            this.Visible = false;
            Form2 obj = (Form2)Application.OpenForms["Form2"];
            obj.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 obj = (Form2)Application.OpenForms["Form2"];
            obj.Close();
        }
    }
}
