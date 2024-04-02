namespace ATV5_CJ3022447
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PROJETO 1
            int numero;
            Console.WriteLine("Até q número deseja contar?");
            numero = int.Parse(Console.ReadLine());
            for (int cont = 1; cont <= numero; cont++)
                Console.WriteLine("{0}", cont);

            //PROJETO 2

            int nmr;
            Console.WriteLine("Até q número deseja contar?(os números pares)");
            nmr = int.Parse(Console.ReadLine());
            for (int cont = 0; cont <= nmr; cont = cont + 2)
                Console.WriteLine("{0}", cont);

            //PROJETO 3

            int nmr1;
            Console.WriteLine("Insira um número menor que 1000");
            nmr1 = int.Parse(Console.ReadLine());
            for (int cont = 1000; cont >= nmr1; cont = cont - 2)
                Console.WriteLine("{0}", cont);

            //PROJETO 4

            int nmr2;
            for (int cont = 0; cont < 200; cont = cont + nmr2)
            {

                Console.WriteLine("Escreva um número para somar, iremos parar de somar caso a soma dos números seja igual ou maior que 200");
                nmr2 = int.Parse(Console.ReadLine());
            }

            //PROJETO 5

            int nmr3;
            Console.WriteLine("Digite o número que deseja descobrir os divisores");
            nmr3 = int.Parse(Console.ReadLine());
            for (int cont = 1; cont < nmr3; cont++)
            {
                if (nmr3 % cont == 0)
                    Console.WriteLine("{0}", cont);
            }

            //PROJETO 6

            //PROJETO 7




            for (int nmr4 = 0, pares = 0, impares = 0; ;)
            {
                Console.WriteLine("Digite um valor, somaremos os ímpares e os pares, se digitar '0' o programa é encerrado");
                nmr4 = int.Parse(Console.ReadLine());

                if (nmr4 == 0)
                {
                    Console.WriteLine("A soma dos números pares é:{0}}\nA soma dos números ímpares é: {1}", pares, impares);
                    break;
                }
                if (nmr4 % 2 == 0)
                    pares = pares + nmr4;
                else
                    impares = impares + nmr4;
            }
    }
}
