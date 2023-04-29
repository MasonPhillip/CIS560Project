CREATE OR ALTER PROCEDURE Movie.RetrievePersonalRating
AS

SELECT R.RatingId, R.MovieId, R.AuthorUserId, R.PersonalRating, R.RatingDescription
FROM Movie.PersonalRatings R
ORDER BY R.PersonalRating DESC;
GO