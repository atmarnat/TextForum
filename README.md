# TwaddleCate
Project for the MSSA cohort

## Description
TwattleCate is a text-based message board based on the Fubuta channel, implementing the GazouBBS script in conjunction with creating and managing user accounts. It uses the MVC model in order to provide users with a way to communicate with each other from anywhere on the planet in real time.
## Index
1. [Concept](#concept)
    1. [PowerPoint](#powerpoint)
1. [Layout](#layout)
    1. [Wireframe](#wireframe)
1. [Database Design](#database-design)
    1. [Entity Relational Diagram](#entity-relational-diagram)
    1. [Database Diagram](database-diagram)

## Concept
~~TODO~~
### PowerPoint
~~TODO~~
## Layout
~~TODO~~
### Wireframe
~~TODO~~
## Database Design
The database is written with SQL, and will be implemented on a webserver. Each new discussion will create a table, so the database will need to be scalable and easy to navigate. This will evolve as I progress more into the project. Here is a preliminary implementation of the webserver so far:
```
-- ~ -- ~ -- 1. Create Database -- ~ -- ~ --
CREATE DATABASE MssaMessageBoard
GO
USE MssaMessageBoard
GO

-- ~ -- ~ -- 2. Create Tables -- ~ -- ~ -- 
CREATE TABLE Users
( UserName varchar (25), UserPassword varchar (25), UserEmail varchar (25), UserDateCreated DATE );
ALTER TABLE Users ADD UserID INT Identity(0,1)
GO

--Do this for each different subject
CREATE TABLE Food --Sports, Fashion, Programming, Health, Entertainment, Misc.
( TopicID varchar(30), tPostNumCreate int, tPostDateCreate DATE, tPostUserID int);
ALTER TABLE Food ADD tPostID INT IDENTITY(0,1) 
GO 
INSERT INTO Food
(TopicID, tPostNumCreate, tPostDateCreate, tPostUserID)
	VALUES
	('Food', 0, GETDATE(), 0);
    
-- ~ -- ~ -- 3. HowTo Population -- ~ -- ~ --
CREATE TABLE Discussion 
(
	PostNum int
	, PostDate DATE
	, PostUserID int
	, PostTopicLoc varchar(30)
	, PostMessage varchar(255)
	, PostRank int
);
ALTER TABLE tempstuff ADD PostID INT IDENTITY(1,1)
GO

INSERT INTO Discussion
(PostNum, PostDate, PostUserID, PostTopicLoc, PostMessage, PostRank, PostID)
VALUES
(
	1 /*Some value, gotten from users*/
	, GETDATE()
	, (SELECT UserID FROM Users) /*ID of user that posted, usually 1 for now*/
	, (SELECT TopicID
		FROM Topic) /*some variable to relate to the topic id*/
	, 'This is a message' /*input from user*/
	, 1 /*order numbering, 1 to whatever*/
	, 1 /*is always the post number of first message in discussion*/
);

INSERT INTO Topics  --topics are Food, Sports, Fashion, Programming, Health, Entertainment, Miscellaneous
(	TopicID
	, tPostNumCreate
	, tPostDateCreate
	, tPostUserID
)
VALUES -- for the list of topics for the first int.
(
	Topics	 
	, (SELECT PostNum
		FROM Discussion
		WHERE PostRank = 1)
	, (SELECT PostDate
		FROM Discussion
		WHERE PostRank = 1)
	, (SELECT PostUserID
		FROM Discussion
		WHERE PostRank = 1)
)

-- ~ -- ~ -- 4. CLEANUP -- ~ -- ~ -- 
USE master
GO
DROP DATABASE MssaMessageBoard
GO
```
### Entity Relational Diagram
![ERD](/Assets/erd.jpg)
### Database Diagram
~~TODO~~
