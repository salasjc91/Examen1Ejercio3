namespace Examen1Ejercio3
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //solicita los datos al usuario, indicando su unidad de medida.
            Console.WriteLine("Ingrese la masa 1 (en kg):");
            double masa1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la masa 2 (en kg):");
            double masa2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la distancia entre las masas (en metros):");
            double distancia = Convert.ToDouble(Console.ReadLine());


            // Crea una nueva instancia de la clase FuerzaGravitacional . Esto crea un nuevo objeto de tipo FuerzaGravitacional y almacena una referencia  en la variable fuerza.
            FuerzaGravitacional fuerza = new FuerzaGravitacional();
            fuerza.Masa1 = masa1;
            fuerza.Masa2 = masa2;
            fuerza.Distancia = distancia;
            
            
            //Llama al método CalcularFuerza del objeto fuerza para calcular la fuerza de atracción entre las masas, y el resultado se almacena en la variable fuerzaAtraccion.

            double fuerzaAtraccion = fuerza.CalcularFuerza();
            Console.WriteLine($"La fuerza de atracción entre las masas es: {fuerzaAtraccion} N");
        }
    }
    
}
