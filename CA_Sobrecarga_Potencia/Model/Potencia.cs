namespace CA_Sobrecarga_Potencia.Model
{
    public class Potencia
    {
        public double valor1 { get; set; }

        public double valor2 { get; set; }

        public double CalcularPot (int valor1){

            return System.Math.Pow(valor1, valor1);
        }

        public double CalcularPot (int valor1, int valor2){

            return System.Math.Pow(valor1, valor2);
        }
    }

}