SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [u_sheykina_schema].[sp_FindByFilter](
    @DateTimeUtc datetimeoffset = null,
    @ItemStatusId tinyint = null
)
AS
BEGIN
set NOCOUNT on;
BEGIN
select Id from ReminderItem as RI
Where (@ItemStatusId is not null and RI.ItemStatusId = @ItemStatusId) OR 
      (@DateTimeUtc is not null and RI.DateTimeUtc >= @DateTimeUtc)
RETURN 
END
END
GO

DECLARE @DateTimeUtc datetimeoffset = '2020-07-19 12:00:00.0000000 +01:00';
EXECUTE [u_sheykina_schema].[sp_FindByFilter] @DateTimeUtc;

DECLARE @DateTimeUtc datetimeoffset = '2020-07-01 12:00:00.0000000 +01:00';
DECLARE @ItemStatusId TINYINT = 1;
EXECUTE [u_sheykina_schema].[sp_FindByFilter] @DateTimeUtc, @ItemStatusId;

DECLARE @DateTimeUtc datetimeoffset = null;
DECLARE @ItemStatusId tinyint = 1;
EXECUTE [u_sheykina_schema].[sp_FindByFilter] @DateTimeUtc, @ItemStatusId;
