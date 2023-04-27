CREATE OR ALTER PROCEDURE Movie.CreateMovie
   @StudioId INT,
   @MovieName NVARCHAR(256),
   @ReleaseDate SMALLINT,
   @IMDBRating DECIMAL(2,1),
   @RottenTomatoesAudienceRating INT,
   @DomesticRevenue BIGINT,
   @InternationlRevenue BIGINT,
   @Cost INT,
   @GenreId INT,
   @RottenTomatoesCriticRating INT,
   @MovieId INT OUTPUT
AS

INSERT Movie.Movies(StudioId, MovieName, [ReleaseDate], IMDBRating, RottenTomatoesAudienceRating, DomesticRevenue, InternationlRevenue, Cost, GenreId, RottenTomatoesCriticRating)
VALUES(@StudioId, @MovieName, @ReleaseDate, @IMDBRating, @RottenTomatoesAudienceRating, @DomesticRevenue, @InternationlRevenue, @Cost, @GenreId, @RottenTomatoesCriticRating);

SET @MovieId = SCOPE_IDENTITY();
GO