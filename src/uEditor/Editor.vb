Public Class Editor

    Private Sub Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Clipboard.GetText = "" Then
            RichTextBox1.Text = Clipboard.GetText
        Else
            RichTextBox1.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not RichTextBox1.Text = "" Then
            Clipboard.SetText(RichTextBox1.Text)
        Else
            Clipboard.Clear()
        End If
        Close()
    End Sub
End Class