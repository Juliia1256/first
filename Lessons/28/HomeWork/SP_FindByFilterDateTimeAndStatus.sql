SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [u_sheykina_schema].[sp_FindByFilterDateTimeAndStatus](
    @DateTimeUtc datetimeoffset,
    @ItemStatusId tinyint
)
AS
BEGIN
set NOCOUNT on;
select Id from ReminderItem
Where DateTimeUtc = @DateTimeUtc and ItemStatusId = @ItemStatusId;
RETURN 
END
GO

DECLARE @DateTimeUtc datetimeoffset = '2020-07-01 12:00:00.0000000 +01:00';
DECLARE @ItemStatusId tinyint = 1;
EXECUTE [u_sheykina_schema].[sp_FindByFilterDateTimeAndStatus] @DateTimeUtc, @ItemStatusId;