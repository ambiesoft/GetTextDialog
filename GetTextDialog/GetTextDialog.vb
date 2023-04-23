Public Class GetTextDialog
    Public Shared Function DoModalDialog(ByVal parent As System.Windows.Forms.Control,
                                         ByVal title As String,
                                         ByVal label As String,
                                         ByRef s As String) As Boolean
        Dim thisobj As GetTextDialog
        Dim sdRet As System.Windows.Forms.DialogResult

        thisobj = New GetTextDialog
        thisobj.Text = title
        thisobj.label.Text = label
        thisobj.chkMain.Visible = False
        thisobj.textBox.Text = s
        If parent Is Nothing Then
            thisobj.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            thisobj.ShowInTaskbar = True
        End If

        sdRet = thisobj.ShowDialog(parent)

        If sdRet = System.Windows.Forms.DialogResult.OK Then
            s = thisobj.textBox.Text
            DoModalDialog = True
        Else
            DoModalDialog = False
        End If

    End Function



    Public Shared Function DoModalDialogCheck(ByVal parent As System.Windows.Forms.Control,
                                              ByVal title As String,
                                              ByVal label As String,
                                              ByVal chkLabel As String,
                                              ByRef s As String,
                                              ByRef check As Boolean) As Boolean
        Dim thisobj As GetTextDialog
        Dim sdRet As System.Windows.Forms.DialogResult

        thisobj = New GetTextDialog
        thisobj.Text = title
        thisobj.label.Text = label
        thisobj.chkMain.Visible = True
        thisobj.chkMain.Text = chkLabel
        thisobj.chkMain.Checked = check
        thisobj.textBox.Text = s
        If parent Is Nothing Then
            thisobj.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            thisobj.ShowInTaskbar = True
        End If

        sdRet = thisobj.ShowDialog(parent)

        If sdRet = System.Windows.Forms.DialogResult.OK Then
            s = thisobj.textBox.Text
            check = thisobj.chkMain.Checked
            DoModalDialogCheck = True
        Else
            DoModalDialogCheck = False
        End If

    End Function



    Private Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class