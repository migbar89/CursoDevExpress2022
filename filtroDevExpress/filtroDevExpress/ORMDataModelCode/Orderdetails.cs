﻿using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace filtroDevExpress.classicmodels
{

    public partial class Orderdetails
    {
        public Orderdetails(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}