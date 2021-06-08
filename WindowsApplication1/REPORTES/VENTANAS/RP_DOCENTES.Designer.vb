<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RP_DOCENTES
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
        Me._BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet = New WindowsApplication1._BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet()
        Me.vista_docenteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.vista_docenteTableAdapter = New WindowsApplication1._BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSetTableAdapters.vista_docenteTableAdapter()
        CType(Me._BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vista_docenteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.vista_docenteBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(482, 341)
        Me.ReportViewer1.TabIndex = 0
        '
        '_BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet
        '
        Me._BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet.DataSetName = "_BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet"
        Me._BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'vista_docenteBindingSource
        '
        Me.vista_docenteBindingSource.DataMember = "vista_docente"
        Me.vista_docenteBindingSource.DataSource = Me._BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet
        '
        'vista_docenteTableAdapter
        '
        Me.vista_docenteTableAdapter.ClearBeforeFill = True
        '
        'VENTANA_DOCENTES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 341)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VENTANA_DOCENTES"
        Me.Text = "VENTANA_DOCENTES"
        CType(Me._BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vista_docenteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents vista_docenteBindingSource As BindingSource
    Friend WithEvents _BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet As _BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet
    Friend WithEvents vista_docenteTableAdapter As _BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSetTableAdapters.vista_docenteTableAdapter
End Class
