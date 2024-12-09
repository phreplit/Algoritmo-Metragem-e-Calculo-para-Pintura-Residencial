
//  Author: PHNO - Tecnólogo | Pós-Graduado
//  Data Release: 29/11/2024
//  Versão Código: 0.0.0.2v
//  Replit: @PHNO, @PHREPLIT
//  E-mail: phreplit@gmail.com

// Algoritmo: Metragem e Calculo para Pintura Residencial, algoritmo desenvolvido em c sharp, desenvolvido para profissionais da area.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace Algoritmo_Metragem_e_Calculo_para_Pintura_Residencial
    {
        class Program
        { // classe

            public static void Main(string[] args)
            {

                while (true)
                {
                    // class, method, string
                    Console.WriteLine("\n");
                    Console.WriteLine(" Metragem e Calculo para Pintura Residencial ");
                    Console.WriteLine("");
                    Console.WriteLine("\n\t     Menu    \n");
                    Console.WriteLine("");
                    Console.WriteLine("1. Calcular Metro Quadrado de uma Parede");
                    Console.WriteLine("2. Calcular Quantidade de Latas por M²");
                    Console.WriteLine("3. Calcular Quantidade de Demaos por Lata(s)");
                    Console.WriteLine("4. Calcular Quantidade de Demaos por M²");
                    Console.WriteLine("5. Sair");
                    Console.WriteLine("");
                    Console.WriteLine("[8] Info");
                    Console.WriteLine("[9] Sobre");

                    Console.WriteLine("\nDigite sua escolha: "); // choice

                    try
                    {
                        int choice = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n");

                        switch (choice)
                        {
                            case 1:
                            Console.WriteLine("Digite a altura da parede: ");
                            int v1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\n");
                            Console.WriteLine("Digite a largura da parede: ");
                            int v2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            int resultado = v1 * v2;
                            Console.WriteLine("A parede tem " + (resultado) + " metros quadrados.");
                            Console.WriteLine();
                            Console.WriteLine("Teclar enter para retornar ao menu...");
                            Console.ReadKey();
                            Clear();
                            break;
                            case 2:
                            int qtdtinta = 3600; // 1 lata tem 3600ml(3,6)
                            int v4 = 360; // quantidade tinta por 1 metro quadrado
                            Console.WriteLine("Digite quantos metros quadrados tem a parede: ");
                            int v3 = Convert.ToInt32(Console.ReadLine()); // metros quadrados 
                            Console.WriteLine("\n");
                            int resultado2 = (v3 * v4); // quantidade de tinta por (n) tantos m²
                            int resultado3 = (resultado2 / qtdtinta); // quantidade de latas
                            Console.WriteLine();
                            Console.WriteLine("A quantidade de tinta para pintar " + (v3) + " M² eh de " + (resultado2) + " mililitro(s) e a quantidade de lata(s) eh de " + (resultado3) + " lata(s).");
                            Console.WriteLine();
                            Console.WriteLine("Teclar enter para retornar ao menu...");
                            Console.ReadKey();
                            Clear();
                            break;
                        case 3:
                            int lata1 = 3600; // 1 lata de tinta
                            int mq1 = 360; // 1 metro quadrado
                            int v6 = 3; // 3600ml(3,6) dividido por 3 sera 1200ml equivale a 3 demaos
                            Console.WriteLine("Digite a quantidade de latas de tinta obtidas por M²: ");
                            int v5 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\n");
                            int resultado4 = (v5 * v6); // demao
                            int calcqtdlitro = (v5 * lata1); // quantidade tinta
                            int calcmq = (calcqtdlitro / mq1); // metro quadrado
                            Console.WriteLine();
                            Console.WriteLine("A quantidade de demaos por " + (v5) + " lata(s) de tinta sera de " + (resultado4) + " demao(s).");
                            Console.WriteLine();
                            Console.WriteLine("Teclar enter para retornar ao menu...");
                            Console.ReadKey();
                            Clear();
                            break;
                            case 4:
                            int lata01 = 3600; // 1 lata de tinta
                            int mq01 = 360; // 1 metro quadrado
                            int v8 = 3; // 3600ml(3,6) dividido por 3 sera 1200ml equivale a 3 demaos
                            Console.WriteLine("Digite a quantidade de latas de tinta obtidas por M²: ");
                            int v7 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\n");
                            int resultado5 = (v7 * v8); // demao
                            int calcqtdlitro01 = (v7 * lata01); // quantidade tinta
                            int calcmq01 = (calcqtdlitro01 / mq01); // metro quadrado
                            Console.WriteLine();
                            Console.WriteLine("A quantidade de demaos para pintar " + (calcmq01) + " metros quadrados sera de " + (resultado5) + " demao(s).");
                            Console.WriteLine();
                            Console.WriteLine("Teclar enter para retornar ao menu...");
                            Console.ReadKey();
                            Clear();
                            break;
                            case 5:
                            Exit();
                            break;
                            case 8:
                                Clear();
                                Console.WriteLine();
                                Console.WriteLine("Info");
                                Console.WriteLine();
                                Console.WriteLine("Para Calcular Pintura com Tinta sem diluicao:");
                                Console.WriteLine("Com base em uma lata de tinta de 3,6L e com base em uma parede com (A 2,70 metros x L 3,70 metros) temos que A x L = a 10M², ");
                                Console.WriteLine("e entao temos que 1 lata com 3600ml de tinta dividido por 10 tera 360ml para cada 1M², esse sera o padrao do calculo 360ml = 1M², ");
                                Console.WriteLine("então tem se que Quaisquer(N) metros quadrados x 360ml = a (N) litros de tinta e esse resultado dividido por 3600ml sera igual a (N) quantidade de latas de tinta.");
                                Console.WriteLine("Para calcular uma demao: ");
                                Console.WriteLine("Para pintar uma demao temos que uma bandeja de tinta tem 1000ml como referencia por demao, ");
                                Console.WriteLine("e uma lata de tinta tem 3600ml entao temos que uma lata tem 1200ml por demao ja que 1200ml vs 3 = a 3600ml(3,6L). Uma demao equivale a uma pintura completa de uma parede. Geralmente eh necessario de duas a tres demaos para pintar uma parede.");
                                Console.WriteLine();
                                Console.WriteLine("Informacao Importante: ");
                                Console.WriteLine();
                                Console.WriteLine("Este algoritmo foi desenvolvido com variaveis inteiras entao nao aceita numeros com virgula ex: 2,90 metros mude para 3 metros.");
                                Console.WriteLine();
                                Console.WriteLine("Teclar enter para retornar ao menu...");
                                Console.ReadKey();
                                Clear();
                                break;
                            case 9:
                                Clear();
                                Console.WriteLine();
                                Console.WriteLine("Algoritmo: Metragem e Calculo para Pintura Residencial");
                                Console.WriteLine();
                                Console.WriteLine("Author: PHNO");
                                Console.WriteLine("Data Release: 29/11/2024");
                                Console.WriteLine("Versao Codigo: 0.0.0.2v");
                                Console.WriteLine("Replit: @PHNO, @PHREPLIT");
                                Console.WriteLine("E-mail: phreplit@gmail.com");
                                Console.WriteLine();
                                Console.WriteLine("Teclar enter para retornar ao menu...");
                                Console.ReadKey();
                                Clear();
                                break;
                            default:
                                Console.WriteLine("Erro, Opcao Invalida! ");
                                Console.WriteLine();
                                Console.WriteLine("Teclar enter para retornar ao menu...");
                                Console.ReadKey();
                                Clear();
                                break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erro, falha no sistema.");
                        Console.WriteLine();
                        Console.WriteLine("Teclar enter para retornar ao menu...");
                        Console.ReadKey();
                        Clear();
                    }
                }
            }
            public static void Exit()
            { // exit method
                Console.WriteLine();
                Console.WriteLine(" Algoritmo Finalizado! ");
                System.Environment.Exit(-1);
                return;
            }
            public static void Clear()
            { // method 
                Console.Clear();
                return;
            }
        }
    }
