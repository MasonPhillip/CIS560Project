CREATE OR ALTER PROCEDURE Movie.SaveMovie
   @MovieId INT,
   @StudioId INT,
   @MovieName NVARCHAR(256),
   @ReleseDate DATE,
   @IMDBRating INT,
   @RottenTomatoesAudienceRating INT,
   @DomesticRevenue BIGINT,
   @InternationlRevenue BIGINT,
   @Cost INT,
   @GenreId INT,
   @RottenTomatoesCriticRating INT
AS
MERGE Movie.Movies M
USING
      (
         VALUES(@MovieId, @StudioId, @MovieName, @ReleseDate, @IMDBRating, @RottenTomatoesAudienceRating, @DomesticRevenue, @InternationlRevenue, @Cost, @GenreId, @RottenTomatoesCriticRating)
      ) S(MovieId, StudioId, MovieName, ReleseDate, IMDBRating, RottenTomatoesAudienceRating, DomesticRevenue, InternationlRevenue, Cost, GenreId, RottenTomatoesCriticRating)
   ON S.MovieId = U.MovieId
WHEN MATCHED AND NOT EXISTS
      (
         SELECT S.StudioId, S.MovieName, S.ReleseDate, S.IMDBRating, S.RottenTomatoesAudienceRating , S.DomesticRevenue , S.InternationlRevenue , S.Cost, S.GenreId, S.RottenTomatoesCriticRating
         INTERSECT
         SELECT  U.StudioId, U.MovieName, U.ReleseDate, U.IMDBRating, U.RottenTomatoesAudienceRating , U.DomesticRevenue , U.InternationlRevenue , U.Cost, U.GenreId, U.RottenTomatoesCriticRating
      ) THEN
   UPDATE
   SET
      MovieId = S.MovieId,
      StudioId = S.StudioId,
      MovieName = S.MovieName,
      ReleseDate = S.ReleseDate,
      IMDBRating = S.IMDBRating,
      RottenTomatoesAudienceRating = S.RottenTomatoesAudienceRating,
      DomesticRevenue = S.DomesticRevenue,
      InternationlRevenue = S.InternationlRevenue,
      Cost = S.Cost,
      GenreId = S.GenreId,
      RottenTomatoesCriticRating = S.RottenTomatoesCriticRating
WHEN NOT MATCHED THEN
   INSERT(MovieId, StudioId, MovieName, ReleseDate, IMDBRating, RottenTomatoesAudienceRating , DomesticRevenue , InternationlRevenue , Cost, GenreId, RottenTomatoesCriticRating)
   VALUES(S.MovieId, S.StudioId, S.MovieName, S.ReleseDate, S.IMDBRating, S.RottenTomatoesAudienceRating , S.DomesticRevenue , S.InternationlRevenue , S.Cost, S.GenreId, S.RottenTomatoesCriticRating);
GO
