USE [EmpleadosDB]
GO

/****** Object:  StoredProcedure [dbo].[CATALOGOS]    Script Date: 4/17/2019 9:19:13 PM ******/
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
			SELECT ID_TE AS Codigo, Descripcion FROM [dbo].[Cat_TE] WHERE ESTATUS=1
		END 
		ELSE
		BEGIN
			SELECT ID_TE AS Codigo, Descripcion FROM [dbo].[Cat_TE] where ESTATUS=1 AND ( ID_TE like '%' + @CONDICION +'%' OR Descripcion like '%'+@CONDICION+'%')
		END
	END
END
GO


