namespace Aula04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio01();
            //Exercicio02();
            //Exercicio03();
            
            void Exercicio01()
            {
                int interval = 0, intervalMin = 0, intervalMax = 0, sum = 0, help = 0;
                bool condition = false;

                while (condition == false) 
                {
                    try
                    {
                        Console.WriteLine("Insira um valor!");
                        intervalMin = int.Parse(Console.ReadLine());
                        condition = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Insira um valor numerico e que seja inteiro!");
                    }                     
                }

                while (condition == true)
                {
                    try
                    {
                        Console.WriteLine("Insira outro valor!");
                        intervalMax = int.Parse(Console.ReadLine());
                        condition = false;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Insira um valor numerico!");
                    }
                }

                if (intervalMin > intervalMax)
                {
                    if (intervalMin < 0)
                    {
                        help = intervalMin;
                        intervalMin = intervalMin - 1;
                    }
                    else
                    {
                        help = intervalMin;
                        intervalMin = intervalMin + 1;
                    }

                    interval = intervalMax;                    
                    while ( interval < intervalMin)
                    {                        
                        if ((interval%2)==0)
                        {
                            sum++;                            
                        }
                        interval = interval + 1;
                    }
                    Console.WriteLine($"No intervalo de {intervalMax} a {help} existe {sum} numeros pares");
                }
                else
                {
                    if (intervalMax < 0)
                    {
                        help = intervalMax;
                        intervalMax = intervalMax - 1;
                    }
                    else
                    {
                        help = intervalMax;
                        intervalMax = intervalMax + 1;
                    }

                    for (interval = intervalMin; interval < intervalMax; interval++)
                    {
                        if (interval % 2 == 0)
                        {
                            sum++;
                        }
                    }
                    Console.WriteLine($"No intervalo de {intervalMin} a {help} existe {sum} numeros pares");
                }
            }

            void Exercicio02()
            {
                bool condition = false;
                int value = 0;

                while (condition == false)
                {
                    try
                    {
                        Console.Clear();
                        Console.WriteLine("Insira um valor inteiro positivo para o termo final da sequencia de Fibonacci!");
                        value = int.Parse(Console.ReadLine()); 
                        if (value < 0)
                        {
                            Console.WriteLine("Só é permitido inserir um valor maior ou igual a zero");
                            Thread.Sleep(1500);
                        }
                        else
                        {
                            condition = true;
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Insira um valor numerico");
                    }
                }                
                
                for (int i = 0; i < (value+1); i++)
                {
                    Console.WriteLine($"A sequencia de Fibonacci! no termo {i} é {Fibonacci(i)}");
                }
            }

            void Exercicio03()
            {
                Random random = new Random();
                int numberRandom = random.Next(1, 101), number = 0;
                bool condition = false, conditionNumber = false;


                Console.WriteLine("Insira um valor inteiro positivo entre 0 e 100 e tente adivinhar qual é o numero secreto!!");
                
                while (condition == false)
                {
                    while (conditionNumber == false)
                    {
                        try
                        {
                            number = int.Parse(Console.ReadLine());
                            if (number < 0)
                            {
                                Console.WriteLine("Só é permitido inserir valor maior que zero");
                                Thread.Sleep(1500);
                            }
                            else if(number > numberRandom)
                            {
                                Console.WriteLine("Você colocou um numero maior que o escolhido pelo computador, continue tentando!");
                            }
                            else if (number < numberRandom)
                            {
                                Console.WriteLine("Você colocou um numero menor que o escolhido pelo computador, continue tentando!");
                            }
                            else
                            {
                                Console.WriteLine($"Muito bem!! Você acertou o numero escolhido");
                                conditionNumber = true;
                                condition = true;
                            }

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Insira um valor numerico");
                        }
                    }
                }

            }

            static double Fibonacci(int value)
            {                
                if (value == 0)
                {
                    return 0;
                }
                else if(value == 1)
                {
                    return 1;
                }
                else if(value == 2)
                {
                    return 1;
                }
                else
                {
                    return Fibonacci(value - 1)+Fibonacci(value - 2);
                }                
            };
        }
    }
}