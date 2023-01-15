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
        public string? idd { get; set; }
    }
}
//USE[Tourism]
//GO
///****** Object:  StoredProcedure [dbo].[Sp_SaveTourGuideReg]    Script Date: 11/23/2022 4:17:58 AM ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//ALTER proc [dbo].[Sp_SaveTourGuideReg]
//@TG_name varchar(20), @TG_cnic int, @TG_DOB varchar(20), @TG_Gender varchar(20), @TG_Mobile int, @TG_Whatsapp int, 
//@TG_Landline int, @TG_city varchar(20), @TG_Sector varchar(20), @TG_Longitude float,
//@TG_latitude float, @TG_registration_date date,
//@TG_registration_time time
//as begin
//insert into Tour_Guide_Registration( [TG_name], [TG_cnic], [TG_DOB], [TG_Gender], 
//[TG_Mobile], [TG_Whatsapp], [TG_Landline], [TG_city], [TG_Sector], [TG_Longitude], [TG_latitude],
//[TG_registration_date], [TG_registration_time], [TG_Registration_status])

//values(@TG_name, @TG_cnic, @TG_DOB, @TG_Gender, @TG_Mobile, @TG_Whatsapp,
//@TG_Landline, @TG_city, @TG_Sector, @TG_Longitude, @TG_latitude,
//@TG_registration_date,
//@TG_registration_time, 'true')
//end


//create proc Sp_GetTourGuides
//as begin
//select * from Tour_Guide_Registration
//end

//create proc Sp_DeleteTourGuide
//@TG_id int
//as begin
//delete from Tour_Guide_Registration where TG_id=@TG_id
//end