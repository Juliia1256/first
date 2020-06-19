--CREATE DATABASE ReminderStorage;

create TABLE ReminderItem (
    [Id] UNIQUEIDENTIFIER NOT NULL primary key,
    [Title] VARCHAR (70) NOT NULL,
    [Message] VARCHAR (300) NOT NULL,
    [DateTimeUtc] datetimeoffset NOT NULL,
    [ItemStatusId] TINYINT NOT NULL,
    [UserId] int NOT NULL
);


CREATE TABLE ItemStatus (
    [Id] TINYINT NOT NULL primary key,
    [StatusName] VARCHAR (20) NOT NULL,
);

Insert into ItemStatus
VALUES
(0, 'Undefined'),
(1, 'Created'),
(2, 'Ready'),
(3, 'Sent'),
(4, 'Failed');

Create TABLE Users (
    [Id] int primary key IDENTITY(1,1),
    [Login] VARCHAR (50) NOT NULL,
    [ChatId] VARCHAR (50) NOT NULL,
);

Insert into Users
VALUES
('sheikina', '123456789');

select * from users;

Alter TABLE ReminderItem
Add CONSTRAINT FK_ItemStatusId FOREIGN KEY (ItemStatusId)
REFERENCES ItemStatus(Id)
On DELETE CASCADE
on UPDATE CASCADE

Alter TABLE ReminderItem
Add CONSTRAINT FK_UserId FOREIGN KEY (UserId)
REFERENCES Users(Id)
On DELETE CASCADE
on UPDATE CASCADE



INSERT into ReminderItem
VALUES 
('db5eaa7c-a228-4da0-8aa5-d634ace80843', 'Birthday party tomorrow','Remind about the party', '2020-06-20 12:00:00.0000 +01:0', 1, 1);

SELECT * from ReminderItem