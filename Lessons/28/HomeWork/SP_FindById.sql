SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [u_sheykina_schema].[sp_FindById] (
@ReminderItemId UNIQUEIDENTIFIER
)
as
BEGIN
set nocount on;
If @ReminderItemId is not null
SELECT Id
FROM ReminderItem
WHERE Id = @ReminderItemId;
RETURN
END
if @ReminderItemId is NULL
BEGIN
PRINT 'Reminder is not found';
RETURN
END
GO

DECLARE @ReminderItemId UNIQUEIDENTIFIER = '2a671b0c-6e71-4fb4-82be-cc1e1986ff86';
EXECUTE [u_sheykina_schema].[sp_FindById] @ReminderItemId;