
IF (OBJECT_ID('GetPersons') IS NOT NULL)
  DROP PROCEDURE GetPersons
GO

CREATE PROCEDURE GetPersons  

		@PersonID int,
		@FirstName varchar(25) OUTPUT,
		@LastName varchar(25) OUTPUT,
		@Age int = 0  OUTPUT ,
		@EmailID varchar(25) = '' OUTPUT,
		@Gender varchar(25) = '' OUTPUT,
		@AddressID int OUTPUT
AS  
BEGIN  
  
SELECT 
	   [PersonID]
      ,[FirstName] = @FirstName
      ,[LastName] = @LastName
      ,[Age] = @Age 
      ,[EmailID] = @EmailID
      ,[Gender] = @Gender
      ,[AddressID]  = @AddressID
FROM Person   

WHERE PersonID = @PersonID

END  


