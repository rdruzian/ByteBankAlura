using System;

public class ContaCorrente {
    public string titular;
    public int agencia;
    public int numero;
    public double saldo;


    /// <summary>
    /// Método Sacar para realizar o saque de sua conta, deve-se receber apenas o valor que será sacado.
    /// Retorna um boolenao para indicar se foi realizado a transação corretamente ou não
    /// </summary>
    /// <param name="valor"></param>
    /// <returns></returns>
    public bool Sacar (double valor)
    {
        if(valor >= this.saldo)
        {
            this.saldo -= valor;
            return true;
        }
        else
        {
            return false;
        }
    }

    /// <summary>
    /// Método para realizar um Depósito na conta, deve-se passar apenas o valor que erá depositado
    /// </summary>
    /// <param name="valor"></param>
    public void Depositar(double valor)
    {
        this.saldo += valor;
    }

    /// <summary>
    /// Método para realizar transferências entre contas, recebendo o valor a ser debitado e a conta que receberá o valor
    /// </summary>
    /// <param name="valor"></param>
    /// <param name="conta"></param>
    public void Transferir(double valor, ContaCorrente conta)
    {
        if (this.saldo < valor)
        {
            Console.WriteLine("Saldo insuficiente para realizar a transação");
            return;
        }
        else
        {
            this.Sacar(valor);
            conta.Depositar(valor);
        }
    }
}