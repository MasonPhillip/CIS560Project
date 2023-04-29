CREATE OR ALTER PROCEDURE Movie.CreatePersonalRatings
   @RatingId INT,
   @MovieId INT,
   @AuthorUserId INT,
   @PersonalRating int,
   @RatingDescription NVARCHAR(256)
AS
	IF @RatingId = 0
	INSERT INTO Movie.PersonalRatings(MovieId, AuthorUserId, PersonalRating, RatingDescription)
	VALUES(@MovieId, @AuthorUserId, @PersonalRating, @RatingDescription);
	ELSE
	UPDATE PersonalRatings
	SET
	MovieId = @MovieId,
	AuthorUserId = @AuthorUserId,
	PersonalRating = @PersonalRating,
	RatingDescription = @RatingDescription
	WHERE RatingId = @RatingId
GO