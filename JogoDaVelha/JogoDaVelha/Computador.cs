using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha
{
    public class Computador
    {
        static bool A1;
        static bool A2;
        static bool A3;
        static bool B1;
        static bool B2;
        static bool B3;
        static bool C1;
        static bool C2;
        static bool C3;

        public static string Jogar() 
        {
            bool jogou = false;
            string retorno = "";
            char meuSimbolo = Jogo.Jogador2.Simbolo;
            char humanoSimbolo = Jogo.Jogador1.Simbolo;
            CarregarAreas();

            //Faz sua primeira jogada
            if (!Jogo.Jogador2.ComputadorFezPrimeiraJogada)
            {
                bool fezPrimeiraJogada = false;
                string[] areas = { "A1", "A2", "A3", "B1", "B2", "B3", "C1", "C2", "C3" };

                Random rdn = new Random();
                string primeiraArea = "";

                while (!fezPrimeiraJogada)
                {
                    int index = rdn.Next(0, 9);

                    try
                    {
                        primeiraArea = areas[index];

                        if (primeiraArea == "A1" && !A1)
                        {
                            retorno = "A1";
                            fezPrimeiraJogada = true;
                            jogou = true;
                        }
                        else if (primeiraArea == "A2" && !A2)
                        {
                            retorno = "A2";
                            fezPrimeiraJogada = true;
                            jogou = true;
                        }
                        else if (primeiraArea == "A3" && !A3)
                        {
                            retorno = "A3";
                            fezPrimeiraJogada = true;
                            jogou = true;
                        }
                        if (primeiraArea == "B1" && !B1)
                        {
                            retorno = "B1";
                            fezPrimeiraJogada = true;
                            jogou = true;
                        }
                        else if (primeiraArea == "B2" && !B2)
                        {
                            retorno = "B2";
                            fezPrimeiraJogada = true;
                            jogou = true;
                        }
                        else if (primeiraArea == "B3" && !B3)
                        {
                            retorno = "B3";
                            fezPrimeiraJogada = true;
                            jogou = true;
                        }
                        if (primeiraArea == "C1" && !C1)
                        {
                            retorno = "C1";
                            fezPrimeiraJogada = true;
                            jogou = true;
                        }
                        else if (primeiraArea == "C2" && !C2)
                        {
                            retorno = "C2";
                            fezPrimeiraJogada = true;
                            jogou = true;
                        }
                        else if (primeiraArea == "C3" && !C3)
                        {
                            retorno = "C3";
                            fezPrimeiraJogada = true;
                            jogou = true;
                        }

                    }
                    catch (Exception)
                    {

                    }
                }

                Jogo.Jogador2.ComputadorFezPrimeiraJogada = true;
            }

            //Verifica se tem apenas uma area para jogar
            if (!jogou)
            {
                if (!A1 && A2 && A3 && B1 && B2 && B3 && C1 && C2 && C3)
                {
                    retorno = "A1";
                    jogou = true;
                }
                else if (A1 && !A2 && A3 && B1 && B2 && B3 && C1 && C2 && C3)
                {
                    retorno = "A2";
                    jogou = true;
                }
                else if (A1 && A2 && !A3 && B1 && B2 && B3 && C1 && C2 && C3)
                {
                    retorno = "A3";
                    jogou = true;
                }
                else if (A1 && A2 && A3 && !B1 && B2 && B3 && C1 && C2 && C3)
                {
                    retorno = "B1";
                    jogou = true;
                }
                else if (A1 && A2 && A3 && B1 && !B2 && B3 && C1 && C2 && C3)
                {
                    retorno = "B2";
                    jogou = true;
                }
                else if (A1 && A2 && A3 && B1 && B2 && !B3 && C1 && C2 && C3)
                {
                    retorno = "B3";
                    jogou = true;
                }
                else if (A1 && A2 && A3 && B1 && B2 && B3 && !C1 && C2 && C3)
                {
                    retorno = "C1";
                    jogou = true;
                }
                else if (A1 && A2 && A3 && B1 && B2 && B3 && C1 && !C2 && C3)
                {
                    retorno = "C2";
                    jogou = true;
                }
                else if (A1 && A2 && A3 && B1 && B2 && B3 && C1 && C2 && !C3)
                {
                    retorno = "C3";
                    jogou = true;
                }
            }

            //Ganha o jogo, caso seja possível
            if (!jogou)
            {
                if (Jogo.Areas.A2 == meuSimbolo && Jogo.Areas.A3 == meuSimbolo && !A1)
                {
                    retorno = "A1";
                    jogou = true;
                }
                else if (Jogo.Areas.A1 == meuSimbolo && Jogo.Areas.A3 == meuSimbolo && !A2)
                {
                    retorno = "A2";
                    jogou = true;
                }
                else if (Jogo.Areas.A1 == meuSimbolo && Jogo.Areas.A2 == meuSimbolo && !A3)
                {
                    retorno = "A3";
                    jogou = true;
                }
                else if (Jogo.Areas.B2 == meuSimbolo && Jogo.Areas.B3 == meuSimbolo && !B1)
                {
                    retorno = "B1";
                    jogou = true;
                }
                else if (Jogo.Areas.B1 == meuSimbolo && Jogo.Areas.B3 == meuSimbolo && !B2)
                {
                    retorno = "B2";
                    jogou = true;
                }
                else if (Jogo.Areas.B1 == meuSimbolo && Jogo.Areas.B2 == meuSimbolo && !B3)
                {
                    retorno = "B3";
                    jogou = true;
                }
                else if (Jogo.Areas.C2 == meuSimbolo && Jogo.Areas.C3 == meuSimbolo && !C1)
                {
                    retorno = "C1";
                    jogou = true;
                }
                else if (Jogo.Areas.C1 == meuSimbolo && Jogo.Areas.C3 == meuSimbolo && !C2)
                {
                    retorno = "C2";
                    jogou = true;
                }
                else if (Jogo.Areas.C1 == meuSimbolo && Jogo.Areas.C2 == meuSimbolo && !C3)
                {
                    retorno = "C3";
                    jogou = true;
                }
                else if (Jogo.Areas.B1 == meuSimbolo && Jogo.Areas.C1 == meuSimbolo && !A1)
                {
                    retorno = "A1";
                    jogou = true;
                }
                else if (Jogo.Areas.B2 == meuSimbolo && Jogo.Areas.C2 == meuSimbolo && !A2)
                {
                    retorno = "A2";
                    jogou = true;
                }
                else if (Jogo.Areas.B3 == meuSimbolo && Jogo.Areas.C3 == meuSimbolo && !A3)
                {
                    retorno = "A3";
                    jogou = true;
                }
                else if (Jogo.Areas.A1 == meuSimbolo && Jogo.Areas.C1 == meuSimbolo && !B1)
                {
                    retorno = "B1";
                    jogou = true;
                }
                else if (Jogo.Areas.A2 == meuSimbolo && Jogo.Areas.C2 == meuSimbolo && !B2)
                {
                    retorno = "B2";
                    jogou = true;
                }
                else if (Jogo.Areas.A3 == meuSimbolo && Jogo.Areas.C3 == meuSimbolo && !B3)
                {
                    retorno = "B3";
                    jogou = true;
                }
                else if (Jogo.Areas.A1 == meuSimbolo && Jogo.Areas.B1 == meuSimbolo && !C1)
                {
                    retorno = "C1";
                    jogou = true;
                }
                else if (Jogo.Areas.A2 == meuSimbolo && Jogo.Areas.B2 == meuSimbolo && !C2)
                {
                    retorno = "C2";
                    jogou = true;
                }
                else if (Jogo.Areas.A3 == meuSimbolo && Jogo.Areas.B3 == meuSimbolo && !C3)
                {
                    retorno = "C3";
                    jogou = true;
                }
                else if (Jogo.Areas.B2 == meuSimbolo && Jogo.Areas.C3 == meuSimbolo && !A1)
                {
                    retorno = "A1";
                    jogou = true;
                }
                else if (Jogo.Areas.A1 == meuSimbolo && Jogo.Areas.C3 == meuSimbolo && !B2)
                {
                    retorno = "B2";
                    jogou = true;
                }
                else if (Jogo.Areas.A1 == meuSimbolo && Jogo.Areas.B2 == meuSimbolo && !C3)
                {
                    retorno = "C3";
                    jogou = true;
                }
                else if (Jogo.Areas.C1 == meuSimbolo && Jogo.Areas.B2 == meuSimbolo && !A3)
                {
                    retorno = "A3";
                    jogou = true;
                }
                else if (Jogo.Areas.A3 == meuSimbolo && Jogo.Areas.C1 == meuSimbolo && !B2)
                {
                    retorno = "B2";
                    jogou = true;
                }
                else if (Jogo.Areas.A3 == meuSimbolo && Jogo.Areas.B2 == meuSimbolo && !C1)
                {
                    retorno = "C1";
                    jogou = true;
                }
            }

            //Se defende, caso necessário
            if (!jogou)
            {
                if (Jogo.Areas.A2 == humanoSimbolo && Jogo.Areas.A3 == humanoSimbolo && !A1)
                {
                    retorno = "A1";
                    jogou = true;
                }
                else if (Jogo.Areas.A1 == humanoSimbolo && Jogo.Areas.A3 == humanoSimbolo && !A2)
                {
                    retorno = "A2";
                    jogou = true;
                }
                else if (Jogo.Areas.A1 == humanoSimbolo && Jogo.Areas.A2 == humanoSimbolo && !A3)
                {
                    retorno = "A3";
                    jogou = true;
                }
                else if (Jogo.Areas.B2 == humanoSimbolo && Jogo.Areas.B3 == humanoSimbolo && !B1)
                {
                    retorno = "B1";
                    jogou = true;
                }
                else if (Jogo.Areas.B1 == humanoSimbolo && Jogo.Areas.B3 == humanoSimbolo && !B2)
                {
                    retorno = "B2";
                    jogou = true;
                }
                else if (Jogo.Areas.B1 == humanoSimbolo && Jogo.Areas.B2 == humanoSimbolo && !B3)
                {
                    retorno = "B3";
                    jogou = true;
                }
                else if (Jogo.Areas.C2 == humanoSimbolo && Jogo.Areas.C3 == humanoSimbolo && !C1)
                {
                    retorno = "C1";
                    jogou = true;
                }
                else if (Jogo.Areas.C1 == humanoSimbolo && Jogo.Areas.C3 == humanoSimbolo && !C2)
                {
                    retorno = "C2";
                    jogou = true;
                }
                else if (Jogo.Areas.C1 == humanoSimbolo && Jogo.Areas.C2 == humanoSimbolo && !C3)
                {
                    retorno = "C3";
                    jogou = true;
                }
                else if (Jogo.Areas.B1 == humanoSimbolo && Jogo.Areas.C1 == humanoSimbolo && !A1)
                {
                    retorno = "A1";
                    jogou = true;
                }
                else if (Jogo.Areas.B2 == humanoSimbolo && Jogo.Areas.C2 == humanoSimbolo && !A2)
                {
                    retorno = "A2";
                    jogou = true;
                }
                else if (Jogo.Areas.B3 == humanoSimbolo && Jogo.Areas.C3 == humanoSimbolo && !A3)
                {
                    retorno = "A3";
                    jogou = true;
                }
                else if (Jogo.Areas.A1 == humanoSimbolo && Jogo.Areas.C1 == humanoSimbolo && !B1)
                {
                    retorno = "B1";
                    jogou = true;
                }
                else if (Jogo.Areas.A2 == humanoSimbolo && Jogo.Areas.C2 == humanoSimbolo && !B2)
                {
                    retorno = "B2";
                    jogou = true;
                }
                else if (Jogo.Areas.A3 == humanoSimbolo && Jogo.Areas.C3 == humanoSimbolo && !B3)
                {
                    retorno = "B3";
                    jogou = true;
                }
                else if (Jogo.Areas.A1 == humanoSimbolo && Jogo.Areas.B1 == humanoSimbolo && !C1)
                {
                    retorno = "C1";
                    jogou = true;
                }
                else if (Jogo.Areas.A2 == humanoSimbolo && Jogo.Areas.B2 == humanoSimbolo && !C2)
                {
                    retorno = "C2";
                    jogou = true;
                }
                else if (Jogo.Areas.A3 == humanoSimbolo && Jogo.Areas.B3 == humanoSimbolo && !C3)
                {
                    retorno = "C3";
                    jogou = true;
                }
                else if (Jogo.Areas.B2 == humanoSimbolo && Jogo.Areas.C3 == humanoSimbolo && !A1)
                {
                    retorno = "A1";
                    jogou = true;
                }
                else if (Jogo.Areas.A1 == humanoSimbolo && Jogo.Areas.C3 == humanoSimbolo && !B2)
                {
                    retorno = "B2";
                    jogou = true;
                }
                else if (Jogo.Areas.A1 == humanoSimbolo && Jogo.Areas.B2 == humanoSimbolo && !C3)
                {
                    retorno = "C3";
                    jogou = true;
                }
                else if (Jogo.Areas.C1 == humanoSimbolo && Jogo.Areas.B2 == humanoSimbolo && !A3)
                {
                    retorno = "A3";
                    jogou = true;
                }
                else if (Jogo.Areas.A3 == humanoSimbolo && Jogo.Areas.C1 == humanoSimbolo && !B2)
                {
                    retorno = "B2";
                    jogou = true;
                }
                else if (Jogo.Areas.A3 == humanoSimbolo && Jogo.Areas.B2 == humanoSimbolo && !C1)
                {
                    retorno = "C1";
                    jogou = true;
                }
            }

            //Usa esse modo caso não tenha encontrado uma opção de jogo, jogando assim a primeira area que encontrar livre
            if (!jogou)
            {
                if (!A1)
                {
                    retorno = "A1";
                    jogou = true;
                }
                else if (!A2)
                {
                    retorno = "A2";
                    jogou = true;
                }
                else if (!A3)
                {
                    retorno = "A3";
                    jogou = true;
                }
                else if (!B1)
                {
                    retorno = "B1";
                    jogou = true;
                }
                else if (!B2)
                {
                    retorno = "B2";
                    jogou = true;
                }
                else if (!B3)
                {
                    retorno = "B3";
                    jogou = true;
                }
                else if (!C1)
                {
                    retorno = "C1";
                    jogou = true;
                }
                else if (!C2)
                {
                    retorno = "C2";
                    jogou = true;
                }
                else if (!C3)
                {
                    retorno = "C3";
                    jogou = true;
                }
            }
            return retorno;
        }

        private static void CarregarAreas() 
        {
            A1 = false;
            A2 = false;
            A3 = false;
            B1 = false;
            B2 = false;
            B3 = false;
            C1 = false;
            C2 = false;
            C3 = false;

            if (Jogo.Areas.A1 != ' ')
            {
                A1 = true;
            }

            if (Jogo.Areas.A2 != ' ')
            {
                A2 = true;
            }

            if (Jogo.Areas.A3 != ' ')
            {
                A3 = true;
            }

            if (Jogo.Areas.B1 != ' ')
            {
                B1 = true;
            }

            if (Jogo.Areas.B2 != ' ')
            {
                B2 = true;
            }

            if (Jogo.Areas.B3 != ' ')
            {
                B3 = true;
            }

            if (Jogo.Areas.C1 != ' ')
            {
                C1 = true;
            }

            if (Jogo.Areas.C2 != ' ')
            {
                C2 = true;
            }

            if (Jogo.Areas.C3 != ' ')
            {
                C3 = true;
            }

        }
    }
}
