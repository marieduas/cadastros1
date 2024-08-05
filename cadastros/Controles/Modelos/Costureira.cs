namespace Modelos;

public class Costureira : Pessoa
{
    string CPF; 
    string CNPJ;

public string GetCPF ()
    {
        return CPF;
    }
public void SetCNPJ (string cnpj)
    {
        CNPJ=cnpj;
    }
}