

SET NOCOUNT ON

--declare @userId UNIQUEIDENTIFIER = '217F9628-607F-4F74-8DFD-685B97696263'

	IF OBJECT_ID('tempdb..#XmlDecentralization_Temp') IS NOT NULL
		DROP TABLE #XmlDecentralization_Temp
	CREATE TABLE #XmlDecentralization_Temp (
				UserId UNIQUEIDENTIFIER,
				UserCode VARCHAR(50),
				FullName nvarchar(255),
				PermissionId varchar(50))

	Insert Into #XmlDecentralization_Temp
	select DISTINCT u.UserId, u.UserCode, u.FullName, PermissionId from UserPermission p inner join [dbo].[User] u on u.UserID = p.UserId
	where u.UserId = @userId

	--select * from #XmlDecentralization_Temp

declare @sqlCol varchar(MAX) = (SELECT QUOTENAME(PermissionId) + ', ' FROM Permission FOR XML PATH (''))
set @sqlCol = SUBSTRING(@sqlCol,1,len(@sqlCol)-1)

declare @sqlQuery varchar(MAX) = '
select *
from #XmlDecentralization_Temp src
pivot
(
  Count(PermissionId)
  for PermissionId in ('+@sqlCol+')
) piv;'

execute(@sqlQuery)