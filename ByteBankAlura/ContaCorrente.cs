public class ContaCorrente {
    public string titular;
    public int agencia;
    public int numero;
    public double saldo;

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

}