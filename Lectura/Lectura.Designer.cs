using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Lectura
{
    [DesignerGenerated()]
    public partial class Lectura : Form
    {

        // Form reemplaza a Dispose para limpiar la lista de componentes.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            if (disposing && components is object)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        // Requerido por el Diseñador de Windows Forms
        private System.ComponentModel.IContainer components;

        // NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
        // Se puede modificar usando el Diseñador de Windows Forms.  
        // No lo modifique con el editor de código.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle106 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle107 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle108 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle109 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle110 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle111 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle112 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle113 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle114 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle115 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle116 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle117 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle118 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle119 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle120 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lectura));
            this.Grid = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Almacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Racion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lectura2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cabezas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServidoProm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Planeado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Servido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Minimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Promedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maximo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VariacionOrd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VariacionAnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PesoProm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PesoPromP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoteEng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._GridLectura = new System.Windows.Forms.DataGridView();
            this.Almacen1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Envio = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Lectura1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ajuste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adelantar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RacAct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiasAgr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this._PanelLecturas = new System.Windows.Forms.Panel();
            this.Label5 = new System.Windows.Forms.Label();
            this._ComboComp = new System.Windows.Forms.ComboBox();
            this.EtiquetaFechaFinNva = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this._TextoDiasAgregar = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.EtiquetaFechaFinRac = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.EtiquetaRacAct = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.CheckAdelantar = new System.Windows.Forms.CheckBox();
            this.Label2 = new System.Windows.Forms.Label();
            this._ComboDist = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.EtiquetaDias = new System.Windows.Forms.Label();
            this.Lbl_Ajuste = new System.Windows.Forms.Label();
            this._TextoAjuste = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.EtiquetaFecha = new System.Windows.Forms.Label();
            this._BotonBuscar = new System.Windows.Forms.Button();
            this._TextoAlmacen = new System.Windows.Forms.TextBox();
            this.EtiquetaAlmacen = new System.Windows.Forms.Label();
            this._ComboLectura = new System.Windows.Forms.ComboBox();
            this._BotonGrabar = new System.Windows.Forms.Button();
            this.EtiquetaLectura = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblErrores = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelConfiguracion = new System.Windows.Forms.Panel();
            this.btnUbicaciones = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEquipo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnCerrarConfiguracion = new System.Windows.Forms.Button();
            this.btnGuardarConfiguracion = new System.Windows.Forms.Button();
            this.lblEsperar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tcFechas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblCorral = new System.Windows.Forms.Label();
            this.panelGrafica = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelMapa = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.btnServida = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnRecibir = new System.Windows.Forms.ToolStripButton();
            this.btnEnviar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCargar = new System.Windows.Forms.ToolStripButton();
            this.btnGenerar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfigurar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.lblZoom = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._GridLectura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this._PanelLecturas.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panelConfiguracion.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tcFechas.SuspendLayout();
            this.panelGrafica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelMapa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Almacen,
            this.Racion,
            this.Lectura2,
            this.Calif,
            this.Cabezas,
            this.ServidoProm,
            this.Planeado,
            this.Servido,
            this.Minimo,
            this.Promedio,
            this.Maximo,
            this.VariacionOrd,
            this.VariacionAnt,
            this.PesoProm,
            this.PesoPromP,
            this.LoteEng});
            this.Grid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Grid.Location = new System.Drawing.Point(0, 403);
            this.Grid.Name = "Grid";
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(608, 94);
            this.Grid.TabIndex = 4;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Fecha.Width = 80;
            // 
            // Almacen
            // 
            this.Almacen.HeaderText = "Almacen";
            this.Almacen.Name = "Almacen";
            this.Almacen.ReadOnly = true;
            this.Almacen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Almacen.Width = 50;
            // 
            // Racion
            // 
            this.Racion.HeaderText = "Racion";
            this.Racion.Name = "Racion";
            this.Racion.ReadOnly = true;
            this.Racion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Racion.Width = 50;
            // 
            // Lectura2
            // 
            dataGridViewCellStyle106.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Lectura2.DefaultCellStyle = dataGridViewCellStyle106;
            this.Lectura2.HeaderText = "Lectura";
            this.Lectura2.Name = "Lectura2";
            this.Lectura2.ReadOnly = true;
            this.Lectura2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Lectura2.Width = 50;
            // 
            // Calif
            // 
            dataGridViewCellStyle107.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Calif.DefaultCellStyle = dataGridViewCellStyle107;
            this.Calif.HeaderText = "Dist.";
            this.Calif.Name = "Calif";
            this.Calif.ReadOnly = true;
            this.Calif.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Calif.Width = 50;
            // 
            // Cabezas
            // 
            dataGridViewCellStyle108.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Cabezas.DefaultCellStyle = dataGridViewCellStyle108;
            this.Cabezas.HeaderText = "Cab";
            this.Cabezas.Name = "Cabezas";
            this.Cabezas.ReadOnly = true;
            this.Cabezas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Cabezas.Width = 60;
            // 
            // ServidoProm
            // 
            dataGridViewCellStyle109.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ServidoProm.DefaultCellStyle = dataGridViewCellStyle109;
            this.ServidoProm.HeaderText = "ServidoProm";
            this.ServidoProm.Name = "ServidoProm";
            this.ServidoProm.ReadOnly = true;
            this.ServidoProm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ServidoProm.Width = 70;
            // 
            // Planeado
            // 
            dataGridViewCellStyle110.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Planeado.DefaultCellStyle = dataGridViewCellStyle110;
            this.Planeado.HeaderText = "Plan";
            this.Planeado.Name = "Planeado";
            this.Planeado.ReadOnly = true;
            this.Planeado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Planeado.Width = 60;
            // 
            // Servido
            // 
            dataGridViewCellStyle111.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Servido.DefaultCellStyle = dataGridViewCellStyle111;
            this.Servido.HeaderText = "Servido";
            this.Servido.Name = "Servido";
            this.Servido.ReadOnly = true;
            this.Servido.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Servido.Width = 60;
            // 
            // Minimo
            // 
            dataGridViewCellStyle112.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Minimo.DefaultCellStyle = dataGridViewCellStyle112;
            this.Minimo.HeaderText = "Minimo";
            this.Minimo.Name = "Minimo";
            this.Minimo.ReadOnly = true;
            this.Minimo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Minimo.Width = 80;
            // 
            // Promedio
            // 
            dataGridViewCellStyle113.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Promedio.DefaultCellStyle = dataGridViewCellStyle113;
            this.Promedio.HeaderText = "Promedio";
            this.Promedio.Name = "Promedio";
            this.Promedio.ReadOnly = true;
            this.Promedio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Promedio.Width = 80;
            // 
            // Maximo
            // 
            dataGridViewCellStyle114.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Maximo.DefaultCellStyle = dataGridViewCellStyle114;
            this.Maximo.HeaderText = "Maximo";
            this.Maximo.Name = "Maximo";
            this.Maximo.ReadOnly = true;
            this.Maximo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Maximo.Width = 80;
            // 
            // VariacionOrd
            // 
            dataGridViewCellStyle115.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.VariacionOrd.DefaultCellStyle = dataGridViewCellStyle115;
            this.VariacionOrd.HeaderText = "VarOrd";
            this.VariacionOrd.Name = "VariacionOrd";
            this.VariacionOrd.ReadOnly = true;
            this.VariacionOrd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.VariacionOrd.Width = 80;
            // 
            // VariacionAnt
            // 
            dataGridViewCellStyle116.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.VariacionAnt.DefaultCellStyle = dataGridViewCellStyle116;
            this.VariacionAnt.HeaderText = "VarAnt";
            this.VariacionAnt.Name = "VariacionAnt";
            this.VariacionAnt.ReadOnly = true;
            this.VariacionAnt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.VariacionAnt.Width = 80;
            // 
            // PesoProm
            // 
            dataGridViewCellStyle117.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.PesoProm.DefaultCellStyle = dataGridViewCellStyle117;
            this.PesoProm.HeaderText = "PesoProm";
            this.PesoProm.Name = "PesoProm";
            this.PesoProm.ReadOnly = true;
            this.PesoProm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PesoProm.Width = 60;
            // 
            // PesoPromP
            // 
            dataGridViewCellStyle118.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.PesoPromP.DefaultCellStyle = dataGridViewCellStyle118;
            this.PesoPromP.HeaderText = "PesoProm%";
            this.PesoPromP.Name = "PesoPromP";
            this.PesoPromP.ReadOnly = true;
            this.PesoPromP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PesoPromP.Width = 60;
            // 
            // LoteEng
            // 
            this.LoteEng.HeaderText = "LoteEng";
            this.LoteEng.Name = "LoteEng";
            this.LoteEng.ReadOnly = true;
            this.LoteEng.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LoteEng.Width = 80;
            // 
            // _GridLectura
            // 
            this._GridLectura.AllowUserToAddRows = false;
            this._GridLectura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._GridLectura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Almacen1,
            this.Envio,
            this.Lectura1,
            this.Hora1,
            this.Ajuste,
            this.Adelantar,
            this.RacAct,
            this.DiasAgr,
            this.Dist,
            this.Comp});
            this._GridLectura.Dock = System.Windows.Forms.DockStyle.Fill;
            this._GridLectura.Location = new System.Drawing.Point(0, 209);
            this._GridLectura.MultiSelect = false;
            this._GridLectura.Name = "_GridLectura";
            this._GridLectura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._GridLectura.Size = new System.Drawing.Size(410, 288);
            this._GridLectura.TabIndex = 8;
            this._GridLectura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridLectura_CellContentClick);
            this._GridLectura.SelectionChanged += new System.EventHandler(this.GridLectura_SelectionChanged);
            // 
            // Almacen1
            // 
            dataGridViewCellStyle119.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Almacen1.DefaultCellStyle = dataGridViewCellStyle119;
            this.Almacen1.HeaderText = "Corral";
            this.Almacen1.Name = "Almacen1";
            this.Almacen1.ReadOnly = true;
            this.Almacen1.Width = 50;
            // 
            // Envio
            // 
            this.Envio.HeaderText = "Envio";
            this.Envio.Name = "Envio";
            this.Envio.ReadOnly = true;
            this.Envio.Width = 50;
            // 
            // Lectura1
            // 
            this.Lectura1.HeaderText = "Lectura";
            this.Lectura1.Name = "Lectura1";
            this.Lectura1.ReadOnly = true;
            this.Lectura1.Width = 50;
            // 
            // Hora1
            // 
            dataGridViewCellStyle120.NullValue = null;
            this.Hora1.DefaultCellStyle = dataGridViewCellStyle120;
            this.Hora1.HeaderText = "Hora";
            this.Hora1.Name = "Hora1";
            this.Hora1.ReadOnly = true;
            this.Hora1.Width = 50;
            // 
            // Ajuste
            // 
            this.Ajuste.HeaderText = "Ajuste";
            this.Ajuste.Name = "Ajuste";
            this.Ajuste.ReadOnly = true;
            this.Ajuste.Width = 60;
            // 
            // Adelantar
            // 
            this.Adelantar.HeaderText = "AdelantaR";
            this.Adelantar.Name = "Adelantar";
            this.Adelantar.ReadOnly = true;
            this.Adelantar.Width = 60;
            // 
            // RacAct
            // 
            this.RacAct.HeaderText = "RacAct";
            this.RacAct.Name = "RacAct";
            this.RacAct.ReadOnly = true;
            this.RacAct.Width = 50;
            // 
            // DiasAgr
            // 
            this.DiasAgr.HeaderText = "DiasAgr";
            this.DiasAgr.Name = "DiasAgr";
            this.DiasAgr.ReadOnly = true;
            this.DiasAgr.Width = 50;
            // 
            // Dist
            // 
            this.Dist.HeaderText = "Dist";
            this.Dist.Name = "Dist";
            this.Dist.ReadOnly = true;
            this.Dist.Width = 50;
            // 
            // Comp
            // 
            this.Comp.HeaderText = "Comp";
            this.Comp.Name = "Comp";
            this.Comp.ReadOnly = true;
            this.Comp.Width = 50;
            // 
            // Chart1
            // 
            this.Chart1.BackColor = System.Drawing.SystemColors.Control;
            chartArea8.Name = "ChartArea1";
            this.Chart1.ChartAreas.Add(chartArea8);
            this.Chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend8.Alignment = System.Drawing.StringAlignment.Far;
            legend8.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend8.Name = "Legend1";
            this.Chart1.Legends.Add(legend8);
            this.Chart1.Location = new System.Drawing.Point(0, 0);
            this.Chart1.Name = "Chart1";
            this.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.Chart1.Series.Add(series8);
            this.Chart1.Size = new System.Drawing.Size(428, 361);
            this.Chart1.TabIndex = 9;
            this.Chart1.Text = "Chart1";
            // 
            // _PanelLecturas
            // 
            this._PanelLecturas.BackColor = System.Drawing.SystemColors.Control;
            this._PanelLecturas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._PanelLecturas.Controls.Add(this.btnSiguiente);
            this._PanelLecturas.Controls.Add(this.Label5);
            this._PanelLecturas.Controls.Add(this._ComboComp);
            this._PanelLecturas.Controls.Add(this.EtiquetaFechaFinNva);
            this._PanelLecturas.Controls.Add(this.Label9);
            this._PanelLecturas.Controls.Add(this._TextoDiasAgregar);
            this._PanelLecturas.Controls.Add(this.Label8);
            this._PanelLecturas.Controls.Add(this.EtiquetaFechaFinRac);
            this._PanelLecturas.Controls.Add(this.Label6);
            this._PanelLecturas.Controls.Add(this.EtiquetaRacAct);
            this._PanelLecturas.Controls.Add(this.Label4);
            this._PanelLecturas.Controls.Add(this.CheckAdelantar);
            this._PanelLecturas.Controls.Add(this.Label2);
            this._PanelLecturas.Controls.Add(this._ComboDist);
            this._PanelLecturas.Controls.Add(this.Label3);
            this._PanelLecturas.Controls.Add(this.EtiquetaDias);
            this._PanelLecturas.Controls.Add(this.Lbl_Ajuste);
            this._PanelLecturas.Controls.Add(this._TextoAjuste);
            this._PanelLecturas.Controls.Add(this.Label1);
            this._PanelLecturas.Controls.Add(this.EtiquetaFecha);
            this._PanelLecturas.Controls.Add(this._BotonBuscar);
            this._PanelLecturas.Controls.Add(this._TextoAlmacen);
            this._PanelLecturas.Controls.Add(this.EtiquetaAlmacen);
            this._PanelLecturas.Controls.Add(this._ComboLectura);
            this._PanelLecturas.Controls.Add(this._BotonGrabar);
            this._PanelLecturas.Controls.Add(this.EtiquetaLectura);
            this._PanelLecturas.Dock = System.Windows.Forms.DockStyle.Top;
            this._PanelLecturas.Location = new System.Drawing.Point(0, 0);
            this._PanelLecturas.Name = "_PanelLecturas";
            this._PanelLecturas.Size = new System.Drawing.Size(410, 183);
            this._PanelLecturas.TabIndex = 10;
            this._PanelLecturas.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(270, 145);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(44, 17);
            this.Label5.TabIndex = 32;
            this.Label5.Text = "Comp";
            // 
            // _ComboComp
            // 
            this._ComboComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._ComboComp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComboComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ComboComp.FormattingEnabled = true;
            this._ComboComp.Items.AddRange(new object[] {
            "N",
            "A",
            "T"});
            this._ComboComp.Location = new System.Drawing.Point(320, 143);
            this._ComboComp.Name = "_ComboComp";
            this._ComboComp.Size = new System.Drawing.Size(47, 24);
            this._ComboComp.TabIndex = 14;
            this._ComboComp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboComp_KeyPress);
            // 
            // EtiquetaFechaFinNva
            // 
            this.EtiquetaFechaFinNva.AutoSize = true;
            this.EtiquetaFechaFinNva.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EtiquetaFechaFinNva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtiquetaFechaFinNva.Location = new System.Drawing.Point(318, 114);
            this.EtiquetaFechaFinNva.Name = "EtiquetaFechaFinNva";
            this.EtiquetaFechaFinNva.Size = new System.Drawing.Size(14, 19);
            this.EtiquetaFechaFinNva.TabIndex = 30;
            this.EtiquetaFechaFinNva.Text = " ";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(217, 114);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(99, 17);
            this.Label9.TabIndex = 29;
            this.Label9.Text = "Fecha Fin Nva";
            // 
            // _TextoDiasAgregar
            // 
            this._TextoDiasAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._TextoDiasAgregar.Location = new System.Drawing.Point(109, 110);
            this._TextoDiasAgregar.MaxLength = 3;
            this._TextoDiasAgregar.Name = "_TextoDiasAgregar";
            this._TextoDiasAgregar.Size = new System.Drawing.Size(31, 23);
            this._TextoDiasAgregar.TabIndex = 28;
            this._TextoDiasAgregar.TextChanged += new System.EventHandler(this.TextoDiasAgregar_TextChanged);
            this._TextoDiasAgregar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextoDiasAgregar_KeyPress);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(14, 113);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(91, 17);
            this.Label8.TabIndex = 27;
            this.Label8.Text = "Dias Agregar";
            // 
            // EtiquetaFechaFinRac
            // 
            this.EtiquetaFechaFinRac.AutoSize = true;
            this.EtiquetaFechaFinRac.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EtiquetaFechaFinRac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtiquetaFechaFinRac.Location = new System.Drawing.Point(320, 44);
            this.EtiquetaFechaFinRac.Name = "EtiquetaFechaFinRac";
            this.EtiquetaFechaFinRac.Size = new System.Drawing.Size(14, 19);
            this.EtiquetaFechaFinRac.TabIndex = 26;
            this.EtiquetaFechaFinRac.Text = " ";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(219, 45);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(99, 17);
            this.Label6.TabIndex = 25;
            this.Label6.Text = "Fecha Fin Rac";
            // 
            // EtiquetaRacAct
            // 
            this.EtiquetaRacAct.AutoSize = true;
            this.EtiquetaRacAct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EtiquetaRacAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtiquetaRacAct.Location = new System.Drawing.Point(172, 45);
            this.EtiquetaRacAct.Name = "EtiquetaRacAct";
            this.EtiquetaRacAct.Size = new System.Drawing.Size(14, 19);
            this.EtiquetaRacAct.TabIndex = 24;
            this.EtiquetaRacAct.Text = " ";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(93, 44);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(76, 17);
            this.Label4.TabIndex = 23;
            this.Label4.Text = "Racion Act";
            // 
            // CheckAdelantar
            // 
            this.CheckAdelantar.AutoSize = true;
            this.CheckAdelantar.Location = new System.Drawing.Point(287, 80);
            this.CheckAdelantar.Name = "CheckAdelantar";
            this.CheckAdelantar.Size = new System.Drawing.Size(108, 17);
            this.CheckAdelantar.TabIndex = 22;
            this.CheckAdelantar.Text = "Adelantar Racion";
            this.CheckAdelantar.UseVisualStyleBackColor = true;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(169, 147);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(32, 17);
            this.Label2.TabIndex = 21;
            this.Label2.Text = "Dist";
            // 
            // _ComboDist
            // 
            this._ComboDist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._ComboDist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComboDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ComboDist.FormattingEnabled = true;
            this._ComboDist.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this._ComboDist.Location = new System.Drawing.Point(205, 143);
            this._ComboDist.Name = "_ComboDist";
            this._ComboDist.Size = new System.Drawing.Size(44, 24);
            this._ComboDist.TabIndex = 13;
            this._ComboDist.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboDist_KeyPress);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(13, 44);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(36, 17);
            this.Label3.TabIndex = 19;
            this.Label3.Text = "Dias";
            // 
            // EtiquetaDias
            // 
            this.EtiquetaDias.AutoSize = true;
            this.EtiquetaDias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EtiquetaDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtiquetaDias.Location = new System.Drawing.Point(54, 44);
            this.EtiquetaDias.Name = "EtiquetaDias";
            this.EtiquetaDias.Size = new System.Drawing.Size(18, 19);
            this.EtiquetaDias.TabIndex = 18;
            this.EtiquetaDias.Text = "  ";
            // 
            // Lbl_Ajuste
            // 
            this.Lbl_Ajuste.AutoSize = true;
            this.Lbl_Ajuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Ajuste.Location = new System.Drawing.Point(153, 77);
            this.Lbl_Ajuste.Name = "Lbl_Ajuste";
            this.Lbl_Ajuste.Size = new System.Drawing.Size(47, 17);
            this.Lbl_Ajuste.TabIndex = 17;
            this.Lbl_Ajuste.Text = "Ajuste";
            // 
            // _TextoAjuste
            // 
            this._TextoAjuste.Enabled = false;
            this._TextoAjuste.Location = new System.Drawing.Point(206, 77);
            this._TextoAjuste.Name = "_TextoAjuste";
            this._TextoAjuste.Size = new System.Drawing.Size(56, 20);
            this._TextoAjuste.TabIndex = 12;
            this._TextoAjuste.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextoAjuste_KeyPress1);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(270, 10);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(47, 17);
            this.Label1.TabIndex = 15;
            this.Label1.Text = "Fecha";
            // 
            // EtiquetaFecha
            // 
            this.EtiquetaFecha.AutoSize = true;
            this.EtiquetaFecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EtiquetaFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtiquetaFecha.Location = new System.Drawing.Point(318, 10);
            this.EtiquetaFecha.Name = "EtiquetaFecha";
            this.EtiquetaFecha.Size = new System.Drawing.Size(14, 19);
            this.EtiquetaFecha.TabIndex = 14;
            this.EtiquetaFecha.Text = " ";
            // 
            // _BotonBuscar
            // 
            this._BotonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._BotonBuscar.Location = new System.Drawing.Point(134, 7);
            this._BotonBuscar.Name = "_BotonBuscar";
            this._BotonBuscar.Size = new System.Drawing.Size(119, 25);
            this._BotonBuscar.TabIndex = 10;
            this._BotonBuscar.Text = "Buscar";
            this._BotonBuscar.UseVisualStyleBackColor = true;
            this._BotonBuscar.Click += new System.EventHandler(this.BotonBuscar_Click_1);
            // 
            // _TextoAlmacen
            // 
            this._TextoAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._TextoAlmacen.Location = new System.Drawing.Point(72, 7);
            this._TextoAlmacen.Name = "_TextoAlmacen";
            this._TextoAlmacen.Size = new System.Drawing.Size(56, 23);
            this._TextoAlmacen.TabIndex = 8;
            this._TextoAlmacen.TextChanged += new System.EventHandler(this.TextoAlmacen_TextChanged);
            this._TextoAlmacen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextoAlmacen_KeyPress1);
            // 
            // EtiquetaAlmacen
            // 
            this.EtiquetaAlmacen.AutoSize = true;
            this.EtiquetaAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtiquetaAlmacen.Location = new System.Drawing.Point(13, 8);
            this.EtiquetaAlmacen.Name = "EtiquetaAlmacen";
            this.EtiquetaAlmacen.Size = new System.Drawing.Size(62, 17);
            this.EtiquetaAlmacen.TabIndex = 13;
            this.EtiquetaAlmacen.Text = "Almacen";
            // 
            // _ComboLectura
            // 
            this._ComboLectura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._ComboLectura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComboLectura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ComboLectura.FormattingEnabled = true;
            this._ComboLectura.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this._ComboLectura.Location = new System.Drawing.Point(72, 76);
            this._ComboLectura.Name = "_ComboLectura";
            this._ComboLectura.Size = new System.Drawing.Size(65, 24);
            this._ComboLectura.TabIndex = 11;
            this._ComboLectura.SelectedIndexChanged += new System.EventHandler(this.ComboLectura_SelectedIndexChanged);
            this._ComboLectura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboLectura_KeyPress1);
            // 
            // _BotonGrabar
            // 
            this._BotonGrabar.BackColor = System.Drawing.Color.Gold;
            this._BotonGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._BotonGrabar.Location = new System.Drawing.Point(12, 143);
            this._BotonGrabar.Name = "_BotonGrabar";
            this._BotonGrabar.Size = new System.Drawing.Size(142, 33);
            this._BotonGrabar.TabIndex = 15;
            this._BotonGrabar.Text = "Grabar";
            this._BotonGrabar.UseVisualStyleBackColor = false;
            this._BotonGrabar.Click += new System.EventHandler(this.BotonGrabar_Click_1);
            // 
            // EtiquetaLectura
            // 
            this.EtiquetaLectura.AutoSize = true;
            this.EtiquetaLectura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtiquetaLectura.Location = new System.Drawing.Point(13, 76);
            this.EtiquetaLectura.Name = "EtiquetaLectura";
            this.EtiquetaLectura.Size = new System.Drawing.Size(56, 17);
            this.EtiquetaLectura.TabIndex = 9;
            this.EtiquetaLectura.Text = "Lectura";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.archivosToolStripMenuItem,
            this.opcionesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1018, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recibirToolStripMenuItem,
            this.enviarToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.menuToolStripMenuItem.Text = "Ws";
            // 
            // recibirToolStripMenuItem
            // 
            this.recibirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("recibirToolStripMenuItem.Image")));
            this.recibirToolStripMenuItem.Name = "recibirToolStripMenuItem";
            this.recibirToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.recibirToolStripMenuItem.Text = "Recibir";
            this.recibirToolStripMenuItem.Click += new System.EventHandler(this.recibirToolStripMenuItem_Click);
            // 
            // enviarToolStripMenuItem
            // 
            this.enviarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("enviarToolStripMenuItem.Image")));
            this.enviarToolStripMenuItem.Name = "enviarToolStripMenuItem";
            this.enviarToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.enviarToolStripMenuItem.Text = "Enviar";
            this.enviarToolStripMenuItem.Click += new System.EventHandler(this.enviarToolStripMenuItem_Click);
            // 
            // archivosToolStripMenuItem
            // 
            this.archivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarToolStripMenuItem,
            this.generarToolStripMenuItem});
            this.archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
            this.archivosToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.archivosToolStripMenuItem.Text = "Archivos";
            // 
            // cargarToolStripMenuItem
            // 
            this.cargarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cargarToolStripMenuItem.Image")));
            this.cargarToolStripMenuItem.Name = "cargarToolStripMenuItem";
            this.cargarToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.cargarToolStripMenuItem.Text = "Cargar";
            this.cargarToolStripMenuItem.Click += new System.EventHandler(this.cargarToolStripMenuItem_Click);
            // 
            // generarToolStripMenuItem
            // 
            this.generarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("generarToolStripMenuItem.Image")));
            this.generarToolStripMenuItem.Name = "generarToolStripMenuItem";
            this.generarToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.generarToolStripMenuItem.Text = "Generar";
            this.generarToolStripMenuItem.Click += new System.EventHandler(this.generarToolStripMenuItem_Click);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuracionToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("configuracionToolStripMenuItem.Image")));
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.configuracionToolStripMenuItem.Text = "Configuracion";
            this.configuracionToolStripMenuItem.Click += new System.EventHandler(this.configuracionToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblErrores});
            this.statusStrip1.Location = new System.Drawing.Point(0, 497);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1018, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblErrores
            // 
            this.lblErrores.Name = "lblErrores";
            this.lblErrores.Size = new System.Drawing.Size(0, 17);
            // 
            // panelConfiguracion
            // 
            this.panelConfiguracion.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelConfiguracion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelConfiguracion.Controls.Add(this.btnUbicaciones);
            this.panelConfiguracion.Controls.Add(this.label11);
            this.panelConfiguracion.Controls.Add(this.txtEquipo);
            this.panelConfiguracion.Controls.Add(this.label10);
            this.panelConfiguracion.Controls.Add(this.txtContrasena);
            this.panelConfiguracion.Controls.Add(this.label7);
            this.panelConfiguracion.Controls.Add(this.txtUsuario);
            this.panelConfiguracion.Controls.Add(this.btnCerrarConfiguracion);
            this.panelConfiguracion.Controls.Add(this.btnGuardarConfiguracion);
            this.panelConfiguracion.Location = new System.Drawing.Point(56, 251);
            this.panelConfiguracion.Name = "panelConfiguracion";
            this.panelConfiguracion.Size = new System.Drawing.Size(289, 193);
            this.panelConfiguracion.TabIndex = 13;
            this.panelConfiguracion.Visible = false;
            // 
            // btnUbicaciones
            // 
            this.btnUbicaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbicaciones.Location = new System.Drawing.Point(15, 110);
            this.btnUbicaciones.Name = "btnUbicaciones";
            this.btnUbicaciones.Size = new System.Drawing.Size(150, 35);
            this.btnUbicaciones.TabIndex = 98;
            this.btnUbicaciones.Text = "Traer Ubicaciones";
            this.btnUbicaciones.UseVisualStyleBackColor = true;
            this.btnUbicaciones.Click += new System.EventHandler(this.btnUbicaciones_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Equipo";
            // 
            // txtEquipo
            // 
            this.txtEquipo.Location = new System.Drawing.Point(81, 19);
            this.txtEquipo.Name = "txtEquipo";
            this.txtEquipo.Size = new System.Drawing.Size(130, 20);
            this.txtEquipo.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Conyraseña";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(81, 71);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(130, 20);
            this.txtContrasena.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(81, 45);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(130, 20);
            this.txtUsuario.TabIndex = 2;
            // 
            // btnCerrarConfiguracion
            // 
            this.btnCerrarConfiguracion.Location = new System.Drawing.Point(191, 151);
            this.btnCerrarConfiguracion.Name = "btnCerrarConfiguracion";
            this.btnCerrarConfiguracion.Size = new System.Drawing.Size(88, 30);
            this.btnCerrarConfiguracion.TabIndex = 1;
            this.btnCerrarConfiguracion.Text = "Cerrar";
            this.btnCerrarConfiguracion.UseVisualStyleBackColor = true;
            this.btnCerrarConfiguracion.Click += new System.EventHandler(this.btnCerrarConfiguracion_Click);
            // 
            // btnGuardarConfiguracion
            // 
            this.btnGuardarConfiguracion.Location = new System.Drawing.Point(97, 151);
            this.btnGuardarConfiguracion.Name = "btnGuardarConfiguracion";
            this.btnGuardarConfiguracion.Size = new System.Drawing.Size(88, 30);
            this.btnGuardarConfiguracion.TabIndex = 0;
            this.btnGuardarConfiguracion.Text = "Guardar";
            this.btnGuardarConfiguracion.UseVisualStyleBackColor = true;
            this.btnGuardarConfiguracion.Click += new System.EventHandler(this.btnGuardarConfiguracion_Click);
            // 
            // lblEsperar
            // 
            this.lblEsperar.AutoSize = true;
            this.lblEsperar.BackColor = System.Drawing.Color.White;
            this.lblEsperar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsperar.Location = new System.Drawing.Point(133, 166);
            this.lblEsperar.Name = "lblEsperar";
            this.lblEsperar.Size = new System.Drawing.Size(131, 31);
            this.lblEsperar.TabIndex = 14;
            this.lblEsperar.Text = "Espere ...";
            this.lblEsperar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelConfiguracion);
            this.panel1.Controls.Add(this._GridLectura);
            this.panel1.Controls.Add(this.tcFechas);
            this.panel1.Controls.Add(this._PanelLecturas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(608, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 497);
            this.panel1.TabIndex = 0;
            // 
            // tcFechas
            // 
            this.tcFechas.Controls.Add(this.tabPage1);
            this.tcFechas.Controls.Add(this.tabPage2);
            this.tcFechas.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcFechas.Location = new System.Drawing.Point(0, 183);
            this.tcFechas.Name = "tcFechas";
            this.tcFechas.SelectedIndex = 0;
            this.tcFechas.Size = new System.Drawing.Size(410, 26);
            this.tcFechas.TabIndex = 11;
            this.tcFechas.Selected += new System.Windows.Forms.TabControlEventHandler(this.tcFechas_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(402, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = ".";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(402, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = ".";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblCorral
            // 
            this.lblCorral.AutoSize = true;
            this.lblCorral.BackColor = System.Drawing.Color.Transparent;
            this.lblCorral.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorral.Location = new System.Drawing.Point(36, 166);
            this.lblCorral.Name = "lblCorral";
            this.lblCorral.Size = new System.Drawing.Size(74, 31);
            this.lblCorral.TabIndex = 15;
            this.lblCorral.Text = "0000";
            this.lblCorral.Visible = false;
            // 
            // panelGrafica
            // 
            this.panelGrafica.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelGrafica.Controls.Add(this.splitContainer1);
            this.panelGrafica.Controls.Add(this.toolStrip1);
            this.panelGrafica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrafica.Location = new System.Drawing.Point(0, 0);
            this.panelGrafica.Name = "panelGrafica";
            this.panelGrafica.Size = new System.Drawing.Size(608, 403);
            this.panelGrafica.TabIndex = 16;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 38);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelMapa);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblCorral);
            this.splitContainer1.Panel2.Controls.Add(this.lblEsperar);
            this.splitContainer1.Panel2.Controls.Add(this.Chart1);
            this.splitContainer1.Size = new System.Drawing.Size(604, 361);
            this.splitContainer1.SplitterDistance = 172;
            this.splitContainer1.TabIndex = 95;
            // 
            // panelMapa
            // 
            this.panelMapa.Controls.Add(this.trackBar1);
            this.panelMapa.Controls.Add(this.toolStrip3);
            this.panelMapa.Controls.Add(this.gMapControl1);
            this.panelMapa.Controls.Add(this.btnServida);
            this.panelMapa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMapa.Location = new System.Drawing.Point(0, 0);
            this.panelMapa.Name = "panelMapa";
            this.panelMapa.Size = new System.Drawing.Size(172, 361);
            this.panelMapa.TabIndex = 94;
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.Gray;
            this.trackBar1.Location = new System.Drawing.Point(10, 211);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Minimum = 15;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 71);
            this.trackBar1.TabIndex = 95;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar1.Value = 16;
            this.trackBar1.Visible = false;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // toolStrip3
            // 
            this.toolStrip3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip3.Font = new System.Drawing.Font("Segoe UI", 5F);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.lblZoom,
            this.toolStripButton2,
            this.toolStripSeparator5,
            this.toolStripButton3,
            this.toolStripSeparator6,
            this.toolStripButton4,
            this.toolStripSeparator7});
            this.toolStrip3.Location = new System.Drawing.Point(0, 335);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(172, 26);
            this.toolStrip3.TabIndex = 94;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(95, 23);
            this.toolStripButton1.Text = "NAVEGADOR";
            this.toolStripButton1.Visible = false;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(39, 23);
            this.toolStripButton2.Text = "  +  ";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click_1);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 26);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(35, 23);
            this.toolStripButton3.Text = "  -  ";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click_1);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 26);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(52, 23);
            this.toolStripButton4.Text = "GIRAR";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click_1);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 26);
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.gMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(0, 0);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(172, 361);
            this.gMapControl1.TabIndex = 92;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.OnMapZoomChanged += new GMap.NET.MapZoomChanged(this.cambioZoomMapa);
            // 
            // btnServida
            // 
            this.btnServida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServida.Image = ((System.Drawing.Image)(resources.GetObject("btnServida.Image")));
            this.btnServida.Location = new System.Drawing.Point(489, -4);
            this.btnServida.Name = "btnServida";
            this.btnServida.Size = new System.Drawing.Size(149, 149);
            this.btnServida.TabIndex = 0;
            this.btnServida.Text = "Servida";
            this.btnServida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnServida.UseVisualStyleBackColor = true;
            this.btnServida.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRecibir,
            this.btnEnviar,
            this.toolStripSeparator1,
            this.btnCargar,
            this.btnGenerar,
            this.toolStripSeparator2,
            this.btnConfigurar,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(604, 38);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnRecibir
            // 
            this.btnRecibir.Image = ((System.Drawing.Image)(resources.GetObject("btnRecibir.Image")));
            this.btnRecibir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRecibir.Name = "btnRecibir";
            this.btnRecibir.Size = new System.Drawing.Size(55, 35);
            this.btnRecibir.Text = "Historial";
            this.btnRecibir.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnRecibir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRecibir.Click += new System.EventHandler(this.btnRecibir_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Image = ((System.Drawing.Image)(resources.GetObject("btnEnviar.Image")));
            this.btnEnviar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(43, 35);
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnEnviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // btnCargar
            // 
            this.btnCargar.Image = ((System.Drawing.Image)(resources.GetObject("btnCargar.Image")));
            this.btnCargar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(46, 35);
            this.btnCargar.Text = "Cargar";
            this.btnCargar.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnCargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerar.Image")));
            this.btnGenerar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(46, 35);
            this.btnGenerar.Text = "Grabar";
            this.btnGenerar.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnGenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.Image = ((System.Drawing.Image)(resources.GetObject("btnConfigurar.Image")));
            this.btnConfigurar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(47, 35);
            this.btnConfigurar.Text = "Config";
            this.btnConfigurar.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnConfigurar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConfigurar.Click += new System.EventHandler(this.btnConfigurar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(376, 141);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(32, 25);
            this.btnSiguiente.TabIndex = 33;
            this.btnSiguiente.Text = ">>";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // lblZoom
            // 
            this.lblZoom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.Size = new System.Drawing.Size(17, 19);
            this.lblZoom.Text = "0";
            // 
            // Lectura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1018, 519);
            this.Controls.Add(this.panelGrafica);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Lectura";
            this.Text = "Lectura";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Lectura_Load);
            this.Resize += new System.EventHandler(this.Lectura_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._GridLectura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this._PanelLecturas.ResumeLayout(false);
            this._PanelLecturas.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panelConfiguracion.ResumeLayout(false);
            this.panelConfiguracion.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tcFechas.ResumeLayout(false);
            this.panelGrafica.ResumeLayout(false);
            this.panelGrafica.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelMapa.ResumeLayout(false);
            this.panelMapa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal DataGridView Grid;
        private DataGridView _GridLectura;

        internal DataGridView GridLectura
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _GridLectura;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_GridLectura != null)
                {
                    _GridLectura.SelectionChanged -= GridLectura_SelectionChanged;
                    _GridLectura.CellContentClick -= GridLectura_CellContentClick;
                }

                _GridLectura = value;
                if (_GridLectura != null)
                {
                    _GridLectura.SelectionChanged += GridLectura_SelectionChanged;
                    _GridLectura.CellContentClick += GridLectura_CellContentClick;
                }
            }
        }

        internal System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
        private Panel _PanelLecturas;

        internal Panel Panel1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PanelLecturas;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PanelLecturas != null)
                {
                    _PanelLecturas.Paint -= Panel1_Paint;
                }

                _PanelLecturas = value;
                if (_PanelLecturas != null)
                {
                    _PanelLecturas.Paint += Panel1_Paint;
                }
            }
        }

        internal Label Label1;
        internal Label EtiquetaFecha;
        private Button _BotonBuscar;

        internal Button BotonBuscar
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BotonBuscar;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BotonBuscar != null)
                {
                    _BotonBuscar.Click -= BotonBuscar_Click_1;
                }

                _BotonBuscar = value;
                if (_BotonBuscar != null)
                {
                    _BotonBuscar.Click += BotonBuscar_Click_1;
                }
            }
        }

        private TextBox _TextoAlmacen;

        internal TextBox TextoAlmacen
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextoAlmacen;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextoAlmacen != null)
                {
                    _TextoAlmacen.KeyPress -= TextoAlmacen_KeyPress1;
                    _TextoAlmacen.TextChanged -= TextoAlmacen_TextChanged;
                }

                _TextoAlmacen = value;
                if (_TextoAlmacen != null)
                {
                    _TextoAlmacen.KeyPress += TextoAlmacen_KeyPress1;
                    _TextoAlmacen.TextChanged += TextoAlmacen_TextChanged;
                }
            }
        }

        internal Label EtiquetaAlmacen;
        private ComboBox _ComboLectura;

        internal ComboBox ComboLectura
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboLectura;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboLectura != null)
                {
                    _ComboLectura.KeyPress -= ComboLectura_KeyPress1;
                    _ComboLectura.SelectedIndexChanged -= ComboLectura_SelectedIndexChanged;
                }

                _ComboLectura = value;
                if (_ComboLectura != null)
                {
                    _ComboLectura.KeyPress += ComboLectura_KeyPress1;
                    _ComboLectura.SelectedIndexChanged += ComboLectura_SelectedIndexChanged;
                }
            }
        }

        private Button _BotonGrabar;

        internal Button BotonGrabar
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BotonGrabar;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BotonGrabar != null)
                {
                    _BotonGrabar.Click -= BotonGrabar_Click_1;
                }

                _BotonGrabar = value;
                if (_BotonGrabar != null)
                {
                    _BotonGrabar.Click += BotonGrabar_Click_1;
                }
            }
        }

        internal Label EtiquetaLectura;
        internal Label Lbl_Ajuste;
        private TextBox _TextoAjuste;

        internal TextBox TextoAjuste
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextoAjuste;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextoAjuste != null)
                {
                    _TextoAjuste.KeyPress -= TextoAjuste_KeyPress1;
                }

                _TextoAjuste = value;
                if (_TextoAjuste != null)
                {
                    _TextoAjuste.KeyPress += TextoAjuste_KeyPress1;
                }
            }
        }

        internal Label EtiquetaDias;
        internal Label Label3;
        private ComboBox _ComboDist;

        internal ComboBox ComboDist
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboDist;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboDist != null)
                {
                    _ComboDist.KeyPress -= ComboDist_KeyPress;
                }

                _ComboDist = value;
                if (_ComboDist != null)
                {
                    _ComboDist.KeyPress += ComboDist_KeyPress;
                }
            }
        }

        internal Label Label2;
        internal CheckBox CheckAdelantar;
        internal Label Label4;
        internal Label EtiquetaRacAct;
        internal Label Label6;
        internal Label EtiquetaFechaFinRac;
        internal Label Label8;
        private TextBox _TextoDiasAgregar;

        internal TextBox TextoDiasAgregar
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextoDiasAgregar;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextoDiasAgregar != null)
                {
                    _TextoDiasAgregar.KeyPress -= TextoDiasAgregar_KeyPress;
                    _TextoDiasAgregar.TextChanged -= TextoDiasAgregar_TextChanged;
                }

                _TextoDiasAgregar = value;
                if (_TextoDiasAgregar != null)
                {
                    _TextoDiasAgregar.KeyPress += TextoDiasAgregar_KeyPress;
                    _TextoDiasAgregar.TextChanged += TextoDiasAgregar_TextChanged;
                }
            }
        }

        internal Label EtiquetaFechaFinNva;
        internal Label Label9;
        private ComboBox _ComboComp;

        internal ComboBox ComboComp
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboComp;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboComp != null)
                {
                    _ComboComp.KeyPress -= ComboComp_KeyPress;
                }

                _ComboComp = value;
                if (_ComboComp != null)
                {
                    _ComboComp.KeyPress += ComboComp_KeyPress;
                }
            }
        }

        internal Label Label5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem recibirToolStripMenuItem;
        private ToolStripMenuItem enviarToolStripMenuItem;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem configuracionToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblErrores;
        private ToolStripMenuItem archivosToolStripMenuItem;
        private ToolStripMenuItem cargarToolStripMenuItem;
        private ToolStripMenuItem generarToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private Panel panelConfiguracion;
        private Button btnCerrarConfiguracion;
        private Button btnGuardarConfiguracion;
        private Label label7;
        private TextBox txtUsuario;
        private Label label11;
        private TextBox txtEquipo;
        private Label label10;
        private TextBox txtContrasena;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Almacen;
        private DataGridViewTextBoxColumn Racion;
        private DataGridViewTextBoxColumn Lectura2;
        private DataGridViewTextBoxColumn Calif;
        private DataGridViewTextBoxColumn Cabezas;
        private DataGridViewTextBoxColumn ServidoProm;
        private DataGridViewTextBoxColumn Planeado;
        private DataGridViewTextBoxColumn Servido;
        private DataGridViewTextBoxColumn Minimo;
        private DataGridViewTextBoxColumn Promedio;
        private DataGridViewTextBoxColumn Maximo;
        private DataGridViewTextBoxColumn VariacionOrd;
        private DataGridViewTextBoxColumn VariacionAnt;
        private DataGridViewTextBoxColumn PesoProm;
        private DataGridViewTextBoxColumn PesoPromP;
        private DataGridViewTextBoxColumn LoteEng;
        private Label lblEsperar;
        private Panel panel1;
        private DataGridViewTextBoxColumn Almacen1;
        private DataGridViewCheckBoxColumn Envio;
        private DataGridViewTextBoxColumn Lectura1;
        private DataGridViewTextBoxColumn Hora1;
        private DataGridViewTextBoxColumn Ajuste;
        private DataGridViewCheckBoxColumn Adelantar;
        private DataGridViewTextBoxColumn RacAct;
        private DataGridViewTextBoxColumn DiasAgr;
        private DataGridViewTextBoxColumn Dist;
        private DataGridViewTextBoxColumn Comp;
        private Label lblCorral;
        private Panel panelGrafica;
        private ToolStrip toolStrip1;
        private ToolStripButton btnRecibir;
        private ToolStripButton btnEnviar;
        private ToolStripButton btnCargar;
        private ToolStripButton btnGenerar;
        private ToolStripButton btnConfigurar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private TabControl tcFechas;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnUbicaciones;
        private Panel panelMapa;
        private ToolStrip toolStrip3;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private Button btnServida;
        private SplitContainer splitContainer1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripSeparator toolStripSeparator7;
        private TrackBar trackBar1;
        private Button btnSiguiente;
        private ToolStripLabel lblZoom;
    }
}