
USE [StudentMng]
GO
CREATE TABLE [Registration](
	[studentID] [int] NOT NULL,
	[name] [varchar] (150) NOT NULL,
	[dob] [datetime]  NOT NULL,
	[gradepoint] [float] NOT NULL,
	[active] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Registration] PRIMARY KEY CLUSTERED ([studentID]))


select * from Registration;

--drop table Registration;




CREATE PROCEDURE [AddStudent]
	-- Add the parameters for the stored procedure here
	@studentID int,
	@name varchar(150),
	@dob datetime,
	@gradepoint float,
	@active varchar (10)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [Registration]
           ([studentID]
           ,[name]
           ,[dob]
           ,[gradepoint]
		   ,[active])
     VALUES
           (@studentID ,@name ,@dob ,@gradepoint,@active)
END

--DROP PROCEDURE [AddStudent] 