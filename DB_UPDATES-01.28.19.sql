USE EMPLEADOSDB

-- =============================================
-- Author:		JAVIER HERNANDEZ
-- Create date: 1/28/2019
-- Description:	ADDS NEW RESETKEY FIELD TO DBO.USERS
-- =============================================
ALTER TABLE USERS ADD ResetKey NVARCHAR(50) NULL;

-- =============================================
-- Author:		JAVIER HERNANDEZ
-- Create date: 1/28/2019
-- Description:	GETS THE USER'S EMAIL
-- =============================================
GO
CREATE PROCEDURE SP_GETUSEREMAIL
	-- Add the parameters for the stored procedure here
	@USERNAME NCHAR(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT EMP_EMAIL+';' AS EMP_EMAIL FROM EMP_DATOS AS A
	INNER JOIN USERS AS B ON A.ID_EMP=B.ID_Emp
	WHERE B.USERNAME=@USERNAME
END

-- =============================================
-- Author:		JAVIER HERNANDEZ
-- Create date: 1/28/2019
-- Description:	SETS THE RESETKEY THAT'S SENT TO USERS EMAIL
-- =============================================
GO
CREATE PROCEDURE SP_SETRESETKEY
	-- Add the parameters for the stored procedure here
	@USERNAME AS NCHAR(20), @RESETKEY AS NVARCHAR(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE USERS SET RESETKEY=@RESETKEY WHERE USERNAME=@USERNAME
END

-- =============================================
-- Author:		JAVIER HERNANDEZ
-- Create date: 1/28/2019
-- Description:	SETS NEW PASSWORD FOR USER
-- =============================================
GO
CREATE PROCEDURE SP_RESETPASSWORD
	-- Add the parameters for the stored procedure here
	@USERNAME AS NCHAR(20), @PASSWORD AS NVARCHAR(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE USERS SET PASSWORD=@PASSWORD WHERE USERNAME=@USERNAME
	SELECT 1 AS RESULT
END