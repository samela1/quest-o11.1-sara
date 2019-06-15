using System;

namespace atividade11._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double saldo = 0;
            Console.WriteLine("Deseja cadastra-se?");
            string cadastro = Console.ReadLine();
            if (cadastro == "sim") ;
            Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Deseja consultar sua conta ?");
            string conta = Console.ReadLine();

            if (conta == "sim") ;
            Console.WriteLine("seu saldo é:" + saldo);

            if (saldo == 0.0)
                Console.WriteLine("Deseja depositar");
            string depositar = Console.ReadLine();

            if (depositar == "sim") ;
            Console.WriteLine("Digite o valor desejado");
            double valor = Double.Parse(Console.ReadLine());
            saldo = saldo + valor;

            Console.WriteLine("Deseja ver o saldo de sua conta?");
            string verificarSaldo = Console.ReadLine();

            if (verificarSaldo == "sim") ;
            Console.WriteLine("Seu saldo é " + saldo);

            Console.WriteLine("Deseja sacar?");
            string sacar = Console.ReadLine();

            if (sacar == "sim") ;
            Console.WriteLine("Digite o valor: ");
            double valorSacar = Double.Parse(Console.ReadLine());
            if (valorSacar <= saldo) 
            { 
            saldo = saldo - valorSacar;
            Console.WriteLine("Saque realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Valor maior que o disponpivel");
            }

            Console.WriteLine("Deseja apagar sua conta?");
            string apagar = Console.ReadLine();

            if (apagar == "sim") ;
            saldo =0;
            nome = "";
            Console.WriteLine("Sua conta foi apgada com sucesso!");


        }
    }
}
