
IF (OBJECT_ID('GetUser') IS NOT NULL)
  DROP PROCEDURE GetUser
GO

CREATE PROCEDURE GetUser  

		@UserId int,
		@FirstName varchar(25) OUTPUT,
		@LastName varchar(25) OUTPUT
AS  
BEGIN  
  
SELECT 
	   UserId
      ,[FirstName] = @FirstName
      ,[LastName] = @LastName
FROM [User]   

WHERE UserId = @UserId

END  


