CREATE OR ALTER PROCEDURE Movie.SaveMovie
   @MovieId INT,
   @StudioId INT,
   @MovieName NVARCHAR(256),
   @ReleaseDate SMALLINT,
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
         VALUES(@MovieId, @StudioId, @MovieName, @ReleaseDate, @IMDBRating, @RottenTomatoesAudienceRating, @DomesticRevenue, @InternationlRevenue, @Cost, @GenreId, @RottenTomatoesCriticRating)
      ) S(MovieId, StudioId, MovieName, ReleaseDate, IMDBRating, RottenTomatoesAudienceRating, DomesticRevenue, InternationlRevenue, Cost, GenreId, RottenTomatoesCriticRating)
   ON S.MovieId = M.MovieId
WHEN MATCHED AND NOT EXISTS
      (
         SELECT S.StudioId, S.MovieName, S.ReleaseDate, S.IMDBRating, S.RottenTomatoesAudienceRating , S.DomesticRevenue , S.InternationlRevenue , S.Cost, S.GenreId, S.RottenTomatoesCriticRating
         INTERSECT
         SELECT  M.StudioId, M.MovieName, M.ReleaseDate, M.IMDBRating, M.RottenTomatoesAudienceRating , M.DomesticRevenue , M.InternationlRevenue , M.Cost, M.GenreId, M.RottenTomatoesCriticRating
      ) THEN
   UPDATE
   SET
      StudioId = S.StudioId,
      MovieName = S.MovieName,
      ReleaseDate = S.ReleaseDate,
      IMDBRating = S.IMDBRating,
      RottenTomatoesAudienceRating = S.RottenTomatoesAudienceRating,
      DomesticRevenue = S.DomesticRevenue,
      InternationlRevenue = S.InternationlRevenue,
      Cost = S.Cost,
      GenreId = S.GenreId,
      RottenTomatoesCriticRating = S.RottenTomatoesCriticRating
WHEN NOT MATCHED THEN
   INSERT(MovieId, StudioId, MovieName, ReleaseDate, IMDBRating, RottenTomatoesAudienceRating , DomesticRevenue , InternationlRevenue , Cost, GenreId, RottenTomatoesCriticRating)
   VALUES(S.MovieId, S.StudioId, S.MovieName, S.ReleaseDate, S.IMDBRating, S.RottenTomatoesAudienceRating , S.DomesticRevenue , S.InternationlRevenue , S.Cost, S.GenreId, S.RottenTomatoesCriticRating);
GO
