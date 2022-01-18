using System;
using System.Collections.Generic;
using System.Text;

namespace AporteBuilder
{
    class Ensamblado
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


        public string Nombre 
        { get { return nombre; }
          set { nombre = value; } 
        }
        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public PlacaBase PlacaBase
        {
            get { return placabase; }
            set { placabase = value; }
        }
        public Cpu Cpu
        {
            get { return procesador; }
            set { procesador = value; }
        }
        public Ram Ram
        {
            get { return ram; }
            set { ram = value; }
        }
        public Almacenamiento Almacenamiento
        {
            get { return almacenamiento; }
            set { almacenamiento = value; }
        }
        public Gpu Gpu
        {
            get { return grafica; }
            set { grafica = value; }
        }
        public Refrigeracion Refrigeracion
        {
            get { return cooler; }
            set { cooler = value; }
        }
        public FuenteEnergia FuenteEnergia
        {
            get { return fuente; }
            set { fuente = value; }
        }
        public Caja Caja
        {
            get { return caja; }
            set { caja = value; }
        }


        public String Mostrar()
        {
            return "--ENSAMBLAJE PC--" +
                  "\nNombre del cliente: " + nombre +
                  "\nPrecio: " + precio +
                  "\n--------------------" +
                  "\nCOMPONENTES" +
                  "\nPlaca Base: " + placabase.MarcaPlaca + "Modelo: " + placabase.ModeloPlaca +
                  "\nProcesador: " + procesador.MarcaCpu + "Modelo: " + procesador.ModeloCpu +
                  "\nMemoria Ram: " + ram.MarcaRam + "Frecuencia: " + ram.Frecuencia + "Capacidad: " + ram.CapacidadRam +
                  "\nAlmacenamiento: " + almacenamiento.MarcaAlm + "Tipo: " + almacenamiento.TipoAlm + "Capacidad: " + almacenamiento.CapacidadAlm +
                  "\nTarjeta Gráfica: " + grafica.MarcaGpu + "Modelo: " + grafica.ModeloGpu +
                  "\nRefrigeración: " + cooler.MarcaCool + "Modelo: " + cooler.ModeloCool + "Tipo: " + cooler.TipoCool +
                  "\nFuente de energía: " + fuente.MarcaFuente + "Certificación: " + fuente.Certificacion +
                  "\nCaja: " + caja.MarcaCaja + "Modelo: " + caja.ModeloCaja +
                  "\n--------------------";
                   
        }


    }
}
