Imports SIGC_FerDL
Imports SIGC_DataAccess

Namespace Mantenimiento
    Public Class BL_Catalogos
        ' Listar Clientes
        Public Function fListarClientes(ByVal piEmpr As Integer)
            Dim DL As New SIGC_FerDL.Mantenimiento.DL_Catalogos
            Return DL.fListarClientes(piEmpr)
        End Function

        ' Mantenimiento de Clientes
        Public Function fManTabCli(ByVal psOpc As String, ByVal piEmp As Integer, ByVal piCli As Integer, ByVal psTip As String, ByVal psDoc As String,
                                   ByVal psNom As String, ByVal psDir As String, ByVal psTel As String, ByVal psEma As String, ByVal psEst As String) As Boolean
            Dim DL As New SIGC_FerDL.Mantenimiento.DL_Catalogos
            fManTabCli = DL.fManTabCli(psOpc, piEmp, piCli, psTip, psDoc, psNom, psDir, psTel, psEma, psEst)
        End Function

        ' Listar Proveedores
        Public Function fListarProveedores(ByVal piEmpr As Integer)
            Dim DL As New SIGC_FerDL.Mantenimiento.DL_Catalogos
            Return DL.fListarProveedores(piEmpr)
        End Function

        ' Mantenimiento de Proveedores
        Public Function fManTabProv(ByVal psOpc As String, ByVal piPro As Integer, ByVal piEmp As Integer, ByVal psDoc As String,
                                   ByVal psNom As String, ByVal psDir As String, ByVal psTel As String, ByVal psEma As String, ByVal psEst As String) As Boolean
            Dim DL As New SIGC_FerDL.Mantenimiento.DL_Catalogos
            fManTabProv = DL.fManTabProv(psOpc, piPro, piEmp, psDoc, psNom, psDir, psTel, psEma, psEst)
        End Function

        ' Listar Productos
        Public Function fListarProductos(ByVal piEmpr As Integer)
            Dim DL As New SIGC_FerDL.Mantenimiento.DL_Catalogos
            Return DL.fListarProductos(piEmpr)
        End Function

        ' Mantenimiento de Productos
        Public Function fManTabProd(ByVal psOpc As String, ByVal piPro As Integer, ByVal piEmp As Integer, ByVal piCat As Integer, ByVal piUni As Integer,
                                    ByVal psDes As String, ByVal pnPre As Double, ByVal pnStk As Double, ByVal pnMin As Double, ByVal psEst As String) As Boolean
            Dim DL As New SIGC_FerDL.Mantenimiento.DL_Catalogos
            fManTabProd = DL.fManTabProd(psOpc, piPro, piEmp, piCat, piUni, psDes, pnPre, pnStk, pnMin, psEst)
        End Function
    End Class

End Namespace

