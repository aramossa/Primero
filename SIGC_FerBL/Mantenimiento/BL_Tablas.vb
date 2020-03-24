Imports SIGC_FerDL
Imports SIGC_DataAccess

Namespace Mantenimiento

    Public Class BL_Tablas
#Region "   Public Functions"

        ' Listasr tabla
        Public Function fListarTablasTabla(ByVal psProc As String, Optional ByVal psTab As String = "")
            Dim DL As New SIGC_FerDL.Mantenimiento.DL_Tablas
            Return DL.fListarTablasTabla(psProc, psTab)
        End Function

        ' Listar Categrías
        Public Function fListarTablaCateg(ByVal piEmpr As Integer, Optional ByVal psOpc As String = "L")
            Dim DL As New SIGC_FerDL.Mantenimiento.DL_Tablas
            Return DL.fListarTablaCateg(piEmpr, psOpc)
        End Function

        ' Listar Unidades de Medida
        Public Function fListarTablaUniMed(ByVal piEmpr As Integer, Optional ByVal psOpc As String = "L")
            Dim DL As New SIGC_FerDL.Mantenimiento.DL_Tablas
            Return DL.fListarTablaUniMed(piEmpr, psOpc)
        End Function

        ' Listar Unidades de Empresa
        Public Function fListarTablaEmpr(Optional ByVal psOpc As String = "L")
            Dim DL As New SIGC_FerDL.Mantenimiento.DL_Tablas
            Return DL.fListarTablaEmpr(psOpc)
        End Function

#End Region

#Region "   Public Procedures"
        Public Function fManTab(ByVal psOpc As String, ByVal psTab As String, ByVal psCod As String, ByVal psDes As String, ByVal psEst As String, ByVal psIde As String) As Boolean
            Dim DL As New SIGC_FerDL.Mantenimiento.DL_Tablas
            fManTab = DL.fManTab(psOpc, psTab, psCod, psDes, psEst, psIde)
        End Function

        Public Function fManTabCateg(ByVal psOpc As String, ByVal piCat As Integer, ByVal piEmp As Integer, ByVal psDes As String, ByVal psEst As String) As Boolean
            Dim DL As New SIGC_FerDL.Mantenimiento.DL_Tablas
            fManTabCateg = DL.fManTabCateg(psOpc, piCat, piEmp, psDes, psEst)
        End Function

        Public Function fManTabUniMed(ByVal psOpc As String, ByVal piUni As Integer, ByVal piEmp As Integer, ByVal psDes As String, ByVal psEst As String) As Boolean
            Dim DL As New SIGC_FerDL.Mantenimiento.DL_Tablas
            fManTabUniMed = DL.fManTabUniMed(psOpc, piUni, piEmp, psDes, psEst)
        End Function

#End Region

    End Class

End Namespace