IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StudentInfo]') AND type in (N'U'))
Create table StudentInfo 
(
Id int IDENTITY (1,1),
Name nVarchar(max),
StudentID nVarchar(20),
PRIMARY KEY (ID)
)