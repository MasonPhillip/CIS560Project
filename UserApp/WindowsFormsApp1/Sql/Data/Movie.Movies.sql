DECLARE @MoviesStaging TABLE
(
   MovieId INT NOT NULL PRIMARY KEY,
   StudioId INT NOT NULL,
   MovieName NVARCHAR(256) NOT NULL,
   [ReleaseDate] DATE NOT NULL,
   IMDBRating DECIMAL(2,1) NOT NULL,
   RottenTomatoesAudienceRating INT NOT NULL,
   DomesticRevenue BIGINT NOT NULL,
   InternationlRevenue BIGINT NOT NULL,
   Cost INT NOT NULL,
   GenreId INT NOT NULL,
   RottenTomatoesCriticRating INT NOT NULL,
   UNIQUE(MovieName, [ReleaseDate])
);

/***************************** Modify values here *****************************/

WITH SourceCTE(MovieId, StudioId, MovieName, [ReleaseDate], IMDBRating, RottenTomatoesAudienceRating, DomesticRevenue, InternationlRevenue, Cost, GenreId, RottenTomatoesCriticRating) AS
(
	SELECT S.MovieId, ST.StudioId, S.MovieName, S.[ReleaseDate], S.IMDBRating, S.RottenTomatoesAudienceRating, S.S.RottenTomatoesCriticRating, S.DomesticRevenue, S.InternationlRevenue, S.Cost, G.GenreId)
	FROM
	(
		VALUES
			 (N'1',N'1', N'Lord of the Rings: Fellowship of the Ring,N'2001', N'8.8', N'0.95,N'0.91', N'316115420', N'898204420,N'93000000 ', N'6'),
 (N'2',N'2', N'Lord of the Rings: The Two Towers,N'2002', N'8.8', N'0.95,N'0.95', N'342952511', N'947944270,N'94000000 ', N'6'),
 (N'3',N'2', N'Lord of the Rings: Return of the King,N'2003', N'9', N'0.86,N'0.93', N'379427292', N'1147633833,N'94000000 ', N'6'),
 (N'4',N'2', N'Batman Begins,N'2005', N'8.2', N'0.94,N'0.84', N'205343774', N'358858124,N'150000000 ', N'1'),
 (N'5',N'1', N'The Dark Knight,N'2008', N'9', N'0.94,N'0.94', N'534987076', N'1006234167,N'185000000 ', N'1'),
 (N'6',N'1', N'The Dark Knight Rises,N'2012', N'8.4', N'0.9,N'0.87', N'448139099', N'1082228107,N'230000000', N'1'),
 (N'7',N'3', N'Star Wars: The Phantom Menace,N'1999', N'6.5', N'0.59,N'0.51', N'474544677', N'1027044677,N'115000000', N'12'),
 (N'8',N'3', N'Star Wars: Attack of the Clones,N'2002', N'6.6', N'0.56,N'0.65', N'310676740', N'656695615,N'115000000', N'12'),
 (N'9',N'3', N'Star Wars: Revenge of the Sith,N'2005', N'7.6', N'0.66,N'0.79', N'380270577', N'868390560,N'113000000', N'12'),
 (N'10',N'3', N'Star Wars: A New Hope,N'1977', N'8.6', N'0.96,N'0.93', N'460998507', N'775398007,N'11000000', N'12'),
 (N'11',N'3', N'Star Wars: The Empire Strikes Back,N'1980', N'8.7', N'0.97,N'0.94', N'292753960', N'538375067,N'18000000', N'12'),
 (N'12',N'3', N'Star Wars: The Return of the Jedi,N'1983', N'8.3', N'0.94,N'0.83', N'309306177', N'475106177,N'32500000', N'12'),
 (N'13',N'4', N'Star Wars: The Force Awakens,N'2015', N'7.8', N'0.95,N'0.93', N'936662225', N'2071310218,N'245000000', N'12'),
 (N'14',N'4', N'Star Wars: The Last Jedi,N'2017', N'6.9', N'0.42,N'0.91', N'620181382', N'1334407706,N'317000000', N'12'),
 (N'15',N'4', N'Star Wars: The Rise of Skywalker,N'2019', N'6.5', N'0.86,N'0.52', N'515202542', N'1077022372,N'275000000', N'12'),
 (N'16',N'5', N'Psycho,N'1960', N'8.5', N'0.95,N'0.96', N'32000000', N'32052925,N'806947', N'8'),
 (N'17',N'6', N'The Wizard of Oz,N'1939', N'8.1', N'0.89,N'0.98', N'24668669', N'25637669,N'2777000', N'6'),
 (N'18',N'1', N'Casablanca,N'1942', N'8.5', N'0.95,N'0.99', N'4219709', N'4626532,N'950000', N'5'),
 (N'19',N'7', N'Citizen Kane,N'1941', N'8.3', N'0.9,N'0.99', N'1627530', N'1645944,N'839727', N'5'),
 (N'20',N'5', N'The Godfather,N'1972', N'9.2', N'0.98,N'0.97', N'136381073', N'250341816,N'6000000', N'5'),
 (N'21',N'8', N'The Sound of Music,N'1965', N'8.1', N'0.91,N'0.84', N'159287539', N'159437744,N'8200000', N'9'),
 (N'22',N'7', N'It's a Wonderful Life,N'1946', N'8.6', N'0.95,N'0.94', N'1483643', N'8574081,N'3180000', N'4'),
 (N'23',N'1', N'Inception,N'2010', N'8.8', N'0.91,N'0.87', N'292587330', N'836504484,N'160000000', N'12'),
 (N'24',N'9', N'Schindler's List,N'1993', N'9', N'0.97,N'0.98', N'96898818', N'322161245,N'22000000', N'7'),
 (N'25',N'9', N'Jurassic Park,N'1993', N'8.2', N'0.91,N'0.91', N'404214720', N'1109802321,N'63000000', N'2'),
 (N'26',N'9', N'Jurassic Park: The Lost World,N'1997', N'6.5', N'0.51,N'0.54', N'229086679', N'618638999,N'73000000', N'2'),
 (N'27',N'9', N'Jurassic Park III,N'2001', N'5.9', N'0.36,N'0.49', N'181171875', N'368780809,N'93000000', N'2'),
 (N'28',N'10', N'The ShawShank Redemption,N'1994', N'9.2', N'0.98,N'0.91', N'28767189', N'28884504,N'25000000', N'5'),
 (N'29',N'6', N'The Good, The Bad, and the Ugly,N'1966', N'8.8', N'0.97,N'0.97', N'25100000', N'25253887,N'1200000', N'16'),
 (N'30',N'5', N'Forrest Gump,N'1994', N'8.8', N'0.95,N'0.71', N'330455270', N'678226465,N'55000000', N'4'),
 (N'31',N'1', N'The Matrix,N'1999', N'8.7', N'0.85,N'0.88', N'172076928', N'467222728,N'63000000', N'12'),
 (N'32',N'1', N'Goodfellas,N'1990', N'8.7', N'0.97,N'0.96', N'46909721', N'47036784,N'25000000', N'5'),
 (N'33',N'10', N'Seven Samurai,N'1954', N'8.6', N'0.97,N'1', N'318649', N'346258,N'875000', N'1'),
 (N'34',N'5', N'Saving Private Ryan,N'1998', N'8.6', N'0.95,N'0.94', N'217049603', N'482349603,N'70000000', N'15'),
 (N'35',N'5', N'Interstellar,N'2014', N'8.6', N'0.86,N'0.73', N'188020017', N'773430538,N'165000000', N'12'),
 (N'36',N'9', N'Back to the Future,N'1985', N'8.5', N'0.94,N'0.97', N'212836762', N'383336762,N'19000000', N'4'),
 (N'37',N'11', N'The Pianist,N'2002', N'8.5', N'0.96,N'0.95', N'32572577', N'120072577,N'35000000', N'7'),
 (N'38',N'4', N'The Lion King,N'1994', N'8.5', N'0.93,N'0.93', N'422783777', N'968511805,N'45000000', N'2'),
 (N'39',N'9', N'Gladiator,N'2000', N'8.5', N'0.87,N'0.8', N'187705427', N'503162313,N'103000000', N'7'),
 (N'40',N'8', N'Alien,N'1979', N'8.4', N'0.94,N'0.98', N'81900459', N'106285522,N'11000000 ', N'12'),
 (N'41',N'12', N'Django Unchained,N'2012', N'8.4', N'0.92,N'0.87', N'162805434', N'426074373,N'100000000 ', N'16'),
 (N'42',N'13', N'WALL-E,N'2008', N'8.4', N'0.9,N'0.95', N'223808164', N'521311890,N'180000000 ', N'2'),
 (N'43',N'1', N'The Shining,N'1980', N'8.4', N'0.93,N'0.82', N'45634352', N'47346869,N'19000000 ', N'8'),
 (N'44',N'4', N'Avengers: Infinity War,N'2018', N'8.4', N'0.92,N'0.85', N'678815482', N'2052415039,N'321000000 ', N'1'),
 (N'45',N'1', N'Toy Story,N'1995', N'8.3', N'0.92,N'1', N'223225679', N'394436586,N'30000000 ', N'4'),
 (N'46',N'1', N'Joker,N'2019', N'8.3', N'0.88,N'0.69', N'335477657', N'1074458282,N'55000000 ', N'5'),
 (N'47',N'4', N'Avengers: Endgame,N'2019', N'8.3', N'0.9,N'0.94', N'858373000', N'2799439100,N'356000000 ', N'1'),
 (N'48',N'15', N'Memento,N'2000', N'8.4', N'0.94,N'0.93', N'25544867', N'40047078,N'9000000 ', N'10'),
 (N'49',N'10', N'Spiderman: Into the Spider-Verse,N'2018', N'8.3', N'0.93,N'0.97', N'190241310', N'384256930,N'90000000 ', N'1'),
 (N'50',N'1', N'2001: A Space Odyssey,N'1968', N'8.3', N'0.89,N'0.92', N'60481243', N'66076033,N'12000000 ', N'12'),
 (N'51',N'5', N'Vertigo,N'1958', N'8.2', N'0.93,N'0.92', N'7705225', N'7798146,N'2479000 ', N'10'),
 (N'52',N'9', N'To Kill A Mockingbird,N'1962', N'8.2', N'0.93,N'0.93', N'592237', N'599146,N'2000000 ', N'5'),
 (N'53',N'8', N'Die Hard,N'1988', N'8.2', N'0.94,N'0.94', N'83844093', N'141603197,N'28000000 ', N'1'),
 (N'54',N'5', N'Raiders of the Lost Ark,N'1981', N'8.4', N'0.96,N'0.96', N'248159971', N'389925971,N'18000000 ', N'2'),
 (N'55',N'5', N'Indiana Jones and the Temple of Doom,N'1984', N'7.5', N'0.92,N'0.76', N'179870271', N'333107271,N'28000000 ', N'2'),
 (N'56',N'5', N'Indiana Jones and the Last Crusade,N'1989', N'8.2', N'0.94,N'0.8', N'197171806', N'474171806,N'48000000 ', N'2'),
 (N'57',N'5', N'Indiana Jones and the Kingdom of the Cyrstal Skull,N'2008', N'6.2', N'0.53,N'0.77', N'317101119', N'790653942,N'185000000 ', N'2'),
 (N'58',N'8', N'Avatar,N'2009', N'7.9', N'0.82,N'0.82', N'785221649', N'2923706026,N'237000000 ', N'12'),
 (N'59',N'9', N'1917,N'2019', N'8.2', N'0.88,N'0.89', N'159227644', N'384577421,N'95000000 ', N'15'),
 (N'60',N'5', N'Top Gun: Maverick,N'2022', N'8.2', N'0.99,N'0.96', N'718732821', N'1493491858,N'170000000 ', N'1'),
 (N'61',N'5', N'The Wolf of Wall Street,N'2013', N'8.2', N'0.83,N'0.8', N'116900694', N'406878233,N'100000000 ', N'4'),
 (N'62',N'5', N'Shutter Island,N'2010', N'8.2', N'0.77,N'0.68', N'128012934', N'294805697,N'80000000 ', N'10'),
 (N'63',N'10', N'Monty Python and the Holy Grail,N'1975', N'8.1', N'0.95,N'0.98', N'1827696', N'1940906,N'253622', N'4'),
 (N'64',N'16', N'Spider-Man: Homecoming,N'2017', N'7.4', N'0.87,N'0.92', N'334201140', N'880166924,N'175000000 ', N'1'),
 (N'65',N'16', N'Spider-Man: Far from Home,N'2019', N'7.4', N'0.95,N'0.9', N'390532085', N'1131927996,N'160000000 ', N'1'),
 (N'66',N'16', N'Spider-Man: No Way Home,N'2021', N'8.2', N'0.98,N'0.93', N'814115070', N'1921847111,N'200000000', N'1'),
 (N'67',N'1', N'V for Vendetta,N'2005', N'8.1', N'0.9,N'0.73', N'70511035', N'134686457,N'54000000 ', N'1'),
 (N'68',N'4', N'Finding Nemo,N'2003', N'8.1', N'0.86,N'0.99', N'380843261', N'941637960,N'94000000 ', N'4'),
 (N'69',N'6', N'Gone With the Wind,N'1939', N'8.1', N'0.92,N'0.9', N'200882193', N'402382193,N'3977000 ', N'11'),
 (N'70',N'4', N'Inside Out,N'2015', N'8.1', N'0.89,N'0.98', N'356921711', N'858848019,N'175000000 ', N'4'),
 (N'71',N'14', N'Howl's Moving Castle,N'2004', N'8.1', N'0.93,N'0.87', N'6789268', N'237536126,N'24000000 ', N'6'),
 (N'72',N'1', N'Blade Runner,N'1982', N'8.1', N'0.91,N'0.89', N'32914489', N'41722424,N'28000000 ', N'12'),
 (N'73',N'17', N'Hacksaw Ridge,N'2016', N'8.1', N'0.91,N'0.84', N'67209615', N'180563636,N'40000000 ', N'15'),
 (N'74',N'1', N'Mad Max: Fury Road,N'2015', N'8.1', N'0.86,N'0.97', N'67209615', N'180563636,N'40000000 ', N'1'),
 (N'75',N'5', N'How to Train Your Dragon,N'2010', N'8.1', N'0.91,N'0.99', N'217581231', N'494879471,N'165000000 ', N'6'),
 (N'76',N'18', N'Jaws,N'1975', N'8.1', N'0.9,N'0.97', N'265859065', N'476512065,N'7000000 ', N'10'),
 (N'77',N'6', N'Rocky,N'1976', N'8', N'0.69,N'0.92', N'117235147', N'117250402,N'960000 ', N'5'),
 (N'78',N'6', N'The Wizard of Oz,N'1939', N'8', N'0.89,N'0.98', N'24668669', N'25637669,N'2777000 ', N'6'),
 (N'79',N'14', N'The Prestige,N'2006', N'8.5', N'0.92,N'0.76', N'53089891', N'109676311,N'40000000 ', N'5'),
 (N'80',N'16', N'Baby Driver,N'2017', N'7.6', N'0.86,N'0.92', N'107825862', N'226945087,N'34000000 ', N'1'),
 (N'81',N'17', N'La La Land,N'2016', N'8', N'0.81,N'0.91', N'151101803', N'471979503,N'30000000 ', N'9'),
 (N'82',N'1', N'The Batman,N'2022', N'7.8', N'0.87,N'0.85', N'369345583', N'770945583,N'200000000 ', N'1'),
 (N'83',N'16', N'The Social Network,N'2010', N'7.8', N'0.87,N'0.96', N'96962694', N'224920375,N'40000000 ', N'5'),
 (N'84',N'16', N'Casino Royale,N'2006', N'8', N'0.9,N'0.94', N'167445960', N'616505162,N'150000000 ', N'1'),
 (N'85',N'15', N'Donnie Darko,N'2001', N'8', N'0.8,N'0.87', N'1478493', N'7012321,N'6000000 ', N'5'),
 (N'86',N'5', N'Titanic,N'1997', N'7.9', N'0.69,N'0.88', N'674292608', N'2263291560,N'200000000 ', N'7'),
 (N'87',N'8', N'The Princess Bride,N'1987', N'8', N'0.94,N'0.98', N'30857814', N'30902869,N'16000000 ', N'2'),
 (N'88',N'6', N'The Terminator,N'1984', N'8.1', N'0.89,N'1', N'38371200', N'78371200,N'6400000 ', N'12'),
 (N'89',N'10', N'Taxi Driver,N'1976', N'8.2', N'0.93,N'0.96', N'28262574', N'28570902,N'1300000 ', N'5'),
 (N'90',N'8', N'Butch Cassidy and the Sundance Kid,N'1969', N'8', N'0.92,N'0.89', N'102308889', N'102311293,N'6000000 ', N'16'),
 (N'91',N'9', N'King Kong,N'2005', N'7.2', N'0.5,N'0.84', N'218080025', N'556906378,N'207000000 ', N'2'),
 (N'92',N'1', N'Harry Potter and the Philosophers Stone,N'2001', N'7.6', N'0.82,N'0.81', N'318886962', N'1023842938,N'125000000 ', N'6'),
 (N'93',N'1', N'Harry Potter and the Chamber of Secrets,N'2002', N'7.4', N'0.8,N'0.82', N'262641637', N'925668380,N'100000000 ', N'6'),
 (N'94',N'1', N'Harry Potter and the Prisoner of Azkaban,N'2004', N'7.9', N'0.86,N'0.9', N'250105651', N'797660766,N'130000000 ', N'6'),
 (N'95',N'1', N'Harry Potter and the Goblet of Fire,N'2005', N'7.7', N'0.74,N'0.88', N'290469928', N'896815106,N'150000000 ', N'6'),
 (N'96',N'1', N'Harry Potter and the Order of the Phoeniz,N'2007', N'7.5', N'0.81,N'0.78', N'292382727', N'942278045,N'150000000 ', N'6'),
 (N'97',N'1', N'Harry Potter and the Half-Blood Prince,N'2009', N'7.6', N'0.78,N'0.84', N'302334374', N'934519387,N'250000000 ', N'6'),
 (N'98',N'1', N'Harry Potter and the Deathly Hallows Part 1. ,N'2010', N'7.7', N'0.85,N'0.77', N'296374621', N'977070383,N'150000000 ', N'6'),
 (N'99',N'1', N'Harry Potter and the Deathly Hallows Part 2.,N'2011', N'8.1', N'0.89,N'0.96', N'381447587', N'1342359942,N'125000000 ', N'6'),
 (N'100',N'8', N'Minority Report,N'2002', N'7.6', N'0.8,N'0.9', N'132072926', N'358372926,N'102000000 ', N'12'),
 (N'101',N'19', N'Pulp Fiction,N'1994', N'8.9', N'0.96,N'0.92', N'107928762', N'213928762,N'8000000 ', N'5'),
 (N'102',N'1', N'Charlie and the Chocolate Factory,N'2005', N'6.7', N'0.51,N'0.83', N'206459076', N'474968763,N'150000000 ', N'6'),
 (N'103',N'9', N'E.T. the Extra-Terrestrial,N'1982', N'7.9', N'0.72,N'0.99', N'437141279', N'792910554,N'10500000', N'12'),
 (N'104',N'4', N'Pirates of the Caribean: The Curse of the Black Pearl,N'2003', N'8.1', N'0.86,N'0.8', N'305413918', N'654264015,N'140000000 ', N'2'),
	) S(MovieId, StudioId, MovieName, [ReleaseDate], IMDBRating, RottenTomatoesAudienceRating, DomesticRevenue, InternationlRevenue, Cost, GenreId, RottenTomatoesCriticRating)
	INNER JOIN Movie.Studios ST ON ST.StudioId = S.StudioId
	INNER JOIN Movie.Genres G ON G.GenreId = S.GenreId
)

/******************************************************************************/

MERGE Movie.Genres G
USING @GenresStaging S ON S.GenreId = G.GenreId
WHEN MATCHED AND S.Genre <> G.Genre THEN
   UPDATE
   SET Genre = S.Genre
WHEN NOT MATCHED THEN
   INSERT(GenreId, Genre)
   VALUES(S.GenreId, S.Genre);