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
    public partial class Menu : Form
    {



       
        Thread nt;
        Thread ap;
        Thread cr;
        

        public Menu()
        {
            InitializeComponent();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
            nt = new Thread(Jogos);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Deseja realmente sair ?", "Caixa de pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            

            if (msg == DialogResult.Yes)
                {

                   Application.Exit();

                } else if (msg == DialogResult.No){


                }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Close();
            ap = new Thread(Crianca_Aprender);
            ap.SetApartmentState(ApartmentState.STA);
            ap.Start();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Close();
            cr = new Thread(Creditos_Software);
            cr.SetApartmentState(ApartmentState.STA);
            cr.Start();

        }

        private void Creditos_Software()
        {
            Application.Run(new Creditos());

        }

        private void Crianca_Aprender()
        {
            Application.Run(new Aprender());
        }


            private void Jogos()
        {

            Application.Run(new Escolha());

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            ap = new Thread(Crianca_Aprender);
            ap.SetApartmentState(ApartmentState.STA);
            ap.Start();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Deseja realmente sair ?", "Caixa de pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Information);


            if (msg == DialogResult.Yes)
            {

                Application.Exit();

            }
            else if (msg == DialogResult.No)
            {


            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            cr = new Thread(Creditos_Software);
            cr.SetApartmentState(ApartmentState.STA);
            cr.Start();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(Jogos);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();

        }

        private void Menu_Load(object sender, EventArgs e)
        {
           

        }

        private void resizeChildrenControls()
        {
          


        }
        private void resizeControl(Rectangle OriginalControlRect, Control control)
        {
            



        }


        private void Menu_Resize(object sender, EventArgs e)
        {
         
        }
    }
}
