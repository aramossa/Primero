Imports System.Data.OleDb
Public Class CargaExcel
   Public Function CargarArchivoExcel(ByVal ruta As String) As DataSet
      Try
         Dim ds As New DataSet
         Dim strconn As String
         strconn = "Provider=Microsoft.Jet.Oledb.4.0; data source= " & ruta & ";Extended properties=""Excel 8.0;hdr=yes;imex=1"""
         Dim mconn As New OleDbConnection(strconn)
         Dim ad As New OleDbDataAdapter("Select * from [Hoja1$]", mconn)

         mconn.Open()
         ad.Fill(ds)
         mconn.Close()
         Return ds
      Catch ex As Exception
         Throw ex
      End Try
   End Function

   Public Function CargarArchivoExcel(ByVal ruta As String, ByVal nombreHoja As String) As DataSet
      Try
         Dim ds As New DataSet
         Dim strconn As String
         strconn = "Provider=Microsoft.Jet.Oledb.4.0; data source= " & ruta & ";Extended properties=""Excel 8.0;hdr=yes;imex=1"""
         Dim mconn As New OleDbConnection(strconn)
         Dim ad As New OleDbDataAdapter("Select * from [" + nombreHoja + "$]", mconn)

         mconn.Open()
         ad.Fill(ds)
         mconn.Close()
         Return ds
      Catch ex As Exception
         Throw ex
      End Try
   End Function

End Class
