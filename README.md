SE master
GO

CREATE DATABASE ScheduleDB
GO

USE ScheduleDB
BEGIN TRAN
CREATE TABLE ActualSchedule (
  id int IDENTITY(1,1) NOT NULL PRIMARY KEY ,
  event_info nvarchar(150),
  event_date datetime
    )
    GO <------------------------------------- Script for creating a DB(I used MSSMS). Dump of current DB - it's black hole for me, so I created small table, sorry. 


    In appsettings.json file you will find connection string for DB, but also in ScheduleContent class you need to enter the full connection string of the table.
    I tried to do with only appsettings.json, but it didn't work.
    Have a good day!
