-- Create a new table called 'Stock' in schema 'dbo'
-- Drop the table if it already exists
IF OBJECT_ID('dbo.Stock', 'U') IS NOT NULL
DROP TABLE dbo.Stock
GO

CREATE TABLE dbo.Stock
(
    StockId INT NOT NULL PRIMARY KEY,
    StockName [NVARCHAR](50) NOT NULL,
    LastPrice [NVARCHAR](50) NOT NULL,
    BuyingPrice [NVARCHAR](50) NOT NULL,
    SalesPrice [NVARCHAR](50) NOT NULL,
    DailyLow [NVARCHAR](50) NOT NULL,
    DailyHigh [NVARCHAR](50) NOT NULL,
    DailyChange [NVARCHAR](50) NOT NULL,
    DailyCapacity [NVARCHAR](50) NOT NULL
);
GO