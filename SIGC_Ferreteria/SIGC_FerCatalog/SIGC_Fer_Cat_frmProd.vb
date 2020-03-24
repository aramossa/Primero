Imports SIGC_FerBL
Imports System.Text.RegularExpressions
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Public Class SIGC_Fer_Cat_frmProd
    Private dt As New DataTable
    Private mbCargar As Boolean
    Private Editando As Boolean
    Private Nuevo As Boolean
    Private Eliminando As Boolean
    Private Cargando As Boolean

    Private Sub SIGC_Fer_Cat_frmProd_Load(sender As Object, e As EventArgs) Handles Me.Load
        mbCargar = False
        Me.WindowState = FormWindowState.Maximized
        LlenarCmbCat()
        LlenarCmbUni()
        LlenarGrilla()
        rCfgBotones(mbCargar)
        mbCargar = True
    End Sub
    ' Carga grilla de datos
    Private Sub LlenarGrilla()
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim ds As DataSet = New DataSet
            Dim BL As New SIGC_FerBL.Mantenimiento.BL_Catalogos
            Dim dt As New DataTable
            dt = BL.fListarProductos(GS_EMP_ID)
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
    ' Carga Combo Categorías
    Private Sub LlenarCmbCat()
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim ds As DataSet = New DataSet
            Dim BL As New SIGC_FerBL.Mantenimiento.BL_Tablas
            Dim dt As New DataTable
            dt = BL.fListarTablaCateg(GS_EMP_ID, "C")
            rCfgCmb(cmbCat, dt, "Descripción", "Código")
            BL = Nothing
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    ' Carga Combo Unidad de Medida
    Private Sub LlenarCmbUni()
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim ds As DataSet = New DataSet
            Dim BL As New SIGC_FerBL.Mantenimiento.BL_Tablas
            Dim dt As New DataTable
            dt = BL.fListarTablaUniMed(GS_EMP_ID, "C")
            rCfgCmb(cmbUni, dt, "Descripción", "Código")
            BL = Nothing
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub rCfgCmb(ByVal pCmb As UltraCombo, ByVal pDt As DataTable, ByVal psDis As String, ByVal psVal As String)
        pCmb.DataSource = pDt
        pCmb.DisplayMember = psDis
        pCmb.ValueMember = psVal
        pCmb.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        pCmb.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
    End Sub
    Private Sub DS_a_CTRLS(grdDat)
        If Not Me.grdDat.ActiveRow Is Nothing Then
            If Not Me.grdDat.ActiveRow.IsGroupByRow Then
                If Not Me.grdDat.ActiveRow.IsFilterRow Then
                    Me.txtId.Text = Me.grdDat.ActiveRow.Cells("PROD_ID").Value.ToString
                    Me.cmbCat.Value = Me.grdDat.ActiveRow.Cells("CATEG_ID").Value.ToString
                    Me.cmbUni.Value = Me.grdDat.ActiveRow.Cells("UNIMED_ID").Value.ToString
                    Me.txtDes.Text = Me.grdDat.ActiveRow.Cells("PROD_DESC").Value.ToString
                    Me.txtPre.Text = Me.grdDat.ActiveRow.Cells("PROD_PRECIO").Value.ToString
                    Me.txtStk.Text = Me.grdDat.ActiveRow.Cells("PROD_STOCK").Value.ToString
                    Me.txtMin.Text = Me.grdDat.ActiveRow.Cells("PROD_STOCKMIN").Value.ToString
                    If Me.grdDat.ActiveRow.Cells("PROD_EST").Value.ToString = "A" Then
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
        cmbCat.Enabled = pCfg
        cmbUni.Enabled = pCfg
        txtDes.Enabled = pCfg
        txtPre.Enabled = pCfg
        txtStk.Enabled = pCfg
        txtMin.Enabled = pCfg
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
        cmbCat.Focus()
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

        'Dim loRes As Boolean
        'Dim lsEst As String
        'Dim lnId As Integer

        'If txtId.Text = String.Empty Then
        '    MessageBox.Show("Debe elejir un registro de la grilla para poder Eliminar", "Mensaje del Programa", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If

        'If MessageBox.Show("¿Está seguro que desea dejar Inactivo el registro", "Mensaje del Programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
        '    Dim BL As New SIGC_FerBL.Mantenimiento.BL_Tablas
        '    lsIde = grdDat.ActiveRow.Cells("IDE").Value.ToString
        '    lsEst = "0"
        '    loRes = BL.fManTab(GS_OPC_MOD, GS_TAB_EST, txtId.Text.ToString, txtDoc.Text.ToString, lsEst, lsIde)
        '    MessageBox.Show("¡Realizado con éxito!", "Mensaje del Programa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    LlenarGrilla()
        'End If

    End Sub

    Private Sub rLimCtr()
        txtId.Enabled = False
        cmbCat.Value = ""
        cmbUni.Value = ""
        txtDes.Text = ""
        txtPre.Text = ""
        txtStk.Text = ""
        txtMin.Text = ""
        chkEst.Checked = False
    End Sub

    Private Sub GrabarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrabarToolStripMenuItem.Click
        Dim loRes As Boolean
        Dim lsEst As String
        Dim lnCat As Integer
        Dim lnUni As Integer
        Dim lnId As Integer
        Try
            If Not fValid() Then Exit Sub
            If chkEst.Checked Then
                lsEst = "A"
            Else
                lsEst = "I"
            End If

            lnCat = cmbCat.Value
            lnUni = cmbUni.Value
            Dim BL As New SIGC_FerBL.Mantenimiento.BL_Catalogos

            ' Nuevo
            If Nuevo Then
                loRes = BL.fManTabProd(GS_OPC_ADD, lnId, GS_EMP_ID, lnCat, lnUni, txtDes.Text, txtPre.Text, txtStk.Text, txtMin.Text, lsEst)
            End If

            ' Modificar
            If Editando Then
                lnId = grdDat.ActiveRow.Cells("PROD_ID").Value.ToString
                loRes = BL.fManTabProd(GS_OPC_MOD, lnId, GS_EMP_ID, lnCat, lnUni, txtDes.Text, txtPre.Text, txtStk.Text, txtMin.Text, lsEst)
            End If

            If Eliminando Then
                lnId = grdDat.ActiveRow.Cells("PROD_ID").Value.ToString
                lsEst = "I"
                loRes = BL.fManTabProd(GS_OPC_DEL, lnId, GS_EMP_ID, lnCat, lnUni, txtDes.Text, txtPre.Text, txtStk.Text, txtMin.Text, lsEst)
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
        If txtPre.Text.ToString.Trim = "" Or txtPre.Text.ToString.Trim Is Nothing Then
            MessageBox.Show("No a ingresado Precio... ", "SIGC", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPre.Focus()
            Exit Function
        End If
        If txtStk.Text.ToString.Trim = "" Or txtStk.Text.ToString.Trim Is Nothing Then
            MessageBox.Show("No a ingresado Stock... ", "SIGC", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtStk.Focus()
            Exit Function
        End If
        If txtMin.Text.ToString.Trim = "" Or txtMin.Text.ToString.Trim Is Nothing Then
            MessageBox.Show("No a ingresado Stock Mínimo... ", "SIGC", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMin.Focus()
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