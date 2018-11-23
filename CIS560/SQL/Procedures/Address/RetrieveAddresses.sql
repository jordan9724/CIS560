CREATE OR ALTER PROCEDURE CIS560.RetrieveAddresses
AS

SELECT A.AddressID, A.Line1, A.Line2, A.City, A.[State], A.Zip
FROM CIS560.[Address] A;
GO