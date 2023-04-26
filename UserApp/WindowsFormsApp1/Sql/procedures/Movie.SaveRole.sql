CREATE OR ALTER PROCEDURE Movie.SaveRole
   @RoleId INT,
   @PersonId INT,
   @MovieId INT,
   @IsDirector BIT,
   @IsActor BIT,
   @AmountPaid INT
AS

MERGE Movie.Roles R
USING
      (
         VALUES(@RoleId, @PersonId, @MovieId, @IsDirector, @IsActor, @AmountPaid)
      ) S(RoleId, PersonId, MovieId, IsDirector, IsActor, AmountPaid)
   ON S.RoleId = R.RoleId
WHEN MATCHED AND NOT EXISTS
      (
         SELECT S.PersonId, S.MovieId, S.IsDirector, S.IsActor, S.AmountPaid
         INTERSECT
         SELECT  R.PersonId, R.MovieId, R.IsDirector, R.IsActor, R.AmountPaid
      ) THEN
   UPDATE
   SET
      PersonId = S.PersonId,
      MovieId = S.MovieId,
      IsDirector = S.IsDirector,
      IsActor = S.IsActor,
      AmountPaid = S.AmountPaid
WHEN NOT MATCHED THEN
   INSERT(RoleId, PersonId, MovieId, IsDirector, IsActor, AmountPaid)
   VALUES(S.RoleId, S.PersonId, S.MovieId, S.IsDirector, S.IsActor, S.AmountPaid);
GO