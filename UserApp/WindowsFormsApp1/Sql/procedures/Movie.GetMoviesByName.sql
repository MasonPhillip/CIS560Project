CREATE OR ALTER PROCEDURE Movie.GetMoviesByName
	@MovieName NVARCHAR(256)
AS

SELECT M.MovieId, M.StudioId, M.MovieName, M.ReleaseDate, M.IMDBRating, M.RottenTomatoesAudienceRating , M.DomesticRevenue , M.InternationalRevenue , M.Cost, M.GenreId, M.RottenTomatoesCriticRating
FROM Movie.Movies M
WHERE M.MovieName LIKE '%' + @MovieName + '%';
GO