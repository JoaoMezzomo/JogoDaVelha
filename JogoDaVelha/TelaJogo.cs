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

namespace JogoDaVelha
{
    public partial class TelaJogo : Form
    {
        TelaInicial TelaInicialAtual;

        private struct Opcoes 
        {
            public static int NumeroDeJogadores;
            public static string Nome1;
            public static string Nome2;
            public static char Simbolo1;
            public static char Simbolo2;
            public static bool Jogador1Comeca = false;
            public static int Placar1;
            public static int Placar2;
        }

        public TelaJogo()
        {
            InitializeComponent();
        }

        public TelaJogo(TelaInicial telaInicial, int numeroDeJogadores, string nome1, string nome2, char simbolo1, char simbolo2)
        {
            InitializeComponent();
            Opcoes.NumeroDeJogadores = numeroDeJogadores;
            Opcoes.Nome1 = nome1;
            Opcoes.Nome2 = nome2;
            Opcoes.Simbolo1 = simbolo1;
            Opcoes.Simbolo2 = simbolo2;
            Opcoes.Placar1 = 0;
            Opcoes.Placar2 = 0;

            NovoJogo(Opcoes.Nome1, Opcoes.Nome2, Opcoes.Simbolo1, Opcoes.Simbolo2);
            TelaInicialAtual = telaInicial;
        }

        private void MostrarPlacar() 
        {
            lblJogadores.Text = Opcoes.Nome1 + " = "+ Opcoes.Placar1 + "\n\tVS\n" + Opcoes.Nome2 + " = " + Opcoes.Placar2;
        }

        private void NovoJogo(string nome1, string nome2, char simbolo1, char simbolo2) 
        {
            Jogo.NovoJogo(nome1, nome2, simbolo1, simbolo2);
            LimparBotoes();
            lblVencedor.Visible = false;
            MostrarPlacar();

            Opcoes.Jogador1Comeca = !Opcoes.Jogador1Comeca;
            if (Opcoes.Jogador1Comeca)
            {
                Jogo.Jogador1.SuaVez = true;
                Jogo.Jogador2.SuaVez = false;
            }
            else
            {
                Jogo.Jogador1.SuaVez = false;
                Jogo.Jogador2.SuaVez = true;
                JogarComputador();
            }


            MostrarVez();
        }

        private void MostrarVez() 
        {
            lblVezDe.Visible = true;

            if (Jogo.Jogador1.SuaVez)
            {
                lblVezDe.Text = "Vez de: " + Jogo.Jogador1.Nome;
            }
            else
            {
                lblVezDe.Text = "Vez de: " + Jogo.Jogador2.Nome;
            }
        }

        private void LimparBotoes() 
        {
            btnA1.Text = "";
            btnA2.Text = "";
            btnA3.Text = "";
            btnB1.Text = "";
            btnB2.Text = "";
            btnB3.Text = "";
            btnC1.Text = "";
            btnC2.Text = "";
            btnC3.Text = "";

            btnA1.Enabled = true;
            btnA2.Enabled = true;
            btnA3.Enabled = true;
            btnB1.Enabled = true;
            btnB2.Enabled = true;
            btnB3.Enabled = true;
            btnC1.Enabled = true;
            btnC2.Enabled = true;
            btnC3.Enabled = true;

            btnA1.BackColor = System.Drawing.Color.Transparent;
            btnA2.BackColor = System.Drawing.Color.Transparent;
            btnA3.BackColor = System.Drawing.Color.Transparent;
            btnB1.BackColor = System.Drawing.Color.Transparent;
            btnB2.BackColor = System.Drawing.Color.Transparent;
            btnB3.BackColor = System.Drawing.Color.Transparent;
            btnC1.BackColor = System.Drawing.Color.Transparent;
            btnC2.BackColor = System.Drawing.Color.Transparent;
            btnC3.BackColor = System.Drawing.Color.Transparent;
        }

        private void BloquearBotoes() 
        {
            btnA1.Enabled = false;
            btnA2.Enabled = false;
            btnA3.Enabled = false;
            btnB1.Enabled = false;
            btnB2.Enabled = false;
            btnB3.Enabled = false;
            btnC1.Enabled = false;
            btnC2.Enabled = false;
            btnC3.Enabled = false;
        }

        private void MarcarBotoes() 
        {
            string[] areasFinal = Jogo.Areas.Final.Split('_');

            foreach (string area in areasFinal)
            {
                if (area == "A1")
                {
                    btnA1.BackColor = System.Drawing.Color.ForestGreen;
                }
                else if (area == "A2")
                {
                    btnA2.BackColor = System.Drawing.Color.ForestGreen;
                }
                else if (area == "A3")
                {
                    btnA3.BackColor = System.Drawing.Color.ForestGreen;
                }
                else if (area == "B1")
                {
                    btnB1.BackColor = System.Drawing.Color.ForestGreen;
                }
                else if (area == "B2")
                {
                    btnB2.BackColor = System.Drawing.Color.ForestGreen;
                }
                else if (area == "B3")
                {
                    btnB3.BackColor = System.Drawing.Color.ForestGreen;
                }
                else if (area == "C1")
                {
                    btnC1.BackColor = System.Drawing.Color.ForestGreen;
                }
                else if (area == "C2")
                {
                    btnC2.BackColor = System.Drawing.Color.ForestGreen;
                }
                else if (area == "C3")
                {
                    btnC3.BackColor = System.Drawing.Color.ForestGreen;
                }
            }
        }

