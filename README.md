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
This project will do 2 main things that the users can see. It will allow people to create a point of discussion (through creating a post), and allow people to respond to posts, by creating their own.

Each point of discussion will be its own thread on its own webpage, where users can follow the timeline of posts and see who replied to who. After a topic reaches a certain length, it will close and people will not be able to respond anymore. Every time someone makes a post in the topic, the topic will move to the top of the queue, which will be a certain length. After the topic leaves the queue, it is permanently deleted.

There will be many different web pages based on different topics that people can join to discuss specific topics, like news, restaraunts, tv shows, etc, so the amount of threads that can be active at one time will be quite extensive. All of this information will be stored on a webserver, so each thread will be its own table of information. This will reqire much reading/writing/creating/deleting of information from the database.

It will be a simple message board with basic functionalities, and will expand as the project grows.

### PowerPoint

![PowerPoint](/Assets/powerpoint.mp4)

## Layout
The website will be 3 layers deep. The homepage will contain links to the topics, and the topics will have a list of discussions on them, with links to each one. There is no limit to the number of discussions that exist (so far). A simplified map looks like:
![LAYOUT](/Assets/layout.jpg)
### Wireframe
TODO: Aug 11
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
TODO: Aug 17
