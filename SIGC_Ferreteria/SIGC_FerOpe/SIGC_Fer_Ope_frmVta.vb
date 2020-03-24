Public Class SIGC_Fer_Ope_frmVta
    Private Sub cmdClte_Click(sender As Object, e As EventArgs) Handles cmdClte.Click
        Dim f As New SIGC_FerTab_frmAyu
        f.msOpc = "C"
        f.msCod = txtCodClte.Text.ToString
        f.msDes = txtDesClte.Text.ToString
        f.ShowDialog()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As New SIGC_FerTab_frmAyu
        f.msOpc = "P"
        f.msCod = txtCodProd.Text.ToString
        f.msDes = txtDesProd.Text.ToString
        f.ShowDialog()
        'txtMargProv.Focus()
    End Sub
End Class