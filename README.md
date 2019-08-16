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
1. [Usage](#usage)
    1. [UML Diagram](#uml-diagram)
    1. [Requirements Traceability Matrix](#requirements-traceability-matrix)


## [^](#index)Concept 
This project will do 2 main things that the users can see. It will allow people to create a point of discussion (through creating a post), and allow people to respond to posts, by creating their own.

Each point of discussion will be its own thread on its own webpage, where users can follow the timeline of posts and see who replied to who. After a topic reaches a certain length, it will close and people will not be able to respond anymore. Every time someone makes a post in the topic, the topic will move to the top of the queue, which will be a certain length. After the topic leaves the queue, it is permanently deleted.

There will be many different web pages based on different topics that people can join to discuss specific topics, like news, restaraunts, tv shows, etc, so the amount of threads that can be active at one time will be quite extensive. All of this information will be stored on a webserver, so each thread will be its own table of information. This will reqire much reading/writing/creating/deleting of information from the database.

It will be a simple message board with basic functionalities, and will expand as the project grows.

### PowerPoint

![PPT](/Assets/Presentation.gif)

## [^](#index)Layout
The website will be 3 layers deep. The homepage will contain links to the topics, and the topics will have a list of discussions on them, with links to each one. There is no limit to the number of discussions that exist (so far). A simplified map looks like:
![LAYOUT](/Assets/layout.jpg)
### [^](#layout)Wireframe
#### Homepage
![home](/Assets/homepage.jpg)
This is the front page of the website. It will have a variety of topics grouped by category. Each will have a picture next to the name, and the user can either click on the picture or the name of the topic in order to go to that webpage. Users will also be able to login to an account on the top left, or continue anonymously. In the top right, there will be a hamburger menu that lets users navigate back to home, view a page that talks about the website, view a page that describes the rules, activate a pop-up that lets them change account info, and finally a button that logs them out of the site. The account buttons are inactive on the anonymous account.

When a user chooses login, they will be prompted with a popup that lets them enter an email and password to login, and a button to let users create a new account. When a user is logged in, their profile picture will display and the login button will be replaced with their username. Users will log out in the hamburger menu.

At the bottom of the page will be a small description of the website, a disclaimer about usage, and the purpose.

There will only be 1 of these.

#### Topic View
![topic](/Assets/topicpage.jpg)
For the topic pages, the title will be displayed at the top and center. Directly under it will be an input box where users can create new discussions, give it a title, and (in the future) upload pictures. I am hesistant on implementing this feature at the moment because of how difficult it is to check the content of an image without human eyes on it. The login features and hamburger menu will work the same as on the home page.

The number of topics will be a set number per page (probably 10 or 20) to make it easier to navigate the site. I am not a fan of infinite scrolling. Users can use a feature at the top or bottom of the page to navigate different discussions. There will also be a search function so that a user can find discussions by content. At the bottom, users will also be able to delete their discussions (if the click the checkbox next to it), and other users will be able to report a discussion (if they click the checkbox of the discussion). There is also a button to return to the homepage at the bottom.

Each discussion displayed will simply be the first message in that discussion, with the profile picture of the user that created it, the user name, the time it was created, and the post number. Post numbers go from 1 to infinity, and are unique for each topic. The content of the first message will also be displayed. The checkbox allows for reporting/deleting. There should be 10-20 of these per page, depending on the configuration.

There will be a fixed number of these, and users will be unable to create new topics.

#### Discussion View
![thread](/Assets/threadpage.jpg)
The discussion view will have a lot of the same features as the Topic view. The login and hamburger parts share the features as the Home view and the Topic view. The Topic title will be used if no discussion name is used when it is created. If one is given, the topic title will be replaced with the discussion title (though the topic title part of the URL will not change). Instead of creating new discussions, users can reply to a discussion.

The number of topics menu will be replaced with simple buttons that let a user to jump to the top or bottom of the page. The delete/report buttons will work the same way, and the home button will remain. Instead of a search function, a Return button will be used to let the user return to the Topic view. The messages will work exactly the same as in the Topic view, with 2 key differences. Only the first message will have no background, the rest will, and all replied posts will be displayed next to the user info. These replies will be links that jump down to the message that was replied to.

There is a potentially infinite number of discussions, so there can be an infinite number of messages. I will probably close discussions after a certain number of messages to keep discussions moving.

## [^](#index)Database Design
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
### [^](#database-design)Entity Relational Diagram
![ERD](/Assets/erd.jpg)
### [^](#database-design)Database Diagram
TODO:
## [^](#index)Usage
The user should be able to create a profile, log into it, modify the information, view any message, create a message, and delete their own message. A moderator is at a higher level, and should be able to do all the same things, but also delete other people messages and discussions. An administrator is at the highest level, and should be able to do all of the previous things, but also delete topics, any profile, and do anything to the design of the website. The Administrator is the developer that controls everything.
### [^](#usage)UML Diagram
![UML](/Assets/UML.jpg)
### [^](#usage)Requirements Traceability Matrix
TODO:
