class Aula06
{
    static void Main()
    {
        /* int n1, n2, n3;

         n1 = 10;
         n2 = 20;
         n3 = 30;

         Console.WriteLine(" \n n1={0} \n n2={1} \n n3={2}\n ", n1,n2,n3);
        */
        int usuario = 1;
        string produto = "Café";
        string cliente = "Joel";
        string adm = "Pedro";
        double valorCompra = 23.90;
        double valorVenda;
        double lucro = 0.65;
        valorVenda = valorCompra+(valorCompra*lucro);

        switch (usuario)
        {
            case 1:
                Console.WriteLine("\n Seja bem vindo {0}!\n", cliente);
                Console.WriteLine(" Relatorio de compra: \n ");
                Console.WriteLine(" PRODUTO....{0,15}", produto);
                Console.WriteLine(" VALOR.........{0,15:c} \n", valorVenda);
                break;

            case 2:
                Console.WriteLine("\n Seja bem vindo {0}!\n",adm);
                Console.WriteLine(" Relatorio de compra: \n ");
                Console.WriteLine(" PRODUTO........{0,15}", produto);
                Console.WriteLine(" VALOR DE VENDA....{0,15:c}", valorVenda);
                Console.WriteLine(" VALOR DE COMPRA...{0,15:c}", valorCompra);
                Console.WriteLine(" LUCRO............{0,15:p}\n",lucro);
                break;

            default:
                break;
        }

        



    }
}