namespace Groc.Models
{
    public class OrderLineItem : BaseModel {
        public int OrderId {get;set;}

        public int ItemId {get;set;}

        public float ItemQuantity {get;set;}

        public float Price {get;set;}

        public virtual Inventory Item {get;set;}

        public virtual Order Order {get;set;}
    }
}