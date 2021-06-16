using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace BuenaVista.Module.BusinessObjects.BuenaVista
{

    public partial class VentaDiaria
    {
        public VentaDiaria(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

       
    }

}
