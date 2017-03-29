using System.Dynamic;
using Starcounter;

namespace DevFranchise.JSON
{
    partial class ModifyOffice : Json
    {
        public Office _office { get; set; }
        public Corporation _corporation { get; set; }

        public Office Office
        {
            get { return _office = Db.SQL<Office>("SELECT o FROM DevFranchise.Office o WHERE o.Id = ?", OfficeId).First; }
            set { _office = value; }
        }
        public Corporation Corporation
        {
            get
            {
                return
                    _corporation =
                        Db.SQL<Corporation>("SELECT co FROM DevFranchise.Corporation co WHERE co.Id = ?", CorporationId).First;
            }
            set { _corporation = value; }
        }

        void Handle(Input.CorporationAddressEvent action)
        {
            //TODO
            var a = Office.Address;
            Transaction.Commit();
        }

    }
}
