using System.Numerics;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProvaCodingTank
{
    class Program
    {
        static void Main(string[] args)
        {
            Questao01();
            Questao02();
            Questao03();
            Questao04();
            Questao05();

            void Questao01()
            {
                int number = 0,pair = 0, odd = 0, numberNegative = 0, numberPositive = 0;
                bool condition = false;

                while (condition == false)
                {                    
                    for (int i = 0; i < 5; i++)
                    {
                        try
                        {
                            Console.WriteLine("Insira um valor numerico positivo");
                            number = int.Parse(Console.ReadLine());
                            if (number % 2 == 0)
                            {
                                pair = pair + 1;
                            }
                            else
                            {
                                odd = odd + 1;
                            }

                            if (number < 0)
                            {
                                numberNegative = numberNegative + 1;
                            }
                            else
                            {
                                numberPositive = numberPositive + 1;
                            }

                        }
                        catch (Exception ex)
                        {
                        Console.WriteLine("Insira um valor numerico e que seja inteiro!");
                        i = i - 1;
                        }
                                                  
                    }
                     condition = true;
                }
                Console.WriteLine($"Dos numeros digitados {pair} são pares");
                Console.WriteLine($"Dos numeros digitados {odd} são impares");
                Console.WriteLine($"Dos numeros digitados {numberNegative} são negativos");
                Console.WriteLine($"Dos numeros digitados {numberPositive} são positivos");
            }

            void Questao02()
            {
                int value01 = 0, value02 = 0, multiplication = 0, division = 0;
                bool condition = false, reverse = false; ;

                while (condition == false)
                {
                    try
                    {
                        Console.WriteLine("Insira um valor para N1");
                        value01 = int.Parse(Console.ReadLine());
                        if (value01 == 0)
                        {
                            Console.WriteLine("A divisão por zero não são permitidas, insira outro valor.");
                        }
                        else
                        {
                            condition = true;
                        }
                    }
                    catch (Exception ex) 
                    { 
                        Console.WriteLine("Insira um valor numerico inteiro"); 
                    }
                }

                while (condition == true)
                {
                    try
                    {
                        Console.WriteLine("Insira um valor para N2");
                        value02 = int.Parse(Console.ReadLine());
                        if (value02 == 0)
                        {
                            Console.WriteLine("A divisão por zero não são permitidas, insira outro valor.");
                        }
                        else
                        {
                            condition = false;
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Insira um valor numerico inteiro");
                    }
                }

                if (value02 < 0 && value01 < 0)
                {
                    value01 = -value01;
                    value02 = -value02;
                    reverse = false;
                }
                else if(value02 < 0)
                {
                    value02 = -value02;
                    reverse = true;
                }
                else if(value02 < 0 && value01 < 0)
                {                    
                    value01 = -value01;
                    reverse = true;
                }               
                

                //Multiplicação
                for (int i = 0; i < value02; i++)
                {
                    multiplication += value01;
                }

                //Divisão
                while (value01 >= value02)
                {
                    value01 -= value02;
                    division++;
                }

                if (reverse)
                {
                    multiplication = -multiplication;
                    division = -division;
                }

                Console.WriteLine("Multiplicação: " + multiplication);
                Console.WriteLine("Divisão Inteira: " + division);

            }

            void Questao03()
            {
                int upper = 0, lower = 0, initUpper = 0, initLower = 0, allWords = 0;
                string phrase;
                string[] words;

                Console.WriteLine("Digite uma frase:");
                phrase = Console.ReadLine();

                words = phrase.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                
                foreach (string word in words)
                {
                    if (!string.IsNullOrEmpty(word))
                    {
                        if (word.All(char.IsUpper))
                            upper++;
                        else if (word.All(char.IsLower))
                            lower++;
                        else if (char.IsUpper(word[0]))
                            initUpper++;
                        else if (char.IsLower(word[0]))
                            initLower++;
                    }
                }

                allWords = words.Length;

                Console.WriteLine($"Quantidade de palavras em maiúsculas: {upper}" );
                Console.WriteLine($"Quantidade de palavras em minúsculas: {lower}");
                Console.WriteLine($"Quantidade de palavras que iniciam com letra maiúscula: {initUpper}");
                Console.WriteLine($"Quantidade de palavras que iniciam com letra minúscula: {initLower}");
                Console.WriteLine($"Quantidade total de palavras: {allWords}");
            }

            void Questao04()
            {
                Console.WriteLine("Questão 04 - Alternativa C = 1");
            }

            void Questao05()
            {
                Console.WriteLine("Questão 05 - Alternativa E = –5, –2, 1, 4, 7");
            }      
            
        }        
    }
}