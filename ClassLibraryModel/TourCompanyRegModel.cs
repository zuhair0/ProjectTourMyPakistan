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

//create proc Sp_SaveTourCompanyReg
//@Tour_guide_id int,
//@Company_name varchar(20),
//@Company_sector varchar(20),
//@City_id varchar(10),
//@Company_longitude_latitude int,
//@Company_website varchar(50),
//@Company_Facebook varchar(50),
//@Company_Instagram varchar(50),
//@Company_contact1 numeric,
//@Company_contact2 numeric,
//@Company_Whatsapp numeric,
//@Company_Landline numeric,
//@Tour_Company_Registration_date_time datetime
//as begin
//insert into Tour_Company_Registration( [Tour_guide_id], [Company_name],
//[Company_sector], [City_id], [Company_longitude_latitude], [Company_website],
//[Company_Facebook], [Company_Instagram], [Company_contact1], [Company_contact2], [Company_Whatsapp],
//[Company_Landline], [Tour_Company_Registration_date_time], [Tour_Company_Status])
//values(@Tour_guide_id, @Company_name, @Company_sector, @City_id, @Company_longitude_latitude,
//@Company_website, @Company_Facebook, @Company_Instagram, @Company_contact1, @Company_contact2,
//@Company_Whatsapp, @Company_Landline, @Tour_Company_Registration_date_time, 'true')
//end


//create proc Sp_GetTourCompanyReg
//as begin
//select * from Tour_Company_Registration
//end

//create proc Sp_DeleteTourCompany
//@Company_ID int
//as begin
//delete from Tour_Company_Registration where Company_ID=@Company_ID
//end