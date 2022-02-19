/****** Script for SelectTopNRows command from SSMS  ******/



Create View PersonSummary

AS


SELECT 
	   p.PersonID
      ,p.FirstName
      ,p.LastName
      ,p.Age
      ,p.EmailID
      ,p.Gender
      ,p.AddressID
	  , a.Address
	  ,a.City
	  ,a.PostalCode
	  ,po.ProvinceName
	  ,po.ProvinceAbbreviation
  FROM dbo.Person as p
  Left Join Address as a ON a.AddressId = p.AddressID
  Left Join Province as po ON po.ProvinceID = a.ProvinceID


