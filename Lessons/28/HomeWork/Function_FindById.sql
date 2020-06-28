SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [u_sheykina_schema].[fn_FindById](
    @ReminderItemId UNIQUEIDENTIFIER
)
RETURNS UNIQUEIDENTIFIER
BEGIN
RETURN (SELECT Id
FROM ReminderItem
WHERE Id = @ReminderItemId)
end 
GO


select [u_sheykina_schema].[fn_FindById]('2a671b0c-6e71-4fb4-82be-cc1e1986ff86')