USE [EmpleadosDB]
GO
/****** Object:  StoredProcedure [dbo].[CATALOGOS]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[CATALOGOS]

 @TIPO as NVARCHAR(20), @CONDICION AS NVARCHAR(30)
AS
BEGIN  

   if(@TIPO='CAT')
	BEGIN 
		IF(@CONDICION='')
		BEGIN
			SELECT [ID_Cap] AS Codigo, [CA_Codigo] AS Descripcion FROM [dbo].[Cat_Capacitacion] WHERE CA_STATUS=1 
		END 
		ELSE
		BEGIN
				SELECT [ID_Cap] AS Codigo, [CA_Codigo] AS Descripcion FROM [dbo].[Cat_Capacitacion] where CA_STATUS=1 AND ([CA_Codigo] like '%'+@CONDICION+'%' OR [CA_Desc] like '%'+@CONDICION+'%')
		END
	END

    if(@TIPO='EV')
	BEGIN 
		IF(@CONDICION='')
		BEGIN
			SELECT [EV_Codigo] AS Codigo,[EV_Descipcion] AS Descripcion FROM [dbo].[Cat_Evaluacion] WHERE EV_ESTATUS=1
		END 
		ELSE
		BEGIN
			SELECT [EV_Codigo] AS Codigo,[EV_Descipcion] AS Descripcion FROM [dbo].[Cat_Evaluacion] where  EV_ESTATUS=1 AND ([EV_Codigo] like '%'+@CONDICION+'%' OR [EV_Descipcion] like '%'+@CONDICION+'%')
		END
	END
	if(@TIPO='EN')
	BEGIN 
		IF(@CONDICION='')
		BEGIN
			SELECT Codigo, Descripcion FROM [dbo].[Cat_EN]
		END 
		ELSE
		BEGIN
			SELECT Codigo, Descripcion FROM [dbo].[Cat_EN] where (Codigo like '%'+@CONDICION+'%' OR Descripcion like '%'+@CONDICION+'%')
		END
	END
	if(@TIPO='DE')
	BEGIN 
		IF(@CONDICION='')
		BEGIN
			SELECT id_depto,Codigo, Descripcion FROM [dbo].[Cat_DEPTO] WHERE ESTATUS=1
		END 
		ELSE
		BEGIN
			SELECT id_depto,Codigo, Descripcion FROM [dbo].[Cat_DEPTO] where ESTATUS=1 AND (Codigo like '%'+@CONDICION+'%' OR Descripcion like '%'+@CONDICION+'%')
		END
	END

		if(@TIPO='EQ')
	BEGIN 
		IF(@CONDICION='')
		BEGIN
			SELECT [Nombre] AS Codigo, Descripcion FROM [dbo].[Cat_Equipos] WHERE ESTATUS=1
		END 
		ELSE
		BEGIN
			SELECT [Nombre] AS Codigo, Descripcion FROM [dbo].[Cat_Equipos] where ESTATUS=1 AND ([Nombre] like '%'+@CONDICION+'%' OR Descripcion like '%'+@CONDICION+'%')
		END
	END

		if(@TIPO='EMP')
	BEGIN 
		IF(@CONDICION='')
		BEGIN
			SELECT [ID_Emp] AS Codigo, [Name] AS Descripcion FROM [dbo].[Empleados]
		END 
		ELSE
		BEGIN
			SELECT [ID_Emp] AS Codigo,[Name] AS Descripcion FROM [dbo].[Empleados] where ([ID_Emp] like '%'+@CONDICION+'%' OR [Name] like '%'+@CONDICION+'%')
		END
	END

	if(left(@TIPO,2)='CI')
	BEGIN 
		IF(@CONDICION='')
		BEGIN
			SELECT a.Codigo, a.Descripcion FROM [dbo].[Cat_CIUDAD] as a inner join [dbo].[Cat_EN] as b on a.ID_Estado=b.Codigo where  a.ID_Estado=RIGHT(@tipo,2)
		END 
		ELSE
		BEGIN
			select a.Codigo, a.Descripcion FROM [dbo].[Cat_CIUDAD] as a inner join [dbo].[Cat_EN] as b on a.ID_Estado=b.Codigo where a.ID_Estado=RIGHT(@tipo,2) and 
			 (a.Codigo like '%'+@CONDICION+'%' OR a.Descripcion like '%'+@CONDICION+'%')
		END
	END
	if(@TIPO='PU')
	BEGIN 
		IF(@CONDICION='')
		BEGIN
			SELECT [ID_Puesto] AS Codigo,[Nombre] AS Descripcion FROM [dbo].[Cat_Puesto] WHERE ESTATUS=1 
		END 
		ELSE
		BEGIN
			SELECT [ID_Puesto] AS Codigo,[Nombre] AS Descripcion FROM [dbo].[Cat_Puesto] where  ESTATUS=1 AND ( [ID_Puesto] like '%' + @CONDICION +'%' OR [Nombre] like '%'+@CONDICION+'%')
		END
	END
	if(@TIPO='SU')
	BEGIN 
		IF(@CONDICION='')
		BEGIN
			SELECT [ID_Emp] as Codigo, [Name] AS Descripcion FROM [dbo].[Cat_Super] WHERE [Activo]=1
		END 
		ELSE
		BEGIN
			SELECT [ID_Emp] as Codigo, [Name] AS Descripcion FROM [dbo].[Cat_Super] as a where [Activo]=1 AND ([ID_Emp] like '%' + @CONDICION +'%' OR [Name] like '%'+@CONDICION+'%')
		END		
	END
	if(@TIPO='TI')
	BEGIN 
		IF(@CONDICION='')
		BEGIN
			SELECT Codigo, Descripcion FROM [dbo].[Cat_TE] WHERE ESTATUS=1
		END 
		ELSE
		BEGIN
			SELECT Codigo, Descripcion FROM [dbo].[Cat_TE] where ESTATUS=1 AND ( Codigo like '%' + @CONDICION +'%' OR Descripcion like '%'+@CONDICION+'%')
		END
	END
END
GO
/****** Object:  StoredProcedure [dbo].[Consulta_AnteLab]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Consulta_AnteLab]
 @ID as int
AS
BEGIN  
 SELECT [ID_Ant]
      ,[ID_Emp]
      ,[Ant_FInicio]
      ,[Ant_FFin]
      ,[Ant_NEmpresa]
      ,[Ant_Cargo]
      ,[Ant_Salario]
      ,[Ant_Tel]
      ,[Ant_Motivo]
      ,[Ant_Contacto]
  FROM [dbo].[Emp_AnteLab]
  where [ID_Emp]=@ID 
END
GO
/****** Object:  StoredProcedure [dbo].[Consulta_CAP]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Consulta_CAP]

AS
BEGIN  
SELECT  [ID_Cap]
      ,[CA_Codigo]
      ,[CA_Desc]
      ,[CA_Status]
  FROM [EmpleadosDB].[dbo].[Cat_Capacitacion]
END
GO
/****** Object:  StoredProcedure [dbo].[Consulta_Capacitacion]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Consulta_Capacitacion]
 @ID as int
AS
BEGIN  
 SELECT [ID_Cap_Emp]
      ,[ID_Cap]
      ,[ID_Emp]
      ,[Fecha]
      ,[Comentario]
  FROM [dbo].[Capacitaciones_Emp]
  where [ID_Emp]=@ID 
END
GO
/****** Object:  StoredProcedure [dbo].[Consulta_CEmergencia]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Consulta_CEmergencia]
 @ID as int
AS
BEGIN  
  SELECT [ID_CEmergencia]
      ,[ID_Emp]
      ,[CE_Nombre]
      ,[CE_APat]
      ,[CE_AMat]
      ,[CE_Parentesco]
      ,[CE_Telefono]
      ,[CE_Celular]
  FROM [dbo].[Emp_CEmergencia]
  where [ID_Emp]=@ID 
END
GO
/****** Object:  StoredProcedure [dbo].[Consulta_depto]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Consulta_depto]

AS
BEGIN  
SELECT   [ID_Depto]
      ,[Codigo]
      ,[Descripcion]
      ,[Estatus]
  FROM [EmpleadosDB].[dbo].[Cat_DEPTO]
  WHERE ESTATUS=1
END
GO
/****** Object:  StoredProcedure [dbo].[Consulta_EAsignado]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Consulta_EAsignado]
 @ID as int
AS
BEGIN  
SELECT [ID_Assig]
      ,[ID_Equipo]
      ,[ID_Emp]
      ,[Fecha]
      ,[Regreso]
      ,[Fecha_R]
      ,[Comentario]
	  ,[ID_User]
  FROM [dbo].[Equipo_Asignado]
  where [ID_Emp]=@ID 
END
GO
/****** Object:  StoredProcedure [dbo].[Consulta_Emp]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Consulta_Emp]

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
	  ,A.Emp_CiudadEstado
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
GO
/****** Object:  StoredProcedure [dbo].[Consulta_Enf]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Consulta_Enf]
 @ID as int
AS
BEGIN  
  SELECT [ID_Enf] ,[Text]
  FROM [dbo].[Emp_Enfermedades]
  where [ID_Emp]=@ID 
END
GO
/****** Object:  StoredProcedure [dbo].[Consulta_EQ]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Consulta_EQ]

AS
BEGIN  
	SELECT  E.[ID_Equipo],E.[Nombre],E.[Descripcion],E.[Costo],E.Estatus,E.ID_Depto,D.Codigo 
	FROM Cat_Equipos AS E INNER JOIN CAT_DEPTO AS D ON E.ID_Depto=D.ID_Depto 
	WHERE E.ESTATUS=1
END
GO
/****** Object:  StoredProcedure [dbo].[Consulta_ES]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Consulta_ES]
 @ID as int
AS
BEGIN  
SELECT [ID_EstSocio]
      ,e.[ID_Emp]
      ,[Viv_Tipo]
      ,[Viv_Condiciones]
      ,[Viv_Luz]
      ,[Viv_Tel]
      ,[Viv_Agua]
      ,[Viv_Drenaje]
      ,[Viv_TubGas]
      ,[Viv_RecBasura]
      ,[Viv_TVCable]
      ,[Viv_Internet]
      ,[Viv_SisSeg]
      ,[Trasn_Metro]
      ,[Trans_Publico]
      ,[Trans_Taxi]
      ,[Trans_VehPropio]
      ,[Act_EvSociales]
      ,[Act_EvCominitarios]
      ,[Act_Museos]
      ,[Act_Teatros]
      ,[Act_Cines]
      ,[Act_FesCulturaes]
      ,[Act_ZonasArq]
      ,[Act_Vaciones]
      ,[Act_PlazasPub]
      ,[Act_ParquesNat]
      ,[Act_PaquesDiv]
      ,[GF_Renta]
      ,[GF_Colegio]
      ,[GF_Despensa]
      ,[GF_Servicios]
      ,[ES_Pasatiempos]
      ,[ES_Religion]
      ,[ES_Verificador]
      ,[ES_Observaciones]
	  ,i.Img_Dom
  FROM [EmpleadosDB].[dbo].[ES] as e
  left join [dbo].[Emp_Imagen] as i on i.ID_Emp=e.ID_Emp
  where E.[ID_Emp]=@ID 
END
GO
/****** Object:  StoredProcedure [dbo].[Consulta_EV]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Consulta_EV]

AS
BEGIN  
SELECT  [ID_Evalua]
      ,[EV_Codigo]
      ,[EV_Descipcion]
      ,[EV_Estatus]
  FROM [EmpleadosDB].[dbo].[Cat_Evaluacion]
END
GO
/****** Object:  StoredProcedure [dbo].[Consulta_Evaluaciones]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Consulta_Evaluaciones]
 @ID as int
AS
BEGIN  
SELECT [ID_EvEmp]
,[ID_Codigo]
      ,[ID_Emp]
      ,[Fecha]
      ,[Estatus]
      ,[ID_User]
  FROM [dbo].[Evaluaciones_Emp]
  where [ID_Emp]=@ID 
END
GO
/****** Object:  StoredProcedure [dbo].[Consulta_Examenes_Medicos]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Consulta_Examenes_Medicos]
 @ID as int
AS
BEGIN  
 SELECT [ID_EM]
      ,[ID_Emp]
      ,[EM_Estudio]
      ,[EM_Resultado]
      ,[EM_Fecha]
      ,[EM_FechaProximo]
  FROM [dbo].[Examenes_Medicos]
  where [ID_Emp]=@ID 
END
GO
/****** Object:  StoredProcedure [dbo].[Consulta_FamEsp]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Consulta_FamEsp]

 @ID as int
AS
BEGIN
	 SELECT [ID_Persona]
      ,[ID_Emp]
      ,[Fam_Tipo]
      ,[Fam_Nombre]
      ,[Fam_APat]
      ,[Fam_AMat]
      ,[Fam_Nacion]
      ,[Fam_FNac]
      ,[Fam_Genero]
  FROM [EmpleadosDB].[dbo].[Emp_DatosFamilia]
  where [ID_Emp]=@ID and [Fam_Tipo]='CONYUGE'
END
GO
/****** Object:  StoredProcedure [dbo].[Consulta_FamHijos]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Consulta_FamHijos]

 @ID as int
AS
BEGIN
	 SELECT [ID_Persona]
      ,[ID_Emp]
      ,[Fam_Tipo]
      ,[Fam_Nombre]
      ,[Fam_APat]
      ,[Fam_AMat]
      ,[Fam_Nacion]
      ,[Fam_FNac]
      ,[Fam_Genero]
  FROM [EmpleadosDB].[dbo].[Emp_DatosFamilia]
  where [ID_Emp]=@ID and [Fam_Tipo]='HIJO'
END
GO
/****** Object:  StoredProcedure [dbo].[Consulta_OI]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Consulta_OI]
 @ID as int
AS
BEGIN  
 SELECT  ID_OIng,
			 [OIng_Desc]
      ,[OIng_Cantidad]
  FROM [dbo].[ES_OtrosIngresos]
  where [ID_EstSocio]=@ID 
END
GO
/****** Object:  StoredProcedure [dbo].[Consulta_PU]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Consulta_PU]

AS
BEGIN  
SELECT   [ID_Puesto]
      ,[Nombre]
      ,[Descripcion]
      ,[Riesgo]
	  ,Estatus
  FROM [EmpleadosDB].[dbo].[Cat_Puesto]
  WHERE ESTATUS=1
END
GO
/****** Object:  StoredProcedure [dbo].[Consulta_REF]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Consulta_REF]
 @ID as int
AS
BEGIN  
 SELECT ID_Ref,
 [Ref_Nombre]
      ,[Ref_Ocupacion]
      ,[Ref_TRelacion]
      ,[Ref_TiempoC]
  FROM [dbo].[ES_Referencias]
  where [ID_EstSocio]=@ID 
END
GO
/****** Object:  StoredProcedure [dbo].[Consulta_SU]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Consulta_SU]

AS
BEGIN  
SELECT  [ID_Super]
      ,[ID_Emp]
      ,[Activo]
      ,[Name]
  FROM [EmpleadosDB].[dbo].[Cat_Super]
  WHERE ACTIVO=1 
END
GO
/****** Object:  StoredProcedure [dbo].[Consulta_TE]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Consulta_TE]

AS
BEGIN  
SELECT [ID_TE]
      ,[Codigo]
      ,[Descripcion]
      ,[Estatus]
  FROM [EmpleadosDB].[dbo].[Cat_TE]
  WHERE ESTATUS=1
END
GO
/****** Object:  StoredProcedure [dbo].[Consulta_users]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Consulta_users]
AS
BEGIN  
SELECT [ID_User]
      ,[ID_Emp]
      ,[UserName]
      ,[Password]
      ,[Activo]
      ,[Acceso]
  FROM [EmpleadosDB].[dbo].[Users]
  WHERE ID_USER<>0 AND ACTIVO=1
END
GO
/****** Object:  StoredProcedure [dbo].[DELETE_ANTE]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[DELETE_ANTE]
 @ID as int
AS
BEGIN  
DELETE FROM [dbo].[Emp_AnteLab] WHERE @ID=ID_Ant
END
GO
/****** Object:  StoredProcedure [dbo].[DELETE_CAPACITACION]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[DELETE_CAPACITACION]
 @ID as int
AS
BEGIN  
DELETE FROM [dbo].[Capacitaciones_Emp] WHERE @ID=[ID_Cap_Emp]
END
GO
/****** Object:  StoredProcedure [dbo].[DELETE_CAPACITACION_ADMIN]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[DELETE_CAPACITACION_ADMIN]
 @ID as int
AS
BEGIN  
	IF EXISTS(SELECT ID_CAP FROM CAPACITACIONES_EMP WHERE ID_CAP=@ID)
	BEGIN
		SELECT 0
	END
	ELSE	
		DELETE FROM [dbo].[Cat_Capacitacion] WHERE @ID=ID_CAP
		SELECT 1
END
GO
/****** Object:  StoredProcedure [dbo].[DELETE_CEMERGENCIA]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[DELETE_CEMERGENCIA]
 @ID as int
AS
BEGIN  
DELETE FROM [dbo].[Emp_CEmergencia] WHERE @ID=[ID_CEmergencia]
END
GO
/****** Object:  StoredProcedure [dbo].[DELETE_DEPTO_ADMIN]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[DELETE_DEPTO_ADMIN]
 @ID as int
AS
BEGIN  
	IF EXISTS(SELECT ID_DEPTO FROM EMP_DATOS WHERE ID_DEPTO=@ID)
	BEGIN
		SELECT 0
	END
	ELSE
	DELETE FROM [dbo].CAT_DEPTO WHERE ID_DEPTO=@ID
		SELECT 1
END
GO
/****** Object:  StoredProcedure [dbo].[DELETE_EMPTYPE_ADMIN]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[DELETE_EMPTYPE_ADMIN]
 @ID as int
AS
BEGIN  
	IF EXISTS(SELECT ID_EMP FROM EMP_DATOS WHERE EMP_TIPO=@ID AND EMP_ACTIVO=1)
	BEGIN
		SELECT 0
	END
	ELSE
	DELETE FROM [dbo].CAT_TE WHERE  ID_TE=@ID	
		SELECT 1
END
GO
/****** Object:  StoredProcedure [dbo].[DELETE_Enfermedades]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[DELETE_Enfermedades]
 @ID as int
AS
BEGIN  
DELETE FROM [dbo].[Emp_Enfermedades] WHERE @ID=[ID_Enf]
END
GO
/****** Object:  StoredProcedure [dbo].[DELETE_EQUIPMENT_ADMIN]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[DELETE_EQUIPMENT_ADMIN]
 @ID as int
AS
BEGIN  
	IF EXISTS(SELECT ID_EQUIPO FROM EQUIPO_ASIGNADO WHERE ID_EQUIPO=@ID)
	BEGIN
		SELECT 0
	END
	ELSE
		DELETE FROM [dbo].CAT_EQUIPOS WHERE ID_EQUIPO=@ID
		SELECT 1
END
GO
/****** Object:  StoredProcedure [dbo].[DELETE_Evaluaciones]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[DELETE_Evaluaciones]
 @ID as int
AS
BEGIN  
DELETE FROM [dbo].[Evaluaciones_Emp] WHERE @ID=[ID_EvEmp]
END
GO
/****** Object:  StoredProcedure [dbo].[DELETE_EVALUATION_ADMIN]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[DELETE_EVALUATION_ADMIN]
 @ID as VARCHAR(50)
AS
BEGIN  
	IF EXISTS(SELECT ID_EVEMP FROM EVALUACIONES_EMP WHERE ID_CODIGO=@ID)
	BEGIN
		SELECT 0
	END
	ELSE	
	DELETE FROM [dbo].CAT_EVALUACION WHERE EV_CODIGO=@ID
		SELECT 1
END
GO
/****** Object:  StoredProcedure [dbo].[DELETE_EXAMENES_MEDICOS]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[DELETE_EXAMENES_MEDICOS]
 @ID as int
AS
BEGIN  
DELETE FROM [dbo].[Examenes_Medicos] WHERE @ID=ID_EM
END
GO
/****** Object:  StoredProcedure [dbo].[DELETE_Familia]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[DELETE_Familia]
 @ID as int
AS
BEGIN  
DELETE FROM [dbo].[Emp_DatosFamilia] WHERE @ID=ID_Persona
END
GO
/****** Object:  StoredProcedure [dbo].[DELETE_OI]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[DELETE_OI]
 @ID as int
AS
BEGIN  
DELETE FROM [dbo].[ES_OtrosIngresos] WHERE @ID=[ID_EstSocio]
END
GO
/****** Object:  StoredProcedure [dbo].[DELETE_OI2]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[DELETE_OI2]
 @ID as int
AS
BEGIN  
DELETE FROM [dbo].[ES_OtrosIngresos] WHERE @ID=[ID_OIng]
END
GO
/****** Object:  StoredProcedure [dbo].[DELETE_POSITIONS_ADMIN]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[DELETE_POSITIONS_ADMIN]
 @ID as VARCHAR(50)
AS
BEGIN  
	IF EXISTS(SELECT ID_PUESTO FROM EMP_DATOS WHERE ID_PUESTO=@ID)
	BEGIN
		SELECT 0
	END
	ELSE	
    	DELETE FROM [dbo].CAT_PUESTO WHERE ID_PUESTO=@ID
		SELECT 1
END
GO
/****** Object:  StoredProcedure [dbo].[DELETE_REF]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[DELETE_REF]
 @ID as int
AS
BEGIN  
DELETE FROM [dbo].[ES_Referencias] WHERE @ID=[ID_Ref] 
END
GO
/****** Object:  StoredProcedure [dbo].[DELETE_REF2]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[DELETE_REF2]
 @ID as int
AS
BEGIN  
DELETE FROM [dbo].[ES_Referencias] WHERE @ID=[ID_Ref]
END
GO
/****** Object:  StoredProcedure [dbo].[DELETE_SUPERVISOR_ADMIN]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[DELETE_SUPERVISOR_ADMIN]
 @ID as int
AS
BEGIN  
	IF EXISTS(SELECT A.ID_EMP FROM EMP_DATOS AS A INNER JOIN CAT_SUPER AS B 
				ON A.EMP_SUP=B.ID_EMP WHERE B.ID_SUPER=@ID AND B.ACTIVO=1)
	BEGIN
		SELECT 0
	END
	ELSE	
	    DELETE FROM [dbo].CAT_SUPER WHERE ID_EMP=@ID
		SELECT 1
END
GO
/****** Object:  StoredProcedure [dbo].[SELECT_CATALOGOS]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SELECT_CATALOGOS]

 @TIPO as NVARCHAR(20), @CONDICION AS NVARCHAR(30)
AS
BEGIN

    if(@TIPO='CAT')
	BEGIN 
			SELECT [CA_Desc] AS Descripcion FROM [dbo].[Cat_Capacitacion] where ( [CA_Codigo]= @CONDICION)	
	END
	if(@TIPO='EV')
	BEGIN 
			SELECT [EV_Descipcion] AS Descripcion FROM [dbo].[Cat_Evaluacion] where ( [EV_Codigo]= @CONDICION)	
	END
	if(@TIPO='EN')
	BEGIN 
			SELECT Descripcion FROM [dbo].[Cat_EN] where (Codigo = @CONDICION)	
	END
	if(@TIPO='DE')
	BEGIN 
			SELECT top 1 Descripcion FROM [dbo].[Cat_DEPTO] where (Codigo = @CONDICION or [ID_Depto]=@CONDICION)	
	END
	if(@TIPO='CI')
	BEGIN
			SELECT Descripcion FROM [dbo].[Cat_CIUDAD] where (Codigo = @CONDICION)
	END
	if(@TIPO='PU')
	BEGIN 
			SELECT [Descripcion] AS Descripcion FROM [dbo].[Cat_Puesto] where ( [ID_Puesto] = @CONDICION )
	END

    if(@TIPO='EQ')
	BEGIN 
			SELECT [Descripcion] AS Descripcion FROM [dbo].[Cat_Equipos] where ( [Nombre] = @CONDICION )
	END
	if(@TIPO='SU')
	BEGIN	
			SELECT [Name] AS Descripcion FROM [dbo].[Cat_Super] as a where [Activo]=1 AND [ID_Emp] = @CONDICION 
	END
	if(@TIPO='TI')
	BEGIN		
			SELECT [Descripcion] FROM [dbo].[Cat_TE] where  ( Codigo = @CONDICION)
	END
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GETUSEREMAIL]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[SP_GETUSEREMAIL]
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
GO
/****** Object:  StoredProcedure [dbo].[SP_RESETPASSWORD]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[SP_RESETPASSWORD] 
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
GO
/****** Object:  StoredProcedure [dbo].[SP_SETRESETKEY]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[SP_SETRESETKEY] 
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
GO
/****** Object:  StoredProcedure [dbo].[SP_UserAndPass]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SP_UserAndPass]
@user varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	IF UPPER(@USER) ='ADMIN'
		BEGIN
			SELECT a.[ID_User] as [ID_Emp] , a.[ID_Emp] as NoEmp, [UserName] as [User], [Password] as Pass, 'EASY System Administrator' Nom, Acceso 
			from [dbo].[Users] as a 
			where  a.[UserName] = @user
		END
	ELSE
		SELECT a.[ID_User] as [ID_Emp] , a.[ID_Emp] as NoEmp, [UserName] as [User], [Password] as Pass, [Emp_Name]+' '+[Emp_APat]+''+[Emp_AMat] Nom, Acceso 
		from [dbo].[Users] as a left join [dbo].[Emp_Datos] b on a.[ID_Emp]=b.[ID_Emp]
		where  a.[UserName] = @user and [Activo]=1
END
GO
/****** Object:  StoredProcedure [dbo].[SP_VALIDRESETKEY]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[SP_VALIDRESETKEY] 
	-- Add the parameters for the stored procedure here
	@USERNAME AS NCHAR(20), @RESETKEY AS NVARCHAR(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DECLARE @S_RESETKEY NVARCHAR(50)
	SELECT @S_RESETKEY=RESETKEY FROM USERS WHERE USERNAME=@USERNAME 
	IF @S_RESETKEY=@RESETKEY 
		BEGIN
			UPDATE USERS SET RESETKEY='' WHERE USERNAME=@USERNAME
			SELECT 1 AS RESULT
		END
	ELSE
		SELECT 0 AS RESULT	
END
GO
/****** Object:  StoredProcedure [dbo].[UDSP_CIUDAD]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JAVIER HERNANDEZ
-- Create date: 08/27/2018
-- Description:	INSERT OR UPDATE POSITIONS
-- =============================================
ALTER PROCEDURE [dbo].[UDSP_CIUDAD]
	-- Add the parameters for the stored procedure here
	@CODIGO NVARCHAR(20),@DESCRIPTION NVARCHAR(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	IF EXISTS(SELECT * FROM CAT_CIUDAD WHERE CODIGO=@CODIGO)
	BEGIN
		UPDATE [dbo].CAT_CIUDAD
		SET [Descripcion] = @DESCRIPTION
		WHERE CODIGO=@CODIGO
	END
	ELSE
	BEGIN
		INSERT INTO [dbo].CAT_CIUDAD(CODIGO,[Descripcion])
		VALUES(@CODIGO,@DESCRIPTION)
	END
END

GO
/****** Object:  StoredProcedure [dbo].[UDSP_DEPTO]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JAVIER HERNANDEZ
-- Create date: 08/27/2018
-- Description:	INSERT OR UPDATE POSITIONS
-- =============================================
ALTER PROCEDURE [dbo].[UDSP_DEPTO]
	-- Add the parameters for the stored procedure here
	@ID INT,@CODIGO NVARCHAR(20),@DESCRIPTION NVARCHAR(50), @STATUS INT
AS
	DECLARE @RESULT BIT
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	IF EXISTS(SELECT * FROM CAT_DEPTO WHERE ID_Depto=@ID)
	BEGIN
		UPDATE [dbo].CAT_DEPTO
		SET [Descripcion] = @DESCRIPTION,[Estatus]=@STATUS
		WHERE [ID_Depto]=@ID
		 SET @RESULT=1
	END
	ELSE
	BEGIN
		IF NOT EXISTS(SELECT * FROM CAT_DEPTO WHERE CODIGO=@CODIGO)
		BEGIN
			 INSERT INTO [dbo].CAT_DEPTO(CODIGO,[Descripcion],[Estatus])
			 VALUES(@CODIGO,@DESCRIPTION,@STATUS)
			 SET @RESULT=1
		END
		ELSE
		BEGIN
			SET @RESULT=0
		END
	END
	SELECT @RESULT AS RESULT
END

GO
/****** Object:  StoredProcedure [dbo].[UDSP_EMPLOYEE]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JAVIER HERNANDEZ
-- Create date: 08/27/2018
-- Description:	INSERT OR UPDATE EMPLOYEE'S INFORMATION
-- =============================================
ALTER PROCEDURE [dbo].[UDSP_EMPLOYEE]
	-- Add the parameters for the stored procedure here
	@EMPLOYEE INT,@NAME NVARCHAR(50),@P_LASTNAME NVARCHAR(50),@M_LASTNAME NVARCHAR(50),@COL NVARCHAR(20),@CITY NVARCHAR(20),@ZIP INT,@CELLPHONE NVARCHAR(20),
	@PHONE NVARCHAR(20),@C_STATUS NVARCHAR(20),@NATIONALITY NVARCHAR(20),@WAGE NUMERIC(18,2),@EDUCATION NVARCHAR(20),@EMAIL NVARCHAR(20),@BIRTHDATE DATETIME,
	@RFC NVARCHAR(20),@SSN NUMERIC(18,0),@REG_DATE DATETIME,@GENDER NVARCHAR(1),@CURP NVARCHAR(20),@ADDRESS NVARCHAR(50),@ACTIVE BIT,@TYPE NVARCHAR(20),
	@SUPERVISOR INT, @EF_DATE DATETIME,@DEPARTMENT NVARCHAR(10),@POSITION INT,@USER INT, @Emp_EN NVARCHAR(10),@EMP_IMAGE IMAGE, @CITYSTATE VARCHAR(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	declare @ID table (ID int)
    -- Insert statements for procedure here
	IF EXISTS(SELECT * FROM EMP_DATOS WHERE ID_EMP=@EMPLOYEE)
		BEGIN
			UPDATE [dbo].[Emp_Datos]
			SET [Emp_Name] = @NAME,[Emp_APat] = @P_LASTNAME,[Emp_AMat] = @M_LASTNAME,[Emp_Col] = @COL ,[Emp_Ciudad] = @CITY,[Emp_CP] = @ZIP ,
				[Emp_Cel] = @CELLPHONE,[Emp_Tel] = @PHONE ,[Emp_EdoCivil] = @C_STATUS,[Emp_Nacionalidad] =@NATIONALITY,[Emp_Salario] = @WAGE,
				[Emp_NEducativo] = @EDUCATION,[Emp_Email] = @EMAIL,[Emp_FNac] = @BIRTHDATE,[Emp_RFC] = @RFC,[Emp_NSS] =@SSN,[Emp_FAlta] =@REG_DATE ,
				[Emp_Sexo] = @GENDER ,[Emp_Curp] = @CURP ,[Emp_Domicilio] = @ADDRESS,[Emp_Activo] = @ACTIVE ,[Emp_Tipo] =@TYPE,[Emp_Sup] = @SUPERVISOR,
				[Emp_FEfectiva] = @EF_DATE,ID_Depto = @DEPARTMENT ,[ID_Puesto] = @POSITION,[ID_User] = @USER,[Emp_EN]=@Emp_EN, Emp_CiudadEstado=@CITYSTATE
			 WHERE ID_EMP=@EMPLOYEE

		END
	ELSE
		BEGIN
			INSERT INTO [dbo].[Emp_Datos]
					   ([Emp_Name],[Emp_APat],[Emp_AMat],[Emp_Col],[Emp_Ciudad],[Emp_CP],[Emp_Cel],[Emp_Tel],[Emp_EdoCivil],[Emp_Nacionalidad],[Emp_Salario]
					   ,[Emp_NEducativo],[Emp_Email],[Emp_FNac],[Emp_RFC] ,[Emp_NSS],[Emp_FAlta],[Emp_Sexo],[Emp_Curp],[Emp_Domicilio],[Emp_Activo],[Emp_Tipo],
					   [Emp_Sup],[Emp_FEfectiva],[Emp_EN] ,ID_Depto,[ID_Puesto],[ID_User],Emp_CiudadEstado )
					   OUTPUT INSERTED.ID_EMP INTO @ID
			VALUES(@NAME,@P_LASTNAME,@M_LASTNAME,@COL,@CITY,@ZIP,@CELLPHONE,@PHONE,@C_STATUS,@NATIONALITY,@WAGE,@EDUCATION,@EMAIL,@BIRTHDATE,@RFC,@SSN,
				   @REG_DATE,@GENDER,@CURP,@ADDRESS,@ACTIVE,@TYPE,@SUPERVISOR,@EF_DATE,@Emp_EN,@DEPARTMENT,@POSITION,@USER,@CITYSTATE)
		SET @EMPLOYEE=(SELECT ID FROM @ID)
		END
		
		IF EXISTS(SELECT * FROM EMP_IMAGEN WHERE ID_EMP=@EMPLOYEE)
		BEGIN
			IF @EMP_IMAGE IS NOT NULL
			BEGIN
				UPDATE [dbo].[Emp_Imagen]
				SET [Img_Emp] = @EMP_IMAGE
				WHERE ID_EMP=@EMPLOYEE
			END			
		END
	ELSE
		BEGIN
			INSERT INTO [dbo].[Emp_Imagen]([ID_Emp],[Img_Emp])
			VALUES(@EMPLOYEE,@EMP_IMAGE)
		END
END

GO
/****** Object:  StoredProcedure [dbo].[UDSP_EMPLOYEE_ALTA]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JAVIER HERNANDEZ
-- Create date: 08/27/2018
-- Description:	INSERT OR UPDATE EMPLOYEE'S INFORMATION
-- =============================================
ALTER PROCEDURE [dbo].[UDSP_EMPLOYEE_ALTA]
	-- Add the parameters for the stored procedure here
	@EMPLOYEE INT,@ACTIVE BIT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF EXISTS(SELECT * FROM EMP_DATOS WHERE ID_EMP=@EMPLOYEE)
		BEGIN
			UPDATE [dbo].[Emp_Datos]
			SET [Emp_Activo] = @ACTIVE
			 WHERE ID_EMP=@EMPLOYEE

	END
END

GO
/****** Object:  StoredProcedure [dbo].[UDSP_EMPLOYEE_CONTACTS]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JAVIER HERNANDEZ
-- Create date: 08/27/2018
-- Description:	INSERT OR UPDATE EMERGENCY CONTACTS
-- =============================================
ALTER PROCEDURE [dbo].[UDSP_EMPLOYEE_CONTACTS]
	-- Add the parameters for the stored procedure here
	@CONTACT INT,@EMPLOYEE INT, @NAME NVARCHAR(30), @P_LASTNAME NVARCHAR(20),@M_LASTNAME NVARCHAR(20),@RELATIONSHIP NVARCHAR(20),
	@PHONE NVARCHAR(20),@CELLPHONE NVARCHAR(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @RESULT BIT
    -- Insert statements for procedure here
	IF EXISTS(SELECT * FROM EMP_CEMERGENCIA WHERE ID_CEMERGENCIA=@CONTACT)
		BEGIN
			UPDATE [dbo].[Emp_CEmergencia]
			SET [ID_Emp] =@EMPLOYEE,[CE_Nombre] =@NAME,[CE_APat] = @P_LASTNAME,[CE_AMat] = @M_LASTNAME,[CE_Parentesco] = @RELATIONSHIP,[CE_Telefono] =@PHONE,
				   [CE_Celular] = @CELLPHONE
			WHERE ID_CEMERGENCIA=@CONTACT
			SET @RESULT=1
		END
	ELSE
		BEGIN
			IF NOT EXISTS(SELECT * FROM EMP_CEMERGENCIA WHERE ID_EMP=@EMPLOYEE AND [CE_Nombre]=@NAME AND [CE_APat]=@P_LASTNAME  AND[CE_AMat] = @M_LASTNAME )
			BEGIN
				INSERT INTO [dbo].[Emp_CEmergencia]([ID_Emp],[CE_Nombre],[CE_APat],[CE_AMat],[CE_Parentesco],[CE_Telefono],[CE_Celular])
				VALUES(@EMPLOYEE,@NAME,@P_LASTNAME,@M_LASTNAME,@RELATIONSHIP,@PHONE,@CELLPHONE)
				SET @RESULT=1
			END
			ELSE
			BEGIN
				SET @RESULT=0
			END
		END
	SELECT @RESULT AS RESULT
END

GO
/****** Object:  StoredProcedure [dbo].[UDSP_EMPLOYEE_DISCHARGE]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JAVIER HERNANDEZ
-- Create date: 08/27/2018
-- Description:	INSERT OR UPDATE EMPLOYEE'S DISCHARGE
-- =============================================
ALTER PROCEDURE [dbo].[UDSP_EMPLOYEE_DISCHARGE]
	-- Add the parameters for the stored procedure here
	@DISCHARGE INT, @EMPLOYEE INT, @DIS_DATE DATETIME,@REASON NVARCHAR(50),@ALERT BIT,@USER INT,@PROV BIT,@CLIENTE BIT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DECLARE @RESULT BIT
	IF EXISTS(SELECT * FROM EMP_BAJAS WHERE ID_Baja=@DISCHARGE)
		BEGIN
			UPDATE [dbo].[Emp_Bajas]
			SET [ID_Emp] =@EMPLOYEE,[Fecha_Baja] = @DIS_DATE,[Motivo] = @REASON,[Alerta] = @ALERT,[ID_user] = @USER, NProv=@PROV ,NClientes=@CLIENTE 
			WHERE ID_BAJA=@DISCHARGE
			SET @RESULT=1
		END
	ELSE
		BEGIN
			IF NOT EXISTS(SELECT * FROM EMP_BAJAS WHERE ID_EMP=@EMPLOYEE AND FECHA_BAJA=@DIS_DATE)
			BEGIN
				INSERT INTO [dbo].[Emp_Bajas]([ID_Emp],[Fecha_Baja],[Motivo],[Alerta],[ID_user],NProv ,NClientes )
				VALUES (@EMPLOYEE,@DIS_DATE,@REASON,@ALERT,@USER,@PROV,@CLIENTE )
				SET @RESULT=1
			END
			ELSE
			BEGIN

				SET @RESULT=0
			END
		END
		SELECT @RESULT AS RESULT
END
GO
/****** Object:  StoredProcedure [dbo].[UDSP_EMPLOYEE_EVALUATION]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:                            <Author,,Name>
-- Create date: <Create Date,,>
-- Description:    <Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[UDSP_EMPLOYEE_EVALUATION]
                -- Add the parameters for the stored procedure here
                @ID_EE INT, @EMPLOYEE INT, @STATUS NVARCHAR(20),@USER INT ,@ID_Codigo NVARCHAR(20)
AS
BEGIN
                -- SET NOCOUNT ON added to prevent extra result sets from
                -- interfering with SELECT statements.
                SET NOCOUNT ON;
	DECLARE @RESULT BIT
    -- Insert statements for procedure here
	IF EXISTS(SELECT * FROM [Evaluaciones_Emp] WHERE ID_EvEmp=@ID_EE )
		BEGIN
			UPDATE [dbo].[Evaluaciones_Emp]
			SET [ID_Emp] = @EMPLOYEE,[ID_Codigo]=@ID_Codigo,[Fecha] = GETDATE(),[Estatus] = @STATUS,[ID_User] = @USER 
			WHERE ID_EvEmp=@ID_EE 
			SET @RESULT=1
		END
	ELSE
		BEGIN
			IF NOT EXISTS(SELECT * FROM EVALUACIONES_EMP WHERE ID_EMP=@EMPLOYEE AND ID_CODIGO=@ID_CODIGO)
				BEGIN
					INSERT INTO [dbo].[Evaluaciones_Emp]([ID_Emp],[Fecha],[Estatus],[ID_User],[ID_Codigo])
					VALUES (@EMPLOYEE,GETDATE(),@STATUS ,@USER,@ID_Codigo)
					SET @RESULT=1
				END
			ELSE
				BEGIN
					SET @RESULT=0
				END
		END
		SELECT @RESULT AS RESULT
END
GO
/****** Object:  StoredProcedure [dbo].[UDSP_EMPLOYEE_FAMILY]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JAVIER HERNANDEZ
-- Create date: 08/27/2018
-- Description:	INSERT OR UPDATE EMPLOYEE'S FAMILY
-- =============================================
ALTER PROCEDURE [dbo].[UDSP_EMPLOYEE_FAMILY]
	-- Add the parameters for the stored procedure here
	@FAM_ID INT,@EMPLOYEE INT,@TYPE NVARCHAR(10),@NAME NVARCHAR(20),@P_LASTNAME NVARCHAR(20),@M_LASTMANEM NVARCHAR(20),@NATIONALITY NVARCHAR(20),
	@BIRTHDATE DATETIME, @GENDER NVARCHAR(1)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @RESULT BIT
    -- Insert statements for procedure here
	IF EXISTS(SELECT * FROM EMP_DATOSFAMILIA WHERE ID_PERSONA=@FAM_ID)
		BEGIN
			UPDATE [dbo].[Emp_DatosFamilia]
			SET [ID_Emp] = @EMPLOYEE,[Fam_Tipo] = @TYPE,[Fam_Nombre] = @NAME,[Fam_APat] = @P_LASTNAME,[Fam_AMat] = @M_LASTMANEM,[Fam_Nacion] = @NATIONALITY,
				[Fam_FNac] =@BIRTHDATE,[Fam_Genero] = @GENDER
			WHERE ID_PERSONA=@FAM_ID
			SET @RESULT=1
		END
	ELSE
		BEGIN
		IF NOT EXISTS(SELECT * FROM EMP_DATOSFAMILIA WHERE [Fam_Nombre]=@NAME and [Fam_APat]=@P_LASTNAME and [Fam_AMat]=@M_LASTMANEM AND [ID_Emp]=@EMPLOYEE)
		begin
			IF	@TYPE='CONYUGE'
			BEGIN
				IF EXISTS(SELECT * FROM EMP_DATOSFAMILIA WHERE [Fam_Tipo]=@TYPE AND [ID_Emp]=@EMPLOYEE)
				BEGIN
					UPDATE [dbo].[Emp_DatosFamilia]
					SET [ID_Emp] = @EMPLOYEE,[Fam_Tipo] = @TYPE,[Fam_Nombre] = @NAME,[Fam_APat] = @P_LASTNAME,[Fam_AMat] = @M_LASTMANEM,[Fam_Nacion] = @NATIONALITY,
						[Fam_FNac] =@BIRTHDATE,[Fam_Genero] = @GENDER
					WHERE [Fam_Tipo]=@TYPE AND [ID_Emp]=@EMPLOYEE
					SET @RESULT=1
				END
				ELSE
				BEGIN
					INSERT INTO [dbo].[Emp_DatosFamilia]([ID_Emp],[Fam_Tipo],[Fam_Nombre],[Fam_APat],[Fam_AMat],[Fam_Nacion],[Fam_FNac],[Fam_Genero])
					VALUES(@EMPLOYEE,@TYPE,@NAME,@P_LASTNAME,@M_LASTMANEM ,@NATIONALITY,@BIRTHDATE,@GENDER)
					SET @RESULT=1
				END
			END
			ELSE
			BEGIN
				INSERT INTO [dbo].[Emp_DatosFamilia]([ID_Emp],[Fam_Tipo],[Fam_Nombre],[Fam_APat],[Fam_AMat],[Fam_Nacion],[Fam_FNac],[Fam_Genero])
				VALUES(@EMPLOYEE,@TYPE,@NAME,@P_LASTNAME,@M_LASTMANEM ,@NATIONALITY,@BIRTHDATE,@GENDER)
				SET @RESULT=1
			END
		END
		ELSE
		BEGIN
		SET @RESULT=0
		END

		END
			SELECT @RESULT AS RESULT
END
GO
/****** Object:  StoredProcedure [dbo].[UDSP_EMPLOYEE_IMAGE]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JAVIER HERNANDEZ
-- Create date: 08/27/2018
-- Description:	INSERT OR UPDATE EMPLOYEE IMAGES
-- =============================================
ALTER PROCEDURE [dbo].[UDSP_EMPLOYEE_IMAGE]
	-- Add the parameters for the stored procedure here
	@EMPLOYEE INT,@EMP_IMAGE IMAGE,@HOU_IMAGE IMAGE
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF EXISTS(SELECT * FROM EMP_IMAGEN WHERE ID_EMP=@EMPLOYEE)
		BEGIN
			IF @EMP_IMAGE IS NOT NULL
			BEGIN
				UPDATE [dbo].[Emp_Imagen]
				SET [Img_Emp] = @EMP_IMAGE
				WHERE ID_EMP=@EMPLOYEE
			END
			IF @HOU_IMAGE IS NOT NULL
			BEGIN
				UPDATE [dbo].[Emp_Imagen]
				SET [Img_Dom] = @HOU_IMAGE
				WHERE ID_EMP=@EMPLOYEE
			END
		END
	ELSE
		BEGIN
			INSERT INTO [dbo].[Emp_Imagen]([ID_Emp],[Img_Emp],[Img_Dom])
			VALUES(@EMPLOYEE,@EMP_IMAGE,@HOU_IMAGE)
		END
END

GO
/****** Object:  StoredProcedure [dbo].[UDSP_EMPLOYEE_JOBHISTORY]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JAVIER HERNANDEZ
-- Create date: 08/27/2018
-- Description:	INSERT OR UPDATE JOB HISTORY
-- =============================================
ALTER PROCEDURE [dbo].[UDSP_EMPLOYEE_JOBHISTORY]
	-- Add the parameters for the stored procedure here
	@PREV_ID INT,@EMPLOYEE INT, @START DATETIME, @END DATETIME ,@COMPANY NVARCHAR(30),@POSITION NVARCHAR(20),@WAGE DECIMAL(18,2),@PHONE NVARCHAR(20),
	@REASON NVARCHAR(50),@CONTACT NVARCHAR(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @RESULT BIT
    -- Insert statements for procedure here
	IF EXISTS(SELECT * FROM [dbo].[Emp_AnteLab] WHERE ID_ANT=@PREV_ID)
	BEGIN
		UPDATE [dbo].[Emp_AnteLab]
		SET [ID_Emp] = @EMPLOYEE,[Ant_FInicio] = @START,[Ant_FFin] = @END,[Ant_NEmpresa] = @COMPANY,[Ant_Cargo] =@POSITION,[Ant_Salario] = @WAGE,[Ant_Tel] = @PHONE,
			[Ant_Motivo] =@REASON,[Ant_Contacto] = @CONTACT
		WHERE ID_ANT=@PREV_ID
		SET @RESULT=1
	END
	ELSE
		BEGIN
			IF NOT EXISTS(SELECT * FROM EMP_ANTELAB WHERE ID_EMP=@EMPLOYEE AND ANT_NEMPRESA=@COMPANY)
			BEGIN
				INSERT INTO [dbo].[Emp_AnteLab]([ID_Emp],[Ant_FInicio],[Ant_FFin],[Ant_NEmpresa],[Ant_Cargo],[Ant_Salario],[Ant_Tel],[Ant_Motivo],[Ant_Contacto])
				VALUES(@EMPLOYEE,@START,@END,@COMPANY,@COMPANY,@WAGE,@PHONE,@REASON,@CONTACT)
				SET @RESULT=1
			END
			ELSE
			BEGIN
				SET @RESULT=0
			END

		END
		SELECT @RESULT AS RESULT
END
GO
/****** Object:  StoredProcedure [dbo].[UDSP_EMPLOYEE_MEDCONDITIONS]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JAVIER HERNANDEZ
-- Create date: 08/27/2018
-- Description:	INSERT OR UPDATE EMPLOYEE MEDICAL CONDITIONS
-- =============================================
ALTER PROCEDURE [dbo].[UDSP_EMPLOYEE_MEDCONDITIONS]
	-- Add the parameters for the stored procedure here
	@CON_ID INT ,@EMPLOYEE INT, @DESCRIPTION NVARCHAR(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @RESULT BIT
    -- Insert statements for procedure here
	IF EXISTS(SELECT * FROM EMP_ENFERMEDADES WHERE ID_ENF=@CON_ID)
		BEGIN
			UPDATE [dbo].[Emp_Enfermedades]
			SET [ID_Emp] = @EMPLOYEE,[Text] = @DESCRIPTION
			WHERE ID_ENF=@CON_ID
			SET @RESULT=1
		END
	ELSE
		BEGIN
			IF NOT EXISTS(SELECT * FROM EMP_ENFERMEDADES WHERE ID_EMP=@EMPLOYEE AND TEXT=@DESCRIPTION)
			BEGIN
				INSERT INTO [dbo].[Emp_Enfermedades]([ID_Emp],[Text])
				VALUES(@EMPLOYEE,@DESCRIPTION)
				SET @RESULT=1
			END
			ELSE
			BEGIN
				SET @RESULT=0
			END
		END
		SELECT @RESULT AS RESULT
END

GO
/****** Object:  StoredProcedure [dbo].[UDSP_EMPLOYEE_SUPER]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:                            <Author,,Name>
-- Create date: <Create Date,,>
-- Description:    <Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[UDSP_EMPLOYEE_SUPER]
                -- Add the parameters for the stored procedure here
                @ID INT,@ID_Emp INT,@NAME NVARCHAR(50),@ESTATUS BIT
AS
BEGIN
                -- SET NOCOUNT ON added to prevent extra result sets from
                -- interfering with SELECT statements.
              SET NOCOUNT ON;
			  DECLARE @RESULT BIT

    -- Insert statements for procedure here
                IF EXISTS(SELECT * FROM [Cat_Super] WHERE ID_Super=@ID)
                BEGIN
                                UPDATE [dbo].[Cat_Super] SET [NAME]= (SELECT [Emp_Name]+' '+[Emp_APat]+' '+[Emp_AMat] FROM [dbo].[Emp_Datos] WHERE [ID_Emp]=@ID_Emp),Activo=@ESTATUS
                                WHERE ID_Super=@ID
								SET @RESULT =1 
                END
                ELSE
                BEGIN

								IF NOT EXISTS(SELECT * FROM  [Cat_Super] WHERE ID_Emp=@ID_Emp)
								BEGIN
										  INSERT INTO [dbo].[Cat_Super](ID_Emp,[NAME],Activo)
														VALUES(@ID_Emp,((SELECT [Emp_Name]+' '+[Emp_APat]+' '+[Emp_AMat] FROM [dbo].[Emp_Datos] WHERE [ID_Emp]=@ID_Emp)),@ESTATUS)
										  SET @RESULT=1
								END
								ELSE
								BEGIN
										SET @RESULT=0
								END
				END
				SELECT @RESULT AS  RESULT
END
GO
/****** Object:  StoredProcedure [dbo].[UDSP_EMPLOYEE_TRAINING]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JAVIER HERNANDEZ
-- Create date: 08/27/2018
-- Description:	INSERT OR UPDATE EMPLOYEES TRAINING
-- =============================================
ALTER PROCEDURE [dbo].[UDSP_EMPLOYEE_TRAINING]
	-- Add the parameters for the stored procedure here
	@ID INT, @TRAINING INT,@EMPLOYEE INT , @DATE DATETIME, @COMENTARIO NVARCHAR(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @RESULT BIT
    -- Insert statements for procedure here
	IF EXISTS(SELECT * FROM CAPACITACIONES_EMP WHERE ID_CAP_EMP =@ID)
	BEGIN
		UPDATE [dbo].[Capacitaciones_Emp]
		SET [ID_Cap] = @TRAINING ,[ID_Emp] =@EMPLOYEE ,[Fecha] = @DATE, COMENTARIO=@COMENTARIO 
		 WHERE ID_CAP_EMP =@ID
		 SET @RESULT=1
	END
	ELSE
	BEGIN
		IF NOT EXISTS (SELECT * FROM CAPACITACIONES_EMP WHERE ID_CAP=@TRAINING)
		BEGIN
			INSERT INTO [dbo].[Capacitaciones_Emp]([ID_Cap],[ID_Emp],[Fecha],COMENTARIO)
			VALUES(@TRAINING,@EMPLOYEE ,@DATE,@COMENTARIO )
			SET @RESULT=1
		END
		ELSE
		BEGIN
			SET @RESULT=0
		END
	END
	SELECT @RESULT AS  RESULT
END
GO
/****** Object:  StoredProcedure [dbo].[UDSP_EMPLOYEE_TYPE]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:                            <Author,,Name>
-- Create date: <Create Date,,>
-- Description:    <Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[UDSP_EMPLOYEE_TYPE]
                -- Add the parameters for the stored procedure here
                @ID INT,@CODE NVARCHAR(20),@DESCRIPTION NVARCHAR(50),@ESTATUS BIT
AS
	DECLARE @RESULT BIT
BEGIN
                -- SET NOCOUNT ON added to prevent extra result sets from
                -- interfering with SELECT statements.
                SET NOCOUNT ON;

    -- Insert statements for procedure here
                IF EXISTS(SELECT * FROM CAT_TE WHERE ID_TE=@ID)
                BEGIN
                                UPDATE [dbo].[Cat_TE] SET [Descripcion] = @DESCRIPTION,ESTATUS=@ESTATUS
                                WHERE ID_TE=@ID 
								 SET @RESULT=1
                END
                ELSE
                BEGIN
				IF NOT EXISTS(SELECT * FROM CAT_TE WHERE CODIGO=@CODE)
				BEGIN
                            INSERT INTO [dbo].[Cat_TE]([Codigo],[Descripcion],ESTATUS)
                            VALUES(@CODE,@DESCRIPTION,@ESTATUS)
						    SET @RESULT=1
               END
			   ELSE
			   BEGIN
							SET @RESULT=0
			   END
		       END
		      SELECT @RESULT AS RESULT
END
GO
/****** Object:  StoredProcedure [dbo].[UDSP_EQUIPMENT]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JAVIER HERNANDEZ
-- Create date: 08/27/2018
-- Description:	INSERT OR UPDATE EQUIPMENT
-- =============================================
ALTER PROCEDURE [dbo].[UDSP_EQUIPMENT]
	-- Add the parameters for the stored procedure here
	@EQU_ID INT,@NAME NVARCHAR(20),@DESCRIPTION NVARCHAR(30),@COST NUMERIC(18,2), @STATUS INT, @DEPTO int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @RESULT BIT
    -- Insert statements for procedure here
	IF EXISTS(SELECT * FROM CAT_EQUIPOS WHERE ID_EQUIPO=@EQU_ID)
	BEGIN
		UPDATE [dbo].[Cat_Equipos]
		SET [Nombre] = @NAME,[Descripcion] = @DESCRIPTION,[Costo] = @COST, ESTATUS=@STATUS, id_depto=@DEPTO
		WHERE  ID_EQUIPO=@EQU_ID
		SET @RESULT=1
	END
	ELSE
	BEGIN
		IF NOT EXISTS(SELECT * FROM Cat_Equipos WHERE NOMBRE=@NAME)
		BEGIN
			INSERT INTO [dbo].[Cat_Equipos]([Nombre],[Descripcion],[Costo],ESTATUS,id_depto)
			VALUES(@NAME,@DESCRIPTION,@COST,@STATUS,@DEPTO)
			SET @RESULT=1
		END
		ELSE
		BEGIN
			SET @RESULT=0
		END
	END
	SELECT @RESULT AS RESULT
END
GO
/****** Object:  StoredProcedure [dbo].[UDSP_EQUIPMENT_ASSIGNED]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JAVIER HERNANDEZ
-- Create date: 08/27/2018
-- Description:	INSERT OR UPDATE ASSIGNED EQUIPMENT
-- =============================================
ALTER PROCEDURE [dbo].[UDSP_EQUIPMENT_ASSIGNED]
	-- Add the parameters for the stored procedure here
	@ASSIGNED INT,@EQUIPMENT NVARCHAR(50),@EMPLOYEE INT,@DATE DATETIME,@ISRETURNED BIT,@DATE_R DATETIME, @user as int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

	DECLARE @RESULT BIT
	IF EXISTS(SELECT * FROM EQUIPO_ASIGNADO WHERE ID_ASSIG=@ASSIGNED)
		BEGIN
			UPDATE [dbo].[Equipo_Asignado]
			SET [ID_Equipo] = @EQUIPMENT,[ID_Emp] = @EMPLOYEE,[Fecha] = @DATE,[Regreso] = @ISRETURNED,[Fecha_R] = @DATE_R,[Comentario] = '' , ID_User=@user
			WHERE ID_ASSIG=@ASSIGNED
			SET @RESULT=1
		END
	ELSE
		BEGIN
			IF NOT EXISTS(SELECT * FROM EQUIPO_ASIGNADO WHERE ID_EQUIPO=@EQUIPMENT AND FECHA_R='1900-01-01 00:00:00.000' AND ID_Emp=@EMPLOYEE)
				BEGIN
					INSERT INTO [dbo].[Equipo_Asignado]([ID_Equipo],[ID_Emp] ,[Fecha],[Regreso] ,[Fecha_R],[Comentario], ID_User )
					VALUES(@EQUIPMENT,@EMPLOYEE,@DATE ,@ISRETURNED,@DATE_R,'', @user)
					SET @RESULT=1
				END
			ELSE
				BEGIN
					SET @RESULT=0
				END
		END
		SELECT @RESULT AS  RESULT
END
GO
/****** Object:  StoredProcedure [dbo].[UDSP_EVALUATIONS]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JAVIER HERNANDEZ
-- Create date: 08/27/2018
-- Description:	INSERT OR UPDATE EVALUATIONS
-- =============================================
ALTER PROCEDURE [dbo].[UDSP_EVALUATIONS]
	-- Add the parameters for the stored procedure here
	@EVAL_ID INT,@CODE NVARCHAR(20),@DESCRIPTION NVARCHAR(50),@STATUS BIT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @RESULT BIT
    -- Insert statements for procedure here
	IF EXISTS(SELECT * FROM CAT_EVALUACION WHERE ID_EVALUA=@EVAL_ID)
		BEGIN
			UPDATE [dbo].[Cat_Evaluacion]
			SET [EV_Codigo] = @CODE,[EV_Descipcion] = @DESCRIPTION,[EV_Estatus] = @STATUS
			WHERE ID_EVALUA=@EVAL_ID
			SET @RESULT=1
		END
	ELSE
	BEGIN
		IF NOT EXISTS(SELECT * FROM CAT_EVALUACION WHERE EV_CODIGO=@CODE)
			BEGIN
				INSERT INTO [dbo].[Cat_Evaluacion]([EV_Codigo],[EV_Descipcion],[EV_Estatus])
				VALUES(@CODE,@DESCRIPTION,@STATUS)
				SET @RESULT=1
			END
		ELSE
			BEGIN
				SET @RESULT=0
			END
	END
	SELECT @RESULT AS RESULT

END

GO
/****** Object:  StoredProcedure [dbo].[UDSP_EXAMENES_MED]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JAVIER HERNANDEZ
-- Create date: 08/27/2018
-- Description:	INSERT OR UPDATE EMERGENCY CONTACTS
-- =============================================
ALTER PROCEDURE [dbo].[UDSP_EXAMENES_MED]
	-- Add the parameters for the stored procedure here
	@ID_EM INT,@EMPLOYEE INT, @EM_Estudio NVARCHAR(50), @EM_Resultado NVARCHAR(50),@EM_Fecha datetime,@EM_FechaProximo datetime
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @RESULT BIT
    -- Insert statements for procedure here
	IF EXISTS(SELECT * FROM [Examenes_Medicos] WHERE [ID_EM]=@ID_EM)
		BEGIN
			UPDATE [dbo].[Examenes_Medicos]
			SET [ID_Emp] =@EMPLOYEE,[EM_Estudio] = @EM_Estudio,[EM_Resultado]=@EM_Resultado , [EM_Fecha]=@EM_Fecha, [EM_FechaProximo]=@EM_FechaProximo 
			WHERE ID_EM=@ID_EM
			SET @RESULT=1
		END
	ELSE
		BEGIN
			IF NOT EXISTS(SELECT * FROM EXAMENES_MEDICOS WHERE EM_ESTUDIO=@EM_Estudio AND EM_FECHA=@EM_FECHA)
				BEGIN
					INSERT INTO [dbo].[Examenes_Medicos]([ID_Emp],[EM_Estudio],[EM_Resultado],[EM_Fecha],[EM_FechaProximo])
					VALUES(@EMPLOYEE, @EM_Estudio, @EM_Resultado,@EM_Fecha,@EM_FechaProximo)
					SET @RESULT=1
				END
			ELSE
				BEGIN
					SET @RESULT=0
				END

		END
	SELECT @RESULT AS RESULT
END

GO
/****** Object:  StoredProcedure [dbo].[UDSP_OBSERVACIONES]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JAVIER HERNANDEZ
-- Create date: 08/27/2018
-- Description:	INSERT OR UPDATE POSITIONS
-- =============================================
ALTER PROCEDURE [dbo].[UDSP_OBSERVACIONES]
	-- Add the parameters for the stored procedure here
	@ID_Emp int,@Observaciones nvarchar(max),@Fecha datetime
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

INSERT INTO [dbo].[Observaciones_Equipo]
           ([ID_Emp]
           ,[Observaciones]
           ,[Fecha])
     VALUES
           (@ID_Emp
           ,@Observaciones
           ,@Fecha)
END
GO
/****** Object:  StoredProcedure [dbo].[UDSP_POSITIONS]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JAVIER HERNANDEZ
-- Create date: 08/27/2018
-- Description:	INSERT OR UPDATE POSITIONS
-- =============================================
ALTER PROCEDURE [dbo].[UDSP_POSITIONS]
	-- Add the parameters for the stored procedure here
	@POSITION INT,@NAME NVARCHAR(20),@DESCRIPTION NVARCHAR(50),@RISK BIT, @STATUS INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @RESULT BIT
	IF EXISTS(SELECT * FROM CAT_PUESTO WHERE ID_PUESTO=@POSITION)
	BEGIN
		UPDATE [dbo].[Cat_Puesto]
		SET [Nombre] = @NAME,[Descripcion] = @DESCRIPTION,[Riesgo] = @RISK,[Estatus]=@STATUS
		WHERE ID_PUESTO=@POSITION
		SET @RESULT =1
	END
	ELSE
	BEGIN
		IF NOT EXISTS(SELECT * FROM  CAT_PUESTO WHERE NOMBRE=@NAME)
			BEGIN
				INSERT INTO [dbo].[Cat_Puesto]([Nombre],[Descripcion],[Riesgo],[Estatus])
				VALUES(@NAME,@DESCRIPTION,@RISK,@STATUS)
				SET @RESULT=1
			END
		ELSE
			BEGIN
				SET @RESULT=0
			END
	END
	SELECT @RESULT AS  RESULT
END

GO
/****** Object:  StoredProcedure [dbo].[UDSP_SES]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:  JAVIER HERNANDEZ
-- Create date: 08/27/2018
-- Description: INSERTS OR UPDATES A SES
-- =============================================
ALTER PROCEDURE [dbo].[UDSP_SES]
-- Add the parameters for the stored procedure here
@SES_ID INT,@EMP_ID INT,@H_TYPE NVARCHAR(20),@H_CONDITION NVARCHAR(20),@H_ELEC BIT,@H_PHONE BIT,@H_WATER BIT,@H_SEWER BIT,@H_GAS BIT,@H_TRASHREC BIT,
@H_CABLETV BIT,@H_INTERNET BIT,@H_SECURITY BIT,@T_METRO BIT,@T_PUBLIC BIT,@T_TAX BIT,@T_CAR BIT,@A_SOCIAL NVARCHAR(20),@A_COMUNITARY NVARCHAR(20),
@A_MUSEUMS NVARCHAR(20),@A_THEATERS NVARCHAR(20),@A_MOVIES NVARCHAR(20),@A_FESTIVALS NVARCHAR(20),@A_ARCHE NVARCHAR(20),@A_VACATIONS NVARCHAR(20),
@A_PLAZAS NVARCHAR(20),@A_NPARK NVARCHAR(20),@A_APARK NVARCHAR(20),@FS_RENT DECIMAL(18,2),@FS_SCHOOL DECIMAL(18,2),@FS_GROCERIES DECIMAL(18,2),
@FS_SERVICES DECIMAL(18,2),@SES_HOBBIES NVARCHAR(100),@SES_RELIGION NVARCHAR(20),@SES_VERIFIER NVARCHAR(50),@SES_OBSERVATIONS NVARCHAR(200)
AS
BEGIN
-- SET NOCOUNT ON added to prevent extra result sets from
-- interfering with SELECT statements.
SET NOCOUNT ON;

    -- Insert statements for procedure here
IF EXISTS(SELECT * FROM ES WHERE ID_ESTSOCIO=@SES_ID)
BEGIN
 UPDATE [dbo].[ES]
 SET [ID_Emp] = @EMP_ID,[Viv_Tipo] = @H_TYPE,[Viv_Condiciones] = @H_CONDITION,[Viv_Luz] = @H_ELEC,[Viv_Tel] = @H_PHONE,[Viv_Agua] = @H_WATER
  ,[Viv_Drenaje] = @H_SEWER,[Viv_TubGas] = @H_GAS,[Viv_RecBasura] = @H_TRASHREC,[Viv_TVCable] = @H_CABLETV,[Viv_Internet] = @H_INTERNET
  ,[Viv_SisSeg] = @H_SECURITY,[Trasn_Metro] = @T_METRO,[Trans_Publico] = @T_PUBLIC,[Trans_Taxi] = @T_TAX,[Trans_VehPropio] = @T_CAR,
  [Act_EvSociales] = @A_SOCIAL,[Act_EvCominitarios] = @A_COMUNITARY,[Act_Museos] = @A_MUSEUMS,[Act_Teatros] = @A_THEATERS,[Act_Cines] = @A_MOVIES,
  [Act_FesCulturaes] = @A_FESTIVALS,[Act_ZonasArq] = @A_ARCHE,[Act_Vaciones] = @A_VACATIONS,[Act_PlazasPub] = @A_PLAZAS,[Act_ParquesNat] = @A_NPARK,
  [Act_PaquesDiv] = @A_APARK,[GF_Renta] = @FS_RENT,[GF_Colegio] = @FS_SCHOOL,[GF_Despensa] = @FS_GROCERIES,[GF_Servicios] = @FS_SERVICES,
  [ES_Pasatiempos] = @SES_HOBBIES,[ES_Religion] = @SES_RELIGION,[ES_Verificador] = @SES_VERIFIER,[ES_Observaciones] = @SES_OBSERVATIONS
 WHERE ID_ESTSOCIO=@SES_ID
 SELECT @SES_ID AS ID_ESTSOCIO
END
ELSE
 BEGIN
  INSERT INTO [dbo].[ES]
      ([ID_Emp],[Viv_Tipo],[Viv_Condiciones],[Viv_Luz],[Viv_Tel],[Viv_Agua],[Viv_Drenaje],[Viv_TubGas],[Viv_RecBasura],[Viv_TVCable],[Viv_Internet]
      ,[Viv_SisSeg],[Trasn_Metro],[Trans_Publico],[Trans_Taxi],[Trans_VehPropio] ,[Act_EvSociales],[Act_EvCominitarios],[Act_Museos]
      ,[Act_Teatros],[Act_Cines],[Act_FesCulturaes],[Act_ZonasArq],[Act_Vaciones],[Act_PlazasPub],[Act_ParquesNat],[Act_PaquesDiv]
      ,[GF_Renta],[GF_Colegio],[GF_Despensa],[GF_Servicios],[ES_Pasatiempos] ,[ES_Religion],[ES_Verificador],[ES_Observaciones])
   OUTPUT INSERTED.ID_ESTSOCIO AS ID_ESTSOCIO
   VALUES (@EMP_ID,@H_TYPE,@H_CONDITION,@H_ELEC,@H_PHONE,@H_WATER,@H_SEWER,@H_GAS,@H_TRASHREC,@H_CABLETV,@H_INTERNET,@H_SECURITY,
     @T_METRO,@T_PUBLIC,@T_TAX,@T_CAR,@A_SOCIAL,@A_COMUNITARY,@A_MUSEUMS,@A_THEATERS,@A_MOVIES,@A_FESTIVALS,@A_ARCHE,@A_VACATIONS,
     @A_PLAZAS,@A_NPARK,@A_APARK,@FS_RENT,@FS_SCHOOL,@FS_GROCERIES,@FS_SERVICES,@SES_HOBBIES,@SES_RELIGION,@SES_VERIFIER,@SES_OBSERVATIONS)
 END
END

GO
/****** Object:  StoredProcedure [dbo].[UDSP_SES_OTHER_INCOMES]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JAVIER HERNANDEZ
-- Create date: 08/27/2018
-- Description:	INSERT OR UPDATE OTHER INCOMES FROM THE SES
-- =============================================
ALTER PROCEDURE [dbo].[UDSP_SES_OTHER_INCOMES]
	-- Add the parameters for the stored procedure here
	@INCOME_ID INT,@SES_ID INT,@DESC NVARCHAR(50),@AMOUNT DECIMAL(18,2)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @RESULT BIT
    -- Insert statements for procedure here
	IF EXISTS(SELECT * FROM ES_OTROSINGRESOS WHERE ID_OING=@INCOME_ID)
		BEGIN
			UPDATE [dbo].[ES_OtrosIngresos]
			SET [ID_EstSocio] = @SES_ID,[OIng_Desc]=@DESC,[OIng_Cantidad] = @AMOUNT
			WHERE ID_OING=@INCOME_ID
			SET @RESULT=1
		END
	ELSE
		BEGIN
			IF NOT EXISTS(SELECT * FROM ES_OTROSINGRESOS WHERE ID_EstSocio=@SES_ID AND OING_DESC=@DESC)
				BEGIN
					INSERT INTO [dbo].[ES_OtrosIngresos]([ID_EstSocio],[OIng_Desc],[OIng_Cantidad])
					VALUES(@SES_ID,@DESC,@AMOUNT)
					SET @RESULT=1
				END
			ELSE
				BEGIN
					SET @RESULT=0
				END
		END
		SELECT @RESULT AS RESULT
END

GO
/****** Object:  StoredProcedure [dbo].[UDSP_SES_REFERENCES]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JAVIER HERNANDEZ
-- Create date: 08/27/2018
-- Description:	INSERT OR UPDATA REFERENCES
-- =============================================
ALTER PROCEDURE [dbo].[UDSP_SES_REFERENCES]
	-- Add the parameters for the stored procedure here
	@REF INT,@SES_ID INT,@NAME NVARCHAR(50),@OCUPATION NVARCHAR(20),@RELATIONSHIP NVARCHAR(20),@TIME NVARCHAR(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @RESULT BIT
    -- Insert statements for procedure here
	IF EXISTS(SELECT * FROM ES_REFERENCIAS WHERE ID_REF=@REF)
		BEGIN
			UPDATE [dbo].[ES_Referencias]
			SET [ID_EstSocio] = @SES_ID,[Ref_Nombre] = @NAME,[Ref_Ocupacion] = @OCUPATION,[Ref_TRelacion] = @RELATIONSHIP,[Ref_TiempoC] = @TIME
			WHERE  ID_REF=@REF
			SET @RESULT=1
		END
	ELSE
		BEGIN
			IF NOT EXISTS(SELECT * FROM ES_REFERENCIAS WHERE ID_ESTSOCIO=@SES_ID AND REF_NOMBRE=@NAME)
				BEGIN
					INSERT INTO [dbo].[ES_Referencias]([ID_EstSocio],[Ref_Nombre],[Ref_Ocupacion],[Ref_TRelacion],[Ref_TiempoC])
					VALUES(@SES_ID,@NAME,@OCUPATION,@RELATIONSHIP,@TIME)
					SET @RESULT=1
				END
			ELSE
				BEGIN
					SET @RESULT=0
				END
		END
	SELECT @RESULT AS RESULT
END

GO
/****** Object:  StoredProcedure [dbo].[UDSP_SES_RPT_1OF4]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[UDSP_SES_RPT_1OF4]
	-- Add the parameters for the stored procedure here
	@EMPLOYEE AS INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM SES_INFO WHERE ID_EMP=@EMPLOYEE
END
GO
/****** Object:  StoredProcedure [dbo].[UDSP_SES_RPT_2OF4]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[UDSP_SES_RPT_2OF4]
	-- Add the parameters for the stored procedure here
	@ID_SES AS INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM ES_REFERENCIAS WHERE ID_ESTSOCIO=@ID_SES
END
GO
/****** Object:  StoredProcedure [dbo].[UDSP_SES_RPT_3OF4]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[UDSP_SES_RPT_3OF4]
	-- Add the parameters for the stored procedure here
	@EMPLOYEE AS INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT     [ID_Persona]  ,[ID_Emp]
      ,[Fam_Tipo]
      ,UPPER([Fam_Nombre] +' '+[Fam_APat]+' '+[Fam_AMat])[NOMBRE]
      ,[Fam_Nacion]
      ,[Fam_FNac]
      ,[Fam_Genero]
  FROM [EmpleadosDB].[dbo].[Emp_DatosFamilia] WHERE ID_EMP=@EMPLOYEE
END
GO
/****** Object:  StoredProcedure [dbo].[UDSP_SES_RPT_4OF4]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[UDSP_SES_RPT_4OF4]
	-- Add the parameters for the stored procedure here
	@ID_SES AS INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM ES_OTROSINGRESOS WHERE ID_ESTSOCIO=@ID_SES
END
GO
/****** Object:  StoredProcedure [dbo].[UDSP_TRANINGS]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JAVIER HERNANDEZ
-- Create date: 08/27/2018
-- Description:	INSERT OR UPDATE TRANINGS
-- =============================================
ALTER PROCEDURE [dbo].[UDSP_TRANINGS]
	-- Add the parameters for the stored procedure here
	@ID INT, @CODE NVARCHAR(20),@DESCRIPTION NVARCHAR(50),@STATUS BIT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @RESULT BIT
    -- Insert statements for procedure here
	IF EXISTS(SELECT * FROM CAT_CAPACITACION WHERE ID_CAP=@ID)
	BEGIN
		UPDATE [dbo].[Cat_Capacitacion]
		   SET [CA_Codigo] = @CODE ,[CA_Desc] = @DESCRIPTION ,[CA_Status] = @STATUS
		 WHERE ID_CAP=@ID
		 SET @RESULT=1
	END
	ELSE
	BEGIN
		IF NOT EXISTS(SELECT * FROM CAT_CAPACITACION WHERE CA_CODIGO=@CODE)
			BEGIN
				INSERT INTO [dbo].[Cat_Capacitacion]   ([CA_Codigo]  ,[CA_Desc],[CA_Status])
				VALUES (@CODE ,@DESCRIPTION,@STATUS)
				SET @RESULT=1
			END
		ELSE
			BEGIN
				SET @RESULT=0
			END
	END
	SELECT @RESULT AS RESULT
END

GO
/****** Object:  StoredProcedure [dbo].[UDSP_USERS]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JAVIER HERNANDEZ
-- Create date: 08/27/2018
-- Description:	UPDATE OR INSERT USERS
-- =============================================
ALTER PROCEDURE [dbo].[UDSP_USERS]
	-- Add the parameters for the stored procedure here
	@ID INT,@USERNAME NCHAR(20),@PASSWORD NVARCHAR(50),@ACTIVE BIT,@ACCESS INT, @ID_EMP INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @RESULT BIT
    -- Insert statements for procedure here
	IF EXISTS(SELECT * FROM USERS WHERE ID_USER=@ID)
		BEGIN
			UPDATE USERS SET USERNAME=@USERNAME,PASSWORD=@PASSWORD,ACCESO=@ACCESS,ACTIVO=@ACTIVE,@ID_EMP =ID_EMP
			WHERE ID_USER=@ID
			SET @RESULT=1
		END
	ELSE
		BEGIN		 
			IF NOT EXISTS(SELECT * FROM USERS WHERE USERNAME=@USERNAME OR ID_EMP=@ID_EMP)
				BEGIN
					INSERT INTO [dbo].[Users]([UserName],[Password],[Acceso],[Activo], ID_EMP)
					VALUES (@USERNAME,@PASSWORD,@ACCESS,@ACTIVE, @ID_EMP)
					SET @RESULT=1
				END
			ELSE
				BEGIN
					SET @RESULT=0
				END
		END

		SELECT @RESULT AS RESULT
END

GO
/****** Object:  StoredProcedure [dbo].[Ultimo_Emp]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Ultimo_Emp]

AS
BEGIN
	DECLARE @NUMBER INT=(SELECT MAX(ID_EMP) FROM [dbo].[Emp_Datos])
	IF	@NUMBER IS NULL
	BEGIN
		SELECT IDENT_CURRENT('EMP_DATOS')
	END
	ELSE
	BEGIN
		SELECT IDENT_CURRENT('EMP_DATOS')+1
	END
END
GO
/****** Object:  StoredProcedure [dbo].[USUARIO_EXIST_NSS]    Script Date: 4/2/2019 9:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[USUARIO_EXIST_NSS]
@ID as nvarchar(50)
AS
BEGIN
	if exists(select * from [dbo].[Emp_Datos] where (convert(nvarchar(50),[Emp_NSS])=@ID) or ([Emp_Curp]=@ID)) 
	begin
	select [ID_Emp] from [dbo].[Emp_Datos] where (convert(nvarchar(50),[Emp_NSS])=@ID) or ([Emp_Curp]=@ID)
	end
	else
	begin
	select 0 as ID_Emp
	end 
END
GO
