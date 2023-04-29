CREATE OR ALTER PROCEDURE Movie.FetchStudio
	@StudioId INT
AS

SELECT S.StudioName
FROM Movie.Studios S
WHERE S.StudioId = @StudioId
GO