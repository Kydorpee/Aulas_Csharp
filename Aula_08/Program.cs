using System.ComponentModel.Design;

class Aula_08
{
    static void Main()
    {
        int select; // Para trabalhar com as opçoes; 
        int v1, v2, Res; // Para as demais!
        double d1, d2, des; // Para divisão!
        string nome;

        Console.Clear();
        Console.Write(" Qual seu nome?: ");
        nome = Console.ReadLine();
        Console.Clear();


        for (int i = 0; i < 1;) 
        {

            Console.WriteLine(" \nOlá {0}, Digite a Opção desejada: \n", nome);

            Console.WriteLine(" 1 - Somar\n 2 - Subtração\n 3 - Multiplicação\n 4 - Divisão\n 0 - Sair\n");
            select = int.Parse(Console.ReadLine());

            Console.Clear();

            switch (select)
            {
                case 1:

                    Console.WriteLine("\n Vamos lá {0}!, Você escolheu Somar! \n", nome);

                    Console.Write(" Digite o primeiro numero: ");
                    v1 = int.Parse(Console.ReadLine());
                    Console.Write(" Digite o segundo numero: ");
                    v2 = int.Parse(Console.ReadLine());

                    Res = v1 + v2;
                    Console.WriteLine("\n O valor de {0} somado a {1} é: {2} \n", v1, v2, Res);
                    Console.ReadKey();
                    break;

                case 2:

                    Console.WriteLine(" \nVamos lá {0}, Você escolheu Subtrair!\n", nome);
                    Console.Write(" Digite o primeiro numero: ");
                    v1 = int.Parse(Console.ReadLine());
                    Console.Write(" Digite o segundo numero: ");
                    v2 = int.Parse(Console.ReadLine());

                    Res = v1 - v2;
                    Console.WriteLine("\n O valor de {0} Subtraido por {1} é: {2}\n", v1, v2, Res);
                    Console.ReadKey();

                    break;

                case 3:

                    Console.WriteLine("\n Vamos lá {0}, Você escolheu Multiplicar!\n", nome);
                    Console.Write(" Digite o Valor: ");
                    v1 = int.Parse(Console.ReadLine());
                    Console.Write(" Quantas vezes deseja Multiplicar?: ");
                    v2 = int.Parse(Console.ReadLine());
                    Res = v1 * v2;
                    Console.WriteLine("\n {0} multiplicado por {1} é: {2}\n", v1, v2, Res);
                    Console.ReadKey();

                    break;

                case 4:

                    Console.WriteLine(" \nVamos lá {0}, Você escolheu Dividir!\n", nome);
                    Console.Write(" Digite o valor: ");
                    d1 = double.Parse(Console.ReadLine());
                    Console.Write(" Quantas vezes deseja dividir?: ");
                    d2 = double.Parse(Console.ReadLine());
                    des = d1 / d2;
                    Console.WriteLine(" \n{0} dividido por {1} é: {2}\n", d1, d2, des);
                    Console.ReadKey();


                    break;

                case 0:

                    i = 1;
                    Console.Clear();

                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("\n Infelizmente a opção digitada esta invalida escolha novamente! \n");
                    Console.ReadKey();

                    break;
            }
        

        }
        


    }
}