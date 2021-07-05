using System;

namespace ByteBankAlura
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaGabriela = new ContaCorrente();

            contaGabriela.titular = "Gabriela";
            contaGabriela.agencia = 863;
            contaGabriela.numero = 863452;
            contaGabriela.saldo = 100;

            Console.WriteLine("Titular: " + contaGabriela.titular);
            Console.WriteLine("Agencia: " + contaGabriela.agencia);
            Console.WriteLine("Numero: " + contaGabriela.numero);
            Console.WriteLine("Saldo: " + contaGabriela.saldo);
            Console.ReadLine();
        }
    }
}
