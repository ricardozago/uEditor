Public Class Sobre

    Dim text As String
    Dim text2 As String


    Private Sub FecharToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecharToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub TranscreverOTextoDeTrásParaFrenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TranscreverOTextoDeTrásParaFrenteToolStripMenuItem.Click
        Dim i As Integer
        text2 = ""
        If Not Clipboard.GetText = "" Then
            i = 0
            text = Clipboard.GetText
            While i < text.Length
                text2 = text2 + text.Substring(text.Length - (i + 1), 1)
                i = i + 1
            End While
            Clipboard.SetText(text2)
        End If
    End Sub

    Private Sub TransformarTextoEmMAIÚSCULASToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransformarTextoEmMAIÚSCULASToolStripMenuItem.Click
        If Not Clipboard.GetText = "" Then
            text = Clipboard.GetText
            text = text.ToUpper()
            Clipboard.SetText(text)
        End If
    End Sub

    Private Sub TransformarTextoEmMINÚSCULASToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransformarTextoEmMINÚSCULASToolStripMenuItem.Click
        If Not Clipboard.GetText = "" Then
            text = Clipboard.GetText
            text = text.ToLower()
            Clipboard.SetText(text)
        End If
    End Sub

    Private Sub DeixarApenasPrimeiroCaractereMAIÚCULOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeixarApenasPrimeiroCaractereMAIÚCULOToolStripMenuItem.Click
        If Not Clipboard.GetText = "" Then
            text = Clipboard.GetText
            text = UCase(text.Substring(0, 1)) + LCase(text.Substring(1, text.Length - 1))
            Clipboard.SetText(text)
        End If
    End Sub

    Private Sub DimTextAsStringToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DimTextAsStringToolStripMenuItem.Click
        If Not Clipboard.GetText = "" Then
            text = Clipboard.GetText
            text2 = UCase(text.Substring(0, 1)) + LCase(text.Substring(1, text.Length - 1))
            text = text2
            Dim i As Integer
            i = 0
            While i < text.Length
                text = text2
                If text.Substring(i, 1) = " " Or text.Substring(i, 1) = vbLf Then
                    If text.Length = i + 1 Then
                        text2 = text.Substring(0, i + 1)
                    Else
                        text2 = text.Substring(0, i + 1) + UCase(text.Substring(i + 1, 1)) + LCase(text.Substring(i + 2, text.Length - (i + 2)))
                    End If
                End If
                i = i + 1
            End While
            If Not text2 = "" Then
                Clipboard.SetText(text2)
            End If
        End If
    End Sub

    Private Sub SobreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SobreToolStripMenuItem.Click
        Me.Show()
        Me.WindowState = 0
    End Sub

    Private Sub RemoverFormataçãoDoTextoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoverFormataçãoDoTextoToolStripMenuItem.Click, µEditor.Click
        If Not Clipboard.GetText = "" Then
            text = Clipboard.GetText
            Clipboard.SetText(text)
        End If
    End Sub

    Private Sub Sobre_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Shell("explorer http://ricardoz.blogspot.com", vbNormalFocus)
    End Sub


    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If Not Clipboard.GetText = "" Then
            MsgBox(Clipboard.GetText)
        End If
    End Sub

    Private Sub SalvaComoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalvaComoToolStripMenuItem.Click
        Dim salvarComo As SaveFileDialog = New SaveFileDialog()
        Dim caminho As DialogResult
        Dim texto As IO.StreamWriter
        Dim file As String

        salvarComo.Title = "Salvar Área de Transferência como:"
        salvarComo.DefaultExt = "txt"
        salvarComo.Filter = "Arquivos de texto (.txt)|*.txt|Todos os arquivos (*.*)|*.*"
        salvarComo.FilterIndex = 1

        caminho = salvarComo.ShowDialog
        file = salvarComo.FileName

        If file <> Nothing Then
            texto = New IO.StreamWriter(file)
            texto.Write(Clipboard.GetText)
            texto.Close()
        End If
    End Sub

    Private Sub EditarTextoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarTextoToolStripMenuItem.Click
        Editor.Show()
    End Sub

    Private Sub LimparÁreaDeTransferênciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimparÁreaDeTransferênciaToolStripMenuItem.Click
        Clipboard.Clear()
    End Sub
End Class
