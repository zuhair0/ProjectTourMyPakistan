using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryModel
{
    public class TourGuideRegistrationModel
    {
        public int TG_id { get; set; }
        public string? TG_name { get; set; }
        public int TG_cnic { get; set; }
        public string? TG_DOB { get; set; }
        public string? TG_Gender { get; set; }
        public int TG_Mobile { get; set; }
        public int TG_Whatsapp { get; set; }
        public int TG_Landline { get; set; }
        public string? TG_city { get; set; }
        public string? TG_Sector { get; set; }
        public float TG_Longitude { get; set; }
        public float TG_latitude { get; set; }
        public DateTime TG_registration_date { get; set; }
        public DateTime TG_registration_time { get; set; }
        public bool TG_Registration_status {get;set;}
    }
}
