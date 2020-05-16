namespace Genius
{
    partial class frJogo
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.pbParabens = new System.Windows.Forms.PictureBox();
            this.pbPrancheta = new System.Windows.Forms.PictureBox();
            this.pbRelogio = new System.Windows.Forms.PictureBox();
            this.pbYellow = new System.Windows.Forms.PictureBox();
            this.pbBlue = new System.Windows.Forms.PictureBox();
            this.pbGreen = new System.Windows.Forms.PictureBox();
            this.pbRed = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbParabens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrancheta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRelogio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRed)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1200;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1200;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 1200;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // timer6
            // 
            this.timer6.Interval = 1000;
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(319, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tempo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(570, 168);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 57);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Essa é sua jogada de número:";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Freestyle Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(605, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 37);
            this.label2.TabIndex = 10;
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIniciar.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.White;
            this.btnIniciar.Location = new System.Drawing.Point(560, 355);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(118, 38);
            this.btnIniciar.TabIndex = 4;
            this.btnIniciar.Text = "INICIO";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnInciar_Click);
            // 
            // pbParabens
            // 
            this.pbParabens.Image = global::Genius.Properties.Resources.parabéns;
            this.pbParabens.Location = new System.Drawing.Point(142, 12);
            this.pbParabens.Name = "pbParabens";
            this.pbParabens.Size = new System.Drawing.Size(520, 82);
            this.pbParabens.TabIndex = 11;
            this.pbParabens.TabStop = false;
            this.pbParabens.Visible = false;
            // 
            // pbPrancheta
            // 
            this.pbPrancheta.Image = global::Genius.Properties.Resources.Smaller_Clipboard_Front__1_;
            this.pbPrancheta.Location = new System.Drawing.Point(540, 129);
            this.pbPrancheta.Name = "pbPrancheta";
            this.pbPrancheta.Size = new System.Drawing.Size(138, 199);
            this.pbPrancheta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPrancheta.TabIndex = 7;
            this.pbPrancheta.TabStop = false;
            // 
            // pbRelogio
            // 
            this.pbRelogio.Image = global::Genius.Properties.Resources.imagesSI2QM19M;
            this.pbRelogio.Location = new System.Drawing.Point(287, 2);
            this.pbRelogio.Name = "pbRelogio";
            this.pbRelogio.Size = new System.Drawing.Size(196, 101);
            this.pbRelogio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRelogio.TabIndex = 5;
            this.pbRelogio.TabStop = false;
            // 
            // pbYellow
            // 
            this.pbYellow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbYellow.Image = global::Genius.Properties.Resources.yellow_off;
            this.pbYellow.Location = new System.Drawing.Point(302, 299);
            this.pbYellow.Name = "pbYellow";
            this.pbYellow.Size = new System.Drawing.Size(193, 176);
            this.pbYellow.TabIndex = 3;
            this.pbYellow.TabStop = false;
            this.pbYellow.WaitOnLoad = true;
            this.pbYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbYellow_MouseDown);
            this.pbYellow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbYellow_MouseUp);
            // 
            // pbBlue
            // 
            this.pbBlue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBlue.Image = global::Genius.Properties.Resources.blue_off;
            this.pbBlue.Location = new System.Drawing.Point(119, 299);
            this.pbBlue.Name = "pbBlue";
            this.pbBlue.Size = new System.Drawing.Size(186, 176);
            this.pbBlue.TabIndex = 2;
            this.pbBlue.TabStop = false;
            this.pbBlue.WaitOnLoad = true;
            this.pbBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbBlue_MouseDown);
            this.pbBlue.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbBlue_MouseUp);
            // 
            // pbGreen
            // 
            this.pbGreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbGreen.Image = global::Genius.Properties.Resources.green_off;
            this.pbGreen.Location = new System.Drawing.Point(302, 190);
            this.pbGreen.Name = "pbGreen";
            this.pbGreen.Size = new System.Drawing.Size(193, 112);
            this.pbGreen.TabIndex = 1;
            this.pbGreen.TabStop = false;
            this.pbGreen.WaitOnLoad = true;
            this.pbGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbGreen_MouseDown);
            this.pbGreen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbGreen_MouseUp);
            // 
            // pbRed
            // 
            this.pbRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRed.Image = global::Genius.Properties.Resources.red_off;
            this.pbRed.Location = new System.Drawing.Point(119, 190);
            this.pbRed.Name = "pbRed";
            this.pbRed.Size = new System.Drawing.Size(186, 112);
            this.pbRed.TabIndex = 0;
            this.pbRed.TabStop = false;
            this.pbRed.WaitOnLoad = true;
            this.pbRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbRed_MouseDown);
            this.pbRed.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbRed_MouseUp);
            // 
            // frJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 553);
            this.Controls.Add(this.pbParabens);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pbPrancheta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbRelogio);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.pbYellow);
            this.Controls.Add(this.pbBlue);
            this.Controls.Add(this.pbGreen);
            this.Controls.Add(this.pbRed);
            this.Name = "frJogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genius";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frJogo_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbParabens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrancheta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRelogio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRed;
        private System.Windows.Forms.PictureBox pbGreen;
        private System.Windows.Forms.PictureBox pbBlue;
        private System.Windows.Forms.PictureBox pbYellow;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.PictureBox pbRelogio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbPrancheta;
        private System.Windows.Forms.Label label2;
        protected System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pbParabens;
    }
}