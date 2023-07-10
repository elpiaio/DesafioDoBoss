using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;

namespace DesafioDoBoss
{
    public static class Program
    {
        public static void Main()
        {
            string repeticao = "r";
            while (repeticao == "r")
            {
                string stringdesafiosbasicos = "Verifique se um número é positivo ou negativo.\r\nVerifique se um número é par ou ímpar.\r\nVerifique se um ano é bissexto ou não.\r\nVerifique se uma pessoa é maior de idade ou menor de idade.\r\nVerifique se uma letra digitada é uma vogal ou consoante.\r\nVerifique se um número digitado é maior que 10.\r\nVerifique se um número digitado é menor que 20.\r\nDetermine se a palavra digitada tem mais ou menos que 10 caracteres.\r\nDetermine se um número digitado está no intervalo entre 15 e 30.\r\nDetermine se um número é divisível por 5.";
                string stringdesafiosintermediarios = "Determine se um número digitado está entre 10 e 20 ou entre 30 e 40.\r\nDetermine se a média de três números é maior que 10.\r\nVerifique se uma letra digitada é maiúscula ou minúscula.\r\nVerifique se uma string é um palíndromo.\r\nDetermine se um aluno está aprovado, reprovado ou em recuperação com base em duas notas (aprovação >7, recuperação 5-7, reprovado <5).\r\nDetermine a faixa etária de uma pessoa (criança, adolescente, adulto, idoso) com base em sua idade.\r\nVerifique se um número é múltiplo de ambos 3 e 5.\r\nDetermine se um número digitado está fora do intervalo entre 15 e 30.\r\nVerifique se três números podem formar um triângulo (a soma de quaisquer dois lados deve ser maior que o terceiro lado).\r\nDetermine se um triângulo é equilátero, isósceles ou escaleno, com base no comprimento de seus lados.";
                string stringdesafiosdificeis = "Determine se uma string tem o mesmo número de caracteres 'a' e 'b'.\r\nVerifique se um número é primo.\r\nVerifique se um número é perfeito (um número perfeito é um número que a soma de seus divisores, excluindo o próprio número, é igual ao número).\r\nDetermine o dia da semana (segunda-feira, terça-feira, etc.) dado um número de 1 a 7.\r\nDetermine se um número é uma potência de 2.\r\nVerifique se um ano é um século.\r\nVerifique se três números formam uma progressão aritmética ou uma progressão geométrica.\r\nDetermine se um número é uma sequência de dígitos consecutivos (por exemplo, 1234, 6789).\r\nDetermine o tipo de ângulo (agudo, reto ou obtuso) com base em seus graus.\r\nVerifique se uma string contém apenas números.";
                
                Console.WriteLine("----------------------\nbem vindo ao Desafio máximo do Nego!!!!\n---------------------- \ndigite o numero correspondente para escolher uma opção:\n\n");
                Console.WriteLine("Escolha o tipo de desafio\n--------------\n1 = facil\n2 = medio\n3 = dificil");
                
                string escolha = Console.ReadLine();
                switch (escolha)
                {
                    case "1":
                        while (repeticao == "r")
                        {
                            stringdesafiosbasicos = stringdesafiosbasicos.Replace("\n", "");
                            List<string> listdesafiosbasicos = stringdesafiosbasicos.Split('\r').ToList();

                            for (int i = 0; i < listdesafiosbasicos.Count; i++)
                            {
                                Console.WriteLine(i + " = " + listdesafiosbasicos[i]);
                            }
                            ExerciciosFacilEscolha();
                            
                            
                            Console.WriteLine("Digite [r] para repetir o metodo ou qualquer outra letra para voltar ao inicio");
                            repeticao = Console.ReadLine();
                        }
                        break;
                    case "2":
                        while (repeticao == "r")
                        {
                            stringdesafiosintermediarios = stringdesafiosintermediarios.Replace("\n", "");
                            List<string> listdesafiosintermediarios = stringdesafiosintermediarios.Split('\r').ToList();

                            for (int i = 0; i < listdesafiosintermediarios.Count; i++)
                            {
                                Console.WriteLine(i + " = " + listdesafiosintermediarios[i]);
                            }
                            ExerciciosIntermediarioEscolha();

                            
                            Console.WriteLine("Digite [r] para repetir o metodo ou qualquer outra letra para voltar ao inicio");
                            repeticao = Console.ReadLine();
                        }
                        break;
                    case "3":
                        while (repeticao == "r")
                        {
                            stringdesafiosdificeis = stringdesafiosdificeis.Replace("\n", "");
                            List<string> listdesafiosdificeis = stringdesafiosdificeis.Split('\r').ToList();

                            for (int i = 0; i < listdesafiosdificeis.Count; i++)
                            {
                                Console.WriteLine(i + " = " + listdesafiosdificeis[i]);
                            }
                            ExerciciosAvancadosEscolha();


                            Console.WriteLine("Digite [r] para repetir o metodo ou qualquer outra letra para voltar ao inicio");
                            repeticao = Console.ReadLine();
                        }
                        break;
                    default:

                        break;
                }
                
                Console.WriteLine("Digite [r] para repetir a escolha do nivel ou qualquer outra letra para finalizar");
                repeticao = Console.ReadLine();
                Console.Clear();
            }
        }
        
