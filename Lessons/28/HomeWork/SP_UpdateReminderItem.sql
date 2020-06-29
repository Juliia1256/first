SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [u_sheykina_schema].[sp_UpdateReminderItem](
    @ReminderItemId UNIQUEIDENTIFIER,
    @Title varchar (70),
	@Message varchar(300),
	@DateTimeUtc datetimeoffset,
	@ItemStatusId tinyint,
	@UserId int
)
as
BEGIN
set NOCOUNT ON;
if @ReminderItemId is NULL
BEGIN
PRINT 'Reminder is not found';
END
If @ReminderItemId is not null
BEGIN
UPDATE ReminderItem
SET Title = @Title,
[Message] = @Message,
[DateTimeUtc] = @DateTimeUtc,
[ItemStatusId] = @ItemStatusId,
[UserId] = @UserId
WHERE id = @ReminderItemId;
END
END
GO

DECLARE @ReminderItemId UNIQUEIDENTIFIER = 'ce4d1b13-485e-43b0-a5ca-b0f6f0037761';
DECLARE @Title varchar (70) = 'A walk to the theatre';
DECLARE @Message varchar(300) = 'Remind about the walk to the movies with Sarah';
DECLARE @DateTimeUtc datetimeoffset = '2020-07-08 21:00:00.0000000 +01:00';
DECLARE @ItemStatusId tinyint = 1;
DECLARE @UserId int= 3;
EXECUTE [u_sheykina_schema].[sp_UpdateReminderItem] @ReminderItemId, @Title, @Message, @DateTimeUtc, @ItemStatusId, @UserId;