        private void VerificarFimDoJogoEVencedor() 
        {
            if (Jogo.VerificarFimDoJogo())
            {
                if (!Jogo.Jogador1.SuaVez)
                {
                    lblVencedor.Text = Jogo.Jogador1.Nome + " é o vencedor :)";
                    Opcoes.Placar1++;
                }
                else
                {
                    lblVencedor.Text = Jogo.Jogador2.Nome + " é o vencedor :)";
                    Opcoes.Placar2++;
                }

                lblVencedor.ForeColor = System.Drawing.Color.ForestGreen;
                lblVencedor.Visible = true;
                lblVezDe.Visible = false;
                MarcarBotoes();
                BloquearBotoes();
            }
            else if (Jogo.VerificarSeDeuVelha())
            {
                lblVencedor.Text = "Ninguém Ganhou :(";
                lblVencedor.ForeColor = System.Drawing.Color.Brown;
                lblVencedor.Visible = true;
                lblVezDe.Visible = false;
            }
            else
            {
                MostrarVez();
                JogarComputador();
            }
        }

        private void JogarComputador() 
        {
            if (Opcoes.NumeroDeJogadores == 1 && Jogo.Jogador2.SuaVez)
            {
                Thread.Sleep(1000);
                string area = Jogo.JogarComputador();

                if (area == "A1")
                {
                    btnA1.PerformClick();
                }
                else if (area == "A2")
                {
                    btnA2.PerformClick();
                }
                else if (area == "A3")
                {
                    btnA3.PerformClick();
                }
                else if (area == "B1")
                {
                    btnB1.PerformClick();
                }
                else if (area == "B2")
                {
                    btnB2.PerformClick();
                }
                else if (area == "B3")
                {
                    btnB3.PerformClick();
                }
                else if (area == "C1")
                {
                    btnC1.PerformClick();
                }
                else if (area == "C2")
                {
                    btnC2.PerformClick();
                }
                else if (area == "C3")
                {
                    btnC3.PerformClick();
                }
            }
        }

        private void btnA1_Click(object sender, EventArgs e)
        {
            btnA1.Text = Jogo.BuscarSimbolo().ToString();
            btnA1.Enabled = false;
            Jogo.Areas.A1 = Jogo.BuscarSimbolo(true);
            VerificarFimDoJogoEVencedor();
        }

        private void btnA2_Click(object sender, EventArgs e)
        {
            btnA2.Text = Jogo.BuscarSimbolo().ToString();
            btnA2.Enabled = false;
            Jogo.Areas.A2 = Jogo.BuscarSimbolo(true);
            VerificarFimDoJogoEVencedor();
        }

        private void btnA3_Click(object sender, EventArgs e)
        {
            btnA3.Text = Jogo.BuscarSimbolo().ToString();
            btnA3.Enabled = false;
            Jogo.Areas.A3 = Jogo.BuscarSimbolo(true);
            VerificarFimDoJogoEVencedor();
        }

        private void btnB1_Click(object sender, EventArgs e)
        {
            btnB1.Text = Jogo.BuscarSimbolo().ToString();
            btnB1.Enabled = false;
            Jogo.Areas.B1 = Jogo.BuscarSimbolo(true);
            VerificarFimDoJogoEVencedor();
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            btnB2.Text = Jogo.BuscarSimbolo().ToString();
            btnB2.Enabled = false;
            Jogo.Areas.B2 = Jogo.BuscarSimbolo(true);
            VerificarFimDoJogoEVencedor();
        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            btnB3.Text = Jogo.BuscarSimbolo().ToString();
            btnB3.Enabled = false;
            Jogo.Areas.B3 = Jogo.BuscarSimbolo(true);
            VerificarFimDoJogoEVencedor();
        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            btnC1.Text = Jogo.BuscarSimbolo().ToString();
            btnC1.Enabled = false;
            Jogo.Areas.C1 = Jogo.BuscarSimbolo(true);
            VerificarFimDoJogoEVencedor();
        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            btnC2.Text = Jogo.BuscarSimbolo().ToString();
            btnC2.Enabled = false;
            Jogo.Areas.C2 = Jogo.BuscarSimbolo(true);
            VerificarFimDoJogoEVencedor();
        }

        private void btnC3_Click(object sender, EventArgs e)
        {
            btnC3.Text = Jogo.BuscarSimbolo().ToString();
            btnC3.Enabled = false;
            Jogo.Areas.C3 = Jogo.BuscarSimbolo(true);
            VerificarFimDoJogoEVencedor();
        }

        private void btnNovoJogo_Click(object sender, EventArgs e)
        {
            NovoJogo(Opcoes.Nome1, Opcoes.Nome2, Opcoes.Simbolo1, Opcoes.Simbolo2);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaInicialAtual.Show();
            this.Close();
        }

        private void TelaJogo_FormClosing(object sender, FormClosingEventArgs e)
        {
            TelaInicialAtual.Show();
        }
    }
}
