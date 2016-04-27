using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _420_476_VIVLIO.Models
{
    public class UserModels
    {
        public int UserID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string CollegeName { get; set; }
        public int Rating_Client { get; set; }
        public int Rating_Vendeur { get; set; }
        public string Name { get; set; }
        public string Prenom { get; set; }
        public HttpPostedFileBase Photo { get; set; }
        public string Type { get; set; }
    }
}