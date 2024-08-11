CREATE PROCEDURE GetInvestors
AS
BEGIN
    SELECT i.Id,
    i.Name,
    it.Name [Type],
    i.Address,
    i.DateAdded,
    SUM(c.Amount) [TotalCommitment],
    cy.Name [Currency]
    FROM Investor i
    INNER JOIN InvestorType it
        ON it.Id = i.InvestorTypeId
    INNER JOIN Commitment c
        ON c.InvestorId = i.Id
    INNER JOIN Currency cy
        ON cy.Id = c.CurrencyId
    GROUP BY i.Id,
    i.Name,
    it.Name,
    i.Address,
    i.DateAdded,
    cy.Name
END

GO

CREATE PROCEDURE GetCommitmentsByInvestorId
    @InvestorId INT
AS
BEGIN
    SELECT c.Id,
    ac.Name [AssetClass],
    cy.Name [Currency],
    c.Amount,
    i.Id    [InvestorId]
    FROM Commitment c
    INNER JOIN AssetClass ac
        ON ac.Id = c.AssetClassId
    INNER JOIN Currency cy
        ON cy.Id = c.CurrencyId
    INNER JOIN Investor i
        ON i.Id = c.InvestorId
    WHERE c.Id = @InvestorId
END

GO
