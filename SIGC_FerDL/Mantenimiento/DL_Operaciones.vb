Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports SIGC_DataAccess
Namespace Mantenimiento
    Public Class DL_Operaciones
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
        ' Listar Ventas Cabecera
        Public Function fListarVtasCab(ByVal piEmpr As Integer) As DataTable
            Try
                conectado()
                cmd = New SqlCommand("SIGC_SP_FER_ListarVtasCab")
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
        ' Listar Ventas Detalle
        Public Function fListarVtasDet(ByVal piEmpr As Integer, ByVal piCab As Integer) As DataTable
            Try
                conectado()
                cmd = New SqlCommand("SIGC_SP_FER_ListarVtasdet")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = cnn
                cmd.Parameters.AddWithValue("@piEmpr", piEmpr)
                cmd.Parameters.AddWithValue("@piCab", piCab)

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

        Public Function fConsDatClte(ByVal piEmpr As Integer, Optional ByVal psOpc As String = "L", Optional ByVal psDoc As String = "") As DataTable
            Try
                conectado()
                cmd = New SqlCommand("SIGC_SP_FER_ListarClientes")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = cnn
                cmd.Parameters.AddWithValue("@piEmpr", piEmpr)
                cmd.Parameters.AddWithValue("@psOpc", psOpc)
                cmd.Parameters.AddWithValue("@psDoc", psDoc)

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
        Public Function fConsDatProd(ByVal piEmpr As Integer, Optional ByVal psOpc As String = "L", Optional ByVal piPrd As Integer = 0) As DataTable
            Try
                conectado()
                cmd = New SqlCommand("SIGC_SP_FER_ListarProductos")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = cnn
                cmd.Parameters.AddWithValue("@piEmpr", piEmpr)
                cmd.Parameters.AddWithValue("@psOpc", psOpc)
                cmd.Parameters.AddWithValue("@piProd", piPrd)

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

        ' Mantenimiento de Ventas Cabecera
        Public Function fManVtasCab(ByVal psOpc As String, ByVal piUni As Integer, ByVal piEmp As Integer, ByVal psDes As String, ByVal psEst As String) As Boolean
            Try
                conectado()
                cmd = New SqlCommand("SIGC_FER_SP_rManVtasCab")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = cnn
                cmd.Parameters.AddWithValue("@psOpc", psOpc)
                cmd.Parameters.AddWithValue("@piUni", piUni)
                cmd.Parameters.AddWithValue("@piEmp", piEmp)
                cmd.Parameters.AddWithValue("@psDes", psDes)
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
