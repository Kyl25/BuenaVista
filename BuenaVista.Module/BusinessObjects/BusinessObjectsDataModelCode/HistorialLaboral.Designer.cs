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

    public partial class HistorialLaboral : XPObject
    {
        Empleados fEmpleado;
        [Association(@"HistorialLaboralReferencesEmpleados")]
        public Empleados Empleado
        {
            get { return fEmpleado; }
            set { SetPropertyValue<Empleados>(nameof(Empleado), ref fEmpleado, value); }
        }
        DateTime fFechaInicio;
        public DateTime FechaInicio
        {
            get { return fFechaInicio; }
            set { SetPropertyValue<DateTime>(nameof(FechaInicio), ref fFechaInicio, value); }
        }
        DateTime fFechaSalida;
        public DateTime FechaSalida
        {
            get { return fFechaSalida; }
            set { SetPropertyValue<DateTime>(nameof(FechaSalida), ref fFechaSalida, value); }
        }
        decimal fSalarioInicial;
        public decimal SalarioInicial
        {
            get { return fSalarioInicial; }
            set { SetPropertyValue<decimal>(nameof(SalarioInicial), ref fSalarioInicial, value); }
        }
        decimal fSalarioActual;
        public decimal SalarioActual
        {
            get { return fSalarioActual; }
            set { SetPropertyValue<decimal>(nameof(SalarioActual), ref fSalarioActual, value); }
        }
        DateTime fUltimoAumento;
        public DateTime UltimoAumento
        {
            get { return fUltimoAumento; }
            set { SetPropertyValue<DateTime>(nameof(UltimoAumento), ref fUltimoAumento, value); }
        }
    }

}
