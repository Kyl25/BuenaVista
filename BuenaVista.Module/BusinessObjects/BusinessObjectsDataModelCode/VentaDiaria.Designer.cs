﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace BuenaVista.Module.BusinessObjects.BuenaVista
{

    public partial class VentaDiaria : XPObject
    {
        decimal fTotal;
        public decimal Total
        {
            get { return fTotal; }
            set { SetPropertyValue<decimal>(nameof(Total), ref fTotal, value); }
        }
        DateTime fFecha;
        public DateTime Fecha
        {
            get { return fFecha; }
            set { SetPropertyValue<DateTime>(nameof(Fecha), ref fFecha, value); }
        }
        decimal fPromedio;
        public decimal Promedio
        {
            get { return fPromedio; }
            set { SetPropertyValue<decimal>(nameof(Promedio), ref fPromedio, value); }
        }
        Producto fProducto;
        public Producto Producto
        {
            get { return fProducto; }
            set { SetPropertyValue<Producto>(nameof(Producto), ref fProducto, value); }
        }
        int fCantidad;
        public int Cantidad
        {
            get { return fCantidad; }
            set { SetPropertyValue<int>(nameof(Cantidad), ref fCantidad, value); }
        }
    }

}