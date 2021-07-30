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
    public partial class Labirinto : Form
    {
        Point startLocation;
        int countDown = 0;
        Thread vol;
        public Labirinto()
        {
            InitializeComponent();
            IniciarJogo();

         
            
        }


        


        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void Labirinto_Load(object sender, EventArgs e)
        {

        }

        private void IniciarJogo()
        {
            GameTimer.Start();
            startLocation = panelInner.Location;
            Cursor.Position = PointToScreen(startLocation);
            countDown = 30;
        }
        private void Labarinto_MouseEnter(object sender, EventArgs e)
        {
            IniciarJogo();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           if(countDown < 0)
            {
                GameTimer.Stop();
                DialogResult msg = MessageBox.Show("Você perdeu!! \n Quer jogar novamente?","Informação", MessageBoxButtons.YesNo);
                if (msg == DialogResult.Yes)
                {
                    IniciarJogo();

                }
                else
                {
                    this.Close();
                    vol = new Thread(Voltar_Escolha);
                    vol.SetApartmentState(ApartmentState.STA);
                    vol.Start();
                }
            
            
            }
            lblTimer.Text = countDown.ToString();
            countDown--;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {

            pictureBox2.Image = Properties.Resources._12;
            GameTimer.Stop();
            DialogResult msg = MessageBox.Show("Você ganhou parabéns!! \n Quer jogar novamente?", "Informação", MessageBoxButtons.YesNo);
            if (msg == DialogResult.Yes)
            {
                IniciarJogo();

            }
            else
            {
                this.Close();
                vol = new Thread(Voltar_Escolha);
                vol.SetApartmentState(ApartmentState.STA);
                vol.Start();
            }
        }

        private void Voltar_Escolha()
        {
            Application.Run(new Escolha());

        }
        private void Voltar()
        {
            Application.Run(new Escolha());
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.Close();
            vol = new Thread(Voltar);
            vol.SetApartmentState(ApartmentState.STA);
            vol.Start();
        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void label42_MouseEnter(object sender, EventArgs e)
        {
            IniciarJogo();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label49_Click(object sender, EventArgs e)
        {

        }
    }
}
