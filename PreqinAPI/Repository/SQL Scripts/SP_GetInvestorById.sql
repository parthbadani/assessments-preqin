CREATE PROCEDURE GetInvestorById
    @Id INT
AS
BEGIN
    SELECT Id, Name, Type, Country, DateAdded, LastUpdated, TotalCommitment
    FROM Investors
    WHERE Id = @Id;
END

GO
