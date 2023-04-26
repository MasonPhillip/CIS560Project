CREATE OR ALTER PROCEDURE Movie.SavePersonalRating
   @RatingId INT,
   @MovieId INT,
   @AuthorUserId INT,
   @PersonalRating int,
   @RatingDescription NVARCHAR(128)
AS

MERGE Movie.PersonalRatings R
USING
      (
         VALUES(@RatingId, @MovieId, @AuthorUserId, @PersonalRating, @RatingDescription)
      ) S(RatingId, MovieId, AuthorUserId, PersonalRating, RatingDescription)
   ON S.RatingId = R.RatingId
WHEN MATCHED AND NOT EXISTS
      (
         SELECT S.MovieId, S.AuthorUserId, S.PersonalRating, S.RatingDescription
         INTERSECT
         SELECT  R.MovieId, R.AuthorUserId, R.PersonalRating, R.RatingDescription
      ) THEN
   UPDATE
   SET
      MovieId = S.MovieId,
      AuthorUserId = S.AuthorUserId,
      PersonalRating = S.PersonalRating,
      RatingDescription = S.RatingDescription
WHEN NOT MATCHED THEN
   INSERT(RatingId, MovieId, AuthorUserId, PersonalRating, RatingDescription)
   VALUES(S.RatingId, S.MovieId, S.AuthorUserId, S.PersonalRating, S.RatingDescription);
GO