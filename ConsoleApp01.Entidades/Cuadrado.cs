using System.Text;

namespace ConsoleApp01.Entidades
{
    public class Cuadrado
    {
        private double lado;

        public Cuadrado(double medidaLado)
        {
            lado = medidaLado;
        }

        public double Lado { get => lado; set => lado = value; }
        public double CalcularPerimetro() => Lado * 4;
        public double CalcularArea() => Math.Pow(Lado,2);
        public bool Validar() => Lado > 0;

        public string MostrarInformacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cuadrado de lado {Lado}");
            sb.AppendLine($"Perímetro: {CalcularPerimetro()}");
            sb.AppendLine($"Área: {CalcularArea()}");
            return sb.ToString();

        }
    }
}
