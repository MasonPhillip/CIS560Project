DECLARE @StudiosStaging TABLE
(
   StudioId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
   StudioName NVARCHAR(32) NOT NULL UNIQUE
);

/***************************** Modify values here *****************************/

INSERT @StudiosStaging(StudioName)
VALUES
	(N'Warner Bros'),
	(N'New Line Cinema'),
	(N'Lucas Film Ltd.'),
	(N'Walt Disney'),
	(N'Paramount Pictures'),
	(N'MGM'),
	(N'RKO Radio Pictures'),
	(N'20th Century Fox'),
	(N'Universal Pictures'),
	(N'Columbia Pictures'),
	(N'Focus Features'),
	(N'Weinstein Co.'),
	(N'Pixar Animation Studios'),
	(N'Buena Vista'),
	(N'NewMarket Film Group'),
	(N'Sony Pictures Entertainment'),
	(N'Lionsgate Films'),
	(N'DiscoVision Universal Pictures'),
	(N'Miramax Films')


/******************************************************************************/

MERGE Movie.Studios ST
USING @StudiosStaging S ON S.StudioId = ST.StudioId
WHEN MATCHED AND S.StudioName <> ST.StudioName THEN
   UPDATE
   SET StudioName = S.StudioName
WHEN NOT MATCHED THEN
   INSERT(StudioName)
   VALUES(S.StudioName);