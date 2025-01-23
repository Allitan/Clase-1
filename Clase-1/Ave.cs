using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_1
{
    public class Ave
    {
        public string? Nombre { get; set; }
        public string? Especie { get; set; }
        public string? Color { get; set; }
        public double Tamano { get; set; }
        public string? Habitat { get; set; }

        public FamiliaAve Familia { get; set; }

        public Ave()
        {
            Familia = new FamiliaAve();
        }

        public void Imprimir()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Especie: {Especie}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Tamanio: {Tamano}");
            Console.WriteLine($"Habitat: {Habitat}");
            Console.WriteLine($"Familia: {Familia.Nombre}");
            Console.WriteLine($"Numero de especie: {Familia.NumeroEspecie}");
            Console.WriteLine($"Caracteristicas: {Familia.Caracteristicas}");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
