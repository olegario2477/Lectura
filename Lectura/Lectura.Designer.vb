<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Lectura
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lectura))
        Me.Grid = New System.Windows.Forms.DataGridView()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Almacen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Racion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lectura2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Calif = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cabezas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServidoProm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Planeado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Servido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Minimo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Promedio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Maximo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VariacionOrd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VariacionAnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PesoProm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PesoPromP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoteEng = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GridLectura = New System.Windows.Forms.DataGridView()
        Me.Almacen1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lectura1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hora1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ajuste = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Adelantar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.RacAct = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiasAgr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dist = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboComp = New System.Windows.Forms.ComboBox()
        Me.EtiquetaFechaFinNva = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextoDiasAgregar = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.EtiquetaFechaFinRac = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.EtiquetaRacAct = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CheckAdelantar = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboDist = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EtiquetaDias = New System.Windows.Forms.Label()
        Me.Lbl_Ajuste = New System.Windows.Forms.Label()
        Me.TextoAjuste = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EtiquetaFecha = New System.Windows.Forms.Label()
        Me.BotonBuscar = New System.Windows.Forms.Button()
        Me.TextoAlmacen = New System.Windows.Forms.TextBox()
        Me.EtiquetaAlmacen = New System.Windows.Forms.Label()
        Me.ComboLectura = New System.Windows.Forms.ComboBox()
        Me.BotonGrabar = New System.Windows.Forms.Button()
        Me.EtiquetaLectura = New System.Windows.Forms.Label()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLectura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grid
        '
        Me.Grid.AllowUserToAddRows = False
        Me.Grid.AllowUserToDeleteRows = False
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Fecha, Me.Almacen, Me.Racion, Me.Lectura2, Me.Calif, Me.Cabezas, Me.ServidoProm, Me.Planeado, Me.Servido, Me.Minimo, Me.Promedio, Me.Maximo, Me.VariacionOrd, Me.VariacionAnt, Me.PesoProm, Me.PesoPromP, Me.LoteEng})
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Grid.Location = New System.Drawing.Point(0, 425)
        Me.Grid.Name = "Grid"
        Me.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grid.Size = New System.Drawing.Size(1018, 94)
        Me.Grid.TabIndex = 4
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Fecha.Width = 80
        '
        'Almacen
        '
        Me.Almacen.HeaderText = "Almacen"
        Me.Almacen.Name = "Almacen"
        Me.Almacen.ReadOnly = True
        Me.Almacen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Almacen.Width = 50
        '
        'Racion
        '
        Me.Racion.HeaderText = "Racion"
        Me.Racion.Name = "Racion"
        Me.Racion.ReadOnly = True
        Me.Racion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Racion.Width = 50
        '
        'Lectura2
        '
        Me.Lectura2.HeaderText = "Lectura"
        Me.Lectura2.Name = "Lectura2"
        Me.Lectura2.ReadOnly = True
        Me.Lectura2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Lectura2.Width = 50
        '
        'Calif
        '
        Me.Calif.HeaderText = "Distribucion"
        Me.Calif.Name = "Calif"
        Me.Calif.ReadOnly = True
        Me.Calif.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Calif.Width = 50
        '
        'Cabezas
        '
        Me.Cabezas.HeaderText = "Cabezas"
        Me.Cabezas.Name = "Cabezas"
        Me.Cabezas.ReadOnly = True
        Me.Cabezas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Cabezas.Width = 60
        '
        'ServidoProm
        '
        Me.ServidoProm.HeaderText = "ServidoProm"
        Me.ServidoProm.Name = "ServidoProm"
        Me.ServidoProm.ReadOnly = True
        Me.ServidoProm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ServidoProm.Width = 70
        '
        'Planeado
        '
        Me.Planeado.HeaderText = "Planeado"
        Me.Planeado.Name = "Planeado"
        Me.Planeado.ReadOnly = True
        Me.Planeado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Planeado.Width = 60
        '
        'Servido
        '
        Me.Servido.HeaderText = "Servido"
        Me.Servido.Name = "Servido"
        Me.Servido.ReadOnly = True
        Me.Servido.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Servido.Width = 60
        '
        'Minimo
        '
        Me.Minimo.HeaderText = "Minimo"
        Me.Minimo.Name = "Minimo"
        Me.Minimo.ReadOnly = True
        Me.Minimo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Minimo.Width = 80
        '
        'Promedio
        '
        Me.Promedio.HeaderText = "Promedio"
        Me.Promedio.Name = "Promedio"
        Me.Promedio.ReadOnly = True
        Me.Promedio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Promedio.Width = 80
        '
        'Maximo
        '
        Me.Maximo.HeaderText = "Maximo"
        Me.Maximo.Name = "Maximo"
        Me.Maximo.ReadOnly = True
        Me.Maximo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Maximo.Width = 80
        '
        'VariacionOrd
        '
        Me.VariacionOrd.HeaderText = "VariacionOrd"
        Me.VariacionOrd.Name = "VariacionOrd"
        Me.VariacionOrd.ReadOnly = True
        Me.VariacionOrd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.VariacionOrd.Width = 80
        '
        'VariacionAnt
        '
        Me.VariacionAnt.HeaderText = "VariacionAnt"
        Me.VariacionAnt.Name = "VariacionAnt"
        Me.VariacionAnt.ReadOnly = True
        Me.VariacionAnt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.VariacionAnt.Width = 80
        '
        'PesoProm
        '
        Me.PesoProm.HeaderText = "PesoProm"
        Me.PesoProm.Name = "PesoProm"
        Me.PesoProm.ReadOnly = True
        Me.PesoProm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.PesoProm.Width = 60
        '
        'PesoPromP
        '
        Me.PesoPromP.HeaderText = "PesoProm%"
        Me.PesoPromP.Name = "PesoPromP"
        Me.PesoPromP.ReadOnly = True
        Me.PesoPromP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.PesoPromP.Width = 60
        '
        'LoteEng
        '
        Me.LoteEng.HeaderText = "LoteEng"
        Me.LoteEng.Name = "LoteEng"
        Me.LoteEng.ReadOnly = True
        Me.LoteEng.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.LoteEng.Width = 80
        '
        'GridLectura
        '
        Me.GridLectura.AllowUserToAddRows = False
        Me.GridLectura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridLectura.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Almacen1, Me.Lectura1, Me.Hora1, Me.Ajuste, Me.Adelantar, Me.RacAct, Me.DiasAgr, Me.Dist, Me.Comp})
        Me.GridLectura.Dock = System.Windows.Forms.DockStyle.Right
        Me.GridLectura.Location = New System.Drawing.Point(633, 0)
        Me.GridLectura.MultiSelect = False
        Me.GridLectura.Name = "GridLectura"
        Me.GridLectura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridLectura.Size = New System.Drawing.Size(385, 425)
        Me.GridLectura.TabIndex = 8
        '
        'Almacen1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Almacen1.DefaultCellStyle = DataGridViewCellStyle1
        Me.Almacen1.Frozen = True
        Me.Almacen1.HeaderText = "Almacen"
        Me.Almacen1.Name = "Almacen1"
        Me.Almacen1.ReadOnly = True
        Me.Almacen1.Width = 55
        '
        'Lectura1
        '
        Me.Lectura1.HeaderText = "Lectura"
        Me.Lectura1.Name = "Lectura1"
        Me.Lectura1.ReadOnly = True
        Me.Lectura1.Width = 50
        '
        'Hora1
        '
        Me.Hora1.HeaderText = "Hora"
        Me.Hora1.Name = "Hora1"
        Me.Hora1.ReadOnly = True
        Me.Hora1.Width = 50
        '
        'Ajuste
        '
        Me.Ajuste.HeaderText = "Ajuste"
        Me.Ajuste.Name = "Ajuste"
        Me.Ajuste.ReadOnly = True
        Me.Ajuste.Width = 60
        '
        'Adelantar
        '
        Me.Adelantar.HeaderText = "AdelantaR"
        Me.Adelantar.Name = "Adelantar"
        Me.Adelantar.ReadOnly = True
        Me.Adelantar.Width = 60
        '
        'RacAct
        '
        Me.RacAct.HeaderText = "RacAct"
        Me.RacAct.Name = "RacAct"
        Me.RacAct.ReadOnly = True
        Me.RacAct.Width = 50
        '
        'DiasAgr
        '
        Me.DiasAgr.HeaderText = "DiasAgr"
        Me.DiasAgr.Name = "DiasAgr"
        Me.DiasAgr.ReadOnly = True
        Me.DiasAgr.Width = 50
        '
        'Dist
        '
        Me.Dist.HeaderText = "Dist"
        Me.Dist.Name = "Dist"
        Me.Dist.ReadOnly = True
        Me.Dist.Width = 50
        '
        'Comp
        '
        Me.Comp.HeaderText = "Comp"
        Me.Comp.Name = "Comp"
        Me.Comp.ReadOnly = True
        Me.Comp.Width = 50
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.Transparent
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Bottom
        Legend1.Alignment = System.Drawing.StringAlignment.Far
        Legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(0, 158)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(633, 267)
        Me.Chart1.TabIndex = 9
        Me.Chart1.Text = "Chart1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.ComboComp)
        Me.Panel1.Controls.Add(Me.EtiquetaFechaFinNva)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.TextoDiasAgregar)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.EtiquetaFechaFinRac)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.EtiquetaRacAct)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.CheckAdelantar)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ComboDist)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.EtiquetaDias)
        Me.Panel1.Controls.Add(Me.Lbl_Ajuste)
        Me.Panel1.Controls.Add(Me.TextoAjuste)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.EtiquetaFecha)
        Me.Panel1.Controls.Add(Me.BotonBuscar)
        Me.Panel1.Controls.Add(Me.TextoAlmacen)
        Me.Panel1.Controls.Add(Me.EtiquetaAlmacen)
        Me.Panel1.Controls.Add(Me.ComboLectura)
        Me.Panel1.Controls.Add(Me.BotonGrabar)
        Me.Panel1.Controls.Add(Me.EtiquetaLectura)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(863, 86)
        Me.Panel1.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(688, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 17)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Comp"
        '
        'ComboComp
        '
        Me.ComboComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboComp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboComp.FormattingEnabled = True
        Me.ComboComp.Items.AddRange(New Object() {"N", "A", "T"})
        Me.ComboComp.Location = New System.Drawing.Point(738, 11)
        Me.ComboComp.Name = "ComboComp"
        Me.ComboComp.Size = New System.Drawing.Size(47, 24)
        Me.ComboComp.TabIndex = 14
        '
        'EtiquetaFechaFinNva
        '
        Me.EtiquetaFechaFinNva.AutoSize = True
        Me.EtiquetaFechaFinNva.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.EtiquetaFechaFinNva.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtiquetaFechaFinNva.Location = New System.Drawing.Point(679, 44)
        Me.EtiquetaFechaFinNva.Name = "EtiquetaFechaFinNva"
        Me.EtiquetaFechaFinNva.Size = New System.Drawing.Size(14, 19)
        Me.EtiquetaFechaFinNva.TabIndex = 30
        Me.EtiquetaFechaFinNva.Text = " "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(578, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 17)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Fecha Fin Nva"
        '
        'TextoDiasAgregar
        '
        Me.TextoDiasAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoDiasAgregar.Location = New System.Drawing.Point(533, 39)
        Me.TextoDiasAgregar.MaxLength = 3
        Me.TextoDiasAgregar.Name = "TextoDiasAgregar"
        Me.TextoDiasAgregar.Size = New System.Drawing.Size(31, 23)
        Me.TextoDiasAgregar.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(438, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 17)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Dias Agregar"
        '
        'EtiquetaFechaFinRac
        '
        Me.EtiquetaFechaFinRac.AutoSize = True
        Me.EtiquetaFechaFinRac.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.EtiquetaFechaFinRac.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtiquetaFechaFinRac.Location = New System.Drawing.Point(347, 41)
        Me.EtiquetaFechaFinRac.Name = "EtiquetaFechaFinRac"
        Me.EtiquetaFechaFinRac.Size = New System.Drawing.Size(14, 19)
        Me.EtiquetaFechaFinRac.TabIndex = 26
        Me.EtiquetaFechaFinRac.Text = " "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(229, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 17)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Fecha Fin Racion"
        '
        'EtiquetaRacAct
        '
        Me.EtiquetaRacAct.AutoSize = True
        Me.EtiquetaRacAct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.EtiquetaRacAct.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtiquetaRacAct.Location = New System.Drawing.Point(199, 41)
        Me.EtiquetaRacAct.Name = "EtiquetaRacAct"
        Me.EtiquetaRacAct.Size = New System.Drawing.Size(14, 19)
        Me.EtiquetaRacAct.TabIndex = 24
        Me.EtiquetaRacAct.Text = " "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(98, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 17)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Racion Actual"
        '
        'CheckAdelantar
        '
        Me.CheckAdelantar.AutoSize = True
        Me.CheckAdelantar.Location = New System.Drawing.Point(52, 66)
        Me.CheckAdelantar.Name = "CheckAdelantar"
        Me.CheckAdelantar.Size = New System.Drawing.Size(108, 17)
        Me.CheckAdelantar.TabIndex = 22
        Me.CheckAdelantar.Text = "Adelantar Racion"
        Me.CheckAdelantar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(597, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 17)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Dist"
        '
        'ComboDist
        '
        Me.ComboDist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboDist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboDist.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboDist.FormattingEnabled = True
        Me.ComboDist.Items.AddRange(New Object() {"1", "2", "3"})
        Me.ComboDist.Location = New System.Drawing.Point(633, 10)
        Me.ComboDist.Name = "ComboDist"
        Me.ComboDist.Size = New System.Drawing.Size(44, 24)
        Me.ComboDist.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 17)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Dias"
        '
        'EtiquetaDias
        '
        Me.EtiquetaDias.AutoSize = True
        Me.EtiquetaDias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.EtiquetaDias.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtiquetaDias.Location = New System.Drawing.Point(52, 40)
        Me.EtiquetaDias.Name = "EtiquetaDias"
        Me.EtiquetaDias.Size = New System.Drawing.Size(18, 19)
        Me.EtiquetaDias.TabIndex = 18
        Me.EtiquetaDias.Text = "  "
        '
        'Lbl_Ajuste
        '
        Me.Lbl_Ajuste.AutoSize = True
        Me.Lbl_Ajuste.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Ajuste.Location = New System.Drawing.Point(474, 14)
        Me.Lbl_Ajuste.Name = "Lbl_Ajuste"
        Me.Lbl_Ajuste.Size = New System.Drawing.Size(47, 17)
        Me.Lbl_Ajuste.TabIndex = 17
        Me.Lbl_Ajuste.Text = "Ajuste"
        '
        'TextoAjuste
        '
        Me.TextoAjuste.Enabled = False
        Me.TextoAjuste.Location = New System.Drawing.Point(527, 14)
        Me.TextoAjuste.Name = "TextoAjuste"
        Me.TextoAjuste.Size = New System.Drawing.Size(56, 20)
        Me.TextoAjuste.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Fecha"
        '
        'EtiquetaFecha
        '
        Me.EtiquetaFecha.AutoSize = True
        Me.EtiquetaFecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.EtiquetaFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtiquetaFecha.Location = New System.Drawing.Point(52, 13)
        Me.EtiquetaFecha.Name = "EtiquetaFecha"
        Me.EtiquetaFecha.Size = New System.Drawing.Size(14, 19)
        Me.EtiquetaFecha.TabIndex = 14
        Me.EtiquetaFecha.Text = " "
        '
        'BotonBuscar
        '
        Me.BotonBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonBuscar.Location = New System.Drawing.Point(264, 10)
        Me.BotonBuscar.Name = "BotonBuscar"
        Me.BotonBuscar.Size = New System.Drawing.Size(67, 25)
        Me.BotonBuscar.TabIndex = 10
        Me.BotonBuscar.Text = "Buscar"
        Me.BotonBuscar.UseVisualStyleBackColor = True
        '
        'TextoAlmacen
        '
        Me.TextoAlmacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoAlmacen.Location = New System.Drawing.Point(202, 10)
        Me.TextoAlmacen.Name = "TextoAlmacen"
        Me.TextoAlmacen.Size = New System.Drawing.Size(56, 23)
        Me.TextoAlmacen.TabIndex = 8
        '
        'EtiquetaAlmacen
        '
        Me.EtiquetaAlmacen.AutoSize = True
        Me.EtiquetaAlmacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtiquetaAlmacen.Location = New System.Drawing.Point(143, 11)
        Me.EtiquetaAlmacen.Name = "EtiquetaAlmacen"
        Me.EtiquetaAlmacen.Size = New System.Drawing.Size(62, 17)
        Me.EtiquetaAlmacen.TabIndex = 13
        Me.EtiquetaAlmacen.Text = "Almacen"
        '
        'ComboLectura
        '
        Me.ComboLectura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboLectura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboLectura.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboLectura.FormattingEnabled = True
        Me.ComboLectura.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6"})
        Me.ComboLectura.Location = New System.Drawing.Point(396, 11)
        Me.ComboLectura.Name = "ComboLectura"
        Me.ComboLectura.Size = New System.Drawing.Size(65, 24)
        Me.ComboLectura.TabIndex = 11
        '
        'BotonGrabar
        '
        Me.BotonGrabar.BackColor = System.Drawing.Color.Gold
        Me.BotonGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonGrabar.Location = New System.Drawing.Point(791, 11)
        Me.BotonGrabar.Name = "BotonGrabar"
        Me.BotonGrabar.Size = New System.Drawing.Size(62, 33)
        Me.BotonGrabar.TabIndex = 15
        Me.BotonGrabar.Text = "Grabar"
        Me.BotonGrabar.UseVisualStyleBackColor = False
        '
        'EtiquetaLectura
        '
        Me.EtiquetaLectura.AutoSize = True
        Me.EtiquetaLectura.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtiquetaLectura.Location = New System.Drawing.Point(337, 11)
        Me.EtiquetaLectura.Name = "EtiquetaLectura"
        Me.EtiquetaLectura.Size = New System.Drawing.Size(56, 17)
        Me.EtiquetaLectura.TabIndex = 9
        Me.EtiquetaLectura.Text = "Lectura"
        '
        'Lectura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1018, 519)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.GridLectura)
        Me.Controls.Add(Me.Grid)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Lectura"
        Me.Text = "Lectura"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLectura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Grid As System.Windows.Forms.DataGridView
    Friend WithEvents GridLectura As System.Windows.Forms.DataGridView
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents EtiquetaFecha As System.Windows.Forms.Label
    Friend WithEvents BotonBuscar As System.Windows.Forms.Button
    Friend WithEvents TextoAlmacen As System.Windows.Forms.TextBox
    Friend WithEvents EtiquetaAlmacen As System.Windows.Forms.Label
    Friend WithEvents ComboLectura As System.Windows.Forms.ComboBox
    Friend WithEvents BotonGrabar As System.Windows.Forms.Button
    Friend WithEvents EtiquetaLectura As System.Windows.Forms.Label
    Friend WithEvents Lbl_Ajuste As System.Windows.Forms.Label
    Friend WithEvents TextoAjuste As System.Windows.Forms.TextBox
    Friend WithEvents EtiquetaDias As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Almacen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Racion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Lectura2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Calif As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cabezas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServidoProm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Planeado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Servido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Minimo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Promedio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Maximo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VariacionOrd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VariacionAnt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PesoProm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PesoPromP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoteEng As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComboDist As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CheckAdelantar As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents EtiquetaRacAct As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents EtiquetaFechaFinRac As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextoDiasAgregar As System.Windows.Forms.TextBox
    Friend WithEvents EtiquetaFechaFinNva As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ComboComp As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Almacen1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Lectura1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hora1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ajuste As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Adelantar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RacAct As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiasAgr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dist As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Comp As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
