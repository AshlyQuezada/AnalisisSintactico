﻿using System;
using System.Collections.Generic;
using System.Text;

namespace sintatico.Clases
{
    class ErroresSintacticos
    {
        int fila;
        int columna;
        String descripcion;

        public ErroresSintacticos(int fila, int columna, String descripcion)
        {
            this.Fila = fila;
            this.Columna = columna;
            this.Descripcion = descripcion;
        }

        public int Fila { get => fila; set => fila = value; }
        public int Columna { get => columna; set => columna = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}

