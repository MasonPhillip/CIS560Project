CREATE OR ALTER PROCEDURE Movie.RatingCompareByMovieName
   @MovieId INT
AS

SELECT M.MovieId, M.MovieName, ISNULL(AVG(R.PersonalRating), 0.00) AS PersonalRatingAverage, ISNULL(AVG(M.IMDBRating), 0.00) AS IMDB, ISNULL(AVG(M.RottenTomatoesAudienceRating), 0.00) AS RottenTomatoesAudienceRating, ISNULL(AVG(M.RottenTomatoesCriticRating), 0.00) AS RottenTomatoesCriticRating
FROM Movie.Movies M
	INNER JOIN Movie.PersonalRatings R ON M.MovieId = R.MovieId
WHERE M.MovieId = @MovieId
GROUP BY M.MovieId, M.MovieName
GO