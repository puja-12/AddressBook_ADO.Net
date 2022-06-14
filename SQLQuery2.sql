create procedure SpAddressBookUpdate
(
	@FirstName varchar(50),
	@LastName varchar(50),
	@Address varchar(50),
	@City varchar(50),
	@State varchar(50),
	@Zip varchar(50),
	@Email varchar(50),
	 @phone bigint,
   @Type varchar(50)
)
as
begin
update  AddressBook set FirstName=@FirstName,LastName=@LastName,Address=@Address,City=@City,State=@State,Zip=@Zip,
Email=@Email,phone=@Phone,@Type=Type where FirstName='Pooja';
SET NOCOUNT ON;
END
GO

SELECT FirstName,LastName,Address,City,State,Zip,Email,phone,Type from AddressBook