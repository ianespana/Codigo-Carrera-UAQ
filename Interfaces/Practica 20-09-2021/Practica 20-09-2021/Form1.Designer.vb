<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFormulario
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
        Me.tcDatos = New System.Windows.Forms.TabControl()
        Me.tpGeneral = New System.Windows.Forms.TabPage()
        Me.tpOpcional = New System.Windows.Forms.TabPage()
        Me.gbUsuario = New System.Windows.Forms.GroupBox()
        Me.gbPerfil = New System.Windows.Forms.GroupBox()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.lbApellidoPaterno = New System.Windows.Forms.Label()
        Me.lbApellidoMaterno = New System.Windows.Forms.Label()
        Me.lbNacionalidad = New System.Windows.Forms.Label()
        Me.lbSexo = New System.Windows.Forms.Label()
        Me.tcDatos.SuspendLayout()
        Me.tpGeneral.SuspendLayout()
        Me.gbUsuario.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcDatos
        '
        Me.tcDatos.Controls.Add(Me.tpGeneral)
        Me.tcDatos.Controls.Add(Me.tpOpcional)
        Me.tcDatos.Location = New System.Drawing.Point(41, 27)
        Me.tcDatos.Name = "tcDatos"
        Me.tcDatos.SelectedIndex = 0
        Me.tcDatos.Size = New System.Drawing.Size(713, 396)
        Me.tcDatos.TabIndex = 0
        '
        'tpGeneral
        '
        Me.tpGeneral.Controls.Add(Me.gbPerfil)
        Me.tpGeneral.Controls.Add(Me.gbUsuario)
        Me.tpGeneral.Location = New System.Drawing.Point(4, 22)
        Me.tpGeneral.Name = "tpGeneral"
        Me.tpGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tpGeneral.Size = New System.Drawing.Size(705, 370)
        Me.tpGeneral.TabIndex = 0
        Me.tpGeneral.Text = "Datos Generales"
        Me.tpGeneral.UseVisualStyleBackColor = True
        '
        'tpOpcional
        '
        Me.tpOpcional.Location = New System.Drawing.Point(4, 22)
        Me.tpOpcional.Name = "tpOpcional"
        Me.tpOpcional.Padding = New System.Windows.Forms.Padding(3)
        Me.tpOpcional.Size = New System.Drawing.Size(705, 370)
        Me.tpOpcional.TabIndex = 1
        Me.tpOpcional.Text = "Datos Opcionales"
        Me.tpOpcional.UseVisualStyleBackColor = True
        '
        'gbUsuario
        '
        Me.gbUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gbUsuario.Controls.Add(Me.lbSexo)
        Me.gbUsuario.Controls.Add(Me.lbNacionalidad)
        Me.gbUsuario.Controls.Add(Me.lbApellidoMaterno)
        Me.gbUsuario.Controls.Add(Me.lbApellidoPaterno)
        Me.gbUsuario.Controls.Add(Me.lbNombre)
        Me.gbUsuario.Location = New System.Drawing.Point(6, 16)
        Me.gbUsuario.Name = "gbUsuario"
        Me.gbUsuario.Size = New System.Drawing.Size(341, 348)
        Me.gbUsuario.TabIndex = 0
        Me.gbUsuario.TabStop = False
        Me.gbUsuario.Text = "Datos de Usuario"
        '
        'gbPerfil
        '
        Me.gbPerfil.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gbPerfil.Location = New System.Drawing.Point(353, 16)
        Me.gbPerfil.Name = "gbPerfil"
        Me.gbPerfil.Size = New System.Drawing.Size(346, 348)
        Me.gbPerfil.TabIndex = 1
        Me.gbPerfil.TabStop = False
        Me.gbPerfil.Text = "Datos de Perfil"
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Location = New System.Drawing.Point(6, 31)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(44, 13)
        Me.lbNombre.TabIndex = 0
        Me.lbNombre.Text = "Nombre"
        '
        'lbApellidoPaterno
        '
        Me.lbApellidoPaterno.AutoSize = True
        Me.lbApellidoPaterno.Location = New System.Drawing.Point(6, 56)
        Me.lbApellidoPaterno.Name = "lbApellidoPaterno"
        Me.lbApellidoPaterno.Size = New System.Drawing.Size(84, 13)
        Me.lbApellidoPaterno.TabIndex = 1
        Me.lbApellidoPaterno.Text = "Apellido Paterno"
        '
        'lbApellidoMaterno
        '
        Me.lbApellidoMaterno.AutoSize = True
        Me.lbApellidoMaterno.Location = New System.Drawing.Point(6, 81)
        Me.lbApellidoMaterno.Name = "lbApellidoMaterno"
        Me.lbApellidoMaterno.Size = New System.Drawing.Size(86, 13)
        Me.lbApellidoMaterno.TabIndex = 2
        Me.lbApellidoMaterno.Text = "Apellido Materno"
        '
        'lbNacionalidad
        '
        Me.lbNacionalidad.AutoSize = True
        Me.lbNacionalidad.Location = New System.Drawing.Point(6, 223)
        Me.lbNacionalidad.Name = "lbNacionalidad"
        Me.lbNacionalidad.Size = New System.Drawing.Size(69, 13)
        Me.lbNacionalidad.TabIndex = 3
        Me.lbNacionalidad.Text = "Nacionalidad"
        '
        'lbSexo
        '
        Me.lbSexo.AutoSize = True
        Me.lbSexo.Location = New System.Drawing.Point(6, 163)
        Me.lbSexo.Name = "lbSexo"
        Me.lbSexo.Size = New System.Drawing.Size(31, 13)
        Me.lbSexo.TabIndex = 4
        Me.lbSexo.Text = "Sexo"
        '
        'frmFormulario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSalmon
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tcDatos)
        Me.Name = "frmFormulario"
        Me.Text = "Formularios"
        Me.tcDatos.ResumeLayout(False)
        Me.tpGeneral.ResumeLayout(False)
        Me.gbUsuario.ResumeLayout(False)
        Me.gbUsuario.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tcDatos As TabControl
    Friend WithEvents tpGeneral As TabPage
    Friend WithEvents tpOpcional As TabPage
    Friend WithEvents gbPerfil As GroupBox
    Friend WithEvents gbUsuario As GroupBox
    Friend WithEvents lbSexo As Label
    Friend WithEvents lbNacionalidad As Label
    Friend WithEvents lbApellidoMaterno As Label
    Friend WithEvents lbApellidoPaterno As Label
    Friend WithEvents lbNombre As Label
End Class
