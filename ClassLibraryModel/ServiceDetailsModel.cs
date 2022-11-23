using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryModel
{
    public class ServiceDetailsModel
    {
        public int SD_ID { get; set; }
        public int Sub_Cat_ID { get; set; }
        public int Cat_ID { get; set; }
        public string? SD_Title { get; set; }
        public int SD_Price { get; set; }
        public int SD_Quantity { get; set; }
        public int SD_Unit { get; set; }


    }
}

//use[Tourism]

//create proc Sp_SaveServiceDetails
//@Sub_Cat_ID int,
//@Cat_ID int,
//@SD_Title varchar(20),
//@SD_Price int,
//@SD_Quantity int,
//@SD_Unit int
//as begin
//insert into Service_details([Sub_Cat_ID], [Cat_ID], [SD_Title], [SD_Price], [SD_Quantity], [SD_Unit])
//values(@Sub_Cat_ID,
//@Cat_ID,
//@SD_Title,
//@SD_Price,
//@SD_Quantity,
//@SD_Unit)
//end

//create proc Sp_GetServiceDetails
//as begin
//select * from Service_details
//end

//create proc Sp_DeleteServiceDetails
//@SD_ID int
//as begin
//delete from Service_details where SD_ID=@SD_ID
//end