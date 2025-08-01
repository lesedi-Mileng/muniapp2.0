USE [MunicpalityDB]
GO

SELECT TOP 10 Service_type, COUNT(*) AS ServiceCount
FROM SERVICE
WHERE duration >0
GROUP BY Service_type
ORDER BY Service_ID DESC;

GO


