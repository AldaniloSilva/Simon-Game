using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Genius

{
    public partial class Form1 : Form
    {

        public frJogo TelaJogo = new frJogo();
        public frConfiguracao telaConfiguracao = new frConfiguracao();
        public frRecordes telaRecordes = new frRecordes();
        public frSobre telaSobre = new frSobre();
        public frAjuda telaAjuda = new frAjuda();



        public WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();



        private void LigaSom(bool SomLigado)
        {
            if (SomLigado)
            {
                player.URL = "Abertura.mp3";
                player.controls.play();
                player.settings.setMode("loop", true);
            }

            else
            {
                player.URL = "Abertura.mp3";
                player.controls.stop();
                player.settings.setMode("loop", false);
                return;
            }
        }


        public Form1()
        {
            InitializeComponent();
            pbComoJogar.Image = global::Genius.Properties.Resources.ajuda_off;
            pbRecordes.Image = global::Genius.Properties.Resources.recordes_off;
            pbJogar.Image = global::Genius.Properties.Resources.jogar_off;
            pbSobre.Image = global::Genius.Properties.Resources.sobre_off;
            pbConfig.Image = global::Genius.Properties.Resources.config_off;
            LigaSom(true);//Liga o som de abertura
            telaConfiguracao.rbtFacil.Checked = true;
            TrocaDados.Nivel = 8;
            TrocaDados.Tempo = 6;
            telaConfiguracao.rbtSomLigado.Checked = true;
            telaConfiguracao.rbtMusicaLigada.Checked = true;
        }

        private void TestaPreferencia()
        {
            //Som de menu
            if (telaConfiguracao.rbtMusicaLigada.Checked == false)
                LigaSom(false);
            else
                LigaSom(true);

            //Dificuldade
            if (telaConfiguracao.rbtFacil.Checked == true)
            {
                TrocaDados.Nivel = 8;
                TrocaDados.Tempo = 6;
            }
            else if (telaConfiguracao.rbtMedio.Checked == true)
            {
                TrocaDados.Nivel = 14;
                TrocaDados.Tempo = 5;
            }
            else if (telaConfiguracao.rbtDificil.Checked == true)
            {
                TrocaDados.Nivel = 20;
                TrocaDados.Tempo = 4;
            }
            else if (telaConfiguracao.rbtSuperDificil.Checked == true)
            {
                TrocaDados.Nivel = 31;
                TrocaDados.Tempo = 3;
            }

            //Efeitos Sonoros
            if (telaConfiguracao.rbtSomDesligado.Checked)
            {
                TrocaDados.EfeitoLigado = false;
            }
            else
                TrocaDados.EfeitoLigado = true;
        }

        private void pbComoJogar_MouseEnter(object sender, EventArgs e)
        {
            pbComoJogar.Image = global::Genius.Properties.Resources.ajuda_on1;
        }

        private void pbComoJogar_MouseLeave(object sender, EventArgs e)
        {
            pbComoJogar.Image = global::Genius.Properties.Resources.ajuda_off;
        }

        private void pbRecordes_MouseEnter(object sender, EventArgs e)
        {
            pbRecordes.Image = global::Genius.Properties.Resources.recordes_on;
        }

        private void pbRecordes_MouseLeave(object sender, EventArgs e)
        {
            pbRecordes.Image = global::Genius.Properties.Resources.recordes_off;
        }

        private void pbJogar_MouseLeave(object sender, EventArgs e)
        {
            pbJogar.Image = global::Genius.Properties.Resources.jogar_off;
        }

        private void pbJogar_MouseEnter(object sender, EventArgs e)
        {
            pbJogar.Image = global::Genius.Properties.Resources.jogar_on;
        }

        private void pbSobre_MouseEnter(object sender, EventArgs e)
        {
            pbSobre.Image = global::Genius.Properties.Resources.sobre_on;
        }

        private void pbSobre_MouseLeave(object sender, EventArgs e)
        {
            pbSobre.Image = global::Genius.Properties.Resources.sobre_off;
        }

        private void pbConfig_MouseEnter(object sender, EventArgs e)
        {
            pbConfig.Image = global::Genius.Properties.Resources.config_on;
        }

        private void pbConfig_MouseLeave(object sender, EventArgs e)
        {
            pbConfig.Image = global::Genius.Properties.Resources.config_off;
        }

        private void MudaTela(bool click)
        {
            if (click == true)//Se houve um clique foi porque alguma tela foi aberta
            {

                pbLogo.Visible = false;
                pbComoJogar.Visible = false;
                pbRecordes.Visible = false;
                pbJogar.Visible = false;
                pbSobre.Visible = false;
                pbConfig.Visible = false;
            }

            if (click == false)//Se não houve clique foi porque alguma tela foi fechada
            {
                LigaSom(true);
                pbLogo.Visible = true;
                pbComoJogar.Visible = true;
                pbRecordes.Visible = true;
                pbJogar.Visible = true;
                pbSobre.Visible = true;
                pbConfig.Visible = true;
            }
        }

        private void pbJogar_Click(object sender, EventArgs e)
        {
            LigaSom(false);//Desliga som de abertura
            MudaTela(true);

            frJogo TelaJogo2 = new frJogo();
            TelaJogo2.ShowDialog();//Habilita uma segunda chamada da tela principal do jogo
            MudaTela(false);


        }

        private void pbConfig_Click(object sender, EventArgs e)
        {

            MudaTela(true);
            telaConfiguracao.ShowDialog();
            MudaTela(false);
            TestaPreferencia();
        }

        private void pbRecordes_Click(object sender, EventArgs e)
        {
            MudaTela(true);
            telaRecordes.ShowDialog();
            MudaTela(false);
            TestaPreferencia();
        }

        private void pbSobre_Click(object sender, EventArgs e)
        {
            MudaTela(true);
            telaSobre.ShowDialog();
            MudaTela(false);
            TestaPreferencia();
        }

        private void pbComoJogar_Click(object sender, EventArgs e)
        {
            MudaTela(true);
            telaAjuda.ShowDialog();
            MudaTela(false);
            TestaPreferencia();
        }
    }
}
