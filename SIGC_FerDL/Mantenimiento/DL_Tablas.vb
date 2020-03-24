Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports SIGC_DataAccess

Namespace Mantenimiento
    Public Class DL_Tablas
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
        Public Function fListarTablaEmpr(Optional ByVal psOpc As String = "L") As DataTable
            Try
                conectado()
                cmd = New SqlCommand("SIGC_SP_FER_ListarEmpresas")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = cnn
                cmd.Parameters.AddWithValue("@psOpc", psOpc)

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

        Public Function fListarTablasTabla(ByVal psProc As String, Optional ByVal psTab As String = "") As DataTable
            Try
                conectado()
                cmd = New SqlCommand(psProc)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = cnn
                cmd.Parameters.AddWithValue("@psTab", psTab)

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

        Public Function fManTab(ByVal psOpc As String, ByVal psTab As String, ByVal psCod As String, ByVal psDes As String, ByVal psEst As String, ByVal psIde As String) As Boolean
            Try
                conectado()
                cmd = New SqlCommand("SIGC_SP_rManTab")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = cnn
                cmd.Parameters.AddWithValue("@psOpc", psOpc)
                cmd.Parameters.AddWithValue("@psTab", psTab)
                cmd.Parameters.AddWithValue("@psCod", psCod)
                cmd.Parameters.AddWithValue("@psDes", psDes)
                cmd.Parameters.AddWithValue("@psEst", psEst)
                cmd.Parameters.AddWithValue("@psIde", psIde)

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

        ' Listar Categorías
        Public Function fListarTablaCateg(ByVal piEmpr As Integer, Optional ByVal psOpc As String = "L") As DataTable
            Try
                conectado()
                cmd = New SqlCommand("SIGC_SP_FER_ListarCateg")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = cnn
                cmd.Parameters.AddWithValue("@piEmpr", piEmpr)
                cmd.Parameters.AddWithValue("@psOpc", psOpc)

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

        ' Listar Unidades de Medida
        Public Function fListarTablaUniMed(ByVal piEmpr As Integer, Optional ByVal psOpc As String = "L") As DataTable
            Try
                conectado()
                cmd = New SqlCommand("SIGC_SP_FER_ListarUniMed")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = cnn
                cmd.Parameters.AddWithValue("@piEmpr", piEmpr)
                cmd.Parameters.AddWithValue("@psOpc", psOpc)

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

        ' Mantenimiento de Categorías
        Public Function fManTabCateg(ByVal psOpc As String, ByVal piCat As Integer, ByVal piEmp As Integer, ByVal psDes As String, ByVal psEst As String) As Boolean
            Try
                conectado()
                cmd = New SqlCommand("SIGC_FER_SP_rManTabCateg")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = cnn
                cmd.Parameters.AddWithValue("@psOpc", psOpc)
                cmd.Parameters.AddWithValue("@piCat", piCat)
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

        ' Mantenimiento de Unidades de Medida
        Public Function fManTabUniMed(ByVal psOpc As String, ByVal piUni As Integer, ByVal piEmp As Integer, ByVal psDes As String, ByVal psEst As String) As Boolean
            Try
                conectado()
                cmd = New SqlCommand("SIGC_FER_SP_rManTabUniMed")
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
