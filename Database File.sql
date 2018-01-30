CREATE DATABASE db_whatsapp;
USE db_whatsapp;
GO

/*
------------------------------------------------------------------------------------------------------------------------------------------------------------------------
																			• Tables
------------------------------------------------------------------------------------------------------------------------------------------------------------------------
*/

CREATE TABLE Accounts
(
	AccountID SMALLINT NOT NULL IDENTITY,
	Username NVARCHAR(30) NOT NULL,
	Password NVARCHAR(30) NOT NULL,
	Tel NVARCHAR(10) NOT NULL,
	About NVARCHAR(100) NOT NULL,
	Photo IMAGE,
	SecurityQ NVARCHAR(44) NOT NULL,
	SecurityR NVARCHAR(40) NOT NULL,
	LastSeen DATETIME NOT NULL DEFAULT GETDATE(),
	RegistratingDate DATE NOT NULL DEFAULT GETDATE(),

	CONSTRAINT pk_id PRIMARY KEY(AccountID)
);
GO

CREATE TABLE Contacts
(
	AccountID SMALLINT NOT NULL,
	ContactID SMALLINT NOT NULL,
	DateF DATE NOT NULL CHECK(dateF <= GETDATE()) DEFAULT GETDATE(),

	CONSTRAINT fk_accid FOREIGN KEY(AccountID) REFERENCES Accounts(AccountID),
	CONSTRAINT fk_conid FOREIGN KEY(ContactID) REFERENCES Accounts(AccountID)
);
GO

CREATE TABLE Msgs
(
	MessageID INT NOT NULL IDENTITY,
	SenderID SMALLINT NOT NULL,
	RecieverID SMALLINT NOT NULL,
	Message TEXT NOT NULL,
	DateS DATETIME NOT NULL CHECK(dateS <= GETDATE()) DEFAULT GETDATE(),
	State BIT NOT NULL DEFAULT 0,
	DateR DATETIME NOT NULL CHECK(dateS <= GETDATE()) DEFAULT GETDATE()

	CONSTRAINT pk_msgid PRIMARY KEY(MessageID),
	CONSTRAINT fk_sid FOREIGN KEY(SenderID) REFERENCES Accounts(AccountID),
	CONSTRAINT fk_recid FOREIGN KEY(RecieverID) REFERENCES Accounts(AccountID),
);
GO

CREATE TABLE appSettings
(
	AccountID SMALLINT NOT NULL,
	BackgroundImage IMAGE DEFAULT NULL,

	BackgroundColorR TINYINT DEFAULT 240,
	BackgroundColorG TINYINT DEFAULT 240,
	BackgroundColorB TINYINT DEFAULT 240,

	AccountBackgroundColorR TINYINT DEFAULT 40,
	AccountBackgroundColorG TINYINT DEFAULT 79,
	AccountBackgroundColorB TINYINT DEFAULT 79,

	ContactBackgrounColorR TINYINT DEFAULT 255,
	ContactBackgrounColorG TINYINT DEFAULT 255,
	ContactBackgrounColorB TINYINT DEFAULT 255,

	AccountTextColorR TINYINT DEFAULT 0,
	AccountTextColorG TINYINT DEFAULT 0,
	AccountTextColorB TINYINT DEFAULT 0,

	ContactTextColorR TINYINT DEFAULT 0,
	ContactTextColorG TINYINT DEFAULT 0,
	ContactTextColorB TINYINT DEFAULT 0,

	CONSTRAINT fk_settAccid FOREIGN KEY(AccountID) REFERENCES Accounts(AccountID)
);
GO

/*
------------------------------------------------------------------------------------------------------------------------------------------------------------------------
																			• Affichage
------------------------------------------------------------------------------------------------------------------------------------------------------------------------
*/

SELECT * FROM Accounts;
SELECT * FROM Contacts;
SELECT * FROM Msgs;
SELECT * FROM appSettings;

----------------------
SELECT ISNULL(MessageID, -1) AS "MessageID", ContactID, Msgs.DateS
FROM Contacts LEFT JOIN Msgs ON Contacts.ContactID IN (Msgs.SenderID, Msgs.RecieverID)
WHERE AccountID = 1 ORDER BY Msgs.DateS ASC;

----------------------

SELECT SenderID, Username, Tel, Photo, DateS
FROM Accounts INNER JOIN Msgs ON AccountID IN (Msgs.SenderID, Msgs.RecieverID)
WHERE AccountID <> 1 AND MessageID = 1;

---------------------

SELECT DISTINCT ISNULL(m.MessageID, -1) AS "MessageID", ContactID, m.DateS
FROM Contacts c
    CROSS APPLY (
        SELECT TOP 1  Msgs.MessageID, Msgs.DateS 
        FROM Msgs 
        WHERE c.ContactID IN (SenderID, RecieverID)
        ORDER BY DateS DESC
    ) m
WHERE AccountID = 1;

SELECT SenderID, Message, DateS FROM Msgs WHERE SenderID IN (1, 2) AND RecieverID IN (1, 2);

/*
------------------------------------------------------------------------------------------------------------------------------------------------------------------------
																			• Mis-a-jours
------------------------------------------------------------------------------------------------------------------------------------------------------------------------
*/

/*DELETE FROM Accounts;
DELETE FROM Contacts;
DELETE FROM Msgs;
DELETE FROM appSettings;

DROP TABLE Accounts;
GO*/
UPDATE Msgs SET State = 0 WHERE MessageID IN (81, 80);
/*
------------------------------------------------------------------------------------------------------------------------------------------------------------------------
																			• Insertion
------------------------------------------------------------------------------------------------------------------------------------------------------------------------
*/


/*
------------------------------------------------------------------------------------------------------------------------------------------------------------------------
																			• Misconceptions
------------------------------------------------------------------------------------------------------------------------------------------------------------------------
*/

CREATE TRIGGER t_appSetting
ON Accounts AFTER INSERT AS
BEGIN
	DECLARE @AccountID SMALLINT; 
	DECLARE gCur CURSOR
	FOR (SELECT AccountID FROM inserted);

	OPEN gCur;

	FETCH NEXT FROM gCur INTO @AccountID;

	WHILE @@FETCH_STATUS = 0
	BEGIN
		INSERT INTO appSettings(AccountID) VALUES(@AccountID);

		FETCH NEXT FROM gCur INTO @AccountID;
	END

	CLOSE gCur;
	DEALLOCATE gCur;
END;