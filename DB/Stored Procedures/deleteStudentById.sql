USE [StudentDB]
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[deleteStudentById]') AND type in (N'P', N'PC'))
DROP PROCEDURE deleteStudentById
GO
CREATE PROCEDURE deleteStudentById
(
	@Id int 
)
As
Begin
	Delete From StudentInfo Where Id = @Id;
End

GO


