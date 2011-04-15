Public Class GetTextDialog
    Public Shared Function DoModalDialog(ByVal parent As System.Windows.Forms.Control, ByVal title As String, ByVal label As String, ByRef s As String) As Boolean
        Dim thisobj As GetTextDialog
        Dim sdRet As System.Windows.Forms.DialogResult

        thisobj = New GetTextDialog
        thisobj.Text = title
        thisobj.label.Text = label
        thisobj.textBox.Text = s
        If Parent Is Nothing Then
            thisobj.StartPosition = Windows.Forms.FormStartPosition.CenterScreen
            thisobj.ShowInTaskbar = True
        End If

        sdRet = thisobj.ShowDialog(Parent)

        If sdRet = Windows.Forms.DialogResult.OK Then
            s = thisobj.textBox.Text
            DoModalDialog = True
        Else
            DoModalDialog = False
        End If

    End Function

    Private Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class