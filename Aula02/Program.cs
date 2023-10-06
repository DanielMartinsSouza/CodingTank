using System.Text;
using System.Text.RegularExpressions;

namespace Aula02
{
    class Program
    {
        static void Main()
        {
            Exercicio05();
            Exercicio06();
            Exercicio07();
            Exercicio08();
            Exercicio09();
            Exercicio10();
            Exercicio11();

            //string minhaString;
            //string minhaString2;
            //minhaString = "Isso é uma string";
            //minhaString2 = "Isso é uma string 2";

            //string resultado = minhaString + minhaString2;
            //string resultado2 = $"{minhaString} {minhaString2}";
            //string resultado3 = string.Format("{0} {1}", minhaString, minhaString2);
            //string resultadoConcat = string.Concat(minhaString, minhaString2);

            //Console.WriteLine(resultado);
            //Console.WriteLine(resultado2);
            //Console.WriteLine(resultado3);
            //Console.WriteLine(resultadoConcat);

            //StringBuilder stringBuilder = new StringBuilder();
            //stringBuilder.Append("Hello, ");
            //stringBuilder.Append("world!");
            //string resultadoStringBuilder = stringBuilder.ToString();
            //Console.WriteLine(resultadoStringBuilder);

            //string texto2 = " Exemplo de texto ";
            //int comprimento = texto2.Length;
            //Console.WriteLine(comprimento);
            //string maiuscula = texto2.ToUpper();
            //Console.WriteLine(maiuscula);
            //string minuscula = texto2.ToLower();
            //Console.WriteLine(minuscula);
            //string remove = texto2.Remove(7);
            //Console.WriteLine(remove);
            //string semEspacoFinalInicial = texto2.Trim();
            //Console.WriteLine(semEspacoFinalInicial);
            //string semEspaco = texto2.Replace(" ", "");
            //Console.WriteLine(semEspaco);
            //int comprimento2 = texto2.Replace(" ", "").Length;
            //Console.WriteLine(comprimento2);
            //string parte = texto2.Substring(0, 10);
            //Console.WriteLine(parte);

            //Console.WriteLine("Digite Sim ou Não:");
            //string input = Console.ReadLine();
            //string pattern = @"^Não";
            //string pattern2 = @"\(\d{2}\) \d{5}-\d{4}";
            //bool isMatch = Regex.IsMatch(input, pattern2);
            //if (isMatch)
            //{
            //    Console.WriteLine("A string corresponde ao padrão.");
            //}
            //else
            //{
            //    Console.WriteLine("A string não corresponde ao padrão.");
            //}

            void Exercicio05()
            {
                try
                {
                    float fishWeigth, fishWeigthmax = 0, pay = 0;
                    Console.WriteLine("Digite o peso do quilo do peixe");
                    fishWeigth = float.Parse(Console.ReadLine());
                    while (fishWeigth < 0)
                    {
                        Console.WriteLine("O peso do quilo do peixe não pode ser negativo!!");
                        Console.WriteLine("Digite o peso do quilo do peixe novamente");
                        fishWeigth = float.Parse(Console.ReadLine());
                    }
                                       
                    if (fishWeigth > 50) 
                    {
                        fishWeigthmax =+ fishWeigth - 50;
                        pay =+ fishWeigthmax * 4;
                        Console.WriteLine($"Seu peixe esta com excesso de {fishWeigthmax} quilos");
                        Console.WriteLine($"Sua multa é de R$:{pay}");
                    }
                    else
                    {
                        Console.WriteLine($"Seu peixe esta com excesso de {fishWeigthmax} quilos");
                        Console.WriteLine($"Sua multa é de R$:{pay}");
                    }                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Para executar o programa é necessario que você insira um valor numerico");
                }
            }
            
            void Exercicio06()
            {
                try
                {
                    int age;
                    Console.WriteLine("Insira sua idade");
                    age = int.Parse(Console.ReadLine());

                    while(age <= 0)
                    {
                        Console.WriteLine("Não existe idade negativa e nem 0 de idade");
                        Console.WriteLine("Insira sua idade");
                        age = int.Parse(Console.ReadLine());                        
                    }

                    if (age >= 5 && age < 8)
                    {
                        Console.WriteLine("Sua categoria é Infantil A");
                    }
                    else if (age >= 8 && age < 12)
                    {
                        Console.WriteLine("Sua categoria é infantil B");
                    }
                    else if (age >= 12 && age < 14)
                    {
                        Console.WriteLine("Sua categoria é Juvenil A");
                    }
                    else if (age >= 14 && age < 18)
                    {
                        Console.WriteLine("Sua categoria é Juvenil B");
                    }
                    else
                    {
                        Console.WriteLine("Sua categoria é Adultos");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Para executar o programa é necessario que você insira um valor numerico");
                }
            }
        
            void Exercicio07()
            {
                float sell, productValue = 0;
                int amount = 0;
                string productCode, productName;
                bool amountBool = true, productValueBool = true;
                                
                Console.WriteLine("Insira o codigo do produto");
                productCode = Console.ReadLine();

                Console.WriteLine("Insira o nome do produto");
                productName = Console.ReadLine();

                while (amountBool)
                {
                    try 
                    {
                        Console.WriteLine("Insira o quantidade vendida do produto");
                        amount = int.Parse(Console.ReadLine());
                        amountBool = false;
                    }
                    catch (Exception ex) 
                    {
                        Console.WriteLine("Insira um valor numerico");
                    }
                }

                while (productValueBool)
                {
                    try
                    {
                        Console.WriteLine("Insira o valor do produto");
                        productValue = float.Parse(Console.ReadLine());
                        productValueBool = false;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Insira um valor numerico");
                    }
                }

                sell = productValue * amount;
                Console.WriteLine("Calculando a venda do produto!!");
                Console.WriteLine($"Código do produto: {productCode}");
                Console.WriteLine($"Produto: {productName}");
                Console.WriteLine($"Quantidade: {amount}");
                Console.WriteLine($"Valor do produto: {productValue}");
                Console.WriteLine($"Valor total da venda: {sell}");

            }
        
            void Exercicio08()
            {
                float proof1=0, proof2=0, proof3=0, approved, approvedExam;
                bool proof1Bool = true, proof2Bool = true, proof3Bool = true;

                while (proof1Bool)
                {
                    try
                    {
                        Console.WriteLine("Insira a nota da primeira prova");
                        proof1 = float.Parse(Console.ReadLine());
                        proof1Bool = false;
                    }catch (Exception ex)
                    {
                        Console.WriteLine("Insira um valor numerico!!");
                    }
                }

                while (proof2Bool)
                {
                    try
                    {
                        Console.WriteLine("Insira a nota da segunda prova");
                        proof2 = float.Parse(Console.ReadLine());
                        proof2Bool = false;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Insira um valor numerico!!");
                    }
                }

                while (proof3Bool)
                {
                    try
                    {
                        Console.WriteLine("Insira a nota da terceira prova");
                        proof3 = float.Parse(Console.ReadLine());
                        proof3Bool = false;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Insira um valor numerico!!");
                    }
                }

                approved = (proof1 + proof2 + proof3)/3;
                if (approved >= 7)
                {
                    Console.WriteLine($"Você foi aprovado com média {approved}");
                }
                else
                {
                    approvedExam = 14 - approved;
                    Console.WriteLine($"Você ficou de exame e precisa tirar nota {approvedExam:F2} para passar de ano");
                }
            }
        
            void Exercicio09()
            {
                int optionCourse=0, optionClass=0;
                string course;
                bool optionBool = true, optionClassBool = true;

                while (optionBool) 
                {
                    try
                    {
                        Console.WriteLine("Escolha qual curso você deseja fazer");
                        Console.WriteLine("1 - Lógica de programação");
                        Console.WriteLine("2 - Desenvolvimento de sistema em C#");
                        Console.WriteLine("3 - Processamento de imagem com python");
                        Console.WriteLine("4 - Desenvolvimento mobile com flutter");
                        optionCourse = int.Parse(Console.ReadLine());

                        while (optionCourse <= 0 || optionCourse > 4)
                        {
                            Console.WriteLine("Escolha qual curso você deseja fazer");
                            Console.WriteLine("1 - Lógica de programação");
                            Console.WriteLine("2 - Desenvolvimento de sistema em C#");
                            Console.WriteLine("3 - Processamento de imagem com python");
                            Console.WriteLine("4 - Desenvolvimento mobile com flutter");
                            Console.WriteLine("Insira um numero de 1 a 4");
                            optionCourse = int.Parse(Console.ReadLine());
                            optionBool = false;
                        }
                        optionBool = false;
                    }
                    catch (Exception ex) 
                    { 
                        Console.WriteLine("Insira um valor numerico");
                    }
                }
                
                if(optionCourse == 1)
                {
                    course = "Lógica de Programação";
                } 
                else if(optionCourse == 2)
                {
                    course = "Desenvolvimento de sistema em C#";
                }
                else if(optionCourse == 3)
                {
                    course = "Processamento de imagem com python";
                }
                else
                {
                    course = "Desenvolvimento mobile com flutter";
                }
                
                while (optionClassBool) 
                {
                    try
                    {
                        Console.WriteLine("Qual turma você gostaria de fazer parte: turma 1, Turma 2 ou Turma 3");
                        Console.WriteLine("Digite 1 para turma 1");
                        Console.WriteLine("Digite 2 para turma 2");
                        Console.WriteLine("Digite 3 para turma 3");
                        optionClass = int.Parse(Console.ReadLine());      
                        
                        while (optionClass <= 0 || optionClass > 3)
                        {
                            Console.WriteLine("Qual turma você gostaria de fazer parte: turma 1, Turma 2 ou Turma 3");
                            Console.WriteLine("Digite 1 para turma 1");
                            Console.WriteLine("Digite 2 para turma 2");
                            Console.WriteLine("Digite 3 para turma 3");
                            Console.WriteLine("Insira um numero de 1 a 3");
                            optionClass = int.Parse(Console.ReadLine());
                            optionClassBool = false;
                        }
                        optionClassBool = false;
                    }
                    catch (Exception ex) { 
                        Console.WriteLine("Insira um valor numerico"); 
                    }
                }

                switch (optionClass)
                {
                    case 1:
                        Console.WriteLine("Essa turma possui uma vaga ainda");
                        Console.WriteLine($"Parabens você faz parte do curso de {course} na turma 1");
                        break;
                    case 2:
                        Console.WriteLine("Essa turma esta cheia mas iremos te inscrever em outra turma");
                        Console.WriteLine($"Parabens você faz parte do curso de {course} na turma 3");
                        break;
                    case 3:
                        Console.WriteLine("Essa turma possui muitas vagas ainda");
                        Console.WriteLine($"Parabens você faz parte do curso de {course} na turma 3");
                        break;
                }
            }
        
            void Exercicio10()
            {                
                string word, reverse = "";

                Console.WriteLine("Digite uma palavra");
                word = Console.ReadLine().ToUpper();

                for (int i = 0; i < word.Length; i++)
                {
                    reverse = $"{reverse}{word[word.Length - (i+1)]}";
                 
                }

                if (reverse == word && reverse == "")
                {
                    Console.WriteLine($"Essa palavra é palíndroma pois {word} = {reverse}");
                }
                else
                {
                    Console.WriteLine($"Essa palavra não é palíndroma pois {word} é diferente de {reverse}");
                }
            }
        
            void Exercicio11()
            {
                float wage = 0, nexWage, wageIncrease, percentageIncrease;
                bool wageBool = true;

                while (wageBool) 
                {
                    try 
                    {
                        Console.WriteLine("Insira o valor do seu salario");
                        wage = float.Parse(Console.ReadLine());                      
                        while(wage <= 0)
                        {
                            Console.WriteLine("Não existe salario negativo");
                            Console.WriteLine("Insira o valor do seu salario");
                            wage = float.Parse(Console.ReadLine());
                        }
                        wageBool = false;
                    }
                    catch (Exception ex) 
                    { 
                        Console.WriteLine("Insira um valor numerico"); 
                    }
                }
                Console.WriteLine(wage);


                if (wage <= 280.00)
                {
                    percentageIncrease = 20;
                    nexWage = wage + (wage * percentageIncrease/100);
                    wageIncrease = nexWage - wage;

                }
                else if(wage > 280 && wage <= 700)
                {
                    percentageIncrease = 15;
                    nexWage = wage + (wage * percentageIncrease/100);
                    wageIncrease = nexWage - wage;
                }
                else if(wage > 700 && wage <= 1500)
                {
                    percentageIncrease = 10;
                    nexWage = wage + (wage * percentageIncrease/100);
                    wageIncrease = nexWage - wage;
                }
                else
                {
                    percentageIncrease = 5;
                    nexWage = wage + (wage * percentageIncrease/100);
                    wageIncrease = nexWage - wage;
                }

                Console.WriteLine($"Salarios antes do reajuste R${wage}");
                Console.WriteLine($"Percentual de aumento {percentageIncrease}%");
                Console.WriteLine($"Valor do aumento {wageIncrease}");
                Console.WriteLine($"Novo salario, após aumento é R${nexWage}");
            }
        }       
    }
}