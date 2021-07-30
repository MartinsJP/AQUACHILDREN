using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Jogo_da_Memoria
{
    public partial class Aprender : Form
    {
        Thread vol;
        int questionNumber = 1;
        public Aprender()
        {
           
            InitializeComponent();
            pictureQuestion(questionNumber);
        }

        public void button1_Click(object sender, EventArgs e)
        {

            this.Close();
            vol = new Thread(Voltar);
            vol.SetApartmentState(ApartmentState.STA);
            vol.Start();


        }

        private void Voltar()
        {
           Application.Run(new Menu());
        }

        private void pictureQuestion(int qnum)
        {



            switch (qnum)
            {

                case 1:
                    pictureBox1.Image = Properties.Resources.primeiro;
                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.segundo;
                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.novocorreto;
                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.quartocorreto;
                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.quinto5;
                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.sexto;
                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.setimo;
                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources.oitavo;
                    break;

                case 9:
                    pictureBox1.Image = Properties.Resources.nono;
                    break;

                case 10:
                    pictureBox1.Image = Properties.Resources.decimo;
                    break;
            }

        }


         private void aprend_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.Close();
            vol = new Thread(Voltar);
            vol.SetApartmentState(ApartmentState.STA);
            vol.Start();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("Sound/play1.wav");
            Player.Play();

        }

    

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (questionNumber < 10)
            {
                questionNumber++;
                pictureQuestion(questionNumber);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (questionNumber > 1)
            {
                questionNumber--;
                pictureQuestion(questionNumber);
            }
        }
    }
}
