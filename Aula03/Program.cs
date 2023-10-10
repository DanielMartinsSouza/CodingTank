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
            Teste2();

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
            float[] vetor1, vetor2, vetor3 = new float[10];

            vetor1 = new float[10];
            for (int i = 0; i < vetor1.Length; i++)
            {
                int contador = i;
                while (contador < vetor1.Length) 
                {
                    try
                    {
                        Console.WriteLine($"Insira um numero para o indice {i} para o vetor1");
                        vetor1[i] = float.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Insira um valor numerico");
                    }
                }
            }

            vetor2 = new float[10];
            for (int i = 0; i < vetor2.Length; i++)
            {
                int contador = i;
                while (contador < vetor2.Length)
                {
                    try
                    {
                        Console.WriteLine($"Insira um numero para o indice {i} para o vetor2");
                        vetor2[i] = float.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Insira um valor numerico");
                    }
                }
            }

            for (int i = 0;i < vetor3.Length; i++)
            {
                vetor3[i] = vetor1[i] + vetor2[vetor3.Length - (i+1)];
                Console.WriteLine($"O valor do vetor3 no indice{i} é {vetor3[i]:F2}");
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
                        Console.WriteLine($"Insira um numero para o vetor no indice {i}");
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
            Console.WriteLine($"A soma de todos valores é {sum:F2}");
            Console.WriteLine($"O menor numero do vetor é {minNumber:F2}");
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
            int numberRead = 0, sum = 0, i = 1, parNumber = 0;
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
                            break;
                        }
                        else
                        {
                            parNumber++;
                            par = $"{par}{i}, ";
                            
                        }                        
                    }
                }
                catch
                {
                   Console.WriteLine("Insira um valor numerico");
                }                
            }
            numberRead = numberRead - 1;
            Console.WriteLine($"Foram lidos {numberRead} lidos");
            Console.WriteLine($"A soma de todos os numeros lidos é {sum}");
            Console.WriteLine($"São pares {parNumber} numeros");
            Console.WriteLine($"São pares os seguintes numeros: {par}");
        }

        static void Teste()
        {
            while (true)
            {
                //Declaração das variáveis
                int numero = 0, pares = 0;
                int[] lista = new int[0];

                //Apresentação no Console
                Console.WriteLine("--------Desafio 15--------");

                while (numero == 0)
                {
                    Console.WriteLine("A lista de números está vazia. Digite um número diferente de zero: ");
                    if (int.TryParse(Console.ReadLine(), out numero) == false)
                    {
                        Console.WriteLine("São aceitos apenas números inteiros");
                        continue;
                    }
                    else
                    {
                        Array.Resize(ref lista, lista.Length + 1);
                        lista[lista.Length - 1] = numero;
                    }
                }
                while (numero != 0)
                {                   
                    if (int.TryParse(Console.ReadLine(), out numero) == false)
                    {
                        bool var = false;
                        while (var == false)
                        {
                            Console.WriteLine("São aceitos apenas números inteiros");
                            var = int.TryParse(Console.ReadLine(), out numero) == true;
                        }
                    }
                    if (numero % 2 == 0 && numero != 0)
                    {
                        pares++;
                    }
                    Array.Resize(ref lista, lista.Length + 1);
                    lista[lista.Length - 1] = numero;

                }
                Console.WriteLine(lista.Length);
                Console.WriteLine(lista.Sum());
                Console.WriteLine(pares);
            }
        }
    
        static void Teste2()
        {
            double numero = 123.4567;
            Console.WriteLine(String.Format("{0:0.00}", numero));
        }
    }
}

