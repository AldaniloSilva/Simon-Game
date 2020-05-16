namespace Genius
{
    partial class frConfiguracao
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtDificil = new System.Windows.Forms.RadioButton();
            this.rbtSuperDificil = new System.Windows.Forms.RadioButton();
            this.rbtMedio = new System.Windows.Forms.RadioButton();
            this.rbtFacil = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtSomDesligado = new System.Windows.Forms.RadioButton();
            this.rbtSomLigado = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtMusicaDesligada = new System.Windows.Forms.RadioButton();
            this.rbtMusicaLigada = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(152, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dificuldade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(129, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Efeitos Sonoros";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.rbtDificil);
            this.groupBox1.Controls.Add(this.rbtSuperDificil);
            this.groupBox1.Controls.Add(this.rbtMedio);
            this.groupBox1.Controls.Add(this.rbtFacil);
            this.groupBox1.Location = new System.Drawing.Point(370, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 112);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // rbtDificil
            // 
            this.rbtDificil.AutoSize = true;
            this.rbtDificil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtDificil.Location = new System.Drawing.Point(7, 66);
            this.rbtDificil.Name = "rbtDificil";
            this.rbtDificil.Size = new System.Drawing.Size(59, 17);
            this.rbtDificil.TabIndex = 2;
            this.rbtDificil.TabStop = true;
            this.rbtDificil.Text = "Difícil";
            this.rbtDificil.UseVisualStyleBackColor = true;
            // 
            // rbtSuperDificil
            // 
            this.rbtSuperDificil.AutoSize = true;
            this.rbtSuperDificil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtSuperDificil.Location = new System.Drawing.Point(7, 89);
            this.rbtSuperDificil.Name = "rbtSuperDificil";
            this.rbtSuperDificil.Size = new System.Drawing.Size(96, 17);
            this.rbtSuperDificil.TabIndex = 3;
            this.rbtSuperDificil.TabStop = true;
            this.rbtSuperDificil.Text = "Super Díficil";
            this.rbtSuperDificil.UseVisualStyleBackColor = true;
            // 
            // rbtMedio
            // 
            this.rbtMedio.AutoSize = true;
            this.rbtMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtMedio.Location = new System.Drawing.Point(7, 43);
            this.rbtMedio.Name = "rbtMedio";
            this.rbtMedio.Size = new System.Drawing.Size(59, 17);
            this.rbtMedio.TabIndex = 1;
            this.rbtMedio.TabStop = true;
            this.rbtMedio.Text = "Médio";
            this.rbtMedio.UseVisualStyleBackColor = true;
            // 
            // rbtFacil
            // 
            this.rbtFacil.AutoSize = true;
            this.rbtFacil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtFacil.Location = new System.Drawing.Point(7, 20);
            this.rbtFacil.Name = "rbtFacil";
            this.rbtFacil.Size = new System.Drawing.Size(52, 17);
            this.rbtFacil.TabIndex = 0;
            this.rbtFacil.TabStop = true;
            this.rbtFacil.Text = "Fácil";
            this.rbtFacil.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox2.Controls.Add(this.rbtSomDesligado);
            this.groupBox2.Controls.Add(this.rbtSomLigado);
            this.groupBox2.Location = new System.Drawing.Point(370, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 74);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // rbtSomDesligado
            // 
            this.rbtSomDesligado.AutoSize = true;
            this.rbtSomDesligado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtSomDesligado.Location = new System.Drawing.Point(7, 42);
            this.rbtSomDesligado.Name = "rbtSomDesligado";
            this.rbtSomDesligado.Size = new System.Drawing.Size(81, 17);
            this.rbtSomDesligado.TabIndex = 5;
            this.rbtSomDesligado.TabStop = true;
            this.rbtSomDesligado.Text = "Desligado";
            this.rbtSomDesligado.UseVisualStyleBackColor = true;
            // 
            // rbtSomLigado
            // 
            this.rbtSomLigado.AutoSize = true;
            this.rbtSomLigado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtSomLigado.Location = new System.Drawing.Point(6, 19);
            this.rbtSomLigado.Name = "rbtSomLigado";
            this.rbtSomLigado.Size = new System.Drawing.Size(63, 17);
            this.rbtSomLigado.TabIndex = 4;
            this.rbtSomLigado.TabStop = true;
            this.rbtSomLigado.Text = "Ligado";
            this.rbtSomLigado.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SteelBlue;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(230, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Música";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox3.Controls.Add(this.rbtMusicaDesligada);
            this.groupBox3.Controls.Add(this.rbtMusicaLigada);
            this.groupBox3.Location = new System.Drawing.Point(370, 297);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 74);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // rbtMusicaDesligada
            // 
            this.rbtMusicaDesligada.AutoSize = true;
            this.rbtMusicaDesligada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtMusicaDesligada.Location = new System.Drawing.Point(7, 42);
            this.rbtMusicaDesligada.Name = "rbtMusicaDesligada";
            this.rbtMusicaDesligada.Size = new System.Drawing.Size(81, 17);
            this.rbtMusicaDesligada.TabIndex = 5;
            this.rbtMusicaDesligada.TabStop = true;
            this.rbtMusicaDesligada.Text = "Desligada";
            this.rbtMusicaDesligada.UseVisualStyleBackColor = true;
            // 
            // rbtMusicaLigada
            // 
            this.rbtMusicaLigada.AutoSize = true;
            this.rbtMusicaLigada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtMusicaLigada.Location = new System.Drawing.Point(6, 19);
            this.rbtMusicaLigada.Name = "rbtMusicaLigada";
            this.rbtMusicaLigada.Size = new System.Drawing.Size(63, 17);
            this.rbtMusicaLigada.TabIndex = 4;
            this.rbtMusicaLigada.TabStop = true;
            this.rbtMusicaLigada.Text = "Ligada";
            this.rbtMusicaLigada.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Genius.Properties.Resources.laptop_PNG5890;
            this.pictureBox1.Location = new System.Drawing.Point(62, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(629, 486);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frConfiguracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 553);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frConfiguracao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genius - Configurações";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.RadioButton rbtDificil;
        public System.Windows.Forms.RadioButton rbtMedio;
        public System.Windows.Forms.RadioButton rbtFacil;
        public System.Windows.Forms.RadioButton rbtSomLigado;
        public System.Windows.Forms.RadioButton rbtSuperDificil;
        public System.Windows.Forms.RadioButton rbtSomDesligado;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.RadioButton rbtMusicaDesligada;
        public System.Windows.Forms.RadioButton rbtMusicaLigada;
    }
}