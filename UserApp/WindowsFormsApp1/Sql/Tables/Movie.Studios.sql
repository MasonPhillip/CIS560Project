IF OBJECT_ID(N'Movie.Studios') IS NULL
BEGIN
   CREATE TABLE Movie.Studios
   (
      StudioId INT NOT NULL IDENTITY(1, 1),
      StudioName NVARCHAR(32) NOT NULL UNIQUE,

      CONSTRAINT PK_Movie_Studios_StudioId PRIMARY KEY CLUSTERED
      (
         StudioId ASC
      ),
   );
END;

/****************************
 * Unique Constraints
 ****************************/

IF NOT EXISTS
   (
      SELECT *
      FROM sys.key_constraints kc
      WHERE kc.parent_object_id = OBJECT_ID(N'Movie.Studios')
         AND kc.[name] = N'UK_Movie_Studios_StudioName'
   )
BEGIN
   ALTER TABLE Movie.Studios
   ADD CONSTRAINT [UK_Movie_Studios_StudioName] UNIQUE NONCLUSTERED
   (
      StudioName ASC
   )
END;