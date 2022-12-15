--Stored Procedures--
create proc Sp_AddCompanyMember
@Tour_Member_ID int, @Company_Member_Firstname varchar(20), 
@Company_Member_Lastname varchar(20),@Company_Member_DOB varchar(20), @Company_Member_Gender varchar(20), 
@Company_Member_role varchar(20), @Company_Member_CNIC int, @Company_Member_Whatsapp int, @Company_Member_Mobile int,
@City_ID int, @Company_Member_Sector varchar(20), @Company_Member_registration_datetime date
as begin
insert into Company_Member_Registration([Tour_Member_ID], [Company_Member_Firstname],
[Company_Member_Lastname], [Company_Member_DOB], [Company_Member_Gender], [Company_Member_role],
[Company_Member_CNIC], [Company_Member_Whatsapp], [Company_Member_Mobile], [City_ID], [Company_Member_Sector], 
[Company_Member_registration_datetime], [Company_Member_registration_status])
values(@Tour_Member_ID, @Company_Member_Firstname,
@Company_Member_Lastname, @Company_Member_DOB, @Company_Member_Gender,
@Company_Member_role, @Company_Member_CNIC, @Company_Member_Whatsapp, @Company_Member_Mobile,
@City_ID, @Company_Member_Sector, @Company_Member_registration_datetime, 'true')
end

create proc Sp_GetCompanyMembers
as begin
select * from Company_Member_Registration
end

create proc Sp_DeleteCompanyMember
@Company_Member_ID int
as begin
delete from Company_Member_Registration where Company_Member_ID=@Company_Member_ID
end
-----------------------------
create proc Sp_SaveCompanyPortfolio
@Company_Id int, @Portfolio_details varchar(50)
as
begin
insert into Company_portfolio ([Company_Id], [Portfolio_details])
values(@Company_Id, @Portfolio_details)
end

create proc Sp_GetCompanyPortfolio
as begin
select * from Company_portfolio
end

create proc Sp_DeleteCompanyPortfolio
@Portfolio_id int
as begin
delete from Company_portfolio where Portfolio_id=@Portfolio_id
end
-------------------------
create proc Sp_AddServiceCtegory
@Cat_Type varchar(20),
@Cat_Title varchar(20)
as
begin
insert into Service_Category( [Cat_Type], [Cat_Title])
values(@Cat_Type, @Cat_Title)
end

create proc Sp_GetServiceCategories
as
begin
select * from Service_Category
end

create proc Sp_DeleteServiceCategory
@Cat_ID int
as begin
delete from Service_Category where Cat_ID=@Cat_ID
end
---------------------------
create proc Sp_SaveServiceDetails
@Sub_Cat_ID int,
@Cat_ID int,
@SD_Title varchar(20),
@SD_Price int,
@SD_Quantity int,
@SD_Unit int
as begin
insert into Service_details([Sub_Cat_ID], [Cat_ID], [SD_Title], [SD_Price], [SD_Quantity], [SD_Unit])
values(@Sub_Cat_ID,
@Cat_ID,
@SD_Title,
@SD_Price,
@SD_Quantity,
@SD_Unit)
end

create proc Sp_GetServiceDetails
as begin
select * from Service_details
end

create proc Sp_DeleteServiceDetails
@SD_ID int
as begin
delete from Service_details where SD_ID=@SD_ID
end
----------------------------
create proc Sp_SaveServiceSubCategory
@Cat_ID int,
@Sub_Cat_Title varchar(200)
as
begin
insert into Service_Sub_Category([Cat_ID], [Sub_Cat_Title])
values(@Cat_ID, @Sub_Cat_Title)
end

create proc Sp_GetServiceSubCategory
as
begin
select * from Service_Sub_Category
end

