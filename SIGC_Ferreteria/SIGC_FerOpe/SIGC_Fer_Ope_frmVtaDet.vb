Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class SIGC_Fer_Ope_frmVtaDet
    Inherits System.Windows.Forms.Form
    Private dt As New DataTable
    Private mbCargar As Boolean
    Private Editando As Boolean
    Private Nuevo As Boolean
    Private Eliminando As Boolean
    Private Cargando As Boolean
    Public msOpc As String ', msTipo As String, msMonto As String, msEst As String
    Public miCab As Integer ', mnDsctoDet As Integer, mnDsctoUsu As Integer
    Public mnTotDoc As Double
    Private Sub SIGC_Fer_Ope_frmVtaDet_Load(sender As Object, e As EventArgs) Handles Me.Load
        If msOpc = GS_OPC_ADD Then
            Me.Text = "Ingresar Venta"
            txtCodClte.Focus()
            rIngDat()
        ElseIf msOpc = GS_OPC_MOD Then
            Me.Text = "Modificar Venta"
            'rModDat()
        ElseIf msOpc = GS_OPC_DEL Then
            Me.Text = "Anular Venta"
            'rInaDat()
        End If
        LlenarGrilla()
    End Sub
    Private Sub LlenarGrilla()
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim ds As DataSet = New DataSet
            Dim BL As New SIGC_FerBL.Mantenimiento.BL_Operaciones
            Dim dt As New DataTable
            dt = BL.fListarVtasDet(GS_EMP_ID, miCab)
            BL = Nothing
            Me.grdDat.DataSource = dt
            ' DS_a_CTRLS(grdDat)
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
            ConfiguraColGrilla(Me.grdDat, 0, "Id.Vta.", 0, True, True, False)
            ConfiguraColGrilla(Me.grdDat, 1, "Sec.Vta.", 50, True, True, False)
            ConfiguraColGrilla(Me.grdDat, 2, "Cab.Vta.", 50, True, True, False)
            ConfiguraColGrilla(Me.grdDat, 3, "Id.Empr.", 50, True, True, False)
            ConfiguraColGrilla(Me.grdDat, 4, "Id.Prod.", 50, True, False, False)
            ConfiguraColGrilla(Me.grdDat, 5, "Producto", 200, False, False, False)
            ConfiguraColGrilla(Me.grdDat, 6, "Precio", 70, True, False, False,, HAlign.Right)
            ConfiguraColGrilla(Me.grdDat, 7, "Cantidad", 70, True, False, False,, HAlign.Right)
            ConfiguraColGrilla(Me.grdDat, 8, "Val.Vta.", 70, True, True, False,, HAlign.Right)
            ConfiguraColGrilla(Me.grdDat, 9, "Val.Igv.", 70, False, True, False,, HAlign.Right)
            ConfiguraColGrilla(Me.grdDat, 10, "Total", 70, False, False, False,, HAlign.Right)
            grdDat.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.Default
        End With
        EstiloGrillaInfrag(Me.grdDat)
    End Sub
    Private Sub rIngDat()
        Editando = False
        Nuevo = True
        rLimDatClte() ' Limpiar Datos Cliente
        rLimDatProd() ' Limpiar Datos Producto
    End Sub
    ' Limpiar Datos Cliente
    Private Sub rLimDatClte()
        mnTotDoc = 0
        txtCodClte.Text = ""
        txtDesClte.Text = ""
    End Sub
    ' Limpiar Datos Producto
    Private Sub rLimDatProd()
        txtCodProd.Text = ""
        txtDesProd.Text = ""
        txtCat.Text = ""
        txtUni.Text = ""
        txtStk.Text = ""
        txtPre.Text = ""
        txtCan.Text = ""
    End Sub
    Private Sub cmdClte_Click(sender As Object, e As EventArgs) Handles cmdClte.Click
        Dim f As New SIGC_FerTab_frmAyu
        f.msOpc = "C"
        txtCodProd.Focus()
        f.ShowDialog()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As New SIGC_FerTab_frmAyu
        f.msOpc = "P"
        f.ShowDialog()
        txtPre.Focus()
    End Sub
    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub
    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        'Dim loRes As Boolean
        'Dim lsEst As String
        'Dim lsTip As String
        'Dim lnId As Integer
        Try
            If Not fValidVtaCab() Then Exit Sub
            ' Grabar cabecera del documento
            Dim BL As New SIGC_FerBL.Mantenimiento.BL_Operaciones
            ' Nuevo
            'If Nuevo Then
            '    If txtId.Text.ToString = "" Then
            '        lnId = 0
            '    Else
            '        lnId = CInt(txtId.Text.ToString)
            '    End If
            '    loRes = BL.fManVtasCab(GS_OPC_ADD, GS_EMP_ID, lnId, lsTip, txtDoc.Text, txtNom.Text, txtDir.Text, txtTel.Text, txtEma.Text, lsEst)
            '    BL.fManVtasCab(mnDsctoCab, GS_EMP_ID, txtCodProd.Text.ToString, GS_COD_DSCTO, txtMargProv.Text.ToString, GS_EST_ACT, GS_USUARIO, msOpc)
            'End If

            'BL.MntoDsctoUsu(mnDsctoUsu, GS_EMP_ID, txtCodClte.Text.ToString, mnDsctoCab, GS_EST_ACT, GS_USUARIO, msOpc)
            '' Grabar Cliente
            'For Each Fila In grdDat.Rows
            '    lnIni = System.Convert.ToDecimal(Fila.Cells("rango_ini").Value)
            '    lnFin = System.Convert.ToDecimal(Fila.Cells("rango_fin").Value)
            '    lnDscto = System.Convert.ToDecimal(Fila.Cells("pct_dscto").Value)
            '    lnComis = System.Convert.ToDecimal(Fila.Cells("pct_comis").Value)
            '    BL.MntoDsctoDet(mnDsctoUsu, GS_COD_DSCTO, lnIni, lnFin, lnDscto, lnComis, GS_EMP_ID, GS_EST_ACT, GS_USUARIO, msOpc)
            'Next
            MessageBox.Show("¡Guardado con éxito!", str_NOM_CORTO, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Grabar rangos
        Catch ex As Exception
            'MessageBox.Show("ERROR AL INTENTAR GRABAR: " & vbCrLf & ex.Message, str_NOM_CORTO, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Close()
    End Sub
    Private Function fValidVtaCab() As Boolean
        fValidVtaCab = False
        If txtCodClte.Text.ToString.Trim = "" Or txtCodClte.Text.ToString.Trim Is Nothing Then
            MessageBox.Show("Ingrese Cliente... ", "SIGC", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCodClte.Focus()
            Exit Function
        End If
        fValidVtaCab = True
    End Function
    Private Function fValidVtaDet() As Boolean
        fValidVtaDet = False
        If txtCodProd.Text.ToString.Trim = "" Or txtCodProd.Text.ToString.Trim Is Nothing Then
            MessageBox.Show("Ingrese Producto... ", "SIGC", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCodProd.Focus()
            Exit Function
        End If
        'If txtDir.Text.ToString.Trim = "" Or txtDir.Text.ToString.Trim Is Nothing Then
        '    MessageBox.Show("No a ingresado dirección... ", "SIGC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    txtDir.Focus()
        '    Exit Function
        'End If
        'If txtTel.Text.ToString.Trim = "" Or txtTel.Text.ToString.Trim Is Nothing Then
        '    MessageBox.Show("No a ingresado teléfono... ", "SIGC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    txtTel.Focus()
        '    Exit Function
        'End If
        'If txtEma.Text.ToString.Trim = "" Or txtEma.Text.ToString.Trim Is Nothing Then
        '    MessageBox.Show("No a ingresado email... ", "SIGC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    txtEma.Focus()
        '    Exit Function
        'End If
        fValidVtaDet = True
    End Function
    ' Valida despues de haber ingresado el codigo de cliente
    Private Sub txtCodClte_LostFocus(sender As Object, e As EventArgs) Handles txtCodClte.LostFocus
        If txtCodClte.Text.ToString.Trim <> "" Then
            fConsDatClte(GS_EMP_ID, txtCodClte.Text.ToString)
        End If
    End Sub
    ' Valida despues de haber ingresado el codigo de producto
    Private Sub txtCodProd_LostFocus(sender As Object, e As EventArgs) Handles txtCodProd.LostFocus
        If txtCodProd.Text.ToString.Trim <> "" Then
            fConsDatProd(GS_EMP_ID, txtCodProd.Text.ToString)
        End If
    End Sub
    ' Valida codigo de cliente ingresado
    Function fConsDatClte(ByVal piEmpr As Integer, ByVal psClte As String) As Boolean
        Try
            Dim BL As New SIGC_FerBL.Mantenimiento.BL_Operaciones
            Dim dt As New DataTable
            Dim dr As DataRow
            fConsDatClte = 0
            dt = BL.fConsDatClte(piEmpr, "D", psClte)
            BL = Nothing

            If dt.Rows.Count = 0 Then
                MessageBox.Show("No se encontró Cliente con el código indicado... ", str_NOM_CORTO, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If dt.Rows(0)(0).ToString = "" Then
                    fConsDatClte = False
                Else
                    dr = dt.Rows(0)
                    txtDesClte.Text = dr("cli_nombre")
                    fConsDatClte = True 'dt.Rows(0)(0).ToString + 1
                    txtCodProd.Focus()
                End If
            End If
        Catch ex As Exception
            fConsDatClte = False
            MsgBox(ex.Message)
        End Try
    End Function
    ' Valida codigo de producto ingresado
    Function fConsDatProd(ByVal piEmpr As Integer, ByVal psProd As String) As Boolean
        Try
            Dim BL As New SIGC_FerBL.Mantenimiento.BL_Operaciones
            Dim dt As New DataTable
            Dim dr As DataRow
            fConsDatProd = 0
            dt = BL.fConsDatProd(piEmpr, "D", psProd)
            BL = Nothing

            If dt.Rows.Count = 0 Then
                MessageBox.Show("No se encontró Producto con el código indicado... ", str_NOM_CORTO, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If dt.Rows(0)(0).ToString = "" Then
                    fConsDatProd = False
                Else
                    dr = dt.Rows(0)
                    txtDesProd.Text = dr("prod_desc")
                    txtCat.Text = dr("CATEG_DESC")
                    txtUni.Text = dr("UNIMED_DESC")
                    txtStk.Text = dr("PROD_STOCK")
                    txtPre.Text = dr("PROD_PRECIO")
                    txtPre.Focus()
                    fConsDatProd = True 'dt.Rows(0)(0).ToString + 1
                End If
            End If
        Catch ex As Exception
            fConsDatProd = False
            MsgBox(ex.Message)
        End Try
    End Function
    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        Try
            If Not fValid() Then Exit Sub
            ' Agrega Registro
            grdDat.DisplayLayout.Bands(0).AddNew()
            ' Limpiar Datos
            rLimDatProd()
            txtCodProd.Focus()
        Catch ex As Exception
            MessageBox.Show("Error al agregar producto..." & vbCrLf & ex.Message, str_NOM_CORTO, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub cmdDel_Click(sender As Object, e As EventArgs) Handles cmdDel.Click
        If Me.grdDat.Selected.Rows.Count > 0 Then
            Me.grdDat.DeleteSelectedRows()
        Else
            MessageBox.Show("Seleccione registro a borrar")
        End If
    End Sub
    Private Function fValid() As Boolean
        Dim lnCan As Integer, lnStk As Integer ', lnIniGrd As Integer, lnFinGrd As Integer
        lnCan = System.Convert.ToDecimal(txtCan.Text)
        lnStk = System.Convert.ToDecimal(txtStk.Text)

        fValid = False

        If txtCodClte.Text.ToString.Trim = "" Then
            MessageBox.Show("Ingrese Cliente... ", str_NOM_CORTO, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCodClte.Focus()
            Exit Function
        End If

        If txtCodProd.Text.ToString.Trim = "" Then
            MessageBox.Show("Ingrese Producto... ", str_NOM_CORTO, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCodProd.Focus()
            Exit Function
        End If

        If txtPre.Text.ToString.Trim = "" Then
            MessageBox.Show("Ingrese Precio... ", str_NOM_CORTO, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPre.Focus()
            Exit Function
        End If

        If txtCan.Text.ToString.Trim = "" Then
            MessageBox.Show("Ingrese Cantidad... ", str_NOM_CORTO, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCan.Focus()
            Exit Function
        End If

        If lnStk < lnCan Then
            MessageBox.Show("Stock insuficiente... ", str_NOM_CORTO, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCan.Focus()
            Exit Function
        End If

        ' 
        'For Each Fila In grdDat.Rows
        '    lnIniGrd = System.Convert.ToDecimal(Fila.Cells("rango_ini").Value)
        '    lnFinGrd = System.Convert.ToDecimal(Fila.Cells("rango_fin").Value)
        '    If lnIniDat >= lnIniGrd And lnIniDat <= lnFinGrd Then
        '        MessageBox.Show("ERROR Rango Ingresado ya está contenido en otro ... ", str_NOM_CORTO, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        txtRanFin.Focus()
        '        Exit Function
        '    End If
        'Next

        fValid = True
    End Function

    Private Sub grdDat_AfterRowInsert(sender As Object, e As RowEventArgs) Handles grdDat.AfterRowInsert
        Try
            Dim lnTotPrd As Double
            lnTotPrd = CDbl(txtPre.Text.ToString) * CDbl(txtCan.Text.ToString)
            mnTotDoc = mnTotDoc + lnTotPrd
            e.Row.Cells("VDET_ID").Value = 0 'txtRanIni.Text.ToString
            e.Row.Cells("VDET_SEC").Value = 0 'txtRanFin.Text.ToString
            e.Row.Cells("VCAB_ID").Value = miCab
            e.Row.Cells("EMP_ID").Value = GS_EMP_ID
            e.Row.Cells("PROD_ID").Value = txtCodProd.Text.ToString
            e.Row.Cells("PROD_DESC").Value = txtDesProd.Text.ToString
            e.Row.Cells("VDET_CAN").Value = txtCan.Text.ToString
            e.Row.Cells("VDET_PRECIO").Value = txtPre.Text.ToString
            e.Row.Cells("VDET_VALVTA").Value = 0 'txtPctComis.Text.ToString
            e.Row.Cells("VDET_VALIGV").Value = 0 'txtPctComis.Text.ToString
            e.Row.Cells("VDET_VALTOT").Value = lnTotPrd 'txtPctComis.Text.ToString
            txtTot.Text = mnTotDoc
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class