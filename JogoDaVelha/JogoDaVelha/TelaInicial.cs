using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class TelaInicial : Form
    {
        bool DoisJogadores = false;

        public TelaInicial()
        {
            InitializeComponent();
        }

        private void NovoJogo()
        {
            int numeroJogadores = 0;
            string nome1 = "";
            string nome2 = "";
            char simbolo1 = ' ';
            char simbolo2 = ' ';

            if (DoisJogadores)
            {
                numeroJogadores = 2;
            }
            else
            {
                numeroJogadores = 1;
            }

            if (!string.IsNullOrEmpty(txtJogador1Nome.Text))
            {
                nome1 = txtJogador1Nome.Text;
            }
            else
            {
                nome1 = "Jogador 1";
            }

            if (!string.IsNullOrEmpty(txtJogador2Nome.Text))
            {
                nome2 = txtJogador2Nome.Text;
            }
            else
            {
                nome2 = "Jogador 2";
            }

            if (comboSimbolo1.SelectedIndex == 0)
            {
                simbolo1 = 'X';
                simbolo2 = 'O';
            }
            else
            {
                simbolo1 = 'O';
                simbolo2 = 'X';
            }

            TelaJogo telaJogo = new TelaJogo(this, numeroJogadores, nome1, nome2, simbolo1, simbolo2);
            telaJogo.Show();
            this.Hide();
        }

        private void btnDoisJogadores_Click(object sender, EventArgs e)
        {
            groupBoxOpcoes.Enabled = true;
            txtJogador1Nome.Text = "Jogador 1";
            txtJogador2Nome.Text = "Jogador 2";
            txtJogador2Nome.ReadOnly = false;
            comboSimbolo1.SelectedIndex = 0;
            comboSimbolo2.SelectedIndex = 1;
            DoisJogadores = true;
            txtJogador1Nome.Focus();
        }

        private void btnUmJogador_Click(object sender, EventArgs e)
        {
            groupBoxOpcoes.Enabled = true;
            txtJogador1Nome.Text = "Jogador 1";
            txtJogador2Nome.Text = "Computador";
            txtJogador2Nome.ReadOnly = true;
            comboSimbolo1.SelectedIndex = 0;
            comboSimbolo2.SelectedIndex = 1;
            DoisJogadores = false;
            txtJogador1Nome.Focus();
        }

        private void btnNovoJogo_Click(object sender, EventArgs e)
        {
            NovoJogo();
        }

        private void comboSimbolo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSimbolo1.SelectedIndex == 0)
            {
                comboSimbolo2.SelectedIndex = 1;
            }
            else
            {
                comboSimbolo2.SelectedIndex = 0;
            }
        }

        private void comboSimbolo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSimbolo2.SelectedIndex == 0)
            {
                comboSimbolo1.SelectedIndex = 1;
            }
            else
            {
                comboSimbolo1.SelectedIndex = 0;
            }
        }

        private void TelaInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (btnNovoJogo.Enabled)
                {
                    NovoJogo();
                }
            }
        }
    }
}