create proc Sp_DeleteServiceSubCategory
@Sub_cat_ID int
as
begin
delete from Service_Sub_Category where Sub_cat_ID=@Sub_cat_ID
end
---------------------------------
create proc Sp_SaveTourCompanyReg
@Tour_guide_id int,
@Company_name varchar(20),
@Company_sector varchar(20),
@City_id varchar(10),
@Company_longitude_latitude int,
@Company_website varchar(50),
@Company_Facebook varchar(50),
@Company_Instagram varchar(50),
@Company_contact1 numeric,
@Company_contact2 numeric,
@Company_Whatsapp numeric,
@Company_Landline numeric,
@Tour_Company_Registration_date_time datetime
as begin
insert into Tour_Company_Registration( [Tour_guide_id], [Company_name],
[Company_sector], [City_id], [Company_longitude_latitude], [Company_website],
[Company_Facebook], [Company_Instagram], [Company_contact1], [Company_contact2], [Company_Whatsapp],
[Company_Landline], [Tour_Company_Registration_date_time], [Tour_Company_Status])
values(@Tour_guide_id, @Company_name, @Company_sector, @City_id, @Company_longitude_latitude,
@Company_website, @Company_Facebook, @Company_Instagram, @Company_contact1, @Company_contact2,
@Company_Whatsapp, @Company_Landline, @Tour_Company_Registration_date_time, 'true')
end


create proc Sp_GetTourCompanyReg
as begin
select * from Tour_Company_Registration
end

create proc Sp_DeleteTourCompany
@Company_ID int
as begin
delete from Tour_Company_Registration where Company_ID=@Company_ID
end
-----------------------------------
create proc Sp_SaveCity
@City_name varchar(50),
@City_Code int
as
begin
insert into City([City_code], [City_name])values(@City_Code, @City_name)
end

create proc Sp_GetCities
as
begin
select * from City
end

create proc Sp_DeleteCity
@City_code int
as
begin
delete from City where City_code=@City_code
end
-----------------------------------
create proc Sp_SaveTourPackages
@Tour_Guide_ID int, @PKG_Title varchar(100), @PKG_Duration varchar(50), @PKG_Pricing varchar(20),
@PKG_From_City varchar(100), @PKG_To_City varchar(100)
as begin
insert into Tour_package ([Tour_Guide_ID], [PKG_Title], [PKG_Duration], [PKG_Pricing], [PKG_From_City], [PKG_To_City])
values(@Tour_Guide_ID, @PKG_Title, @PKG_Duration, @PKG_Pricing, @PKG_From_City, @PKG_To_City)
END

CREATE PROC Sp_GetPackages
as BEGIN SELECT * FROM Tour_package
END

CREATE PROC Sp_DeletePackages
@Tour_Guide_ID int
as BEGIN
DELETE FROM Tour_package where Tour_Guide_ID=@Tour_Guide_ID
END
---------------------------------------
create proc Sp_SaveTourPkgServices
@Company_Service_ID int
as begin 
insert into Tour_Package_Services([Company_Service_ID])values(@Company_Service_ID)
end

create proc Sp_GetTourPkgServices
as begin select * from Tour_Package_Services
end

create proc Sp_DeleteTourPkgServices
@Company_Service_ID int
as begin delete from Tour_Package_Services where Company_Service_ID=@Company_Service_ID
end
---------------------------------------------
create proc Sp_SaveTourPackageViewpoint
@Vp_id int, @field varchar(20)
as
begin
insert into Tour_Package_Viewpoints([VP_ID], [Field])
values(@Vp_id, @field)
end

create proc Sp_GetTourPackageViewpoint
as begin
select * from Tour_Package_Viewpoints
end

create proc Sp_DeleteTourPackageViewpoint
@Tour_PKG_View_ID int
as begin
delete from Tour_Package_Viewpoints where Tour_PKG_View_ID=@Tour_PKG_View_ID
end
----------------------------------
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


create proc Sp_GetRegUsers
as begin
select * from User_registration
end

create proc Sp_GetUserNameandPass
as begin
select Username, Password from User_registration
end

select * from Tour_Company_Registration

