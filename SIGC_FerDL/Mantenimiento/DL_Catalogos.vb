Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports SIGC_DataAccess

Namespace Mantenimiento
    Public Class DL_Catalogos
        Inherits Conexion
        Dim cmd As New SqlCommand
#Region "   Variables"
        Private mdsDataSet As System.Data.DataSet = Nothing
#End Region

#Region "   Constructors"
        Public Sub New()
            MyBase.New()
        End Sub
#End Region
        ' Listar Clientes
        Public Function fListarClientes(ByVal piEmpr As Integer) As DataTable
            Try
                conectado()
                cmd = New SqlCommand("SIGC_SP_FER_ListarClientes")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = cnn
                cmd.Parameters.AddWithValue("@piEmpr", piEmpr)

                If cmd.ExecuteNonQuery Then
                    Dim dt As New DataTable
                    Dim da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                    Return dt
                Else
                    Return Nothing
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            Finally
                desconectado()
            End Try
        End Function

        ' Mantenimiento de Clientes
        Public Function fManTabCli(ByVal psOpc As String, ByVal piEmp As Integer, ByVal piCli As Integer, ByVal psTip As String, ByVal psDoc As String,
                                   ByVal psNom As String, ByVal psDir As String, ByVal psTel As String, ByVal psEma As String, ByVal psEst As String) As Boolean
            Try
                conectado()
                cmd = New SqlCommand("SIGC_FER_SP_rManTabCli")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = cnn
                cmd.Parameters.AddWithValue("@psOpc", psOpc)
                cmd.Parameters.AddWithValue("@piEmp", piEmp)
                cmd.Parameters.AddWithValue("@piCli", piCli)
                cmd.Parameters.AddWithValue("@psTip", psTip)
                cmd.Parameters.AddWithValue("@psDoc", psDoc)
                cmd.Parameters.AddWithValue("@psNom", psNom)
                cmd.Parameters.AddWithValue("@psDir", psDir)
                cmd.Parameters.AddWithValue("@psTel", psTel)
                cmd.Parameters.AddWithValue("@psEma", psEma)
                cmd.Parameters.AddWithValue("@psEst", psEst)
                If cmd.ExecuteNonQuery Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            Finally
                desconectado()
            End Try
        End Function

        ' Listar Proveedores
        Public Function fListarProveedores(ByVal piEmpr As Integer) As DataTable
            Try
                conectado()
                cmd = New SqlCommand("SIGC_SP_FER_ListarProveedores")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = cnn
                cmd.Parameters.AddWithValue("@piEmpr", piEmpr)

                If cmd.ExecuteNonQuery Then
                    Dim dt As New DataTable
                    Dim da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                    Return dt
                Else
                    Return Nothing
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            Finally
                desconectado()
            End Try
        End Function

        ' Mantenimiento de Proveedores
        Public Function fManTabProv(ByVal psOpc As String, ByVal piPro As Integer, ByVal piEmp As Integer, ByVal psDoc As String,
                                   ByVal psNom As String, ByVal psDir As String, ByVal psTel As String, ByVal psEma As String, ByVal psEst As String) As Boolean
            Try
                conectado()
                cmd = New SqlCommand("SIGC_FER_SP_rManTabPROV")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = cnn
                cmd.Parameters.AddWithValue("@psOpc", psOpc)
                cmd.Parameters.AddWithValue("@piPro", piPro)
                cmd.Parameters.AddWithValue("@piEmp", piEmp)
                cmd.Parameters.AddWithValue("@psDoc", psDoc)
                cmd.Parameters.AddWithValue("@psNom", psNom)
                cmd.Parameters.AddWithValue("@psDir", psDir)
                cmd.Parameters.AddWithValue("@psTel", psTel)
                cmd.Parameters.AddWithValue("@psEma", psEma)
                cmd.Parameters.AddWithValue("@psEst", psEst)
                If cmd.ExecuteNonQuery Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            Finally
                desconectado()
            End Try
        End Function

        ' Listar Productos
        Public Function fListarProductos(ByVal piEmpr As Integer) As DataTable
            Try
                conectado()
                cmd = New SqlCommand("SIGC_SP_FER_ListarProductos")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = cnn
                cmd.Parameters.AddWithValue("@piEmpr", piEmpr)

                If cmd.ExecuteNonQuery Then
                    Dim dt As New DataTable
                    Dim da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                    Return dt
                Else
                    Return Nothing
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            Finally
                desconectado()
            End Try
        End Function

        ' Mantenimiento de Productos
        Public Function fManTabProd(ByVal psOpc As String, ByVal piPro As Integer, ByVal piEmp As Integer, ByVal piCat As Integer, ByVal piUni As Integer,
                                    ByVal psDes As String, ByVal pnPre As Double, ByVal pnStk As Double, ByVal pnMin As Double, ByVal psEst As String) As Boolean
            Try
                conectado()
                cmd = New SqlCommand("SIGC_FER_SP_rManTabProd")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = cnn
                cmd.Parameters.AddWithValue("@psOpc", psOpc)
                cmd.Parameters.AddWithValue("@piPro", piPro)
                cmd.Parameters.AddWithValue("@piEmp", piEmp)
                cmd.Parameters.AddWithValue("@piCat", piCat)
                cmd.Parameters.AddWithValue("@piUni", piUni)
                cmd.Parameters.AddWithValue("@psDes", psDes)
                cmd.Parameters.AddWithValue("@pnPre", pnPre)
                cmd.Parameters.AddWithValue("@pnStk", pnStk)
                cmd.Parameters.AddWithValue("@pnMin", pnMin)
                cmd.Parameters.AddWithValue("@psEst", psEst)
                If cmd.ExecuteNonQuery Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            Finally
                desconectado()
            End Try
        End Function

    End Class

End Namespace