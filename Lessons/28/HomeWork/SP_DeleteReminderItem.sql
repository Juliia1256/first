SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [u_sheykina_schema].[sp_DeleteReminderItem](
    @ReminderItemId UNIQUEIDENTIFIER
)
AS
BEGIN
set NOCOUNT on;
if @ReminderItemId is NULL
BEGIN
PRINT 'Reminder is not found';
END
If @ReminderItemId is not null
BEGIN
select @ReminderItemId = [u_sheykina_schema].[fn_FindById](@ReminderItemId);
delete ReminderItem
where id = @ReminderItemId;
END
END
GO

DECLARE @ReminderItemId UNIQUEIDENTIFIER = 'ce4d1b13-485e-43b0-a5ca-b0f6f0037761';
EXECUTE [u_sheykina_schema].[sp_DeleteReminderItem] @ReminderItemId;