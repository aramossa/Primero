﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SIGC_Fer_Tab_frmEstados
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SIGC_Fer_Tab_frmEstados))
        Me.txtDes = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabDet = New System.Windows.Forms.TabPage()
        Me.chkEst = New System.Windows.Forms.CheckBox()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.grdDat = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RefrescarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrabarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UltraGridExcelExporter1 = New Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(Me.components)
        Me.tabDet.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        CType(Me.grdDat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDes
        '
        Me.txtDes.Location = New System.Drawing.Point(90, 35)
        Me.txtDes.Name = "txtDes"
        Me.txtDes.Size = New System.Drawing.Size(296, 20)
        Me.txtDes.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Código"
        '
        'tabDet
        '
        Me.tabDet.Controls.Add(Me.chkEst)
        Me.tabDet.Controls.Add(Me.txtCod)
        Me.tabDet.Controls.Add(Me.txtDes)
        Me.tabDet.Controls.Add(Me.Label2)
        Me.tabDet.Controls.Add(Me.Label1)
        Me.tabDet.Location = New System.Drawing.Point(4, 22)
        Me.tabDet.Name = "tabDet"
        Me.tabDet.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDet.Size = New System.Drawing.Size(796, 89)
        Me.tabDet.TabIndex = 0
        Me.tabDet.Text = "Detalle de Categoría"
        Me.tabDet.UseVisualStyleBackColor = True
        '
        'chkEst
        '
        Me.chkEst.AutoSize = True
        Me.chkEst.Location = New System.Drawing.Point(90, 65)
        Me.chkEst.Name = "chkEst"
        Me.chkEst.Size = New System.Drawing.Size(56, 17)
        Me.chkEst.TabIndex = 2
        Me.chkEst.Text = "Activo"
        Me.chkEst.UseVisualStyleBackColor = True
        '
        'txtCod
        '
        Me.txtCod.Location = New System.Drawing.Point(90, 9)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(48, 20)
        Me.txtCod.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Descripción"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabDet)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(804, 115)
        Me.TabControl1.TabIndex = 10
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
        Me.grdDat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdDat.Location = New System.Drawing.Point(0, 0)
        Me.grdDat.Name = "grdDat"
        Me.grdDat.Size = New System.Drawing.Size(804, 315)
        Me.grdDat.TabIndex = 9
        Me.grdDat.Text = "UltraGrid1"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.grdDat)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(804, 434)
        Me.SplitContainer1.SplitterDistance = 315
        Me.SplitContainer1.TabIndex = 11
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefrescarToolStripMenuItem, Me.AgregarToolStripMenuItem, Me.ModificarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.GrabarToolStripMenuItem, Me.CancelarToolStripMenuItem, Me.ExportarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(804, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RefrescarToolStripMenuItem
        '
        Me.RefrescarToolStripMenuItem.Image = Global.SIGC_Negocio.My.Resources.Resources.table_refresh
        Me.RefrescarToolStripMenuItem.Name = "RefrescarToolStripMenuItem"
        Me.RefrescarToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.RefrescarToolStripMenuItem.Text = "Refrescar"
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.Image = CType(resources.GetObject("AgregarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.AgregarToolStripMenuItem.Text = "&Agregar"
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Image = CType(resources.GetObject("ModificarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.ModificarToolStripMenuItem.Text = "&Modificar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = CType(resources.GetObject("EliminarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.EliminarToolStripMenuItem.Text = "&Eliminar"
        '
        'GrabarToolStripMenuItem
        '
        Me.GrabarToolStripMenuItem.Image = CType(resources.GetObject("GrabarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GrabarToolStripMenuItem.Name = "GrabarToolStripMenuItem"
        Me.GrabarToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.GrabarToolStripMenuItem.Text = "&Grabar"
        '
        'CancelarToolStripMenuItem
        '
        Me.CancelarToolStripMenuItem.Image = CType(resources.GetObject("CancelarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CancelarToolStripMenuItem.Name = "CancelarToolStripMenuItem"
        Me.CancelarToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.CancelarToolStripMenuItem.Text = "&Cancelar"
        '
        'ExportarToolStripMenuItem
        '
        Me.ExportarToolStripMenuItem.Image = Global.SIGC_Negocio.My.Resources.Resources.Exportar_Excel
        Me.ExportarToolStripMenuItem.Name = "ExportarToolStripMenuItem"
        Me.ExportarToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.ExportarToolStripMenuItem.Text = "E&xportar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = Global.SIGC_Negocio.My.Resources.Resources.salir_de_gnome_icono_7637_32
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'SIGC_Fer_Tab_frmEstados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 458)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SIGC_Fer_Tab_frmEstados"
        Me.Text = "Estados"
        Me.tabDet.ResumeLayout(False)
        Me.tabDet.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        CType(Me.grdDat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDes As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tabDet As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents grdDat As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CancelarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GrabarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents txtCod As TextBox
    Friend WithEvents chkEst As CheckBox
    Friend WithEvents UltraGridExcelExporter1 As Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter
    Friend WithEvents RefrescarToolStripMenuItem As ToolStripMenuItem
End Class