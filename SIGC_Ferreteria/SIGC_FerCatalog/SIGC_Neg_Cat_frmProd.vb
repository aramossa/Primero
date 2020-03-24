Imports SIGC_FerBL
Imports Infragistics.Win.UltraWinGrid
Public Class SIGC_Neg_Cat_frmProd
    Private dt As New DataTable
    Private mbCargar As Boolean
    Private Editando As Boolean
    Private Nuevo As Boolean
    Private Cargando As Boolean

    Private Sub SIGC_Neg_Cat_frmProd_Load(sender As Object, e As EventArgs) Handles Me.Load
        mbCargar = False
        Me.WindowState = FormWindowState.Maximized
        LlenarGrilla()
        rCfgBotones(mbCargar)
        mbCargar = True
    End Sub
    ' Carga grilla de datos
    Private Sub LlenarGrilla()
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim BL As New SIGC_FerBL.Mantenimiento.BL_Tablas
            Dim dt As New DataTable
            dt = BL.fListarTablasTabla("SIGC_SP_ListarTablaTabla", GS_TAB_EST)
            BL = Nothing
            Me.grdDat.DataSource = dt
            DS_a_CTRLS(grdDat)
            rCfgGrilla(grdDat)
            EstiloGrillaInfrag(Me.grdDat)
            grdDat.Refresh()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    ' Configura columnas de la grilla
    Private Sub rCfgGrilla(pGrd As UltraGrid)
        With pGrd
            'con esto ocultas todos los campos
            Dim I As Integer
            For I = 1 To .DisplayLayout.Bands(0).Columns.Count - 1
                .DisplayLayout.Bands(0).Columns(I).Hidden = True
                .DisplayLayout.Bands(0).Columns(I).CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
            Next
            ConfiguraColGrilla(pGrd, 0, "Código", 100, True, False, False)
            ConfiguraColGrilla(pGrd, 1, "Descripción", 200, True, False, False)
            ConfiguraColGrilla(pGrd, 2, "Est", 200, True, True, False)
            ConfiguraColGrilla(pGrd, 3, "Estado", 200, True, False, False)
            ConfiguraColGrilla(pGrd, 4, "Id", 200, True, True, False)
            pGrd.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.Default
        End With
        EstiloGrillaInfrag(pGrd)
    End Sub

    ' Configura botones del toolbar
    Private Sub rCfgBotones(ByVal pCfg As Boolean)
        '
        RefrescarToolStripMenuItem.Enabled = Not pCfg
        EliminarToolStripMenuItem.Enabled = Not pCfg
        AgregarToolStripMenuItem.Enabled = Not pCfg
        ExportarToolStripMenuItem.Enabled = Not pCfg
        ModificarToolStripMenuItem.Enabled = Not pCfg
        GrabarToolStripMenuItem.Enabled = pCfg
        CancelarToolStripMenuItem.Enabled = pCfg
        '
        tabDet.Enabled = pCfg
        grdDat.Enabled = Not pCfg
        txtCod.Enabled = pCfg
        txtDes.Enabled = pCfg
        chkEst.Enabled = pCfg
    End Sub

    ' Actualia Campos de los datos seun la linea en que se encuentra
    Private Sub DS_a_CTRLS(pGrd As UltraGrid)
        If Not pGrd.ActiveRow Is Nothing Then
            If Not pGrd.ActiveRow.IsGroupByRow Then
                If Not pGrd.ActiveRow.IsFilterRow Then
                    Me.txtCod.Text = pGrd.ActiveRow.Cells("COD").Value.ToString
                    Me.txtDes.Text = pGrd.ActiveRow.Cells("DES").Value.ToString
                    Me.chkEst.Checked = IIf(pGrd.ActiveRow.Cells("EST").Value.ToString = "1", True, False)
                End If
            End If
        End If
    End Sub

    Private Sub grdDat_AfterRowActivate(sender As Object, e As EventArgs) Handles grdDat.AfterRowActivate
        DS_a_CTRLS(grdDat)
    End Sub

