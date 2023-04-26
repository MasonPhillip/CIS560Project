CREATE OR ALTER PROCEDURE Movie.RatingCompareByMovieName
   @MovieId INT
AS

SELECT M.MovieId, M.MovieName, ISNULL(AVG(R.PersonalRating), 0.00) AS PersonalRatingAverage, M.IMDBRating, M.RottenTomatoesAudienceRating, M.RottenTomatoesCriticRating
FROM Movie.Movies M
INNER JOIN
Movie.PersonalRatings R
On
M.MovieId = R.MovieId
WHERE M.MovieId = @MovieId
GO