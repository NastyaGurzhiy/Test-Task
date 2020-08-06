/****** Скрипт для команды SelectTopNRows из среды SSMS  ******/
SELECT TOP (1000) [Id]
      ,[Date]
      ,[EmployeeId]
      ,[CurrentRole]
      ,[ActivType]
      ,[CurrentProject]
      ,[TimePeriod]
  FROM [TrackTime].[dbo].[WorkTimes]
  truncate table worktimes