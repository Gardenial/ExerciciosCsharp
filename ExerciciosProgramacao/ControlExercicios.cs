using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosProgramacao
{

    
    class ControlExercicios
    {
        //Criando um Objeto na memória
        ModelExercicios exercicios;
        
        //Método construtor
        public ControlExercicios() 
        {
            
            this.exercicios = new ModelExercicios();

        }//Fim do construtor

        public void Coletar()
        {
            Console.WriteLine("Informe um Número: ");
            this.exercicios.GetSetNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe outro Número: ");
            this.exercicios.GetSetNum2 = Convert.ToInt32(Console.ReadLine());


        }//Fim do método Coletar


        public int Menu()
        {

            Console.WriteLine("-------------------MENU-------------------" +
                "\n 1.Dobrar e Triplicar"               +
                "\n 2.Salário 30%"                      + 
                "\n 3.Impar Par | Negativo Positivo."   + 
                "\n 4. Soma de um a Cem"                +
                "\n 5. Tabuada de um número"            +
                "\n 6. Num Um até Num Dois"             +
                "\n 7. Impares de Cem a Duzentos"       +
                "\n 8. Somar Inteiros"                  +
                "\n 9. Soma de N números"               +
                "\n 10. Média"                          +
                "\n 11. Maior e Menor"                  +
                "\n 12. Vinte Valores"                  +
                "\n 0.Sair" );


            int opcao = Convert.ToInt32(Console.ReadLine());
            return opcao;
        }//Fim do Método Menu

        //Método de operações

        public void Operacao()
        {

            int opcao = 0;
            do
            {

                opcao = Menu();
                Console.Clear();

                switch (opcao) 
                {
                
                    case 0:
                        Console.WriteLine("Obrigado!");
                       break;
                    case 1:
                        Console.WriteLine("Digite um Número");
                        double num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.exercicios.DobrarTriplicar(num1));
                        break;
                    case 2:
                        Console.WriteLine("Digite um Número");
                        double salario = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.exercicios.Salario(salario));
                        break;
                    case 3:
                        Console.WriteLine("Digite um Número");
                        double num = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.exercicios.ImparPar(num));
                        Console.WriteLine(this.exercicios.PosNeg(num));
                        break;
                    case 4:
                        Console.WriteLine(this.exercicios.SomaUmACem());
                        break; 
                    case 5:
                        Console.WriteLine("Digite um Número");
                        int n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.exercicios.Tabuada(n));
                        break;
                    case 6:
                        Coletar();
                        Console.WriteLine(this.exercicios.NumUmANumDois());
                        break;
                    case 7:
                        Console.WriteLine(this.exercicios.ImparCemDuzentos());
                        break;
                    case 8:
                        Console.WriteLine(this.exercicios.SomaInteiros());
                        break;
                    case 9:
                        Console.WriteLine(this.exercicios.SomaInteiros2());
                        break;
                    case 10:
                        Console.WriteLine(this.exercicios.Media());
                        break;
                    case 11:
                        Console.WriteLine(this.exercicios.MaiorMenor());
                        break;
                    case 12:
                        Console.WriteLine(this.exercicios.VinteInteiros());
                        break;

                }//Fim do Switch...Case

            } while (opcao != 0); //Fim do Do...While

        }//Fim do Método Operacao

    }//Fim da classe ControlExercicios
}//Fim do Projeto
