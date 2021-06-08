<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RP_CARRERA
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me._BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet1 = New WindowsApplication1._BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet1()
        Me.CARRERABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CARRERATableAdapter = New WindowsApplication1._BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet1TableAdapters.CARRERATableAdapter()
        CType(Me._BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CARRERABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.CARRERABindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Report2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(348, 238)
        Me.ReportViewer1.TabIndex = 0
        '
        '_BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet1
        '
        Me._BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet1.DataSetName = "_BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet1"
        Me._BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CARRERABindingSource
        '
        Me.CARRERABindingSource.DataMember = "CARRERA"
        Me.CARRERABindingSource.DataSource = Me._BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet1
        '
        'CARRERATableAdapter
        '
        Me.CARRERATableAdapter.ClearBeforeFill = True
        '
        'VENTANA_CARRERA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 238)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VENTANA_CARRERA"
        Me.Text = "VENTANA_CARRERA"
        CType(Me._BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CARRERABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CARRERABindingSource As BindingSource
    Friend WithEvents _BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet1 As _BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet1
    Friend WithEvents CARRERATableAdapter As _BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet1TableAdapters.CARRERATableAdapter
End Class
