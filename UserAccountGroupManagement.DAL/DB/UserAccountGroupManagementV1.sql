USE [master]
GO
/****** Object:  Database [UserAccountGroupManagementV1]    Script Date: 17/06/2022 10:51:08 AM ******/
CREATE DATABASE [UserAccountGroupManagementV1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'UserAccountGroupManagementV1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\UserAccountGroupManagementV1.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'UserAccountGroupManagementV1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\UserAccountGroupManagementV1_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [UserAccountGroupManagementV1] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [UserAccountGroupManagementV1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [UserAccountGroupManagementV1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [UserAccountGroupManagementV1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [UserAccountGroupManagementV1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [UserAccountGroupManagementV1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [UserAccountGroupManagementV1] SET ARITHABORT OFF 
GO
ALTER DATABASE [UserAccountGroupManagementV1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [UserAccountGroupManagementV1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [UserAccountGroupManagementV1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [UserAccountGroupManagementV1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [UserAccountGroupManagementV1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [UserAccountGroupManagementV1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [UserAccountGroupManagementV1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [UserAccountGroupManagementV1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [UserAccountGroupManagementV1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [UserAccountGroupManagementV1] SET  DISABLE_BROKER 
GO
ALTER DATABASE [UserAccountGroupManagementV1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [UserAccountGroupManagementV1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [UserAccountGroupManagementV1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [UserAccountGroupManagementV1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [UserAccountGroupManagementV1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [UserAccountGroupManagementV1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [UserAccountGroupManagementV1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [UserAccountGroupManagementV1] SET RECOVERY FULL 
GO
ALTER DATABASE [UserAccountGroupManagementV1] SET  MULTI_USER 
GO
ALTER DATABASE [UserAccountGroupManagementV1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [UserAccountGroupManagementV1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [UserAccountGroupManagementV1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [UserAccountGroupManagementV1] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [UserAccountGroupManagementV1] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'UserAccountGroupManagementV1', N'ON'
GO
ALTER DATABASE [UserAccountGroupManagementV1] SET QUERY_STORE = OFF
GO
USE [UserAccountGroupManagementV1]
GO
/****** Object:  User [dev]    Script Date: 17/06/2022 10:51:08 AM ******/
CREATE USER [dev] FOR LOGIN [dev] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [dev]
GO
/****** Object:  Table [dbo].[usr_account]    Script Date: 17/06/2022 10:51:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usr_account](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[login_name] [varchar](100) NOT NULL,
	[password] [varchar](100) NOT NULL,
	[password_salt] [varchar](100) NOT NULL,
	[created] [datetime] NOT NULL,
	[modified] [datetime] NULL,
	[status] [char](1) NULL,
 CONSTRAINT [PK_usr_account] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usr_group]    Script Date: 17/06/2022 10:51:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usr_group](
	[id] [smallint] IDENTITY(1,1) NOT NULL,
	[group_name] [varchar](100) NOT NULL,
	[description] [varchar](200) NULL,
	[created] [datetime] NOT NULL,
	[modified] [datetime] NULL,
 CONSTRAINT [PK_usr_group] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usr_user]    Script Date: 17/06/2022 10:51:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usr_user](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[first_name] [varchar](80) NOT NULL,
	[middle_name] [varchar](80) NULL,
	[last_name] [varchar](80) NOT NULL,
	[dob] [date] NOT NULL,
	[created] [datetime] NOT NULL,
	[modified] [datetime] NULL,
	[account_fk] [bigint] NOT NULL,
 CONSTRAINT [PK_epe_employee] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usr_user_group_link]    Script Date: 17/06/2022 10:51:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usr_user_group_link](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[user_fk] [bigint] NOT NULL,
	[group_fk] [smallint] NOT NULL,
	[created] [datetime] NOT NULL,
 CONSTRAINT [PK_epe_employee_group_link] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_usr_account]    Script Date: 17/06/2022 10:51:08 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_usr_account] ON [dbo].[usr_account]
(
	[login_name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_usr_group]    Script Date: 17/06/2022 10:51:08 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_usr_group] ON [dbo].[usr_group]
(
	[group_name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[usr_account] ADD  CONSTRAINT [DF_usr_account_status]  DEFAULT ('A') FOR [status]
GO
/****** Object:  StoredProcedure [dbo].[st_HasUserGoupsChanged_select]    Script Date: 17/06/2022 10:51:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[st_HasUserGoupsChanged_select](@user_id bigint, @xml_rec XML)  
AS
BEGIN  

    DECLARE @result bit = 0
	
	DECLARE @error_num int = 0
	DECLARE @groupCount int = 0
	DECLARE @userGroupLink int = 0

	DECLARE @max int
	DECLARE @index int
	
	--row attributes or elements
	DECLARE @id smallint
	
	--count the number of rows
	SELECT @max = @xml_rec.query('<e>
								{ count(root/rec) }
							</e>'
						   ).value('e[1]','int')

--start loop thru the rows     
	SET @index = 1	     
	WHILE(@index <= @max AND @error_num = 0)
	BEGIN
		--get a record
		SELECT @id = T.c.value('(ID)[1]', 'smallint')	
		FROM   @xml_rec.nodes('/root/rec[position()=sql:variable("@index")]') T(c)

		SELECT @groupCount = COUNT(*)
		FROM [dbo].[usr_user_group_link]
		WHERE [user_fk] = @user_id AND [group_fk] = @id
		

		IF(@groupCount = 0)
		BEGIN
			SET @result = 1
			SET @error_num = -2007
		END
	           		
		SET @index = @index + 1
	END

	IF(@error_num =0)
	BEGIN
		SELECT @groupCount = COUNT(*)
		FROM [dbo].[usr_user_group_link]

		IF(@max = @groupCount)
		BEGIN
			SET @result = 0
		END
		ELSE
			BEGIN
				SET @result = 1
			END
	END
    RETURN @result;  
END
GO
/****** Object:  StoredProcedure [dbo].[st_user_delete]    Script Date: 17/06/2022 10:51:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[st_user_delete]
(
--usr_user
 @user_id bigint

--usr_account
,@account_id bigint

--other
,@error_num int = 0 output

)
AS
BEGIN

	BEGIN TRANSACTION
	
	BEGIN TRY

--usr_account	
		
			DELETE FROM [dbo].[usr_account]
			WHERE id = @account_id
				
			
			IF(@@ROWCOUNT = 0)
			BEGIN
				SET @error_num = -2008
			END
	

--start usr_user					
			IF(@error_num = 0)
			BEGIN
		
				DELETE FROM [dbo].[usr_user]
				WHERE id = @user_id
					   
			           
				IF(@@ROWCOUNT = 0)
				BEGIN
					SET @error_num = -2009		
				END
				
			END

--end usr_user								
--start group link			
			IF(@error_num = 0)
			BEGIN
				DELETE FROM dbo.usr_user_group_link
				WHERE user_fk = @user_id

				--IF(@@ROWCOUNT = 0)
				--BEGIN
				--PRINT '@error_num' + CONVERT(NVARCHAR(50), @error_num)
				--	SET @error_num = -2010		
				--END

			END
			
--end group link	

		IF(@error_num =0)
		BEGIN
			COMMIT TRANSACTION
		END
			ELSE
				BEGIN
					ROLLBACK TRANSACTION
				END    
	END TRY
	BEGIN CATCH
		SET @error_num = -2004
		ROLLBACK TRANSACTION

	END CATCH		
	
END
GO
/****** Object:  StoredProcedure [dbo].[st_user_insert]    Script Date: 17/06/2022 10:51:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[st_user_insert]
(
--usr_user
 @user_id bigint = 0 output
, @first_name varchar(80)
, @middle_name varchar(80)
, @last_name varchar(80)
, @dob date

--group link
--,@user_group_fk smallint
, @xml_user_group_fk_rec XML

--usr_account
,@account_id bigint = 0 output
,@login_name varchar(100)
,@password varchar(100)
,@password_salt varchar(100)
,@status char(1)

--other
,@error_num int = 0 output
,@created datetime
)
AS
BEGIN

	BEGIN TRANSACTION
	
	BEGIN TRY

--usr_account	
		IF(NOT EXISTS(SELECT 1 FROM usr_account WHERE login_name = @login_name))
		BEGIN
		
			INSERT INTO [dbo].[usr_account]
				   ([login_name]
				   ,[password]
				   ,[password_salt]
				   ,[status]
				   ,[created]
				   )
			 VALUES
				   (
				   @login_name
				   ,@password
				   ,@password_salt
				   ,@status
				   ,@created
				   )			
			
			IF(@@ROWCOUNT > 0)
			BEGIN
				SET @account_id = SCOPE_IDENTITY()
			END
			ELSE
				BEGIN
					SET @error_num = -2000
				END

--start usr_user					
			IF(@error_num = 0)
			BEGIN
		
				INSERT INTO [dbo].[usr_user]
					   ([first_name]
					   ,[middle_name]
					   ,[last_name]
					   ,[dob]
					   ,[account_fk]
					   ,[created])
				 VALUES
					   (@first_name
					   ,@middle_name
					   ,@last_name
					   ,@dob
					   ,@account_id
					   ,@created
					   )
					   
			           
				IF(@@ROWCOUNT > 0)
				BEGIN
					SET @user_id = SCOPE_IDENTITY()		
				END
					ELSE
						BEGIN
							SET @error_num = -2001
						END
			END

--end usr_user								
--start group link			
			IF(@error_num = 0)
			BEGIN
				EXECUTE	[st_userGroups_insert]
						@user_id,
						@xml_user_group_fk_rec,
						@created,
						@error_num OUTPUT
			END
			
--end group link	
		END
		ELSE
			BEGIN
				--login name is already exist
				SET @error_num = -2003
			END		
		IF(@error_num =0)
		BEGIN
			COMMIT TRANSACTION
		END
			ELSE
				BEGIN
					ROLLBACK TRANSACTION
				END    
	END TRY
	BEGIN CATCH
		SET @error_num = -2004
		ROLLBACK TRANSACTION

	END CATCH		
	
END
GO
/****** Object:  StoredProcedure [dbo].[st_user_update]    Script Date: 17/06/2022 10:51:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[st_user_update]
(
--usr_user
 @user_id bigint
, @first_name varchar(80)
, @middle_name varchar(80)
, @last_name varchar(80)
, @dob date

--group link
, @xml_user_group_fk_rec XML

--usr_account
,@account_id bigint
,@password varchar(100)
,@password_salt varchar(100)
,@status char(1)

--other
,@error_num int = 0 output
,@modified datetime
)
AS
BEGIN

	BEGIN TRANSACTION
	
	BEGIN TRY

--usr_account	
			UPDATE [dbo].[usr_account]
			SET [password] = @password
				,[password_salt] = @password_salt
				,[status] = @status
				,modified = @modified
			WHERE id = @account_id
				
			
			IF(@@ROWCOUNT = 0)
			BEGIN
				SET @error_num = -2005
			END
	

--start usr_user					
			IF(@error_num = 0)
			BEGIN
		
				UPDATE [dbo].[usr_user]
				SET	   [first_name] = @first_name
					   ,[middle_name] = @middle_name
					   ,[last_name] = @last_name
					   ,[dob] = @dob
					   ,[modified] = @modified
				WHERE id = @user_id
					   
			           
				IF(@@ROWCOUNT = 0)
				BEGIN
					SET @error_num = -2006		
				END
				
			END

--end usr_user								
--start group link			
			IF(@error_num = 0)
			BEGIN
				EXECUTE	[st_userGroup_delsert]
						@user_id,
						@xml_user_group_fk_rec,
						@modified,
						@error_num OUTPUT
			END
			
--end group link	

		IF(@error_num =0)
		BEGIN
			COMMIT TRANSACTION
		END
			ELSE
				BEGIN
					ROLLBACK TRANSACTION
				END    
	END TRY
	BEGIN CATCH
		SET @error_num = -2004
		ROLLBACK TRANSACTION

	END CATCH		
	
END
GO
/****** Object:  StoredProcedure [dbo].[st_userGroup_delete]    Script Date: 17/06/2022 10:51:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[st_userGroup_delete](
	@id bigint
	, @error_num int = 0 output
	)
AS
BEGIN

BEGIN TRANSACTION
	
	BEGIN TRY
	
		IF ( NOT EXISTS(SELECT 1 FROM [dbo].[usr_user_group_link] WHERE group_fk = @id))
		BEGIN
			DELETE 
			FROM   [dbo].[usr_group]
			WHERE  [id] = @id
			

			IF(@@ROWCOUNT = 0)
			BEGIN
				SET @error_num = -1003
			END
		END	
			ELSE
			BEGIN
				SET @error_num = -1004
			END

		IF(@error_num =0)
			BEGIN
				COMMIT TRANSACTION
			END
				ELSE
					BEGIN
						ROLLBACK TRANSACTION
						END   
	END TRY
	BEGIN CATCH
		SET @error_num = -1001
		ROLLBACK TRANSACTION
		
	END CATCH	
END
GO
/****** Object:  StoredProcedure [dbo].[st_userGroup_delsert]    Script Date: 17/06/2022 10:51:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[st_userGroup_delsert]
(
@user_fk BIGINT
,@xml_rec XML
,@created DATETIME
, @error_num int = 0 output
)
AS
BEGIN
	DECLARE @hasUserGroupChanged bit = 0

	DECLARE @max int
	DECLARE @index int
	
	--row attributes or elements
	DECLARE @id smallint
	

	EXEC	@hasUserGroupChanged = [dbo].[st_HasUserGoupsChanged_select]
																@user_id = @user_fk,
																@xml_rec = @xml_rec
	
	IF(@hasUserGroupChanged = 1)
	BEGIN

		--count the number of rows
		SELECT @max = @xml_rec.query('<e>
								{ count(root/rec) }
							</e>'
						   ).value('e[1]','int')
						   
		--delete all existing [[usr_user_group_link] for user fk
		DELETE FROM [usr_user_group_link]
		WHERE user_fk = @user_fk

		--start loop thru the rows     
		SET @index = 1	     

		WHILE(@index <= @max AND @error_num = 0)
		BEGIN
			--get a record
			SELECT @id = T.c.value('(ID)[1]', 'smallint')	
			FROM   @xml_rec.nodes('/root/rec[position()=sql:variable("@index")]') T(c)

			INSERT INTO [dbo].[usr_user_group_link]
						([user_fk]
						,[group_fk]
						,[created])
					VALUES
						(@user_fk
						,@id
						,@created)			

			IF(@@ROWCOUNT = 0)
			BEGIN
				SET @error_num = -2007
			END
	           		
			SET @index = @index + 1
		END
	END
	
END
GO
/****** Object:  StoredProcedure [dbo].[st_userGroup_insert]    Script Date: 17/06/2022 10:51:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Vinhlan Ong
-- Create date: 10/6/2022
-- Description:	initial creation
-- =============================================
CREATE PROCEDURE [dbo].[st_userGroup_insert](
	@id bigint = 0 output
	, @group_name varchar(100)
	, @description varchar(200)
	, @created datetime
	, @error_num int = 0 output
	)
AS
BEGIN

BEGIN TRANSACTION
	
	BEGIN TRY
	
			INSERT INTO [dbo].[usr_group]
				   (group_name
				   ,description
				   ,[created]
				   )
			 VALUES
				   (
				   @group_name
				   ,@description
				   ,@created
				  )

			IF(@@ROWCOUNT > 0)
			BEGIN
				SET @id = SCOPE_IDENTITY()
			END
			ELSE
				BEGIN
					SET @error_num = -1000
				END

			IF(@error_num =0)
				BEGIN
					COMMIT TRANSACTION
				END
					ELSE
						BEGIN
							ROLLBACK TRANSACTION
						END    
	END TRY
	BEGIN CATCH
		SET @error_num = -1001
		ROLLBACK TRANSACTION
		
	END CATCH	
END
GO
/****** Object:  StoredProcedure [dbo].[st_userGroup_update]    Script Date: 17/06/2022 10:51:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[st_userGroup_update](
	@id bigint
	, @group_name varchar(100)
	, @description varchar(200)
	, @modified datetime
	, @error_num int = 0 output
	)
AS
BEGIN

BEGIN TRANSACTION
	
	BEGIN TRY
	
			UPDATE [dbo].[usr_group]
			SET	   group_name = @group_name
				   ,description = @description
				   ,[modified] = @modified
			WHERE id = @id
		

			IF(@@ROWCOUNT > 0)
			BEGIN
				SET @id = SCOPE_IDENTITY()
			END
			ELSE
				BEGIN
					SET @error_num = -1002
				END

			IF(@error_num =0)
				BEGIN
					COMMIT TRANSACTION
				END
					ELSE
						BEGIN
							ROLLBACK TRANSACTION
						END    
	END TRY
	BEGIN CATCH
		SET @error_num = -1001
		ROLLBACK TRANSACTION
		
	END CATCH	
END
GO
/****** Object:  StoredProcedure [dbo].[st_userGroupAll_select]    Script Date: 17/06/2022 10:51:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[st_userGroupAll_select]
AS
BEGIN

	SELECT [id]
      ,[group_name]
      ,[description]
      ,[created]
      ,[modified]
	FROM [dbo].[usr_group]
	ORDER BY group_name
END
GO
/****** Object:  StoredProcedure [dbo].[st_userGroups_insert]    Script Date: 17/06/2022 10:51:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[st_userGroups_insert]
(
@user_fk BIGINT
,@xml_rec XML
,@created DATETIME
, @error_num int = 0 output
)
AS
BEGIN

	DECLARE @max int
	DECLARE @index int
	
	--row attributes or elements
	DECLARE @id smallint
	
--count the number of rows
	SELECT @max = @xml_rec.query('<e>
								{ count(root/rec) }
							</e>'
						   ).value('e[1]','int')
						   
	--start loop thru the rows     
	SET @index = 1	     
	
	WHILE(@index <= @max AND @error_num = 0)
	BEGIN
		--get a record
		SELECT @id = T.c.value('(ID)[1]', 'smallint')	
		FROM   @xml_rec.nodes('/root/rec[position()=sql:variable("@index")]') T(c)

		INSERT INTO [dbo].[usr_user_group_link]
					([user_fk]
					,[group_fk]
					,[created])
				VALUES
					(@user_fk
					,@id
					,@created)			

		IF(@@ROWCOUNT = 0)
		BEGIN
			SET @error_num = -2002
		END
	           		
		SET @index = @index + 1
	END
	
END
GO
/****** Object:  StoredProcedure [dbo].[st_userList_select]    Script Date: 17/06/2022 10:51:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[st_userList_select]
AS
BEGIN	
	SELECT usr.[id]
      ,[first_name]
      ,[middle_name]
      ,[last_name]
	  ,dob
      ,usrAcc.[login_name]
      ,usr.[created]
      ,usrAcc.id account_fk
	  ,usrAcc.status
	  --,ug.group_name
	FROM [dbo].[usr_user] usr
		INNER JOIN usr_account usrAcc ON usr.account_fk = usr.id
		--INNER JOIN usr_user_group_link ugl ON ugl.user_fk = usr.id
		--INNER JOIN usr_group ug ON ug.id = ugl.group_fk

END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'must be a valid email address' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'usr_account', @level2type=N'COLUMN',@level2name=N'login_name'
GO
USE [master]
GO
ALTER DATABASE [UserAccountGroupManagementV1] SET  READ_WRITE 
GO
