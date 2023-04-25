CREATE OR ALTER PROCEDURE Movie.CreateRole
   @PersonId INT,
   @MovieId INT,
   @IsDirector BIT,
   @IsActor BIT,
   @AmountPaid INT,
   @RoleId INT OUTPUT
AS

INSERT Movie.Roles(PersonId, MovieId, IsDirector, IsActor, AmountPaid)
VALUES(@PersonId, @MovieId, @IsDirector, @IsActor, @AmountPaid);

SET @RoleId = SCOPE_IDENTITY();
GO