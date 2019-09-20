CREATE TABLE Users
( userID INT Identity(1,1), userName varchar (25) NOT NULL, email varchar (40),
	userPhoto varchar(80), userPassword varchar(40) NOT NULL,
	userPermissions int, PRIMARY KEY(userID));
GO