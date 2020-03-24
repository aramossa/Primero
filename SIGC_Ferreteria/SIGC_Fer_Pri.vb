Public Class SIGC_Fer_Pri
    Private Sub utMant_ToolClick(sender As Object, e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles utMant.ToolClick
        Select Case e.Tool.Key
            Case "Clientes"
                Dim key As String = "Clte"
                ' Valida si el formulario ya se encuentra abierto
                If Me.tabOpc.TabPages(key) Is Nothing Then
                    Dim f As New SIGC_Fer_Cat_frmClte
                    f.Text = "Clientes" '
                    'Crea el tab que lo contiene
                    Me.tabOpc.TabPages.Add(key, f.Text)
                    f.TopLevel = False
                    f.FormBorderStyle = BorderStyle.None
                    f.Dock = DockStyle.Fill
                    Me.tabOpc.TabPages(key).Controls.Add(f)
                    Me.tabOpc.SelectedTab = Me.tabOpc.TabPages(key)
                    'Asigna el nuevo form al tag del tabpage
                    Me.tabOpc.TabPages(key).Tag = f
                    'Por si desde el propio form quieres cerrar y eliminar el tab
                    f.Tag = Me.tabOpc.TabPages(key)
                    f.Show()
                Else
                    Me.tabOpc.SelectedTab = Me.tabOpc.TabPages(key)
                End If
            Case "Artículos"
                Dim key As String = "Art"
                ' Valida si el formulario ya se encuentra abierto
                If Me.tabOpc.TabPages(key) Is Nothing Then
                    Dim f As New SIGC_Fer_Cat_frmProd
                    f.Text = "Artículos" '
                    'Crea el tab que lo contiene
                    Me.tabOpc.TabPages.Add(key, f.Text)
                    f.TopLevel = False
                    f.FormBorderStyle = BorderStyle.None
                    f.Dock = DockStyle.Fill
                    Me.tabOpc.TabPages(key).Controls.Add(f)
                    Me.tabOpc.SelectedTab = Me.tabOpc.TabPages(key)
                    'Asigna el nuevo form al tag del tabpage
                    Me.tabOpc.TabPages(key).Tag = f
                    'Por si desde el propio form quieres cerrar y eliminar el tab
                    f.Tag = Me.tabOpc.TabPages(key)
                    f.Show()
                Else
                    Me.tabOpc.SelectedTab = Me.tabOpc.TabPages(key)
                End If
            Case "Marcas"
                Dim key As String = "Mar"
                ' Valida si el formulario ya se encuentra abierto
                If Me.tabOpc.TabPages(key) Is Nothing Then
                    Dim f As New SIGC_Fer_Tab_frmMarca
                    f.Text = "Marcas" '
                    'Crea el tab que lo contiene
                    Me.tabOpc.TabPages.Add(key, f.Text)
                    f.TopLevel = False
                    f.FormBorderStyle = BorderStyle.None
                    f.Dock = DockStyle.Fill
                    Me.tabOpc.TabPages(key).Controls.Add(f)
                    Me.tabOpc.SelectedTab = Me.tabOpc.TabPages(key)
                    'Asigna el nuevo form al tag del tabpage
                    Me.tabOpc.TabPages(key).Tag = f
                    'Por si desde el propio form quieres cerrar y eliminar el tab
                    f.Tag = Me.tabOpc.TabPages(key)
                    f.Show()
                Else
                    Me.tabOpc.SelectedTab = Me.tabOpc.TabPages(key)
                End If
            Case "Proveedores"
                Dim key As String = "Prov"
                ' Valida si el formulario ya se encuentra abierto
                If Me.tabOpc.TabPages(key) Is Nothing Then
                    Dim f As New SIGC_Fer_Cat_frmProv
                    f.Text = "Proveedor" '
                    'Crea el tab que lo contiene
                    Me.tabOpc.TabPages.Add(key, f.Text)
                    f.TopLevel = False
                    f.FormBorderStyle = BorderStyle.None
                    f.Dock = DockStyle.Fill
                    Me.tabOpc.TabPages(key).Controls.Add(f)
                    Me.tabOpc.SelectedTab = Me.tabOpc.TabPages(key)
                    'Asigna el nuevo form al tag del tabpage
                    Me.tabOpc.TabPages(key).Tag = f
                    'Por si desde el propio form quieres cerrar y eliminar el tab
                    f.Tag = Me.tabOpc.TabPages(key)
                    f.Show()
                Else
                    Me.tabOpc.SelectedTab = Me.tabOpc.TabPages(key)
                End If
            Case "Categoria"
                Dim key As String = "Categ"
                ' Valida si el formulario ya se encuentra abierto
                If Me.tabOpc.TabPages(key) Is Nothing Then
                    Dim f As New SIGC_Fer_Tab_frmCateg
                    f.Text = "Categoría" '
                    'Crea el tab que lo contiene
                    Me.tabOpc.TabPages.Add(key, f.Text)
                    f.TopLevel = False
                    f.FormBorderStyle = BorderStyle.None
                    f.Dock = DockStyle.Fill
                    Me.tabOpc.TabPages(key).Controls.Add(f)
                    Me.tabOpc.SelectedTab = Me.tabOpc.TabPages(key)
                    'Asigna el nuevo form al tag del tabpage
                    Me.tabOpc.TabPages(key).Tag = f
                    'Por si desde el propio form quieres cerrar y eliminar el tab
                    f.Tag = Me.tabOpc.TabPages(key)
                    f.Show()
                Else
                    Me.tabOpc.SelectedTab = Me.tabOpc.TabPages(key)
                End If
            Case "Estados"
                Dim key As String = "Estados"
                ' Valida si el formulario ya se encuentra abierto
                If Me.tabOpc.TabPages(key) Is Nothing Then
                    Dim f As New SIGC_Fer_Tab_frmEstados
                    f.Text = "Estados" '
                    'Crea el tab que lo contiene
                    Me.tabOpc.TabPages.Add(key, f.Text)
                    f.TopLevel = False
                    f.FormBorderStyle = BorderStyle.None
                    f.Dock = DockStyle.Fill
                    Me.tabOpc.TabPages(key).Controls.Add(f)
                    Me.tabOpc.SelectedTab = Me.tabOpc.TabPages(key)
                    'Asigna el nuevo form al tag del tabpage
                    Me.tabOpc.TabPages(key).Tag = f
                    'Por si desde el propio form quieres cerrar y eliminar el tab
                    f.Tag = Me.tabOpc.TabPages(key)
                    f.Show()
                Else
                    Me.tabOpc.SelectedTab = Me.tabOpc.TabPages(key)
                End If
            Case "Unidad de Medida"
                Dim key As String = "UniMed"
                ' Valida si el formulario ya se encuentra abierto
                If Me.tabOpc.TabPages(key) Is Nothing Then
                    Dim f As New SIGC_Fer_Tab_frmUniMed
                    f.Text = "Unidad de Medida" '
                    'Crea el tab que lo contiene
                    Me.tabOpc.TabPages.Add(key, f.Text)
                    f.TopLevel = False
                    f.FormBorderStyle = BorderStyle.None
                    f.Dock = DockStyle.Fill
                    Me.tabOpc.TabPages(key).Controls.Add(f)
                    Me.tabOpc.SelectedTab = Me.tabOpc.TabPages(key)
                    'Asigna el nuevo form al tag del tabpage
                    Me.tabOpc.TabPages(key).Tag = f
                    'Por si desde el propio form quieres cerrar y eliminar el tab
                    f.Tag = Me.tabOpc.TabPages(key)
                    f.Show()
                Else
                    Me.tabOpc.SelectedTab = Me.tabOpc.TabPages(key)
                End If
            Case "Ventas"
                Dim key As String = "Ventas"
                ' Valida si el formulario ya se encuentra abierto
                If Me.tabOpc.TabPages(key) Is Nothing Then
                    Dim f As New SIGC_Fer_Ope_frmVtaCab
                    f.Text = "Ventas" '
                    'Crea el tab que lo contiene
                    Me.tabOpc.TabPages.Add(key, f.Text)
                    f.TopLevel = False
                    f.FormBorderStyle = BorderStyle.None
                    f.Dock = DockStyle.Fill
                    Me.tabOpc.TabPages(key).Controls.Add(f)
                    Me.tabOpc.SelectedTab = Me.tabOpc.TabPages(key)
                    'Asigna el nuevo form al tag del tabpage
                    Me.tabOpc.TabPages(key).Tag = f
                    'Por si desde el propio form quieres cerrar y eliminar el tab
                    f.Tag = Me.tabOpc.TabPages(key)
                    f.Show()
                Else
                    Me.tabOpc.SelectedTab = Me.tabOpc.TabPages(key)
                End If
            Case "Salir"
                If MessageBox.Show("Está seguro de Salir de la Aplicación", "SIGC", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                    Application.Exit()
                End If
        End Select
    End Sub
End Class
