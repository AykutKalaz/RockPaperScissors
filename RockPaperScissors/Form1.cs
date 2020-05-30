using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        public string[] bilgisayar = new string[3];
        public string[] ben = new string[3];
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int no = random.Next(0, 3);
            
            if(cmbSec.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen listeden birini seçin");
            }
            else
            {
                pctBilgisayar.ImageLocation = bilgisayar[no];
                if (cmbSec.SelectedIndex == no)
                {
                    lblSonuc.Text = "Berabere";
                    lblSonuc.ForeColor = Color.Yellow;
                }
                else if (cmbSec.SelectedIndex == 0)
                {
                    if (no == 1)
                    {
                        lblSonuc.Text = "Kaybettiniz";
                        lblSonuc.ForeColor = Color.Red;
                    }
                    else if (no == 2)
                    {
                        lblSonuc.Text = "Kazandınız";
                        lblSonuc.ForeColor = Color.Green;
                    }
                }

                else if (cmbSec.SelectedIndex == 1)
                {
                    if (no == 2)
                    {
                        lblSonuc.Text = "Kaybettiniz";
                        lblSonuc.ForeColor = Color.Red;
                    }
                    else if (no == 0)
                    {
                        lblSonuc.Text = "Kazandınız";
                        lblSonuc.ForeColor = Color.Green;
                    }
                }

                else if (cmbSec.SelectedIndex == 2)
                {
                    if (no == 0)
                    {
                        lblSonuc.Text = "Kaybettiniz";
                        lblSonuc.ForeColor = Color.Red;
                    }
                    else if (no == 1)
                    {
                        lblSonuc.Text = "Kazandınız";
                        lblSonuc.ForeColor = Color.Green;
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bilgisayar[0] = AppDomain.CurrentDomain.BaseDirectory + "RockPaperScissors\\rock.jpg";
            bilgisayar[1] = AppDomain.CurrentDomain.BaseDirectory + "RockPaperScissors\\paper.jpg";
            bilgisayar[2] = AppDomain.CurrentDomain.BaseDirectory + "RockPaperScissors\\scissors.jpg";

            ben[0] = AppDomain.CurrentDomain.BaseDirectory + "RockPaperScissors\\rock1.jpg";
            ben[1] = AppDomain.CurrentDomain.BaseDirectory + "RockPaperScissors\\paper1.jpg";
            ben[2] = AppDomain.CurrentDomain.BaseDirectory + "RockPaperScissors\\scisssors1.jpg";
        }

        private void cmbSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSec.SelectedIndex == 0)
            {
                pctBen.ImageLocation = ben[0];
            }
            else if (cmbSec.SelectedIndex == 1)
            {
                pctBen.ImageLocation = ben[1];
            }
            else if (cmbSec.SelectedIndex == 2)
            {
                pctBen.ImageLocation = ben[2];
            }
            else
                MessageBox.Show("Bir sorun var");
        }
    }
}
