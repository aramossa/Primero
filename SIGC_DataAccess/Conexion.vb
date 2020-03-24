Imports System.Data.SqlClient

Public Class Conexion

    Protected cnn As New SqlConnection

    Public idusuario As Integer
    Protected Function conectado()
        Try
            'cnn = New SqlConnection("data source=DESKTOP-3I9FE0P;initial catalog=SIGC_Negocio;integrated security=true")
            'cnn = New SqlConnection("data source=DESKTOP-3I9FE0P;initial catalog=SIGC_Ferreteria;integrated security=true")
            cnn = New SqlConnection("data source=ANTONIO;initial catalog=SIGC_Ferreteria;integrated security=true")
            cnn.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Protected Function desconectado()
        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
