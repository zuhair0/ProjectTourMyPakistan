using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryModel
{
    public class TourPackageModel
    {
        public int PKG_Id { get; set; }
        public int Tour_Guide_ID { get; set; }
        public string? PKG_Title { get; set; }
        public string? PKG_Duration { get; set; }
        public string? PKG_Pricing { get; set; }
        public string? PKG_From_City { get; set; }
        public string? PKG_To_City { get; set; }

    }
}

//create proc Sp_SaveTourPackages
//@Tour_Guide_ID int, @PKG_Title varchar(100), @PKG_Duration varchar(50), @PKG_Pricing varchar(20),
//@PKG_From_City varchar(100), @PKG_To_City varchar(100)
//as begin
//insert into Tour_package ([Tour_Guide_ID], [PKG_Title], [PKG_Duration], [PKG_Pricing], [PKG_From_City], [PKG_To_City])
//values(@Tour_Guide_ID, @PKG_Title, @PKG_Duration, @PKG_Pricing, @PKG_From_City, @PKG_To_City)
//END

//CREATE PROC Sp_GetPackages
//as BEGIN SELECT * FROM Tour_package
//END

//CREATE PROC Sp_DeletePackages
//@Tour_Guide_ID int
//as BEGIN
//DELETE FROM Tour_package where Tour_Guide_ID=@Tour_Guide_ID
//END