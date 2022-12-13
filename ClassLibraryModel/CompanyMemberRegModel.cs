using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryModel
{
    public class CompanyMemberRegModel
    {
        public int Company_Member_ID { get; set; }
        public int Tour_Member_ID { get; set; }  //this is Tour_Comapny_ID
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


//use[Tourism]

//create proc Sp_AddCompanyMember
//@Tour_Member_ID int, @Company_Member_Firstname varchar(20), 
//@Company_Member_Lastname varchar(20),@Company_Member_DOB varchar(20), @Company_Member_Gender varchar(20), 
//@Company_Member_role varchar(20), @Company_Member_CNIC int, @Company_Member_Whatsapp int, @Company_Member_Mobile int,
//@City_ID int, @Company_Member_Sector varchar(20), @Company_Member_registration_datetime date
//as begin
//insert into Company_Member_Registration([Tour_Member_ID], [Company_Member_Firstname],
//[Company_Member_Lastname], [Company_Member_DOB], [Company_Member_Gender], [Company_Member_role],
//[Company_Member_CNIC], [Company_Member_Whatsapp], [Company_Member_Mobile], [City_ID], [Company_Member_Sector], 
//[Company_Member_registration_datetime], [Company_Member_registration_status])
//values(@Tour_Member_ID, @Company_Member_Firstname,
//@Company_Member_Lastname, @Company_Member_DOB, @Company_Member_Gender,
//@Company_Member_role, @Company_Member_CNIC, @Company_Member_Whatsapp, @Company_Member_Mobile,
//@City_ID, @Company_Member_Sector, @Company_Member_registration_datetime, 'true')
//end

//create proc Sp_GetCompanyMembers
//as begin
//select * from Company_Member_Registration
//end

//create proc Sp_DeleteCompanyMember
//@Company_Member_ID int
//as begin
//delete from Company_Member_Registration where Company_Member_ID=@Company_Member_ID
//end
