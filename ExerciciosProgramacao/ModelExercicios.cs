using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosProgramacao
{
    class ModelExercicios
    {
        //Declarando variáveis
        private double num1;
        private double num2;

        //Método Construtor
        public ModelExercicios()
        {

            GetSetNum1 = 0;
            GetSetNum2 = 0;


        }//Fim do Método Construtor

        //Metodos get e set

        public double GetSetNum1
        { get { return this.num1; } set { this.num1 = value; } }
        //Fim do Get Set Num1

        public double GetSetNum2
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
            string result = "";
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
            for(int i  = 0; i < 101; i++) 
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

           for (int i = 0; i == n; i++)
           {

               resultado += "\n" + n + " * " + i + " = " + (n * 1);


           }//Fim do for

           return resultado;

        }// Fim do método Tabuada

    }//Fim da classe ModelExercicios
}//Fim do projeto
