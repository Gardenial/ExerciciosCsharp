using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosProgramacao
{
    class ModelExercicios
    {
        //Declarando variáveis
        private int num1;
        private int num2;


        //Método Construtor
        public ModelExercicios()
        {

            GetSetNum1 = 0;
            GetSetNum2 = 0;


        }//Fim do Método Construtor

        //Metodos get e set

        public int GetSetNum1
        { get { return this.num1; } set { this.num1 = value; } }
        //Fim do Get Set Num1

        public int GetSetNum2
        { get { return this.num2; } set { this.num2 = value; } }
        //Fim do Get Set Num2




        //----------------EXERCÍCIOS-------------------

        /*
         * 1.   Faça um algoritmo que o usuário digite
                um número e obtenha como resultado o
                dobro e o triplo do número digitado.
         */


        public string DobrarTriplicar(double num1)
        {

            double num2 = 0;
            double num3 = 0;
            string result = "";

            num2 = num1;
            num3 = num2;
            num1 *= 2;
            num2 *= 3;



            result = "O número digitado é: " + (num3) +
                    "\nO dobro do número é: " + (num1) +
                    "\nO triplo do número é: " + (num2);

            return result;

        }//Fim do Método DobrarTriplicar

        /*
         * 2.   Faça um algoritmo que a partir de um
                salário informado pelo usuário, obtenha
                como retorno o salário aumentado de 30%
         */

        public string Salario(double salario)
        {
            string result = "";
            double valor = 0;

            valor = salario * 30 / 100;
            result = "O salário é: " + salario +
                    "\nCom o aumento de 30% o salário final é: " + (salario + valor);

            return result;


        }//Fim do Método Salário

        /*
         * 3.   Determinar se um número é par ou
                ímpar e positivo ou negativo. 
         */

        public string ImparPar(double num)
        {
            num = num % 2;
            if (num % 2 == 0)
            {

                return "O valor digitado é Par";

            }//Fim do if

            return "O valor é Impar";


        }//Fim do Método ImparParPosNeg

        public string PosNeg(double num)
        {

            string PosNeg = ImparPar(num);
            Boolean validacao = false;

            if (num > 0)
            {
                validacao = true;
                return "O valor é positivo";

            }// Fim do IF

            return "O valor é negativo";
        }//Fim do Método PosNeg

        /*
         * 4.   Faça um algoritmo que calcule a soma
                dos números inteiros de 1 a 100
         */

        public string SomaUmACem()
        {

            int num1 = 0;
            for (int i = 0; i < 101; i++)
            {

                num1 += i;

            }//Fim do For

            return "A soma de todos os números de um a cem é: " + num1;

        }//Fim do Método SomaUmACem

        /*
         * 5.   Construa um programa que exiba a
                tabuada de 1 até N
         */

        public string Tabuada(int n)
        {

            string resultado = "";

            for (int i = 0; i <= n; i++)
            {

                resultado += "\n" + n + " * " + i + " = " + (n * i);


            }//Fim do for

            return resultado;

        }// Fim do método Tabuada


        /*
         * 6.    Faça um algoritmo que escreva na tela
                 os números de um número inicial a um
                 número final. Os números inicial e final
                 devem ser informados pelo usuário;
        */

        public string NumUmANumDois()
        {

            string resultado = "";
            for (int i = GetSetNum1; i <= GetSetNum2; i++)
            {

                resultado += "-" + i;

            }

            return resultado;

        }//Fim do Método NumUmANumDois

        /*
         * 7.   Escrever um algoritmo que gera e
                escreve os números ímpares entre 100 e
                200;
         */

        public string ImparCemDuzentos()
        {
            string resultado = "";

            for (int i = 100; i <= 200; i++)
            {

                if (i % 2 == 1)
                {

                    resultado += "\n" + i;

                }//Fim do If

            }//Fim do For

            return resultado;
        }//Fim do Método ImparCemDuzentos


        /*
         * 8.   Escrever um algoritmo que leia 10
                números inteiros e, ao final, apresente a
                soma de todos os números lidos;

         */

        public string SomaInteiros()
        {
            int n = 0;
            int conta = 0;

            for (int i = 1; i <= 10; i++)
            {

                Console.WriteLine("Digite o " + i + "° Número");
                n = Convert.ToInt32(Console.ReadLine());
                conta += n;

            }//Fim do For

            return "A soma dos 10 números digitados é de: " + conta;

        }//Fim do Método SomaInteiros

        /* 
         * 9.   Faça o mesmo que antes, porém, ao
                invés de ler 10 números, o programa
                deverá ler e somar números até que o
                valor digitado seja zero ( 0 ).
         */

        public string SomaInteiros2()
        {
            int n = 0;
            int conta = 0;
            int i = 1;
            do
            {
                Console.WriteLine("Digite o " + i + 1 + "° Número");
                n = Convert.ToInt32(Console.ReadLine());
                conta += n;

            } while (n != 0); //Fim do While

            return "A soma de todos os números digitados é de: " + conta;

        }//Fim do Método SomaInteiros2

        /*
         * 10.  Escreva um algoritmo que calcule a
                média dos números digitados pelo
                usuário, se eles forem pares. Termine a
                leitura se o usuário digitar zero (0);
         */

        public string Media()
        {
            double media = 0;
            int i = 0;
            int j = 0;
            string msg = "";
            double num = 0;
            do
            {
                j += 1;
                Console.WriteLine("Digite o " + j + "° Número: ");
                num = Convert.ToDouble(Console.ReadLine());
                if (num % 2 == 0)
                {

                    media += num;
                    i += 1;

                }//Fim do If

            } while (num != 0); //Fim do DO...While

            media /= (i - 1);
            msg = "A média dos números digitados é: " + media;
            return msg;

        }//Fim do Método Media


        /*
         * 11. Escreva um algoritmo que leia valores
              inteiros e encontre o maior e o menor
              deles.Termine a leitura se o usuário
              digitar zero(0);
        */

        public string MaiorMenor()
        {
            int maiorValor = 0;
            int menorValor = 0;
            int n = 0;
            Boolean flag = false;

            do
            {
                Console.WriteLine("Digite um número: ");
                n = Convert.ToInt32(Console.ReadLine());
                if (flag == false)
                {

                    maiorValor = n;
                    menorValor = n;
                    flag = true;

                }//Fim do If

                if (n != 0)
                {

                    if (n > maiorValor)
                    {

                        menorValor = n;

                    }//Fim do If 
                    else if (n < maiorValor)
                    {

                        menorValor = n;
                    }//Fim do Else IF
                }//Fim do If
            } while (n != 0); //Fim do While
            return "O maior valor digitado é: " + maiorValor + "\n O menor valor digitado é: " + menorValor;

        }//Fim do Método MaiorMenor

        /*
         * 12.   Escreva um algoritmo que leia 20
                 valores inteiros e ao final exiba:
                 A) a soma dos números positivos;
                 B) a quantidade de valores negativos;
         */

        public string VinteInteiros()
        {
            int n = 0;
            int conta = 0;
            int negativo = 0;


            for (int i = 0; i <= 20; i++)
            {

                Console.WriteLine("Digite o " + (i + 1) + "° Número");
                n = Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                {

                    conta += n;


                }
                else
                {

                    negativo += 1;

                }

            }//Fim do For

            return "A soma dos 20 números digitados é de: " + conta + "\n E a quantidade de valores negativos é de :" + negativo;

        }//Fim do Método SomaInteiros

        /*
        * 13.   Escreva um programa que lido um
                número, calcule e informe o seu fatorial.
        */

        public string Fatorial(int n)
        {

            int fatorial = 1;

            for (int i = 2; i <= n; i++)
            {

                fatorial *= i;

            }//fim do For

            return "O Resultado do Número Fatorial " + n + " é: " + fatorial;

        }//Fim do Método Fatorial



        /*
         * 14.  Escreva um programa que leia um valor
                correspondente ao número de jogadores de
                um time de vôlei. O programa deverá ler
                uma altura para cada um dos jogadores e, ao
                final, informar a altura média do time.
         */


        public string TimeVolei(int n)
        {

            double altura = 0;
            for(int i = 0; i < n; i++)
            {
                
                

                Console.WriteLine("Digite a altura da " + (i + 1) + " Jogadora");
                altura += Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(altura);



            }//Fim do For

            return "A média dos números digitados é: " + altura/n;

        }//Fim do Método TimeVolei

        /*
         * 15.  Em um concurso de miss, os jurados
                precisam digitar o nome das 16
                candidatas e suas respectivas notas (0 a
                10). Crie um programa que leia estas
                informações e que, ao final do programa,
                apresente apenas o nome e a nota da
                vencedora.
         */

        public string Miss()
        {
            int nota = 0;
            int maiorNota = 0;
            int menorNota = 0;
            string nome = "";
            string nomeMaior = "";
            Boolean flag = false;
            
            for(int i = 0; i <= 3; i++) 
            {
                do
                {
                    Console.WriteLine("Digite o Nome da " + (i + 1) + "° Miss");
                    nome = Console.ReadLine();
                    Console.WriteLine("Digite a Nota da " + nome);
                    nota = Convert.ToInt16(Console.ReadLine());
                    if(nota < 0 || nota > 10)
                    {
                        Console.WriteLine("Informe um valor entre 0 e 10");
                    }
                } while (nota < 0 || nota > 10);

                if (flag == false)
                {

                    maiorNota = nota;
                    menorNota = nota;
                    flag = true;

                }//Fim do If

               
                


                if (nota != 0)
                {

                    if (nota > maiorNota)
                    {

                        menorNota = nota;
                        nomeMaior = nome;

                    }//Fim do If 
                    else if (nota < maiorNota)
                    {

                        menorNota = nota;
                    }//Fim do Else IF
                }//Fim do If


            }//Fim do For

            return "A Vencedora do Concurso de miss é: " + nome + "\nCom: " + maiorNota + " Pontos";

        }//Fim do Método Miss


        /*
         * 16.  Escreva um algoritmo para ler o
                número total de eleitores de um
                município, o número de votos brancos,
                nulos e válidos. Calcular e escrever o
                percentual que cada um representa em
                relação ao total de eleitores.
         */

        public string Eleitores()
        {
            double prcBrancos = 0;
            double prcNulos = 0;
            double prcValidos = 0;
            string msg = "";


            Console.WriteLine("Digite o Número total de eleitores:");
            double totalEleitores = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o Número de votos Brancos:");
            double  votosBrancos = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o Número de votos Nulos:");
            double votosNulos = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o Número de votos Válidos:");
            double votosValidos = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(votosBrancos);
            Console.WriteLine(votosNulos);
            Console.WriteLine(votosValidos);

            prcBrancos = (votosBrancos / totalEleitores) * 100;
            prcNulos = (votosNulos / totalEleitores) * 100;
            prcValidos = (votosValidos / totalEleitores) * 100;
            
            msg = "O total de eleitores é de: " + totalEleitores +
                  "%\nO Percentual de votos Brancos é de: " + prcBrancos +
                  "%\nO Percentual de votos Nulos é de: " + prcNulos +
                  "%\nO Percentual de votos Validos é de:" + prcValidos;

            return msg; 
        }//Fim do Método Eleitores


        /*
         * 17.   O custo de um carro novo ao consumidor é
                 a soma do custo de fábrica com a porcentagem
                 do distribuidor e dos impostos (aplicados ao
                 custo de fábrica). Supondo que o percentual do
                 distribuidor seja de 28% e os impostos de
                 45%, escrever um algoritmo para ler o custo de
                 fábrica de um carro, calcular e escrever o custo
                 final ao consumidor.
         */


        public string CarroNovo()
        {

            double prcDistribuidor = 0.26;
            double impostos = 0.49;

            Console.WriteLine("Informe o custo de fábrica do carro:");
            double custoFabrica = Convert.ToDouble(Console.ReadLine());


            double custoDistribuidor = custoFabrica * prcDistribuidor;
            double custoImpostos = custoFabrica * impostos;
            double custoFinal = custoFabrica + custoDistribuidor + custoImpostos;

            return "O valor do Custo final para o Consumidor é de: " + custoFinal;

        }//Fim do Método CarroNovo






    }//Fim da classe ModelExercicios
}//Fim do projeto
