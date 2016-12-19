USE [StudentDB]
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[updateStudent]') AND type in (N'P', N'PC'))
DROP PROCEDURE updateStudent
GO
CREATE PROCEDURE updateStudent
(
	@Id int,
	@Name nvarchar(max) = null,
	@StudentID nvarchar(20) = null
)
As
Begin
	Update StudentInfo
	Set
	Name=@Name,
	StudentID=@StudentID
	Where Id = @Id;
End

GO


