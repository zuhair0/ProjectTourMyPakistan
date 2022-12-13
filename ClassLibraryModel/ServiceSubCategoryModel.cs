using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryModel
{
    public class ServiceSubCategoryModel
    {
        public int Sub_cat_ID { get; set; }
        public int Cat_ID { get; set; }
        public string? Sub_Cat_Title { get; set; }
    }
}

//create proc Sp_SaveServiceSubCategory
//@Cat_ID int,
//@Sub_Cat_Title varchar(200)
//as
//begin
//insert into Service_Sub_Category([Cat_ID], [Sub_Cat_Title])
//values(@Cat_ID, @Sub_Cat_Title)
//end

//create proc Sp_GetServiceSubCategory
//as
//begin
//select * from Service_Sub_Category
//end

//create proc Sp_DeleteServiceSubCategory
//@Sub_cat_ID int
//as
//begin
//delete from Service_Sub_Category where Sub_cat_ID=@Sub_cat_ID
//end



