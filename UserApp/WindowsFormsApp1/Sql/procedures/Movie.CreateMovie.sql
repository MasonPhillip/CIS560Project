CREATE OR ALTER PROCEDURE Movie.CreateMovie
   @MovieId INT,
   @StudioId INT,
   @MovieName NVARCHAR(256),
   @ReleaseDate SMALLINT,
   @IMDBRating DECIMAL(2,1),
   @RottenTomatoesAudienceRating INT,
   @DomesticRevenue BIGINT,
   @InternationlRevenue BIGINT,
   @Cost INT,
   @GenreId INT,
   @RottenTomatoesCriticRating INT
AS
	IF @MovieId = 0
	INSERT INTO Movie.Movies(StudioId, MovieName, [ReleaseDate], IMDBRating, RottenTomatoesAudienceRating, DomesticRevenue, InternationlRevenue, Cost, GenreId, RottenTomatoesCriticRating)
	VALUES(@StudioId, @MovieName, @ReleaseDate, @IMDBRating, @RottenTomatoesAudienceRating, @DomesticRevenue, @InternationlRevenue, @Cost, @GenreId, @RottenTomatoesCriticRating)
	ELSE
	UPDATE Movies
	SET
	StudioId = @StudioId,
	MovieName = @MovieName,
	[ReleaseDate] = @ReleaseDate,
	IMDBRating = @IMDBRating,
	RottenTomatoesAudienceRating = @RottenTomatoesAudienceRating,
	DomesticRevenue = @DomesticRevenue,
	InternationlRevenue = @InternationlRevenue,
	Cost = @Cost,
	GenreId = @GenreId,
	RottenTomatoesCriticRating = @RottenTomatoesCriticRating
	WHERE MovieId = @MovieId
Go