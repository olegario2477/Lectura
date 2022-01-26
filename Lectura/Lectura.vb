Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting.Chart
'Imports System.Drawing.Drawing2D



Public Class Lectura
    '---------
    'Dim Dibujar As Boolean
    'Dim Grafico As Graphics
    '--------

    Dim archivo As String
    Dim ar As String

    Dim efile As String = Application.StartupPath & "\EXPORTAR.CSV"
    Dim ifile As String = Application.StartupPath & "\LECTURA_" + DateTime.Now.ToString("ddMMyyyy") + ".CSV"

    'Private Sub PictureBox1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PictureBox1.Paint

    '    Grafico = e.Graphics

    '    Dim Lapiz As New Pen(Brushes.Black, 3)


    '    If Dibujar Then

    '        Grafico.SmoothingMode = SmoothingMode.AntiAlias

    '        Grafico.DrawArc(Lapiz, 85, 48, 45, 45, -60, 120)

    '        Grafico.DrawLine(Lapiz, 50, 70, 120, 50)

    '        Grafico.DrawLine(Lapiz, 50, 70, 120, 90)

    '    End If

    'End Sub

    'Private Sub BotonGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    modificar()

    'End Sub

    Private Sub Lectura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '----------
        'Dibujar = True
        'PictureBox1.Refresh()
        '----------

        Me.Text = "Lectura Comederos - v " & Me.GetType.Assembly.GetName.Version.ToString() + " - " + bitModo()


        Grid.Height = 250
        Chart1.Height = 380

        EtiquetaFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")

        visualizar()

        ComboLectura.Text = "3"

        ComboDist.Text = "1"
        ComboComp.Text = "N"

        TextoAlmacen.Focus()

        ruta()

    End Sub

    Sub grabar()

        Dim loteeng As String = ""
        Dim vAdelantar As String

        Dim strExport As String = ""

        If Grid.RowCount > 0 Then
            loteeng = Grid.Rows(0).Cells("loteeng").Value
        End If

        If Len(TextoAjuste.Text) = 0 Then
            TextoAjuste.Text = "0"
        End If

        TextoDiasAgregar.Text = TextoDiasAgregar.Text.TrimStart("0")

        If Len(TextoDiasAgregar.Text) = 0 Then
            TextoDiasAgregar.Text = "0"
        End If

        If CheckAdelantar.Checked Then
            vAdelantar = "1"
        Else
            vAdelantar = "0"
        End If

        strExport = DateTime.Now.ToString("yyyyMMdd") + "," + TextoAlmacen.Text + "," + loteeng + "," + ComboLectura.Text + "," + Now.TimeOfDay.ToString + "," + TextoAjuste.Text + "," + vAdelantar + "," + EtiquetaRacAct.Text + "," + TextoDiasAgregar.Text + "," + ComboDist.Text + "," + ComboComp.Text

        Dim tw As System.IO.TextWriter = New System.IO.StreamWriter(ifile, True)
        tw.WriteLine(strExport)
        tw.Close()

        MessageBox.Show("Agrego una Lectura", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Chart1.Series.Clear()

    End Sub

    Sub limpiar()

        Grid.Rows.Clear()
        'TextoAlmacen.Text = ""
        ComboLectura.Text = ""
        ComboLectura.Text = "3"
        ComboDist.Text = "1"
        ComboComp.Text = "N"
        TextoAjuste.Text = ""
        CheckAdelantar.Checked = False
        TextoDiasAgregar.Text = ""

    End Sub

    Private Sub BotonBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        historial()

    End Sub

    'Private Sub TextoAlmacen_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then

    '        historial()

    '        ComboLectura.Focus()

    '        e.Handled = True
    '    End If
    'End Sub

    'Private Sub ComboLectura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then

    '        modificar()

    '        e.Handled = True
    '    End If
    'End Sub

    Sub ruta()

        If System.IO.File.Exists(efile) = True Then

            Dim TextFieldParser1 As New Microsoft.VisualBasic.FileIO.TextFieldParser(efile)

            TextFieldParser1.Delimiters = New String() {","}

            Grid.Rows.Clear()

            While Not TextFieldParser1.EndOfData
                Dim Row1 As String() = TextFieldParser1.ReadFields()

                If TextoAlmacen.Text = "" Then

                    TextoAlmacen.Text = Row1(1)
                    Exit While

                Else

                    If TextoAlmacen.Text = Row1(1) Then

                        TextoAlmacen.Text = Row1(12)
                        Exit While

                    End If

                End If

            End While

            historial()

        End If


    End Sub

    Sub historial()

        If System.IO.File.Exists(efile) = True Then

            Dim TextFieldParser1 As New Microsoft.VisualBasic.FileIO.TextFieldParser(efile)

            TextFieldParser1.Delimiters = New String() {","}

            Grid.Rows.Clear()
            EtiquetaDias.Text = ""

            While Not TextFieldParser1.EndOfData
                Dim Row1 As String() = TextFieldParser1.ReadFields()

                If TextoAlmacen.Text = Row1(1) Then
                    Grid.Rows.Add(Mid(Row1(0), 7, 2) + "-" + Mid(Row1(0), 5, 2) + "-" + Mid(Row1(0), 1, 4), Row1(1), Row1(4), Row1(3), Row1(13), Row1(8), "", Row1(5), Row1(6), "", "", "", "", "", Row1(9), "", Row1(2))
                    EtiquetaDias.Text = Row1(10)
                    EtiquetaRacAct.Text = Row1(14)
                    EtiquetaFechaFinRac.Text = Mid(Row1(15), 7, 2) + "/" + Mid(Row1(15), 5, 2) + "/" + Mid(Row1(15), 1, 4)

                End If

            End While




            calculos()

            graficar()

            diasfinal()

        End If

    End Sub

    Sub lee()

        Dim vAdelantar As Boolean

        If System.IO.File.Exists(ifile) = True Then

            Dim TextFieldParser1 As New Microsoft.VisualBasic.FileIO.TextFieldParser(ifile)

            TextFieldParser1.Delimiters = New String() {","}

            While Not TextFieldParser1.EndOfData
                Dim Row1 As String() = TextFieldParser1.ReadFields()

                If Row1(1) = TextoAlmacen.Text Then

                    ComboLectura.Text = Row1(3)
                    TextoAjuste.Text = Row1(5)
                    EtiquetaRacAct.Text = Row1(7)
                    TextoDiasAgregar.Text = Row1(8)

                    ComboDist.Text = Row1(9)
                    ComboComp.Text = Row1(10)

                    If Row1(6) = "1" Then
                        vAdelantar = True
                    Else
                        vAdelantar = False
                    End If

                    CheckAdelantar.Checked = vAdelantar

                End If

            End While

        End If

    End Sub

    Sub visualizar()

        Dim vAdelantar As Boolean

        If System.IO.File.Exists(ifile) = True Then

            Dim TextFieldParser1 As New Microsoft.VisualBasic.FileIO.TextFieldParser(ifile)

            TextFieldParser1.Delimiters = New String() {","}

            GridLectura.Rows.Clear()

            While Not TextFieldParser1.EndOfData
                Dim Row1 As String() = TextFieldParser1.ReadFields()

                If Row1(6) = "1" Then
                    vAdelantar = True
                Else
                    vAdelantar = False
                End If

                GridLectura.Rows.Add(Row1(1), Row1(3), Row1(4), Row1(5), vAdelantar, Row1(7), Row1(8), Row1(9), Row1(10))

            End While

            'GridLectura.Rows(i - 1).Selected = True
            'GridLectura.CurrentCell = GridLectura.Rows(i - 1).Cells(0)

            GridLectura.Rows(GridLectura.Rows.Count - 1).Selected = True
            GridLectura.CurrentCell = GridLectura.Rows(GridLectura.Rows.Count - 1).Cells(0)


        End If

    End Sub

    Sub modificar()

        Dim i As Integer
        Dim b As Boolean = False
        Dim vAdelantar As String
        Dim cont As Integer
        Dim alm As String

        If TextoAlmacen.Text = "" Then
            MessageBox.Show("Elija un Almacen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextoAlmacen.Focus()
            GoTo Salir
        End If

        If Len(TextoAlmacen.Text) <> 4 Then
            MessageBox.Show("4 Caracteres el Almacen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextoAlmacen.Focus()
            GoTo Salir
        End If

        If ComboLectura.Text = "" Then
            MessageBox.Show("Elija una Lectura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ComboLectura.Focus()
            GoTo Salir
        End If

        If ComboDist.Text = "" Then
            MessageBox.Show("Elija una Calif", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ComboDist.Focus()
            GoTo Salir
        End If

        If (ComboLectura.Text = "0" Or ComboLectura.Text = "6") And Len(TextoAjuste.Text) = 0 Then
            MessageBox.Show("Agregue peso ajuste", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextoAjuste.Focus()
            GoTo Salir
        End If

        If System.IO.File.Exists(ifile) = False Then
            GoTo graba
        End If

        Dim lines() As String = IO.File.ReadAllLines(ifile)
        For x As Integer = 0 To lines.GetUpperBound(0)

            alm = "," + TextoAlmacen.Text + ","

            If lines(x).Contains(alm) Then
                b = True
                cont = 0
                For i = 1 To Len(lines(x))

                    If Mid(lines(x), i, 1) = "," Then
                        cont = cont + 1
                        If cont = 3 Then
                            GoTo salta
                        End If
                    End If

                Next
Salta:
                If TextoAjuste.Text = "" Then
                    TextoAjuste.Text = "0"
                End If

                TextoDiasAgregar.Text = TextoDiasAgregar.Text.TrimStart("0")

                If Len(TextoDiasAgregar.Text) = 0 Then
                    TextoDiasAgregar.Text = "0"
                End If

                If CheckAdelantar.Checked Then
                    vAdelantar = "1"
                Else
                    vAdelantar = "0"
                End If

                lines(x) = Mid(lines(x), 1, i) + ComboLectura.Text + "," + Now.TimeOfDay.ToString + "," + TextoAjuste.Text + "," + vAdelantar + "," + EtiquetaRacAct.Text + "," + TextoDiasAgregar.Text + "," + ComboDist.Text + "," + ComboComp.Text

            End If

        Next


        If b Then
            'modificar
            IO.File.WriteAllLines(ifile, lines)

            MessageBox.Show("Modifico una Lectura", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Chart1.Series.Clear()

        Else
Graba:
            'insertar
            grabar()

            'GridLectura.Rows(GridLectura.Rows.Count - 1).Selected = True
            'GridLectura.CurrentCell = GridLectura.Rows(GridLectura.Rows.Count - 1).Cells(0)

        End If

        limpiar()
        visualizar()
        TextoAlmacen.Focus()

Salir:

    End Sub

    Sub graficar()

        Dim mayor As Double
        Dim menor As Double
        Dim valor As Double

        Dim cadena As String = Grid.Columns("servido").HeaderText
        Dim cadena1 As String = Grid.Columns("maximo").HeaderText
        Dim cadena2 As String = Grid.Columns("minimo").HeaderText

        Chart1.Series.Clear()

        If Grid.RowCount > 0 Then

            Chart1.Series.Add(cadena)
            Chart1.Series.Add(cadena1)
            Chart1.Series.Add(cadena2)

            Chart1.Series(cadena).ChartType = DataVisualization.Charting.SeriesChartType.Spline
            Chart1.Series(cadena1).ChartType = DataVisualization.Charting.SeriesChartType.Spline
            Chart1.Series(cadena2).ChartType = DataVisualization.Charting.SeriesChartType.Spline

            Chart1.Series(cadena).Points.Clear()
            Chart1.Series(cadena1).Points.Clear()
            Chart1.Series(cadena2).Points.Clear()

            Chart1.Series(cadena).Color = Color.Blue
            Chart1.Series(cadena1).Color = Color.Red
            Chart1.Series(cadena2).Color = Color.Yellow

            Chart1.Series(cadena).IsValueShownAsLabel = True
            Chart1.Series(cadena1).IsValueShownAsLabel = True
            Chart1.Series(cadena2).IsValueShownAsLabel = True

            For i As Integer = Grid.RowCount - 1 To 0 Step -1

                Chart1.Series(cadena).Points.AddXY(Mid(Grid.Rows(i).Cells("fecha").Value, 1, 2), Grid.Rows(i).Cells("servido").Value)
                Chart1.Series(cadena1).Points.AddXY(Mid(Grid.Rows(i).Cells("fecha").Value, 1, 2), Grid.Rows(i).Cells("maximo").Value)
                Chart1.Series(cadena2).Points.AddXY(Mid(Grid.Rows(i).Cells("fecha").Value, 1, 2), Grid.Rows(i).Cells("minimo").Value)

            Next

            Chart1.ChartAreas(0).AxisX.Interval = 1

            mayor = Grid.Rows(0).Cells("servido").Value()

            For i As Integer = 1 To Grid.RowCount - 1

                valor = Grid.Rows(i).Cells("servido").Value()
                If valor > mayor Then
                    mayor = valor
                End If

            Next

            menor = Grid.Rows(0).Cells("servido").Value()

            For i As Integer = 1 To Grid.RowCount - 1

                valor = Grid.Rows(i).Cells("servido").Value()
                If valor < menor Then
                    menor = valor
                End If

            Next

            Chart1.ChartAreas(0).AxisY.Minimum = menor - 50
            Chart1.ChartAreas(0).AxisY.Maximum = mayor + 50
            Chart1.ChartAreas(0).AxisY.Interval = 100


        End If


    End Sub

    Sub calculos()

        Dim suma As Double
        Dim i, j As Integer

        For i = 0 To Grid.RowCount - 1

            suma = 0

            For j = 0 To 3
                If i + j <= Grid.RowCount - 1 Then
                    suma = suma + Grid.Rows(i + j).Cells("servido").Value()
                    'j = j + 1
                Else
                    GoTo salte
                End If

            Next

Salte:
            If j > 0 Then
                'servidoprom
                Grid.Rows(i).Cells("promedio").Value = String.Format("{0:0.000}", suma / j)
            Else
                Grid.Rows(i).Cells("promedio").Value = "0"
            End If

            'max
            Grid.Rows(i).Cells("maximo").Value = String.Format("{0:0.000}", Grid.Rows(i).Cells("promedio").Value * 1.015)

            'min
            Grid.Rows(i).Cells("minimo").Value = String.Format("{0:0.000}", Grid.Rows(i).Cells("promedio").Value * 0.985)

            'variacionord
            Grid.Rows(i).Cells("variacionord").Value = String.Format("{0:0.00%}", (Grid.Rows(i).Cells("servido").Value - Grid.Rows(i).Cells("planeado").Value) / Grid.Rows(i).Cells("planeado").Value)

            If i > 0 Then
                'variacionant
                Grid.Rows(i).Cells("variacionant").Value = String.Format("{0:0.00%}", (Grid.Rows(i).Cells("servido").Value - Grid.Rows(i - 1).Cells("servido").Value) / Grid.Rows(i - 1).Cells("servido").Value)
            End If

            'pp%
            Grid.Rows(i).Cells("pesopromp").Value = String.Format("{0:0.00%}", (Grid.Rows(i).Cells("servido").Value / Grid.Rows(i).Cells("cabezas").Value) / Grid.Rows(i).Cells("pesoprom").Value)

            'pesoprom
            Grid.Rows(i).Cells("pesoprom").Value = String.Format("{0:0.000}", Grid.Rows(i).Cells("pesoprom").Value / 1)

            'pp%
            Grid.Rows(i).Cells("servidoprom").Value = String.Format("{0:0.000}", (Grid.Rows(i).Cells("servido").Value / Grid.Rows(i).Cells("cabezas").Value))

        Next


    End Sub

    Private Sub BotonBuscar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonBuscar.Click

        busca()

    End Sub

    Sub busca()

        historial()

        lee()

    End Sub

    Private Sub BotonGrabar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonGrabar.Click

        modificar()

        ruta()

    End Sub

    Private Sub TextoAlmacen_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextoAlmacen.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then

            historial()

            lee()

            ComboLectura.Focus()

            e.Handled = True
        End If

    End Sub

    Private Sub ComboLectura_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboLectura.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then


            Select Case ComboLectura.Text
                Case "0", "6"
                    TextoAjuste.Enabled = True
                    TextoAjuste.Focus()
                Case Else
                    TextoAjuste.Enabled = False
                    'BotonGrabar.Focus()
                    ComboDist.Focus()
                    'modificar()
            End Select

            e.Handled = True
        End If
    End Sub

    Private Sub TextoAjuste_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextoAjuste.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then

            ComboDist.Focus()
            'BotonGrabar.Focus()
            'modificar()

            e.Handled = True
        End If
    End Sub

    Private Sub ComboLectura_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboLectura.SelectedIndexChanged

        Select Case ComboLectura.Text
            Case "0", "6"
                TextoAjuste.Enabled = True
            Case Else
                TextoAjuste.Enabled = False
        End Select

    End Sub

    Private Sub ComboDist_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboDist.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            ComboComp.Focus()
        End If

    End Sub

    Public Sub Numeros(ByVal CajaTexto As Windows.Forms.TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub TextoDiasAgregar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextoDiasAgregar.KeyPress
        Numeros(TextoDiasAgregar, e)
    End Sub

    Private Sub TextoDiasAgregar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextoDiasAgregar.TextChanged

        diasfinal()

    End Sub

    Sub diasfinal()

        Dim fecha1 As Date
        Dim dias1 As Long



        If EtiquetaRacAct.Text = "R4" Or EtiquetaRacAct.Text = "R5" Or EtiquetaRacAct.Text = "R6" Then
            TextoDiasAgregar.Text = "0"
            TextoDiasAgregar.Enabled = False

            CheckAdelantar.Enabled = False
            CheckAdelantar.Checked = False

        Else

            If EtiquetaFechaFinRac.Text <> "00/00/0000" Then
                fecha1 = EtiquetaFechaFinRac.Text
                dias1 = IIf(TextoDiasAgregar.Text <> "", TextoDiasAgregar.Text, "0")
                fecha1 = fecha1.AddDays(dias1)
                EtiquetaFechaFinNva.Text = fecha1
                TextoDiasAgregar.Enabled = True
            Else
                EtiquetaFechaFinNva.Text = "00/00/0000"
                TextoDiasAgregar.Enabled = False
            End If

            If dias1 = 0 Then
                CheckAdelantar.Enabled = True
            Else
                CheckAdelantar.Enabled = False
                CheckAdelantar.Checked = False
            End If

        End If


    End Sub

    Private Sub ComboComp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboComp.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            BotonGrabar.Focus()
        End If
    End Sub

    'Private Sub GridLectura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles GridLectura.KeyPress
    '    If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
    '        TextoAlmacen.Focus()
    '    End If
    'End Sub

    'Private Sub GridLectura_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridLectura.CellClick
    '    grid_mostrar()
    'End Sub

    Private Sub GridLectura_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridLectura.SelectionChanged
        If GridLectura.Focused Then
            grid_mostrar()
        End If

    End Sub

    Sub grid_mostrar()

        If GridLectura.RowCount > 0 Then
            TextoAlmacen.Text = GridLectura.Item(0, GridLectura.CurrentCell.RowIndex).Value
            busca()
        End If

    End Sub



    Private Sub GridLectura_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridLectura.CellContentClick

    End Sub

    Private Sub TextoAlmacen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextoAlmacen.TextChanged

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Function bitModo() As String

        Dim valor As String = ""

        If IntPtr.Size = 8 Then

            valor = " 64 bits"

        ElseIf IntPtr.Size = 4 Then

            valor = " 32 bits"
        End If

        bitModo = valor

    End Function


End Class