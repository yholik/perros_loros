using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Perros_Loros_01.Modelos;
using Perros_Loros_01.utiles;
namespace Perros_Loros_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GestorAnimales gerente = new GestorAnimales();

            gerente.inicio();
            bool salir = false;
            while (!salir)
            {
                gerente.menuPrincipal();
                salir = true;
            }

        }
    }
}
