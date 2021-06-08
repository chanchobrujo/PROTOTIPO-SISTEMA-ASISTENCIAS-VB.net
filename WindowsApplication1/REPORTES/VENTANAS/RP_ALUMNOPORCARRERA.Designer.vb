<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RP_ALUMNOPORCARRERA
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me._BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet2 = New WindowsApplication1._BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet2()
        Me.ALUMNOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALUMNOTableAdapter = New WindowsApplication1._BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet2TableAdapters.ALUMNOTableAdapter()
        CType(Me._BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALUMNOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(363, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "BUSCAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(77, 6)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(164, 21)
        Me.ComboBox1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "CARRERA:"
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ALUMNOBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Report3.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(15, 33)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(423, 246)
        Me.ReportViewer1.TabIndex = 6
        '
        '_BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet2
        '
        Me._BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet2.DataSetName = "_BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet2"
        Me._BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ALUMNOBindingSource
        '
        Me.ALUMNOBindingSource.DataMember = "ALUMNO"
        Me.ALUMNOBindingSource.DataSource = Me._BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet2
        '
        'ALUMNOTableAdapter
        '
        Me.ALUMNOTableAdapter.ClearBeforeFill = True
        '
        'RP_ALUMNOPORCARRERA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 289)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RP_ALUMNOPORCARRERA"
        Me.Text = "RP_ALUMNOPORCARRERA"
        CType(Me._BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALUMNOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ALUMNOBindingSource As BindingSource
    Friend WithEvents _BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet2 As _BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet2
    Friend WithEvents ALUMNOTableAdapter As _BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet2TableAdapters.ALUMNOTableAdapter
End Class
