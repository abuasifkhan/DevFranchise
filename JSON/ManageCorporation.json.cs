using System.Collections;
using System.Collections.Generic;
using Sc.Server.Weaver.Schema;
using Starcounter;

namespace DevFranchise.JSON
{
    partial class ManageCorporation : Json
    {
        //public string ParentId;
        public IEnumerable<Office> OfficesNew =>
            Db.SQL<Office>("SELECT o FROM DevFranchise.Office o where o.ParentId = ?", Id);

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
    }
}
