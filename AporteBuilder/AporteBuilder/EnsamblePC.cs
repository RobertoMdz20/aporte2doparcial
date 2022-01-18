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

        public EnsamblePC Precio(double precio)
        {
            this.precio = precio;
            return this;
        }

        public EnsamblePC PlacaBase(PlacaBase placabase)
        {
            this.placabase = placabase;
            return this;
        }

        public EnsamblePC Cpu(Cpu procesador)
        {
            this.procesador = procesador;
            return this; 
        }
        
        public EnsamblePC Ram(Ram ram)
        {
            this.ram = ram;
            return this;
        }

        public EnsamblePC Almacenamiento(Almacenamiento almacenamiento)
        {
            this.almacenamiento = almacenamiento;
            return this;
        }

        public EnsamblePC Gpu(Gpu grafica)
        {
            this.grafica = grafica;
            return this;
        }

        public EnsamblePC Refrigeracion(Refrigeracion cooler)
        {
            this.cooler = cooler;
            return this;
        }

        public EnsamblePC FuenteEnergia(FuenteEnergia fuente)
        {
            this.fuente = fuente;
            return this;
        }

        public EnsamblePC Caja(Caja caja)
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
