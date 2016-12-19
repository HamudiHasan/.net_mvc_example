use StudentDB
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[insertStudent]') AND type in (N'P', N'PC'))
DROP PROCEDURE insertStudent
GO
CREATE PROCEDURE insertStudent
(
	@Id int output,
	@Name nvarchar(100) = null,
	@StudentID nvarchar(20) = null
)
As
Begin
Insert Into StudentInfo
	(
		Name,
		StudentId
	)
	Values
	(
		@Name,
		@StudentId
	)

	Set @Id = SCOPE_IDENTITY();
End


GO
