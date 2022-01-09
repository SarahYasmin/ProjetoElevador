using System;


namespace ProjetoElevador.Model
{
    public class Elevador
    {

        //Propriedades

        public int AndarAtual { get; set; }
        public int TotalDeAndaresDoEdificio { get; set; }
        public int CapacidadeMaxima { get; set; }
        public int QuantidadeDePessoas { get; set; }


        //MÉTODOS

        public void Iniciar()
        {
            CapacidadeMaxima = 5;
            TotalDeAndaresDoEdificio = 7;
            AndarAtual = 0;
        }

        public void Entrar()

        //Entrar : deve acrescentar uma pessoa no elevador (só deve acrescentar se ainda houver espaço)

        {
            


            if (QuantidadeDePessoas < 5) //Numero de pessoas menor que 5.
            {
                Console.WriteLine("--------SUBINDO--------");
            }

            else if (QuantidadeDePessoas == 5) //Numero de pessoas igual a 5.
            {
                Console.WriteLine("--------SUBINDO--------");
            }

            else //Numero de pessoas diferente de <=5.
            {
                Console.WriteLine("A quantidade de pessoas ultrapassou o limite, aguardando a saida");
            }
        }

            public void Sair()
        //Sair : deve remover uma pessoa do elevador (só deve remover se houver alguém dentro dele)
        {

            if (QuantidadeDePessoas == 1)
             {
                 Console.WriteLine("Por favor, saia do elevador");
             }

        }

        public void Subir()
        //deve subir um andar (não deve subir se já estiver no último andar);
        {
            if (TotalDeAndaresDoEdificio <= 7)
            {
                Console.WriteLine("");
            }
            else if (AndarAtual > 1) //
            {
               Console.WriteLine("--------SUBINDO--------");
            }

            else //Ultrapassou o andar 7.
            {
                Console.WriteLine("Este andar não existe");

            }
        }

        public void Descer()
        //deve descer um andar(não deve descer se já estiver no térreo)
        {
            if ( AndarAtual !=0)
            {
                Console.WriteLine("-------DESCENDO-------");
            }

            else //Caso nenhuma a opção anteriores não seja executada. 
            {
                Console.WriteLine("Opção invalida");

            }
        }
    }
}
