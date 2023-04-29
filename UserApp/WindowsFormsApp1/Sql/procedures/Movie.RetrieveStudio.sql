CREATE OR ALTER PROCEDURE Movie.RetrieveStudio
AS

SELECT S.StudioId, S.StudioName
FROM Movie.Studios S
ORDER BY S.StudioName ASC;
GO