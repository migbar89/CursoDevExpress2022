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
namespace filtroDevExpress.classicmodels
{

    [Persistent(@"offices")]
    public partial class Offices : XPLiteObject
    {
        string fOfficeCode;
        [Key]
        [Size(10)]
        [Persistent(@"officeCode")]
        public string OfficeCode
        {
            get { return fOfficeCode; }
            set { SetPropertyValue<string>(nameof(OfficeCode), ref fOfficeCode, value); }
        }
        string fCity;
        [Size(50)]
        [Persistent(@"city")]
        public string City
        {
            get { return fCity; }
            set { SetPropertyValue<string>(nameof(City), ref fCity, value); }
        }
        string fPhone;
        [Size(50)]
        [Persistent(@"phone")]
        public string Phone
        {
            get { return fPhone; }
            set { SetPropertyValue<string>(nameof(Phone), ref fPhone, value); }
        }
        string fAddressLine1;
        [Size(50)]
        [Persistent(@"addressLine1")]
        public string AddressLine1
        {
            get { return fAddressLine1; }
            set { SetPropertyValue<string>(nameof(AddressLine1), ref fAddressLine1, value); }
        }
        string fAddressLine2;
        [Size(50)]
        [Persistent(@"addressLine2")]
        public string AddressLine2
        {
            get { return fAddressLine2; }
            set { SetPropertyValue<string>(nameof(AddressLine2), ref fAddressLine2, value); }
        }
        string fState;
        [Size(50)]
        [Persistent(@"state")]
        public string State
        {
            get { return fState; }
            set { SetPropertyValue<string>(nameof(State), ref fState, value); }
        }
        string fCountry;
        [Size(50)]
        [Persistent(@"country")]
        public string Country
        {
            get { return fCountry; }
            set { SetPropertyValue<string>(nameof(Country), ref fCountry, value); }
        }
        string fPostalCode;
        [Size(15)]
        [Persistent(@"postalCode")]
        public string PostalCode
        {
            get { return fPostalCode; }
            set { SetPropertyValue<string>(nameof(PostalCode), ref fPostalCode, value); }
        }
        string fTerritory;
        [Size(10)]
        [Persistent(@"territory")]
        public string Territory
        {
            get { return fTerritory; }
            set { SetPropertyValue<string>(nameof(Territory), ref fTerritory, value); }
        }
        [Association(@"EmployeesReferencesOffices")]
        public XPCollection<Employees> EmployeesCollection { get { return GetCollection<Employees>(nameof(EmployeesCollection)); } }
    }

}
