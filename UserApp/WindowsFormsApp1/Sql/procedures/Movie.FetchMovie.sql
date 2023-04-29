CREATE OR ALTER PROCEDURE Movie.FetchMovie
	@MovieId INT
AS

SELECT M.StudioId, M.MovieName, M.ReleaseDate, M.IMDBRating, M.RottenTomatoesAudienceRating, M.DomesticRevenue, M.InternationalRevenue, M.Cost, M.GenreId, M.RottenTomatoesCriticRating
FROM Movie.Movies M
WHERE M.MovieId = @MovieId;
GO