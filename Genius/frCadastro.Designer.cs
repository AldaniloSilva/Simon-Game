namespace Genius
{
    partial class frCadastro
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPontos = new System.Windows.Forms.Label();
            this.txtNomeCadastro = new System.Windows.Forms.TextBox();
            this.btnSalvarDados = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Genius.Properties.Resources.memoria;
            this.pictureBox1.Location = new System.Drawing.Point(28, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(193, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pontos";
            // 
            // lblPontos
            // 
            this.lblPontos.AutoSize = true;
            this.lblPontos.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontos.Location = new System.Drawing.Point(304, 91);
            this.lblPontos.Name = "lblPontos";
            this.lblPontos.Size = new System.Drawing.Size(84, 26);
            this.lblPontos.TabIndex = 3;
            this.lblPontos.Text = "99,99";
            // 
            // txtNomeCadastro
            // 
            this.txtNomeCadastro.Location = new System.Drawing.Point(288, 41);
            this.txtNomeCadastro.Name = "txtNomeCadastro";
            this.txtNomeCadastro.Size = new System.Drawing.Size(100, 20);
            this.txtNomeCadastro.TabIndex = 4;
            // 
            // btnSalvarDados
            // 
            this.btnSalvarDados.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarDados.Location = new System.Drawing.Point(267, 131);
            this.btnSalvarDados.Name = "btnSalvarDados";
            this.btnSalvarDados.Size = new System.Drawing.Size(79, 33);
            this.btnSalvarDados.TabIndex = 5;
            this.btnSalvarDados.Text = "Salvar";
            this.btnSalvarDados.UseVisualStyleBackColor = true;
            this.btnSalvarDados.Click += new System.EventHandler(this.btnSalvarDados_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // frCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 176);
            this.Controls.Add(this.btnSalvarDados);
            this.Controls.Add(this.txtNomeCadastro);
            this.Controls.Add(this.lblPontos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genius - Tela de Cadastro ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeCadastro;
        private System.Windows.Forms.Button btnSalvarDados;
        public System.Windows.Forms.Label lblPontos;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}