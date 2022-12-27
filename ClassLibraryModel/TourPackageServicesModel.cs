using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryModel
{
    public class TourPackageServicesModel
    {
        public int PKG_Id { get; set; }
        public int PKG_Service_ID { get; set; }
        public int Company_Service_ID { get; set; }
    }
}
//create proc Sp_SaveTourPkgServices
//@Company_Service_ID int
//as begin 
//insert into Tour_Package_Services([Company_Service_ID])values(@Company_Service_ID)
//end

//create proc Sp_GetTourPkgServices
//as begin select * from Tour_Package_Services
//end

//create proc Sp_DeleteTourPkgServices
//@Company_Service_ID int
//as begin delete from Tour_Package_Services where Company_Service_ID=@Company_Service_ID
//end