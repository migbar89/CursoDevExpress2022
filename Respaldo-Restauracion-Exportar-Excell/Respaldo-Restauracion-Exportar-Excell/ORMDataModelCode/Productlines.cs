using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace Respaldo_Restauracion_Exportar_Excell.Database
{

    public partial class Productlines
    {
        public Productlines(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
