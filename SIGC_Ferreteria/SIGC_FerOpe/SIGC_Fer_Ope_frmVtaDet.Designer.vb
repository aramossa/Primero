<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SIGC_Fer_Ope_frmVtaDet
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.grpCli = New System.Windows.Forms.GroupBox()
        Me.cmdClte = New System.Windows.Forms.Button()
        Me.txtDesClte = New System.Windows.Forms.TextBox()
        Me.txtCodClte = New System.Windows.Forms.TextBox()
        Me.grpArt = New System.Windows.Forms.GroupBox()
        Me.txtUni = New System.Windows.Forms.TextBox()
        Me.txtCat = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtCodProd = New System.Windows.Forms.TextBox()
        Me.txtCan = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtStk = New System.Windows.Forms.TextBox()
        Me.txtPre = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDesProd = New System.Windows.Forms.TextBox()
        Me.grdDat = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.cmdDel = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.txtTot = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpCli.SuspendLayout()
        Me.grpArt.SuspendLayout()
        CType(Me.grdDat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpCli
        '
        Me.grpCli.Controls.Add(Me.cmdClte)
        Me.grpCli.Controls.Add(Me.txtDesClte)
        Me.grpCli.Controls.Add(Me.txtCodClte)
        Me.grpCli.Location = New System.Drawing.Point(13, 12)
        Me.grpCli.Name = "grpCli"
        Me.grpCli.Size = New System.Drawing.Size(588, 53)
        Me.grpCli.TabIndex = 0
        Me.grpCli.TabStop = False
        Me.grpCli.Text = " Cliente "
        '
        'cmdClte
        '
        Me.cmdClte.Location = New System.Drawing.Point(552, 17)
        Me.cmdClte.Name = "cmdClte"
        Me.cmdClte.Size = New System.Drawing.Size(26, 22)
        Me.cmdClte.TabIndex = 2
        Me.cmdClte.Text = "..."
        Me.cmdClte.UseVisualStyleBackColor = True
        '
        'txtDesClte
        '
        Me.txtDesClte.Location = New System.Drawing.Point(87, 19)
        Me.txtDesClte.Name = "txtDesClte"
        Me.txtDesClte.Size = New System.Drawing.Size(459, 20)
        Me.txtDesClte.TabIndex = 1
        '
        'txtCodClte
        '
        Me.txtCodClte.Location = New System.Drawing.Point(11, 19)
        Me.txtCodClte.Name = "txtCodClte"
        Me.txtCodClte.Size = New System.Drawing.Size(70, 20)
        Me.txtCodClte.TabIndex = 0
        '
        'grpArt
        '
        Me.grpArt.Controls.Add(Me.txtUni)
        Me.grpArt.Controls.Add(Me.txtCat)
        Me.grpArt.Controls.Add(Me.Button1)
        Me.grpArt.Controls.Add(Me.txtCodProd)
        Me.grpArt.Controls.Add(Me.txtCan)
        Me.grpArt.Controls.Add(Me.Label7)
        Me.grpArt.Controls.Add(Me.txtStk)
        Me.grpArt.Controls.Add(Me.txtPre)
        Me.grpArt.Controls.Add(Me.Label12)
        Me.grpArt.Controls.Add(Me.Label5)
        Me.grpArt.Controls.Add(Me.Label6)
        Me.grpArt.Controls.Add(Me.Label4)
        Me.grpArt.Controls.Add(Me.txtDesProd)
        Me.grpArt.Location = New System.Drawing.Point(13, 71)
        Me.grpArt.Name = "grpArt"
        Me.grpArt.Size = New System.Drawing.Size(588, 135)
        Me.grpArt.TabIndex = 1
        Me.grpArt.TabStop = False
        Me.grpArt.Text = " Producto"
        '
        'txtUni
        '
        Me.txtUni.Location = New System.Drawing.Point(87, 74)
        Me.txtUni.Name = "txtUni"
        Me.txtUni.Size = New System.Drawing.Size(100, 20)
        Me.txtUni.TabIndex = 7
        '
        'txtCat
        '
        Me.txtCat.Location = New System.Drawing.Point(87, 46)
        Me.txtCat.Name = "txtCat"
        Me.txtCat.Size = New System.Drawing.Size(361, 20)
        Me.txtCat.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(552, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(26, 22)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtCodProd
        '
        Me.txtCodProd.Location = New System.Drawing.Point(11, 19)
        Me.txtCodProd.Name = "txtCodProd"
        Me.txtCodProd.Size = New System.Drawing.Size(70, 20)
        Me.txtCodProd.TabIndex = 3
        '
        'txtCan
        '
        Me.txtCan.Location = New System.Drawing.Point(262, 100)
        Me.txtCan.Name = "txtCan"
        Me.txtCan.Size = New System.Drawing.Size(100, 20)
        Me.txtCan.TabIndex = 10
        Me.txtCan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(198, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Cantidad"
        '
        'txtStk
        '
        Me.txtStk.Location = New System.Drawing.Point(262, 74)
        Me.txtStk.Name = "txtStk"
        Me.txtStk.Size = New System.Drawing.Size(100, 20)
        Me.txtStk.TabIndex = 8
        Me.txtStk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPre
        '
        Me.txtPre.Location = New System.Drawing.Point(87, 100)
        Me.txtPre.Name = "txtPre"
        Me.txtPre.Size = New System.Drawing.Size(100, 20)
        Me.txtPre.TabIndex = 9
        Me.txtPre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(20, 49)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 13)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Categoria"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(216, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Stock"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(38, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Unidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Precio"
        '
        'txtDesProd
        '
        Me.txtDesProd.Location = New System.Drawing.Point(87, 19)
        Me.txtDesProd.Name = "txtDesProd"
        Me.txtDesProd.Size = New System.Drawing.Size(459, 20)
        Me.txtDesProd.TabIndex = 4
        '
        'grdDat
        '
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.grdDat.DisplayLayout.Appearance = Appearance1
        Me.grdDat.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grdDat.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.grdDat.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdDat.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.grdDat.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdDat.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.grdDat.DisplayLayout.MaxColScrollRegions = 1
        Me.grdDat.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grdDat.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Highlight
        Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.grdDat.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.grdDat.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.grdDat.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Me.grdDat.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.grdDat.DisplayLayout.Override.CellAppearance = Appearance8
        Me.grdDat.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.grdDat.DisplayLayout.Override.CellPadding = 0
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.grdDat.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance10.TextHAlignAsString = "Left"
        Me.grdDat.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.grdDat.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grdDat.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Appearance11.BorderColor = System.Drawing.Color.Silver
        Me.grdDat.DisplayLayout.Override.RowAppearance = Appearance11
        Me.grdDat.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grdDat.DisplayLayout.Override.TemplateAddRowAppearance = Appearance12
        Me.grdDat.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grdDat.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grdDat.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.grdDat.Location = New System.Drawing.Point(13, 229)
        Me.grdDat.Name = "grdDat"
        Me.grdDat.Size = New System.Drawing.Size(502, 163)
        Me.grdDat.TabIndex = 2
        Me.grdDat.Text = "UltraGrid1"
        '
        'cmdDel
        '
        Me.cmdDel.Image = Global.SIGC_Negocio.My.Resources.Resources.delete1
        Me.cmdDel.Location = New System.Drawing.Point(41, 205)
        Me.cmdDel.Name = "cmdDel"
        Me.cmdDel.Size = New System.Drawing.Size(29, 24)
        Me.cmdDel.TabIndex = 16
        Me.cmdDel.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Image = Global.SIGC_Negocio.My.Resources.Resources.add
        Me.cmdAdd.Location = New System.Drawing.Point(13, 205)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(29, 24)
        Me.cmdAdd.TabIndex = 15
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Image = Global.SIGC_Negocio.My.Resources.Resources._exit
        Me.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdSalir.Location = New System.Drawing.Point(521, 352)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(80, 40)
        Me.cmdSalir.TabIndex = 14
        Me.cmdSalir.Text = "&Salir"
        Me.cmdSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Image = Global.SIGC_Negocio.My.Resources.Resources.save
        Me.cmdGrabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdGrabar.Location = New System.Drawing.Point(521, 306)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(80, 40)
        Me.cmdGrabar.TabIndex = 13
        Me.cmdGrabar.Text = "&Grabar"
        Me.cmdGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'txtTot
        '
        Me.txtTot.Location = New System.Drawing.Point(415, 398)
        Me.txtTot.Name = "txtTot"
        Me.txtTot.Size = New System.Drawing.Size(100, 20)
        Me.txtTot.TabIndex = 41
        Me.txtTot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(373, 401)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Total"
        '
        'SIGC_Fer_Ope_frmVtaDet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 418)
        Me.Controls.Add(Me.txtTot)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdDel)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.grdDat)
        Me.Controls.Add(Me.grpArt)
        Me.Controls.Add(Me.grpCli)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "SIGC_Fer_Ope_frmVtaDet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        Me.grpCli.ResumeLayout(False)
        Me.grpCli.PerformLayout()
        Me.grpArt.ResumeLayout(False)
        Me.grpArt.PerformLayout()
        CType(Me.grdDat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpCli As GroupBox
    Friend WithEvents grpArt As GroupBox
    Friend WithEvents grdDat As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents cmdSalir As Button
    Friend WithEvents cmdGrabar As Button
    Friend WithEvents cmdDel As Button
    Friend WithEvents cmdAdd As Button
    Friend WithEvents txtDesClte As TextBox
    Friend WithEvents txtCodClte As TextBox
    Friend WithEvents txtCan As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtStk As TextBox
    Friend WithEvents txtPre As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDesProd As TextBox
    Friend WithEvents cmdClte As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtCodProd As TextBox
    Friend WithEvents txtUni As TextBox
    Friend WithEvents txtCat As TextBox
    Friend WithEvents txtTot As TextBox
    Friend WithEvents Label1 As Label
End Class
