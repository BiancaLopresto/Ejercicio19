namespace Ejercicio19.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Celsius;
            double Reaumur;
            double Fahrenheit;

            Console.Write("Ingrese los grados Celsius: ");
            Celsius=int.Parse(Console.ReadLine());

            if (Celsius>30)
            {
                Reaumur = 0.8 * Celsius;
                Console.Write($"Los grados Celsius {Celsius} convertidos a Reaumur son: {Reaumur} grados");
            }
            else
            {
                Fahrenheit = 1.8 * Celsius + 32;
                Console.Write($"Los grados Celsius {Celsius} convertidos a Fahrenheit son: {Fahrenheit} grados");
                
            }

        }
    }
}