CREATE OR ALTER PROCEDURE Movie.RetrieveMovie
AS

SELECT M.MovieId, M.StudioId, M.MovieName, M.ReleaseDate, M.IMDBRating, M.RottenTomatoesAudienceRating , M.DomesticRevenue , M.InternationalRevenue , M.Cost, M.GenreId, M.RottenTomatoesCriticRating
FROM Movie.Movies M
ORDER BY M.MovieName ASC;
GO