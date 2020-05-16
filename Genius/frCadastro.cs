using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Genius
{
    public partial class frCadastro : Form
    {
        string dados;
        public frCadastro()
        {
            InitializeComponent();
        }

        private void btnSalvarDados_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txtNomeCadastro.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtNomeCadastro, "Digite um nome válido");
                return;
            }

            else
            {
                
                if (TrocaDados.Nivel == 8)
                    dados = "F";
                if (TrocaDados.Nivel == 14)
                    dados = "M";
                if (TrocaDados.Nivel == 20)
                    dados = "D";
                if (TrocaDados.Nivel == 31)
                    dados = "SD";

                dados = dados + "|" + txtNomeCadastro.Text + "|" + lblPontos.Text;


                File.AppendAllText("RECORDES.txt", Environment.NewLine + dados);
                this.Close();
            }
        }

      
    }
}
