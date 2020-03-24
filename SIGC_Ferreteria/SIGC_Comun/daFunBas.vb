Module daFunBas

#Region "Mouse"

    Public Sub MouseWaitON()
        '// varios Application.DoEvents() por recomendacion de C.Cama
        Application.DoEvents()
        Application.DoEvents()
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Application.DoEvents()
        Application.DoEvents()
    End Sub

    Public Sub MouseWaitOFF()
        '// varios Application.DoEvents() por recomendacion de C.Cama
        Application.DoEvents()
        Application.DoEvents()
        Cursor.Current = System.Windows.Forms.Cursors.Arrow
        Application.DoEvents()
        Application.DoEvents()
    End Sub

#End Region

#Region "Avisos usuario"

    Public Sub AvisoError(ByVal psMSJ As String)
        MsgBox(psMSJ, MsgBoxStyle.Information, str_NOM_SISTEMA)
    End Sub

    Public Sub MsgErrorCritico(ByVal psMSJ As String)
        MsgBox(psMSJ, MsgBoxStyle.Critical, str_NOM_SISTEMA)
    End Sub

    Public Function fbConfirma(ByVal psMSJ As String) As Boolean
        If MessageBox.Show(psMSJ, str_NOM_SISTEMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            fbConfirma = True
        Else
            fbConfirma = False
        End If
        Application.DoEvents()  '// para esperar que desaparesca
    End Function

#End Region

#Region "Conversión de datos"

    Public Function fsDbDate_TxtTimeStam(ByVal poFec As Object) As String
        If TypeOf poFec Is DBNull Then
            Return ""
        Else
            Return (Format(poFec, "dd/MM/yyyy hh:mm:ss tt"))
        End If
    End Function

    Public Function fsNowString() As String
        Return Now.ToString("dd/MM/yyyy hh:mm:ss tt")
    End Function

    Public Function fnDBL(ByVal pnVAL As Object) As Double
        Dim lnDBL As Double
        Try
            lnDBL = Convert.ToDouble(pnVAL)
        Catch ex As Exception
            lnDBL = 0      '// casos: cadena vacia, DBNull
        End Try
        Return lnDBL
    End Function

    Public Function fsFecParamOracle(ByVal pdFEC As Object) As String
        Try
            fsFecParamOracle = Format(CDate(pdFEC), "yyyyMMdd")
        Catch ex As Exception
            fsFecParamOracle = ""
        End Try
    End Function

#End Region

#Region "Valida Numero"

    Public Sub Validar_Numero(ByVal e As System.Windows.Forms.KeyPressEventArgs, ByVal pText As String)
        If e.KeyChar = "" Then
            e.Handled = False
            Exit Sub
        End If
        If (Not Char.IsDigit(e.KeyChar)) And (e.KeyChar <> ".") Then
            e.Handled = True
        Else
            If e.KeyChar = "." And InStr(pText, ".") Then
                e.Handled = True
                Exit Sub
            End If
            e.Handled = False
        End If
    End Sub ' Validar_Numero

    Public Sub Validar_NumeroInt(ByVal e As System.Windows.Forms.KeyPressEventArgs, ByVal pText As String)
        If e.KeyChar = "" Then
            e.Handled = False
            Exit Sub
        End If
        If (Not Char.IsDigit(e.KeyChar)) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub  ' Validar_NumeroInt  

#End Region

#Region "Grilla"
    Public Sub EstiloGrillaInfrag(ByVal Grilla As Infragistics.Win.UltraWinGrid.UltraGrid)
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Appearance10.BackColor = System.Drawing.Color.FromArgb(192, 192, 255)
        Appearance10.BackColor2 = System.Drawing.Color.FromArgb(192, 192, 255)
        Appearance10.ForeColor = System.Drawing.Color.Black
        Appearance10.TextHAlign = Infragistics.Win.HAlign.Left

        With Grilla
            .DisplayLayout.Override.HeaderAppearance = Appearance10
            'con esto se muestra el filtro en la grilla
            .DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
            .DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True

            .DisplayLayout.Override.RowAlternateAppearance.BackColor = ObtenerColor(CType(("239,247,250"), String))
            .DisplayLayout.Override.RowAppearance.BackColor = ObtenerColor(CType(("255,255,255"), String))
            .DisplayLayout.Override.RowAlternateAppearance.ForeColor = Color.DarkBlue
            .DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True
        End With
    End Sub

    Public Function ObtenerColor(ByVal pstrBackColorRGB As String) As Color
        Dim intColorR, intcolorG, intColorB As Integer
        Dim arrColor() As String = pstrBackColorRGB.Split(CType(",", Char))
        Try
            If pstrBackColorRGB <> "" Then
                arrColor = pstrBackColorRGB.Split(CType(",", Char))
                intColorR = CType(arrColor(0), Integer)
                intcolorG = CType(arrColor(1), Integer)
                intColorB = CType(arrColor(2), Integer)
                ObtenerColor = Color.FromArgb(intColorR, intcolorG, intColorB)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.GetBaseException.ToString, "CCP", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Function

    Public Sub ConfiguraColGrilla(ByVal grdDat As Infragistics.Win.UltraWinGrid.UltraGrid,
                                 ByVal intCol As Integer,
                                 ByVal strCaption As String,
                                 ByVal intWidth As Integer,
                                 ByVal blHeaderFixed As Boolean,
                                 ByVal blHidden As Boolean,
                                 Optional ByVal blTipoChk As Boolean = False,
                                 Optional ByVal psFormato As String = "",
                                 Optional ByVal intAli As Integer = Infragistics.Win.HAlign.Left)
        With grdDat
            .DisplayLayout.Bands(0).Columns(intCol).Header.Caption = strCaption
            .DisplayLayout.Bands(0).Columns(intCol).Width = intWidth
            .DisplayLayout.Bands(0).Columns(intCol).Header.Fixed = blHeaderFixed
            .DisplayLayout.Bands(0).Columns(intCol).Hidden = blHidden
            .DisplayLayout.Bands(0).Columns(intCol).CellAppearance.TextHAlign = intAli
            If blTipoChk = True Then
                .DisplayLayout.Bands(0).Columns(intCol).Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
            End If

            ' Si envía formato lo aplica
            If psFormato.ToString.Length > 0 Then
                .DisplayLayout.Bands(0).Columns(intCol).Format = psFormato
            End If
        End With
    End Sub

#End Region

End Module
