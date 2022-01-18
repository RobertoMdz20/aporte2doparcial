using System;

namespace AporteBuilder
{
    class Program
    {
        static void Main(string[] args)
        {

            String nombre;
            double precio;
            
            PlacaBase placabase;
            String marcaplaca;
            String modeloplaca;

            Cpu procesador;
            String marcacpu;
            String modelocpu;

            Ram ram;
            String marcaram;
            String frecuencia;
            String capacidadram;

            Almacenamiento almacenamiento;
            String marcaalm;
            String tipoalm;
            String capacidadalm;

            Gpu grafica;
            String marcagpu;
            String modelogpu;

            Refrigeracion cooler;
            String marcacool;
            String tipocool;
            String modelocool;

            FuenteEnergia fuente;
            String marcafuente;
            String certificacion;

            Caja caja;
            String marcacaja;
            String modelocaja;

            Console.Write("Ingrese el nombre del cliente: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese el precio final del pc: ");
            precio = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Ingrese la marca de placa base: ");
            marcaplaca = Console.ReadLine();
            Console.Write("Ingrese el modelo de placa base: ");
            modeloplaca = Console.ReadLine();
            placabase = new PlacaBase(marcaplaca, modeloplaca);

            Console.Write("Ingrese la marca del procesador: ");
            marcacpu = Console.ReadLine();
            Console.Write("Ingrese el modelo del procesador: ");
            modelocpu = Console.ReadLine();           
            procesador = new Cpu(marcacpu, modelocpu);
            
            Console.Write("Ingrese la marca de la ram: ");
            marcaram = Console.ReadLine();
            Console.Write("Ingrese la frecuencia de la ram: ");
            frecuencia = Console.ReadLine();
            Console.Write("Ingrese la capacidad e la ram: ");
            capacidadram = Console.ReadLine();
            ram = new Ram(marcaram, frecuencia, capacidadram);

            Console.Write("Ingrese la marca del almacenamiento: ");
            marcaalm = Console.ReadLine();
            Console.Write("Ingrese el tipo de almacenamiento: ");
            tipoalm = Console.ReadLine();
            Console.Write("Ingrese la capacidad de almacenamiento: ");
            capacidadalm = Console.ReadLine();
            almacenamiento = new Almacenamiento(marcaalm, tipoalm, capacidadalm);

            Console.Write("Ingrese la marca de la tarjeta gráfica: ");
            marcagpu = Console.ReadLine();
            Console.Write("Ingrese el modelo de la tarjeta gráfica:");
            modelogpu = Console.ReadLine();
            grafica = new Gpu(marcagpu, modelogpu);

            Console.Write("Ingrese la marca de de la refrigeración: ");
            marcacool = Console.ReadLine();
            Console.Write("Ingrese el modelo de la refrigeración:");
            modelocool = Console.ReadLine();
            Console.Write("Ingrese el tipo de refrigeración: ");
            tipocool = Console.ReadLine();
            cooler = new Refrigeracion(marcacool, tipocool, modelocool);

            Console.Write("Ingrese la marca de la fuente de alimentación:");
            marcafuente = Console.ReadLine();
            Console.Write("Ingrese la certificación de la fuente:");
            certificacion = Console.ReadLine();
            fuente = new FuenteEnergia(marcafuente, certificacion);

            Console.Write("Ingrese la marca de la caja:");
            marcacaja = Console.ReadLine();
            Console.Write("Ingrese el modelo de la caja:");
            modelocaja = Console.ReadLine();
            caja = new Caja(marcacaja, modelocaja);

            Console.Clear();

            EnsamblePC builderensamblePC = new EnsamblePC();
            Ensamblado ensamblador = builderensamblePC
                .NombreCliente(nombre)
                .PrecioFinal(precio)
                .LaPlacaBase(placabase)
                .ElCpu(procesador)
                .LaRam(ram)
                .ElAlmacenamiento(almacenamiento)
                .LaGpu(grafica)
                .LaRefrigeracion(cooler)
                .LaFuenteEnergia(fuente)
                .LaCaja(caja)
                .BuildEnsamblado();
            Console.WriteLine(ensamblador.Mostrar());
            Console.ReadKey();

        }
    }
}
