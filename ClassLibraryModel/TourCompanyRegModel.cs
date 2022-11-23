using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryModel
{
    public class TourCompanyRegModel
    {
        public int Company_ID { get; set; }
        public int Tour_guide_id { get; set; }
        public string? Company_name { get; set; }
        public string? Company_sector { get; set; }
        public int City_id { get; set; }
        public float Company_longitude_latitude { get; set; }
        public string? Company_website { get; set; }
        public string? Company_Facebook { get; set; }
        public string? Company_Instagram { get; set; }
        public int Company_contact1 { get; set; }
        public int Company_contact2 { get; set; }
        public int Company_Whatsapp { get; set; }
        public int Company_Landline { get; set; }
        public DateTime Tour_Company_Registration_date_time { get; set; }
    }
}
