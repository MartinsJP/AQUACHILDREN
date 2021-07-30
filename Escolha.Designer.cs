
namespace Jogo_da_Memoria
{
    partial class Escolha
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.memo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.escol = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // memo
            // 
            this.memo.BackColor = System.Drawing.Color.Transparent;
            this.memo.BackgroundImage = global::Jogo_da_Memoria.Properties.Resources.escolha_memoria;
            this.memo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.memo.FlatAppearance.BorderColor = System.Drawing.Color.PowderBlue;
            this.memo.FlatAppearance.BorderSize = 0;
            this.memo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.memo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.memo.ForeColor = System.Drawing.Color.Transparent;
            this.memo.Location = new System.Drawing.Point(624, 303);
            this.memo.Name = "memo";
            this.memo.Size = new System.Drawing.Size(146, 128);
            this.memo.TabIndex = 5;
            this.memo.UseVisualStyleBackColor = false;
            this.memo.Click += new System.EventHandler(this.button2_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Jogo_da_Memoria.Properties.Resources.escolha_quiz;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(877, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 128);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::Jogo_da_Memoria.Properties.Resources.escolha_labirinto;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(360, 303);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 128);
            this.button4.TabIndex = 8;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.Image = global::Jogo_da_Memoria.Properties.Resources.voltar_novo;
            this.pictureBox11.Location = new System.Drawing.Point(43, 559);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(149, 63);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 17;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Click += new System.EventHandler(this.pictureBox11_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::Jogo_da_Memoria.Properties.Resources.nuvem;
            this.pictureBox8.Location = new System.Drawing.Point(-9, -27);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(1956, 142);
            this.pictureBox8.TabIndex = 18;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::Jogo_da_Memoria.Properties.Resources.heroii;
            this.pictureBox6.Location = new System.Drawing.Point(1644, 714);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(198, 238);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 19;
            this.pictureBox6.TabStop = false;
            // 
            // escol
            // 
            this.escol.AutoSize = true;
            this.escol.BackColor = System.Drawing.Color.Transparent;
            this.escol.Font = new System.Drawing.Font("Sitka Heading", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.escol.ForeColor = System.Drawing.Color.White;
            this.escol.Location = new System.Drawing.Point(472, 159);
            this.escol.Name = "escol";
            this.escol.Size = new System.Drawing.Size(405, 69);
            this.escol.TabIndex = 4;
            this.escol.Text = "ESCOLHA O JOGO";
            this.escol.Click += new System.EventHandler(this.escol_Click);
            // 
            // Escolha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jogo_da_Memoria.Properties.Resources.chao_fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.memo);
            this.Controls.Add(this.escol);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Escolha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escolha o JOGO";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button memo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label escol;
    }
}