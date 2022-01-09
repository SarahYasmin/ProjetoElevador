using System;

namespace ProjetoElevador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //true ou false;
            bool continuar = true;

            do
            {
                //Executa a função de seleção do andar
                Console.WriteLine(@" Precione um botão:
                                   
                                    0 - Terréo
                                    1 - Primeiro Pavimento
                                    2 - Segundo Pavimento
                                    3 - Terceiro Pavimento
                                    4 - Quarto Pavimento
                                    5 - Quinto Pavimento
                                    6 - Sexto Pavimento
                                    7 - Setimo pavimento
                          ");


                string opcaoEscolhida = Console.ReadLine();
                Console.Clear();
                continuar = true;


                switch (opcaoEscolhida)
                {
                    //Resposta do sistema para as opções de 0 a 7.
                    case "0":
                        Console.WriteLine("Indo para o terréo"); break;

                    case "1": Console.WriteLine("Indo para o primeiro Pavimento"); break;
                    case "2": Console.WriteLine("Indo para o segundo Pavimento"); break;
                    case "3": Console.WriteLine("Indo para o terceiro Pavimento"); break;
                    case "4": Console.WriteLine("Indo para o quarto Pavimento"); break;
                    case "5": Console.WriteLine("Indo para o quinto Pavimento"); break;
                    case "6": Console.WriteLine("Indo para o sexto Pavimento"); break;
                    case "7": Console.WriteLine("Indo para o setimo Pavimento"); break;
                    default:
                        //caso a escolha não corresponda informa = Escolha inválida.
                        Console.WriteLine("Escolha inválida.");
                        Environment.Exit(0);
                        break;
                }

                //Executa a função de informar o numero de pessoas.

                Console.WriteLine(@"Quantas pessoas há no elevador?

                                    01 
                                    02 
                                    03 
                                    04 
                                    05 
                          ");

                string QuantidadeDePessoas = Console.ReadLine();
                Console.Clear();

                switch (QuantidadeDePessoas)
                {
                    //Resposta do sistema para as opções de 01 a 05.
                    case "01":
                        Console.WriteLine("Indo para o andar.");
                        continuar = false;
                        Environment.Exit(0);
                        break;
                    case "02":
                        Console.WriteLine("Indo para o andar.");
                        Environment.Exit(0);
                        break;
                    case "03":
                        Console.WriteLine("Indo para o andar.");
                        Environment.Exit(0);
                        break;
                    case "04":
                        Console.WriteLine("Indo para o andar.");
                        Environment.Exit(0);
                        break;
                    case "05":
                        Console.WriteLine("Indo para o andar.");
                        Environment.Exit(0);
                        break;

                    default:
                        //caso a escolha não corresponda informa = Capacidade Maxima de Pessoas Atingida, aguardando a saida.
                        Console.WriteLine("Capacidade Maxima de Pessoas Atingida, aguardando a saida................");
                        Console.WriteLine("...........................................................");
                        Console.WriteLine("...........................................................");
                        Console.WriteLine("...........................................................");
                        continuar =true;
                    break;

                }


            }

            while (continuar);
            while (continuar == true) ;

        }
      
    }
}

























