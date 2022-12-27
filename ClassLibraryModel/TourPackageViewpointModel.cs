using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryModel
{
    public class TourPackageViewpointModel
    {
        public int PKG_Id { get; set; }
        public int Tour_PKG_View_ID { get; set; }
        public int Vp_id { get; set; }
        public string? Field { get; set; }
    }
}


//create proc Sp_SaveTourPackageViewpoint
//@Vp_id int, @field varchar(20)
//as
//begin
//insert into Tour_Package_Viewpoints([VP_ID], [Field])
//values(@Vp_id, @field)
//end

//create proc Sp_GetTourPackageViewpoint
//as begin
//select * from Tour_Package_Viewpoints
//end

//create proc Sp_DeleteTourPackageViewpoint
//@Tour_PKG_View_ID int
//as begin
//delete from Tour_Package_Viewpoints where Tour_PKG_View_ID=@Tour_PKG_View_ID
//end
