Imports SIGC_FerBL
Public Class SIGC_Fer_Tab_frmCateg
    Private dt As New DataTable
    Private mbCargar As Boolean
    Private Editando As Boolean
    Private Nuevo As Boolean
    Private Eliminando As Boolean
    Private Cargando As Boolean
    Private Sub SIGC_Fer_Tab_frmCateg_Load(sender As Object, e As EventArgs) Handles Me.Load
        mbCargar = False
        Me.WindowState = FormWindowState.Maximized
        LlenarGrilla()
        rCfgBotones(mbCargar)
        mbCargar = True
    End Sub
    Private Sub LlenarGrilla()
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim ds As DataSet = New DataSet
            Dim BL As New SIGC_FerBL.Mantenimiento.BL_Tablas
            Dim dt As New DataTable
            dt = BL.fListarTablaCateg(GS_EMP_ID)
            BL = Nothing
            Me.grdDat.DataSource = dt
            DS_a_CTRLS(grdDat)
            Pinta_InfraGrilla()
            EstiloGrillaInfrag(Me.grdDat)
            grdDat.Refresh()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub DS_a_CTRLS(grdDat)
        If Not Me.grdDat.ActiveRow Is Nothing Then
            If Not Me.grdDat.ActiveRow.IsGroupByRow Then
                If Not Me.grdDat.ActiveRow.IsFilterRow Then
                    Me.txtId.Text = Me.grdDat.ActiveRow.Cells("CATEG_ID").Value.ToString
                    Me.txtDes.Text = Me.grdDat.ActiveRow.Cells("CATEG_DESC").Value.ToString
                    If Me.grdDat.ActiveRow.Cells("CATEG_EST").Value.ToString = "A" Then
                        Me.chkEst.Checked = True
                    Else
                        Me.chkEst.Checked = False
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub Pinta_InfraGrilla()
        With Me.grdDat
            'con esto ocultas todos los campos
            Dim I As Integer
            For I = 1 To .DisplayLayout.Bands(0).Columns.Count - 1
                .DisplayLayout.Bands(0).Columns(I).Hidden = True
                .DisplayLayout.Bands(0).Columns(I).CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
            Next
            ConfiguraColGrilla(Me.grdDat, 0, "Empr", 0, True, True, False)
            ConfiguraColGrilla(Me.grdDat, 1, "Id.Cat.", 50, True, False, False)
            ConfiguraColGrilla(Me.grdDat, 2, "Descripción", 200, True, False, False)
            ConfiguraColGrilla(Me.grdDat, 3, "Cod.Est.", 50, True, True, False)
            ConfiguraColGrilla(Me.grdDat, 4, "Estado", 100, False, False, False)
            grdDat.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.Default
        End With
        EstiloGrillaInfrag(Me.grdDat)
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
        txtId.Enabled = False
        tabDet.Enabled = pCfg
        grdDat.Enabled = Not pCfg
        txtDes.Enabled = pCfg
        chkEst.Enabled = pCfg
    End Sub
    Private Sub grdDat_AfterRowActivate(sender As Object, e As EventArgs) Handles grdDat.AfterRowActivate
        DS_a_CTRLS(grdDat)
    End Sub

#Region "ToolBar"
    ' Refrescar
    Private Sub RefrescarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefrescarToolStripMenuItem.Click
        LlenarGrilla()
    End Sub
    ' Agregar
    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click
        Editando = False
        Nuevo = True
        rCfgBotones(True)
        rLimCtr()
        txtDes.Focus()
        chkEst.Checked = True
    End Sub
    ' Modificar
    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        Editando = True
        Nuevo = False
        rCfgBotones(True)
    End Sub
    ' Eliminar
    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Eliminando = True
        Editando = False
        Nuevo = False
        rCfgBotones(True)
    End Sub

    Private Sub rLimCtr()
        txtId.Enabled = False
        txtDes.Text = ""
        chkEst.Checked = False
    End Sub

    Private Sub GrabarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrabarToolStripMenuItem.Click
        Dim loRes As Boolean
        Dim lsEst As String
        Dim lnId As Integer
        Try
            If Not fValid() Then Exit Sub
            If chkEst.Checked Then
                lsEst = "A"
            Else
                lsEst = "I"
            End If
            Dim BL As New SIGC_FerBL.Mantenimiento.BL_Tablas

            ' Nuevo
            If Nuevo Then
                If txtId.Text.ToString = "" Then
                    lnId = 0
                Else
                    lnId = CInt(txtId.Text.ToString)
                End If
                loRes = BL.fManTabCateg(GS_OPC_ADD, lnId, GS_EMP_ID, txtDes.Text, lsEst)
            End If

            ' Modificar
            If Editando Then
                lnId = grdDat.ActiveRow.Cells("CATEG_ID").Value.ToString
                loRes = BL.fManTabCateg(GS_OPC_MOD, lnId, GS_EMP_ID, txtDes.Text, lsEst)
            End If

            If Eliminando Then
                lnId = grdDat.ActiveRow.Cells("CATEG_ID").Value.ToString
                lsEst = "I"
                loRes = BL.fManTabCateg(GS_OPC_DEL, lnId, GS_EMP_ID, txtDes.Text, lsEst)
            End If

            Cargando = True
            Eliminando = False
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
        If txtDes.Text.ToString.Trim = "" Or txtDes.Text.ToString.Trim Is Nothing Then
            MessageBox.Show("No a ingresado descripción... ", "SIGC", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDes.Focus()
            Exit Function
        End If
        fValid = True
        'If Regex.IsMatch(txtEma.Text,
        '       "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-  
        '       9-]+)*(\.[a-z]{2,4})$") = False Then
        '    MessageBox.Show("No a ingresado email... ", "SIGC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    txtEma.Focus()
        '    Exit Function
        'End If
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

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If SIGC_Fer_Pri.tabOpc.TabPages.Count = 0 Then Exit Sub
        CType(SIGC_Fer_Pri.tabOpc.SelectedTab.Tag, Form).Close()
        SIGC_Fer_Pri.tabOpc.TabPages.Remove(SIGC_Fer_Pri.tabOpc.SelectedTab)
    End Sub
#End Region

End Class