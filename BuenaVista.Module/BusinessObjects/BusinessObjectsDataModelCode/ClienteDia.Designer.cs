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

    public partial class ClienteDia : XPObject
    {
        int fCantidad;
        public int Cantidad
        {
            get { return fCantidad; }
            set { SetPropertyValue<int>(nameof(Cantidad), ref fCantidad, value); }
        }
        DateTime fTiempoEspera;
        public DateTime TiempoEspera
        {
            get { return fTiempoEspera; }
            set { SetPropertyValue<DateTime>(nameof(TiempoEspera), ref fTiempoEspera, value); }
        }
    }

}