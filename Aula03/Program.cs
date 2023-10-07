namespace Aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio01();
            //Exercicio02();
            //Exercicio03();
            //Exercicio04();

            //RunDicionario();
            //RunMatriz();
            //RunArray();
        }

        static void RunArray()
        {
            int[] vetorInteiro = new int[5];
            vetorInteiro[0] = 1;
            vetorInteiro[1] = 2;
            vetorInteiro[2] = 3;
            vetorInteiro[3] = 4;
            vetorInteiro[4] = 5;

            //Resize => aumenta o array
            int tamanhoAtual = vetorInteiro.Length;
            Array.Resize(ref vetorInteiro, tamanhoAtual + 5);
            vetorInteiro[6] = 7;

            while (true)
            {
                Console.WriteLine("true");
                return;
            }
        }
    
        static void RunMatriz()
        {
            int[,] matriz = new int[2, 3];
            matriz[0,0] = 1;
            matriz[0,1] = 2;
            matriz[0,2] = 3;
            matriz[1,0] = 4;
            matriz[1,1] = 5;
            matriz[1,2] = 6;
        }
    
        static void RunDicionario()
        {
            Dictionary<string, double> dic = new Dictionary<string, double>
            {
                {"chave1",2},
                {"chave2",3},
                {"chave3",4 }
            };

            foreach(var item in dic)
            {
                Console.WriteLine($"chave: {item.Key}, valor: {item.Value}");
            }
        }
    
        static void Exercicio01()
        {
            int[] vetor1, vetor2, vetor3 = new int[3];

            vetor1 = new int[10];
            for (int i = 0; i < vetor1.Length; i++)
            {
                int contador = i;
                while (contador < vetor1.Length) 
                {
                    try
                    {
                        Console.WriteLine($"Insira um numero para o indice {i} para o vetor1");
                        vetor1[i] = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Insira um valor numerico");
                    }
                }
            }

            vetor2 = new int[10];
            for (int i = 0; i < vetor2.Length; i++)
            {
                int contador = i;
                while (contador < vetor2.Length)
                {
                    try
                    {
                        Console.WriteLine($"Insira um numero para o indice {i} para o vetor2");
                        vetor2[i] = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Insira um valor numerico");
                    }
                }
            }

            vetor3[0] = vetor1[1] + vetor2[9];
            vetor3[1] = vetor1[2] + vetor2[9];
            vetor3[2] = vetor1[3] + vetor2[8];

            for (int i = 0;i < vetor3.Length; i++)
            {
                Console.WriteLine($"O valor do vetor{i} é {vetor3[i]}");
            }
        }
    
        static void Exercicio02()
        {
            int[] number = new int[10];
            float average, sum = 0, minNumber = 0;

            for (int i = 0; i<number.Length ; i++) 
            {
                int contador = i;
                while (contador < number.Length)
                {
                    try
                    {
                        Console.WriteLine($"Insira um o valor {i}");
                        number[i] = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Insira um valor numerico");
                    }
                }                
                sum = sum + number[i];               
            }
            minNumber = number[0]; 

            for(int i = 1; i<number.Length; i++)
            {
                if (minNumber > number[i])
                {
                    minNumber = number[i];
                }
            } 


            average = sum / 10;
            Console.WriteLine($"Média dos valores do vetor é {average:F2}");
            Console.WriteLine($"A soma de todos valores é {sum}");
            Console.WriteLine($"O menor numero do vetor é {minNumber}");
        }
    
        static void Exercicio03()
        {
            int sum = 0;
            for (int i = 1; i <= 100 ; i++)
            {
                sum = sum+i;
            }
            Console.WriteLine(sum);
        }
    
        static void Exercicio04()
        {
            int numberRead = 0, sum = 0, i = 1;
            string par = "";

            while(i != 0){
                try
                {
                    Console.WriteLine("Insira um valor");
                    i = int.Parse(Console.ReadLine());
                    numberRead++;
                    sum += i;
                    if(i % 2 == 0)
                    {
                        if (i == 0) 
                        {
                            continue;
                        }
                        else
                        {
                            par = $"{par}{i}, ";
                        }
                    }
                }
                catch
                {
                   Console.WriteLine("Insira um valor numerico");
                }                
            }
            Console.WriteLine($"Foram lidos {numberRead} lidos");
            Console.WriteLine($"A soma de todos os numeros lidos é {sum}");
            Console.WriteLine($"São pares os seguintes numeros: {par}");
        }
    }
}
