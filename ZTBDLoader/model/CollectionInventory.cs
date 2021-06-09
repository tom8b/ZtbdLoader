using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTBDLoader.model
{
    public class CollectionInventory
    {
        public int ID { get; set; }
        public int BibNum { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public string PublicationYear { get; set; }
        public string Publisher { get; set; }
        public string Subjects { get; set; }
        public string ItemType { get; set; }
        public string ItemCollection { get; set; }
        public string FloatingItem { get; set; }
        public string ItemLocation { get; set; }
        public DateTime ReportDate { get; set; }
        public int ItemCount { get; set; }
    }
}