#Region "ToolBar"
    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click
        Editando = False
        Nuevo = True
        rCfgBotones(True)
        rLimCtr()
    End Sub
    Private Sub rLimCtr()
        txtCod.Text = ""
        txtDes.Text = ""
        chkEst.Checked = False
    End Sub

    Private Sub GrabarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrabarToolStripMenuItem.Click
        Dim loRes As Boolean
        Dim lsEst As String
        Dim lsIde As String

        Try
            If Not fValid() Then Exit Sub

            If chkEst.Checked Then
                lsEst = "1"
            Else
                lsEst = "0"
            End If

            Dim BL As New SIGC_FerBL.Mantenimiento.BL_Tablas

            ' Nuevo
            If Nuevo Then
                loRes = BL.fManTab(GS_OPC_ADD, GS_TAB_EST, txtCod.Text.ToString, txtDes.Text.ToString, lsEst, lsIde)
            End If

            ' Modificar
            If Editando Then
                lsIde = grdDat.ActiveRow.Cells("IDE").Value.ToString
                loRes = BL.fManTab(GS_OPC_MOD, GS_TAB_EST, txtCod.Text.ToString, txtDes.Text.ToString, lsEst, lsIde)
            End If

            Cargando = True
            Editando = False
            Nuevo = False
            grdDat.Enabled = True
            LlenarGrilla()
            rCfgBotones(False)
            Cargando = False
            MessageBox.Show("¡Guardado con éxito!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            'DS_a_CTRLS()
            MessageBox.Show("ERROR AL INTENTAR GRABAR: " & vbCrLf & ex.Message, "SOD", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Function fValid() As Boolean
        fValid = False
        If txtCod.Text.ToString.Trim = "" Or txtCod.Text.ToString.Trim Is Nothing Then
            MessageBox.Show("No a ingresado Código... ", "SIGC", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Function
        End If
        If txtDes.Text.ToString.Trim = "" Then
            MessageBox.Show("No a ingresado descripción... ", "SIGC", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Function
        End If
        fValid = True
    End Function

    Private Sub CancelarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelarToolStripMenuItem.Click
        rCfgBotones(False)
        DS_a_CTRLS(grdDat)
    End Sub

    Private Sub ExportarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportarToolStripMenuItem.Click
        If grdDat.DataSource IsNot Nothing Then
            If grdDat.Rows.Count > 0 Then
                Dim lsArch As String
                Dim DialogSave As New SaveFileDialog
                ' Extension por defecto
                DialogSave.DefaultExt = "xls"
                ' Extensiones disponibles
                DialogSave.Filter = "Libro de Microsoft Office Excel(*.xls)|*.xls|XML file (*.xml)|*.xml|All files (*.*)|*.*"
                'Anadir extension en cas de que el usuario no lo haga
                DialogSave.AddExtension = True
                ' Restaura el directosio selectionado la proxima vez
                DialogSave.RestoreDirectory = True
                ' Titulo de la ventana
                DialogSave.Title = "Where do you want to save the file?"
                ' Directorio donde compenzar a buscar
                DialogSave.InitialDirectory = Application.StartupPath    '"C:/"
                If DialogSave.ShowDialog() = DialogResult.OK Then
                    'MessageBox.Show("Selectionaste el fichero: " + DialogSave.FileName)
                Else
                    MessageBox.Show("Se cancelo la operación.")
                    Exit Sub
                End If
                Me.Cursor = Cursors.WaitCursor
                lsArch = Trim(DialogSave.FileName.ToString)
                Me.UltraGridExcelExporter1.Export(Me.grdDat, lsArch)
                MessageBox.Show("Se generó el archivo " + lsArch, Me.Text, MessageBoxButtons.OK)
                Me.Cursor = Cursors.Default
                DialogSave.Dispose()
                DialogSave = Nothing

                System.Diagnostics.Process.Start(lsArch)
                Exit Sub
            Else
                MessageBox.Show("Debe tener datos para poder exportar.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Debe tener datos para poder exportar.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub RefrescarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefrescarToolStripMenuItem.Click
        LlenarGrilla()
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        Editando = True
        Nuevo = False
        rCfgBotones(True)
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Dim loRes As Boolean
        Dim lsEst As String
        Dim lsIde As String

        If txtCod.Text = String.Empty Then
            MessageBox.Show("Debe elejir un registro de la grilla para poder Eliminar", "Mensaje del Programa", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If MessageBox.Show("¿Está seguro que desea dejar Inactivo el registro", "Mensaje del Programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            Dim BL As New SIGC_FerBL.Mantenimiento.BL_Tablas
            lsIde = grdDat.ActiveRow.Cells("IDE").Value.ToString
            lsEst = "0"
            loRes = BL.fManTab(GS_OPC_MOD, GS_TAB_EST, txtCod.Text.ToString, txtDes.Text.ToString, lsEst, lsIde)
            MessageBox.Show("¡Realizado con éxito!", "Mensaje del Programa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LlenarGrilla()
        End If

    End Sub

#End Region

End Class