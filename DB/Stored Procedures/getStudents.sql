USE StudentDB
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[getStudents]') AND type in (N'P', N'PC'))
DROP PROCEDURE getStudents
GO
CREATE PROCEDURE getStudents
As 
BEGIN 
SELECT * FROM StudentInfo
END
GO