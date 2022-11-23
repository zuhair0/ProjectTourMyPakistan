using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryModel
{
    public class ViewPointModel
    {
        public int Vp_id { get; set; }
        public int City_id { get; set; }
        public string? VP_Name { get; set; }
        public string? Vp_detail_Eng { get; set; }
        public string? Vp_detail_Urdu { get; set; }
    }
}

//use[Tourism]
//create proc Sp_ViewPoint
//@city_id int,
//@vp_name varchar(20),
//@vp_detail_eng varchar(200),
//@vp_detail_urdu varchar(200)
//as begin
//insert into ViewPoints([City_id], [VP_Name], [Vp_detail_Eng], [Vp_detail_Urdu])
//values(@city_id,
//@vp_name,
//@vp_detail_eng,
//@vp_detail_urdu)
//end

//create proc Sp_GetViewPoints
//as
//begin
//select * from ViewPoints
//end

//create proc Sp_DeleteViewPoint
//@city_id int
//as
//begin
//delete from ViewPoints where City_id=@city_id
//end