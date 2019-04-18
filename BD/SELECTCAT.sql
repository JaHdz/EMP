USE [EmpleadosDB]
GO

/****** Object:  StoredProcedure [dbo].[SELECT_CATALOGOS]    Script Date: 4/17/2019 9:20:38 PM ******/
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
			SELECT [Descripcion] FROM [dbo].[Cat_TE] where  ( ID_TE = @CONDICION)
	END
END
GO


