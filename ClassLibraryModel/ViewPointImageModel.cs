using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryModel
{
    public class ViewPointImageModel
    {
        public int VP_image_id { get; set; }
        public int VP_id { get; set; }
        public string? VP_image_url { get; set; }
        public string? Vp_detail_Eng { get; set; }
    }
}

//use[Tourism]
//create proc Sp_ViewPointImage
//@VP_id int,
//@VP_image_url varchar(200),
//@VP_details_Eng varchar(300)
//as
//begin
//insert into ViewPoint_image([VP_id], [VP_image_url], [Vp_detail_Eng])
//values(@VP_id, @VP_image_url, @VP_details_Eng)
//end

//create proc Sp_GetViewPointImage
//as begin
//select * from ViewPoint_image
//end

//create proc Sp_DeleteViewPointImage
//@VP_id int
//as
//begin
//delete from ViewPoint_image where VP_id=@VP_id
//end

