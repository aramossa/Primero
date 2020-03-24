Imports SIGC_FerBL
Public Class SIGC_Neg_Cat_frmClte
    Private dt As New DataTable
    Private mbCargar As Boolean
    Private Editando As Boolean
    Private Nuevo As Boolean
    Private Cargando As Boolean
    Private Sub SIGC_Neg_Tab_frmClte_Load(sender As Object, e As EventArgs) Handles Me.Load
        mbCargar = False
        Me.WindowState = FormWindowState.Maximized

        LlenarGrilla()

        UltraTabPageControl1.Enabled = False
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
            '            ds = BL.fListarClientes(GS_EMP_ID)
            dt = BL.fListarClientes(GS_EMP_ID)

            BL = Nothing

            Me.grdDat.DataSource = dt ' ds.Tables(0)
            '            Pinta_InfraGrilla()
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
            ConfiguraColGrilla(Me.grdDat, 0, "CODIGO", 0, True, True, False)
            ConfiguraColGrilla(Me.grdDat, 1, "Ap. Paterno", 100, True, False, False)
            ConfiguraColGrilla(Me.grdDat, 2, "Ap. Materno", 200, True, False, False)
            ConfiguraColGrilla(Me.grdDat, 3, "Nombres", 100, True, False, False)
            ConfiguraColGrilla(Me.grdDat, 4, "Nro. DNI", 200, False, False, False)
            ConfiguraColGrilla(Me.grdDat, 5, "Fec.Nacim.", 100, True, False, False)
            ConfiguraColGrilla(Me.grdDat, 6, "Brevete", 200, False, False, False)
            ConfiguraColGrilla(Me.grdDat, 7, "Tipo Persona", 200, False, False, False)
            ConfiguraColGrilla(Me.grdDat, 8, "Estado", 200, False, False, False)
            grdDat.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.Default

        End With
        EstiloGrillaInfrag(Me.grdDat)
    End Sub
    Private Sub DS_a_CTRLS()
        If Not Me.grdDat.ActiveRow Is Nothing Then
            'If Not Me.grdDat.ActiveRow.IsGroupByRow Then
            '    If Not Me.grdDat.ActiveRow.IsFilterRow Then
            '        Me.ID_Pers.Value = Me.grdDat.ActiveRow.Cells("ID_PERS").Value.ToString
            '        Me.txtApePat.Text = Me.grdDat.ActiveRow.Cells("APE_PAT").Value.ToString
            '        Me.txtApeMat.Text = Me.grdDat.ActiveRow.Cells("APE_MAT").Value.ToString
            '        Me.txtNombres.Text = Me.grdDat.ActiveRow.Cells("NOMBRES").Value.ToString
            '        Me.txtDNI.Text = Me.grdDat.ActiveRow.Cells("NRO_DNI").Value.ToString
            '        Me.dtpFecNac.Value = Me.grdDat.ActiveRow.Cells("FEC_NAC").Value.ToString
            '        Me.txtLicencia.Text = Me.grdDat.ActiveRow.Cells("NRO_BREVETE").Value.ToString
            '        Me.cmbEstado.Text = IIf(Me.grdDat.ActiveRow.Cells("COD_EST").Value.ToString = "ACT", "Activo", "Inactivo")
            '    End If
            'End If
        End If
    End Sub

End Class