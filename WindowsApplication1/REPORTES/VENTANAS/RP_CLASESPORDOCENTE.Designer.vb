<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RP_CLASESPORDOCENTE
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me._BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet3 = New WindowsApplication1._BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet3()
        Me.vista_clase2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.vista_clase2TableAdapter = New WindowsApplication1._BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet3TableAdapters.vista_clase2TableAdapter()
        CType(Me._BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vista_clase2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DOCENTE:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(74, 6)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(164, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(360, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "BUSCAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.vista_clase2BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Report4.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 33)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(423, 340)
        Me.ReportViewer1.TabIndex = 3
        '
        '_BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet3
        '
        Me._BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet3.DataSetName = "_BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet3"
        Me._BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'vista_clase2BindingSource
        '
        Me.vista_clase2BindingSource.DataMember = "vista_clase2"
        Me.vista_clase2BindingSource.DataSource = Me._BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet3
        '
        'vista_clase2TableAdapter
        '
        Me.vista_clase2TableAdapter.ClearBeforeFill = True
        '
        'VENTANA_CLASESPORDOCENTE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 385)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "VENTANA_CLASESPORDOCENTE"
        Me.Text = "VENTANA_CLASESPORDOCENTE"
        CType(Me._BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vista_clase2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents vista_clase2BindingSource As BindingSource
    Friend WithEvents _BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet3 As _BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet3
    Friend WithEvents vista_clase2TableAdapter As _BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet3TableAdapters.vista_clase2TableAdapter
End Class
