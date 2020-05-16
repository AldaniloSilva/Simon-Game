using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Genius
{
    public partial class frAjuda : Form
    {
        int c = 1;
        public frAjuda()
        {
            InitializeComponent();
            pbAjuda.Image = global::Genius.Properties.Resources.passo1;
            btnPasso.Text = "Passo 2 >>>";
        }

        //private void btnPasso(object sender, EventArgs e)
        //{
        //    c++;
        //    if (c == 1)
        //    {
        //        pbAjuda.Image = global::Genius.Properties.Resources.passo2;
        //    }
        //}

       

        private void btnPasso_Click(object sender, EventArgs e)
        {
            c++;
            if(c==1)
            {
                pbAjuda.Image = global::Genius.Properties.Resources.passo1;
                btnPasso.Text = "Passo 2 >>>";
            }
        
            else if (c == 2)
            {
                pbAjuda.Image = global::Genius.Properties.Resources.passo2;
                btnPasso.Text = "Passo 3 >>>";
            }

            else if (c == 3)
            {
                pbAjuda.Image = global::Genius.Properties.Resources.passo3;
                btnPasso.Text = "Passo 4 >>>";
            }

            else if (c == 4)
            {
                pbAjuda.Image = global::Genius.Properties.Resources.passo4;
                btnPasso.Text = "Passo 5 >>>";
            }

            else if (c == 5)
            {
                pbAjuda.Image = global::Genius.Properties.Resources.passo5;
                btnPasso.Text = "Passo 6 >>>";
            }

            else if (c == 6)
            {
                pbAjuda.Image = global::Genius.Properties.Resources.passo6;
                btnPasso.Text = "Passo 7 >>>";
            }

            else if (c == 7)
            {
                pbAjuda.Image = global::Genius.Properties.Resources.passo7;
                btnPasso.Text = "Passo 8 >>>";
            }

            else if (c == 8)
            {
                pbAjuda.Image = global::Genius.Properties.Resources.passo8;
                btnPasso.Text = "Passo 1 >>>";
                c = 1;
                return;
            }
        }
    }
}
