using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Media;

namespace Genius
{

    public partial class frJogo : Form
    {
        frCadastro TelaCadastro = new frCadastro();
        Stopwatch cronometro = new Stopwatch();
        public frJogo()
        {
            InitializeComponent();
            this.TransparencyKey = this.BackColor = Color.Turquoise;
            DesabilitaClick(true);
            textBox1.SelectionStart = 0;
            if (TrocaDados.EfeitoLigado == false)
                MessageBox.Show("Para melhorar a experiência," + Environment.NewLine + "ative o som no menu de configuração!", "Ligue o som",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public double tempo = 0;
        public int numero;
        public int[] computador = new int[TrocaDados.Nivel];
        public int[] jogador = new int[TrocaDados.Nivel];
        public int c = 0;
        public int quantidade = 0;//conta quantas vezes foi preenchido o vetor computador
        public bool certo;
        public string nome;
        public int j;
        public int n;

        private void LigaEfeitoSonoro(bool Ligado, string SomDaCor)
        {
            WMPLib.WindowsMediaPlayer playerCores = new WMPLib.WindowsMediaPlayer();
            if (Ligado)
            {
                playerCores.URL = SomDaCor;
                playerCores.controls.play();
                playerCores.settings.setMode("loop", false);
            }
            else
            {
                playerCores.URL = SomDaCor;
                playerCores.controls.stop();
                playerCores.settings.setMode("loop", false);
            }
        }


        private void Sound_Red()
        {
            if (TrocaDados.EfeitoLigado)
            {
                pbRed.Image = global::Genius.Properties.Resources.red_on;
                LigaEfeitoSonoro(true, "som_vermelho.mp3");
            }
            else
            {
                pbRed.Image = global::Genius.Properties.Resources.red_on;
                LigaEfeitoSonoro(false, "som_vermelho.mp3");
            }

        }

        private void Sound_Blue()
        {
            if (TrocaDados.EfeitoLigado)
            {
                pbBlue.Image = global::Genius.Properties.Resources.blue_on;
                LigaEfeitoSonoro(true, "som_azul.mp3");
            }
            else
            {
                pbBlue.Image = global::Genius.Properties.Resources.blue_on;
                LigaEfeitoSonoro(false, "som_azul.mp3");
            }

        }

        private void Sound_Yellow()
        {
            if (TrocaDados.EfeitoLigado)
            {
                pbYellow.Image = global::Genius.Properties.Resources.yellow_on;
                LigaEfeitoSonoro(true, "som_amarelo.mp3");
            }
            else
            {
                pbYellow.Image = global::Genius.Properties.Resources.yellow_on;
                LigaEfeitoSonoro(false, "som_amarelo.mp3");
            }
        }

        private void Sound_Green()
        {
            pbGreen.Image = global::Genius.Properties.Resources.green_on;
            if (TrocaDados.EfeitoLigado)
            {
                pbGreen.Image = global::Genius.Properties.Resources.green_on;
                LigaEfeitoSonoro(true, "som_verde.mp3");
            }
            else
            {
                pbGreen.Image = global::Genius.Properties.Resources.green_on;
                LigaEfeitoSonoro(false, "som_verde.mp3");
            }
        }

        private void Sound_Error(int correto)
        {


            if (correto == 1)
            {
                pbRed.Image = global::Genius.Properties.Resources.red_on;
                // timer1.Enabled = true;
                ApagaCores(c - 1);
                nome = "vermelho";
            }
            else if (correto == 2)
            {
                pbGreen.Image = global::Genius.Properties.Resources.green_on;
                //timer2.Enabled = true;
                ApagaCores(c - 1);
                nome = "verde";
            }
            else if (correto == 3)
            {
                pbBlue.Image = global::Genius.Properties.Resources.blue_on;
                //timer3.Enabled = true;
                ApagaCores(c - 1);
                nome = "azul";
            }
            else if (correto == 4)
            {
                pbYellow.Image = global::Genius.Properties.Resources.yellow_on;
                // timer4.Enabled = true;
                ApagaCores(c - 1);
                nome = "amarelo";
            }
            c = 0;
            DesabilitaClick(true);

            if (TrocaDados.EfeitoLigado)
                if (TrocaDados.EfeitoLigado)
                {
                    LigaEfeitoSonoro(true, "som_erro.mp3");
                }
                else
                {
                    LigaEfeitoSonoro(false, "som_erro.mp3");
                }

            timer5.Enabled = false;

            label1.Text = "Tempo";


            if (MessageBox.Show("Que pena você errou!!!" + Environment.NewLine +
                $"A cor correta era o {nome}!" + Environment.NewLine + "Deseja Salvar a pontuação?",
                "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes == true)
            {
                TelaCadastro.lblPontos.Text = (CalculaPontos(tempo));
                TelaCadastro.ShowDialog();
            }
            ApagaCores(c - 1);
            ZeraVariaveis();
        }




        private void ApagaCores(int cor)
        {
            switch (cor)
            {
                case 1:
                    timer1.Enabled = true;
                    break;

                case 2:
                    timer2.Enabled = true;
                    break;

                case 3:
                    timer3.Enabled = true;
                    break;

                case 4:
                    timer4.Enabled = true;
                    break;
                default:
                    {
                        timer1.Enabled = true;
                        timer2.Enabled = true;
                        timer3.Enabled = true;
                        timer4.Enabled = true;
                        break;
                    }
            }
        }
        #region//REGIÃO PARA USUARIO ESCOLHER A COR PELO CLIQUE
        private void pbRed_MouseUp(object sender, MouseEventArgs e)
        {
            pbRed.Image = global::Genius.Properties.Resources.red_off;

        }

        private void pbRed_MouseDown(object sender, MouseEventArgs e)
        {
            pbRed.Image = global::Genius.Properties.Resources.red_on;
            EscolhaCor(1);//Escolhida a cor vermelha pelo clique
        }

        private void pbGreen_MouseUp(object sender, MouseEventArgs e)
        {
            pbGreen.Image = global::Genius.Properties.Resources.green_off;
        }

        private void pbGreen_MouseDown(object sender, MouseEventArgs e)
        {
            pbGreen.Image = global::Genius.Properties.Resources.green_on;
            EscolhaCor(2);//Escolhida a cor verde pelo clique

        }

        private void pbBlue_MouseUp(object sender, MouseEventArgs e)
        {
            pbBlue.Image = global::Genius.Properties.Resources.blue_off;
        }

        private string CalculaPontos(double tempo)
        {

            tempo = (tempo / 1000);
            double pontos = (tempo / j) * 10;
            if (j == computador.Length)
                pontos = pontos + j;
            return pontos.ToString("f1");
        }

        private void pbBlue_MouseDown(object sender, MouseEventArgs e)
        {
            pbBlue.Image = global::Genius.Properties.Resources.blue_on;
            EscolhaCor(3);//Escolhida a cor azul pelo clique
        }

        private void pbYellow_MouseUp(object sender, MouseEventArgs e)
        {
            pbYellow.Image = global::Genius.Properties.Resources.yellow_off;
        }

        private void pbYellow_MouseDown(object sender, MouseEventArgs e)
        {
            pbYellow.Image = global::Genius.Properties.Resources.yellow_on;
            EscolhaCor(4);//Escolhida a cor amarela pelo clique
        }
        #endregion
        private void EscolhaCor(int cor)//Aqui processada a cor escolhida pelo jogador
        {
            if (quantidade <= computador.Length - 1)
            {
                jogador[c] = cor;
                ValidaJogada();

                if (certo)//Se a escolha da cor for certa...
                {
                    //Acende uma das cores:
                    if (cor == 1)
                        Sound_Red();//acende e toca o som do vermelho
                    else if (cor == 2)
                        Sound_Green();//acende e toca o som do verde
                    else if (cor == 3)
                        Sound_Blue();//acende e toca o som do azul
                    else if (cor == 4)
                        Sound_Yellow();//acende e toca o som do amarelo


                    if (c == quantidade || c == computador.Length)
                    {

                        c = 0;
                        timer6.Enabled = true;//...Repete a sequecia
                    }

                    else
                        return;//Retorna para poder escolher uma nova cor

                }
                else
                {
                    //Se a opção for errada acenderá o botão da cor certa
                    cronometro.Stop();//para o relógio
                    Sound_Error(computador[c - 1]);
                    return;
                }
                j++;

            }
        }

        private void ZeraVariaveis()
        {
            c = 0;
            j = 0;
            quantidade = 0;
            n = 0;
            int x = 0;//representa a posição do vetor computador e jogador a ser apagada
            foreach (int posicao in computador)
                computador[x++] = 0;

            x = 0;//zera o x novamente para que seja zerado o vetor jogador
            foreach (int posicao in jogador)
                jogador[x++] = 0;
            label2.Text = "";
            tempo = 0;
            certo = false;
            ApresentaParabens(false);
            btnIniciar.Enabled = true;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            pbRed.Image = global::Genius.Properties.Resources.red_off;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            pbGreen.Image = global::Genius.Properties.Resources.green_off;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Enabled = false;
            pbBlue.Image = global::Genius.Properties.Resources.blue_off;
        }


        private void timer4_Tick(object sender, EventArgs e)
        {
            timer4.Enabled = false;
            pbYellow.Image = global::Genius.Properties.Resources.yellow_off;
        }



        private bool ValidaJogada()//Valida a jogada 
        {
            certo = true;


            if (jogador[c] != computador[c])
            {
                certo = false;
                ApagaCores(jogador[c]);

            }

            c++;
            cronometro.Restart();
            return certo;

        }



        private void DesabilitaClick(bool clickoff)
        {
            if (clickoff == true)//Desabilita o clique do usuário
            {
                pbRed.Enabled = false;
                pbBlue.Enabled = false;
                pbGreen.Enabled = false;
                pbYellow.Enabled = false;
                cronometro.Stop();
                tempo = tempo + Convert.ToInt32(cronometro.ElapsedMilliseconds);


            }
            else//Habilita o clique do usuário
            {
                pbRed.Enabled = true;
                pbBlue.Enabled = true;
                pbGreen.Enabled = true;
                pbYellow.Enabled = true;
            }

        }


        private void SorteiaCor()//Sorteia a próxima cor
        {
            DesabilitaClick(true);//Se os botões precisarem ser desabilitados, então...


            Random sorteia = new Random();
            numero = sorteia.Next(1, 5);


            if (numero == 1)//Se for vermelho
            {
                Sound_Red();
                computador[quantidade] = numero;
                timer1.Enabled = true;
            }

            else if (numero == 2)//Se for verde
            {
                Sound_Green();
                computador[quantidade] = numero;
                timer2.Enabled = true;
            }

            else if (numero == 3)//Se for azul
            {
                Sound_Blue();
                computador[quantidade] = numero;
                timer3.Enabled = true;
            }

            else if (numero == 4)//Se for amarelo
            {
                Sound_Yellow();
                computador[quantidade] = numero;
                timer4.Enabled = true;
            }
            DesabilitaClick(false);
            quantidade++;
            label2.Text = quantidade.ToString();
            timer5.Enabled = true;
            cronometro.Restart();


            if (quantidade == computador.Length)
            {
                quantidade = 0;
                DesabilitaClick(false);//Se os botões precisarem ser habilitados, então...
                return;
            }



        }



        private void timer6_Tick(object sender, EventArgs e)//Repete a sequencia após validar
        {
            timer5.Enabled = false;
            label1.Text = "Tempo";
            if (j <= computador.Length - 1)
            {
                DesabilitaClick(true);
                if (computador[n] == 1)
                {
                    Sound_Red();
                    timer1.Enabled = true;
                }

                else if (computador[n] == 2)
                {
                    Sound_Green();
                    timer2.Enabled = true;
                }

                else if (computador[n] == 3)
                {
                    Sound_Blue();
                    timer3.Enabled = true;
                }
                else if (computador[n] == 4)
                {
                    Sound_Yellow();
                    timer4.Enabled = true;
                }
                if (n >= quantidade)
                {

                    timer6.Enabled = false;
                    n = 0;
                    SorteiaCor();//Após repetida a sequencia será sorteada uma nova cor
                }
                else
                    n++;
            }
            else
            {
                timer6.Enabled = false;
                ApresentaParabens(true);
                if (MessageBox.Show("Parabéns! Você tem uma grande mémoria!" + Environment.NewLine +
                    "Deseja salvar sua pontuação?", "Fim de Jogo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes == true)
                {
                    TelaCadastro.lblPontos.Text = (CalculaPontos(tempo));
                    TelaCadastro.ShowDialog();
                }

          
                
                DesabilitaClick(true);
                ZeraVariaveis();

            }
        }
        private void ApresentaParabens(bool confirma)
        {
            WMPLib.WindowsMediaPlayer playerVitoria = new WMPLib.WindowsMediaPlayer();
            if (confirma == true)
            {
                label1.Visible = false;
                pbRelogio.Visible = false;
                pbParabens.Visible = true;

                playerVitoria.URL = "Vitoria.mp3";
                playerVitoria.controls.play();
                playerVitoria.settings.setMode("loop", true);
            }


            else
                label1.Visible = true;
            pbRelogio.Visible = true;
            pbParabens.Visible = false;
            playerVitoria.URL = "Vitoria.mp3";
            playerVitoria.controls.stop();
            playerVitoria.settings.setMode("loop", false);
        }

        private void btnInciar_Click(object sender, EventArgs e)//Tudo começa aqui
        {
            btnIniciar.Enabled = false;
            timer5.Enabled = true;
            cronometro.Restart();
            SorteiaCor();

        }

        private void frJogo_FormClosing(object sender, FormClosingEventArgs e)
        {

            if ((MessageBox.Show("Deseja Realmente Sair?" + Environment.NewLine + "Os dados não salvos serão perdidos.",
                "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No == true))
                e.Cancel = true;
            else
            {
                timer5.Enabled = false;
                cronometro.Stop();
                tempo = tempo + Convert.ToInt32(cronometro.ElapsedMilliseconds);
            }

        }

        private void timer5_Tick(object sender, EventArgs e)//Conta o tempo
        {
            label1.Text = Math.Truncate(cronometro.Elapsed.TotalSeconds).ToString();



            if ((Convert.ToInt16(cronometro.Elapsed.TotalSeconds)) > TrocaDados.Tempo)
            {
                timer5.Enabled = false;
                if (TrocaDados.EfeitoLigado)
                    if (TrocaDados.EfeitoLigado)
                    {
                        LigaEfeitoSonoro(true, "som_erro.mp3");
                    }
                    else
                    {
                        LigaEfeitoSonoro(false, "som_erro.mp3");
                    }

                label1.Text = "Tempo";
                ZeraVariaveis();
                // certo = false;


                if (MessageBox.Show("Que pena o tempo se esgotou!!", "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
                    == DialogResult.Yes == true)
                {
                    TelaCadastro.lblPontos.Text = (CalculaPontos(tempo));
                    TelaCadastro.ShowDialog();
                }
                MessageBox.Show(tempo.ToString());
                MessageBox.Show(CalculaPontos(tempo));
                DesabilitaClick(true);
            }



        }


    }

}

