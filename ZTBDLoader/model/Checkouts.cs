using System;

namespace ZTBDLoader.model
{
    public class Checkouts
    {
        public int ID { get; set; }
        public int BibNumber { get; set; }
        public long ItemBarcode { get; set; }
        public string ItemType { get; set; }
        public string Collection { get; set; }
        public string CallNumber { get; set; }
        public DateTime CheckoutDateTime { get; set; }
    }
}
