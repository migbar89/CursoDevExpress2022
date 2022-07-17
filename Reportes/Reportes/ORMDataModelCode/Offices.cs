using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace Reportes.Database
{

    public partial class Offices
    {
        public Offices(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
