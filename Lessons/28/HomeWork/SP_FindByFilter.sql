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
if @DateTimeUtc is not null and @ItemStatusId is not null
BEGIN
select Id from ReminderItem
Where DateTimeUtc >= @DateTimeUtc and ItemStatusId = @ItemStatusId;
RETURN 
END
if @ItemStatusId is null
BEGIN
select Id from ReminderItem
Where DateTimeUtc >= @DateTimeUtc
END
if @DateTimeUtc is NULL
BEGIN
select Id from ReminderItem
Where ItemStatusId = @ItemStatusId;
RETURN 
END
END
GO

DECLARE @DateTimeUtc datetimeoffset = '2020-07-01 12:00:00.0000000 +01:00';
DECLARE @ItemStatusId tinyint = 1;
EXECUTE [u_sheykina_schema].[sp_FindByFilter] @DateTimeUtc, @ItemStatusId;

DECLARE @DateTimeUtc datetimeoffset = '2020-07-01 12:00:00.0000000 +01:00';
DECLARE @ItemStatusId tinyint = null;
EXECUTE [u_sheykina_schema].[sp_FindByFilter] @DateTimeUtc, @ItemStatusId;

DECLARE @DateTimeUtc datetimeoffset = null;
DECLARE @ItemStatusId tinyint = 1;
EXECUTE [u_sheykina_schema].[sp_FindByFilter] @DateTimeUtc, @ItemStatusId;
