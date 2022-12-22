using System;
using System.Collections.Generic;
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


//create proc Sp_UserReg
//@Name varchar(20),
//@Mobile numeric,
//@Email varchar(30),
//@Address varchar(30),
//@UserName varchar(20),
//@Password varchar(20)
//as begin
//insert into User_registration([Name], [Mobile], [Email], [Address], [UserName], [Password])
//values(@Name, @Mobile, @Email, @Address, @UserName, @Password)
//end


//create proc Sp_GetRegUsers
//as begin
//select * from User_registration
//end

//create proc Sp_GetUserNameandPass
//as begin
//select Username, Password from User_registration
//end

//select * from Tour_Company_Registration

//create proc Sp_GetCompanyByTourID
//@Tour_guide_id int
//as begin
//select * from Tour_Company_Registration where Tour_guide_id=@Tour_guide_id
//end
