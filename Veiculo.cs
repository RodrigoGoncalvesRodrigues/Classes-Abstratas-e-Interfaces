using System.Security.Cryptography.X509Certificates;

public abstract  class Veiculo
{
    public string Marca { get; set; }
    public string  Modelo { get; set; }

    public Veiculo(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
    }

    public abstract void Ligar();
    public void Desligar()
    {
        Console.WriteLine("O veiculo está desligando");
    }

    
}