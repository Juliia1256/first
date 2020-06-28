SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [u_sheykina_schema].[sp_AddToStorage] (
    @Title varchar (70),
	@Message varchar(300),
	@DateTimeUtc datetimeoffset,
	@ItemStatusId tinyint,
	@UserId int
)
AS
BEGIN
set NOCOUNT ON;
DECLARE
@ReminderItemId UNIQUEIDENTIFIER
BEGIN
set @ReminderItemId = NEWID();
INSERT into ReminderItem ([Id],[Title], [Message], [DateTimeUtc], [ItemStatusId], [UserId])
VALUES (@ReminderItemId, @Title, @Message, @DateTimeUtc, @ItemStatusId, @UserId);
END
END
GO

DECLARE @Title varchar (70) = 'A walk to the movies';
DECLARE @Message varchar(300) = 'Remind about the walk to the movies with Sarah';
DECLARE @DateTimeUtc datetimeoffset = '2020-07-08 21:00:00.0000000 +01:00';
DECLARE @ItemStatusId tinyint = 1;
DECLARE @UserId int= 3;
EXECUTE [u_sheykina_schema].[sp_AddToStorage] @Title, @Message, @DateTimeUtc, @ItemStatusId, @UserId;