select * from dbo.Product
Go
select * from dbo.Customer
Go
select * from dbo.Customer Where Id = 2
Go
delete dbo.Customer where Id = 3
Go

INSERT dbo.Product([Name],[Price],[Count])
VALUES('saye',200,3)
Go
INSERT INTO dbo.Customer (Username,[Password],[FirstName],[LastName],[Email],[PhoneNumber]) 
VALUES ('zahra_s','zs','zahra', 'samimi','zahrasamimi49@gmail.com','09391233807')
Go

EXEC dbo.CustomerIns 
	@Username = 'zahra_s',
	@Password  = 'zs',
	@FirstName ='zahra', 
	@LastName ='samimi',
	@Email ='zahrasamimi49@gmail.com',
	@PhoneNumber = '09391233807',
	@GenderId  =2

Go
ALTER PROC CustomerIns
(
	@Username NVARCHAR(100),
	@Password NVARCHAR(100),
	@FirstName NVARCHAR(100), 
	@LastName NVARCHAR(100),
	@Email NVARCHAR(100),
	@PhoneNumber NVARCHAR(100),
	@GenderId SMALLINT
)
AS
BEGIN
	INSERT INTO dbo.Customer (Username,[Password],[FirstName],[LastName],[Email],[PhoneNumber],[GenderId]) 
	VALUES (@Username,@Password,@FirstName, @LastName,@Email,@PhoneNumber,@GenderId)	
END