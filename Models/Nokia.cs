namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        
        // Sobrescrever o método "InstalarAplicativo"

        public override void InstalarAplicativo(string WhatsApp)
        {
            Console.WriteLine(value:$"Instalando aplicativo {WhatsApp} em Nokia");
        }
    }
}