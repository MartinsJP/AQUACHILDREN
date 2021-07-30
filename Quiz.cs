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
    public partial class Quiz : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int totalQuestions;
        Thread vol;

        public Quiz()
        {
            InitializeComponent();

            askQuestion(questionNumber);
          
            totalQuestions = 6;
        }

        private void ClickAnswerEvent(object sender, EventArgs e)
        {

            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);




            if (buttonTag == correctAnswer)
            {
                MessageBox.Show("PARABÉNS VOCE ACERTOU !!");
                score++;

            }
            else
            {
                MessageBox.Show("OPA, PENSE MELHOR... !!");
            }

            if (questionNumber == totalQuestions)
            {

                MessageBox.Show("QUIZ TERMINADO" + Environment.NewLine + "VOCE ACERTOU " + score + Environment.NewLine);
                DialogResult msg = MessageBox.Show("Deseja jogar novamente ?", "Caixa de pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (msg == DialogResult.Yes)
                {
                    score = 0;
                    questionNumber = 0;
                    askQuestion(questionNumber);

                }else if (msg == DialogResult.No){
                    this.Close();
                    vol = new Thread(Voltar_Escolha);
                    vol.SetApartmentState(ApartmentState.STA);
                    vol.Start();

                }
                  
            }

            questionNumber++;
            askQuestion(questionNumber);

        }

        private void Voltar_Escolha()
        {
            Application.Run(new Escolha());

        }


        private void askQuestion(int qnum)
        {



            switch (qnum)
            {

                case 1:

                    
                    pictureBox2.Image = Properties.Resources.quizprimeiro;
                    lblQuestion.Text = "DEIXAR A TORNEIRA ABERTA ENQUANTO ESCOVA OS DENTES ESTÁ CERTO?";
                    button1.Image = Properties.Resources.SIM;
                    button2.Image = Properties.Resources.NAO;
                    correctAnswer = 2;
                    break;

                case 2:

                    pictureBox2.Image = Properties.Resources.quizsegundo;
                    lblQuestion.Text = "DEIXAR A TORNEIRA PINGANDO ESTÁ CORRETO?";
                    lblQuestion.Focus();
                    button1.Image = Properties.Resources.SIM;
                    button2.Image = Properties.Resources.NAO;
                    correctAnswer = 2;

                    break;

                case 3:

                    pictureBox2.Image = Properties.Resources.quintoquiz;
                    lblQuestion.Text = "É CORRETO COLETAR ÁGUA DA CHUVA PARA UTILIZAR DEPOIS?";
                    lblQuestion.Focus();
                    button1.Image = Properties.Resources.SIM;
                    button2.Image = Properties.Resources.NAO;
                    correctAnswer = 1;

                    break;

                case 4:

                    pictureBox2.Image = Properties.Resources.quizquarto;
                    lblQuestion.Text = "TOMAR BANHOS DEMORADOS AJUDA A ECONOMIZAR ÁGUA?";
                    lblQuestion.Focus();
                    button1.Image = Properties.Resources.SIM;
                    button2.Image = Properties.Resources.NAO;
                    correctAnswer = 2;

                    break;

                case 5:

                    pictureBox2.Image = Properties.Resources.quizterceiro;
                    lblQuestion.Text = "JOGAR PAPEL NA PRIVADA ESTÁ CERTO?";
                    lblQuestion.Focus();
                    button1.Image = Properties.Resources.SIM;
                    button2.Image = Properties.Resources.NAO;
                    correctAnswer = 2;

                    break;


                case 6:

                    pictureBox2.Image = Properties.Resources.quizsexto;
                    lblQuestion.Text = "QUANTA ÁGUA DOCE ACESSÍVEL EXISTE NO MUNDO?";
                    lblQuestion.Focus();
                    button1.Image = Properties.Resources.alternativa1;
                    button2.Image = Properties.Resources.alternativa2;

                    correctAnswer = 1;



                    break;





            }




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
    }
}
