<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculadora
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
        Me.gbSuperior = New System.Windows.Forms.GroupBox()
        Me.tbNumero3 = New System.Windows.Forms.TextBox()
        Me.lblNumero3 = New System.Windows.Forms.Label()
        Me.tbNumero2 = New System.Windows.Forms.TextBox()
        Me.lblNumero2 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.tbNumero1 = New System.Windows.Forms.TextBox()
        Me.lblNumero1 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.gbInferior = New System.Windows.Forms.GroupBox()
        Me.tbSituacion = New System.Windows.Forms.TextBox()
        Me.tbPromedio = New System.Windows.Forms.TextBox()
        Me.lblSituacion = New System.Windows.Forms.Label()
        Me.lblPromedio = New System.Windows.Forms.Label()
        Me.gbSuperior.SuspendLayout()
        Me.gbInferior.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbSuperior
        '
        Me.gbSuperior.Controls.Add(Me.tbNumero3)
        Me.gbSuperior.Controls.Add(Me.lblNumero3)
        Me.gbSuperior.Controls.Add(Me.tbNumero2)
        Me.gbSuperior.Controls.Add(Me.lblNumero2)
        Me.gbSuperior.Controls.Add(Me.btnSalir)
        Me.gbSuperior.Controls.Add(Me.btnCalcular)
        Me.gbSuperior.Controls.Add(Me.btnNuevo)
        Me.gbSuperior.Controls.Add(Me.tbNumero1)
        Me.gbSuperior.Controls.Add(Me.lblNumero1)
        Me.gbSuperior.Location = New System.Drawing.Point(12, 12)
        Me.gbSuperior.Name = "gbSuperior"
        Me.gbSuperior.Size = New System.Drawing.Size(481, 221)
        Me.gbSuperior.TabIndex = 0
        Me.gbSuperior.TabStop = False
        Me.gbSuperior.Text = "Ingresar Datos"
        '
        'tbNumero3
        '
        Me.tbNumero3.Location = New System.Drawing.Point(157, 115)
        Me.tbNumero3.Name = "tbNumero3"
        Me.tbNumero3.Size = New System.Drawing.Size(194, 20)
        Me.tbNumero3.TabIndex = 8
        '
        'lblNumero3
        '
        Me.lblNumero3.AutoSize = True
        Me.lblNumero3.Location = New System.Drawing.Point(41, 118)
        Me.lblNumero3.Name = "lblNumero3"
        Me.lblNumero3.Size = New System.Drawing.Size(110, 13)
        Me.lblNumero3.TabIndex = 7
        Me.lblNumero3.Text = "Nota Tres (2 Créditos)"
        Me.lblNumero3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbNumero2
        '
        Me.tbNumero2.Location = New System.Drawing.Point(157, 88)
        Me.tbNumero2.Name = "tbNumero2"
        Me.tbNumero2.Size = New System.Drawing.Size(194, 20)
        Me.tbNumero2.TabIndex = 6
        '
        'lblNumero2
        '
        Me.lblNumero2.AutoSize = True
        Me.lblNumero2.Location = New System.Drawing.Point(41, 91)
        Me.lblNumero2.Name = "lblNumero2"
        Me.lblNumero2.Size = New System.Drawing.Size(108, 13)
        Me.lblNumero2.TabIndex = 5
        Me.lblNumero2.Text = "Nota Dos (4 Créditos)"
        Me.lblNumero2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(379, 115)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(379, 86)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 3
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(379, 57)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 2
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'tbNumero1
        '
        Me.tbNumero1.Location = New System.Drawing.Point(157, 59)
        Me.tbNumero1.Name = "tbNumero1"
        Me.tbNumero1.Size = New System.Drawing.Size(194, 20)
        Me.tbNumero1.TabIndex = 1
        '
        'lblNumero1
        '
        Me.lblNumero1.AutoSize = True
        Me.lblNumero1.Location = New System.Drawing.Point(42, 62)
        Me.lblNumero1.Name = "lblNumero1"
        Me.lblNumero1.Size = New System.Drawing.Size(109, 13)
        Me.lblNumero1.TabIndex = 0
        Me.lblNumero1.Text = "Nota Uno (3 Créditos)"
        Me.lblNumero1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gbInferior
        '
        Me.gbInferior.Controls.Add(Me.tbSituacion)
        Me.gbInferior.Controls.Add(Me.tbPromedio)
        Me.gbInferior.Controls.Add(Me.lblSituacion)
        Me.gbInferior.Controls.Add(Me.lblPromedio)
        Me.gbInferior.Location = New System.Drawing.Point(12, 239)
        Me.gbInferior.Name = "gbInferior"
        Me.gbInferior.Size = New System.Drawing.Size(481, 193)
        Me.gbInferior.TabIndex = 1
        Me.gbInferior.TabStop = False
        '
        'tbSituacion
        '
        Me.tbSituacion.Location = New System.Drawing.Point(157, 76)
        Me.tbSituacion.Name = "tbSituacion"
        Me.tbSituacion.Size = New System.Drawing.Size(176, 20)
        Me.tbSituacion.TabIndex = 10
        '
        'tbPromedio
        '
        Me.tbPromedio.Location = New System.Drawing.Point(157, 50)
        Me.tbPromedio.Name = "tbPromedio"
        Me.tbPromedio.Size = New System.Drawing.Size(176, 20)
        Me.tbPromedio.TabIndex = 8
        '
        'lblSituacion
        '
        Me.lblSituacion.AutoSize = True
        Me.lblSituacion.Location = New System.Drawing.Point(101, 79)
        Me.lblSituacion.Name = "lblSituacion"
        Me.lblSituacion.Size = New System.Drawing.Size(51, 13)
        Me.lblSituacion.TabIndex = 9
        Me.lblSituacion.Text = "Situación"
        Me.lblSituacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPromedio
        '
        Me.lblPromedio.AutoSize = True
        Me.lblPromedio.Location = New System.Drawing.Point(101, 53)
        Me.lblPromedio.Name = "lblPromedio"
        Me.lblPromedio.Size = New System.Drawing.Size(51, 13)
        Me.lblPromedio.TabIndex = 7
        Me.lblPromedio.Text = "Promedio"
        Me.lblPromedio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmCalculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 444)
        Me.Controls.Add(Me.gbInferior)
        Me.Controls.Add(Me.gbSuperior)
        Me.Name = "frmCalculadora"
        Me.Text = "Calculadora de promedio"
        Me.gbSuperior.ResumeLayout(False)
        Me.gbSuperior.PerformLayout()
        Me.gbInferior.ResumeLayout(False)
        Me.gbInferior.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbSuperior As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents gbInferior As GroupBox
    Friend WithEvents tbNumero2 As TextBox
    Friend WithEvents lblNumero2 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents tbNumero1 As TextBox
    Friend WithEvents lblNumero1 As Label
    Friend WithEvents tbSituacion As TextBox
    Friend WithEvents tbPromedio As TextBox
    Friend WithEvents lblSituacion As Label
    Friend WithEvents lblPromedio As Label
    Friend WithEvents tbNumero3 As TextBox
    Friend WithEvents lblNumero3 As Label
End Class
