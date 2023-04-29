DECLARE @UsersStaging TABLE
(
    UserId INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
    Username NVARCHAR(32) NOT NULL,
    [Password] NVARCHAR(32) NOT NULL,
    [Name] NVARCHAR(32) NOT NULL,
    RecoveryEmail NVARCHAR(32) NOT NULL
);

/***************************** Modify values here *****************************/

INSERT @UsersStaging(UserName, [Password], [Name], RecoveryEmail)
VALUES
(N'vgovern0', N'LEMelf1', N'Vidovic Govern', N'vgovern0@ft.com'),
(N'tunderwood1', N'8F2ZozYZM2G', N'Tallie Underwood', N'tunderwood1@fastcompany.com'),
(N'hkevern2', N'rgfEnDyC', N'Hube Kevern', N'hkevern2@fema.gov'),
(N'mlatty3', N'8OTOJ8q94s', N'Marthena Latty', N'mlatty3@delicious.com'),
(N'kburdoun4', N'f0dptXoE', N'Keri Burdoun', N'kburdoun4@amazon.de'),
(N'mwoodstock5', N'KbG6SNTp40WT', N'Melony Woodstock', N'mwoodstock5@intel.com'),
(N'bfawdry6', N'TWjXYm', N'Boone Fawdry', N'bfawdry6@unc.edu'),
(N'msankey7', N'Mchn22sH', N'Mady Sankey', N'msankey7@discuz.net'),
(N'vduberry8', N'9EexJcPX', N'Vincenty Duberry', N'vduberry8@boston.com'),
(N'egrzeszczyk9', N'ZNLZesOrbpFO', N'Egbert Grzeszczyk', N'egrzeszczyk9@e-recht24.de'),
(N'lgoggeya', N'cAh7LJ', N'Lynnell Goggey', N'lgoggeya@ning.com'),
(N'cjuarab', N'8oGxwvRe', N'Cordy Juara', N'cjuarab@typepad.com'),
(N'clunneyc', N'vJbe6z2sVJ', N'Collete Lunney', N'clunneyc@yale.edu'),
(N'eovereld', N'hOwIDTx', N'Elwood Overel', N'eovereld@dion.ne.jp'),
(N'bjobbinse', N'QCWSm2iuu35c', N'Birch Jobbins', N'bjobbinse@dropbox.com'),
(N'whenckef', N'N4tGK7gQdzI', N'Washington Hencke', N'whenckef@guardian.co.uk'),
(N'aguytong', N'WIID1wF', N'Ambrose Guyton', N'aguytong@samsung.com'),
(N'mzylberdikh', N'aElXdQJDNPT', N'Meagan Zylberdik', N'mzylberdikh@altervista.org'),
(N'srenboldi', N'SlFMiA8AZtn9', N'Sena Renbold', N'srenboldi@twitpic.com'),
(N'alongleyj', N'UuSCqElw', N'Avrom Longley', N'alongleyj@live.com'),
(N'scomelinik', N'MFoaoCIu', N'Shepperd Comelini', N'scomelinik@histats.com'),
(N'rhirsthousel', N'iYedCzmHv', N'Reagen Hirsthouse', N'rhirsthousel@about.com'),
(N'ntemlettm', N'TqX61DfngrdM', N'Niven Temlett', N'ntemlettm@imgur.com'),
(N'iclousleyn', N'P5B0yU', N'Ianthe Clousley', N'iclousleyn@yellowbook.com'),
(N'bkimmingso', N'ZF2LCUFP', N'Bobbette Kimmings', N'bkimmingso@altervista.org'),
(N'vlafontp', N'RvZzCMyuh5a', N'Vevay Lafont', N'vlafontp@soup.io'),
(N'aeneferq', N'K4izyt', N'Agnes Enefer', N'aeneferq@cbsnews.com'),
(N'gspurdenr', N'DKkoEhMoI', N'Gaspard Spurden', N'gspurdenr@independent.co.uk'),
(N'gkeens', N'xapXoiK22V', N'Gwenette Keen', N'gkeens@taobao.com'),
(N'mchattot', N'J8xh0kq', N'Marv Chatto', N'mchattot@ebay.co.uk'),
(N'ybraderu', N'7SA2pG', N'Yetty Brader', N'ybraderu@mit.edu'),
(N'miannellov', N'HwCNRmpDz8Ld', N'Mada Iannello', N'miannellov@columbia.edu'),
(N'ebollisw', N'5j44DYGDyrF', N'Elwyn Bollis', N'ebollisw@is.gd'),
(N'aabthorpex', N'UiL1Wx', N'Adelle Abthorpe', N'aabthorpex@sina.com.cn'),
(N'ldenisevichy', N'SRDDzdwDP', N'Leoline Denisevich', N'ldenisevichy@liveinternet.ru'),
(N'tberryclothz', N'Y5QBm5pDPY', N'Teddi Berrycloth', N'tberryclothz@angelfire.com'),
(N'jobruen10', N'6yki2pW', N'Jasper Bruen', N'jobruen10@github.io'),
(N'rgladbeck11', N'n8JEtSUhWtqd', N'Ric Gladbeck', N'rgladbeck11@google.es'),
(N'frochford12', N'Y89QB6PTjP', N'Forbes Rochford', N'frochford12@facebook.com'),
(N'rcameli13', N'kAWoGVbBG', N'Rollins Cameli', N'rcameli13@bandcamp.com'),
(N'trother14', N'xjGJozAyzTU', N'Tucky Rother', N'trother14@github.io'),
(N'hmeikle15', N'v1ivAcnCz', N'Hewet Meikle', N'hmeikle15@skype.com'),
(N'mmackness16', N'WXv1Frld0o', N'Marlene Mackness', N'mmackness16@bravesites.com'),
(N'mgepson17', N'YSUo5C2mulOZ', N'Merl Gepson', N'mgepson17@mozilla.com'),
(N'rbend18', N'lWCk0G2eem', N'Rozanna Bend', N'rbend18@prweb.com'),
(N'qhambright19', N'JsMzrb', N'Quinlan Hambright', N'qhambright19@dmoz.org'),
(N'amealand1a', N're0HwKDoz', N'Anabal Mealand', N'amealand1a@wisc.edu'),
(N'isidden1b', N'vK9ZnpJlY', N'Iosep Sidden', N'isidden1b@europa.eu'),
(N'bleggen1c', N'ecRKMM', N'Bridie Leggen', N'bleggen1c@nba.com'),
(N'jmoulson1d', N'UXEbYq', N'Jodi Moulson', N'jmoulson1d@dion.ne.jp'),
(N'mrobertsson1e', N'tbfpWm3Xh', N'Merv Robertsson', N'mrobertsson1e@prnewswire.com'),
(N'sshewon1f', N'UCCDWuF', N'Sibby Shewon', N'sshewon1f@parallels.com'),
(N'tiron1g', N'MLvdWxf4TPVa', N'Tess Iron', N'tiron1g@behance.net'),
(N'ccorrison1h', N'dmfRkwa', N'Caresa Corrison', N'ccorrison1h@flavors.me'),
(N'gnias1i', N'0IxLpkyYEy5T', N'Garrett Nias', N'gnias1i@blog.com'),
(N'gbrissard1j', N'HA09Vk5z4', N'Gwenneth Brissard', N'gbrissard1j@meetup.com'),
(N'bmouser1k', N'hw7Cb6T', N'Brunhilda Mouser', N'bmouser1k@disqus.com'),
(N'jstaines1l', N'bIWTrWVL', N'Julie Staines', N'jstaines1l@google.nl'),
(N'psmethurst1m', N'1eoaH8BJazkY', N'Pammy Smethurst', N'psmethurst1m@ehow.com'),
(N'taubry1n', N'53HW1xSlO', N'Tommi Aubry', N'taubry1n@sbwire.com'),
(N'dogbourne1o', N'm6sQn4CVaHlv', N'Daphna Ogbourne', N'dogbourne1o@amazon.co.jp'),
(N'vtitchen1p', N'j7AkBCEtM', N'Vince Titchen', N'vtitchen1p@phoca.cz'),
(N'sstaning1q', N'yIxBC8xxGcC', N'Stacia Staning', N'sstaning1q@hc360.com'),
(N'ljentgens1r', N'6ZuPmnmq6Dgc', N'Leann Jentgens', N'ljentgens1r@facebook.com'),
(N'rhoneywood1s', N'eSQnua3H6ZC', N'Rana Honeywood', N'rhoneywood1s@japanpost.jp'),
(N'hverry1t', N'1P0ZpZ', N'Hart Verry', N'hverry1t@netvibes.com'),
(N'cbaudouin1u', N'tHU4Lw', N'Catha Baudouin', N'cbaudouin1u@baidu.com'),
(N'rallwell1v', N'14gUfBNwl', N'Rourke Allwell', N'rallwell1v@guardian.co.uk'),
(N'ceckford1w', N'b2oB6WjKnJ', N'Cicely Eckford', N'ceckford1w@ft.com'),
(N'zblore1x', N'ybRyvYa', N'Zita Blore', N'zblore1x@blog.com'),
(N'pormonde1y', N'SvsxiSGO', N'Penny Ormonde', N'pormonde1y@usda.gov'),
(N'trelton1z', N'ZohHJKAQfQe', N'Tedd Relton', N'trelton1z@berkeley.edu'),
(N'rcroke20', N'vREojolJHqQh', N'Rheta Croke', N'rcroke20@mapy.cz'),
(N'nchaundy21', N'K4uu7XcaSb', N'Nico Chaundy', N'nchaundy21@slashdot.org'),
(N'nclemoes22', N'sADhol', N'Nannette Clemoes', N'nclemoes22@sakura.ne.jp'),
(N'dpilmoor23', N'tZs9jonSW', N'Darwin Pilmoor', N'dpilmoor23@mysql.com'),
(N'sgladtbach24', N'lDPjBbqBaCF', N'Sigfrid Gladtbach', N'sgladtbach24@parallels.com'),
(N'rluchelli25', N'LseofiIdYW9', N'Reed Luchelli', N'rluchelli25@woothemes.com'),
(N'aberesford26', N'kRwEGXa', N'Antons Beresford', N'aberesford26@4shared.com'),
(N'amc27', N'oNEyrQy', N'Abagael Mc Giffin', N'amc27@purevolume.com'),
(N'mbutson28', N'6htWrc', N'Martyn Butson', N'mbutson28@cnn.com'),
(N'pcobley29', N'JQbvFe7s', N'Parry Cobley', N'pcobley29@hud.gov'),
(N'tmateus2a', N'OMR8pqkE5', N'Tara Mateus', N'tmateus2a@ted.com'),
(N'gmeach2b', N'gBGbiIP', N'Giffard Meach', N'gmeach2b@barnesandnoble.com'),
(N'ddellenbrok2c', N'9tryucPt4Z', N'Davidde Dellenbrok', N'ddellenbrok2c@zdnet.com'),
(N'flangmaid2d', N'6Uf3rMNdQ', N'Federico Langmaid', N'flangmaid2d@vinaora.com'),
(N'mwesley2e', N'I9bEdq5kZFt3', N'Marney Wesley', N'mwesley2e@fc2.com'),
(N'smcravey2f', N'ac1Mhk', N'Silas McRavey', N'smcravey2f@unblog.fr'),
(N'mmccullough2g', N'Tbpc4QJo7', N'Martainn McCullough', N'mmccullough2g@smh.com.au'),
(N'svigurs2h', N'7Sb67gx4e6Z', N'Silva Vigurs', N'svigurs2h@craigslist.org'),
(N'lgowthorpe2i', N'1bMDsIjKu', N'Lori Gowthorpe', N'lgowthorpe2i@netscape.com'),
(N'tmanuello2j', N'GAAfdEnqxJwu', N'Tate Manuello', N'tmanuello2j@ucoz.com'),
(N'bhallbord2k', N'PmWO7VgI6G', N'Bobbie Hallbord', N'bhallbord2k@bravesites.com'),
(N'hwilcocke2l', N'AfFix13Azg', N'Herrick Wilcocke', N'hwilcocke2l@hud.gov'),
(N'iribbens2m', N'N7doy8', N'Ingram Ribbens', N'iribbens2m@tuttocitta.it'),
(N'aoverbury2n', N'NVIK8xBLJ', N'Avis Overbury', N'aoverbury2n@deviantart.com'),
(N'eglencross2o', N'tr4SdDdo', N'Emma Glencross', N'eglencross2o@npr.org'),
(N'eoferris2p', N'dRngz1i', N'Erma Ferris', N'eoferris2p@home.pl'),
(N'dchad2q', N'bLmIpLJ3n', N'Dev Chad', N'dchad2q@bizjournals.com'),
(N'nlyal2r', N'p0TtjvQTC1', N'Nanete Lyal', N'nlyal2r@yellowbook.com'),
(N'caden', N'pass', N'Caden McNeal', N'cmmcneal@ksu.edu')






/******************************************************************************/

MERGE Movie.Users U
USING @UsersStaging US ON US.UserId = U.UserId
WHEN MATCHED THEN
   UPDATE
   SET 
   U.UserName = US.UserName,
   U.[Password] = US.[Password],
   U.[Name] = US.[Name],
   U.RecoveryEmail = US.RecoveryEmail
WHEN NOT MATCHED THEN
   INSERT(UserName, [Password], [Name], RecoveryEmail)
   VALUES(US.UserName, US.[Password], US.[Name], US.RecoveryEmail);