Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.Drawing.Image
Imports System.IO
Imports CLASES

Public Class VENTANA_INICIO

    Sub conexion()
        Dim CN As SqlConnection
        Try
            dao_conex.conectar()
            CN = dao_conex.getconexion
            Label12.Text = "CONEXION: EXITOSA"
            O.Enabled = True
            TabControl1.Enabled = True
            Timer1.Enabled = True
            MenuStrip1.Enabled = True
        Catch ex As Exception
            Label12.Text = "CONEXION: FALLIDA"
        End Try
    End Sub
    Sub limpiar1()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub
    Sub limpiar2()
        TextBox4.Text = ""
        TextBox5.Clear()
        TextBox6.Clear()
        PictureBox1.Image = Nothing
    End Sub
    Sub limpiar3()
        Dim saveUcnow As DateTime = DateTime.Now
        DateTimePicker2.Value = saveUcnow
        ComboBox5.SelectedIndex = 0
        ComboBox6.SelectedIndex = 0
        ComboBox7.SelectedIndex = 0
    End Sub
    Sub cargar_datos()
        cargar_carrera()
        cargar_alumno()
        cargar_docente()
        cargar_horario()
        cargar_clase()
    End Sub
    Sub cargar_alumno()
        Try
            Dim dt As DataTable
            dt = dao_alum.listado
            TABLA_ALUMNOS.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub cargar_clase()
        Try
            Dim dt As DataTable
            dt = dao_cla.listado
            TABLA_CLASE.DataSource = dt
            TABLA_CLASE.Columns("FOTO DEL DOCENTE").Width = 81
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub cargar_carrera()
        Try
            Dim dt As DataTable
            dt = dao_carrera.listado
            ComboBox1.DataSource = dt
            ComboBox1.DisplayMember = "carrera"
            ComboBox1.ValueMember = "carrera"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub cargar_docente()
        Try
            Dim dt As DataTable
            dt = dao_doc.listado
            TABLA_PROFESOR.DataSource = dt
            TABLA_PROFESOR.Columns("FOTO").Width = 81
            ComboBox12.DataSource = dt
            ComboBox12.DisplayMember = "NOMBRE_APELLIDOS"
            ComboBox12.ValueMember = "ID_DOCENTE"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub cargar_horario()
        Try
            Dim dt As DataTable
            dt = dao_jhor.listado
            TABLA_HORARIOS.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Dim IMGBYTES As Byte() = Nothing
    Function MycallBack() As Boolean
        Return False
    End Function
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label13.Text = TimeOfDay
    End Sub
    Private Sub VENTANA_INICIO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label13.Text = TimeOfDay
        conexion()
        cargar_datos()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim C As New RP_CARRERA
        C.ShowDialog()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim C As New RP_DOCENTES
        C.ShowDialog()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim C As New VENTANA_MATRICULA
        C.ShowDialog()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim C As New VENTANA_CURSOS
        C.ShowDialog()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim C As New VENTANA_ASITENCIA
        C.ShowDialog()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            If (abrir_imagenesDOCENTE.ShowDialog = vbOK) Then
                Dim CallBack As New GetThumbnailImageAbort(AddressOf MycallBack)
                Dim MIIMAGE As Image = Image.FromFile(abrir_imagenesDOCENTE.FileName)
                Dim IMAGESTREAM As MemoryStream = New MemoryStream
                MIIMAGE.GetThumbnailImage(81, 51, CallBack, IntPtr.Zero).Save(IMAGESTREAM, ImageFormat.Jpeg)
                IMGBYTES = IMAGESTREAM.GetBuffer
                IMAGESTREAM = New MemoryStream(IMGBYTES)
                PictureBox1.Image = Image.FromStream(IMAGESTREAM)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim C As New VENTANA_ASIGNACION_CLASE
        C.ShowDialog()
    End Sub
    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Try
            If ComboBox3.Text = "NUEVO" Then
                limpiar1()
            End If
            If ComboBox3.Text = "REGISTRAR" Then
                Try
                    Dim C As New ALUMNO(0, CInt(TextBox1.Text), TextBox2.Text & "-" & TextBox3.Text, ComboBox1.Text, ComboBox2.Text)
                    dao_alum.agregar(C)
                    cargar_alumno()
                    limpiar1()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            If ComboBox3.Text = "ACTUALIZAR" Then
                Try
                    Dim C As New ALUMNO(CInt(Convert.ToString(TABLA_ALUMNOS.CurrentRow.Cells(0).Value)), CInt(TextBox1.Text), TextBox2.Text & "-" & TextBox3.Text, ComboBox1.Text, ComboBox2.Text)
                    dao_alum.modificar(C)
                    cargar_alumno()
                    limpiar1()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            If ComboBox3.Text = "ELIMINAR" Then
                Try
                    Dim C As New ALUMNO(CInt(Convert.ToString(TABLA_ALUMNOS.CurrentRow.Cells(0).Value)), CInt(TextBox1.Text), TextBox2.Text & "-" & TextBox3.Text, ComboBox1.Text, ComboBox2.Text)
                    dao_alum.eliminar(C)
                    cargar_alumno()
                    limpiar1()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        Try
            If ComboBox4.Text = "NUEVO" Then
                limpiar2()
            End If
            If ComboBox4.Text = "REPORTE" Then
                Dim C As New RP_DOCENTES
                C.ShowDialog()
            End If
            If ComboBox4.Text = "REGISTRAR" Then
                Dim C As New DOCENTE(0, CInt(TextBox6.Text), TextBox5.Text & "-" & TextBox4.Text, IMGBYTES)
                dao_doc.agregar(C)
                limpiar2()
            End If
            If ComboBox4.Text = "ELIMINAR" Then
                Dim C As New DOCENTE(CInt(Convert.ToString(TABLA_PROFESOR.CurrentRow.Cells(0).Value)), CInt(TextBox6.Text), TextBox5.Text & "-" & TextBox4.Text, IMGBYTES)
                dao_doc.eliminar(C)
                limpiar2()
            End If
            If ComboBox4.Text = "ACTUALIZAR" Then
                Dim C As New DOCENTE(CInt(Convert.ToString(TABLA_PROFESOR.CurrentRow.Cells(0).Value)), CInt(TextBox6.Text), TextBox5.Text & "-" & TextBox4.Text, IMGBYTES)
                dao_doc.actualizar(C)
                limpiar2()
            End If
            cargar_docente()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ComboBox9_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox9.SelectedIndexChanged
        Try
            If ComboBox9.Text = "NUEVO" Then
                limpiar3()
            End If
            If ComboBox9.Text = "REGISTRAR" Then
                Dim c As New HORARIO(0, DateTimePicker2.Value.ToShortDateString, ComboBox5.Text & ":" & ComboBox6.Text & ":" & ComboBox7.Text)
                dao_jhor.agregar(c)
            End If
            If ComboBox9.Text = "ELIMINAR" Then
                Dim c As New HORARIO(CInt(TABLA_HORARIOS.CurrentRow.Cells(0).Value), DateTimePicker2.Value.ToShortDateString, ComboBox5.Text & ":" & ComboBox6.Text & ":" & ComboBox7.Text)
                dao_jhor.eliminar(c)
            End If
            If ComboBox9.Text = "ACTUALIZAR" Then
                Dim c As New HORARIO(CInt(Convert.ToString(TABLA_HORARIOS.CurrentRow.Cells(0).Value)), DateTimePicker2.Value.ToShortDateString, ComboBox5.Text & ":" & ComboBox6.Text & ":" & ComboBox7.Text)
                dao_jhor.actualizar(c)
            End If
            cargar_horario()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ComboBox13_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox13.SelectedIndexChanged
        Try
            If ComboBox13.Text = "REGISTRAR" Then
                Dim c As New CLASE(0, DateTimePicker1.Value.ToShortDateString, Convert.ToString(ComboBox11.Text & ":" & ComboBox10.Text & ":" & ComboBox8.Text), CInt(ComboBox12.SelectedValue))
                dao_cla.agregar(c)
            End If
            If ComboBox13.Text = "ELIMINAR" Then
                Dim c As New CLASE(TABLA_CLASE.CurrentRow.Cells(0).Value, DateTimePicker1.Value.ToShortDateString, Convert.ToString(ComboBox11.Text & ":" & ComboBox10.Text & ":" & ComboBox8.Text), CInt(ComboBox12.SelectedValue))
                dao_cla.eliminar(c)
            End If
            If ComboBox13.Text = "ACTUALIZAR" Then
                Dim c As New CLASE(TABLA_CLASE.CurrentRow.Cells(0).Value, DateTimePicker1.Value.ToShortDateString, Convert.ToString(ComboBox11.Text & ":" & ComboBox10.Text & ":" & ComboBox8.Text), CInt(ComboBox12.SelectedValue))
                dao_cla.modificar(c)
            End If
            cargar_clase()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub TABLA_ALUMNOS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TABLA_ALUMNOS.CellClick
        Try
            TextBox1.Text = Convert.ToString(TABLA_ALUMNOS.CurrentRow.Cells(1).Value)
            Dim C() As String
            C = Convert.ToString(TABLA_ALUMNOS.CurrentRow.Cells(2).Value).Split("-")
            TextBox2.Text = C(0)
            TextBox3.Text = C(1)
            ComboBox1.SelectedValue = Convert.ToString(TABLA_ALUMNOS.CurrentRow.Cells(3).Value)
            ComboBox2.SelectedItem = Convert.ToString(TABLA_ALUMNOS.CurrentRow.Cells(4).Value)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub TABLA_HORARIOS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TABLA_HORARIOS.CellClick
        Try
            DateTimePicker2.Value = TABLA_HORARIOS.CurrentRow.Cells(1).Value
            Dim c() As String
            c = Convert.ToString(TABLA_HORARIOS.CurrentRow.Cells(2).Value).Split(":")
            ComboBox5.SelectedItem = c(0)
            ComboBox6.SelectedItem = c(1)
            ComboBox7.SelectedItem = c(2)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub TABLA_PROFESOR_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TABLA_PROFESOR.CellClick
        Try
            TextBox6.Text = Convert.ToString(TABLA_PROFESOR.CurrentRow.Cells(1).Value)
            Dim C() As String
            C = Convert.ToString(TABLA_PROFESOR.CurrentRow.Cells(2).Value).Split("-")
            TextBox5.Text = C(0)
            TextBox4.Text = C(1)
            PictureBox1.Image = TABLA_PROFESOR.CurrentRow.Cells(3).FormattedValue
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CARRERAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CARRERAToolStripMenuItem.Click
        Dim C As New RP_ALUMNOPORCARRERA
        C.ShowDialog()
    End Sub

    Private Sub CLASESDEUNDOCENTEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CLASESDEUNDOCENTEToolStripMenuItem.Click
        Dim C As New RP_CLASESPORDOCENTE
        C.ShowDialog()
    End Sub

    Private Sub CURSOSDEUNACARRERAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CURSOSDEUNACARRERAToolStripMenuItem.Click
        Dim C As New RP_CURSOSPORCARRERA
        C.ShowDialog()
    End Sub

    Private Sub ASISTENCIAPORCLASEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ASISTENCIAPORCLASEToolStripMenuItem.Click
        Dim C As New RP_ASISTENCIADEUNACLASE
        C.ShowDialog()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub
End Class