create proc Sp_GetCompanyByTourID
@Tour_guide_id int
as begin
select * from Tour_Company_Registration where Tour_guide_id=@Tour_guide_id
end
------------------------------------------------------
create proc Sp_ViewPointImage
@VP_id int,
@VP_image_url varchar(200),
@VP_details_Eng varchar(300)
as
begin
insert into ViewPoint_image([VP_id], [VP_image_url], [Vp_detail_Eng])
values(@VP_id, @VP_image_url, @VP_details_Eng)
end

create proc Sp_GetViewPointImage
as begin
select * from ViewPoint_image
end

create proc Sp_DeleteViewPointImage
@VP_id int
as
begin
delete from ViewPoint_image where VP_id=@VP_id
end
-----------------------------------------

create proc Sp_ViewPoint
@city_id int,
@vp_name varchar(20),
@vp_detail_eng varchar(200),
@vp_detail_urdu varchar(200)
as begin
insert into ViewPoints([City_id], [VP_Name], [Vp_detail_Eng], [Vp_detail_Urdu])
values(@city_id,
@vp_name,
@vp_detail_eng,
@vp_detail_urdu)
end

create proc Sp_GetViewPoints
as
begin
select * from ViewPoints
end

create proc Sp_DeleteViewPoint
@city_id int
as
begin
delete from ViewPoints where City_id=@city_id
end

GO
/****** Object:  StoredProcedure [dbo].[Sp_SaveTourGuideReg]    Script Date: 11/23/2022 4:17:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[Sp_SaveTourGuideReg]
@TG_name varchar(20), @TG_cnic int, @TG_DOB varchar(20), @TG_Gender varchar(20), @TG_Mobile int, @TG_Whatsapp int, 
@TG_Landline int, @TG_city varchar(20), @TG_Sector varchar(20), @TG_Longitude float,
@TG_latitude float, @TG_registration_date date,
@TG_registration_time time
as begin
insert into Tour_Guide_Registration( [TG_name], [TG_cnic], [TG_DOB], [TG_Gender], 
[TG_Mobile], [TG_Whatsapp], [TG_Landline], [TG_city], [TG_Sector], [TG_Longitude], [TG_latitude],
[TG_registration_date], [TG_registration_time], [TG_Registration_status])
values(@TG_name, @TG_cnic, @TG_DOB, @TG_Gender, @TG_Mobile, @TG_Whatsapp,
@TG_Landline, @TG_city, @TG_Sector, @TG_Longitude, @TG_latitude,
@TG_registration_date,
@TG_registration_time, 'true')
end


create proc Sp_GetTourGuides
as begin
select * from Tour_Guide_Registration
end

create proc Sp_DeleteTourGuide
@TG_id int
as begin
delete from Tour_Guide_Registration where TG_id=@TG_id
end
-----------------------------------
CREATE PROC Sp_SaveTourCompanyService
@Category_ID int,
@Sub_Category_ID int,
@SD_ID int
AS BEGIN
INSERT INTO Tour_Company_Service([Category_ID],[Sub_Category_ID],[SD_ID])
VALUES(@Category_ID,@Sub_Category_ID,@SD_ID)
END

CREATE PROC Sp_GetTourCompanyService
AS BEGIN
SELECT * FROM Tour_Company_Service
END

CREATE PROC Sp_DeleteTourCompanyService
@Company_Service_ID int
AS BEGIN
DELETE FROM Tour_Company_Service WHERE Company_Service_ID=@Company_Service_ID
END

create proc Sp_UserReg
@Name varchar(20),
@Mobile numeric,
@Email varchar(30),
@Address varchar(30),
@UserName varchar(20),
@Password varchar(20)
AS BEGIN 
INSERT INTO User_registration([Name],[Mobile],[Email],[Address],[UserName],[Password])
VALUES(@Name,@Mobile,@Email,@Address,@UserName,@Password)
END

CREATE PROC Sp_GetRegUsers
AS BEGIN
SELECT * FROM User_registration
END

