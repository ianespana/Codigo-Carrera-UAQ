<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOperaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOperaciones))
        Me.gbSuperior = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tbNumero2 = New System.Windows.Forms.TextBox()
        Me.lblNumero2 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.tbNumero1 = New System.Windows.Forms.TextBox()
        Me.lblNumero1 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.gbInferior = New System.Windows.Forms.GroupBox()
        Me.tbRaiz = New System.Windows.Forms.TextBox()
        Me.lblRaiz = New System.Windows.Forms.Label()
        Me.tbMult = New System.Windows.Forms.TextBox()
        Me.lblMult = New System.Windows.Forms.Label()
        Me.tbPot = New System.Windows.Forms.TextBox()
        Me.lblPot = New System.Windows.Forms.Label()
        Me.tbDiv = New System.Windows.Forms.TextBox()
        Me.lblDiv = New System.Windows.Forms.Label()
        Me.tbResta = New System.Windows.Forms.TextBox()
        Me.tbSuma = New System.Windows.Forms.TextBox()
        Me.lblResta = New System.Windows.Forms.Label()
        Me.lblSuma = New System.Windows.Forms.Label()
        Me.gbSuperior.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbInferior.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbSuperior
        '
        Me.gbSuperior.Controls.Add(Me.PictureBox1)
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
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(369, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'tbNumero2
        '
        Me.tbNumero2.Location = New System.Drawing.Point(92, 83)
        Me.tbNumero2.Name = "tbNumero2"
        Me.tbNumero2.Size = New System.Drawing.Size(100, 20)
        Me.tbNumero2.TabIndex = 6
        '
        'lblNumero2
        '
        Me.lblNumero2.AutoSize = True
        Me.lblNumero2.Location = New System.Drawing.Point(33, 86)
        Me.lblNumero2.Name = "lblNumero2"
        Me.lblNumero2.Size = New System.Drawing.Size(53, 13)
        Me.lblNumero2.TabIndex = 5
        Me.lblNumero2.Text = "Número 2"
        Me.lblNumero2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(246, 115)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(246, 86)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 3
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(246, 57)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 2
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'tbNumero1
        '
        Me.tbNumero1.Location = New System.Drawing.Point(92, 57)
        Me.tbNumero1.Name = "tbNumero1"
        Me.tbNumero1.Size = New System.Drawing.Size(100, 20)
        Me.tbNumero1.TabIndex = 1
        '
        'lblNumero1
        '
        Me.lblNumero1.AutoSize = True
        Me.lblNumero1.Location = New System.Drawing.Point(33, 60)
        Me.lblNumero1.Name = "lblNumero1"
        Me.lblNumero1.Size = New System.Drawing.Size(53, 13)
        Me.lblNumero1.TabIndex = 0
        Me.lblNumero1.Text = "Número 1"
        Me.lblNumero1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gbInferior
        '
        Me.gbInferior.Controls.Add(Me.tbRaiz)
        Me.gbInferior.Controls.Add(Me.lblRaiz)
        Me.gbInferior.Controls.Add(Me.tbMult)
        Me.gbInferior.Controls.Add(Me.lblMult)
        Me.gbInferior.Controls.Add(Me.tbPot)
        Me.gbInferior.Controls.Add(Me.lblPot)
        Me.gbInferior.Controls.Add(Me.tbDiv)
        Me.gbInferior.Controls.Add(Me.lblDiv)
        Me.gbInferior.Controls.Add(Me.tbResta)
        Me.gbInferior.Controls.Add(Me.tbSuma)
        Me.gbInferior.Controls.Add(Me.lblResta)
        Me.gbInferior.Controls.Add(Me.lblSuma)
        Me.gbInferior.Location = New System.Drawing.Point(12, 239)
        Me.gbInferior.Name = "gbInferior"
        Me.gbInferior.Size = New System.Drawing.Size(481, 193)
        Me.gbInferior.TabIndex = 1
        Me.gbInferior.TabStop = False
        '
        'tbRaiz
        '
        Me.tbRaiz.Location = New System.Drawing.Point(356, 71)
        Me.tbRaiz.Name = "tbRaiz"
        Me.tbRaiz.Size = New System.Drawing.Size(100, 20)
        Me.tbRaiz.TabIndex = 18
        '
        'lblRaiz
        '
        Me.lblRaiz.AutoSize = True
        Me.lblRaiz.Location = New System.Drawing.Point(320, 74)
        Me.lblRaiz.Name = "lblRaiz"
        Me.lblRaiz.Size = New System.Drawing.Size(30, 13)
        Me.lblRaiz.TabIndex = 17
        Me.lblRaiz.Text = "Raíz"
        Me.lblRaiz.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbMult
        '
        Me.tbMult.Location = New System.Drawing.Point(92, 71)
        Me.tbMult.Name = "tbMult"
        Me.tbMult.Size = New System.Drawing.Size(100, 20)
        Me.tbMult.TabIndex = 16
        '
        'lblMult
        '
        Me.lblMult.AutoSize = True
        Me.lblMult.Location = New System.Drawing.Point(15, 74)
        Me.lblMult.Name = "lblMult"
        Me.lblMult.Size = New System.Drawing.Size(71, 13)
        Me.lblMult.TabIndex = 15
        Me.lblMult.Text = "Multiplicación"
        Me.lblMult.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbPot
        '
        Me.tbPot.Location = New System.Drawing.Point(356, 45)
        Me.tbPot.Name = "tbPot"
        Me.tbPot.Size = New System.Drawing.Size(100, 20)
        Me.tbPot.TabIndex = 14
        '
        'lblPot
        '
        Me.lblPot.AutoSize = True
        Me.lblPot.Location = New System.Drawing.Point(301, 48)
        Me.lblPot.Name = "lblPot"
        Me.lblPot.Size = New System.Drawing.Size(49, 13)
        Me.lblPot.TabIndex = 13
        Me.lblPot.Text = "Potencia"
        Me.lblPot.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbDiv
        '
        Me.tbDiv.Location = New System.Drawing.Point(356, 19)
        Me.tbDiv.Name = "tbDiv"
        Me.tbDiv.Size = New System.Drawing.Size(100, 20)
        Me.tbDiv.TabIndex = 12
        '
        'lblDiv
        '
        Me.lblDiv.AutoSize = True
        Me.lblDiv.Location = New System.Drawing.Point(306, 22)
        Me.lblDiv.Name = "lblDiv"
        Me.lblDiv.Size = New System.Drawing.Size(44, 13)
        Me.lblDiv.TabIndex = 11
        Me.lblDiv.Text = "División"
        Me.lblDiv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbResta
        '
        Me.tbResta.Location = New System.Drawing.Point(92, 45)
        Me.tbResta.Name = "tbResta"
        Me.tbResta.Size = New System.Drawing.Size(100, 20)
        Me.tbResta.TabIndex = 10
        '
        'tbSuma
        '
        Me.tbSuma.Location = New System.Drawing.Point(92, 19)
        Me.tbSuma.Name = "tbSuma"
        Me.tbSuma.Size = New System.Drawing.Size(100, 20)
        Me.tbSuma.TabIndex = 8
        '
        'lblResta
        '
        Me.lblResta.AutoSize = True
        Me.lblResta.Location = New System.Drawing.Point(47, 48)
        Me.lblResta.Name = "lblResta"
        Me.lblResta.Size = New System.Drawing.Size(35, 13)
        Me.lblResta.TabIndex = 9
        Me.lblResta.Text = "Resta"
        Me.lblResta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSuma
        '
        Me.lblSuma.AutoSize = True
        Me.lblSuma.Location = New System.Drawing.Point(47, 22)
        Me.lblSuma.Name = "lblSuma"
        Me.lblSuma.Size = New System.Drawing.Size(34, 13)
        Me.lblSuma.TabIndex = 7
        Me.lblSuma.Text = "Suma"
        Me.lblSuma.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmOperaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 444)
        Me.Controls.Add(Me.gbInferior)
        Me.Controls.Add(Me.gbSuperior)
        Me.Name = "frmOperaciones"
        Me.Text = "Operaciones Aritméticas"
        Me.gbSuperior.ResumeLayout(False)
        Me.gbSuperior.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents tbRaiz As TextBox
    Friend WithEvents lblRaiz As Label
    Friend WithEvents tbMult As TextBox
    Friend WithEvents lblMult As Label
    Friend WithEvents tbPot As TextBox
    Friend WithEvents lblPot As Label
    Friend WithEvents tbDiv As TextBox
    Friend WithEvents lblDiv As Label
    Friend WithEvents tbResta As TextBox
    Friend WithEvents tbSuma As TextBox
    Friend WithEvents lblResta As Label
    Friend WithEvents lblSuma As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
