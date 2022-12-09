using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//comment
namespace ClassLibraryModel
{
    public class TourismModel
    {
        public string? City_name { get; set; }
        public int City_code { get; set; }
         
    }
}

//create proc Sp_SaveCity
//@City_name varchar(50),
//@City_Code int
//as
//begin
//insert into City([City_code], [City_name])values(@City_Code, @City_name)
//end

//create proc Sp_GetCities
//as
//begin
//select * from City
//end

//create proc Sp_DeleteCity
//@City_code int
//as
//begin
//delete from City where City_code=@City_code
//end