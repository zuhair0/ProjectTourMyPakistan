using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryModel
{
    public class ServiceCategoryModel
    {
        public int Cat_ID { get; set; }
        public string? Cat_Type { get; set; }
        public string? Cat_Title { get; set; }
    }
}
//create proc Sp_AddServiceCtegory
//@Cat_Type varchar(20),
//@Cat_Title varchar(20)
//as
//begin
//insert into Service_Category( [Cat_Type], [Cat_Title])
//values(@Cat_Type, @Cat_Title)
//end

//create proc Sp_GetServiceCategories
//as
//begin
//select * from Service_Category
//end

//create proc Sp_DeleteServiceCategory
//@Cat_ID int
//as begin
//delete from Service_Category where Cat_ID=@Cat_ID
//end