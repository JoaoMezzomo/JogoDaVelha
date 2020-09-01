using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha
{
    public static class Jogo
    {
        public struct Jogador1 
        {
            public static string Nome;
            public static char Simbolo;
            public static bool SuaVez;
            public static bool Venceu;
        }

        public struct Jogador2
        {
            public static string Nome;
            public static char Simbolo;
            public static bool SuaVez;
            public static bool Venceu;
            public static bool ComputadorFezPrimeiraJogada;
        }

        public struct Areas 
        {
            public static char A1;
            public static char A2;
            public static char A3;
            public static char B1;
            public static char B2;
            public static char B3;
            public static char C1;
            public static char C2;
            public static char C3;
            public static string Final;
        }

        public static string JogarComputador() 
        {
            return Computador.Jogar();
        }

        public static void NovoJogo(string nome1, string nome2, char simbolo1, char simbolo2) 
        {
            Jogador1.Nome = nome1;
            Jogador1.Simbolo = simbolo1;
            Jogador1.Venceu = false;

            Jogador2.Nome = nome2;
            Jogador2.Simbolo = simbolo2;
            Jogador2.Venceu = false;
            Jogador2.ComputadorFezPrimeiraJogada = false;

            Areas.A1 = ' ';
            Areas.A2 = ' ';
            Areas.A3 = ' ';
            Areas.B1 = ' ';
            Areas.B2 = ' ';
            Areas.B3 = ' ';
            Areas.C1 = ' ';
            Areas.C2 = ' ';
            Areas.C3 = ' ';
            Areas.Final = "";
        }

        public static bool VerificarSeDeuVelha() 
        {
            bool retorno = false;

            if (Areas.A1 != ' ' && 
            Areas.A2 != ' ' && 
            Areas.A3 != ' ' && 
            Areas.B1 != ' ' && 
            Areas.B2 != ' ' && 
            Areas.B3 != ' ' && 
            Areas.C1 != ' ' && 
            Areas.C2 != ' ' && 
            Areas.C3 != ' ')
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool VerificarFimDoJogo() 
        {
            bool retorno = false;

            if (Areas.A1 != ' ' && Areas.A2 != ' ' && Areas.A3 != ' ' && Areas.A1 == Areas.A2 && Areas.A1 == Areas.A3)
            {
                Areas.Final = "A1_A2_A3";
                retorno = true;
            }
            else if (Areas.B1 != ' ' && Areas.B2 != ' ' && Areas.B3 != ' ' && Areas.B1 == Areas.B2 && Areas.B1 == Areas.B3)
            {
                Areas.Final = "B1_B2_B3";
                retorno = true;
            }
            else if (Areas.C1 != ' ' && Areas.C2 != ' ' && Areas.C3 != ' ' && Areas.C1 == Areas.C2 && Areas.C1 == Areas.C3)
            {
                Areas.Final = "C1_C2_C3";
                retorno = true;
            }
            else if (Areas.A1 != ' ' && Areas.B1 != ' ' && Areas.C1 != ' ' && Areas.A1 == Areas.B1 && Areas.A1 == Areas.C1)
            {
                Areas.Final = "A1_B1_C1";
                retorno = true;
            }
            else if (Areas.A2 != ' ' && Areas.B2 != ' ' && Areas.C2 != ' ' && Areas.A2 == Areas.B2 && Areas.A2 == Areas.C2)
            {
                Areas.Final = "A2_B2_C2";
                retorno = true;
            }
            else if (Areas.A3 != ' ' && Areas.B3 != ' ' && Areas.C3 != ' ' && Areas.A3 == Areas.B3 && Areas.A3 == Areas.C3)
            {
                Areas.Final = "A3_B3_C3";
                retorno = true;
            }
            else if (Areas.A1 != ' ' && Areas.B2 != ' ' && Areas.C3 != ' ' && Areas.A1 == Areas.B2 && Areas.A1 == Areas.C3)
            {
                Areas.Final = "A1_B2_C3";
                retorno = true;
            }
            else if (Areas.A3 != ' ' && Areas.B2 != ' ' && Areas.C1 != ' ' && Areas.A3 == Areas.B2 && Areas.A3 == Areas.C1)
            {
                Areas.Final = "A3_B2_C1";
                retorno = true;
            }

            return retorno;
        }

        private static void MudarVez() 
        {
            Jogador1.SuaVez = !Jogador1.SuaVez;
            Jogador2.SuaVez = !Jogador2.SuaVez;
        }

        public static char BuscarSimbolo(bool mudarVez = false) 
        {
            if (Jogador1.SuaVez)
            {
                if (mudarVez)
                {
                    MudarVez();
                }

                return Jogador1.Simbolo;
            }
            else
            {
                if (mudarVez)
                {
                    MudarVez();
                }

                return Jogador2.Simbolo;
            }
        }
    }

    
}
