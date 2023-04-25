IF OBJECT_ID(N'Movie.People') IS NULL
BEGIN
   CREATE TABLE Movie.People
   (
      PersonId INT NOT NULL IDENTITY(1, 1),
      FirstName VARCHAR(32) NOT NULL,
      LastName VARCHAR(32) NOT NULL

      CONSTRAINT PK_Movie_People_PersonId PRIMARY KEY CLUSTERED
      (
         PersonId ASC
      )
   );
END;
