Imports System.Configuration.ConfigurationSettings
Public Class SIGC_Fer_Login
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Application.Exit()
    End Sub
    Private Sub conFoco(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, TextBox).BackColor = Color.LightGoldenrodYellow
    End Sub

    Private Sub sinFoco(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, TextBox).BackColor = Color.White
    End Sub

    Private Sub BtnIniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIniciar.Click

        'If TxtUsuario.Text.Trim = String.Empty Or TxtPassword.Text.Trim = String.Empty Then
        '      MessageBox.Show("Para ingresar es necesario completar los datos del Usuario y la Contraseña.", "SIGC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '   TxtUsuario.Focus()
        '   Me.DialogResult = DialogResult.None
        '   Exit Sub
        'End If
        Dim DS As New DataSet
        Dim User As String = TxtUsuario.Text.Trim.ToUpper
        '//Validador de usuarios
        GS_USUARIO = User
        Me.Cursor = Cursors.WaitCursor

        'GS_SEG_COD_EMPR = System.Configuration.ConfigurationManager.AppSettings("COD_EMPR_SEGUR")
        'GS_SEG_COD_SIST = System.Configuration.ConfigurationManager.AppSettings("COD_SISTEMA")
        'GS_SEG_COD_MOD = System.Configuration.ConfigurationManager.AppSettings("COD_MODULO")

        'Dim Msg As String
        If False Then 'Not fbSPG_VAL_USUARIO(GS_SEG_COD_EMPR, GS_SEG_COD_SIST, GS_SEG_COD_MOD, User, TxtPassword.Text.Trim, Msg) Then
            'AvisoError(Msg)
            TxtUsuario.Focus()
            Me.DialogResult = DialogResult.None
            Me.Cursor = Cursors.Default
            Exit Sub
        Else
            GS_USUARIO = User
            Dim f As New SIGC_Fer_Pri
            'f.ToolStripStatusLabel2.Text = User
            f.Show()
            Me.Hide()
            Me.Cursor = Cursors.Default
        End If
    End Sub

#Region "   Controls Handles"

#End Region

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Llena Tipo
        rLlenarCombos(cmbEmpr)

        For Each c As Object In Me.Controls
            If c.GetType Is GetType(TextBox) Then
                AddHandler DirectCast(c, TextBox).GotFocus, AddressOf conFoco
                AddHandler DirectCast(c, TextBox).LostFocus, AddressOf sinFoco
            End If
        Next
        TxtUsuario.Text = System.Environment.UserName.ToUpper()
        TxtPassword.Focus()
        'Me.lblServidor.Text = Me.NombreServidorBaseDatos
        'GS_NOM_BD = Me.lblServidor.Text


    End Sub
    Private Function NombreServidorBaseDatos() As String
        'Dim BL As New bf BL_CCP.Mantenimiento.Util
        Return "Santa Anita" 'BL.NombreServidorBaseDatos()
    End Function

    Private Sub TxtUsuario_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        TxtUsuario.TabIndex = 0
        TxtPassword.TabIndex = 1
    End Sub

    Private Sub TxtUsuario_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        TxtUsuario.Text = TxtUsuario.Text.ToUpper
    End Sub
    Private Sub TxtPassword_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        TxtUsuario.TabIndex = 1
        TxtPassword.TabIndex = 0
    End Sub

#Region "Combos"
    Sub rLlenarCombos(ByVal oCmb As ComboBox)
        Me.Cursor = Cursors.WaitCursor
        Dim BL As New SIGC_FerBL.Mantenimiento.BL_Tablas
        Dim dt As New DataTable
        dt = BL.fListarTablaEmpr("L")
        BL = Nothing
        oCmb.DataSource = dt
        oCmb.DisplayMember = "descripcion"
        oCmb.ValueMember = "codigo"
        GS_EMP_ID = oCmb.SelectedValue
        Me.Cursor = Cursors.Default
    End Sub
#End Region

End Class
