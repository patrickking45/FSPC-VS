using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _420_476_VIVLIO.Models
{
    public class OfferModels
    {
        public int OfferID { get; set; }
        public int MatiereID { get; set; }

        public int NiveauID { get; set; }

        public int UserID { get; set; }
        public decimal Price { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime PostedDate { get; set; }
        public string Status { get; set; }
        public HttpPostedFileBase Photo { get; set; }
        public string Author_CompanyName { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
    }
}