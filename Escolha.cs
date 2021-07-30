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
    public partial class Escolha : Form
    {
        Thread vol;

        public Escolha()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            vol = new Thread(Voltar);
            vol.SetApartmentState(ApartmentState.STA);
            vol.Start();
        }

        public void button2_Click(object sender, EventArgs e)
        {

            this.Close();
            vol = new Thread(Memoria);
            vol.SetApartmentState(ApartmentState.STA);
            vol.Start();


        }

        private void Memoria()
        {
            Application.Run(new Form1());
        }

        private void Quiz()
        {
            Application.Run(new Quiz());
        }
        private void Labirinto()
        {
            Application.Run(new Labirinto());
        }

     
        private void Voltar()
        {
            Application.Run(new Menu());
        }

        private void escol_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.Close();
            vol = new Thread(Voltar);
            vol.SetApartmentState(ApartmentState.STA);
            vol.Start();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            vol = new Thread(Quiz);
            vol.SetApartmentState(ApartmentState.STA);
            vol.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            vol = new Thread(Labirinto);
            vol.SetApartmentState(ApartmentState.STA);
            vol.Start();
        }

     
    }
}
