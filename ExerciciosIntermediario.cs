using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDoBoss
{
    internal class ExerciciosIntermediario
    {
        public static void Exercicio0() // número digitado está entre 10 e 20 ou entre 30 e 40.
        {
            try
            {
                Console.WriteLine("digite um numero");
                decimal number = Convert.ToDecimal(Console.ReadLine());

                if ((number >= 10) && (number <= 20))
                {
                    Console.WriteLine("o numero esta no intervalo de 10 a 20");
                }
                if ((number >= 30) && (number <= 40))
                {
                    Console.WriteLine("o numero esta no intervalo de 30 a 40");
                }
                else
                {
                    Console.WriteLine("o numero está fora de todos os intervalos");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio1() // a média de três números é maior que 10.
        {
            try
            {
                Console.WriteLine("digite o numero 1");
                decimal number1 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("digite o numero 2");
                decimal number2 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("digite o numero 3");
                decimal number3 = Convert.ToDecimal(Console.ReadLine());

                decimal result = (number1 + number2 + number3) / 3;
                if (result > 10)
                {
                    Console.WriteLine($"a media de {result} é maior que dez");
                }
                else
                {
                    Console.WriteLine($"a media de {result} NÃO é maior que dez");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio2() // minuscula ou maiuscula
        {
            try
            {
                Console.WriteLine("digite uma letra");
                string letra = Console.ReadLine().Trim();
                try
                {
                    letra = letra.Replace(letra.Substring(1, letra.Length - 1), "");
                }
                catch { }

                string copia = letra.ToLower();
                if (letra == copia)
                {
                    Console.WriteLine("é minuscula");
                }
                else
                {
                    Console.WriteLine("É maiuscula");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio3() //  string é um palíndromo (arara)
        {
            List<string> list = new List<string>();
            try
            {
                Console.WriteLine("digite uma palavra");
                string palavra2 = "";
                string palavra = Console.ReadLine().ToLower().Trim().Replace(" ", "");

                for (int i = 0; i < palavra.Length; i++)
                {
                    palavra2 = palavra.Substring(i, 1) + palavra2;
                }

                if (palavra == palavra2)
                {
                    Console.WriteLine("A palavra é um palíndromo.");
                }
                else
                {
                    Console.WriteLine("A palavra não é um palíndromo.");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio4() // media de notas
        {
            try
            {
                Console.WriteLine("digite a nota 1");
                decimal number1 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("digite a nota 2");
                decimal number2 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("digite a nota 3");
                decimal number3 = Convert.ToDecimal(Console.ReadLine());

                decimal result = (number1 + number2 + number3) / 3;

                Console.WriteLine(result + "\n");
                if (result >= 7)
                {
                    Console.WriteLine($"VOCE PASSOU");
                }
                if ((result >= 5) && (result < 7))
                {
                    Console.WriteLine("recuperação");
                }
                else
                {
                    Console.WriteLine($"REPROVADO");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio5() // idade
        {
            try
            {
                Console.WriteLine("digite a sua idade");
                decimal idade = Convert.ToDecimal(Console.ReadLine());

                if (idade >= 60)
                {
                    Console.WriteLine($"vc é Idoso");
                }
                if ((idade >= 18) && (idade < 60))
                {
                    Console.WriteLine("vc é adulto");
                }
                if ((idade >= 13) && (idade < 18))
                {
                    Console.WriteLine("vc é adolescente");
                }
                else
                {
                    Console.WriteLine($"criança");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio6() // múltiplo de ambos 3 e 5.
        {
            try
            {
                Console.WriteLine("digite um numero");
                decimal number = Convert.ToDecimal(Console.ReadLine());
                if ((number % 3 == 0) && (number % 5 == 0))
                {
                    Console.WriteLine("é multiplo");
                }
                else
                {
                    Console.WriteLine("nao é");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio7() // intervalo de 15 e 30
        {
            try
            {
                Console.WriteLine("digite um numero");
                decimal number = Convert.ToDecimal(Console.ReadLine());
                if ((number >= 15) && (number <= 30))
                {
                    Console.WriteLine("O numero esta no intervalo");
                }
                else
                {
                    Console.WriteLine("O número nao esta no intervalo");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio8() // três números podem formar um triângulo (a soma de quaisquer dois lados deve ser maior que o terceiro lado).
        {
            try
            {
                Console.WriteLine("digite o lado 1");
                decimal number1 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("digite o lado 2");
                decimal number2 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("digite o lado 3");
                decimal number3 = Convert.ToDecimal(Console.ReadLine());

                List<decimal> numbers = new List<decimal>();
                numbers.Add(number1);
                numbers.Add(number2);
                numbers.Add(number3);

                var numeromaior = numbers.OrderByDescending(c => c).ToList();
                
                if (numeromaior[0] < numeromaior[1] + numeromaior[2])
                {
                    Console.WriteLine("isso é um triangulo");
                }
                else
                {
                    Console.WriteLine("isso não é um triangulo");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio9() // Determine se um triângulo é equilátero, isósceles ou escaleno, com base no comprimento de seus lados.
        {
            try
            {
                Console.WriteLine("digite o lado 1");
                decimal number1 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("digite o lado 2");
                decimal number2 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("digite o lado 3");
                decimal number3 = Convert.ToDecimal(Console.ReadLine());

                if ((number1 == number2) && (number1 == number3))
                {
                    Console.WriteLine("é equilatero");
                }
                if ((number1 != number2) && (number2 != number3) && (number1 != number3))
                {
                    Console.WriteLine("é escaleno");
                }
                else
                {
                    Console.WriteLine("é isóceles");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
    }
}
