﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MenuPrincipal
{
    class Carro
    {
        int cantidad;
        Producto producto;

        public Carro(Producto p, int c)
        {
            producto = p;
            cantidad = c;
        }

        public int Cantidad
        {
            get { return this.cantidad; }
        }

        public Producto getProductoCarro()
        {
            return this.producto;
        }

        public void agregarMasCantidad(int cant)
        {
            this.cantidad += cant;
        }

        public float getPrecioProductoCarro()
        {
            return producto.Precio;
        }

        public override string ToString()
        {
            return producto +" "+ "("+cantidad+")";
        }
    }
}
