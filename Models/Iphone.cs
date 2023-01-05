namespace DesafioPOO.Models
{
    // Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        
        // Sobrescrever o método "InstalarAplicativo"

        public override void InstalarAplicativo(string Facebook)
        {
            Console.WriteLine(value:$"Instalando aplicativo {Facebook} em iphone");
        }
    }
}