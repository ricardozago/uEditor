<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sobre
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sobre))
        Me.µEditor = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MaiúsculasEMinúsculasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransformarTextoEmMAIÚSCULASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransformarTextoEmMINÚSCULASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeixarApenasPrimeiroCaractereMAIÚCULOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DimTextAsStringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TranscreverOTextoDeTrásParaFrenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoverFormataçãoDoTextoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalvaComoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FecharToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EditarTextoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimparÁreaDeTransferênciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'µEditor
        '
        Me.µEditor.ContextMenuStrip = Me.ContextMenuStrip1
        Me.µEditor.Icon = CType(resources.GetObject("µEditor.Icon"), System.Drawing.Icon)
        Me.µEditor.Text = "µEditor"
        Me.µEditor.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MaiúsculasEMinúsculasToolStripMenuItem, Me.TranscreverOTextoDeTrásParaFrenteToolStripMenuItem, Me.RemoverFormataçãoDoTextoToolStripMenuItem, Me.ToolStripMenuItem1, Me.EditarTextoToolStripMenuItem, Me.SalvaComoToolStripMenuItem, Me.LimparÁreaDeTransferênciaToolStripMenuItem, Me.SobreToolStripMenuItem, Me.FecharToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(273, 224)
        '
        'MaiúsculasEMinúsculasToolStripMenuItem
        '
        Me.MaiúsculasEMinúsculasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransformarTextoEmMAIÚSCULASToolStripMenuItem, Me.TransformarTextoEmMINÚSCULASToolStripMenuItem, Me.DeixarApenasPrimeiroCaractereMAIÚCULOToolStripMenuItem, Me.DimTextAsStringToolStripMenuItem})
        Me.MaiúsculasEMinúsculasToolStripMenuItem.Name = "MaiúsculasEMinúsculasToolStripMenuItem"
        Me.MaiúsculasEMinúsculasToolStripMenuItem.Size = New System.Drawing.Size(272, 22)
        Me.MaiúsculasEMinúsculasToolStripMenuItem.Text = "MAIÚSCULAS e minúsculas"
        '
        'TransformarTextoEmMAIÚSCULASToolStripMenuItem
        '
        Me.TransformarTextoEmMAIÚSCULASToolStripMenuItem.Name = "TransformarTextoEmMAIÚSCULASToolStripMenuItem"
        Me.TransformarTextoEmMAIÚSCULASToolStripMenuItem.Size = New System.Drawing.Size(386, 22)
        Me.TransformarTextoEmMAIÚSCULASToolStripMenuItem.Text = "TRANSFORMAR TEXTO EM MAIÚSCULAS"
        '
        'TransformarTextoEmMINÚSCULASToolStripMenuItem
        '
        Me.TransformarTextoEmMINÚSCULASToolStripMenuItem.Name = "TransformarTextoEmMINÚSCULASToolStripMenuItem"
        Me.TransformarTextoEmMINÚSCULASToolStripMenuItem.Size = New System.Drawing.Size(386, 22)
        Me.TransformarTextoEmMINÚSCULASToolStripMenuItem.Text = "transformar texto em minúsculas"
        '
        'DeixarApenasPrimeiroCaractereMAIÚCULOToolStripMenuItem
        '
        Me.DeixarApenasPrimeiroCaractereMAIÚCULOToolStripMenuItem.Name = "DeixarApenasPrimeiroCaractereMAIÚCULOToolStripMenuItem"
        Me.DeixarApenasPrimeiroCaractereMAIÚCULOToolStripMenuItem.Size = New System.Drawing.Size(386, 22)
        Me.DeixarApenasPrimeiroCaractereMAIÚCULOToolStripMenuItem.Text = "Deixar apenas primeiro caractere maiúsculo"
        '
        'DimTextAsStringToolStripMenuItem
        '
        Me.DimTextAsStringToolStripMenuItem.Name = "DimTextAsStringToolStripMenuItem"
        Me.DimTextAsStringToolStripMenuItem.Size = New System.Drawing.Size(386, 22)
        Me.DimTextAsStringToolStripMenuItem.Text = "Deixar O Primeiro Caractere De Todas As Palavras Maiúculo"
        '
        'TranscreverOTextoDeTrásParaFrenteToolStripMenuItem
        '
        Me.TranscreverOTextoDeTrásParaFrenteToolStripMenuItem.Name = "TranscreverOTextoDeTrásParaFrenteToolStripMenuItem"
        Me.TranscreverOTextoDeTrásParaFrenteToolStripMenuItem.Size = New System.Drawing.Size(272, 22)
        Me.TranscreverOTextoDeTrásParaFrenteToolStripMenuItem.Text = "Transcrever o texto de trás para frente"
        '
        'RemoverFormataçãoDoTextoToolStripMenuItem
        '
        Me.RemoverFormataçãoDoTextoToolStripMenuItem.Name = "RemoverFormataçãoDoTextoToolStripMenuItem"
        Me.RemoverFormataçãoDoTextoToolStripMenuItem.Size = New System.Drawing.Size(272, 22)
        Me.RemoverFormataçãoDoTextoToolStripMenuItem.Text = "Remover formatação do texto"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(272, 22)
        Me.ToolStripMenuItem1.Text = "Ver texto na área de transfêrencia"
        '
        'SalvaComoToolStripMenuItem
        '
        Me.SalvaComoToolStripMenuItem.Name = "SalvaComoToolStripMenuItem"
        Me.SalvaComoToolStripMenuItem.Size = New System.Drawing.Size(272, 22)
        Me.SalvaComoToolStripMenuItem.Text = "Salva como..."
        '
        'SobreToolStripMenuItem
        '
        Me.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem"
        Me.SobreToolStripMenuItem.Size = New System.Drawing.Size(272, 22)
        Me.SobreToolStripMenuItem.Text = "Sobre"
        '
        'FecharToolStripMenuItem
        '
        Me.FecharToolStripMenuItem.Name = "FecharToolStripMenuItem"
        Me.FecharToolStripMenuItem.Size = New System.Drawing.Size(272, 22)
        Me.FecharToolStripMenuItem.Text = "Fechar"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.Location = New System.Drawing.Point(123, 149)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(141, 16)
        Me.LinkLabel1.TabIndex = 1
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "ricardoz.blogspot.com"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 142)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 30)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.Menu
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 40)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(260, 96)
        Me.RichTextBox1.TabIndex = 4
        Me.RichTextBox1.Text = "Este programa foi desenvolvido usando o Microsoft Visual Basic 2013 Express, perm" & _
    "ite as edições mais simples e comuns em textos que estão na área de transferênci" & _
    "a."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(87, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "µEditor 0.3"
        '
        'EditarTextoToolStripMenuItem
        '
        Me.EditarTextoToolStripMenuItem.Name = "EditarTextoToolStripMenuItem"
        Me.EditarTextoToolStripMenuItem.Size = New System.Drawing.Size(272, 22)
        Me.EditarTextoToolStripMenuItem.Text = "Editar texto"
        '
        'LimparÁreaDeTransferênciaToolStripMenuItem
        '
        Me.LimparÁreaDeTransferênciaToolStripMenuItem.Name = "LimparÁreaDeTransferênciaToolStripMenuItem"
        Me.LimparÁreaDeTransferênciaToolStripMenuItem.Size = New System.Drawing.Size(272, 22)
        Me.LimparÁreaDeTransferênciaToolStripMenuItem.Text = "Limpar área de transferência"
        '
        'Sobre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 184)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Sobre"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents µEditor As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents FecharToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TranscreverOTextoDeTrásParaFrenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaiúsculasEMinúsculasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransformarTextoEmMAIÚSCULASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransformarTextoEmMINÚSCULASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeixarApenasPrimeiroCaractereMAIÚCULOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DimTextAsStringToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SobreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoverFormataçãoDoTextoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalvaComoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarTextoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LimparÁreaDeTransferênciaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
