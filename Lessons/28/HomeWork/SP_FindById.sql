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
select @ReminderItemId = [u_sheykina_schema].[fn_FindById](@ReminderItemId);
RETURN
Print 'Reminder was found' + convert(varchar(36),@ReminderItemId);
if @ReminderItemId is NULL
BEGIN
PRINT 'Reminder is not found';
END
END
GO

DECLARE @ReminderItemId UNIQUEIDENTIFIER = '2a671b0c-6e71-4fb4-82be-cc1e1986ff86';
EXECUTE [u_sheykina_schema].[sp_FindById] @ReminderItemId;