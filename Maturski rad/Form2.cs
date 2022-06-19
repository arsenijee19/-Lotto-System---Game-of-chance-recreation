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
        List<Panel> listPanel = new List<Panel>();
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            listPanel.Add(panel1);
            listPanel.Add(panel2);
            listPanel[index].BringToFront();
        }

        int[] Numbers = new int[7];
        int n = 0, index;
        void checkN() /// proverava da li je izabrano tacno 6 brojeva
        {
            if (n == 6)
            {
                MessageBox.Show("Uspešno ste izabrali Vaše brojeve. Srećno!");
                index++;
                listPanel[index].BringToFront();
            }
        }
        List<int> randomNumbers = new List<int>();
        private bool panel2Painted = false;

        int equalNumbers = 0;
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            if (!panel2Painted)
            {
                Random rnd = new Random();
                for (int i = 0; i < 16; i++)
                {
                    int k = rnd.Next(1, 24);
                    while (randomNumbers.Contains(k))
                    {
                        k = rnd.Next(1, 24);
                    }
                    randomNumbers.Add(k);
                    //  aaaa.Text += k + " ";
                }
            }
            panel2Painted = true;
        }
        private void roundPicture1_Click(object sender, EventArgs e)
        {

        }

        private void roundPicture1_Click_1(object sender, EventArgs e)
        {
            n++;
            Numbers[n] = 1;
            textBox1.Text += "1 ";
            checkN();
            roundPicture1.Enabled = false;
            if (randomNumbers.Contains(1))
            {
                equalNumbers++;
            }
        }

        private void roundPicture2_Click(object sender, EventArgs e)
        {
            n++;
            Numbers[n] = 2;
            textBox1.Text += "2 ";
            checkN();
            roundPicture2.Enabled = false;
            if (randomNumbers.Contains(2))
            {
                equalNumbers++;
            }
        }

        private void roundPicture3_Click(object sender, EventArgs e)
        {
            n++;
            Numbers[n] = 3;
            textBox1.Text += "3 ";
            checkN();
            roundPicture3.Enabled = false;
            if (randomNumbers.Contains(3))
            {
                equalNumbers++;
            }
        }

        private void roundPicture4_Click(object sender, EventArgs e)
        {
            n++;
            Numbers[n] = 4;
            textBox1.Text += "4 ";
            checkN();
            roundPicture4.Enabled = false;
            if (randomNumbers.Contains(4))
            {
                equalNumbers++;
            }
        }

        private void roundPicture5_Click(object sender, EventArgs e)
        {
            n++;
            Numbers[n] = 5;
            textBox1.Text += "5 ";
            checkN();
            roundPicture5.Enabled = false;
            if (randomNumbers.Contains(5))
            {
                equalNumbers++;
            }
        }

        private void roundPicture6_Click(object sender, EventArgs e)
        {
            n++;
            Numbers[n] = 6;
            textBox1.Text += "6 ";
            checkN();
            roundPicture6.Enabled = false;
            if (randomNumbers.Contains(6))
            {
                equalNumbers++;
            }
        }

        private void roundPicture7_Click(object sender, EventArgs e)
        {
            n++;
            Numbers[n] = 7;
            textBox1.Text += "7 ";
            checkN();
            roundPicture7.Enabled = false;
            if (randomNumbers.Contains(7))
            {
                equalNumbers++;
            }
        }

        private void roundPicture8_Click(object sender, EventArgs e)
        {
            n++;
            Numbers[n] = 8;
            textBox1.Text += "8 ";
            checkN();
            roundPicture8.Enabled = false;
            if (randomNumbers.Contains(8))
            {
                equalNumbers++;
            }
        }

        private void roundPicture9_Click(object sender, EventArgs e)
        {
            n++;
            Numbers[n] = 9;
            textBox1.Text += "9 ";
            checkN();
            roundPicture9.Enabled = false;
            if (randomNumbers.Contains(9))
            {
                equalNumbers++;
            }
        }

        private void roundPicture10_Click(object sender, EventArgs e)
        {
            n++;
            Numbers[n] = 10;
            textBox1.Text += "10 ";
            checkN();
            roundPicture10.Enabled = false;
            if (randomNumbers.Contains(10))
            {
                equalNumbers++;
            }
        }

        private void roundPicture11_Click(object sender, EventArgs e)
        {
            n++;
            Numbers[n] = 11;
            textBox1.Text += "11 ";
            checkN();
            roundPicture11.Enabled = false;
            if (randomNumbers.Contains(11))
            {
                equalNumbers++;
            }
        }

        private void roundPicture12_Click(object sender, EventArgs e)
        {
            n++;
            Numbers[n] = 12;
            textBox1.Text += "12 ";
            checkN();
            roundPicture12.Enabled = false;
            if (randomNumbers.Contains(12))
            {
                equalNumbers++;
            }
        }

        private void roundPicture13_Click(object sender, EventArgs e)
        {
            n++;
            Numbers[n] = 13;
            textBox1.Text += "13 ";
            checkN();
            roundPicture13.Enabled = false;
            if (randomNumbers.Contains(13))
            {
                equalNumbers++;
            }
        }

        private void roundPicture14_Click(object sender, EventArgs e)
        {
            n++;
            Numbers[n] = 14;
            textBox1.Text += "14 ";
            checkN();
            roundPicture14.Enabled = false;
            if (randomNumbers.Contains(14))
            {
                equalNumbers++;
            }
        }

        private void roundPicture15_Click(object sender, EventArgs e)
        {
            n++;
            Numbers[n] = 15;
            textBox1.Text += "15 ";
            checkN();
            roundPicture15.Enabled = false;
            if (randomNumbers.Contains(15))
            {
                equalNumbers++;
            }
        }

        private void roundPicture16_Click(object sender, EventArgs e)
        {
            n++;
            Numbers[n] = 16;
            textBox1.Text += "16 ";
            checkN();
            roundPicture16.Enabled = false;
            if (randomNumbers.Contains(16))
            {
                equalNumbers++;
            }
        }

        private void roundPicture17_Click(object sender, EventArgs e)
        {
            n++;
            Numbers[n] = 17;
            textBox1.Text += "17 ";
            checkN();
            roundPicture17.Enabled = false;
            if (randomNumbers.Contains(17))
            {
                equalNumbers++;
            }
        }

        private void roundPicture18_Click(object sender, EventArgs e)
        {
            n++;
            Numbers[n] = 18;
            textBox1.Text += "18 ";
            checkN();
            roundPicture18.Enabled = false;
            if (randomNumbers.Contains(18))
            {
                equalNumbers++;
            }
        }

        private void roundPicture19_Click(object sender, EventArgs e)
        {
            n++;
            Numbers[n] = 19;
            textBox1.Text += "19 ";
            checkN();
            roundPicture19.Enabled = false;
            if (randomNumbers.Contains(19))
            {
                equalNumbers++;
            }
        }

        private void roundPicture20_Click(object sender, EventArgs e)
        {
            n++;
            Numbers[n] = 20;
            textBox1.Text += "20 ";
            checkN();
            roundPicture20.Enabled = false;
            if (randomNumbers.Contains(20))
            {
                equalNumbers++;
            }
        }

        private void roundPicture21_Click(object sender, EventArgs e)
        {
            n++;
            Numbers[n] = 21;
            textBox1.Text += "21 ";
            checkN();
            roundPicture21.Enabled = false;
            if (randomNumbers.Contains(21))
            {
                equalNumbers++;
            }
        }

        private void roundPicture22_Click(object sender, EventArgs e)
        {
            n++;
            Numbers[n] = 22;
            textBox1.Text += "22 ";
            checkN();
            roundPicture22.Enabled = false;
            if (randomNumbers.Contains(22))
            {
                equalNumbers++;
            }
        }

        private void roundPicture23_Click(object sender, EventArgs e)
        {
            n++;
            Numbers[n] = 23;
            textBox1.Text += "23 ";
            checkN();
            roundPicture23.Enabled = false;
            if (randomNumbers.Contains(23))
            {
                equalNumbers++;
            }
        }

        private void roundPicture24_Click(object sender, EventArgs e)
        {
            n++;
            Numbers[n] = 24;
            textBox1.Text += "24 ";
            checkN();
            roundPicture24.Enabled = false;
            if (randomNumbers.Contains(24))
            {
                equalNumbers++;
            }
            if (randomNumbers.Contains(24))
            {
                equalNumbers++;
            }
        }
        private async void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            int countStep = 0;

            if (countStep == 0)
            {

                if (randomNumbers[countStep] == 1)
                {
                    roundPicture25.Image = Image.FromFile("../images/1.png");
                    roundPicture26.Image = Image.FromFile("../images/1mm.png");

                }
                if (randomNumbers[countStep] == 2)
                {
                    roundPicture25.Image = Image.FromFile("../images/2.png");
                    roundPicture26.Image = Image.FromFile("../images/2m.png");

                }
                if (randomNumbers[countStep] == 3)
                {
                    roundPicture25.Image = Image.FromFile("../images/3.png");
                    roundPicture26.Image = Image.FromFile("../images/3m.png");

                }
                if (randomNumbers[countStep] == 4)
                {
                    roundPicture25.Image = Image.FromFile("../images/4.png");
                    roundPicture26.Image = Image.FromFile("../images/4m.png");

                }

                if (randomNumbers[countStep] == 5)
                {
                    roundPicture25.Image = Image.FromFile("../images/5.png");
                    roundPicture26.Image = Image.FromFile("../images/5m.png");

                }
                if (randomNumbers[countStep] == 6)
                {
                    roundPicture25.Image = Image.FromFile("../images/6.png");
                    roundPicture26.Image = Image.FromFile("../images/6m.png");

                }
                if (randomNumbers[countStep] == 7)
                {
                    roundPicture25.Image = Image.FromFile("../images/7.png");
                    roundPicture26.Image = Image.FromFile("../images/7m.png");

                }
                if (randomNumbers[countStep] == 8)
                {
                    roundPicture25.Image = Image.FromFile("../images/8.png");
                    roundPicture26.Image = Image.FromFile("../images/8m.png");

                }
                if (randomNumbers[countStep] == 9)
                {
                    roundPicture25.Image = Image.FromFile("../images/9.png");
                    roundPicture26.Image = Image.FromFile("../images/9m.png");

                }
                if (randomNumbers[countStep] == 10)
                {
                    roundPicture25.Image = Image.FromFile("../images/10.png");
                    roundPicture26.Image = Image.FromFile("../images/10m.png");

                }
                if (randomNumbers[countStep] == 11)
                {
                    roundPicture25.Image = Image.FromFile("../images/11.png");
                    roundPicture26.Image = Image.FromFile("../images/11m.png");

                }
                if (randomNumbers[countStep] == 12)
                {
                    roundPicture25.Image = Image.FromFile("../images/12.png");
                    roundPicture26.Image = Image.FromFile("../images/12m.png");

                }
                if (randomNumbers[countStep] == 13)
                {
                    roundPicture25.Image = Image.FromFile("../images/13.png");
                    roundPicture26.Image = Image.FromFile("../images/13m.png");

                }
                if (randomNumbers[countStep] == 14)
                {
                    roundPicture25.Image = Image.FromFile("../images/14.png");
                    roundPicture26.Image = Image.FromFile("../images/14m.png");

                }
                if (randomNumbers[countStep] == 15)
                {
                    roundPicture25.Image = Image.FromFile("../images/15.png");
                    roundPicture26.Image = Image.FromFile("../images/15m.png");

                }
                if (randomNumbers[countStep] == 16)
                {
                    roundPicture25.Image = Image.FromFile("../images/16.png");
                    roundPicture26.Image = Image.FromFile("../images/16m.png");

                }

                if (randomNumbers[countStep] == 17)
                {
                    roundPicture25.Image = Image.FromFile("../images/17.png");
                    roundPicture26.Image = Image.FromFile("../images/17m.png");

                }
                if (randomNumbers[countStep] == 18)
                {
                    roundPicture25.Image = Image.FromFile("../images/18.png");
                    roundPicture26.Image = Image.FromFile("../images/18m.png");

                }
                if (randomNumbers[countStep] == 19)
                {
                    roundPicture25.Image = Image.FromFile("../images/19.png");
                    roundPicture26.Image = Image.FromFile("../images/19m.png");

                }
                if (randomNumbers[countStep] == 20)
                {
                    roundPicture25.Image = Image.FromFile("../images/20.png");
                    roundPicture26.Image = Image.FromFile("../images/20m.png");

                }
                if (randomNumbers[countStep] == 21)
                {
                    roundPicture25.Image = Image.FromFile("../images/21.png");
                    roundPicture26.Image = Image.FromFile("../images/21m.png");

                }
                if (randomNumbers[countStep] == 22)
                {
                    roundPicture25.Image = Image.FromFile("../images/22.png");
                    roundPicture26.Image = Image.FromFile("../images/22m.png");

                }
                if (randomNumbers[countStep] == 23)
                {
                    roundPicture25.Image = Image.FromFile("../images/23.png");
                    roundPicture26.Image = Image.FromFile("../images/23mm.png");

                }
                if (randomNumbers[countStep] == 24)
                {
                    roundPicture25.Image = Image.FromFile("../images/24.png");
                    roundPicture26.Image = Image.FromFile("../images/24m.png");

                }
            }

            countStep = 1;

            if (countStep == 1)
            {
                var t1 = Task.Delay(2000);
                await t1;
                if (randomNumbers[countStep] == 1)
                {
                    roundPicture25.Image = Image.FromFile("../images/1.png");
                    roundPicture28.Image = Image.FromFile("../images/1mm.png");

                }
                if (randomNumbers[countStep] == 2)
                {
                    roundPicture25.Image = Image.FromFile("../images/2.png");
                    roundPicture28.Image = Image.FromFile("../images/2m.png");

                }
                if (randomNumbers[countStep] == 3)
                {
                    roundPicture25.Image = Image.FromFile("../images/3.png");
                    roundPicture28.Image = Image.FromFile("../images/3m.png");

                }
                if (randomNumbers[countStep] == 4)
                {
                    roundPicture25.Image = Image.FromFile("../images/4.png");
                    roundPicture28.Image = Image.FromFile("../images/4m.png");

                }

                if (randomNumbers[countStep] == 5)
                {
                    roundPicture25.Image = Image.FromFile("../images/5.png");
                    roundPicture28.Image = Image.FromFile("../images/5m.png");

                }
                if (randomNumbers[countStep] == 6)
                {
                    roundPicture25.Image = Image.FromFile("../images/6.png");
                    roundPicture28.Image = Image.FromFile("../images/6m.png");

                }
                if (randomNumbers[countStep] == 7)
                {
                    roundPicture25.Image = Image.FromFile("../images/7.png");
                    roundPicture28.Image = Image.FromFile("../images/7m.png");

                }
                if (randomNumbers[countStep] == 8)
                {
                    roundPicture25.Image = Image.FromFile("../images/8.png");
                    roundPicture28.Image = Image.FromFile("../images/8m.png");

                }
                if (randomNumbers[countStep] == 9)
                {
                    roundPicture25.Image = Image.FromFile("../images/9.png");
                    roundPicture28.Image = Image.FromFile("../images/9m.png");

                }
                if (randomNumbers[countStep] == 10)
                {
                    roundPicture25.Image = Image.FromFile("../images/10.png");
                    roundPicture28.Image = Image.FromFile("../images/10m.png");

                }
                if (randomNumbers[countStep] == 11)
                {
                    roundPicture25.Image = Image.FromFile("../images/11.png");
                    roundPicture28.Image = Image.FromFile("../images/11m.png");

                }
                if (randomNumbers[countStep] == 12)
                {
                    roundPicture25.Image = Image.FromFile("../images/12.png");
                    roundPicture28.Image = Image.FromFile("../images/12m.png");

                }
                if (randomNumbers[countStep] == 13)
                {
                    roundPicture25.Image = Image.FromFile("../images/13.png");
                    roundPicture28.Image = Image.FromFile("../images/13m.png");

                }
                if (randomNumbers[countStep] == 14)
                {
                    roundPicture25.Image = Image.FromFile("../images/14.png");
                    roundPicture28.Image = Image.FromFile("../images/14m.png");

                }
                if (randomNumbers[countStep] == 15)
                {
                    roundPicture25.Image = Image.FromFile("../images/15.png");
                    roundPicture28.Image = Image.FromFile("../images/15m.png");

                }
                if (randomNumbers[countStep] == 16)
                {
                    roundPicture25.Image = Image.FromFile("../images/16.png");
                    roundPicture28.Image = Image.FromFile("../images/16m.png");

                }

                if (randomNumbers[countStep] == 17)
                {
                    roundPicture25.Image = Image.FromFile("../images/17.png");
                    roundPicture28.Image = Image.FromFile("../images/17m.png");

                }
                if (randomNumbers[countStep] == 18)
                {
                    roundPicture25.Image = Image.FromFile("../images/18.png");
                    roundPicture28.Image = Image.FromFile("../images/18m.png");

                }
                if (randomNumbers[countStep] == 19)
                {
                    roundPicture25.Image = Image.FromFile("../images/19.png");
                    roundPicture28.Image = Image.FromFile("../images/19m.png");

                }
                if (randomNumbers[countStep] == 20)
                {
                    roundPicture25.Image = Image.FromFile("../images/20.png");
                    roundPicture28.Image = Image.FromFile("../images/20m.png");

                }
                if (randomNumbers[countStep] == 21)
                {
                    roundPicture25.Image = Image.FromFile("../images/21.png");
                    roundPicture28.Image = Image.FromFile("../images/21m.png");

                }
                if (randomNumbers[countStep] == 22)
                {
                    roundPicture25.Image = Image.FromFile("../images/22.png");
                    roundPicture28.Image = Image.FromFile("../images/22m.png");

                }
                if (randomNumbers[countStep] == 23)
                {
                    roundPicture25.Image = Image.FromFile("../images/23.png");
                    roundPicture28.Image = Image.FromFile("../images/23mm.png");

                }
                if (randomNumbers[countStep] == 24)
                {
                    roundPicture25.Image = Image.FromFile("../images/24.png");
                    roundPicture28.Image = Image.FromFile("../images/24m.png");

                }
            }
            countStep = 2;

            if (countStep == 2)
            {
                var t1 = Task.Delay(2000);
                await t1;
                if (randomNumbers[countStep] == 1)
                {
                    roundPicture25.Image = Image.FromFile("../images/1.png");
                    roundPicture30.Image = Image.FromFile("../images/1mm.png");

                }
                if (randomNumbers[countStep] == 2)
                {
                    roundPicture25.Image = Image.FromFile("../images/2.png");
                    roundPicture30.Image = Image.FromFile("../images/2m.png");

                }
                if (randomNumbers[countStep] == 3)
                {
                    roundPicture25.Image = Image.FromFile("../images/3.png");
                    roundPicture30.Image = Image.FromFile("../images/3m.png");

                }
                if (randomNumbers[countStep] == 4)
                {
                    roundPicture25.Image = Image.FromFile("../images/4.png");
                    roundPicture30.Image = Image.FromFile("../images/4m.png");

                }

                if (randomNumbers[countStep] == 5)
                {
                    roundPicture25.Image = Image.FromFile("../images/5.png");
                    roundPicture30.Image = Image.FromFile("../images/5m.png");

                }
                if (randomNumbers[countStep] == 6)
                {
                    roundPicture25.Image = Image.FromFile("../images/6.png");
                    roundPicture30.Image = Image.FromFile("../images/6m.png");

                }
                if (randomNumbers[countStep] == 7)
                {
                    roundPicture25.Image = Image.FromFile("../images/7.png");
                    roundPicture30.Image = Image.FromFile("../images/7m.png");

                }
                if (randomNumbers[countStep] == 8)
                {
                    roundPicture25.Image = Image.FromFile("../images/8.png");
                    roundPicture30.Image = Image.FromFile("../images/8m.png");

                }
                if (randomNumbers[countStep] == 9)
                {
                    roundPicture25.Image = Image.FromFile("../images/9.png");
                    roundPicture30.Image = Image.FromFile("../images/9m.png");

                }
                if (randomNumbers[countStep] == 10)
                {
                    roundPicture25.Image = Image.FromFile("../images/10.png");
                    roundPicture30.Image = Image.FromFile("../images/10m.png");

                }
                if (randomNumbers[countStep] == 11)
                {
                    roundPicture25.Image = Image.FromFile("../images/11.png");
                    roundPicture30.Image = Image.FromFile("../images/11m.png");

                }
                if (randomNumbers[countStep] == 12)
                {
                    roundPicture25.Image = Image.FromFile("../images/12.png");
                    roundPicture30.Image = Image.FromFile("../images/12m.png");

                }
                if (randomNumbers[countStep] == 13)
                {
                    roundPicture25.Image = Image.FromFile("../images/13.png");
                    roundPicture30.Image = Image.FromFile("../images/13m.png");

                }
                if (randomNumbers[countStep] == 14)
                {
                    roundPicture25.Image = Image.FromFile("../images/14.png");
                    roundPicture30.Image = Image.FromFile("../images/14m.png");

                }
                if (randomNumbers[countStep] == 15)
                {
                    roundPicture25.Image = Image.FromFile("../images/15.png");
                    roundPicture30.Image = Image.FromFile("../images/15m.png");

                }
                if (randomNumbers[countStep] == 16)
                {
                    roundPicture25.Image = Image.FromFile("../images/16.png");
                    roundPicture30.Image = Image.FromFile("../images/16m.png");

                }

                if (randomNumbers[countStep] == 17)
                {
                    roundPicture25.Image = Image.FromFile("../images/17.png");
                    roundPicture30.Image = Image.FromFile("../images/17m.png");

                }
                if (randomNumbers[countStep] == 18)
                {
                    roundPicture25.Image = Image.FromFile("../images/18.png");
                    roundPicture30.Image = Image.FromFile("../images/18m.png");

                }
                if (randomNumbers[countStep] == 19)
                {
                    roundPicture25.Image = Image.FromFile("../images/19.png");
                    roundPicture30.Image = Image.FromFile("../images/19m.png");

                }
                if (randomNumbers[countStep] == 20)
                {
                    roundPicture25.Image = Image.FromFile("../images/20.png");
                    roundPicture30.Image = Image.FromFile("../images/20m.png");

                }
                if (randomNumbers[countStep] == 21)
                {
                    roundPicture25.Image = Image.FromFile("../images/21.png");
                    roundPicture30.Image = Image.FromFile("../images/21m.png");

                }
                if (randomNumbers[countStep] == 22)
                {
                    roundPicture25.Image = Image.FromFile("../images/22.png");
                    roundPicture30.Image = Image.FromFile("../images/22m.png");

                }
                if (randomNumbers[countStep] == 23)
                {
                    roundPicture25.Image = Image.FromFile("../images/23.png");
                    roundPicture30.Image = Image.FromFile("../images/23mm.png");

                }
                if (randomNumbers[countStep] == 24)
                {
                    roundPicture25.Image = Image.FromFile("../images/24.png");
                    roundPicture30.Image = Image.FromFile("../images/24m.png");

                }
            }

            countStep = 3;

            if (countStep == 3)
            {
                var t1 = Task.Delay(2000);
                await t1;
                if (randomNumbers[countStep] == 1)
                {
                    roundPicture25.Image = Image.FromFile("../images/1.png");
                    roundPicture32.Image = Image.FromFile("../images/1mm.png");

                }
                if (randomNumbers[countStep] == 2)
                {
                    roundPicture25.Image = Image.FromFile("../images/2.png");
                    roundPicture32.Image = Image.FromFile("../images/2m.png");

                }
                if (randomNumbers[countStep] == 3)
                {
                    roundPicture25.Image = Image.FromFile("../images/3.png");
                    roundPicture32.Image = Image.FromFile("../images/3m.png");

                }
                if (randomNumbers[countStep] == 4)
                {
                    roundPicture25.Image = Image.FromFile("../images/4.png");
                    roundPicture32.Image = Image.FromFile("../images/4m.png");

                }

                if (randomNumbers[countStep] == 5)
                {
                    roundPicture25.Image = Image.FromFile("../images/5.png");
                    roundPicture32.Image = Image.FromFile("../images/5m.png");

                }
                if (randomNumbers[countStep] == 6)
                {
                    roundPicture25.Image = Image.FromFile("../images/6.png");
                    roundPicture32.Image = Image.FromFile("../images/6m.png");

                }
                if (randomNumbers[countStep] == 7)
                {
                    roundPicture25.Image = Image.FromFile("../images/7.png");
                    roundPicture32.Image = Image.FromFile("../images/7m.png");

                }
                if (randomNumbers[countStep] == 8)
                {
                    roundPicture25.Image = Image.FromFile("../images/8.png");
                    roundPicture32.Image = Image.FromFile("../images/8m.png");

                }
                if (randomNumbers[countStep] == 9)
                {
                    roundPicture25.Image = Image.FromFile("../images/9.png");
                    roundPicture32.Image = Image.FromFile("../images/9m.png");

                }
                if (randomNumbers[countStep] == 10)
                {
                    roundPicture25.Image = Image.FromFile("../images/10.png");
                    roundPicture32.Image = Image.FromFile("../images/10m.png");

                }
                if (randomNumbers[countStep] == 11)
                {
                    roundPicture25.Image = Image.FromFile("../images/11.png");
                    roundPicture32.Image = Image.FromFile("../images/11m.png");

                }
                if (randomNumbers[countStep] == 12)
                {
                    roundPicture25.Image = Image.FromFile("../images/12.png");
                    roundPicture32.Image = Image.FromFile("../images/12m.png");

                }
                if (randomNumbers[countStep] == 13)
                {
                    roundPicture25.Image = Image.FromFile("../images/13.png");
                    roundPicture32.Image = Image.FromFile("../images/13m.png");

                }
                if (randomNumbers[countStep] == 14)
                {
                    roundPicture25.Image = Image.FromFile("../images/14.png");
                    roundPicture32.Image = Image.FromFile("../images/14m.png");

                }
                if (randomNumbers[countStep] == 15)
                {
                    roundPicture25.Image = Image.FromFile("../images/15.png");
                    roundPicture32.Image = Image.FromFile("../images/15m.png");

                }
                if (randomNumbers[countStep] == 16)
                {
                    roundPicture25.Image = Image.FromFile("../images/16.png");
                    roundPicture32.Image = Image.FromFile("../images/16m.png");

                }

                if (randomNumbers[countStep] == 17)
                {
                    roundPicture25.Image = Image.FromFile("../images/17.png");
                    roundPicture32.Image = Image.FromFile("../images/17m.png");

                }
                if (randomNumbers[countStep] == 18)
                {
                    roundPicture25.Image = Image.FromFile("../images/18.png");
                    roundPicture32.Image = Image.FromFile("../images/18m.png");

                }
                if (randomNumbers[countStep] == 19)
                {
                    roundPicture25.Image = Image.FromFile("../images/19.png");
                    roundPicture32.Image = Image.FromFile("../images/19m.png");

                }
                if (randomNumbers[countStep] == 20)
                {
                    roundPicture25.Image = Image.FromFile("../images/20.png");
                    roundPicture32.Image = Image.FromFile("../images/20m.png");

                }
                if (randomNumbers[countStep] == 21)
                {
                    roundPicture25.Image = Image.FromFile("../images/21.png");
                    roundPicture32.Image = Image.FromFile("../images/21m.png");

                }
                if (randomNumbers[countStep] == 22)
                {
                    roundPicture25.Image = Image.FromFile("../images/22.png");
                    roundPicture32.Image = Image.FromFile("../images/22m.png");

                }
                if (randomNumbers[countStep] == 23)
                {
                    roundPicture25.Image = Image.FromFile("../images/23.png");
                    roundPicture32.Image = Image.FromFile("../images/23mm.png");

                }
                if (randomNumbers[countStep] == 24)
                {
                    roundPicture25.Image = Image.FromFile("../images/24.png");
                    roundPicture32.Image = Image.FromFile("../images/24m.png");

                }
            }
            countStep = 4;

            if (countStep == 4)
            {
                var t1 = Task.Delay(2000);
                await t1;
                if (randomNumbers[countStep] == 1)
                {
                    roundPicture25.Image = Image.FromFile("../images/1.png");
                    roundPicture27.Image = Image.FromFile("../images/1mm.png");

                }
                if (randomNumbers[countStep] == 2)
                {
                    roundPicture25.Image = Image.FromFile("../images/2.png");
                    roundPicture27.Image = Image.FromFile("../images/2m.png");

                }
                if (randomNumbers[countStep] == 3)
                {
                    roundPicture25.Image = Image.FromFile("../images/3.png");
                    roundPicture27.Image = Image.FromFile("../images/3m.png");

                }
                if (randomNumbers[countStep] == 4)
                {
                    roundPicture25.Image = Image.FromFile("../images/4.png");
                    roundPicture27.Image = Image.FromFile("../images/4m.png");

                }

                if (randomNumbers[countStep] == 5)
                {
                    roundPicture25.Image = Image.FromFile("../images/5.png");
                    roundPicture27.Image = Image.FromFile("../images/5m.png");

                }
                if (randomNumbers[countStep] == 6)
                {
                    roundPicture25.Image = Image.FromFile("../images/6.png");
                    roundPicture27.Image = Image.FromFile("../images/6m.png");

                }
                if (randomNumbers[countStep] == 7)
                {
                    roundPicture25.Image = Image.FromFile("../images/7.png");
                    roundPicture27.Image = Image.FromFile("../images/7m.png");

                }
                if (randomNumbers[countStep] == 8)
                {
                    roundPicture25.Image = Image.FromFile("../images/8.png");
                    roundPicture27.Image = Image.FromFile("../images/8m.png");

                }
                if (randomNumbers[countStep] == 9)
                {
                    roundPicture25.Image = Image.FromFile("../images/9.png");
                    roundPicture27.Image = Image.FromFile("../images/9m.png");

                }
                if (randomNumbers[countStep] == 10)
                {
                    roundPicture25.Image = Image.FromFile("../images/10.png");
                    roundPicture27.Image = Image.FromFile("../images/10m.png");

                }
                if (randomNumbers[countStep] == 11)
                {
                    roundPicture25.Image = Image.FromFile("../images/11.png");
                    roundPicture27.Image = Image.FromFile("../images/11m.png");

                }
                if (randomNumbers[countStep] == 12)
                {
                    roundPicture25.Image = Image.FromFile("../images/12.png");
                    roundPicture27.Image = Image.FromFile("../images/12m.png");

                }
                if (randomNumbers[countStep] == 13)
                {
                    roundPicture25.Image = Image.FromFile("../images/13.png");
                    roundPicture27.Image = Image.FromFile("../images/13m.png");

                }
                if (randomNumbers[countStep] == 14)
                {
                    roundPicture25.Image = Image.FromFile("../images/14.png");
                    roundPicture27.Image = Image.FromFile("../images/14m.png");

                }
                if (randomNumbers[countStep] == 15)
                {
                    roundPicture25.Image = Image.FromFile("../images/15.png");
                    roundPicture27.Image = Image.FromFile("../images/15m.png");

                }
                if (randomNumbers[countStep] == 16)
                {
                    roundPicture25.Image = Image.FromFile("../images/16.png");
                    roundPicture27.Image = Image.FromFile("../images/16m.png");

                }

                if (randomNumbers[countStep] == 17)
                {
                    roundPicture25.Image = Image.FromFile("../images/17.png");
                    roundPicture27.Image = Image.FromFile("../images/17m.png");

                }
                if (randomNumbers[countStep] == 18)
                {
                    roundPicture25.Image = Image.FromFile("../images/18.png");
                    roundPicture27.Image = Image.FromFile("../images/18m.png");

                }
                if (randomNumbers[countStep] == 19)
                {
                    roundPicture25.Image = Image.FromFile("../images/19.png");
                    roundPicture27.Image = Image.FromFile("../images/19m.png");

                }
                if (randomNumbers[countStep] == 20)
                {
                    roundPicture25.Image = Image.FromFile("../images/20.png");
                    roundPicture27.Image = Image.FromFile("../images/20m.png");

                }
                if (randomNumbers[countStep] == 21)
                {
                    roundPicture25.Image = Image.FromFile("../images/21.png");
                    roundPicture27.Image = Image.FromFile("../images/21m.png");

                }
                if (randomNumbers[countStep] == 22)
                {
                    roundPicture25.Image = Image.FromFile("../images/22.png");
                    roundPicture27.Image = Image.FromFile("../images/22m.png");

                }
                if (randomNumbers[countStep] == 23)
                {
                    roundPicture25.Image = Image.FromFile("../images/23.png");
                    roundPicture27.Image = Image.FromFile("../images/23mm.png");

                }
                if (randomNumbers[countStep] == 24)
                {
                    roundPicture25.Image = Image.FromFile("../images/24.png");
                    roundPicture27.Image = Image.FromFile("../images/24m.png");

                }
            }

            countStep = 5;

            if (countStep == 5)
            {
                var t1 = Task.Delay(2000);
                await t1;
                if (randomNumbers[countStep] == 1)
                {
                    roundPicture25.Image = Image.FromFile("../images/1.png");
                    roundPicture29.Image = Image.FromFile("../images/1mm.png");

                }
                if (randomNumbers[countStep] == 2)
                {
                    roundPicture25.Image = Image.FromFile("../images/2.png");
                    roundPicture29.Image = Image.FromFile("../images/2m.png");

                }
                if (randomNumbers[countStep] == 3)
                {
                    roundPicture25.Image = Image.FromFile("../images/3.png");
                    roundPicture29.Image = Image.FromFile("../images/3m.png");

                }
                if (randomNumbers[countStep] == 4)
                {
                    roundPicture25.Image = Image.FromFile("../images/4.png");
                    roundPicture29.Image = Image.FromFile("../images/4m.png");

                }

                if (randomNumbers[countStep] == 5)
                {
                    roundPicture25.Image = Image.FromFile("../images/5.png");
                    roundPicture29.Image = Image.FromFile("../images/5m.png");

                }
                if (randomNumbers[countStep] == 6)
                {
                    roundPicture25.Image = Image.FromFile("../images/6.png");
                    roundPicture29.Image = Image.FromFile("../images/6m.png");

                }
                if (randomNumbers[countStep] == 7)
                {
                    roundPicture25.Image = Image.FromFile("../images/7.png");
                    roundPicture29.Image = Image.FromFile("../images/7m.png");

                }
                if (randomNumbers[countStep] == 8)
                {
                    roundPicture25.Image = Image.FromFile("../images/8.png");
                    roundPicture29.Image = Image.FromFile("../images/8m.png");

                }
                if (randomNumbers[countStep] == 9)
                {
                    roundPicture25.Image = Image.FromFile("../images/9.png");
                    roundPicture29.Image = Image.FromFile("../images/9m.png");

                }
                if (randomNumbers[countStep] == 10)
                {
                    roundPicture25.Image = Image.FromFile("../images/10.png");
                    roundPicture29.Image = Image.FromFile("../images/10m.png");

                }
                if (randomNumbers[countStep] == 11)
                {
                    roundPicture25.Image = Image.FromFile("../images/11.png");
                    roundPicture29.Image = Image.FromFile("../images/11m.png");

                }
                if (randomNumbers[countStep] == 12)
                {
                    roundPicture25.Image = Image.FromFile("../images/12.png");
                    roundPicture29.Image = Image.FromFile("../images/12m.png");

                }
                if (randomNumbers[countStep] == 13)
                {
                    roundPicture25.Image = Image.FromFile("../images/13.png");
                    roundPicture29.Image = Image.FromFile("../images/13m.png");

                }
                if (randomNumbers[countStep] == 14)
                {
                    roundPicture25.Image = Image.FromFile("../images/14.png");
                    roundPicture29.Image = Image.FromFile("../images/14m.png");

                }
                if (randomNumbers[countStep] == 15)
                {
                    roundPicture25.Image = Image.FromFile("../images/15.png");
                    roundPicture29.Image = Image.FromFile("../images/15m.png");

                }
                if (randomNumbers[countStep] == 16)
                {
                    roundPicture25.Image = Image.FromFile("../images/16.png");
                    roundPicture29.Image = Image.FromFile("../images/16m.png");

                }

                if (randomNumbers[countStep] == 17)
                {
                    roundPicture25.Image = Image.FromFile("../images/17.png");
                    roundPicture29.Image = Image.FromFile("../images/17m.png");

                }
                if (randomNumbers[countStep] == 18)
                {
                    roundPicture25.Image = Image.FromFile("../images/18.png");
                    roundPicture29.Image = Image.FromFile("../images/18m.png");

                }
                if (randomNumbers[countStep] == 19)
                {
                    roundPicture25.Image = Image.FromFile("../images/19.png");
                    roundPicture29.Image = Image.FromFile("../images/19m.png");

                }
                if (randomNumbers[countStep] == 20)
                {
                    roundPicture25.Image = Image.FromFile("../images/20.png");
                    roundPicture29.Image = Image.FromFile("../images/20m.png");

                }
                if (randomNumbers[countStep] == 21)
                {
                    roundPicture25.Image = Image.FromFile("../images/21.png");
                    roundPicture29.Image = Image.FromFile("../images/21m.png");

                }
                if (randomNumbers[countStep] == 22)
                {
                    roundPicture25.Image = Image.FromFile("../images/22.png");
                    roundPicture29.Image = Image.FromFile("../images/22m.png");

                }
                if (randomNumbers[countStep] == 23)
                {
                    roundPicture25.Image = Image.FromFile("../images/23.png");
                    roundPicture29.Image = Image.FromFile("../images/23mm.png");

                }
                if (randomNumbers[countStep] == 24)
                {
                    roundPicture25.Image = Image.FromFile("../images/24.png");
                    roundPicture29.Image = Image.FromFile("../images/24m.png");

                }
            }

            countStep = 6;

            if (countStep == 6)
            {
                var t1 = Task.Delay(2000);
                await t1;
                if (randomNumbers[countStep] == 1)
                {
                    roundPicture25.Image = Image.FromFile("../images/1.png");
                    roundPicture31.Image = Image.FromFile("../images/1mm.png");

                }
                if (randomNumbers[countStep] == 2)
                {
                    roundPicture25.Image = Image.FromFile("../images/2.png");
                    roundPicture31.Image = Image.FromFile("../images/2m.png");

                }
                if (randomNumbers[countStep] == 3)
                {
                    roundPicture25.Image = Image.FromFile("../images/3.png");
                    roundPicture31.Image = Image.FromFile("../images/3m.png");

                }
                if (randomNumbers[countStep] == 4)
                {
                    roundPicture25.Image = Image.FromFile("../images/4.png");
                    roundPicture31.Image = Image.FromFile("../images/4m.png");

                }

                if (randomNumbers[countStep] == 5)
                {
                    roundPicture25.Image = Image.FromFile("../images/5.png");
                    roundPicture31.Image = Image.FromFile("../images/5m.png");

                }
                if (randomNumbers[countStep] == 6)
                {
                    roundPicture25.Image = Image.FromFile("../images/6.png");
                    roundPicture31.Image = Image.FromFile("../images/6m.png");

                }
                if (randomNumbers[countStep] == 7)
                {
                    roundPicture25.Image = Image.FromFile("../images/7.png");
                    roundPicture31.Image = Image.FromFile("../images/7m.png");

                }
                if (randomNumbers[countStep] == 8)
                {
                    roundPicture25.Image = Image.FromFile("../images/8.png");
                    roundPicture31.Image = Image.FromFile("../images/8m.png");

                }
                if (randomNumbers[countStep] == 9)
                {
                    roundPicture25.Image = Image.FromFile("../images/9.png");
                    roundPicture31.Image = Image.FromFile("../images/9m.png");

                }
                if (randomNumbers[countStep] == 10)
                {
                    roundPicture25.Image = Image.FromFile("../images/10.png");
                    roundPicture31.Image = Image.FromFile("../images/10m.png");

                }
                if (randomNumbers[countStep] == 11)
                {
                    roundPicture25.Image = Image.FromFile("../images/11.png");
                    roundPicture31.Image = Image.FromFile("../images/11m.png");

                }
                if (randomNumbers[countStep] == 12)
                {
                    roundPicture25.Image = Image.FromFile("../images/12.png");
                    roundPicture31.Image = Image.FromFile("../images/12m.png");

                }
                if (randomNumbers[countStep] == 13)
                {
                    roundPicture25.Image = Image.FromFile("../images/13.png");
                    roundPicture31.Image = Image.FromFile("../images/13m.png");

                }
                if (randomNumbers[countStep] == 14)
                {
                    roundPicture25.Image = Image.FromFile("../images/14.png");
                    roundPicture31.Image = Image.FromFile("../images/14m.png");

                }
                if (randomNumbers[countStep] == 15)
                {
                    roundPicture25.Image = Image.FromFile("../images/15.png");
                    roundPicture31.Image = Image.FromFile("../images/15m.png");

                }
                if (randomNumbers[countStep] == 16)
                {
                    roundPicture25.Image = Image.FromFile("../images/16.png");
                    roundPicture31.Image = Image.FromFile("../images/16m.png");

                }

                if (randomNumbers[countStep] == 17)
                {
                    roundPicture25.Image = Image.FromFile("../images/17.png");
                    roundPicture31.Image = Image.FromFile("../images/17m.png");

                }
                if (randomNumbers[countStep] == 18)
                {
                    roundPicture25.Image = Image.FromFile("../images/18.png");
                    roundPicture31.Image = Image.FromFile("../images/18m.png");

                }
                if (randomNumbers[countStep] == 19)
                {
                    roundPicture25.Image = Image.FromFile("../images/19.png");
                    roundPicture31.Image = Image.FromFile("../images/19m.png");

                }
                if (randomNumbers[countStep] == 20)
                {
                    roundPicture25.Image = Image.FromFile("../images/20.png");
                    roundPicture31.Image = Image.FromFile("../images/20m.png");

                }
                if (randomNumbers[countStep] == 21)
                {
                    roundPicture25.Image = Image.FromFile("../images/21.png");
                    roundPicture31.Image = Image.FromFile("../images/21m.png");

                }
                if (randomNumbers[countStep] == 22)
                {
                    roundPicture25.Image = Image.FromFile("../images/22.png");
                    roundPicture31.Image = Image.FromFile("../images/22m.png");

                }
                if (randomNumbers[countStep] == 23)
                {
                    roundPicture25.Image = Image.FromFile("../images/23.png");
                    roundPicture31.Image = Image.FromFile("../images/23mm.png");

                }
                if (randomNumbers[countStep] == 24)
                {
                    roundPicture25.Image = Image.FromFile("../images/24.png");
                    roundPicture31.Image = Image.FromFile("../images/24m.png");

                }
            }
            countStep = 7;

            if (countStep == 7)
            {
                var t1 = Task.Delay(2000);
                await t1;
                if (randomNumbers[countStep] == 1)
                {
                    roundPicture25.Image = Image.FromFile("../images/1.png");
                    roundPicture33.Image = Image.FromFile("../images/1mm.png");

                }
                if (randomNumbers[countStep] == 2)
                {
                    roundPicture25.Image = Image.FromFile("../images/2.png");
                    roundPicture33.Image = Image.FromFile("../images/2m.png");

                }
                if (randomNumbers[countStep] == 3)
                {
                    roundPicture25.Image = Image.FromFile("../images/3.png");
                    roundPicture33.Image = Image.FromFile("../images/3m.png");

                }
                if (randomNumbers[countStep] == 4)
                {
                    roundPicture25.Image = Image.FromFile("../images/4.png");
                    roundPicture33.Image = Image.FromFile("../images/4m.png");

                }

                if (randomNumbers[countStep] == 5)
                {
                    roundPicture25.Image = Image.FromFile("../images/5.png");
                    roundPicture33.Image = Image.FromFile("../images/5m.png");

                }
                if (randomNumbers[countStep] == 6)
                {
                    roundPicture25.Image = Image.FromFile("../images/6.png");
                    roundPicture33.Image = Image.FromFile("../images/6m.png");

                }
                if (randomNumbers[countStep] == 7)
                {
                    roundPicture25.Image = Image.FromFile("../images/7.png");
                    roundPicture33.Image = Image.FromFile("../images/7m.png");

                }
                if (randomNumbers[countStep] == 8)
                {
                    roundPicture25.Image = Image.FromFile("../images/8.png");
                    roundPicture33.Image = Image.FromFile("../images/8m.png");

                }
                if (randomNumbers[countStep] == 9)
                {
                    roundPicture25.Image = Image.FromFile("../images/9.png");
                    roundPicture33.Image = Image.FromFile("../images/9m.png");

                }
                if (randomNumbers[countStep] == 10)
                {
                    roundPicture25.Image = Image.FromFile("../images/10.png");
                    roundPicture33.Image = Image.FromFile("../images/10m.png");

                }
                if (randomNumbers[countStep] == 11)
                {
                    roundPicture25.Image = Image.FromFile("../images/11.png");
                    roundPicture33.Image = Image.FromFile("../images/11m.png");

                }
                if (randomNumbers[countStep] == 12)
                {
                    roundPicture25.Image = Image.FromFile("../images/12.png");
                    roundPicture33.Image = Image.FromFile("../images/12m.png");

                }
                if (randomNumbers[countStep] == 13)
                {
                    roundPicture25.Image = Image.FromFile("../images/13.png");
                    roundPicture33.Image = Image.FromFile("../images/13m.png");

                }
                if (randomNumbers[countStep] == 14)
                {
                    roundPicture25.Image = Image.FromFile("../images/14.png");
                    roundPicture33.Image = Image.FromFile("../images/14m.png");

                }
                if (randomNumbers[countStep] == 15)
                {
                    roundPicture25.Image = Image.FromFile("../images/15.png");
                    roundPicture33.Image = Image.FromFile("../images/15m.png");

                }
                if (randomNumbers[countStep] == 16)
                {
                    roundPicture25.Image = Image.FromFile("../images/16.png");
                    roundPicture33.Image = Image.FromFile("../images/16m.png");

                }

                if (randomNumbers[countStep] == 17)
                {
                    roundPicture25.Image = Image.FromFile("../images/17.png");
                    roundPicture33.Image = Image.FromFile("../images/17m.png");

                }
                if (randomNumbers[countStep] == 18)
                {
                    roundPicture25.Image = Image.FromFile("../images/18.png");
                    roundPicture33.Image = Image.FromFile("../images/18m.png");

                }
                if (randomNumbers[countStep] == 19)
                {
                    roundPicture25.Image = Image.FromFile("../images/19.png");
                    roundPicture33.Image = Image.FromFile("../images/19m.png");

                }
                if (randomNumbers[countStep] == 20)
                {
                    roundPicture25.Image = Image.FromFile("../images/20.png");
                    roundPicture33.Image = Image.FromFile("../images/20m.png");

                }
                if (randomNumbers[countStep] == 21)
                {
                    roundPicture25.Image = Image.FromFile("../images/21.png");
                    roundPicture33.Image = Image.FromFile("../images/21m.png");

                }
                if (randomNumbers[countStep] == 22)
                {
                    roundPicture25.Image = Image.FromFile("../images/22.png");
                    roundPicture33.Image = Image.FromFile("../images/22m.png");

                }
                if (randomNumbers[countStep] == 23)
                {
                    roundPicture25.Image = Image.FromFile("../images/23.png");
                    roundPicture33.Image = Image.FromFile("../images/23mm.png");

                }
                if (randomNumbers[countStep] == 24)
                {
                    roundPicture25.Image = Image.FromFile("../images/24.png");
                    roundPicture33.Image = Image.FromFile("../images/24m.png");

                }
            }
            countStep = 8;

            if (countStep == 8)
            {
                var t1 = Task.Delay(2000);
                await t1;
                if (randomNumbers[countStep] == 1)
                {
                    roundPicture25.Image = Image.FromFile("../images/1.png");
                    roundPicture34.Image = Image.FromFile("../images/1mm.png");

                }
                if (randomNumbers[countStep] == 2)
                {
                    roundPicture25.Image = Image.FromFile("../images/2.png");
                    roundPicture34.Image = Image.FromFile("../images/2m.png");

                }
                if (randomNumbers[countStep] == 3)
                {
                    roundPicture25.Image = Image.FromFile("../images/3.png");
                    roundPicture34.Image = Image.FromFile("../images/3m.png");

                }
                if (randomNumbers[countStep] == 4)
                {
                    roundPicture25.Image = Image.FromFile("../images/4.png");
                    roundPicture34.Image = Image.FromFile("../images/4m.png");

                }

                if (randomNumbers[countStep] == 5)
                {
                    roundPicture25.Image = Image.FromFile("../images/5.png");
                    roundPicture34.Image = Image.FromFile("../images/5m.png");

                }
                if (randomNumbers[countStep] == 6)
                {
                    roundPicture25.Image = Image.FromFile("../images/6.png");
                    roundPicture34.Image = Image.FromFile("../images/6m.png");

                }
                if (randomNumbers[countStep] == 7)
                {
                    roundPicture25.Image = Image.FromFile("../images/7.png");
                    roundPicture34.Image = Image.FromFile("../images/7m.png");

                }
                if (randomNumbers[countStep] == 8)
                {
                    roundPicture25.Image = Image.FromFile("../images/8.png");
                    roundPicture34.Image = Image.FromFile("../images/8m.png");

                }
                if (randomNumbers[countStep] == 9)
                {
                    roundPicture25.Image = Image.FromFile("../images/9.png");
                    roundPicture34.Image = Image.FromFile("../images/9m.png");

                }
                if (randomNumbers[countStep] == 10)
                {
                    roundPicture25.Image = Image.FromFile("../images/10.png");
                    roundPicture34.Image = Image.FromFile("../images/10m.png");

                }
                if (randomNumbers[countStep] == 11)
                {
                    roundPicture25.Image = Image.FromFile("../images/11.png");
                    roundPicture34.Image = Image.FromFile("../images/11m.png");

                }
                if (randomNumbers[countStep] == 12)
                {
                    roundPicture25.Image = Image.FromFile("../images/12.png");
                    roundPicture34.Image = Image.FromFile("../images/12m.png");

                }
                if (randomNumbers[countStep] == 13)
                {
                    roundPicture25.Image = Image.FromFile("../images/13.png");
                    roundPicture34.Image = Image.FromFile("../images/13m.png");

                }
                if (randomNumbers[countStep] == 14)
                {
                    roundPicture25.Image = Image.FromFile("../images/14.png");
                    roundPicture34.Image = Image.FromFile("../images/14m.png");

                }
                if (randomNumbers[countStep] == 15)
                {
                    roundPicture25.Image = Image.FromFile("../images/15.png");
                    roundPicture34.Image = Image.FromFile("../images/15m.png");

                }
                if (randomNumbers[countStep] == 16)
                {
                    roundPicture25.Image = Image.FromFile("../images/16.png");
                    roundPicture34.Image = Image.FromFile("../images/16m.png");

                }

                if (randomNumbers[countStep] == 17)
                {
                    roundPicture25.Image = Image.FromFile("../images/17.png");
                    roundPicture34.Image = Image.FromFile("../images/17m.png");

                }
                if (randomNumbers[countStep] == 18)
                {
                    roundPicture25.Image = Image.FromFile("../images/18.png");
                    roundPicture34.Image = Image.FromFile("../images/18m.png");

                }
                if (randomNumbers[countStep] == 19)
                {
                    roundPicture25.Image = Image.FromFile("../images/19.png");
                    roundPicture34.Image = Image.FromFile("../images/19m.png");

                }
                if (randomNumbers[countStep] == 20)
                {
                    roundPicture25.Image = Image.FromFile("../images/20.png");
                    roundPicture34.Image = Image.FromFile("../images/20m.png");

                }
                if (randomNumbers[countStep] == 21)
                {
                    roundPicture25.Image = Image.FromFile("../images/21.png");
                    roundPicture34.Image = Image.FromFile("../images/21m.png");

                }
                if (randomNumbers[countStep] == 22)
                {
                    roundPicture25.Image = Image.FromFile("../images/22.png");
                    roundPicture34.Image = Image.FromFile("../images/22m.png");

                }
                if (randomNumbers[countStep] == 23)
                {
                    roundPicture25.Image = Image.FromFile("../images/23.png");
                    roundPicture34.Image = Image.FromFile("../images/23mm.png");

                }
                if (randomNumbers[countStep] == 24)
                {
                    roundPicture25.Image = Image.FromFile("../images/24.png");
                    roundPicture34.Image = Image.FromFile("../images/24m.png");

                }
            }

            countStep = 9;

            if (countStep == 9)
            {
                var t1 = Task.Delay(2000);
                await t1;
                if (randomNumbers[countStep] == 1)
                {
                    roundPicture25.Image = Image.FromFile("../images/1.png");
                    roundPicture36.Image = Image.FromFile("../images/1mm.png");

                }
                if (randomNumbers[countStep] == 2)
                {
                    roundPicture25.Image = Image.FromFile("../images/2.png");
                    roundPicture36.Image = Image.FromFile("../images/2m.png");

                }
                if (randomNumbers[countStep] == 3)
                {
                    roundPicture25.Image = Image.FromFile("../images/3.png");
                    roundPicture36.Image = Image.FromFile("../images/3m.png");

                }
                if (randomNumbers[countStep] == 4)
                {
                    roundPicture25.Image = Image.FromFile("../images/4.png");
                    roundPicture36.Image = Image.FromFile("../images/4m.png");

                }

                if (randomNumbers[countStep] == 5)
                {
                    roundPicture25.Image = Image.FromFile("../images/5.png");
                    roundPicture36.Image = Image.FromFile("../images/5m.png");

                }
                if (randomNumbers[countStep] == 6)
                {
                    roundPicture25.Image = Image.FromFile("../images/6.png");
                    roundPicture36.Image = Image.FromFile("../images/6m.png");

                }
                if (randomNumbers[countStep] == 7)
                {
                    roundPicture25.Image = Image.FromFile("../images/7.png");
                    roundPicture36.Image = Image.FromFile("../images/7m.png");

                }
                if (randomNumbers[countStep] == 8)
                {
                    roundPicture25.Image = Image.FromFile("../images/8.png");
                    roundPicture36.Image = Image.FromFile("../images/8m.png");

                }
                if (randomNumbers[countStep] == 9)
                {
                    roundPicture25.Image = Image.FromFile("../images/9.png");
                    roundPicture36.Image = Image.FromFile("../images/9m.png");

                }
                if (randomNumbers[countStep] == 10)
                {
                    roundPicture25.Image = Image.FromFile("../images/10.png");
                    roundPicture36.Image = Image.FromFile("../images/10m.png");

                }
                if (randomNumbers[countStep] == 11)
                {
                    roundPicture25.Image = Image.FromFile("../images/11.png");
                    roundPicture36.Image = Image.FromFile("../images/11m.png");

                }
                if (randomNumbers[countStep] == 12)
                {
                    roundPicture25.Image = Image.FromFile("../images/12.png");
                    roundPicture36.Image = Image.FromFile("../images/12m.png");

                }
                if (randomNumbers[countStep] == 13)
                {
                    roundPicture25.Image = Image.FromFile("../images/13.png");
                    roundPicture36.Image = Image.FromFile("../images/13m.png");

                }
                if (randomNumbers[countStep] == 14)
                {
                    roundPicture25.Image = Image.FromFile("../images/14.png");
                    roundPicture36.Image = Image.FromFile("../images/14m.png");

                }
                if (randomNumbers[countStep] == 15)
                {
                    roundPicture25.Image = Image.FromFile("../images/15.png");
                    roundPicture36.Image = Image.FromFile("../images/15m.png");

                }
                if (randomNumbers[countStep] == 16)
                {
                    roundPicture25.Image = Image.FromFile("../images/16.png");
                    roundPicture36.Image = Image.FromFile("../images/16m.png");

                }

                if (randomNumbers[countStep] == 17)
                {
                    roundPicture25.Image = Image.FromFile("../images/17.png");
                    roundPicture36.Image = Image.FromFile("../images/17m.png");

                }
                if (randomNumbers[countStep] == 18)
                {
                    roundPicture25.Image = Image.FromFile("../images/18.png");
                    roundPicture36.Image = Image.FromFile("../images/18m.png");

                }
                if (randomNumbers[countStep] == 19)
                {
                    roundPicture25.Image = Image.FromFile("../images/19.png");
                    roundPicture36.Image = Image.FromFile("../images/19m.png");

                }
                if (randomNumbers[countStep] == 20)
                {
                    roundPicture25.Image = Image.FromFile("../images/20.png");
                    roundPicture36.Image = Image.FromFile("../images/20m.png");

                }
                if (randomNumbers[countStep] == 21)
                {
                    roundPicture25.Image = Image.FromFile("../images/21.png");
                    roundPicture36.Image = Image.FromFile("../images/21m.png");

                }
                if (randomNumbers[countStep] == 22)
                {
                    roundPicture25.Image = Image.FromFile("../images/22.png");
                    roundPicture36.Image = Image.FromFile("../images/22m.png");

                }
                if (randomNumbers[countStep] == 23)
                {
                    roundPicture25.Image = Image.FromFile("../images/23.png");
                    roundPicture36.Image = Image.FromFile("../images/23mm.png");

                }
                if (randomNumbers[countStep] == 24)
                {
                    roundPicture25.Image = Image.FromFile("../images/24.png");
                    roundPicture36.Image = Image.FromFile("../images/24m.png");

                }
            }
            countStep = 10;

            if (countStep == 10)
            {
                var t1 = Task.Delay(2000);
                await t1;
                if (randomNumbers[countStep] == 1)
                {
                    roundPicture25.Image = Image.FromFile("../images/1.png");
                    roundPicture38.Image = Image.FromFile("../images/1mm.png");

                }
                if (randomNumbers[countStep] == 2)
                {
                    roundPicture25.Image = Image.FromFile("../images/2.png");
                    roundPicture38.Image = Image.FromFile("../images/2m.png");

                }
                if (randomNumbers[countStep] == 3)
                {
                    roundPicture25.Image = Image.FromFile("../images/3.png");
                    roundPicture38.Image = Image.FromFile("../images/3m.png");

                }
                if (randomNumbers[countStep] == 4)
                {
                    roundPicture25.Image = Image.FromFile("../images/4.png");
                    roundPicture38.Image = Image.FromFile("../images/4m.png");

                }

                if (randomNumbers[countStep] == 5)
                {
                    roundPicture25.Image = Image.FromFile("../images/5.png");
                    roundPicture38.Image = Image.FromFile("../images/5m.png");

                }
                if (randomNumbers[countStep] == 6)
                {
                    roundPicture25.Image = Image.FromFile("../images/6.png");
                    roundPicture38.Image = Image.FromFile("../images/6m.png");

                }
                if (randomNumbers[countStep] == 7)
                {
                    roundPicture25.Image = Image.FromFile("../images/7.png");
                    roundPicture38.Image = Image.FromFile("../images/7m.png");

                }
                if (randomNumbers[countStep] == 8)
                {
                    roundPicture25.Image = Image.FromFile("../images/8.png");
                    roundPicture38.Image = Image.FromFile("../images/8m.png");

                }
                if (randomNumbers[countStep] == 9)
                {
                    roundPicture25.Image = Image.FromFile("../images/9.png");
                    roundPicture38.Image = Image.FromFile("../images/9m.png");

                }
                if (randomNumbers[countStep] == 10)
                {
                    roundPicture25.Image = Image.FromFile("../images/10.png");
                    roundPicture38.Image = Image.FromFile("../images/10m.png");

                }
                if (randomNumbers[countStep] == 11)
                {
                    roundPicture25.Image = Image.FromFile("../images/11.png");
                    roundPicture38.Image = Image.FromFile("../images/11m.png");

                }
                if (randomNumbers[countStep] == 12)
                {
                    roundPicture25.Image = Image.FromFile("../images/12.png");
                    roundPicture38.Image = Image.FromFile("../images/12m.png");

                }
                if (randomNumbers[countStep] == 13)
                {
                    roundPicture25.Image = Image.FromFile("../images/13.png");
                    roundPicture38.Image = Image.FromFile("../images/13m.png");

                }
                if (randomNumbers[countStep] == 14)
                {
                    roundPicture25.Image = Image.FromFile("../images/14.png");
                    roundPicture38.Image = Image.FromFile("../images/14m.png");

                }
                if (randomNumbers[countStep] == 15)
                {
                    roundPicture25.Image = Image.FromFile("../images/15.png");
                    roundPicture38.Image = Image.FromFile("../images/15m.png");

                }
                if (randomNumbers[countStep] == 16)
                {
                    roundPicture25.Image = Image.FromFile("../images/16.png");
                    roundPicture38.Image = Image.FromFile("../images/16m.png");

                }

                if (randomNumbers[countStep] == 17)
                {
                    roundPicture25.Image = Image.FromFile("../images/17.png");
                    roundPicture38.Image = Image.FromFile("../images/17m.png");

                }
                if (randomNumbers[countStep] == 18)
                {
                    roundPicture25.Image = Image.FromFile("../images/18.png");
                    roundPicture38.Image = Image.FromFile("../images/18m.png");

                }
                if (randomNumbers[countStep] == 19)
                {
                    roundPicture25.Image = Image.FromFile("../images/19.png");
                    roundPicture38.Image = Image.FromFile("../images/19m.png");

                }
                if (randomNumbers[countStep] == 20)
                {
                    roundPicture25.Image = Image.FromFile("../images/20.png");
                    roundPicture38.Image = Image.FromFile("../images/20m.png");

                }
                if (randomNumbers[countStep] == 21)
                {
                    roundPicture25.Image = Image.FromFile("../images/21.png");
                    roundPicture38.Image = Image.FromFile("../images/21m.png");

                }
                if (randomNumbers[countStep] == 22)
                {
                    roundPicture25.Image = Image.FromFile("../images/22.png");
                    roundPicture38.Image = Image.FromFile("../images/22m.png");

                }
                if (randomNumbers[countStep] == 23)
                {
                    roundPicture25.Image = Image.FromFile("../images/23.png");
                    roundPicture38.Image = Image.FromFile("../images/23mm.png");

                }
                if (randomNumbers[countStep] == 24)
                {
                    roundPicture25.Image = Image.FromFile("../images/24.png");
                    roundPicture38.Image = Image.FromFile("../images/24m.png");

                }
            }

            countStep = 11;

            if (countStep == 11)
            {
                var t1 = Task.Delay(2000);
                await t1;
                if (randomNumbers[countStep] == 1)
                {
                    roundPicture25.Image = Image.FromFile("../images/1.png");
                    roundPicture40.Image = Image.FromFile("../images/1mm.png");

                }
                if (randomNumbers[countStep] == 2)
                {
                    roundPicture25.Image = Image.FromFile("../images/2.png");
                    roundPicture40.Image = Image.FromFile("../images/2m.png");

                }
                if (randomNumbers[countStep] == 3)
                {
                    roundPicture25.Image = Image.FromFile("../images/3.png");
                    roundPicture40.Image = Image.FromFile("../images/3m.png");

                }
                if (randomNumbers[countStep] == 4)
                {
                    roundPicture25.Image = Image.FromFile("../images/4.png");
                    roundPicture40.Image = Image.FromFile("../images/4m.png");

                }

                if (randomNumbers[countStep] == 5)
                {
                    roundPicture25.Image = Image.FromFile("../images/5.png");
                    roundPicture40.Image = Image.FromFile("../images/5m.png");

                }
                if (randomNumbers[countStep] == 6)
                {
                    roundPicture25.Image = Image.FromFile("../images/6.png");
                    roundPicture40.Image = Image.FromFile("../images/6m.png");

                }
                if (randomNumbers[countStep] == 7)
                {
                    roundPicture25.Image = Image.FromFile("../images/7.png");
                    roundPicture40.Image = Image.FromFile("../images/7m.png");

                }
                if (randomNumbers[countStep] == 8)
                {
                    roundPicture25.Image = Image.FromFile("../images/8.png");
                    roundPicture40.Image = Image.FromFile("../images/8m.png");

                }
                if (randomNumbers[countStep] == 9)
                {
                    roundPicture25.Image = Image.FromFile("../images/9.png");
                    roundPicture40.Image = Image.FromFile("../images/9m.png");

                }
                if (randomNumbers[countStep] == 10)
                {
                    roundPicture25.Image = Image.FromFile("../images/10.png");
                    roundPicture40.Image = Image.FromFile("../images/10m.png");

                }
                if (randomNumbers[countStep] == 11)
                {
                    roundPicture25.Image = Image.FromFile("../images/11.png");
                    roundPicture40.Image = Image.FromFile("../images/11m.png");

                }
                if (randomNumbers[countStep] == 12)
                {
                    roundPicture25.Image = Image.FromFile("../images/12.png");
                    roundPicture40.Image = Image.FromFile("../images/12m.png");

                }
                if (randomNumbers[countStep] == 13)
                {
                    roundPicture25.Image = Image.FromFile("../images/13.png");
                    roundPicture40.Image = Image.FromFile("../images/13m.png");

                }
                if (randomNumbers[countStep] == 14)
                {
                    roundPicture25.Image = Image.FromFile("../images/14.png");
                    roundPicture40.Image = Image.FromFile("../images/14m.png");

                }
                if (randomNumbers[countStep] == 15)
                {
                    roundPicture25.Image = Image.FromFile("../images/15.png");
                    roundPicture40.Image = Image.FromFile("../images/15m.png");

                }
                if (randomNumbers[countStep] == 16)
                {
                    roundPicture25.Image = Image.FromFile("../images/16.png");
                    roundPicture40.Image = Image.FromFile("../images/16m.png");

                }

                if (randomNumbers[countStep] == 17)
                {
                    roundPicture25.Image = Image.FromFile("../images/17.png");
                    roundPicture40.Image = Image.FromFile("../images/17m.png");

                }
                if (randomNumbers[countStep] == 18)
                {
                    roundPicture25.Image = Image.FromFile("../images/18.png");
                    roundPicture40.Image = Image.FromFile("../images/18m.png");

                }
                if (randomNumbers[countStep] == 19)
                {
                    roundPicture25.Image = Image.FromFile("../images/19.png");
                    roundPicture40.Image = Image.FromFile("../images/19m.png");

                }
                if (randomNumbers[countStep] == 20)
                {
                    roundPicture25.Image = Image.FromFile("../images/20.png");
                    roundPicture40.Image = Image.FromFile("../images/20m.png");

                }
                if (randomNumbers[countStep] == 21)
                {
                    roundPicture25.Image = Image.FromFile("../images/21.png");
                    roundPicture40.Image = Image.FromFile("../images/21m.png");

                }
                if (randomNumbers[countStep] == 22)
                {
                    roundPicture25.Image = Image.FromFile("../images/22.png");
                    roundPicture40.Image = Image.FromFile("../images/22m.png");

                }
                if (randomNumbers[countStep] == 23)
                {
                    roundPicture25.Image = Image.FromFile("../images/23.png");
                    roundPicture40.Image = Image.FromFile("../images/23mm.png");

                }
                if (randomNumbers[countStep] == 24)
                {
                    roundPicture25.Image = Image.FromFile("../images/24.png");
                    roundPicture40.Image = Image.FromFile("../images/24m.png");

                }
            }
            countStep = 12;

            if (countStep == 12)
            {
                var t1 = Task.Delay(2000);
                await t1;
                if (randomNumbers[countStep] == 1)
                {
                    roundPicture25.Image = Image.FromFile("../images/1.png");
                    roundPicture35.Image = Image.FromFile("../images/1mm.png");

                }
                if (randomNumbers[countStep] == 2)
                {
                    roundPicture25.Image = Image.FromFile("../images/2.png");
                    roundPicture35.Image = Image.FromFile("../images/2m.png");

                }
                if (randomNumbers[countStep] == 3)
                {
                    roundPicture25.Image = Image.FromFile("../images/3.png");
                    roundPicture35.Image = Image.FromFile("../images/3m.png");

                }
                if (randomNumbers[countStep] == 4)
                {
                    roundPicture25.Image = Image.FromFile("../images/4.png");
                    roundPicture35.Image = Image.FromFile("../images/4m.png");

                }

                if (randomNumbers[countStep] == 5)
                {
                    roundPicture25.Image = Image.FromFile("../images/5.png");
                    roundPicture35.Image = Image.FromFile("../images/5m.png");

                }
                if (randomNumbers[countStep] == 6)
                {
                    roundPicture25.Image = Image.FromFile("../images/6.png");
                    roundPicture35.Image = Image.FromFile("../images/6m.png");

                }
                if (randomNumbers[countStep] == 7)
                {
                    roundPicture25.Image = Image.FromFile("../images/7.png");
                    roundPicture35.Image = Image.FromFile("../images/7m.png");

                }
                if (randomNumbers[countStep] == 8)
                {
                    roundPicture25.Image = Image.FromFile("../images/8.png");
                    roundPicture35.Image = Image.FromFile("../images/8m.png");

                }
                if (randomNumbers[countStep] == 9)
                {
                    roundPicture25.Image = Image.FromFile("../images/9.png");
                    roundPicture35.Image = Image.FromFile("../images/9m.png");

                }
                if (randomNumbers[countStep] == 10)
                {
                    roundPicture25.Image = Image.FromFile("../images/10.png");
                    roundPicture35.Image = Image.FromFile("../images/10m.png");

                }
                if (randomNumbers[countStep] == 11)
                {
                    roundPicture25.Image = Image.FromFile("../images/11.png");
                    roundPicture35.Image = Image.FromFile("../images/11m.png");

                }
                if (randomNumbers[countStep] == 12)
                {
                    roundPicture25.Image = Image.FromFile("../images/12.png");
                    roundPicture35.Image = Image.FromFile("../images/12m.png");

                }
                if (randomNumbers[countStep] == 13)
                {
                    roundPicture25.Image = Image.FromFile("../images/13.png");
                    roundPicture35.Image = Image.FromFile("../images/13m.png");

                }
                if (randomNumbers[countStep] == 14)
                {
                    roundPicture25.Image = Image.FromFile("../images/14.png");
                    roundPicture35.Image = Image.FromFile("../images/14m.png");

                }
                if (randomNumbers[countStep] == 15)
                {
                    roundPicture25.Image = Image.FromFile("../images/15.png");
                    roundPicture35.Image = Image.FromFile("../images/15m.png");

                }
                if (randomNumbers[countStep] == 16)
                {
                    roundPicture25.Image = Image.FromFile("../images/16.png");
                    roundPicture35.Image = Image.FromFile("../images/16m.png");

                }

                if (randomNumbers[countStep] == 17)
                {
                    roundPicture25.Image = Image.FromFile("../images/17.png");
                    roundPicture35.Image = Image.FromFile("../images/17m.png");

                }
                if (randomNumbers[countStep] == 18)
                {
                    roundPicture25.Image = Image.FromFile("../images/18.png");
                    roundPicture35.Image = Image.FromFile("../images/18m.png");

                }
                if (randomNumbers[countStep] == 19)
                {
                    roundPicture25.Image = Image.FromFile("../images/19.png");
                    roundPicture35.Image = Image.FromFile("../images/19m.png");

                }
                if (randomNumbers[countStep] == 20)
                {
                    roundPicture25.Image = Image.FromFile("../images/20.png");
                    roundPicture35.Image = Image.FromFile("../images/20m.png");

                }
                if (randomNumbers[countStep] == 21)
                {
                    roundPicture25.Image = Image.FromFile("../images/21.png");
                    roundPicture35.Image = Image.FromFile("../images/21m.png");

                }
                if (randomNumbers[countStep] == 22)
                {
                    roundPicture25.Image = Image.FromFile("../images/22.png");
                    roundPicture35.Image = Image.FromFile("../images/22m.png");

                }
                if (randomNumbers[countStep] == 23)
                {
                    roundPicture25.Image = Image.FromFile("../images/23.png");
                    roundPicture35.Image = Image.FromFile("../images/23mm.png");

                }
                if (randomNumbers[countStep] == 24)
                {
                    roundPicture25.Image = Image.FromFile("../images/24.png");
                    roundPicture35.Image = Image.FromFile("../images/24m.png");

                }
            }

            countStep = 13;

            if (countStep == 13)
            {
                var t1 = Task.Delay(2000);
                await t1;
                if (randomNumbers[countStep] == 1)
                {
                    roundPicture25.Image = Image.FromFile("../images/1.png");
                    roundPicture37.Image = Image.FromFile("../images/1mm.png");

                }
                if (randomNumbers[countStep] == 2)
                {
                    roundPicture25.Image = Image.FromFile("../images/2.png");
                    roundPicture37.Image = Image.FromFile("../images/2m.png");

                }
                if (randomNumbers[countStep] == 3)
                {
                    roundPicture25.Image = Image.FromFile("../images/3.png");
                    roundPicture37.Image = Image.FromFile("../images/3m.png");

                }
                if (randomNumbers[countStep] == 4)
                {
                    roundPicture25.Image = Image.FromFile("../images/4.png");
                    roundPicture37.Image = Image.FromFile("../images/4m.png");

                }

                if (randomNumbers[countStep] == 5)
                {
                    roundPicture25.Image = Image.FromFile("../images/5.png");
                    roundPicture37.Image = Image.FromFile("../images/5m.png");

                }
                if (randomNumbers[countStep] == 6)
                {
                    roundPicture25.Image = Image.FromFile("../images/6.png");
                    roundPicture37.Image = Image.FromFile("../images/6m.png");

                }
                if (randomNumbers[countStep] == 7)
                {
                    roundPicture25.Image = Image.FromFile("../images/7.png");
                    roundPicture37.Image = Image.FromFile("../images/7m.png");

                }
                if (randomNumbers[countStep] == 8)
                {
                    roundPicture25.Image = Image.FromFile("../images/8.png");
                    roundPicture37.Image = Image.FromFile("../images/8m.png");

                }
                if (randomNumbers[countStep] == 9)
                {
                    roundPicture25.Image = Image.FromFile("../images/9.png");
                    roundPicture37.Image = Image.FromFile("../images/9m.png");

                }
                if (randomNumbers[countStep] == 10)
                {
                    roundPicture25.Image = Image.FromFile("../images/10.png");
                    roundPicture37.Image = Image.FromFile("../images/10m.png");

                }
                if (randomNumbers[countStep] == 11)
                {
                    roundPicture25.Image = Image.FromFile("../images/11.png");
                    roundPicture37.Image = Image.FromFile("../images/11m.png");

                }
                if (randomNumbers[countStep] == 12)
                {
                    roundPicture25.Image = Image.FromFile("../images/12.png");
                    roundPicture37.Image = Image.FromFile("../images/12m.png");

                }
                if (randomNumbers[countStep] == 13)
                {
                    roundPicture25.Image = Image.FromFile("../images/13.png");
                    roundPicture37.Image = Image.FromFile("../images/13m.png");

                }
                if (randomNumbers[countStep] == 14)
                {
                    roundPicture25.Image = Image.FromFile("../images/14.png");
                    roundPicture37.Image = Image.FromFile("../images/14m.png");

                }
                if (randomNumbers[countStep] == 15)
                {
                    roundPicture25.Image = Image.FromFile("../images/15.png");
                    roundPicture37.Image = Image.FromFile("../images/15m.png");

                }
                if (randomNumbers[countStep] == 16)
                {
                    roundPicture25.Image = Image.FromFile("../images/16.png");
                    roundPicture37.Image = Image.FromFile("../images/16m.png");

                }

                if (randomNumbers[countStep] == 17)
                {
                    roundPicture25.Image = Image.FromFile("../images/17.png");
                    roundPicture37.Image = Image.FromFile("../images/17m.png");

                }
                if (randomNumbers[countStep] == 18)
                {
                    roundPicture25.Image = Image.FromFile("../images/18.png");
                    roundPicture37.Image = Image.FromFile("../images/18m.png");

                }
                if (randomNumbers[countStep] == 19)
                {
                    roundPicture25.Image = Image.FromFile("../images/19.png");
                    roundPicture37.Image = Image.FromFile("../images/19m.png");

                }
                if (randomNumbers[countStep] == 20)
                {
                    roundPicture25.Image = Image.FromFile("../images/20.png");
                    roundPicture37.Image = Image.FromFile("../images/20m.png");

                }
                if (randomNumbers[countStep] == 21)
                {
                    roundPicture25.Image = Image.FromFile("../images/21.png");
                    roundPicture37.Image = Image.FromFile("../images/21m.png");

                }
                if (randomNumbers[countStep] == 22)
                {
                    roundPicture25.Image = Image.FromFile("../images/22.png");
                    roundPicture37.Image = Image.FromFile("../images/22m.png");

                }
                if (randomNumbers[countStep] == 23)
                {
                    roundPicture25.Image = Image.FromFile("../images/23.png");
                    roundPicture37.Image = Image.FromFile("../images/23mm.png");

                }
                if (randomNumbers[countStep] == 24)
                {
                    roundPicture25.Image = Image.FromFile("../images/24.png");
                    roundPicture37.Image = Image.FromFile("../images/24m.png");

                }
            }

            countStep = 14;

            if (countStep == 14)
            {
                var t1 = Task.Delay(2000);
                await t1;
                if (randomNumbers[countStep] == 1)
                {
                    roundPicture25.Image = Image.FromFile("../images/1.png");
                    roundPicture39.Image = Image.FromFile("../images/1mm.png");

                }
                if (randomNumbers[countStep] == 2)
                {
                    roundPicture25.Image = Image.FromFile("../images/2.png");
                    roundPicture39.Image = Image.FromFile("../images/2m.png");

                }
                if (randomNumbers[countStep] == 3)
                {
                    roundPicture25.Image = Image.FromFile("../images/3.png");
                    roundPicture39.Image = Image.FromFile("../images/3m.png");

                }
                if (randomNumbers[countStep] == 4)
                {
                    roundPicture25.Image = Image.FromFile("../images/4.png");
                    roundPicture39.Image = Image.FromFile("../images/4m.png");

                }

                if (randomNumbers[countStep] == 5)
                {
                    roundPicture25.Image = Image.FromFile("../images/5.png");
                    roundPicture39.Image = Image.FromFile("../images/5m.png");

                }
                if (randomNumbers[countStep] == 6)
                {
                    roundPicture25.Image = Image.FromFile("../images/6.png");
                    roundPicture39.Image = Image.FromFile("../images/6m.png");

                }
                if (randomNumbers[countStep] == 7)
                {
                    roundPicture25.Image = Image.FromFile("../images/7.png");
                    roundPicture39.Image = Image.FromFile("../images/7m.png");

                }
                if (randomNumbers[countStep] == 8)
                {
                    roundPicture25.Image = Image.FromFile("../images/8.png");
                    roundPicture39.Image = Image.FromFile("../images/8m.png");

                }
                if (randomNumbers[countStep] == 9)
                {
                    roundPicture25.Image = Image.FromFile("../images/9.png");
                    roundPicture39.Image = Image.FromFile("../images/9m.png");

                }
                if (randomNumbers[countStep] == 10)
                {
                    roundPicture25.Image = Image.FromFile("../images/10.png");
                    roundPicture39.Image = Image.FromFile("../images/10m.png");

                }
                if (randomNumbers[countStep] == 11)
                {
                    roundPicture25.Image = Image.FromFile("../images/11.png");
                    roundPicture39.Image = Image.FromFile("../images/11m.png");

                }
                if (randomNumbers[countStep] == 12)
                {
                    roundPicture25.Image = Image.FromFile("../images/12.png");
                    roundPicture39.Image = Image.FromFile("../images/12m.png");

                }
                if (randomNumbers[countStep] == 13)
                {
                    roundPicture25.Image = Image.FromFile("../images/13.png");
                    roundPicture39.Image = Image.FromFile("../images/13m.png");

                }
                if (randomNumbers[countStep] == 14)
                {
                    roundPicture25.Image = Image.FromFile("../images/14.png");
                    roundPicture39.Image = Image.FromFile("../images/14m.png");

                }
                if (randomNumbers[countStep] == 15)
                {
                    roundPicture25.Image = Image.FromFile("../images/15.png");
                    roundPicture39.Image = Image.FromFile("../images/15m.png");

                }
                if (randomNumbers[countStep] == 16)
                {
                    roundPicture25.Image = Image.FromFile("../images/16.png");
                    roundPicture39.Image = Image.FromFile("../images/16m.png");

                }

                if (randomNumbers[countStep] == 17)
                {
                    roundPicture25.Image = Image.FromFile("../images/17.png");
                    roundPicture39.Image = Image.FromFile("../images/17m.png");

                }
                if (randomNumbers[countStep] == 18)
                {
                    roundPicture25.Image = Image.FromFile("../images/18.png");
                    roundPicture39.Image = Image.FromFile("../images/18m.png");

                }
                if (randomNumbers[countStep] == 19)
                {
                    roundPicture25.Image = Image.FromFile("../images/19.png");
                    roundPicture39.Image = Image.FromFile("../images/19m.png");

                }
                if (randomNumbers[countStep] == 20)
                {
                    roundPicture25.Image = Image.FromFile("../images/20.png");
                    roundPicture39.Image = Image.FromFile("../images/20m.png");

                }
                if (randomNumbers[countStep] == 21)
                {
                    roundPicture25.Image = Image.FromFile("../images/21.png");
                    roundPicture39.Image = Image.FromFile("../images/21m.png");

                }
                if (randomNumbers[countStep] == 22)
                {
                    roundPicture25.Image = Image.FromFile("../images/22.png");
                    roundPicture39.Image = Image.FromFile("../images/22m.png");

                }
                if (randomNumbers[countStep] == 23)
                {
                    roundPicture25.Image = Image.FromFile("../images/23.png");
                    roundPicture39.Image = Image.FromFile("../images/23mmm.png");

                }
                if (randomNumbers[countStep] == 24)
                {
                    roundPicture25.Image = Image.FromFile("../images/24.png");
                    roundPicture39.Image = Image.FromFile("../images/24m.png");
                }
                countStep++;
            }
            if (countStep == 15)
            {
                var t1 = Task.Delay(2000);
                await t1;
                if (randomNumbers[countStep] == 1)
                {
                    roundPicture25.Image = Image.FromFile("../images/1.png");
                    roundPicture41.Image = Image.FromFile("../images/1mm.png");

                }
                if (randomNumbers[countStep] == 2)
                {
                    roundPicture25.Image = Image.FromFile("../images/2.png");
                    roundPicture41.Image = Image.FromFile("../images/2m.png");

                }
                if (randomNumbers[countStep] == 3)
                {
                    roundPicture25.Image = Image.FromFile("../images/3.png");
                    roundPicture41.Image = Image.FromFile("../images/3m.png");

                }
                if (randomNumbers[countStep] == 4)
                {
                    roundPicture25.Image = Image.FromFile("../images/4.png");
                    roundPicture41.Image = Image.FromFile("../images/4m.png");

                }

                if (randomNumbers[countStep] == 5)
                {
                    roundPicture25.Image = Image.FromFile("../images/5.png");
                    roundPicture41.Image = Image.FromFile("../images/5m.png");

                }
                if (randomNumbers[countStep] == 6)
                {
                    roundPicture25.Image = Image.FromFile("../images/6.png");
                    roundPicture41.Image = Image.FromFile("../images/6m.png");

                }
                if (randomNumbers[countStep] == 7)
                {
                    roundPicture25.Image = Image.FromFile("../images/7.png");
                    roundPicture41.Image = Image.FromFile("../images/7m.png");

                }
                if (randomNumbers[countStep] == 8)
                {
                    roundPicture25.Image = Image.FromFile("../images/8.png");
                    roundPicture41.Image = Image.FromFile("../images/8m.png");

                }
                if (randomNumbers[countStep] == 9)
                {
                    roundPicture25.Image = Image.FromFile("../images/9.png");
                    roundPicture41.Image = Image.FromFile("../images/9m.png");

                }
                if (randomNumbers[countStep] == 10)
                {
                    roundPicture25.Image = Image.FromFile("../images/10.png");
                    roundPicture41.Image = Image.FromFile("../images/10m.png");

                }
                if (randomNumbers[countStep] == 11)
                {
                    roundPicture25.Image = Image.FromFile("../images/11.png");
                    roundPicture41.Image = Image.FromFile("../images/11m.png");

                }
                if (randomNumbers[countStep] == 12)
                {
                    roundPicture25.Image = Image.FromFile("../images/12.png");
                    roundPicture41.Image = Image.FromFile("../images/12m.png");

                }
                if (randomNumbers[countStep] == 13)
                {
                    roundPicture25.Image = Image.FromFile("../images/13.png");
                    roundPicture41.Image = Image.FromFile("../images/13m.png");

                }
                if (randomNumbers[countStep] == 14)
                {
                    roundPicture25.Image = Image.FromFile("../images/14.png");
                    roundPicture41.Image = Image.FromFile("../images/14m.png");

                }
                if (randomNumbers[countStep] == 15)
                {
                    roundPicture25.Image = Image.FromFile("../images/15.png");
                    roundPicture41.Image = Image.FromFile("../images/15m.png");

                }
                if (randomNumbers[countStep] == 16)
                {
                    roundPicture25.Image = Image.FromFile("../images/16.png");
                    roundPicture41.Image = Image.FromFile("../images/16m.png");

                }

                if (randomNumbers[countStep] == 17)
                {
                    roundPicture25.Image = Image.FromFile("../images/17.png");
                    roundPicture41.Image = Image.FromFile("../images/17m.png");

                }
                if (randomNumbers[countStep] == 18)
                {
                    roundPicture25.Image = Image.FromFile("../images/18.png");
                    roundPicture41.Image = Image.FromFile("../images/18m.png");

                }
                if (randomNumbers[countStep] == 19)
                {
                    roundPicture25.Image = Image.FromFile("../images/19.png");
                    roundPicture41.Image = Image.FromFile("../images/19m.png");

                }
                if (randomNumbers[countStep] == 20)
                {
                    roundPicture25.Image = Image.FromFile("../images/20.png");
                    roundPicture41.Image = Image.FromFile("../images/20m.png");

                }
                if (randomNumbers[countStep] == 21)
                {
                    roundPicture25.Image = Image.FromFile("../images/21.png");
                    roundPicture41.Image = Image.FromFile("../images/21m.png");

                }
                if (randomNumbers[countStep] == 22)
                {
                    roundPicture25.Image = Image.FromFile("../images/22.png");
                    roundPicture41.Image = Image.FromFile("../images/22m.png");

                }
                if (randomNumbers[countStep] == 23)
                {
                    roundPicture25.Image = Image.FromFile("../images/23.png");
                    roundPicture41.Image = Image.FromFile("../images/23mm.png");

                }
                if (randomNumbers[countStep] == 24)
                {
                    roundPicture25.Image = Image.FromFile("../images/24.png");
                    roundPicture41.Image = Image.FromFile("../images/24m.png");
                }

                aaaa.Text += equalNumbers; /// broj pogodjenih brojeva
                aaaa.Text += "/6";
                var t2 = Task.Delay(5000);
                await t2;


                if (equalNumbers == 6)
                {
                    var myFormW = new Victory();
                    myFormW.Show();
                }
                else
                {
                    var myFormA = new Almost();
                    myFormA.Show();
                }

            }

        }

    }

}