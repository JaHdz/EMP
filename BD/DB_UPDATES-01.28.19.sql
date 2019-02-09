USE EMPLEADOSDB

-- =============================================
-- Author:		JAVIER HERNANDEZ
-- Create date: 1/28/2019
-- Description:	ADDS NEW RESETKEY FIELD TO DBO.USERS
-- =============================================
ALTER TABLE USERS ADD ResetKey NVARCHAR(50) NOT NULL DEFAULT ('');

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
	SET NOCOUNT ON;

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
	SET NOCOUNT ON;

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
	SET NOCOUNT ON;

	UPDATE USERS SET PASSWORD=@PASSWORD WHERE USERNAME=@USERNAME
	SELECT 1 AS RESULT
END
-- =============================================
-- Author:		JAVIER HERNANDEZ
-- Create date: 1/28/2019
-- Description:	ADDS NEW FIELDS TO THIS PROCEUDRE
-- =============================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE CONSULTA_EMP
	@ID as int
AS
BEGIN
	   select 
	   A.[ID_Emp]
      ,A.[Emp_Name]
      ,A.[Emp_APat]
      ,A.[Emp_AMat]
      ,A.[Emp_Col]
      ,A.[Emp_Ciudad]
      ,A.[Emp_CP]
      ,A.[Emp_Cel]
      ,A.[Emp_Tel]
      ,A.[Emp_EdoCivil]
      ,A.[Emp_Nacionalidad]
      ,A.[Emp_Salario]
      ,A.[Emp_NEducativo]
      ,A.[Emp_Email]
      ,A.[Emp_FNac]
      ,A.[Emp_RFC]
      ,A.[Emp_NSS]
      ,A.[Emp_FAlta]
      ,A.[Emp_Sexo]
      ,A.[Emp_Curp]
      ,A.[Emp_Domicilio]
      ,A.[Emp_Activo] 
      ,A.[Emp_Tipo]
      ,A.[Emp_Sup]
      ,A.[Emp_FEfectiva]
      ,A.[ID_Depto]
      ,A.[ID_Puesto]
      ,A.[ID_User]
	  ,A.Emp_EN
	  ,I.Img_Emp 
	  ,B.Fecha_Baja
	  ,b.Alerta
	  ,b.Motivo
	  ,b.NProv
      ,b.NClientes
  FROM [EmpleadosDB].[dbo].[Emp_Datos] AS A 
  Left JOIN [dbo].[Emp_Imagen] AS I ON A.ID_Emp=I.ID_Emp 
  Left JOIN [dbo].[Emp_Bajas] AS B ON A.ID_Emp= B.ID_Emp 
  where A.ID_Emp=@ID
END