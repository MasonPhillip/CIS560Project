CREATE OR ALTER PROCEDURE Movie.CreateStudio
   @StudioName NVARCHAR(32),
   @StudioId INT OUTPUT
AS

INSERT Movie.Studios(StudioName)
VALUES(@StudioName);

SET @StudioId = SCOPE_IDENTITY();
GO