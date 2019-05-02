Public Class EstudioSocioeconomico
#Region "Propiedades"
		Public Property ID_EstSocio As integer 
		Public Property ID_Emp As integer 
		Public Property Viv_Tipo As string 
		Public Property Viv_Condiciones As string 
		Public Property Viv_Luz As boolean 
		Public Property Viv_Tel As boolean 
		Public Property Viv_Agua As boolean 
		Public Property Viv_Drenaje As boolean 
		Public Property Viv_TubGas As boolean 
		Public Property Viv_RecBasura As boolean 
		Public Property Viv_TVCable As boolean 
		Public Property Viv_Internet As boolean 
		Public Property Viv_SisSeg As boolean 
		Public Property Trasn_Metro As boolean 
		Public Property Trans_Publico As boolean 
		Public Property Trans_Taxi As boolean 
		Public Property Trans_VehPropio As boolean 
		Public Property Act_EvSociales As string 
		Public Property Act_EvCominitarios As string 
		Public Property Act_Museos As string 
		Public Property Act_Teatros As string 
		Public Property Act_Cines As string 
		Public Property Act_FesCulturaes As string 
		Public Property Act_ZonasArq As string 
		Public Property Act_Vaciones As string 
		Public Property Act_PlazasPub As string 
		Public Property Act_ParquesNat As string 
		Public Property Act_PaquesDiv As string 
		Public Property GF_Renta As decimal 
		Public Property GF_Colegio As decimal 
		Public Property GF_Despensa As decimal 
		Public Property GF_Servicios As decimal 
		Public Property ES_Pasatiempos As string 
		Public Property ES_Religion As string 
		Public Property ES_Verificador As string 
		Public Property ES_Observaciones As string 
	#End Region

	#Region "Funciones y Metodos"
	Public Sub New(ByVal liID_EstSocio As integer, ByVal liID_Emp As integer, ByVal lsViv_Tipo As string, ByVal lsViv_Condiciones As string, ByVal lbViv_Luz As boolean, ByVal lbViv_Tel As boolean, ByVal lbViv_Agua As boolean, ByVal lbViv_Drenaje As boolean, ByVal lbViv_TubGas As boolean, ByVal lbViv_RecBasura As boolean, ByVal lbViv_TVCable As boolean, ByVal lbViv_Internet As boolean, ByVal lbViv_SisSeg As boolean, ByVal lbTrasn_Metro As boolean, ByVal lbTrans_Publico As boolean, ByVal lbTrans_Taxi As boolean, ByVal lbTrans_VehPropio As boolean, ByVal lsAct_EvSociales As string, ByVal lsAct_EvCominitarios As string, ByVal lsAct_Museos As string, ByVal lsAct_Teatros As string, ByVal lsAct_Cines As string, ByVal lsAct_FesCulturaes As string, ByVal lsAct_ZonasArq As string, ByVal lsAct_Vaciones As string, ByVal lsAct_PlazasPub As string, ByVal lsAct_ParquesNat As string, ByVal lsAct_PaquesDiv As string, ByVal ldGF_Renta As decimal, ByVal ldGF_Colegio As decimal, ByVal ldGF_Despensa As decimal, ByVal ldGF_Servicios As decimal, ByVal lsES_Pasatiempos As string, ByVal lsES_Religion As string, ByVal lsES_Verificador As string, ByVal lsES_Observaciones As string)
    ID_EstSocio = liID_EstSocio 
    ID_Emp = liID_Emp 
    Viv_Tipo = lsViv_Tipo 
    Viv_Condiciones = lsViv_Condiciones 
    Viv_Luz = lbViv_Luz 
    Viv_Tel = lbViv_Tel 
    Viv_Agua = lbViv_Agua 
    Viv_Drenaje = lbViv_Drenaje 
    Viv_TubGas = lbViv_TubGas 
    Viv_RecBasura = lbViv_RecBasura 
    Viv_TVCable = lbViv_TVCable 
    Viv_Internet = lbViv_Internet 
    Viv_SisSeg = lbViv_SisSeg 
    Trasn_Metro = lbTrasn_Metro 
    Trans_Publico = lbTrans_Publico 
    Trans_Taxi = lbTrans_Taxi 
    Trans_VehPropio = lbTrans_VehPropio 
    Act_EvSociales = lsAct_EvSociales 
    Act_EvCominitarios = lsAct_EvCominitarios 
    Act_Museos = lsAct_Museos 
    Act_Teatros = lsAct_Teatros 
    Act_Cines = lsAct_Cines 
    Act_FesCulturaes = lsAct_FesCulturaes 
    Act_ZonasArq = lsAct_ZonasArq 
    Act_Vaciones = lsAct_Vaciones 
    Act_PlazasPub = lsAct_PlazasPub 
    Act_ParquesNat = lsAct_ParquesNat 
    Act_PaquesDiv = lsAct_PaquesDiv 
    GF_Renta = ldGF_Renta 
    GF_Colegio = ldGF_Colegio 
    GF_Despensa = ldGF_Despensa 
    GF_Servicios = ldGF_Servicios 
    ES_Pasatiempos = lsES_Pasatiempos 
    ES_Religion = lsES_Religion 
    ES_Verificador = lsES_Verificador 
    ES_Observaciones = lsES_Observaciones 
End Sub
#End Region
End Class

