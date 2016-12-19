USE [StudentDB]
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[getStudentById]') AND type in (N'P', N'PC'))
DROP PROCEDURE getStudentById
GO
CREATE PROCEDURE getStudentById
(
	@Id int 
)
As
Begin
	Select * From StudentInfo Where Id = @Id;
End


GO