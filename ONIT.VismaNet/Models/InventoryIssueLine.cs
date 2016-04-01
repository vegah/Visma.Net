using ONIT.VismaNetApi.Lib;
using ONIT.VismaNetApi.Models.CustomDto;
using ONIT.VismaNetApi.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONIT.VismaNetApi.Models
{
    /*
    	public DtoValue<string> WarehouseId { get; set; }
	public DtoValue<Nullable<decimal>> UnitCost { get; set; }
	public DtoValue<Nullable<decimal>> ExtCost { get; set; }
	public DtoValue<Nullable<decimal>> UnitPrice { get; set; }
	public DtoValue<Nullable<decimal>> ExtPrice { get; set; }
	public DtoValue<Nullable<InventoryTransactionType>> TranType { get; set; }
	public ApiOperation Operation { get; set; }
	public DtoValue<int> LineNumber { get; set; }
	public DtoValue<string> InventoryNumber { get; set; }
	public DtoValue<string> LocationId { get; set; }
	public DtoValue<Nullable<decimal>> Quantity { get; set; }
	public DtoValue<string> UOM { get; set; }
	public DtoValue<string> ReasonCode { get; set; }
	public DtoValue<string> Description { get; set; }
    */
    public class InventoryIssueLine : DtoProviderBase
    {
        public InventoryIssueLine()
        {
            DtoFields.Add("operation", new NotDto<ApiOperation>(ApiOperation.Insert));
        }

        public string warehouseId
        {
            get { return Get<string>(); }
            set { Set(value); }
        }

        public decimal unitCost
        {
            get { return Get<decimal>(); }
            set { Set(value); }
        }

        public decimal extCost
        {
            get { return Get<decimal>(); }
            set { Set(value); }
        }

        public decimal unitPrice
        {
            get { return Get<decimal>(); }
            set { Set(value); }
        }

        public decimal extPrice
        {
            get { return Get<decimal>(); }
            set { Set(value); }
        }

        public InventoryTransactionType tranType
        {
            get { return Get<InventoryTransactionType>(); }
            set { Set(value); }
        }

        public ApiOperation operation
        {
            get { return Get(defaultValue: new NotDto<ApiOperation>(ApiOperation.Insert)).Value; }
            set { Set(new NotDto<ApiOperation>(value)); }
        }

        public int lineNumber
        {
            get { return Get<int>(); }
            set { Set(value); }
        }

        public string inventoryNumber
        {
            get { return Get<string>(); }
            set { Set(value); }
        }

        public string locationId
        {
            get { return Get<string>(); }
            set { Set(value); }
        }

        public decimal quantity
        {
            get { return Get<decimal>(); }
            set { Set(value); }
        }


        public string uOM
        {
            get { return Get<string>(); }
            set { Set(value); }
        }

        public string description
        {
            get { return Get<string>(); }
            set { Set(value); }
        }

        public Location location
        {
            get { return Get<Location>(); }
            private set { Set(value); }
        }

        public Warehouse warehouse
        {
            get { return Get("warehouseId", new Warehouse()); }
            private set { Set(value, key: "warehouseId"); }
        }

        public ReasonCode reasonCode
        {
            get { return Get<ReasonCode>(); }
            private set { Set(value); }
        }

    }
}
