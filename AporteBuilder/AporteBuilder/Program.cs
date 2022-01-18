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
            Console.Write("Ingrese el precio del nuevo material: ");
            precio = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la marca de placa base: ");
            marcaplaca = Console.ReadLine();
            Console.Write("Ingrese el modelo de placa base: ");
            modeloplaca = Console.ReadLine();
            Console.Write("Ingrese la marca del procesador: ");
            marcacpu = Console.ReadLine();
            Console.Write("Ingrese el modelo del procesador: ");
            modelocpu = Console.ReadLine();
            Console.Write("Ingrese la marca de la ram: ");
            marcaram = Console.ReadLine();
            Console.Write("Ingrese la frecuencia de la ram ");
            frecuencia = Console.ReadLine();
            Console.Write("Ingrese la capacidad e la ram ");
            capacidadram = Console.ReadLine();


            EnsamblePC builderensamblePC = new EnsamblePC();
            Ensamblado ensamblado = builderensamblePC
                .NombreCliente(nombre)
                .Precio(precio)
                .PlacaBase(placabase)
                .Cpu(procesador)
                .Ram(ram)
                .Almacenamiento(almacenamiento)
                .Gpu(grafica)
                .Refrigeracion(cooler)
                .FuenteEnergia(fuente)
                .Caja(caja)
                .BuildEnsamblado();
            Console.WriteLine(ensamblado.Mostrar());
            Console.ReadKey();

        }
    }
}
