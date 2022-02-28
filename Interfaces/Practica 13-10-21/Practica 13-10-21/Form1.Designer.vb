<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstructuras
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
        Me.gbDats = New System.Windows.Forms.GroupBox()
        Me.gbDia = New System.Windows.Forms.GroupBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lbNumero = New System.Windows.Forms.Label()
        Me.tbNumero = New System.Windows.Forms.TextBox()
        Me.tbDia = New System.Windows.Forms.TextBox()
        Me.lbDia = New System.Windows.Forms.Label()
        Me.gbDats.SuspendLayout()
        Me.gbDia.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbDats
        '
        Me.gbDats.Controls.Add(Me.tbNumero)
        Me.gbDats.Controls.Add(Me.lbNumero)
        Me.gbDats.Controls.Add(Me.btnSalir)
        Me.gbDats.Controls.Add(Me.btnCalcular)
        Me.gbDats.Controls.Add(Me.btnNuevo)
        Me.gbDats.Location = New System.Drawing.Point(12, 12)
        Me.gbDats.Name = "gbDats"
        Me.gbDats.Size = New System.Drawing.Size(305, 109)
        Me.gbDats.TabIndex = 0
        Me.gbDats.TabStop = False
        Me.gbDats.Text = "Ingresar Datos"
        '
        'gbDia
        '
        Me.gbDia.Controls.Add(Me.tbDia)
        Me.gbDia.Controls.Add(Me.lbDia)
        Me.gbDia.Location = New System.Drawing.Point(12, 127)
        Me.gbDia.Name = "gbDia"
        Me.gbDia.Size = New System.Drawing.Size(305, 52)
        Me.gbDia.TabIndex = 1
        Me.gbDia.TabStop = False
        Me.gbDia.Text = "Día de la semana"
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(219, 24)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 0
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(219, 53)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 1
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(219, 82)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'lbNumero
        '
        Me.lbNumero.AutoSize = True
        Me.lbNumero.Location = New System.Drawing.Point(33, 58)
        Me.lbNumero.Name = "lbNumero"
        Me.lbNumero.Size = New System.Drawing.Size(44, 13)
        Me.lbNumero.TabIndex = 4
        Me.lbNumero.Text = "Número"
        '
        'tbNumero
        '
        Me.tbNumero.Location = New System.Drawing.Point(83, 56)
        Me.tbNumero.Name = "tbNumero"
        Me.tbNumero.Size = New System.Drawing.Size(100, 20)
        Me.tbNumero.TabIndex = 2
        '
        'tbDia
        '
        Me.tbDia.Location = New System.Drawing.Point(83, 19)
        Me.tbDia.Name = "tbDia"
        Me.tbDia.Size = New System.Drawing.Size(100, 20)
        Me.tbDia.TabIndex = 5
        '
        'lbDia
        '
        Me.lbDia.AutoSize = True
        Me.lbDia.Location = New System.Drawing.Point(33, 21)
        Me.lbDia.Name = "lbDia"
        Me.lbDia.Size = New System.Drawing.Size(25, 13)
        Me.lbDia.TabIndex = 6
        Me.lbDia.Text = "Día"
        '
        'frmEstructuras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 187)
        Me.Controls.Add(Me.gbDia)
        Me.Controls.Add(Me.gbDats)
        Me.Name = "frmEstructuras"
        Me.Text = "Estructuras Selectivas"
        Me.gbDats.ResumeLayout(False)
        Me.gbDats.PerformLayout()
        Me.gbDia.ResumeLayout(False)
        Me.gbDia.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbDats As GroupBox
    Friend WithEvents tbNumero As TextBox
    Friend WithEvents lbNumero As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents gbDia As GroupBox
    Friend WithEvents tbDia As TextBox
    Friend WithEvents lbDia As Label
End Class
