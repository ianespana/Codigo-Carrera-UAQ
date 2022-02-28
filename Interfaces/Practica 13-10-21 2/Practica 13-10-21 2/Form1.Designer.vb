<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEpilepsia
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
        Me.lbOscuro = New System.Windows.Forms.Label()
        Me.lbClaro = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.btnEpilepsia = New System.Windows.Forms.Button()
        Me.btnNoEpilepsia = New System.Windows.Forms.Button()
        Me.lbAhora = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbOscuro
        '
        Me.lbOscuro.AutoSize = True
        Me.lbOscuro.Font = New System.Drawing.Font("Segoe UI Black", 70.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbOscuro.ForeColor = System.Drawing.Color.Blue
        Me.lbOscuro.Location = New System.Drawing.Point(22, 172)
        Me.lbOscuro.Name = "lbOscuro"
        Me.lbOscuro.Size = New System.Drawing.Size(753, 125)
        Me.lbOscuro.TabIndex = 0
        Me.lbOscuro.Text = "Yeah, SCIENCE!"
        '
        'lbClaro
        '
        Me.lbClaro.AutoSize = True
        Me.lbClaro.Font = New System.Drawing.Font("Segoe UI Black", 70.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbClaro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbClaro.Location = New System.Drawing.Point(22, 172)
        Me.lbClaro.Name = "lbClaro"
        Me.lbClaro.Size = New System.Drawing.Size(753, 125)
        Me.lbClaro.TabIndex = 1
        Me.lbClaro.Text = "Yeah, SCIENCE!"
        '
        'Timer1
        '
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1000
        '
        'btnEpilepsia
        '
        Me.btnEpilepsia.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEpilepsia.Location = New System.Drawing.Point(135, 371)
        Me.btnEpilepsia.Name = "btnEpilepsia"
        Me.btnEpilepsia.Size = New System.Drawing.Size(150, 60)
        Me.btnEpilepsia.TabIndex = 2
        Me.btnEpilepsia.Text = "Ejecutar"
        Me.btnEpilepsia.UseVisualStyleBackColor = True
        '
        'btnNoEpilepsia
        '
        Me.btnNoEpilepsia.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNoEpilepsia.Location = New System.Drawing.Point(538, 371)
        Me.btnNoEpilepsia.Name = "btnNoEpilepsia"
        Me.btnNoEpilepsia.Size = New System.Drawing.Size(150, 60)
        Me.btnNoEpilepsia.TabIndex = 3
        Me.btnNoEpilepsia.Text = "Detener"
        Me.btnNoEpilepsia.UseVisualStyleBackColor = True
        '
        'lbAhora
        '
        Me.lbAhora.AutoSize = True
        Me.lbAhora.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAhora.Location = New System.Drawing.Point(46, 55)
        Me.lbAhora.Name = "lbAhora"
        Me.lbAhora.Size = New System.Drawing.Size(95, 31)
        Me.lbAhora.TabIndex = 4
        Me.lbAhora.Text = "Label1"
        '
        'frmEpilepsia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbAhora)
        Me.Controls.Add(Me.btnNoEpilepsia)
        Me.Controls.Add(Me.btnEpilepsia)
        Me.Controls.Add(Me.lbClaro)
        Me.Controls.Add(Me.lbOscuro)
        Me.Name = "frmEpilepsia"
        Me.Text = "Epilepsia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbOscuro As Label
    Friend WithEvents lbClaro As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents btnEpilepsia As Button
    Friend WithEvents btnNoEpilepsia As Button
    Friend WithEvents lbAhora As Label
End Class
