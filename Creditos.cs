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
    public partial class Creditos : Form
    {
        Thread vol;

        public Creditos()
        {
            InitializeComponent();
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

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.Close();
            vol = new Thread(Voltar);
            vol.SetApartmentState(ApartmentState.STA);
            vol.Start();
        }

        private void titulo_Click(object sender, EventArgs e)
        {

        }
    }
}
