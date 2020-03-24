Imports SIGC_FerBL
Public Class SIGC_Fer_Tab_frmMarca
    Private dt As New DataTable
    Private mbCargar As Boolean
    Private Editando As Boolean
    Private Nuevo As Boolean
    Private Cargando As Boolean

    Private Sub SIGC_Fer_frmMarc_Load(sender As Object, e As EventArgs) Handles Me.Load
        mbCargar = False
        Me.WindowState = FormWindowState.Maximized
        LlenarGrilla()
        tabDet.Enabled = False
        grdDat.Enabled = True
        EliminarToolStripMenuItem.Enabled = True
        AgregarToolStripMenuItem.Enabled = True
        ExportarToolStripMenuItem.Enabled = True
        ModificarToolStripMenuItem.Enabled = True
        GrabarToolStripMenuItem.Enabled = False
        CancelarToolStripMenuItem.Enabled = False
        mbCargar = True
    End Sub
    Private Sub LlenarGrilla()
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim ds As DataSet = New DataSet
            Dim BL As New SIGC_FerBL.Mantenimiento.BL_Catalogos
            Dim dt As New DataTable
            'dt = BL.fListarCatalogoTabla(GS_EMP_ID, "SIGC_SP_ListarCatalogoTabla", "SIGC_MARCAS")

            BL = Nothing

            Me.grdDat.DataSource = dt ' ds.Tables(0)
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
            ConfiguraColGrilla(Me.grdDat, 0, "Id", 100, True, True, False)
            ConfiguraColGrilla(Me.grdDat, 1, "Código", 100, True, False, False)
            ConfiguraColGrilla(Me.grdDat, 2, "Descripción", 200, True, False, False)
            ConfiguraColGrilla(Me.grdDat, 3, "Estado", 100, True, False, False)
            grdDat.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.Default

        End With
        EstiloGrillaInfrag(Me.grdDat)
    End Sub

End Class