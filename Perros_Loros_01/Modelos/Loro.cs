using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perros_Loros_01.Modelos
{
    public class Loro : Animal
    {
        public string palabraFavorita;

        public void aprenderPalabra(string palabra)
        {
            if(this.palabraFavorita == null){
                palabraFavorita = palabra;
            }

            if(this.palabraFavorita.Length < palabra.Length)
            {
                palabraFavorita = palabra;
            }
        }

        public override void mostrarAnimal()
        {
            Console.WriteLine($"Nombre del Animal: {this.nombre} " +
                  $"Edad: {this.edad} " +
                  $"Kg Consumidos: {this.kgComidaConsumida} " +
                  $"Palabra favorita: {this.palabraFavorita}");
        }
    }
}
