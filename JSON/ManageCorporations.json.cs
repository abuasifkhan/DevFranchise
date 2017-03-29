using System.Collections;
using System.Collections.Generic;
using Starcounter;

namespace DevFranchise.JSON
{
    partial class ManageCorporations : Json
    {
        public IEnumerable<Corporation> Corporations =>
            Db.SQL<Corporation>("SELECT co FROM DevFranchise.Corporation co");
        void Handle(Input.CreateCorporationEvent action)
        {
            new Corporation()
            {
                Name = NewCorporation,
                Address = new Address()

            };
            Transaction.Commit();
        }

        //void Handle(Input.CreateOfficeEvent action)
        //{
        //    new Office()
        //    {
        //        Address = new Address(),
        //        Name = NewOfficeName
        //    };

        //    Transaction.Commit();
        //}
    }
}
