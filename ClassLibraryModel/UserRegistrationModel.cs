using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibraryModel
{
    public class UserRegistrationModel
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public long Mobile { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? UserName { get; set; }
        public string? Userrole { get; set; }

        public string? Password { get; set; }


    }
}
//use[Tourism]

//alter proc Sp_UserReg
//@Name varchar(20),
//@Mobile numeric,
//@Email varchar(30),
//@Address varchar(30),
//@UserName varchar(20),
//@Password varchar(20),
//@Userrole varchar(20)
//as begin
//declare @id int
//set @id=(SELECT floor (RAND()*(10000000 - 1) + 1))
//insert into Auth([user_fkid], [UserName], [Password], [userrole], [Reg_datetime])
//values(@id, @UserName, @Password, @Userrole, GETDATE())
//insert into User_registration([ID],[Name], [Mobile], [Email], [Address], [UserName], [Password])
//values(@id, @Name, @Mobile, @Email, @Address, @UserName, @Password)
//end


//create proc Sp_GetRegUsers
//as begin
//select * from User_registration
//end

//create proc Sp_GetUserNameandPass
//as begin
//select Username, Password, UserRole from Auth
//end

//select * from Tour_Company_Registration
//select * from Auth
//select * from User_registration
//create proc Sp_GetCompanyByTourID
//@Tour_guide_id int
//as begin
//select * from Tour_Company_Registration where Tour_guide_id=@Tour_guide_id
//end
