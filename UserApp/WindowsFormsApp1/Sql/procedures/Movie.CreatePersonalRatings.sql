CREATE OR ALTER PROCEDURE Movie.CreatePersonalRatings
   @MovieId INT,
   @AuthorUserId INT,
   @PersonalRating int,
   @RatingDescription NVARCHAR(128),
   @RatingId INT OUTPUT
AS

INSERT Movie.PersonalRatings(MovieId, AuthorUserId, PersonalRating, RatingDescription)
VALUES(@MovieId, @AuthorUserId, @PersonalRating, @RatingDescription);

SET @RatingId = SCOPE_IDENTITY();
GO