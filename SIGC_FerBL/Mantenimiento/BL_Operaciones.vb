Imports SIGC_FerDL
Imports SIGC_DataAccess
Namespace Mantenimiento
    Public Class BL_Operaciones
#Region "   Public Functions"
        ' Listar Ventas Cabecera
        Public Function fListarVtasCab(ByVal piEmpr As Integer)
            Dim DL As New SIGC_FerDL.Mantenimiento.DL_Operaciones
            Return DL.fListarVtasCab(piEmpr)
        End Function
        ' Listar Ventas Detalle
        Public Function fListarVtasDet(ByVal piEmpr As Integer, ByVal piCab As Integer)
            Dim DL As New SIGC_FerDL.Mantenimiento.DL_Operaciones
            Return DL.fListarVtasDet(piEmpr, piCab)
        End Function

        ' Consulta datos del cliente
        Public Function fConsDatClte(ByVal piEmpr As Integer, Optional ByVal psOpc As String = "L", Optional ByVal psDoc As String = "")
            Dim DL As New SIGC_FerDL.Mantenimiento.DL_Operaciones
            Return DL.fConsDatClte(piEmpr, psOpc, psDoc)
        End Function
        ' Consulta datos del producto
        Public Function fConsDatProd(ByVal piEmpr As Integer, Optional ByVal psOpc As String = "L", Optional ByVal piPrd As Integer = 0)
            Dim DL As New SIGC_FerDL.Mantenimiento.DL_Operaciones
            Return DL.fConsDatProd(piEmpr, psOpc, piPrd)
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
        Public Function fManVtasCab(ByVal psOpc As String, ByVal piUni As Integer, ByVal piEmp As Integer, ByVal psDes As String, ByVal psEst As String) As Boolean
            Dim DL As New SIGC_FerDL.Mantenimiento.DL_Operaciones
            fManVtasCab = DL.fManVtasCab(psOpc, piUni, piEmp, psDes, psEst)
        End Function
#End Region
    End Class
End Namespace