        public static void ExerciciosFacilEscolha()
        {
            string escolha = Console.ReadLine();
            if (escolha == "0")
            {
                ExerciciosFacil.Exercicio0();
            }
            if (escolha == "1")
            {
                ExerciciosFacil.Exercicio1();
            }
            if (escolha == "2")
            {
                ExerciciosFacil.Exercicio2();
            }
            if (escolha == "3")
            {
                ExerciciosFacil.Exercicio3();
            }
            if (escolha == "4")
            {
                ExerciciosFacil.Exercicio4();
            }
            if (escolha == "5")
            {
                ExerciciosFacil.Exercicio5();
            }
            if (escolha == "6")
            {
                ExerciciosFacil.Exercicio6();
            }
            if (escolha == "7")
            {
                ExerciciosFacil.Exercicio7();
            }
            if (escolha == "8")
            {
                ExerciciosFacil.Exercicio8();
            }
            if (escolha == "9")
            {
                ExerciciosFacil.Exercicio9();
            }
        }
        public static void ExerciciosIntermediarioEscolha()
        {
            string escolha = Console.ReadLine();
            if (escolha == "0")
            {
                ExerciciosIntermediario.Exercicio0();
            }
            if (escolha == "1")
            {
                ExerciciosIntermediario.Exercicio1();
            }
            if (escolha == "2")
            {
                ExerciciosIntermediario.Exercicio2();
            }
            if (escolha == "3")
            {
                ExerciciosIntermediario.Exercicio3();
            }
            if (escolha == "4")
            {
                ExerciciosIntermediario.Exercicio4();
            }
            if (escolha == "5")
            {
                ExerciciosIntermediario.Exercicio5();
            }
            if (escolha == "6")
            {
                ExerciciosIntermediario.Exercicio6();
            }
            if (escolha == "7")
            {
                ExerciciosIntermediario.Exercicio7();
            }
            if (escolha == "8")
            {
                ExerciciosIntermediario.Exercicio8();
            }
            if (escolha == "9")
            {
                ExerciciosIntermediario.Exercicio9();
            }
        }
        public static void ExerciciosAvancadosEscolha()
        {
            string escolha = Console.ReadLine();
            if (escolha == "0")
            {
                ExerciciosAvancados.Exercicio0();
            }
            if (escolha == "1")
            {
                ExerciciosAvancados.Exercicio1();
            }
            if (escolha == "2")
            {
                ExerciciosAvancados.Exercicio2();
            }
            if (escolha == "3")
            {
                ExerciciosAvancados.Exercicio3();
            }
            if (escolha == "4")
            {
                ExerciciosAvancados.Exercicio4();
            }
            if (escolha == "5")
            {
                ExerciciosAvancados.Exercicio5();
            }
            if (escolha == "6")
            {
                ExerciciosAvancados.Exercicio6();
            }
            if (escolha == "7")
            {
                ExerciciosAvancados.Exercicio7();
            }
            if (escolha == "8")
            {
                ExerciciosAvancados.Exercicio8();
            }
            if (escolha == "9")
            {
                ExerciciosAvancados.Exercicio9();
            }
        }
    }
}







