class Aula_08
{
    static void Main()
    {
        int select,v1, v2, Res;
        string nome;

        Console.Write(" Qual seu nome?: ");
        nome = Console.ReadLine();

        Console.WriteLine(" Olá {0}, Digite a Opção desejada:", nome);

        Console.WriteLine(" 1 - Somar\n 2 - Subtração\n 3 - Multiplicação\n 4 - Divisão\n");
        select = int.Parse(Console.ReadLine());


        switch (select)
        {
            case 1:

                Console.WriteLine(" Vamos lá {0}!, Você escolheu Somar!",nome);

                Console.Write(" Digite o primimeiro numero: ");
                v1 = int.Parse (Console.ReadLine());
                Console.Write(" Digite o segundo numero: ");
                v2 = int.Parse(Console.ReadLine());

                Res = v1 + v2;
                Console.WriteLine(" O valor de {0} somado a {1} é: {2}",v1,v2, Res);
                break;

            case 2:

                Console.WriteLine(" Vamos lá {0}, Você escolheu Subtrair!", nome);
                Console.Write(" Digite o primeiro numero: ");
                v1 = int.Parse(Console.ReadLine());
                Console.Write(" Digite o segundo numero: ");
                v2 = int.Parse(Console.ReadLine());

                Res = v1 - v2;
                Console.WriteLine(" O valor de {0} Subtraido por {1} é: {2}",v1,v2,Res);
                break;

            case 3:

                Console.WriteLine(" Vamos lá {0}, Você escolheu Multiplicar!", nome);
                Console.Write(" Digite o Valor: ");
                v1 = int.Parse(Console.ReadLine());
                Console.Write(" Quantas vezes deseja Multiplicar?: ");
                v2 = int.Parse(Console.ReadLine());
                Res = v1 * v2;
                Console.WriteLine(" {0} multiplicado por {1} é: {2}", v1, v2, Res);

                break;

            case 4:

                Console.WriteLine(" Vamos lá {0}, Você escolheu Dividir!", nome);
                Console.Write(" Digite o valor: ");
                v1 = int.Parse(Console.ReadLine());
                Console.Write(" Quantas vezes deseja dividir?: ");
                v2 = int.Parse(Console.ReadLine());
                Res = v1 / v2;
                Console.WriteLine(" {0} dividido por {1} é: {2}", v1,v2,Res);


                break;

            default:
                break;
        }


    }
}