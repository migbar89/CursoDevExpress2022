﻿using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace WindowsFormsApp1.devexpress
{

    public partial class Estudiante
    {
        public Estudiante(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
