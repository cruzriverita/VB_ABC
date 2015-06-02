<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabInsertar = New System.Windows.Forms.TabPage()
        Me.TabActualizar = New System.Windows.Forms.TabPage()
        Me.TabEliminar = New System.Windows.Forms.TabPage()
        Me.TabVisualizar = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextNombre = New System.Windows.Forms.TextBox()
        Me.TextDPI = New System.Windows.Forms.TextBox()
        Me.ButtonInsertar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.TabInsertar.SuspendLayout()
        Me.TabActualizar.SuspendLayout()
        Me.TabEliminar.SuspendLayout()
        Me.TabVisualizar.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabInsertar)
        Me.TabControl1.Controls.Add(Me.TabActualizar)
        Me.TabControl1.Controls.Add(Me.TabEliminar)
        Me.TabControl1.Controls.Add(Me.TabVisualizar)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(694, 401)
        Me.TabControl1.TabIndex = 0
        '
        'TabInsertar
        '
        Me.TabInsertar.Controls.Add(Me.ButtonInsertar)
        Me.TabInsertar.Controls.Add(Me.TextDPI)
        Me.TabInsertar.Controls.Add(Me.TextNombre)
        Me.TabInsertar.Controls.Add(Me.Label2)
        Me.TabInsertar.Controls.Add(Me.Label1)
        Me.TabInsertar.Location = New System.Drawing.Point(4, 22)
        Me.TabInsertar.Name = "TabInsertar"
        Me.TabInsertar.Padding = New System.Windows.Forms.Padding(3)
        Me.TabInsertar.Size = New System.Drawing.Size(686, 375)
        Me.TabInsertar.TabIndex = 0
        Me.TabInsertar.Text = "Insertar"
        Me.TabInsertar.UseVisualStyleBackColor = True
        '
        'TabActualizar
        '
        Me.TabActualizar.Controls.Add(Me.ComboBox1)
        Me.TabActualizar.Controls.Add(Me.TextBox3)
        Me.TabActualizar.Controls.Add(Me.Label5)
        Me.TabActualizar.Controls.Add(Me.Button1)
        Me.TabActualizar.Controls.Add(Me.TextBox1)
        Me.TabActualizar.Controls.Add(Me.TextBox2)
        Me.TabActualizar.Controls.Add(Me.Label3)
        Me.TabActualizar.Controls.Add(Me.Label4)
        Me.TabActualizar.Location = New System.Drawing.Point(4, 22)
        Me.TabActualizar.Name = "TabActualizar"
        Me.TabActualizar.Padding = New System.Windows.Forms.Padding(3)
        Me.TabActualizar.Size = New System.Drawing.Size(686, 375)
        Me.TabActualizar.TabIndex = 1
        Me.TabActualizar.Text = "Actualizar"
        Me.TabActualizar.UseVisualStyleBackColor = True
        '
        'TabEliminar
        '
        Me.TabEliminar.Controls.Add(Me.ComboBox2)
        Me.TabEliminar.Controls.Add(Me.TextBox4)
        Me.TabEliminar.Controls.Add(Me.Label6)
        Me.TabEliminar.Controls.Add(Me.Button2)
        Me.TabEliminar.Controls.Add(Me.TextBox5)
        Me.TabEliminar.Controls.Add(Me.TextBox6)
        Me.TabEliminar.Controls.Add(Me.Label7)
        Me.TabEliminar.Controls.Add(Me.Label8)
        Me.TabEliminar.Location = New System.Drawing.Point(4, 22)
        Me.TabEliminar.Name = "TabEliminar"
        Me.TabEliminar.Padding = New System.Windows.Forms.Padding(3)
        Me.TabEliminar.Size = New System.Drawing.Size(686, 375)
        Me.TabEliminar.TabIndex = 2
        Me.TabEliminar.Text = "Eliminar"
        Me.TabEliminar.UseVisualStyleBackColor = True
        '
        'TabVisualizar
        '
        Me.TabVisualizar.Controls.Add(Me.DataGridView1)
        Me.TabVisualizar.Location = New System.Drawing.Point(4, 22)
        Me.TabVisualizar.Name = "TabVisualizar"
        Me.TabVisualizar.Padding = New System.Windows.Forms.Padding(3)
        Me.TabVisualizar.Size = New System.Drawing.Size(686, 375)
        Me.TabVisualizar.TabIndex = 3
        Me.TabVisualizar.Text = "Visualizar"
        Me.TabVisualizar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "DPI"
        '
        'TextNombre
        '
        Me.TextNombre.Location = New System.Drawing.Point(135, 86)
        Me.TextNombre.Name = "TextNombre"
        Me.TextNombre.Size = New System.Drawing.Size(240, 20)
        Me.TextNombre.TabIndex = 2
        '
        'TextDPI
        '
        Me.TextDPI.Location = New System.Drawing.Point(135, 124)
        Me.TextDPI.Name = "TextDPI"
        Me.TextDPI.Size = New System.Drawing.Size(240, 20)
        Me.TextDPI.TabIndex = 3
        '
        'ButtonInsertar
        '
        Me.ButtonInsertar.Location = New System.Drawing.Point(135, 173)
        Me.ButtonInsertar.Name = "ButtonInsertar"
        Me.ButtonInsertar.Size = New System.Drawing.Size(240, 23)
        Me.ButtonInsertar.TabIndex = 4
        Me.ButtonInsertar.Text = "Insertar"
        Me.ButtonInsertar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(138, 173)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(240, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Actualizar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(138, 124)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(240, 20)
        Me.TextBox1.TabIndex = 8
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(138, 86)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(240, 20)
        Me.TextBox2.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "DPI"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Nombre"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(138, 41)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(240, 20)
        Me.TextBox3.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "ID"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(422, 39)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(225, 21)
        Me.ComboBox1.TabIndex = 12
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(416, 53)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(225, 21)
        Me.ComboBox2.TabIndex = 20
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(132, 55)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(240, 20)
        Me.TextBox4.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "ID"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(132, 187)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(240, 23)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Eliminar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(132, 138)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(240, 20)
        Me.TextBox5.TabIndex = 16
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(132, 100)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(240, 20)
        Me.TextBox6.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "DPI"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Nombre"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(43, 48)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(573, 271)
        Me.DataGridView1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 401)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabInsertar.ResumeLayout(False)
        Me.TabInsertar.PerformLayout()
        Me.TabActualizar.ResumeLayout(False)
        Me.TabActualizar.PerformLayout()
        Me.TabEliminar.ResumeLayout(False)
        Me.TabEliminar.PerformLayout()
        Me.TabVisualizar.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabInsertar As System.Windows.Forms.TabPage
    Friend WithEvents ButtonInsertar As System.Windows.Forms.Button
    Friend WithEvents TextDPI As System.Windows.Forms.TextBox
    Friend WithEvents TextNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabActualizar As System.Windows.Forms.TabPage
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TabEliminar As System.Windows.Forms.TabPage
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TabVisualizar As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView

End Class
