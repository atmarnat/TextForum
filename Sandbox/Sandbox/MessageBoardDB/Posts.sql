INSERT INTO Posts (topicID, userID, created, content)
VALUES(
	3,		/*The current topic*/
	1,		/*The current user, default is anonymous*/
	GETDATE(),	/*The current date/time*/
	'This is a sample message' /*The content body, what comes from the textbox*/
);
INSERT INTO Posts (topicID, userID, created, content)
VALUES(
	3,		/*The current topic*/
	1,		/*The current user, default is anonymous*/
	GETDATE(),	/*The current date/time*/
	'This is another sample message' /*The content body, what comes from the textbox*/
);
INSERT INTO Posts (topicID, userID, created, content)
VALUES(
	3,		/*The current topic*/
	1,		/*The current user, default is anonymous*/
	GETDATE(),	/*The current date/time*/
	'This is a third sample message' /*The content body, what comes from the textbox*/
);
