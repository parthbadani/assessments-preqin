CREATE PROCEDURE GetInvestors
AS
BEGIN
    SELECT Id, Name, Type, Country, DateAdded, LastUpdated, TotalCommitment
    FROM Investors;
END

GO
