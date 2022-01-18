using System;
using System.Collections.Generic;
using System.Text;

namespace AporteBuilder
{
    class EnsamblePC : IEnsamblePC
    {
        private string nombre;
        private double precio;

        private PlacaBase placabase;
        private Cpu procesador;
        private Ram ram;
        private Almacenamiento almacenamiento;
        private Gpu grafica;
        private Refrigeracion cooler;
        private FuenteEnergia fuente;
        private Caja caja;


        public EnsamblePC NombreCliente(String nombre)
        {
            this.nombre = nombre;
            return this;
        }

        public EnsamblePC PrecioFinal(double precio)
        {
            this.precio = precio;
            return this;
        }

        public EnsamblePC LaPlacaBase(PlacaBase placabase)
        {
            this.placabase = placabase;
            return this;
        }

        public EnsamblePC ElCpu(Cpu procesador)
        {
            this.procesador = procesador;
            return this; 
        }
        
        public EnsamblePC LaRam(Ram ram)
        {
            this.ram = ram;
            return this;
        }

        public EnsamblePC ElAlmacenamiento(Almacenamiento almacenamiento)
        {
            this.almacenamiento = almacenamiento;
            return this;
        }

        public EnsamblePC LaGpu(Gpu grafica)
        {
            this.grafica = grafica;
            return this;
        }

        public EnsamblePC LaRefrigeracion(Refrigeracion cooler)
        {
            this.cooler = cooler;
            return this;
        }

        public EnsamblePC LaFuenteEnergia(FuenteEnergia fuente)
        {
            this.fuente = fuente;
            return this;
        }

        public EnsamblePC LaCaja(Caja caja)
        {
            this.caja = caja;
            return this;
        }

        
        public Ensamblado BuildEnsamblado()
        {
            return new Ensamblado()
            {
                Nombre = this.nombre,
                Precio = this.precio,
                PlacaBase = this.placabase,
                Cpu = this.procesador,
                Ram = this.ram,
                Almacenamiento = this.almacenamiento,
                Gpu = this.grafica,
                Refrigeracion = this.cooler,
                FuenteEnergia = this.fuente,
                Caja = this.caja
            };          
        }
    }
}
