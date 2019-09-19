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
1. [Product Backlog Items](#product-backlog-items)


## [⮤](#index)Concept 
This project will do 2 main things that the users can see. It will allow people to create a point of discussion (through creating a post), and allow people to respond to posts, by creating their own.

Each point of discussion will be its own thread on its own webpage, where users can follow the timeline of posts and see who replied to who. After a topic reaches a certain length, it will close and people will not be able to respond anymore. Every time someone makes a post in the topic, the topic will move to the top of the queue, which will be a certain length. After the topic leaves the queue, it is permanently deleted.

There will be many different web pages based on different topics that people can join to discuss specific topics, like news, restaraunts, tv shows, etc, so the amount of threads that can be active at one time will be quite extensive. All of this information will be stored on a webserver, so each thread will be its own table of information. This will reqire much reading/writing/creating/deleting of information from the database.

It will be a simple message board with basic functionalities, and will expand as the project grows.

### PowerPoint

![PPT](/Assets/Presentation.gif)

## [⮤](#index)Layout
The website will be 3 layers deep. The homepage will contain links to the topics, and the topics will have a list of discussions on them, with links to each one. There is no limit to the number of discussions that exist (so far).
### [⮤](#index)[^](#layout)Wireframe
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

## [⮤](#index)Database Design
The database is written with SQL, and will be implemented on a webserver. I have made significant changes to the design of the database in order to simplify data retrieval. There are only 3 tables now, one for users, one for all of the posts, and one for each topic. This greatly simplifies getting values for the website, and it minimizes the number of models needed for the MVC application. Here is a more refined version of the database:
```
-- ~ -- ~ -- 1. Create Database -- ~ -- ~ --
CREATE DATABASE MssaMessageBoard
GO
USE MssaMessageBoard
GO

-- ~ -- ~ -- 2. Create Tables -- ~ -- ~ -- 
CREATE TABLE Users
( userID INT Identity(1,1), userName varchar (25) NOT NULL, email varchar (40),
	userPhoto varchar(80), userPassword varchar(40) NOT NULL,
	userPermissions int, PRIMARY KEY(userID));
GO

CREATE TABLE Topics
( topicID INT Identity(1,1), topic varchar (40), PRIMARY KEY(topicID));
GO

CREATE TABLE Posts
( postID INT identity(1,1), topicID int, userID int, created date, content varchar (255), 
	PRIMARY KEY(postID), 
	FOREIGN KEY(topicID) REFERENCES Topics(topicID),
	FOREIGN KEY(userID) REFERENCES Users(userID));
GO
    
-- ~ -- ~ -- 3. Setting up default values -- ~ -- ~ --
INSERT INTO Topics (topic)
VALUES ('Math');
INSERT INTO Topics (topic)
VALUES ('Language');
INSERT INTO Topics (topic)
VALUES ('Literature');
INSERT INTO Topics (topic)
VALUES ('History');
INSERT INTO Topics (topic)
VALUES ('Fitness');
INSERT INTO Topics (topic)
VALUES ('Food');
INSERT INTO Topics (topic)
VALUES ('Social');
INSERT INTO Topics (topic)
VALUES ('Sports');
INSERT INTO Topics (topic)
VALUES ('Entertainment');
INSERT INTO Topics (topic)
VALUES ('Fashion');
INSERT INTO Topics (topic)
VALUES ('Places');
INSERT INTO Topics (topic)
VALUES ('Miscellaneous');
SELECT * FROM Topics;

INSERT INTO Users (userName, email, userPassword)
VALUES ('Administrator', 'abc@xyz.com', 'Password')
INSERT INTO Users (userName, userPassword)
VALUES ('Anonymous', 'password')
SELECT * FROM Users;

-- ~ -- ~ -- 4. How to in -- ~ -- ~ -- 
INSERT INTO Posts (topicID, userID, created, content)
VALUES(
	3,		/*The current topic*/
	1,		/*The current user, default is anonymous*/
	GETDATE(),	/*The current date/time*/
	'This is a sample message' /*The content body, what comes from the textbox*/
);

-- ~ -- ~ -- 5. CLEANUP -- ~ -- ~ -- 
USE master
GO
DROP DATABASE MssaMessageBoard
GO
```
### [⮤](#index)[^](#database-design)Entity Relational Diagram
![ERD](/Assets/erd.jpg)
### [⮤](#index)[^](#database-design)Database Diagram
![DatabaseDiagram](/Assets/databaseDiagram.jpg)
## [⮤](#index)Usage
The user should be able to create a profile, log into it, modify the information, view any message, create a message, and delete their own message. A moderator is at a higher level, and should be able to do all the same things, but also delete other people messages and discussions. An administrator is at the highest level, and should be able to do all of the previous things, but also delete topics, any profile, and do anything to the design of the website. The Administrator is the developer that controls everything.
### [⮤](#index)[^](#usage)UML Diagram
![UML](/Assets/UML.jpg)
### [⮤](#index)[^](#usage)Requirements Traceability Matrix
WIP: Some of the initial tests to run, and all of the different subsections of them

| TestNo.      | Status     | Build     | TimeStamp | Requirement       | Test Description | Test Method | Test Procedure |
| -----------: | :--------: | :-------: | :-------: | :---------------: | :--------------- | :---------: | :------------: |
| 1            | Not Tested |           |           | User Login        | User shall make an account | Analysis | Enter the pw/username/(default)picture, update all three |
| 1.1          | Not Tested |           |           |                   | User shall make a username | Test | unit test |
| 1.2          | Not Tested |           |           |                   | User shall make a password | Test | unit test |
| 1.3          | Not Tested |           |           |                   | User shall upload a profile picture | Demonstration | Enter the picture |
| 1.4          | Not Tested |           |           |                   | User shall be able to update profile | Analysis | unit test group(checking if all information is changed) |
| 2            | Not Tested |           |           | Message Creation  | User shall create a message | Test | unit test |
| 2.1          | Not Tested |           |           |                   | User shall delete a message | Test | unit test |
| 3            | Not Tested |           |           | Message Handling  | Website shall display messages | Inspection  | View the webpage to verify information |
| 3.1          | Not Tested |           |           |                   | Website shall group messages by discussion | Analysis | unit test group verifying correct information from database |
| 3.2          | Not Tested |           |           |                   | Website shall update discussion list when new discussion created | Analysis | unit test group checking for message on both pages |
| 3.3          | Not Tested |           |           |                   | Website shall handle message linking to other messages in same discussion | Demonstration | Click generated links and see if they go to right spot |
| 3.4          | Not Tested |           |           |                   | Website shall handle message linking to other messages across discussions/topics | Demonstration | Click generated links and see if they go to right spot |
| 4            | Not Tested |           |           | Website Layout    | Views shall display correctly | Inspection | View page and see if everything is lined up correctly |
| 4.1          | Not Tested |           |           |                   | Menu shall point to the correct views | Demonstration | Click links to see if they point to right locations |
| 4.2          | Not Tested |           |           |                   | HomePage shall point to topic views and login information | Demonstration | Click links to see if they point to right locations |
| 4.3          | Not Tested |           |           |                   | Topic views shall have list of discussions | Inspection | View the page and see if there are messages |
| 4.3.1        | Not Tested |           |           |                   | Topic views shall arrange discussions by date of last post | Test | unit test (by time ordering) |
| 4.4          | Not Tested |           |           |                   | Discussion views shall have a list of messages | Inspection  | View page and see if there are messages |
| 4.4.1        | Not Tested |           |           |                   | User pictures shall display properly | Inspection | View if pictures are uploading correctly |

## [⮤](#index)Product Backlog Items
#### Complete:
1. GUI
1. Database model

#### WIP:
1. Creating controllers/models to access database
1. Set up pagination

#### TODO:
1. Populate initial tables
1. Create user accounts page
1. Validate login info
1. Push to a webserver
1. Testing
1. Gui for mobile devices
