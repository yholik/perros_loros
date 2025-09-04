using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perros_Loros_01.Modelos
{
    public class Perro : Animal
    {
        public string raza {  get; set; }


        public override void mostrarAnimal()
        {
            Console.WriteLine($"Nombre del Animal: {this.nombre} | " +
                  $"Edad: {this.edad} | " +
                  $"Kg Consumidos: {this.kgComidaConsumida} | " +
                  $"Raza: {this.raza}");
        }
    }
}
