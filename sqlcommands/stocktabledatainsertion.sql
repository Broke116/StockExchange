-- Insert rows into table 'Stock'
INSERT INTO [StockExchange].[dbo].[Stock]
(
 [StockId], [StockName], [LastPrice], [BuyingPrice], [SalesPrice], [DailyLow], [DailyHigh], [DailyChange], [DailyCapacity]   
)
VALUES
(
 1, 'NEKASH', 11.15, 11.15, 11.16, 10.08, 11.41, 10.62, 214.6925
),
(
 2, 'KHYAO', 14.15, 14.15, 14.16, 14.08, 14.41, 10.62, 614.6925
),
(
 3, 'HENER', 35.15, 35.15, 35.16, 35.08, 35.41, -0.40, 4.724
),
(
 4, 'LETKIM', 4.81, 4.81, 4.82, 4.79, 4.94, -2.04, 135.53
),
(
 5, 'ESELS', 17.15, 17.15, 17.16, 16.57, 17.52, -1.54, 257.725
)

GO