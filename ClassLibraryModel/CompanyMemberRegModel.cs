using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryModel
{
    public class CompanyMemberRegModel
    {
        public int Tour_Member_ID { get; set; }
        public string? Company_Member_Firstname { get; set; }
        public string? Company_Member_Lastname { get; set; }
        public int Company_Member_DOB { get; set; }
        public string? Company_Member_Gender { get; set; }
        public string? Company_Member_role { get; set; }
        public int Company_Member_CNIC { get; set; }
        public int Company_Member_Whatsapp { get; set; }
        public int Company_Member_Mobile { get; set; }
        public int City_ID { get; set; }
        public string? Company_Member_Sector { get; set; }
        public DateTime Company_Member_registration_datetime { get; set; }
    }
}
//Don't know the Stored Procedures maazrat :')