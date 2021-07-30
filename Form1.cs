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
    public partial class Form1 : Form
    {

        Thread vol;

        int movimentos, cliques, cartasEncontradas, tagIndex;

        Image[] img = new Image[5];

        List<string> lista = new List<string>();

        int[] tags = new int[2];


        public Form1()
        {
            InitializeComponent();
            Inicio();

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
            Application.Run(new Escolha());
        }

        private void Inicio()
        {

            foreach (PictureBox item in Controls.OfType<PictureBox>())
            {

                tagIndex = int.Parse(String.Format("{0}", item.Tag));
                img[tagIndex] = item.Image;

                item.Image = Properties.Resources._33;
                item.Enabled = true;


            }

            Embaralhar();

        }


       private void Embaralhar()
        {

            foreach (PictureBox item in Controls.OfType<PictureBox>())
            {

                Random rdn = new Random();

                int[] xP = { 89, 341, 604, 865, 1105 };
                int[] yP = { 119, 385 };

              Repete:
                var X = xP[rdn.Next(0, xP.Length)];
                var Y = yP[rdn.Next(0, yP.Length)];
            

                string verificacao = X.ToString() + Y.ToString();

                if (lista.Contains(verificacao))
                {

                    goto Repete;

                } else
                {

                    item.Location = new Point(X, Y);
                    lista.Add(verificacao);

                }




            }
        }
        
        
        private void ImagensClick_Click(object sender, EventArgs e)
        {

            bool parEncontrado = false;

            PictureBox pic = (PictureBox)sender;
            cliques++;

            tagIndex = int.Parse(String.Format("{0}", pic.Tag));
            pic.Image = img[tagIndex];
            pic.Refresh();


            if (cliques ==1) { 

                tags[0] = int.Parse(String.Format("{0}", pic.Tag));

            } else if (cliques == 2) {

                movimentos++;
                lblMovimentos.Text = "MOVIMENTOS: " + movimentos.ToString();
                tags[1] = int.Parse(String.Format("{0}", pic.Tag));

                parEncontrado = ChecagemPares();
                Desvirar(parEncontrado);
            }
        }

        private bool ChecagemPares()
        {
            cliques = 0;

            if (tags[0] == tags [1]) { 
                return true;

            } else { 
                return false; } 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Desvirar(bool check)
        {

            Thread.Sleep(700);


            foreach (PictureBox item in Controls.OfType<PictureBox>())
            {

                if(int.Parse(String.Format("{0}", item.Tag)) == tags[0] ||
                   int.Parse(String.Format("{0}", item.Tag)) == tags[1]) {

                    if (check == true)
                    {

                        item.Enabled = false;
                        cartasEncontradas++;

                    } else {
                        item.Image = Properties.Resources._33;
                        item.Refresh();

                    }
                }    
            }

            FinalJogo();

        }


        private void FinalJogo()
        {

            if (cartasEncontradas == img.Length * 2)
            {

                MessageBox.Show("     Parabéns, Você terminou o jogo com " + movimentos.ToString() + " movimentos!!", "Parabenização"); 
                DialogResult msg = MessageBox.Show("Deseja jogar novamente ?", "Caixa de pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (msg == DialogResult.Yes)
                {

                    cliques = 0; movimentos = 0; cartasEncontradas = 0;
                    lista.Clear();
                    Inicio();

                } else if (msg == DialogResult.No){

                    MessageBox.Show("          Obrigado por Jogar!! ", "Caixa de Saída");
                    this.Close();
                    vol = new Thread(Voltar_Escolha);
                    vol.SetApartmentState(ApartmentState.STA);
                    vol.Start();

                }

          


            }
        }

        private void Voltar_Escolha()
        {
            Application.Run(new Escolha());

        }


    }
}
