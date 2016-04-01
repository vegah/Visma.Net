using Newtonsoft.Json;
using ONIT.VismaNetApi.Lib;
using ONIT.VismaNetApi.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONIT.VismaNetApi.Models
{
    public class InventoryIssue : DtoProviderBase, IHaveInternalId, IHaveNumber
    {
        public int? inventoryId
        {
            get { return Get<int>(); }
            set { Set(value); }
        }

        public string inventoryNumber
        {
            get { return Get<string>() != null ? Get<string>().Trim() : null; }
            set { Set(value); }
        }

        public List<InventoryIssueLine> issueLines
        {
            get { return Get(defaultValue: new List<InventoryIssueLine>()); }
            set { Set(value); }
        }

        public decimal totalAmount
        {
            get { return Get<decimal>(); }
            private set { Set(value); }
        }

        public decimal controlAmount
        {
            get { return Get<decimal>(); }
            private set { Set(value); }
        }

        public InventoryDocumentStatus status
        {
            get { return Get<InventoryDocumentStatus>(); }
            private set { Set(value); }
        }

        public string referenceNumber
        {
            get { return Get<string>(); }
            set { Set(value); }
        }

        public bool hold
        {
            get { return Get<bool>(); }
            set { Set(value); }
        }

        public DateTime? Date
        {
            get { return Get<DateTime?>(); }
            set { Set(value); }
        }

        public string postPeriod
        {
            get { return Get<string>(); }
            set { Set(value); }
        }

        public string externalReference
        {
            get { return Get<string>(); }
            set { Set(value); }
        }

        public string description
        {
            get { return Get<string>(); }
            set { Set(value); }
        }

        public decimal totalQuantity
        {
            get { return Get<decimal>(); }
            private set { Set(value); }
        }

        public decimal controlQuantity
        {
            get { return Get<decimal>(); }
            set { Set(value); }
        }

        public string batchNumber
        {
            get { return Get<string>(); }
            private set { Set(value); }
        }

        public DateTime lastModifiedDateTime
        {
            get { return Get<DateTime>(); }
            private set { Set(value); }
        }


        [JsonIgnore]
        public int internalId
        {
            get { return inventoryId ?? 0; }
            private set { inventoryId = value; }
        }
        [JsonIgnore]

        public string number => inventoryNumber;

        public void Add(InventoryIssueLine line)
        {
            line.lineNumber = 1;
            if (issueLines.Count > 0)
                line.lineNumber = Math.Max(issueLines.Count + 1,
                    issueLines.Max(x => x.lineNumber) + 1);
            issueLines.Add(line);
        }

        internal override void PrepareForUpdate()
        {
            foreach (var issueLine in issueLines)
            {
                issueLine.operation = ApiOperation.Update;
            }
        }



    }
}
