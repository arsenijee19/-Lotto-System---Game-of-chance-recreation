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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static string chosenNumbers;
        private void PassArray()
        {
            if (array.Length > 0)
            {
                Form3 f3 = new Form3();
                f3.ShowArray(array);
            }
            else
                MessageBox.Show("Niz je prazan");
        }

        public int[] array = new int[7];
        public int n = 0;
        Form myForm3 = new Form3();

        private void roundPicture1_Click(object sender, EventArgs e)
        {
            n++;
            array[n] = 1;
            textBox1.Text += " 1 ";
            roundPicture1.Enabled = false;
            if (n == 6)
            {
                MessageBox.Show("Uspešno ste izabrali Vaše brojeve! Srećno!");
                myForm3.Show();
                this.Visible = false;
                PassArray();
            }

        }

        private void roundPicture2_Click(object sender, EventArgs e)
        {
            n++;
            array[n] = 2;
            textBox1.Text += " 2 ";
            roundPicture2.Enabled = false;
            if (n == 6)
            {
                MessageBox.Show("Uspešno ste izabrali Vaše brojeve! Srećno!");
                myForm3.Show();
                this.Visible = false;
            }

        }
        private void roundPicture3_Click(object sender, EventArgs e)
        {
            n++;
            array[n] = 3;
            textBox1.Text += " 3 ";
            roundPicture3.Enabled = false;
            if (n == 6)
            {
                MessageBox.Show("Uspešno ste izabrali Vaše brojeve! Srećno!");
                myForm3.Show();
                this.Visible = false;
            }
        }
        private void roundPicture4_Click(object sender, EventArgs e)
        {
            n++;
            array[n] = 4;
            textBox1.Text += " 4 ";
            roundPicture4.Enabled = false;
            if (n == 6)
            {
                MessageBox.Show("Uspešno ste izabrali Vaše brojeve! Srećno!");
                myForm3.Show();
                this.Visible = false;
            }

        }

        private void roundPicture5_Click(object sender, EventArgs e)
        {
            n++;
            array[n] = 5;
            textBox1.Text += " 5 ";
            roundPicture5.Enabled = false;
            if (n == 6)
            {
                MessageBox.Show("Uspešno ste izabrali Vaše brojeve! Srećno!");
                myForm3.Show();
                this.Visible = false;
            }

        }

        private void roundPicture6_Click(object sender, EventArgs e)
        {
            n++;
            array[n] = 6;
            textBox1.Text += " 6 ";
            roundPicture6.Enabled = false;

            if (n == 6)
            {
                MessageBox.Show("Uspešno ste izabrali Vaše brojeve! Srećno!");
                myForm3.Show();
                this.Visible = false;
            }

        }

        private void roundPicture7_Click(object sender, EventArgs e)
        {
            n++;
            array[n] = 7;
            textBox1.Text += " 7 ";
            roundPicture7.Enabled = false;
            if (n == 6)
            {
                chosenNumbers = textBox1.Text;
                MessageBox.Show("Uspešno ste izabrali Vaše brojeve! Srećno!");
                myForm3.Show();
                this.Visible = false;
            }

        }

        private void roundPicture8_Click(object sender, EventArgs e)
        {
            n++;
            array[n] = 8;
            textBox1.Text += " 8 ";
            roundPicture8.Enabled = false;
            if (n == 6)
            {
                MessageBox.Show("Uspešno ste izabrali Vaše brojeve! Srećno!");
                myForm3.Show();
                this.Visible = false;
            }

        }

        private void roundPicture11_Click(object sender, EventArgs e)
        {
            n++;
            array[n] = 11;
            textBox1.Text += " 11 ";
            roundPicture11.Enabled = false;
            if (n == 6)
            {
                MessageBox.Show("Uspešno ste izabrali Vaše brojeve! Srećno!");
                myForm3.Show();
                this.Visible = false;
            }

        }

        private void roundPicture9_Click(object sender, EventArgs e)
        {
            n++;
            array[n] = 9;
            textBox1.Text += " 9 ";
            roundPicture9.Enabled = false;
            if (n == 6)
            {
                MessageBox.Show("Uspešno ste izabrali Vaše brojeve! Srećno!");
                myForm3.Show();
                this.Visible = false;
            }

        }

        private void roundPicture10_Click(object sender, EventArgs e)
        {
            n++;
            array[n] = 10;
            textBox1.Text += " 10 ";
            roundPicture10.Enabled = false;
            if (n == 6)
            {
                MessageBox.Show("Uspešno ste izabrali Vaše brojeve! Srećno!");
                myForm3.Show();
                this.Visible = false;
            }

        }

        private void roundPicture12_Click(object sender, EventArgs e)
        {
            n++;
            array[n] = 12;
            textBox1.Text += " 12 ";
            roundPicture12.Enabled = false;
            if (n == 6)
            {
                MessageBox.Show("Uspešno ste izabrali Vaše brojeve! Srećno!");
                myForm3.Show();
                this.Visible = false;
            }

        }

        private void roundPicture13_Click(object sender, EventArgs e)
        {
            n++;
            array[n] = 13;
            textBox1.Text += " 13 ";
            roundPicture13.Enabled = false;
            if (n == 6)
            {
                MessageBox.Show("Uspešno ste izabrali Vaše brojeve! Srećno!");
                myForm3.Show();
                this.Visible = false;
            }

        }

        private void roundPicture14_Click(object sender, EventArgs e)
        {
            n++;
            array[n] = 14;
            textBox1.Text += " 14 ";
            roundPicture14.Enabled = false;
            if (n == 6)
            {
                MessageBox.Show("Uspešno ste izabrali Vaše brojeve! Srećno!");
                myForm3.Show();
                this.Visible = false;
            }

        }

        private void roundPicture15_Click(object sender, EventArgs e)
        {
            n++;
            array[n] = 15;
            textBox1.Text += " 15 ";
            roundPicture15.Enabled = false;
            if (n == 6)
            {
                MessageBox.Show("Uspešno ste izabrali Vaše brojeve! Srećno!");
                myForm3.Show();
                this.Visible = false;
            }

        }

        private void roundPicture16_Click(object sender, EventArgs e)
        {
            n++;
            array[n] = 16;
            textBox1.Text += " 16 ";
            roundPicture16.Enabled = false;
            if (n == 6)
            {
                MessageBox.Show("Uspešno ste izabrali Vaše brojeve! Srećno!");
                myForm3.Show();
                this.Visible = false;
            }

        }

        private void roundPicture17_Click(object sender, EventArgs e)
        {
            n++;
            array[n] = 17;
            textBox1.Text += " 17 ";
            roundPicture17.Enabled = false;

            if (n == 6)
            {
                MessageBox.Show("Uspešno ste izabrali Vaše brojeve! Srećno!");
                myForm3.Show();
                this.Visible = false;
            }

        }

        private void roundPicture18_Click(object sender, EventArgs e)
        {
            n++;
            array[n] = 18;
            textBox1.Text += " 18 ";
            roundPicture18.Enabled = false;
            if (n == 6)
            {
                MessageBox.Show("Uspešno ste izabrali Vaše brojeve! Srećno!");
                myForm3.Show();
                this.Visible = false;
            }

        }

        private void roundPicture19_Click(object sender, EventArgs e)
        {
            n++;
            array[n] = 19;
            textBox1.Text += " 19 ";
            roundPicture19.Enabled = false;
            if (n == 6)
            {
                MessageBox.Show("Uspešno ste izabrali Vaše brojeve! Srećno!");
                myForm3.Show();
                this.Visible = false;
            }
        }

        private void roundPicture20_Click(object sender, EventArgs e)
        {
            n++;
            array[n] = 20;
            textBox1.Text += " 20 ";
            roundPicture20.Enabled = false;
            if (n == 6)
            {
                MessageBox.Show("Uspešno ste izabrali Vaše brojeve! Srećno!");
                myForm3.Show();
                this.Visible = false;
            }
        }

        private void roundPicture21_Click(object sender, EventArgs e)
        {
            n++;
            array[n] = 21;
            textBox1.Text += " 21 ";
            roundPicture21.Enabled = false;
            if (n == 6)
            {
                MessageBox.Show("Uspešno ste izabrali Vaše brojeve! Srećno!");
                myForm3.Show();
                this.Visible = false;
            }

        }

        private void roundPicture22_Click(object sender, EventArgs e)
        {
            n++;
            array[n] = 22;
            textBox1.Text += " 22 ";
            roundPicture22.Enabled = false;
            if (n == 6)
            {
                MessageBox.Show("Uspešno ste izabrali Vaše brojeve! Srećno!");
                PassArray();
                myForm3.Show();
                this.Visible = false;
                
            }

        }



    }
}
