<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RP_ASISTENCIADEUNACLASE
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.TABLA = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me._BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet6 = New WindowsApplication1._BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet6()
        Me.vista_asistenciaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.vista_asistenciaTableAdapter = New WindowsApplication1._BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet6TableAdapters.vista_asistenciaTableAdapter()
        CType(Me.TABLA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vista_asistenciaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TABLA
        '
        Me.TABLA.AllowUserToAddRows = False
        Me.TABLA.AllowUserToDeleteRows = False
        Me.TABLA.BackgroundColor = System.Drawing.SystemColors.Info
        Me.TABLA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TABLA.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.TABLA.Location = New System.Drawing.Point(15, 33)
        Me.TABLA.Name = "TABLA"
        Me.TABLA.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TABLA.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.TABLA.RowHeadersWidth = 20
        Me.TABLA.RowTemplate.Height = 58
        Me.TABLA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TABLA.Size = New System.Drawing.Size(423, 121)
        Me.TABLA.TabIndex = 39
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(363, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "BUSCAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "CARRERA:"
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.vista_asistenciaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Report6.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(15, 160)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(423, 200)
        Me.ReportViewer1.TabIndex = 42
        '
        '_BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet6
        '
        Me._BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet6.DataSetName = "_BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet6"
        Me._BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'vista_asistenciaBindingSource
        '
        Me.vista_asistenciaBindingSource.DataMember = "vista_asistencia"
        Me.vista_asistenciaBindingSource.DataSource = Me._BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet6
        '
        'vista_asistenciaTableAdapter
        '
        Me.vista_asistenciaTableAdapter.ClearBeforeFill = True
        '
        'RP_ASISTENCIADEUNACLASE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 370)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TABLA)
        Me.Name = "RP_ASISTENCIADEUNACLASE"
        Me.Text = "RP_ASISTENCIADEUNACLASE"
        CType(Me.TABLA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vista_asistenciaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TABLA As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents vista_asistenciaBindingSource As BindingSource
    Friend WithEvents _BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet6 As _BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet6
    Friend WithEvents vista_asistenciaTableAdapter As _BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet6TableAdapters.vista_asistenciaTableAdapter
End Class
