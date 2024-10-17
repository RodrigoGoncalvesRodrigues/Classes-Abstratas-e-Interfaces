using System.Security.Cryptography.X509Certificates;

public class Bicicleta:Veiculo,IAceleravel
{
    public   Bicicleta(string marca, string modelo):base(marca, modelo)
    {

    }
        public void Acelerar()
        {
            
            Console.WriteLine($"A bicicleta da marca {Marca} e modelo {Modelo} esta pedalando mais rápido");
        
        }
    public override void Ligar()
    {
        Console.WriteLine($" a bicicleta está pronta para uso ");
    }
}
