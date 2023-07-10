using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDoBoss
{
    internal class ExerciciosFacil
    {
        /*
            string repeticao = "r";
            while (repeticao == "r")
            {
                Console.WriteLine("Digite [r] para repetir a escolha do nivel ou qualquer outra letra para finalizar");
                repeticao = Console.ReadLine();
                Console.Clear();
            }
        */
        public static void Exercicio0() // positivo ou negativo
        {
            try
            {
                Console.WriteLine("digite um numero");
                decimal number = Convert.ToDecimal(Console.ReadLine());
                if (number < 0)
                {
                    Console.WriteLine("O numero é Negativo");
                }
                else
                {
                    Console.WriteLine("O número é positivo!");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio1() //par ou impar
        {
            try
            {
                Console.WriteLine("digite um numero");
                decimal number = Convert.ToDecimal(Console.ReadLine());
                if (number % 2 == 1)
                {
                    Console.WriteLine("O numero é impar");
                }
                else
                {
                    Console.WriteLine("O número é par!");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio2() //bissexto ou nao
        {
            try
            {
                Console.WriteLine("digite um ano");
                decimal number = Convert.ToDecimal(Console.ReadLine());
                if (number % 4 == 0)
                {
                    Console.WriteLine("O ano é bissexto");
                }
                else
                {
                    Console.WriteLine("O ano NÃO é bissexto!");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio3() //maior de idade
        {
            try
            {
                Console.WriteLine("digite um numero");
                decimal number = Convert.ToDecimal(Console.ReadLine());
                if (number >= 18)
                {
                    Console.WriteLine("de maior");
                }
                else
                {
                    Console.WriteLine("de menor");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio4() //vogal ou consoante
        {
            try
            {
                Console.WriteLine("digite uma letra");
                string letra = Console.ReadLine().ToLower().Trim();
                try
                {
                    letra = letra.Replace(letra.Substring(1, letra.Length - 1), "");
                }
                catch { }

                if ((letra == "a") || (letra == "e") || (letra == "i") || (letra == "o") || (letra == "u"))
                {
                    Console.WriteLine(letra + " - é vogal");
                }
                else
                {
                    Console.WriteLine(letra + " - consoante");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio5() //maior que 10
        {
            try
            {
                Console.WriteLine("digite um numero");
                decimal number = Convert.ToDecimal(Console.ReadLine());
                if (number > 10)
                {
                    Console.WriteLine("O numero é maior");
                }
                else
                {
                    Console.WriteLine("O número é menor!");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio6() // menor que 20
        {
            try
            {
                Console.WriteLine("digite um numero");
                decimal number = Convert.ToDecimal(Console.ReadLine());
                if (number >= 20)
                {
                    Console.WriteLine("O numero é maior ou igual");
                }
                else
                {
                    Console.WriteLine("O número é menor!");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio7() // palavra maior que dez
        {
            try
            {
                Console.WriteLine("digite uma palavra");
                string letra = Console.ReadLine().ToLower().Trim();
                letra = letra.Replace(" ", "");

                if (letra.Length > 10)
                {
                    Console.WriteLine(letra + " - é maior que 10");
                }
                else
                {
                    Console.WriteLine("é menor que dez");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio8() //intervalo de 15 e 30    
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
                    Console.WriteLine("O número nao esta");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio9() //divisivel por 5
        {
            try
            {
                Console.WriteLine("digite um numero");
                decimal number = Convert.ToDecimal(Console.ReadLine());
                if (number % 5 == 0)
                {
                    Console.WriteLine("O numero é multiplo de 5");
                }
                else
                {
                    Console.WriteLine("O número nao é");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
    }
}
