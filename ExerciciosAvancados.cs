using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DesafioDoBoss
{
    internal class ExerciciosAvancados
    {
        public static void Exercicio0() // Determine se uma string tem o mesmo número de caracteres 'a' e 'b'.
        {
            try
            {
                Console.WriteLine("digite uma frase");
                string frase = Console.ReadLine().ToLower().Trim();
                int a = 0; int b = 0;
                
                for (int i = 0; i < frase.Length; i++) 
                {
                    if (frase.Substring(i,1) == "a")
                    {
                        a++;
                    }
                    if (frase.Substring(i, 1) == "b")
                    {
                        b++;
                    }
                }
                Console.WriteLine($"{a} - a");
                Console.WriteLine($"{b} - b");
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio1() //  número é primo.
        {
            try
            {
                Console.WriteLine("digite um numero");
                decimal number = Convert.ToDecimal(Console.ReadLine());
                
                var div = 0;
                for (int i = 2; i <= number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        div++;
                    }
                }
                
                if (div == 0)
                {
                    Console.WriteLine("é primo");
                }
                else
                {
                    Console.WriteLine("nao é primo");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio2() // número é perfeito (um número perfeito é um número que a soma de seus divisores, excluindo o próprio número, é igual ao número).
        {
            try
            {
                Console.WriteLine("digite um numero");
                decimal number = Convert.ToDecimal(Console.ReadLine());
                
                int sum = 0;
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        sum += i;
                    }
                }
                if (number == sum)
                {
                    Console.WriteLine("é perfeito");
                }
                else
                {
                    Console.WriteLine("nao é perfeito");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio3() // dias da semana
        {
            try
            {
                Console.WriteLine("digite um numero de 1-7");
                int number = Convert.ToInt32(Console.ReadLine());

                List<string> dias_da_semana = new List<string>();
                dias_da_semana.AddRange(new string[] { "segunda","terça","quarta","quinta","sexta","sabado","domingo" });

                if (true)
                {
                    Console.WriteLine(number + " representa " + dias_da_semana[number]);
                }
                else
                {
                    Console.WriteLine("vc digitou um numero errado");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio4() // Determine se um número é uma potência de 2.
        {
            try
            {
                Console.WriteLine("digite um numero");
                decimal number = Convert.ToDecimal(Console.ReadLine());
                var number_conta = number;
                int contador = 0;
                bool erro = false;

                while (number_conta != 1 && erro == false)
                {
                    if (number_conta % 2 == 0)
                    {
                        number_conta = number_conta / 2;
                        contador++;
                    }
                    else
                    {
                        erro = true;
                    }
                }

                if (erro == false)
                {
                    Console.WriteLine($" o numero que vc digitou({number}) equivale a dois elevado a {contador}");
                }
                else
                {
                    Console.WriteLine("o numero digitado nao é uma potencia de dois");
                }

            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio5() // Verifique se um ano é um século.
        {
            try
            {
                Console.WriteLine("digite um ano");
                decimal ano = Convert.ToDecimal(Console.ReadLine());
                string ano_string = ano.ToString();

                if (ano_string.Length > 2)
                {
                    string seculo = ano_string.Substring(0, 2);
                    ano = decimal.Parse(seculo);
                    ano++;
                }
                else
                {
                    ano = 1;
                }

                Console.WriteLine("o ano que vc digitou pertence ao seculo "+ano);
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio6() //  três números formam uma progressão aritmética ou uma progressão geométrica.
        {
            try
            {
                Console.WriteLine("digite o numero 1");
                decimal number1 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("digite o numero 2");
                decimal number2 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("digite o numero 3");
                decimal number3 = Convert.ToDecimal(Console.ReadLine());

                var razao = number2 - number1;
                var razao2 = number3 - number2;

                if ((number1 + number1 == number2) && (number2 + number2 == number3))
                {
                    Console.WriteLine("isso é uma progressao geometrica");
                }
                if (razao == razao2)
                {
                    Console.WriteLine("isso é uma progressão aritimetica");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio7() //  um número é uma sequência de dígitos consecutivos (por exemplo, 1234, 6789).
        {
            try
            {
                Console.WriteLine("Digite um número:");
                decimal number = Convert.ToDecimal(Console.ReadLine());
                string numeros_string = number.ToString();

                List<string> list_numeros_string = new List<string>();
                List<decimal> list_numeros = new List<decimal>();

                for (int i = 0; i < numeros_string.Length; i++)
                {
                    list_numeros_string.Add(numeros_string.Substring(i, 1));
                    list_numeros.Add(Decimal.Parse(list_numeros_string[i]));
                }
                bool erro = false;
                int b = 1;
                for (int i = 0; i < numeros_string.Length -1; i++)
                {
                    if ((list_numeros[i] == list_numeros[b] - 1) && (erro == false))
                    {

                    }
                    else
                    {
                        erro = true;
                    }
                    b++;
                }
                if (erro == false)
                {
                    Console.WriteLine($" o numero que vc digitou é uma sequencia");
                }
                else
                {
                    Console.WriteLine("o numero digitado nao é uma sequencia");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio8() //  tipo de ângulo (agudo, reto ou obtuso) com base em seus graus.
        {
            try
            {
                Console.WriteLine("Digite a medida do ângulo em graus:");
                int graus = int.Parse(Console.ReadLine());

                if (graus < 90)
                {
                    Console.WriteLine("O ângulo é agudo.");
                }
                else if ((graus == 90) || (graus == 180) || (graus == 270)) 
                {
                    Console.WriteLine("O ângulo é reto.");
                }
                else
                {
                    Console.WriteLine("O ângulo é obtuso.");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio9() // Verifique se uma string contém apenas números.
        {
            try
            {
                Console.WriteLine("Digite uma string:");
                string input = Console.ReadLine();
                
                Regex regex = new Regex(@"^[0-9]+$");
                bool contemApenasNumeros = regex.IsMatch(input);

                if (contemApenasNumeros)
                {
                    Console.WriteLine("A string contém apenas números.");
                }
                else
                {
                    Console.WriteLine("A string contém caracteres que não são números.");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
    }
}
