namespace Genius
{
    partial class frAjuda
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
            this.btnPasso = new System.Windows.Forms.Button();
            this.pbAjuda = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAjuda)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPasso
            // 
            this.btnPasso.Location = new System.Drawing.Point(333, 501);
            this.btnPasso.Name = "btnPasso";
            this.btnPasso.Size = new System.Drawing.Size(99, 23);
            this.btnPasso.TabIndex = 2;
            this.btnPasso.Text = "Passo 2 >>>>";
            this.btnPasso.UseVisualStyleBackColor = true;
            this.btnPasso.Click += new System.EventHandler(this.btnPasso_Click);
            // 
            // pbAjuda
            // 
            this.pbAjuda.Image = global::Genius.Properties.Resources.passo72;
            this.pbAjuda.Location = new System.Drawing.Point(-1, -2);
            this.pbAjuda.Name = "pbAjuda";
            this.pbAjuda.Size = new System.Drawing.Size(775, 553);
            this.pbAjuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAjuda.TabIndex = 1;
            this.pbAjuda.TabStop = false;
            // 
            // frAjuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 553);
            this.Controls.Add(this.btnPasso);
            this.Controls.Add(this.pbAjuda);
            this.Name = "frAjuda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genius - Ajuda";
            ((System.ComponentModel.ISupportInitialize)(this.pbAjuda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbAjuda;
        private System.Windows.Forms.Button btnPasso;
    }
}