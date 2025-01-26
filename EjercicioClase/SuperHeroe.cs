using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EjercicioClase
{
    public class SuperHeroe
    {
        
        public string nombre { get; set; }
        public string identidadSecreta { get; set; }
        public string ciudad {  get; set; }
        public bool puedeVolar {  get; set; }

        public Superpoder superPoder { get; set; }

        public SuperHeroe() {
            superPoder = new Superpoder();
        }

        public void Imprimir()
        {
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Identidad Secreta: {identidadSecreta}");
            Console.WriteLine($"Ciudad: {ciudad}");
            Console.WriteLine($"Puede volar:: {puedeVolar}");
            Console.WriteLine($"Super poder: {superPoder.nombre}");
            Console.WriteLine($"Descripcion: {superPoder.descripcion}");
            Console.WriteLine($"Nivel: {superPoder.nivel}");
            Console.WriteLine();
            Console.WriteLine();
        }

    }
}
