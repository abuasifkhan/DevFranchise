using System;
using System.Collections;
using System.Collections.Generic;
using DevFranchise.JSON;
using Starcounter;

namespace DevFranchise
{
    [Database]
    public abstract class Element
    {
        //public string Id => Guid.NewGuid().ToString();
        public string Id => this.GetObjectID();
    }

    [Database]
    public class Address
    {
        public string Name;
        public string Street;
        public int Number;
        public int ZipCode;
        public string City;
        public string Country;
        public string FullAddress => $"{Street} {Number}, {ZipCode} {City}, {Country}";

    }

    [Database]
    public class Transaction
    {
        public Address Address;
        public string Data;
        public int SalesPrice;
        public double Commission;
    }

    [Database]
    public class Office 
    {
        //public string Id => Guid.NewGuid().ToString();
        public string Id => this.GetObjectID();
        public Address Address;
        public string Name;
        public string ParentId;
        public int NumberOfHomesSold;
        public int TotalCommision;
        public double AverageCommision;
        public double Trend;
        public Transaction Transaction;
    }

    [Database]
    public class Corporation 
    {
        //public string Id => Guid.NewGuid().ToString();
        public string Id => this.GetObjectID();
        public string Name;
        public Address Address;
        public IEnumerable<Office> Offices =>
            Db.SQL<Office>("SELECT co FROM DevFranchise.Office co where co.ParentId = ?", Id);
    }
    class Program
    {
        
        static void Main()
        {

            Application.Current.Use(new HtmlFromJsonProvider());
            Application.Current.Use(new PartialToStandaloneHtmlProvider());


            Handle.GET("/DeveloperTestFranchise/start", () =>
            {
                return Db.Scope(() =>
                {
                    //var Corporation =
                    //    Db.SQL<Corporation>(
                    //        "SELECT co FROM DevFranchise.Corporation co");
                    var json = new ManageCorporations()
                    {
                        Html = @"/ManageCorporations.html",
                        //Corporations = Corporation
                    };

                    if (Session.Current == null)
                    {
                        Session.Current = new Session(SessionOptions.PatchVersioning);
                    }
                    json.Session = Session.Current;

                    return json;
                });
            });

            Handle.GET("/DeveloperTestFranchise/{?}", (string id) =>
            {
                return Db.Scope(() =>
                {
                    var Corporation =
                        Db.SQL<Corporation>(
                            "SELECT co FROM DevFranchise.Corporation co WHERE co.Id = ?", id).First;
                    var offices = Db.SQL<Office>("SELECT o From DevFranchise.Office o where o.ParentId = ?",id);

                    var json = new ManageCorporation()
                    {
                        Data = Corporation,
                        Html = @"/ManageCorporation.html",
                        //OfficesNew = offices
                    };
                    if (Session.Current == null)
                    {
                        Session.Current = new Session(SessionOptions.PatchVersioning);
                    }
                    json.Session = Session.Current;
                    return json;

                });
            });

            Handle.GET("/DeveloperTestFranchise/franchise/{?}", (string id) =>
            {
                return Db.Scope(() =>
                {
                    var Office =
                        Db.SQL<Office>(
                            "SELECT o FROM DevFranchise.Office o WHERE o.Id = ?", id).First;
                    var Corporation =
                        Db.SQL<Corporation>("SELECT co FROM DevFranchise.Corporation co WHERE co.Id = ?",
                            Office.ParentId).First;
                    var json = new ModifyOffice()
                    {
                        Html = @"/ModifyOffice.html",
                        OfficeId = Office.Id,
                        CorporationId = Office.ParentId
                    };
                    if (Session.Current == null)
                    {
                        Session.Current = new Session(SessionOptions.PatchVersioning);
                    }
                    json.Session = Session.Current;
                    return json;

                });
            });
        }
    }
}