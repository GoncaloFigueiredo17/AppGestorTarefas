<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        MenuStrip1 = New MenuStrip()
        VerTarefasToolStripMenuItem = New ToolStripMenuItem()
        Label3 = New Label()
        TituloBox = New TextBox()
        DescricaoBox = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Button1 = New Button()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(332, 15)
        Label2.TabIndex = 1
        Label2.Text = "Cria as tuas tarefas, e organiza os teus dias da melhor maneira"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = SystemColors.ButtonHighlight
        MenuStrip1.Dock = DockStyle.None
        MenuStrip1.GripStyle = ToolStripGripStyle.Visible
        MenuStrip1.Items.AddRange(New ToolStripItem() {VerTarefasToolStripMenuItem})
        MenuStrip1.Location = New Point(474, 9)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.RenderMode = ToolStripRenderMode.Professional
        MenuStrip1.Size = New Size(206, 24)
        MenuStrip1.Stretch = False
        MenuStrip1.TabIndex = 2
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' VerTarefasToolStripMenuItem
        ' 
        VerTarefasToolStripMenuItem.Name = "VerTarefasToolStripMenuItem"
        VerTarefasToolStripMenuItem.Size = New Size(74, 20)
        VerTarefasToolStripMenuItem.Text = "Ver Tarefas"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(376, 170)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 15)
        Label3.TabIndex = 3
        ' 
        ' TituloBox
        ' 
        TituloBox.Location = New Point(182, 162)
        TituloBox.Name = "TituloBox"
        TituloBox.Size = New Size(197, 23)
        TituloBox.TabIndex = 4
        ' 
        ' DescricaoBox
        ' 
        DescricaoBox.Location = New Point(182, 211)
        DescricaoBox.Name = "DescricaoBox"
        DescricaoBox.Size = New Size(197, 23)
        DescricaoBox.TabIndex = 5
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(182, 255)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(197, 23)
        DateTimePicker1.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(182, 144)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 15)
        Label4.TabIndex = 7
        Label4.Text = "Titulo da Tarefa"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(182, 193)
        Label5.Name = "Label5"
        Label5.Size = New Size(58, 15)
        Label5.TabIndex = 8
        Label5.Text = "Descrição"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(182, 240)
        Label6.Name = "Label6"
        Label6.Size = New Size(67, 15)
        Label6.TabIndex = 9
        Label6.Text = "Data Limite"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Button1.Cursor = Cursors.Hand
        Button1.Location = New Point(244, 294)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 10
        Button1.Text = "Criar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Inicio
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(574, 562)
        Controls.Add(Button1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(DateTimePicker1)
        Controls.Add(DescricaoBox)
        Controls.Add(TituloBox)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Inicio"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Inicio"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents VerTarefasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents TituloBox As TextBox
    Friend WithEvents DescricaoBox As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
End Class
