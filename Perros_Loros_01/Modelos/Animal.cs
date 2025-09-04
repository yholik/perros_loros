using System;

namespace Perros_Loros_01.Modelos
{
    public class Animal
    {
        public string nombre { get; set; }
        public int edad { get; set; }
        public double kgComidaConsumida { get; private set; }




        public void comer(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    this.kgComidaConsumida += 1;
                    break;
                case 2:
                    this.kgComidaConsumida += 2.5;
                    break;
                    case 3:
                    this.kgComidaConsumida += 3;
                    break;
                default:
                    break;
            }
        }

        public char getInicial()
        {
           char inicial = this.nombre[0];

            return inicial;
        }

        public void crecer(int cantidad) {
            this.edad += cantidad;
        }
        public virtual void mostrarAnimal()
        {
            Console.WriteLine($"Nombre del Animal: {this.nombre} - " +
                  $"Edad: {this.edad} - " +
                  $"Kg Consumidos: {this.kgComidaConsumida}");
        }
    }
}
