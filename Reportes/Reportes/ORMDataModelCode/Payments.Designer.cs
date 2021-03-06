//------------------------------------------------------------------------------
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
namespace Reportes.Database
{

    [Persistent(@"payments")]
    public partial class Payments : XPLiteObject
    {
        DateTime fPaymentDate;
        [Persistent(@"paymentDate")]
        public DateTime PaymentDate
        {
            get { return fPaymentDate; }
            set { SetPropertyValue<DateTime>(nameof(PaymentDate), ref fPaymentDate, value); }
        }
        decimal fAmount;
        [Persistent(@"amount")]
        public decimal Amount
        {
            get { return fAmount; }
            set { SetPropertyValue<decimal>(nameof(Amount), ref fAmount, value); }
        }
        public struct CompoundKey1Struct
        {
            [Persistent("customerNumber")]
            public int CustomerNumber { get; set; }
            [Size(50)]
            [Persistent("checkNumber")]
            public string CheckNumber { get; set; }
        }
        [Key, Persistent]
        public CompoundKey1Struct CompoundKey1;
    }

}
