USE [EmpleadosDB]
GO
/****** Object:  StoredProcedure [dbo].[Consulta_Emp]    Script Date: 18/04/2019 01:02:21 a. m. ******/
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
      ,C.ID_TE as Emp_Tipo
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
  INNER JOIN CAT_TE AS C ON A.EMP_TIPO=C.CODIGO
  where A.ID_Emp=@ID
END
