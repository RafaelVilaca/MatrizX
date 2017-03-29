using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizX
{
    class Program
    {
        static void Main(string[] args)
        {
            string escolha = "";
            string valorMatriz = "";
            int validacao = 0, li, co;

            do
            {
                Console.WriteLine("Insira o tamanho da matriz: ");
                valorMatriz = Console.ReadLine();

                if (string.IsNullOrEmpty(valorMatriz.Trim()))
                {
                    do
                    {
                        Console.WriteLine("\nEscrita em Branco! Siga o passo Abaixo:");
                        Console.WriteLine("Insira o tamanho da matriz: ");
                        valorMatriz = Console.ReadLine();
                    } while (valorMatriz == "");
                }

                bool isNumero = int.TryParse(valorMatriz, out validacao);

                if (isNumero)
                {
                    if (Convert.ToInt32(valorMatriz) < 3)
                    {
                        do
                        {
                            Console.WriteLine("\nValor baixo, minímo de 3 posições.");
                            Console.WriteLine("Insira o tamanho da matriz: ");
                            valorMatriz = Console.ReadLine();
                            isNumero = int.TryParse(valorMatriz, out validacao);
                        } while ((Convert.ToInt16(valorMatriz) < 3) || (valorMatriz == "") || (isNumero == false));
                    }

                    string[,] matriz = new string[Convert.ToInt16(valorMatriz), Convert.ToInt16(valorMatriz)];
                    Console.WriteLine("");
                    int meio = (Convert.ToInt16(valorMatriz) / 2);
                    for (li = 0; li < Convert.ToInt16(valorMatriz); li++)
                    {
                        for (co = 0; co < Convert.ToInt16(valorMatriz); co++)
                        {
                            if (li == co || li + co == (Convert.ToInt16(valorMatriz) - 1))
                            {
                                Console.Write("X" + "  ");
                            }
                            else
                            {
                                if ((li < co && li + co > (Convert.ToInt16(valorMatriz) - 1)) || (li > co && li + co < (Convert.ToInt16(valorMatriz) - 1)))
                                {
                                    Console.Write("0" + "  ");
                                }
                                else
                                {
                                    Console.Write(" " + "  ");
                                }
                            }
                        }
                        Console.WriteLine("");
                    }

                    Console.WriteLine("\nCentro da Matriz {0}° linha e {1}° coluna.", meio + 1, meio + 1);


                    //int[] matrizv = new int[Convert.ToInt32(valorMatriz) - 1];
                    //int[] matrizh = new int[Convert.ToInt32(valorMatriz) - 1];

                    //foreach (var v in matrizv)
                    //{
                    //    foreach (var h in matrizh)
                    //    {
                    //        Console.Write(" X ");
                    //    }
                    //    Console.WriteLine(v);
                    //}

                }
                else
                {
                    Console.WriteLine("O digitado não é um número, faça a verificação novamente");
                }


                Console.WriteLine("\nQuer fazer outra matriz? (S ou N) \n");
                escolha = Console.ReadLine();

                if (escolha.ToLower() != "s" && escolha.ToLower() != "n")
                {
                    do
                    {
                        Console.WriteLine("Opção Inválida!");
                        Console.WriteLine("Por gentileza, escolha S ou N para sua resposta");
                        Console.WriteLine("Quer fazer outra matriz? (S ou N) \n");
                        escolha = Console.ReadLine();
                    } while (escolha.ToLower() != "s" && escolha.ToLower() != "n");
                }
            } while (escolha.ToLower() == "s");

            Console.WriteLine("Obrigado pela Preferência =)");
            Console.ReadKey();
        }
    }
}
