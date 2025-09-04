using Perros_Loros_01.Modelos;
using System;
using System.Collections.Generic;


namespace Perros_Loros_01.utiles
{
    public class GestorAnimales
    {

        private List<Animal> animalesL = new List<Animal>();

        // Punto de inicio del programa, si o si tiene que cargar animales
        public void inicio()
        {
            Console.WriteLine("Bienvenido, soy el gestor de Animales, primero");

            bool confirmado = false;
            while (!confirmado)
            {
                //Ejecutamos cargarAnimales
                this.cargarAnimales();

                //Si la cantidad en la lista es igual o mayor a dos hacemos esta pregunta
                // Si o si se ejecuta dos veces antes de este if
                if (animalesL.Count >= 2)
                {
                    Console.WriteLine("Ingresar mas animales? S/N");
                    string respuesta = Console.ReadLine();
                    respuesta = respuesta.ToLower();


                    //Si pone que no, entonces rompemos el ciclo
                    if (respuesta[0] == 'n')
                    {
                        confirmado = true;
                    }
                }
            }

        }

        // Menu de seleccion de opciones, se utiliza luego de inicio
        public void menuPrincipal()
        {
            bool confirmado = false;
            do
            {
                Console.WriteLine($"1. Mostrar listado de animales nombre y edad \n" +
                    $"2. Cargar animal \n" +
                    $"3. Alimentar animal \n" +
                    $"4. Enseñar palabras a un Loro \n" +
                    $"5. ¿Cuantos años pasaron? \n" +
                    $"6. ¿Cual es la inicial del que mas comió? \n" +
                    $"0. Salir \n"
                    );

                string sOpcion = Console.ReadLine();
                int opcion = int.Parse(sOpcion);
                string nombre;

                switch (opcion)
                {
                    case 1:
                        this.mostrarTodos();
                        break;

                    case 2:
                        this.cargarAnimales();
                        break;

                    case 3:
                        this.alimentarAnimal();
                        break;

                    case 4:
                        Console.WriteLine("Ingresa el nombre del Loro");
                        nombre = Console.ReadLine();

                        // Uso funcion de buscar Loro y lo asigno a un apodo
                        Loro loroBuscado = this.buscarLoro(nombre);

                        // Le enseñamos una palabra
                        Console.WriteLine("Ingresa una palabra:");
                        string palabraAprender = Console.ReadLine();

                        this.enseñarPalabra(loroBuscado, palabraAprender);
                        break;

                    case 5:
                        Console.WriteLine("Escribi el nombre del animal");
                        this.mostrarTodos();
                        nombre = Console.ReadLine();
                        Animal animalBuscado = this.buscarPorInicial(nombre);

                        Console.WriteLine("Cuantos años pasaron?");
                        string sAnios = Console.ReadLine();
                        int anios = int.Parse(sAnios);

                        animalBuscado.crecer(anios);
                        break;
                    case 6:
                        char inicial = this.getMasGloton();
                        Console.WriteLine($"La inicial del animal que mas comio es: {inicial}");
                        break;

                        default:
                        confirmado = true;
                        Console.WriteLine("Gracias por usar el programa");
                        break;

                }
            } while (!confirmado);
        }

        //POR HACER: - PREGUNTAR CUANTOS AÑOS PASARON E INCREMENTAR LA EDAD DEL ANIMAL // HECHO
        //           - MOSTRAR INICIAL DEL ANIMAL QUE MAS COMIO //HECHO

        public void incrementarEdad(Animal animalElegido, int cantidad)
        {
            animalElegido.crecer(cantidad);
        }

        public void alimentarAnimal()
        {
            Animal animalitoElegido = null;

            //Pedimos el nombre del animal
            Console.WriteLine("Escribi el nombre del animal:");
            string nombre = Console.ReadLine();

            //Con funcion buscar lo asignamos a animalitoElegido, si no lo encuentra quedara en null
            animalitoElegido = this.buscarPorInicial(nombre);

            //Si el animal es nulo se retornara automaticamente y pedimos de nuevo el nombre del animal 
            if (animalitoElegido == null)
            {
                Console.WriteLine("No existe el animal");
                return;
            }

            Console.WriteLine($"Elegi cuanto darle de comer:" +
                $"a. 1kg" +
                $"b. 2.5kg" +
                $"c. 3kg");
            string opcionLetra = Console.ReadLine();

            switch (opcionLetra)
            {
                case "a":
                    animalitoElegido.comer(1);
                    break;
                case "b":
                    animalitoElegido.comer(2);
                    break;
                case "c":
                    animalitoElegido.comer(3);
                    break;
                default:
                    Console.WriteLine("Opcion invalida");
                    break;

            }
        }

        public void enseñarPalabra(Loro loroBuscado, string palabra)
        {

            if (loroBuscado != null)
            {
                loroBuscado.aprenderPalabra(palabra);
            }

        }

        public Animal buscarPorInicial(string nombre)
        {
            Animal animBuscado = null;
            foreach (Animal animal in animalesL)
            {
                if (nombre.ToLower() == animal.nombre.ToLower())
                {
                    animBuscado = animal;
                    break;
                }
            }

            return animBuscado;
        }

        public char getMasGloton(){
            Animal buscarGloton = animalesL[0];

            foreach (Animal animal in animalesL) {

                if (animal.kgComidaConsumida > buscarGloton.kgComidaConsumida) {
                    buscarGloton = animal;
                }
            }

            char inicialGloton = buscarGloton.getInicial();

            return inicialGloton;
        }

        public Loro buscarLoro(string nombre)
        {
            Loro loroBuscado = null;

            foreach (Loro animal in animalesL)
            {
                if (nombre.ToLower() == animal.nombre.ToLower())
                {
                    loroBuscado = animal;
                    break;
                }
            }

            return loroBuscado;
        }

        public virtual void cargarAnimales()
        {
            // Si es perro hay que pedirle una raza, la iniciamos en null.
            string raza = null;

            //Pedimos que carguen animales por teclado
            Console.WriteLine($"Carga los animales");

            Console.WriteLine($"Que animal es: Loro - Perro");
            string animalIngresado = Console.ReadLine();
            animalIngresado = animalIngresado.ToLower();

            //Si el animal es un perro, preguntamos la raza, si no lo es quedara raza en null
            if (animalIngresado == "perro")
            {
                Console.WriteLine("De que raza es?");
                raza = Console.ReadLine();
            }

            Console.WriteLine("Nombre?");
            string nombre = Console.ReadLine();

            Console.WriteLine("Edad?");
            string sEdad = Console.ReadLine();
            int edad = int.Parse(sEdad);

            //Creamos el objeto y lo agregamos a la lista del gestor
            switch (animalIngresado)
            {
                case "loro":
                    Loro loro = new Loro() { nombre = nombre, edad = edad };
                    animalesL.Add(loro);
                    break;
                case "perro":
                    Perro perro = new Perro() { nombre = nombre, edad = edad, raza = raza };
                    animalesL.Add(perro);
                    break;
                default:
                    Console.WriteLine("No manejamos ese tipo de animal");
                    break;
            }


        }

        public void mostrarTodos()
        {
            foreach (Animal anim in animalesL)
            {
                anim.mostrarAnimal();
            }
        }


    }
}
