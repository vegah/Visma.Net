using ONIT.VismaNetApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONIT.VismaNetApi.Lib.Data
{
    public class InventoryIssueData : BaseCrudDataClass<InventoryIssue>
    {
        public InventoryIssueData(VismaNetAuthorization auth) : base(auth)
        {
            ApiControllerUri = VismaNetControllers.InventoryIssue;
        }

    }
}
