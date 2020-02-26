﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace MenuPrincipal
{
    class Producto
    {
        string tipo;
        string marca;
        string envase;
        float precio;
        static int id=0;
        int idpropio = 0;

        
        public Producto(string tipo, string marca, string envase, float precio)
        {
            this.tipo = tipo;
            this.marca = marca;
            this.envase = envase;
            this.precio = precio;
            id = id+1;
            idpropio = id;
        }
        
        
        public string Tipo
        {    
            get { return this.tipo; }
        }

        public string Marca
        {   
            get { return this.marca; }
        }

        public string Envase
        {   
            get { return this.envase; }
        }

        public float Precio
        {   
            get { return this.precio; }
        }

        public int Id
        {
            get { return this.idpropio; }
        }
        
        override public string ToString()//OVERRIDE PARA IMPRIMIR EL ID, TIPO MARCA ENVASE Y PRECIO DEL PRODUCTO, ESTO SE VA A USAR EN LA SIMULACION DE LA COMPRA
        {
            return idpropio+")"+tipo+" "+marca+" ("+envase+") ";
        }
    }
}
