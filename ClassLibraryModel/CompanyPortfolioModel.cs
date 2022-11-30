using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryModel
{
    public class CompanyPortfolioModel
    {
        public int Portfolio_id { get; set; }
        public int Company_Id { get; set; }

        public string? Portfolio_details { get; set; }

    }
}

//create proc Sp_SaveCompanyPortfolio
//@Company_Id int, @Portfolio_details varchar(50)
//as
//begin
//insert into Company_portfolio ([Company_Id], [Portfolio_details])
//values(@Company_Id, @Portfolio_details)
//end

//create proc Sp_GetCompanyPortfolio
//as begin
//select * from Company_portfolio
//end

//create proc Sp_DeleteCompanyPortfolio
//@Portfolio_id int
//as begin
//delete from Company_portfolio where Portfolio_id=@Portfolio_id
//end