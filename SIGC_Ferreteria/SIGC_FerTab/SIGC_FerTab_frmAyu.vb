Imports Infragistics.Win.UltraWinGrid
Imports SIGC_FerBL
Public Class SIGC_FerTab_frmAyu
    Public msOpc As String, msCod As String, msDes As String, msEst As String
    Private Sub SIGC_FerTab_frmAyu_Load(sender As Object, e As EventArgs) Handles Me.Load
        If msOpc = "C" Then
            Me.Text = "Consulta de Clientes"
        ElseIf msOpc = "P" Then
            Me.Text = "Consulta de Productos"
        End If
        LlenarGrilla()
    End Sub
    Private Sub LlenarGrilla()
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim ds As DataSet = New DataSet
            Dim BL As New SIGC_FerBL.Mantenimiento.BL_Catalogos
            Dim dt As New DataTable
            If msOpc = "C" Then
                dt = BL.fListarClientes(GS_EMP_ID)
            ElseIf msOpc = "P" Then
                dt = BL.fListarProductos(GS_EMP_ID)
            End If
            BL = Nothing
            Me.grdDat.DataSource = dt
            Pinta_InfraGrilla()
            EstiloGrillaInfrag(Me.grdDat)
            grdDat.Refresh()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Pinta_InfraGrilla()
        With Me.grdDat
            'con esto ocultas todos los campos
            Dim I As Integer
            For I = 1 To .DisplayLayout.Bands(0).Columns.Count - 1
                .DisplayLayout.Bands(0).Columns(I).Hidden = True
                .DisplayLayout.Bands(0).Columns(I).CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
            Next
            If msOpc = "C" Then
                ConfiguraColGrilla(Me.grdDat, 0, "Empr", 0, True, True, False)
                ConfiguraColGrilla(Me.grdDat, 1, "Id.Cli.", 50, True, False, False)
                ConfiguraColGrilla(Me.grdDat, 2, "T.C.", 50, True, True, False)
                ConfiguraColGrilla(Me.grdDat, 3, "Tipo", 50, True, False, False)
                ConfiguraColGrilla(Me.grdDat, 4, "DNI/RUC", 100, True, False, False)
                ConfiguraColGrilla(Me.grdDat, 5, "Nombre/Razón Social", 200, False, False, False)
                ConfiguraColGrilla(Me.grdDat, 6, "Dirección", 200, True, False, False)
                ConfiguraColGrilla(Me.grdDat, 7, "Teléfono", 100, False, False, False)
                ConfiguraColGrilla(Me.grdDat, 8, "Email", 200, False, False, False)
                ConfiguraColGrilla(Me.grdDat, 9, "Cod.Est.", 50, True, True, False)
                ConfiguraColGrilla(Me.grdDat, 10, "Estado", 100, False, False, False)

            ElseIf msOpc = "P" Then
                ConfiguraColGrilla(Me.grdDat, 0, "Id.Prod", 50, True, False, False)
                ConfiguraColGrilla(Me.grdDat, 1, "Empr", 0, True, True, False)
                ConfiguraColGrilla(Me.grdDat, 2, "CodCat", 50, True, True, False)
                ConfiguraColGrilla(Me.grdDat, 3, "Categoría", 100, True, False, False)
                ConfiguraColGrilla(Me.grdDat, 4, "CodUM", 100, True, True, False)
                ConfiguraColGrilla(Me.grdDat, 5, "Uni.Med.", 100, True, False, False)
                ConfiguraColGrilla(Me.grdDat, 6, "descripción", 200, False, False, False)
                ConfiguraColGrilla(Me.grdDat, 7, "Precio", 100, True, False, False)
                ConfiguraColGrilla(Me.grdDat, 8, "Stock", 100, False, False, False)
                ConfiguraColGrilla(Me.grdDat, 9, "Stk.Min.", 100, False, False, False)
                ConfiguraColGrilla(Me.grdDat, 10, "Cod.Est.", 50, True, True, False)
                ConfiguraColGrilla(Me.grdDat, 11, "Estado", 100, False, False, False)
            End If
            grdDat.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.Default
        End With
        EstiloGrillaInfrag(Me.grdDat)
    End Sub
    Private Sub grdDat_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles grdDat.DoubleClickRow
        If msOpc = "C" Then
            SIGC_Fer_Ope_frmVtaDet.txtCodClte.Text = e.Row.Cells("CLI_NRODOC").Value
            SIGC_Fer_Ope_frmVtaDet.txtDesClte.Text = e.Row.Cells("CLI_NOMBRE").Value
            SIGC_Fer_Ope_frmVtaDet.txtCodProd.Focus()
        End If
        If msOpc = "P" Then
            SIGC_Fer_Ope_frmVtaDet.txtCodProd.Text = e.Row.Cells("prod_id").Value
            SIGC_Fer_Ope_frmVtaDet.txtDesProd.Text = e.Row.Cells("prod_desc").Value
            SIGC_Fer_Ope_frmVtaDet.txtCat.Text = e.Row.Cells("CATEG_DESC").Value
            SIGC_Fer_Ope_frmVtaDet.txtUni.Text = e.Row.Cells("UNIMED_DESC").Value
            SIGC_Fer_Ope_frmVtaDet.txtStk.Text = e.Row.Cells("PROD_STOCK").Value
            SIGC_Fer_Ope_frmVtaDet.txtPre.Text = e.Row.Cells("PROD_PRECIO").Value
            SIGC_Fer_Ope_frmVtaDet.txtCodProd.Focus()
        End If
        Me.Close()
    End Sub
End Class