namespace Aula01 
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercicio01();
            Exercicio02();
            Exercicio03();
            Exercicio04();
            //Console.WriteLine("Digite o seu nome: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Digite o sua idade: ");
            //int year = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Olá, {name}!!! Bem-vindo ao Coding Tank.");
            void Exercicio01() 
            {
                Console.WriteLine("1° Digite um numero");
                Console.WriteLine("2° Digite um outro numero");
                int number01 = int.Parse(Console.ReadLine());
                int number02 = int.Parse(Console.ReadLine());

                int adicao = number01 + number02;
                int subtracao = number01 - number02;
                int multiplicacao = number01 * number02;
                int divisao = number01 / number02;


                Console.WriteLine($"Adição: {number01} + {number02} = {adicao}");
                Console.WriteLine($"Subtração: {number01} - {number02} = {subtracao}");
                Console.WriteLine($"Multiplicação: {number01} * {number02} = {multiplicacao}");
                Console.WriteLine($"Divisão: {number01} / {number02} = {divisao}");
            }

            void Exercicio02() 
            {
                Console.WriteLine("1° Insira o ano atual");
                Console.WriteLine("2° Insira o ano do seu nascimento");
                int anoAtual = int.Parse(Console.ReadLine());
                int anoNascimento = int.Parse(Console.ReadLine());

                int idade = anoAtual - anoNascimento;

                Console.WriteLine($"Você tem {idade} anos");
            }

            void Exercicio03() 
            {
                Console.WriteLine("1° Insira o valor total da conta");
                Console.WriteLine("2° Insira o a porcentagem da gorjeta que desejar dar (Ex: 20% = 20)");
                float conta = float.Parse(Console.ReadLine());
                float gorjeta = float.Parse(Console.ReadLine());

                float contaTotal = conta + (conta*(gorjeta/100));
                float gorjetaValor = (conta * (gorjeta / 100));

                Console.WriteLine($"O valor gorjeta é {gorjetaValor:F2}");
                Console.WriteLine($"O valor total da conta é {contaTotal:F2}");
            }

            void Exercicio04()
            {
                Console.WriteLine("Insira um valor de dinheiro em real");

                double real = double.Parse(Console.ReadLine());

                double dolar = real / 5.50;
                double euro = real / 6.50;

                Console.WriteLine($"{real} equivale a {dolar:F2} dólares");
                Console.WriteLine($"{real} equivale a {euro:F2} euros");
            }

        }
    }

   
}