using System.Collections;
using System.Collections.Generic;
using Sc.Server.Weaver.Schema;
using Starcounter;

namespace DevFranchise.JSON
{
    partial class ManageCorporation : Json
    {
        private static string HOME = "NumberOfHomesSold";
        private static string TOTAL_COMMISSION = "TotalCommision";
        private static string AVERAGE_COMMISSION = "AverageCommision";
        private static string TREND = "Trend";
        //public string ParentId;
        public IEnumerable<Office> officesNew { get; set; }

        public IEnumerable<Office> OfficesNew
        {
            get { return officesNew = Db.SQL<Office>("SELECT o FROM DevFranchise.Office o where o.ParentId = ?", Id); }
            set { officesNew = value; }
        }
        //public IEnumerable<Office> OfficesNew =>
        //    Db.SQL<Office>("SELECT o FROM DevFranchise.Office o where o.ParentId = ?", Id);

        void Handle(Input.CreateOfficeEvent action)
        {
            new Office()
            {
                Address = new Address(),
                Name = NewOffice,
                ParentId = Id
            };

            Transaction.Commit();
        }
        void Handle(Input.HomesEvent action)
        {
            OfficesNew = SortBy(HOME);
            Transaction.Commit();
        }
        void Handle(Input.TotalCommissionEvent action)
        {
            OfficesNew = SortBy(TOTAL_COMMISSION);
            Transaction.Commit();
        }
        void Handle(Input.AverageCommissionEvent action)
        {
            OfficesNew = SortBy(AVERAGE_COMMISSION);
            Transaction.Commit();
        }
        void Handle(Input.TrendEvent action)
        {
            OfficesNew = SortBy(TREND);
            Transaction.Commit();
        }

        public IEnumerable<Office> SortBy(string property)
        {
            string query = "SELECT o FROM DevFranchise.Office o where o.ParentId = ? ORDER BY " + property;
            return Db.SQL<Office>(query, Id);
        }
    }
}
