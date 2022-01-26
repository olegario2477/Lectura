using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Linq;
using System.Drawing.Drawing2D;

namespace Lectura
{
    // Imports System.Drawing.Drawing2D

    public partial class Lectura
    {

        double gLatitud = 21.923002;
        double gLongitud = -98.745503;
        int gorientacion = 0;
        private List<PointLatLng> _points;



        DataTable dtUbictmp;

        GMapPolygon polygonCelda;
        GMapOverlay overlayCeldas;
        GMarkerGoogle markerlabelCelda;
        GMapOverlay overlaylabelCeldas;



        public Lectura()
        {
            InitializeComponent();
            _points = new List<PointLatLng>();
            _GridLectura.Name = "GridLectura";
            _PanelLecturas.Name = "Panel1";
            _ComboComp.Name = "ComboComp";
            _TextoDiasAgregar.Name = "TextoDiasAgregar";
            _ComboDist.Name = "ComboDist";
            _TextoAjuste.Name = "TextoAjuste";
            _BotonBuscar.Name = "BotonBuscar";
            _TextoAlmacen.Name = "TextoAlmacen";
            _ComboLectura.Name = "ComboLectura";
            _BotonGrabar.Name = "BotonGrabar"; 
        }
        // ---------
        // Dim Dibujar As Boolean
        // Dim Grafico As Graphics
        // --------

        private string archivo;
        private string ar;
        private string efile = Application.StartupPath + @"\EXPORTAR.CSV";
        private string ifile = Application.StartupPath + @"\LECTURA_" + DateTime.Now.ToString("ddMMyyyy") + ".CSV";

        ConnectedWs connectar;

        String usuario = "";
        String contrasena = "";
        String equipo = "";

        String verrormsg = "";
        String vemsg = "";

        // Private Sub PictureBox1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PictureBox1.Paint

        // Grafico = e.Graphics

        // Dim Lapiz As New Pen(Brushes.Black, 3)


        // If Dibujar Then

        // Grafico.SmoothingMode = SmoothingMode.AntiAlias

        // Grafico.DrawArc(Lapiz, 85, 48, 45, 45, -60, 120)

        // Grafico.DrawLine(Lapiz, 50, 70, 120, 50)

        // Grafico.DrawLine(Lapiz, 50, 70, 120, 90)

        // End If

        // End Sub

        // Private Sub BotonGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        // modificar()

        // End Sub

        private void Lectura_Load(object sender, EventArgs e)
        {
            // ----------
            // Dibujar = True
            // PictureBox1.Refresh()
            // ----------

            lblEsperar.Visible = true;
   
            Text = "Lectura Comederos - v " + GetType().Assembly.GetName().Version.ToString() + " - " + bitModo();
            
            GridLectura.RowHeadersVisible = false;
            GridLectura.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridLectura.AllowUserToResizeRows = false;

            Grid.RowHeadersVisible = false;
            Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Grid.AllowUserToResizeRows = false;
            
            Grid.Height = 250;
            Chart1.Height = 350; //380;            
            posicionLabel();            
            this.Refresh();

            consultaConfiguraciones();


            EtiquetaFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            visualizar2();
         
            this.Refresh();

            ComboLectura.Text = "3";
            ComboDist.Text = "1";
            ComboComp.Text = "N";
            TextoAlmacen.Focus();
            //ruta();
            ruta2();

            lblEsperar.Visible = false;
            lblCorral.Visible = true;

            llenaPestanaFechas();




            tablaUbicTemp();
            cargaMapa();
            botonCeldas();
            busca();

        }

        private void Lectura_Resize(object sender, System.EventArgs e)
        {
            posicionLabel();
        }

        private void posicionLabel() 
        { 
       
            lblCorral.Top = Chart1.Height - lblCorral.Height;
            lblCorral.Left = 20;
 
        }

        public void grabar()
        {
            string loteeng = "";
            string vAdelantar;
            string strExport = "";
            if (Grid.RowCount > 0)
            {
                loteeng = Conversions.ToString(Grid.Rows[0].Cells["loteeng"].Value);
            }

            if (Strings.Len(TextoAjuste.Text) == 0)
            {
                TextoAjuste.Text = "0";
            }

            TextoDiasAgregar.Text = TextoDiasAgregar.Text.TrimStart('0');
            if (Strings.Len(TextoDiasAgregar.Text) == 0)
            {
                TextoDiasAgregar.Text = "0";
            }

            if (CheckAdelantar.Checked)
            {
                vAdelantar = "1";
            }
            else
            {
                vAdelantar = "0";
            }

            strExport = DateTime.Now.ToString("yyyyMMdd") + "," + TextoAlmacen.Text + "," + loteeng + "," + ComboLectura.Text + "," + DateAndTime.Now.TimeOfDay.ToString() + "," + TextoAjuste.Text + "," + vAdelantar + "," + EtiquetaRacAct.Text + "," + TextoDiasAgregar.Text + "," + ComboDist.Text + "," + ComboComp.Text;
            TextWriter tw = new StreamWriter(ifile, true);
            tw.WriteLine(strExport);
            tw.Close();

 
            MessageBox.Show("Agrego una Lectura", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Chart1.Series.Clear();
        }

        public void grabar2()
        {
            string loteeng = "";
            string vAdelantar;
            string strExport = "";
            if (Grid.RowCount > 0)
            {
                loteeng = Conversions.ToString(Grid.Rows[0].Cells["loteeng"].Value);
            }

            if (Strings.Len(TextoAjuste.Text) == 0)
            {
                TextoAjuste.Text = "0";
            }

            TextoDiasAgregar.Text = TextoDiasAgregar.Text.TrimStart('0');
            if (Strings.Len(TextoDiasAgregar.Text) == 0)
            {
                TextoDiasAgregar.Text = "0";
            }

            if (CheckAdelantar.Checked)
            {
                vAdelantar = "1";
            }
            else
            {
                vAdelantar = "0";
            }


            Datos datos = new Datos();
            DataTable dt = new DataTable();

            string campos = "fijo1,"
                            + "fijo2,"
                            + "fijo3,"
                            + "fijo4,"
                            + "fijo5,"
                            + "fijo6,"
                            + "fijo7,"
                            + "fijo8,"
                            + "fijo9,"
                            + "fijo10,"
                            + "fijo11";


            string valores = "'" 
                + DateTime.Now.ToString("yyyyMMdd") + "','" 
                + TextoAlmacen.Text + "','" 
                + loteeng + "','" 
                + ComboLectura.Text + "','"  
                + DateAndTime.Now.TimeOfDay.ToString().Substring(0, 8) + "','"  
                + TextoAjuste.Text + "','"  
                + vAdelantar + "','"  
                + EtiquetaRacAct.Text + "','"  
                + TextoDiasAgregar.Text + "','"  
                + ComboDist.Text + "','"  
                + ComboComp.Text + "'";


            datos.p_sql = "insert into lecturas (" + campos + ") values(" + valores + ")";

            if (!datos.consultaSQL(ref dt, false)) 
            {
                MessageBox.Show(datos.p_error, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

       
            MessageBox.Show("Agrego una Lectura", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Chart1.Series.Clear();
        }

        public void actualizar2(string valor)
        {
            string loteeng = "";
            string vAdelantar;
            string strExport = "";
            if (Grid.RowCount > 0)
            {
                loteeng = Conversions.ToString(Grid.Rows[0].Cells["loteeng"].Value);
            }

            if (Strings.Len(TextoAjuste.Text) == 0)
            {
                TextoAjuste.Text = "0";
            }

            TextoDiasAgregar.Text = TextoDiasAgregar.Text.TrimStart('0');
            if (Strings.Len(TextoDiasAgregar.Text) == 0)
            {
                TextoDiasAgregar.Text = "0";
            }

            if (CheckAdelantar.Checked)
            {
                vAdelantar = "1";
            }
            else
            {
                vAdelantar = "0";
            }


            Datos datos = new Datos();
            DataTable dt = new DataTable();


            string valores =
                "fijo1='" + DateTime.Now.ToString("yyyyMMdd") + "'," +
                "fijo2='" + TextoAlmacen.Text + "'," +
                "fijo3='" + loteeng + "'," +
                "fijo4='" + ComboLectura.Text + "'," +
                "fijo5='" + DateAndTime.Now.TimeOfDay.ToString().Substring(0,8) + "'," +
                "fijo6='" + TextoAjuste.Text + "'," +
                "fijo7='" + vAdelantar + "'," +
                "fijo8='" + EtiquetaRacAct.Text + "'," +
                "fijo9='" + TextoDiasAgregar.Text + "'," +
                "fijo10='" + ComboDist.Text + "'," +
                "fijo11='" + ComboComp.Text + "'";

            datos.p_sql = "update lecturas set " + valores + " where fijo2='" + valor + "'";

            if (!datos.consultaSQL(ref dt, false))
            {
                MessageBox.Show(datos.p_error, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }


            MessageBox.Show("Modifico una Lectura", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Chart1.Series.Clear();
        }

        public void limpiar()
        {
            Grid.Rows.Clear();
            // TextoAlmacen.Text = ""
            ComboLectura.Text = "";
            ComboLectura.Text = "3";
            ComboDist.Text = "1";
            ComboComp.Text = "N";
            TextoAjuste.Text = "";
            CheckAdelantar.Checked = false;
            TextoDiasAgregar.Text = "";
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            historial2();
        }

        // Private Sub TextoAlmacen_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        // If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then

        // historial()

        // ComboLectura.Focus()

        // e.Handled = True
        // End If
        // End Sub

        // Private Sub ComboLectura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        // If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then

        // modificar()

        // e.Handled = True
        // End If
        // End Sub

        public void ruta()
        {
            if (File.Exists(efile) == true)
            {
                var TextFieldParser1 = new Microsoft.VisualBasic.FileIO.TextFieldParser(efile);
                TextFieldParser1.Delimiters = new string[] { "," };
                Grid.Rows.Clear();
                while (!TextFieldParser1.EndOfData)
                {
                    var Row1 = TextFieldParser1.ReadFields();
                    if (string.IsNullOrEmpty(TextoAlmacen.Text))
                    {
                        TextoAlmacen.Text = Row1[1];
                        break;
                    }
                    else if ((TextoAlmacen.Text ?? "") == (Row1[1] ?? ""))
                    {
                        TextoAlmacen.Text = Row1[12];
                        break;
                    }
                }

                historial();
            }
        }

        public void ruta2()
        {

            DataTable dt = new DataTable();
            consultaHistorial(ref dt);

            Grid.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {

                if (string.IsNullOrEmpty(TextoAlmacen.Text))
                {
                    TextoAlmacen.Text = row[1].ToString();
                    break;
                }
                else if ((TextoAlmacen.Text ?? "") == (row[1].ToString() ?? ""))
                {
                    TextoAlmacen.Text = row[12].ToString();
                    break;
                }

            }

            historial2();

        }

        public void historial()
        {
            if (File.Exists(efile) == true)
            {
                var TextFieldParser1 = new Microsoft.VisualBasic.FileIO.TextFieldParser(efile);
                TextFieldParser1.Delimiters = new string[] { "," };
                Grid.Rows.Clear();
                EtiquetaDias.Text = "";
                while (!TextFieldParser1.EndOfData)
                {
                    var Row1 = TextFieldParser1.ReadFields();
                    if ((TextoAlmacen.Text ?? "") == (Row1[1] ?? ""))
                    {
                        Grid.Rows.Add(Strings.Mid(Row1[0], 7, 2) + "-" + Strings.Mid(Row1[0], 5, 2) + "-" + Strings.Mid(Row1[0], 1, 4), Row1[1], Row1[4], Row1[3], Row1[13], Row1[8], "", Row1[5], Row1[6], "", "", "", "", "", Row1[9], "", Row1[2]);
                        EtiquetaDias.Text = Row1[10];
                        EtiquetaRacAct.Text = Row1[14];
                        EtiquetaFechaFinRac.Text = Strings.Mid(Row1[15], 7, 2) + "/" + Strings.Mid(Row1[15], 5, 2) + "/" + Strings.Mid(Row1[15], 1, 4);
                    }
                }

                calculos();
                graficar();
                diasfinal();
            }
        }

        public void historial2()
        {

            DataTable dt = new DataTable();
            consultaHistorial(ref dt);

            Grid.Rows.Clear();
            EtiquetaDias.Text = "";

            foreach (DataRow row in dt.Rows)
            {

                if ((TextoAlmacen.Text ?? "") == (row[1].ToString() ?? ""))
                {
                    Grid.Rows.Add(Strings.Mid(row[0].ToString(), 7, 2) + "-" + Strings.Mid(row[0].ToString(), 5, 2) + "-" + Strings.Mid(row[0].ToString(), 1, 4), row[1].ToString(), row[4].ToString(), row[3].ToString(), row[13].ToString(), row[8].ToString(), "", row[5].ToString(), row[6].ToString(), "", "", "", "", "", row[9].ToString(), "", row[2].ToString());
                    EtiquetaDias.Text = row[10].ToString();
                    EtiquetaRacAct.Text = row[14].ToString();
                    EtiquetaFechaFinRac.Text = Strings.Mid(row[15].ToString(), 7, 2) + "/" + Strings.Mid(row[15].ToString(), 5, 2) + "/" + Strings.Mid(row[15].ToString(), 1, 4);
                }

            }

            calculos();
            graficar();
            diasfinal();

            

        }

        public void lee()
        {
            bool vAdelantar;

            if (File.Exists(ifile) == true)
            {
                var TextFieldParser1 = new Microsoft.VisualBasic.FileIO.TextFieldParser(ifile);
                TextFieldParser1.Delimiters = new string[] { "," };
                while (!TextFieldParser1.EndOfData)
                {
                    var Row1 = TextFieldParser1.ReadFields();
                    if ((Row1[1] ?? "") == (TextoAlmacen.Text ?? ""))
                    {
                        ComboLectura.Text = Row1[3];
                        TextoAjuste.Text = Row1[5];
                        EtiquetaRacAct.Text = Row1[7];
                        TextoDiasAgregar.Text = Row1[8];
                        ComboDist.Text = Row1[9];
                        ComboComp.Text = Row1[10];
                        if (Row1[6] == "1")
                        {
                            vAdelantar = true;
                        }
                        else
                        {
                            vAdelantar = false;
                        }

                        CheckAdelantar.Checked = vAdelantar;
                    }
                }
            }
        }

        public void lee2()
        {
            bool vAdelantar;

            DataTable dt = new DataTable();
            consultaLecturas(ref dt, EtiquetaFecha.Text, false);

            foreach (DataRow row in dt.Rows)
            {

                if ((row[1] ?? "") == (TextoAlmacen.Text ?? ""))
                {
                    ComboLectura.Text = row[3].ToString();
                    TextoAjuste.Text = row[5].ToString();
                    EtiquetaRacAct.Text = row[7].ToString();
                    TextoDiasAgregar.Text = row[8].ToString();
                    ComboDist.Text = row[9].ToString();
                    ComboComp.Text = row[10].ToString();
                    if (row[6].ToString() == "1")
                    {
                        vAdelantar = true;
                    }
                    else
                    {
                        vAdelantar = false;
                    }

                    CheckAdelantar.Checked = vAdelantar;
                }


            }


        }

        public void visualizar()
        {
            bool vAdelantar;
            if (File.Exists(ifile) == true)
            {
                var TextFieldParser1 = new Microsoft.VisualBasic.FileIO.TextFieldParser(ifile);
                TextFieldParser1.Delimiters = new string[] { "," };
                GridLectura.Rows.Clear();
                while (!TextFieldParser1.EndOfData)
                {
                    var Row1 = TextFieldParser1.ReadFields();
                    if (Row1[6] == "1")
                    {
                        vAdelantar = true;
                    }
                    else
                    {
                        vAdelantar = false;
                    }

                    GridLectura.Rows.Add(Row1[1], Row1[3], Row1[4], Row1[5], vAdelantar, Row1[7], Row1[8], Row1[9], Row1[10]);
                }

                // GridLectura.Rows(i - 1).Selected = True
                // GridLectura.CurrentCell = GridLectura.Rows(i - 1).Cells(0)

                GridLectura.Rows[GridLectura.Rows.Count - 1].Selected = true;
                GridLectura.CurrentCell = GridLectura.Rows[GridLectura.Rows.Count - 1].Cells[0];
            }
        }

        public void visualizar2()
        {

            bool vAdelantar;
            bool vEnvio;

            DataTable dt = new DataTable();
            consultaLecturas(ref dt, EtiquetaFecha.Text, false);
            
            GridLectura.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            { 
 
                if (row[6].ToString() == "1")
                {
                    vAdelantar = true;
                }
                else
                {
                    vAdelantar = false;
                }


                if (row[11].ToString() == "S")
                {
                    vEnvio = true;
                }
                else
                {
                    vEnvio = false;
                }

                GridLectura.Rows.Add(row[1].ToString().Trim(), vEnvio, row[3].ToString(), row[4].ToString(), row[5].ToString(), vAdelantar, row[7].ToString(), row[8].ToString(), row[9].ToString(), row[10].ToString());            
            }

            if (GridLectura.Rows.Count>0) 
            { 
                GridLectura.Rows[GridLectura.Rows.Count - 1].Selected = true;
                GridLectura.CurrentCell = GridLectura.Rows[GridLectura.Rows.Count - 1].Cells[0];            
            }

        }

        public void modificar()
        {
            int i;
            bool b = false;
            string vAdelantar;
            int cont;
            string alm;
            if (string.IsNullOrEmpty(TextoAlmacen.Text))
            {
                MessageBox.Show("Elija un Almacen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextoAlmacen.Focus();
                return;
                
            }

            if (Strings.Len(TextoAlmacen.Text) != 4)
            {
                MessageBox.Show("4 Caracteres el Almacen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextoAlmacen.Focus();
                return;
            }

            if (string.IsNullOrEmpty(ComboLectura.Text))
            {
                MessageBox.Show("Elija una Lectura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ComboLectura.Focus();
                return;
            }

            if (string.IsNullOrEmpty(ComboDist.Text))
            {
                MessageBox.Show("Elija una Calif", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ComboDist.Focus();
                return;
            }

            if ((ComboLectura.Text == "0" | ComboLectura.Text == "6") & Strings.Len(TextoAjuste.Text) == 0)
            {
                MessageBox.Show("Agregue peso ajuste", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextoAjuste.Focus();
                return;
            }

            if (File.Exists(ifile) == false)
            {
                grabar();
            }

            var lines = File.ReadAllLines(ifile);
            for (int x = 0, loopTo = lines.GetUpperBound(0); x <= loopTo; x++)
            {
                alm = "," + TextoAlmacen.Text + ",";
                if (lines[x].Contains(alm))
                {
                    b = true;
                    cont = 0;
                    var loopTo1 = Strings.Len(lines[x]);
                    for (i = 1; i <= loopTo1; i++)
                    {
                        if (Strings.Mid(lines[x], i, 1) == ",")
                        {
                            cont = cont + 1;
                            if (cont == 3)
                            {
                                break;
                            }
                        }
                    }
                                                            
                    if (string.IsNullOrEmpty(TextoAjuste.Text))
                    {
                        TextoAjuste.Text = "0";
                    }

                    TextoDiasAgregar.Text = TextoDiasAgregar.Text.TrimStart('0');
                    if (Strings.Len(TextoDiasAgregar.Text) == 0)
                    {
                        TextoDiasAgregar.Text = "0";
                    }

                    if (CheckAdelantar.Checked)
                    {
                        vAdelantar = "1";
                    }
                    else
                    {
                        vAdelantar = "0";
                    }

                    lines[x] = Strings.Mid(lines[x], 1, i) + ComboLectura.Text + "," + DateAndTime.Now.TimeOfDay.ToString() + "," + TextoAjuste.Text + "," + vAdelantar + "," + EtiquetaRacAct.Text + "," + TextoDiasAgregar.Text + "," + ComboDist.Text + "," + ComboComp.Text;
                }
            }

            if (b)
            {
                // modificar
                File.WriteAllLines(ifile, lines);
                MessageBox.Show("Modifico una Lectura", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Chart1.Series.Clear();
            }
            else
            {

                // insertar
                grabar();

                // GridLectura.Rows(GridLectura.Rows.Count - 1).Selected = True
                // GridLectura.CurrentCell = GridLectura.Rows(GridLectura.Rows.Count - 1).Cells(0)

            }

            limpiar();
            visualizar();
            TextoAlmacen.Focus();

        }

        public void modificar2()
        {

            int i;
            bool b = false;
            string vAdelantar;
            //int cont;
            string alm = "";

            if (string.IsNullOrEmpty(TextoAlmacen.Text))
            {
                MessageBox.Show("Elija un Almacen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextoAlmacen.Focus();
                return;
            }

            if (Strings.Len(TextoAlmacen.Text) != 4)
            {
                MessageBox.Show("4 Caracteres el Almacen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextoAlmacen.Focus();
                return;
            }

            if (string.IsNullOrEmpty(ComboLectura.Text))
            {
                MessageBox.Show("Elija una Lectura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ComboLectura.Focus();
                return;
            }

            if (string.IsNullOrEmpty(ComboDist.Text))
            {
                MessageBox.Show("Elija una Calif", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ComboDist.Focus();
                return;
            }

            if ((ComboLectura.Text == "0" | ComboLectura.Text == "6") & Strings.Len(TextoAjuste.Text) == 0)
            {
                MessageBox.Show("Agregue peso ajuste", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextoAjuste.Focus();
                return;
            }



            DataTable dt = new DataTable();
            consultaLecturas(ref dt, EtiquetaFecha.Text, false);

            foreach (DataRow row in dt.Rows)
            { 

                alm = TextoAlmacen.Text;
                if (row[1].ToString().Contains(alm))
                {
                    b = true;

                    if (string.IsNullOrEmpty(TextoAjuste.Text))
                    {
                        TextoAjuste.Text = "0";
                    }

                    TextoDiasAgregar.Text = TextoDiasAgregar.Text.TrimStart('0');
                    if (Strings.Len(TextoDiasAgregar.Text) == 0)
                    {
                        TextoDiasAgregar.Text = "0";
                    }

                    if (CheckAdelantar.Checked)
                    {
                        vAdelantar = "1";
                    }
                    else
                    {
                        vAdelantar = "0";
                    }
                         
                    break;
                
                }

            }

            if (b)
            {
                // modificar
                actualizar2(alm);
                //File.WriteAllLines(ifile, lines);
                //MessageBox.Show("Modifico una Lectura", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Chart1.Series.Clear();
            }
            else
            {

                // insertar
                grabar2();

                // GridLectura.Rows(GridLectura.Rows.Count - 1).Selected = True
                // GridLectura.CurrentCell = GridLectura.Rows(GridLectura.Rows.Count - 1).Cells(0)

            }

            limpiar();
            visualizar2();
            TextoAlmacen.Focus();

        }

        public void graficar()
        {
            double mayor;
            double menor;
            double valor;
            string cadena = Grid.Columns["servido"].HeaderText;
            string cadena1 = Grid.Columns["maximo"].HeaderText;
            string cadena2 = Grid.Columns["minimo"].HeaderText;

            lblCorral.Text = TextoAlmacen.Text;

            Chart1.Series.Clear();
            if (Grid.RowCount > 0)
            {
                Chart1.Series.Add(cadena);
                Chart1.Series.Add(cadena1);
                Chart1.Series.Add(cadena2);
                Chart1.Series[cadena].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                Chart1.Series[cadena1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                Chart1.Series[cadena2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                Chart1.Series[cadena].Points.Clear();
                Chart1.Series[cadena1].Points.Clear();
                Chart1.Series[cadena2].Points.Clear();
                Chart1.Series[cadena].Color = Color.Blue;
                Chart1.Series[cadena1].Color = Color.Red;
                Chart1.Series[cadena2].Color = Color.Yellow;
                Chart1.Series[cadena].IsValueShownAsLabel = true;
                Chart1.Series[cadena1].IsValueShownAsLabel = true;
                Chart1.Series[cadena2].IsValueShownAsLabel = true;
                for (int i = Grid.RowCount - 1; i >= 0; i -= 1)
                {
                    Chart1.Series[cadena].Points.AddXY(Strings.Mid(Conversions.ToString(Grid.Rows[i].Cells["fecha"].Value), 1, 2), Grid.Rows[i].Cells["servido"].Value);
                    Chart1.Series[cadena1].Points.AddXY(Strings.Mid(Conversions.ToString(Grid.Rows[i].Cells["fecha"].Value), 1, 2), Grid.Rows[i].Cells["maximo"].Value);
                    Chart1.Series[cadena2].Points.AddXY(Strings.Mid(Conversions.ToString(Grid.Rows[i].Cells["fecha"].Value), 1, 2), Grid.Rows[i].Cells["minimo"].Value);
                }

                Chart1.ChartAreas[0].AxisX.Interval = 1d;
                mayor = Conversions.ToDouble(Grid.Rows[0].Cells["servido"].Value);
                for (int i = 1, loopTo = Grid.RowCount - 1; i <= loopTo; i++)
                {
                    valor = Conversions.ToDouble(Grid.Rows[i].Cells["servido"].Value);
                    if (valor > mayor)
                    {
                        mayor = valor;
                    }
                }

                menor = Conversions.ToDouble(Grid.Rows[0].Cells["servido"].Value);
                for (int i = 1, loopTo1 = Grid.RowCount - 1; i <= loopTo1; i++)
                {
                    valor = Conversions.ToDouble(Grid.Rows[i].Cells["servido"].Value);
                    if (valor < menor)
                    {
                        menor = valor;
                    }
                }

                Chart1.ChartAreas[0].AxisY.Minimum = menor - 50d;
                Chart1.ChartAreas[0].AxisY.Maximum = mayor + 50d;
                Chart1.ChartAreas[0].AxisY.Interval = 100d;
            }
        }

        public void calculos()
        {
            double suma;
            int i, j;
            var loopTo = Grid.RowCount - 1;
            for (i = 0; i <= loopTo; i++)
            {
                suma = 0d;
                for (j = 0; j <= 3; j++)
                {
                    if (i + j <= Grid.RowCount - 1)
                    {
                        suma = Conversions.ToDouble(Operators.AddObject(suma, Grid.Rows[i + j].Cells["servido"].Value));
                    }
                    // j = j + 1
                    else
                    {
                        break;
                    }
                }

                ;
                if (j > 0)
                {
                    // servidoprom
                    Grid.Rows[i].Cells["promedio"].Value = string.Format("{0:0.000}", suma / j);
                }
                else
                {
                    Grid.Rows[i].Cells["promedio"].Value = "0";
                }

                // max
                Grid.Rows[i].Cells["maximo"].Value = string.Format("{0:0.000}", Operators.MultiplyObject(Grid.Rows[i].Cells["promedio"].Value, 1.015d));

                // min
                Grid.Rows[i].Cells["minimo"].Value = string.Format("{0:0.000}", Operators.MultiplyObject(Grid.Rows[i].Cells["promedio"].Value, 0.985d));

                // variacionord
                Grid.Rows[i].Cells["variacionord"].Value = string.Format("{0:0.00%}", Operators.DivideObject(Operators.SubtractObject(Grid.Rows[i].Cells["servido"].Value, Grid.Rows[i].Cells["planeado"].Value), Grid.Rows[i].Cells["planeado"].Value));
                if (i > 0)
                {
                    // variacionant
                    Grid.Rows[i].Cells["variacionant"].Value = string.Format("{0:0.00%}", Operators.DivideObject(Operators.SubtractObject(Grid.Rows[i].Cells["servido"].Value, Grid.Rows[i - 1].Cells["servido"].Value), Grid.Rows[i - 1].Cells["servido"].Value));
                }

                // pp%
                Grid.Rows[i].Cells["pesopromp"].Value = string.Format("{0:0.00%}", Operators.DivideObject(Operators.DivideObject(Grid.Rows[i].Cells["servido"].Value, Grid.Rows[i].Cells["cabezas"].Value), Grid.Rows[i].Cells["pesoprom"].Value));

                // pesoprom
                Grid.Rows[i].Cells["pesoprom"].Value = string.Format("{0:0.000}", Operators.DivideObject(Grid.Rows[i].Cells["pesoprom"].Value, 1));

                // pp%
                Grid.Rows[i].Cells["servidoprom"].Value = string.Format("{0:0.000}", Operators.DivideObject(Grid.Rows[i].Cells["servido"].Value, Grid.Rows[i].Cells["cabezas"].Value));
            }
        }

        private void BotonBuscar_Click_1(object sender, EventArgs e)
        {
            busca();
        }

        public void busca()
        {
            historial2();
            lee2();
            ubicaCorralMapa();
        }

        private void BotonGrabar_Click_1(object sender, EventArgs e)
        {
            modificar2();
            ruta2();
        }

        private void TextoAlmacen_KeyPress1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                historial2();
                ubicaCorralMapa();
                lee2();
                ComboLectura.Focus();
                e.Handled = true;
            }
        }

        private void ComboLectura_KeyPress1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                switch (ComboLectura.Text ?? "")
                {
                    case "0":
                    case "6":
                        {
                            TextoAjuste.Enabled = true;
                            TextoAjuste.Focus();
                            break;
                        }

                    default:
                        {
                            TextoAjuste.Enabled = false;
                            // BotonGrabar.Focus()
                            ComboDist.Focus();
                            break;
                        }
                        // modificar()
                }

                e.Handled = true;
            }
        }

        private void TextoAjuste_KeyPress1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                ComboDist.Focus();
                // BotonGrabar.Focus()
                // modificar()

                e.Handled = true;
            }
        }

        private void ComboLectura_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ComboLectura.Text ?? "")
            {
                case "0":
                case "6":
                    {
                        TextoAjuste.Enabled = true;
                        break;
                    }

                default:
                    {
                        TextoAjuste.Enabled = false;
                        break;
                    }
            }
        }

        private void ComboDist_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                ComboComp.Focus();
            }
        }

        public void Numeros(TextBox CajaTexto, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TextoDiasAgregar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Numeros(TextoDiasAgregar, e);
        }

        private void TextoDiasAgregar_TextChanged(object sender, EventArgs e)
        {
            diasfinal();
        }

        public void diasfinal()
        {
            DateTime fecha1;
            var dias1 = default(long);
            if (EtiquetaRacAct.Text == "R4" | EtiquetaRacAct.Text == "R5" | EtiquetaRacAct.Text == "R6")
            {
                TextoDiasAgregar.Text = "0";
                TextoDiasAgregar.Enabled = false;
                CheckAdelantar.Enabled = false;
                CheckAdelantar.Checked = false;
            }
            else
            {
                if (EtiquetaFechaFinRac.Text != "00/00/0000" && EtiquetaFechaFinRac.Text != " " && EtiquetaFechaFinRac.Text != "//")
                {
                    fecha1 = Conversions.ToDate(EtiquetaFechaFinRac.Text);
                    dias1 = Conversions.ToLong(Interaction.IIf(!string.IsNullOrEmpty(TextoDiasAgregar.Text), TextoDiasAgregar.Text, "0"));
                    fecha1 = fecha1.AddDays(dias1);
                    EtiquetaFechaFinNva.Text = Conversions.ToString(fecha1);
                    TextoDiasAgregar.Enabled = true;
                }
                else
                {
                    EtiquetaFechaFinNva.Text = "00/00/0000";
                    TextoDiasAgregar.Enabled = false;
                }

                if (dias1 == 0L)
                {
                    CheckAdelantar.Enabled = true;
                }
                else
                {
                    CheckAdelantar.Enabled = false;
                    CheckAdelantar.Checked = false;
                }
            }
        }

        private void ComboComp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                BotonGrabar.Focus();
            }
        }

        // Private Sub GridLectura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles GridLectura.KeyPress
        // If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
        // TextoAlmacen.Focus()
        // End If
        // End Sub

        // Private Sub GridLectura_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridLectura.CellClick
        // grid_mostrar()
        // End Sub

        private void GridLectura_SelectionChanged(object sender, EventArgs e)
        {
            if (GridLectura.Focused)
            {
                grid_mostrar();
            }
        }

        public void grid_mostrar()
        {
            if (GridLectura.RowCount > 0)
            {
                TextoAlmacen.Text = Conversions.ToString(GridLectura[0, GridLectura.CurrentCell.RowIndex].Value);
                busca();
            }
        }

        private void GridLectura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridLectura.Focused)
            {
                grid_mostrar();
            }
        }

        private void TextoAlmacen_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private string bitModo()
        {
            string bitModoRet = default;
            string valor = "";
            if (IntPtr.Size == 8)
            {
                valor = " 64 bits";
            }
            else if (IntPtr.Size == 4)
            {
                valor = " 32 bits";
            }

            bitModoRet = valor;
            return bitModoRet;
        }

        private void recibirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            recibitHistorial();
        }

        private void recibitHistorial() 
        {

            if (!redConectado())
            {
                MessageBox.Show("Sin red disponible.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                if (MessageBox.Show("¿ Desea actualizar historial servidas con ws ?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataTable dt = new DataTable();
                    if (!obtenerWsdlHistorialSap(ref dt))
                    {
                        MessageBox.Show(verrormsg, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        guardaHistorial(dt);

                        TextoAlmacen.Text = "";
                        visualizar2();
                        ruta2();
                        MessageBox.Show("Listo, cargo hitorial de servidas con ws", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
        
            }
        
        }

        private Boolean obtenerWsdlHistorialSap(ref DataTable dtsalida)
        {

            Cursor = Cursors.WaitCursor;

            ArrayList lista = new ArrayList();

            string seleccion = "HISTORIAL";

            DateTime fecha = DateTime.Today;
            //fecha = new DateTime(2020, 12, 01);
            fecha = DateTime.Now;

            Thread t = new Thread(() => { cargarWSDLSel(seleccion, fecha, equipo, ""); });
            t.Name = seleccion;
            t.IsBackground = true;
            t.Start();

            Console.WriteLine(t.Name + " " + t.ManagedThreadId.ToString() + " " + DateTime.Now.ToString());

            t.Join();

            lista = connectar.getList();
            String errormsg = connectar.getError();
            String emsg = connectar.getEmsg();



            DataTable dttmp = new DataTable();
            dttmp.Columns.Add("fijo1");
            dttmp.Columns.Add("fijo2");
            dttmp.Columns.Add("fijo3");
            dttmp.Columns.Add("fijo4");
            dttmp.Columns.Add("fijo5");
            dttmp.Columns.Add("fijo6");
            dttmp.Columns.Add("fijo7");
            dttmp.Columns.Add("fijo8");
            dttmp.Columns.Add("fijo9");
            dttmp.Columns.Add("fijo10");
            dttmp.Columns.Add("fijo11");
            dttmp.Columns.Add("fijo12");
            dttmp.Columns.Add("fijo13");
            dttmp.Columns.Add("fijo14");
            dttmp.Columns.Add("fijo15");
            dttmp.Columns.Add("fijo16");


            foreach (String listar in lista)
            {

                string[] lines = listar.Split('|');

                DataRow newRow = dttmp.NewRow();

                //lines[0] = lines[0].Insert(4, "-");
                //lines[0] = lines[0].Insert(7, "-");
                newRow["fijo1"] = lines[0].Trim();
                newRow["fijo2"] = lines[1].Trim();
                newRow["fijo3"] = lines[2].Trim();
                newRow["fijo4"] = lines[3].Trim();
                newRow["fijo5"] = lines[4].Trim();
                newRow["fijo6"] = lines[5].Trim();
                newRow["fijo7"] = lines[6].Trim();
                newRow["fijo8"] = lines[7].Trim();
                newRow["fijo9"] = lines[8].Trim();
                newRow["fijo10"] = lines[9].Trim();
                newRow["fijo11"] = lines[10].Trim();
                newRow["fijo12"] = lines[11].Trim();
                newRow["fijo13"] = lines[12].Trim();
                newRow["fijo14"] = lines[13].Trim();
                newRow["fijo15"] = lines[14].Trim();
                newRow["fijo16"] = lines[15].Trim();

                dttmp.Rows.Add(newRow);

            }

            dtsalida = dttmp;

            verrormsg = "";

            Cursor = Cursors.Default;

            if (!errormsg.Equals(""))
            {
                verrormsg = errormsg;
                return false;
            }
            else 
            {
                return true;
            }


        }

        private void obtenerWsdlHistorialArchivo(string archivo, ref DataTable dtsalida)
        {

            if (File.Exists(archivo) == true)
            {

                eliminarHistorial();

                DataTable dttmp = new DataTable();
                dttmp.Columns.Add("fijo1");
                dttmp.Columns.Add("fijo2");
                dttmp.Columns.Add("fijo3");
                dttmp.Columns.Add("fijo4");
                dttmp.Columns.Add("fijo5");
                dttmp.Columns.Add("fijo6");
                dttmp.Columns.Add("fijo7");
                dttmp.Columns.Add("fijo8");
                dttmp.Columns.Add("fijo9");
                dttmp.Columns.Add("fijo10");
                dttmp.Columns.Add("fijo11");
                dttmp.Columns.Add("fijo12");
                dttmp.Columns.Add("fijo13");
                dttmp.Columns.Add("fijo14");
                dttmp.Columns.Add("fijo15");
                dttmp.Columns.Add("fijo16");

                var TextFieldParser1 = new Microsoft.VisualBasic.FileIO.TextFieldParser(archivo);
                TextFieldParser1.Delimiters = new string[] { "," };
                while (!TextFieldParser1.EndOfData)
                {

                    var Row1 = TextFieldParser1.ReadFields();

                    DataRow newRow = dttmp.NewRow();

                    newRow["fijo1"] = Row1[0].Trim();
                    newRow["fijo2"] = Row1[1].Trim();
                    newRow["fijo3"] = Row1[2].Trim();
                    newRow["fijo4"] = Row1[3].Trim();
                    newRow["fijo5"] = Row1[4].Trim();
                    newRow["fijo6"] = Row1[5].Trim();
                    newRow["fijo7"] = Row1[6].Trim();
                    newRow["fijo8"] = Row1[7].Trim();
                    newRow["fijo9"] = Row1[8].Trim();
                    newRow["fijo10"] = Row1[9].Trim();
                    newRow["fijo11"] = Row1[10].Trim();
                    newRow["fijo12"] = Row1[11].Trim();
                    newRow["fijo13"] = Row1[12].Trim();
                    newRow["fijo14"] = Row1[13].Trim();
                    newRow["fijo15"] = Row1[14].Trim();
                    newRow["fijo16"] = Row1[15].Trim();

                    dttmp.Rows.Add(newRow);

                }

                dtsalida = dttmp;

            }



        }

        private void cargarWSDLSel(String catalogo, DateTime fecha, String equipo, String parametros)
        {

            connectar = new ConnectedWs(Constants.OPERACION_CATALOGO, catalogo, usuario, contrasena, fecha.ToString("yyyy-MM-dd"), equipo, parametros);
            connectar.getDataWs();

        }



        private void guardaHistorial(DataTable dtentrada)
        {

            Datos datos = new Datos();
            DataTable dt = new DataTable();

            this.Cursor = Cursors.WaitCursor;

            datos.p_sql = "DELETE FROM historial";

            if (!datos.consultaSQL(ref dt, true))
            {
                //MessageBox.Show(datos.p_error, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                MessageBox.Show(datos.p_error, "Mensaje");
            }


            List<string> dbRegistros = new List<string>();

            foreach (DataRow row in dtentrada.Rows)
            {
                string campos = "fijo1," 
                    + "fijo2,"
                    + "fijo3,"
                    + "fijo4,"
                    + "fijo5,"
                    + "fijo6,"
                    + "fijo7,"
                    + "fijo8,"
                    + "fijo9,"
                    + "fijo10,"
                    + "fijo11,"
                    + "fijo12,"
                    + "fijo13,"
                    + "fijo14,"
                    + "fijo15,"
                    + "fijo16";

                string valores = "'" 
                     + row["fijo1"].ToString() + "','"
                     + row["fijo2"].ToString() + "','"
                     + row["fijo3"].ToString() + "','"
                     + row["fijo4"].ToString() + "','"
                     + row["fijo5"].ToString() + "','"
                     + row["fijo6"].ToString() + "','"
                     + row["fijo7"].ToString() + "','"
                     + row["fijo8"].ToString() + "','"
                     + row["fijo9"].ToString() + "','"
                     + row["fijo10"].ToString() + "','"
                     + row["fijo11"].ToString() + "','"
                     + row["fijo12"].ToString() + "','"
                     + row["fijo13"].ToString() + "','"
                     + row["fijo14"].ToString() + "','"
                     + row["fijo15"].ToString() + "','"
                     + row["fijo16"].ToString() + "'";


                dbRegistros.Add("insert into historial ("+campos+") values("+valores+")");
            }


            datos.p_sql_list = dbRegistros;

            if (!datos.consultaSQLs(ref dt))
            {
                //MessageBox.Show(datos.p_error, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                MessageBox.Show(datos.p_error, "Mensaje");
            }
            else
            {

            }

            this.Cursor = Cursors.Default;

        }

        private void eliminarHistorial()
        {

            Datos datos = new Datos();
            DataTable dt = new DataTable();

            this.Cursor = Cursors.WaitCursor;

            datos.p_sql = "DELETE FROM historial";

            if (!datos.consultaSQL(ref dt, true))
            {
                //MessageBox.Show(datos.p_error, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Stop);                
            }


        }

        private void consultaHistorial(ref DataTable dt)
        {

            Datos datos = new Datos();
            DataTable dt2 = new DataTable();

            this.Cursor = Cursors.WaitCursor;

            datos.p_sql = "SELECT * FROM historial";

            if (!datos.consultaSQL(ref dt2, true))
            {
                //MessageBox.Show(datos.p_error, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                MessageBox.Show(datos.p_error, "Mensaje");
            }
            else
            {

                DataTable dttmp = new DataTable();
                dttmp.Columns.Add("fijo1");
                dttmp.Columns.Add("fijo2");
                dttmp.Columns.Add("fijo3");
                dttmp.Columns.Add("fijo4");
                dttmp.Columns.Add("fijo5");
                dttmp.Columns.Add("fijo6");
                dttmp.Columns.Add("fijo7");
                dttmp.Columns.Add("fijo8");
                dttmp.Columns.Add("fijo9");
                dttmp.Columns.Add("fijo10");
                dttmp.Columns.Add("fijo11");
                dttmp.Columns.Add("fijo12");
                dttmp.Columns.Add("fijo13");
                dttmp.Columns.Add("fijo14");
                dttmp.Columns.Add("fijo15");
                dttmp.Columns.Add("fijo16");

                foreach (DataRow row in dt2.Rows)
                {

                    DataRow newRow = dttmp.NewRow();

                    newRow["fijo1"] = row["fijo1"];
                    newRow["fijo2"] = row["fijo2"];
                    newRow["fijo3"] = row["fijo3"];
                    newRow["fijo4"] = row["fijo4"];
                    newRow["fijo5"] = row["fijo5"];
                    newRow["fijo6"] = row["fijo6"];
                    newRow["fijo7"] = row["fijo7"];
                    newRow["fijo8"] = row["fijo8"];
                    newRow["fijo9"] = row["fijo9"];
                    newRow["fijo10"] = row["fijo10"];
                    newRow["fijo11"] = row["fijo11"];
                    newRow["fijo12"] = row["fijo12"];
                    newRow["fijo13"] = row["fijo13"];
                    newRow["fijo14"] = row["fijo14"];
                    newRow["fijo15"] = row["fijo15"];
                    newRow["fijo16"] = row["fijo16"];

                    dttmp.Rows.Add(newRow);

                }

                dt = dttmp;

            }

            this.Cursor = Cursors.Default;

        }

        private void consultaLecturas(ref DataTable dt, string fecha, Boolean pendEnvio)
        {

            Datos datos = new Datos();
            DataTable dt2 = new DataTable();

            this.Cursor = Cursors.WaitCursor;

            string vfecha = fecha.Substring(6, 4)+fecha.Substring(3, 2)+fecha.Substring(0, 2);

            datos.p_sql = "SELECT * FROM lecturas WHERE fijo1 ='"+vfecha+"'";

            if (pendEnvio) 
            {
                datos.p_sql = datos.p_sql + " AND envio = 'N'";
            }

            if (!datos.consultaSQL(ref dt2, true))
            {
                //MessageBox.Show(datos.p_error, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                MessageBox.Show(datos.p_error, "Mensaje");
            }
            else
            {

                DataTable dttmp = new DataTable();
                dttmp.Columns.Add("fijo1");
                dttmp.Columns.Add("fijo2");
                dttmp.Columns.Add("fijo3");
                dttmp.Columns.Add("fijo4");
                dttmp.Columns.Add("fijo5");
                dttmp.Columns.Add("fijo6");
                dttmp.Columns.Add("fijo7");
                dttmp.Columns.Add("fijo8");
                dttmp.Columns.Add("fijo9");
                dttmp.Columns.Add("fijo10");
                dttmp.Columns.Add("fijo11");
                dttmp.Columns.Add("envio");

                foreach (DataRow row in dt2.Rows)
                {

                    DataRow newRow = dttmp.NewRow();

                    newRow["fijo1"] = row["fijo1"];
                    newRow["fijo2"] = row["fijo2"];
                    newRow["fijo3"] = row["fijo3"];
                    newRow["fijo4"] = row["fijo4"];
                    newRow["fijo5"] = row["fijo5"];
                    newRow["fijo6"] = row["fijo6"];
                    newRow["fijo7"] = row["fijo7"];
                    newRow["fijo8"] = row["fijo8"];
                    newRow["fijo9"] = row["fijo9"];
                    newRow["fijo10"] = row["fijo10"];
                    newRow["fijo11"] = row["fijo11"];
                    newRow["envio"] = row["envio"];

                    dttmp.Rows.Add(newRow);

                }

                dt = dttmp;

            }

            this.Cursor = Cursors.Default;

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cargaArchivo();
        }

        private void generarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generaArchivo(EtiquetaFecha.Text);
        }

        private void generaArchivo(string fecha)
        {

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "csv file|*.csv";
            saveFileDialog1.Title = "Guardar como...";
            saveFileDialog1.FileName = "LECTURA_" + DateTime.Now.ToString("ddMMyyyy") +"_"+ DateTime.Now.ToString("HHmmss") + ".CSV";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                if (saveFileDialog1.FileName != "")
                {

                    DataTable dt = new DataTable();
                    consultaLecturas(ref dt, fecha, false);

                    TextWriter tw = new StreamWriter(saveFileDialog1.FileName, true);

                    foreach (DataRow row in dt.Rows)
                    {

                        string strExport =
                            row[0].ToString() + "," +
                            row[1].ToString() + "," +
                            row[2].ToString() + "," +
                            row[3].ToString() + "," +
                            row[4].ToString() + "," +
                            row[5].ToString() + "," +
                            row[6].ToString() + "," +
                            row[7].ToString() + "," +
                            row[8].ToString() + "," +
                            row[9].ToString() + "," +
                            row[10].ToString() + "";

                        tw.WriteLine(strExport);

                    }

                    tw.Close();

                    MessageBox.Show("Listo, genero archivo de lecturas", "Mensaje");

                }
            
            }
        }

        private void cargaArchivo()
        {

            if (MessageBox.Show("¿ Desea cargar historial servidas desde archivo ?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "csv file|*.csv";
                openFileDialog1.Title = "Abrir";
                openFileDialog1.FileName = "EXPORTAR" + ".CSV";
                if (openFileDialog1.ShowDialog()== DialogResult.OK)
                {
                    if (openFileDialog1.FileName != "")
                    {

                        DataTable dt = new DataTable();

                        obtenerWsdlHistorialArchivo(openFileDialog1.FileName, ref dt);
                        guardaHistorial(dt);
                        MessageBox.Show("Listo, cargo historial servidas desde archivo", "Mensaje");

                    }
                }

            }

        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opcionConfigurar();
        }

        private void opcionConfigurar() 
        { 
            consultaConfiguraciones();
            panelConfiguracion.Location = new System.Drawing.Point(12,12);
            panelConfiguracion.Visible = true;            
        }

        private void btnCerrarConfiguracion_Click(object sender, EventArgs e)
        {
            panelConfiguracion.Visible = false;
        }

        private void btnGuardarConfiguracion_Click(object sender, EventArgs e)
        {
            guardaConfiguraciones();
            panelConfiguracion.Visible = false;
        }


        private void consultaConfiguraciones() 
        {

            Datos datos = new Datos();
            DataTable dt = new DataTable();

            datos.p_sql = "SELECT * FROM configuracion";

            usuario = "";
            contrasena = "";
            equipo = "";

            if (!datos.consultaSQL(ref dt, true))
            {
                MessageBox.Show(datos.p_error, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {

                foreach (DataRow row in dt.Rows)
                {

                    usuario = row["usuario"].ToString();
                    contrasena = row["contrasena"].ToString();
                    equipo = row["equipo"].ToString();

                }

            }

            txtUsuario.Text = usuario;
            txtContrasena.Text = contrasena;
            txtEquipo.Text = equipo;

        }

        private void guardaConfiguraciones()
        {

            Datos datos = new Datos();
            DataTable dt = new DataTable();

            string valores =
                "equipo='" + txtEquipo.Text + "'," +
                "usuario='" + txtUsuario.Text + "'," +
                "contrasena='" + txtContrasena.Text + "'";

            datos.p_sql = "update configuracion set " + valores;

            if (!datos.consultaSQL(ref dt, false))
            {
                MessageBox.Show(datos.p_error, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            equipo = txtEquipo.Text;
            usuario = txtUsuario.Text;
            contrasena = txtContrasena.Text;


        }

        private void enviarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enviarLecturas(EtiquetaFecha.Text);
        }

        private void enviarLecturas(string fecha)
        {

            if (!redConectado())
            {
                MessageBox.Show("Sin red disponible.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                if (MessageBox.Show("¿ Desea enviar lecturas con ws ?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    DataTable dt = new DataTable();

                    consultaLecturas(ref dt, fecha, true);

                    if (!enviarWsdlLecturasSap(dt))
                    {
                        MessageBox.Show(verrormsg, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {

                        if (vemsg.ToUpper().Contains("ok".ToUpper()))
                        {
                            envioLecturas(EtiquetaFecha.Text);
                            visualizar2();
                            GridLectura.Refresh();
                            MessageBox.Show(vemsg, "Mensaje", MessageBoxButtons.OK);
                        }
                        else if (vemsg.ToUpper().Contains("error".ToUpper()))
                        {
                            MessageBox.Show(vemsg, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else if (vemsg.ToUpper().Contains("alerta".ToUpper()))
                        {
                            MessageBox.Show(vemsg, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }

                }
            
            }

        }

        private void envioLecturas(string fecha) 
        {

            Datos datos = new Datos();
            DataTable dt = new DataTable();

            string vfecha = fecha.Substring(6, 4) + fecha.Substring(3, 2) + fecha.Substring(0, 2);

            datos.p_sql = "update lecturas set envio = 'S' where fijo1='" + vfecha + "'";

            if (!datos.consultaSQL(ref dt, false))
            {
                //MessageBox.Show(datos.p_error, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }


        }

        private Boolean enviarWsdlLecturasSap(DataTable dt)
        {

            Cursor = Cursors.WaitCursor;

            ArrayList lista = new ArrayList();

            lista.Clear();

            foreach (DataRow row in dt.Rows)
            {

                lista.Add(
                    row["fijo1"].ToString() + "|" +
                    row["fijo2"].ToString() + "|" +
                    row["fijo3"].ToString() + "|" +
                    row["fijo4"].ToString() + "|" +
                    row["fijo5"].ToString() + "|" +
                    row["fijo6"].ToString() + "|" +
                    row["fijo7"].ToString() + "|" +
                    row["fijo8"].ToString() + "|" +
                    row["fijo9"].ToString() + "|" +
                    row["fijo10"].ToString() + "|" +
                    row["fijo11"].ToString() 


                    //row["Numcamion"].ToString() + "|" +
                    //row["Jornada"].ToString() + "|" +
                    //row["Fecha"].ToString().Substring(0, 2) + "." + row["Fecha"].ToString().Substring(3, 2) + ".20" + row["Fecha"].ToString().Substring(6, 2) + "|" +
                    //row["Hora"].ToString() + ":00" + "|" +
                    //row["Corral"].ToString() + "|" +
                    //row["Servida"].ToString() + "|" +
                    //row["Racion"].ToString() + "|" +
                    //row["planeado"].ToString() + "|" +
                    //row["Realidad"].ToString()

                );

            }

            Thread t = new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                transferirWSDLSel(lista);
            });
            t.Start();

            t.Join();

            String errormsg = connectar.getError();
            String emsg = connectar.getEmsg();


            verrormsg = "";

            Cursor = Cursors.Default;

            if (!errormsg.Equals(""))
            {
                verrormsg = errormsg;
                return false;
            }
            else
            {
                vemsg = emsg;
                return true;
            }


        }


        private void transferirWSDLSel(ArrayList lectura)
        {
            try
            {
                connectar = new ConnectedWs(Constants.OPERACION_TRANSFERIR, lectura, usuario, contrasena, equipo, "");
                connectar.setDataWs();
            }
            catch { }

            
        }

        private Boolean redConectado()
        {
            return System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
        }

        private void btnRecibir_Click(object sender, EventArgs e)
        {
            recibitHistorial();
            botonCeldas();
            busca();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            enviarLecturas(EtiquetaFecha.Text);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            cargaArchivo();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            generaArchivo(EtiquetaFecha.Text);
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            opcionConfigurar();
        }

        private void llenaPestanaFechas() 
        {

            Datos datos = new Datos();
            DataTable dt = new DataTable();

            tcFechas.TabPages.Clear();

            datos.p_sql = "SELECT DISTINCT fijo1 FROM lecturas ORDER BY fijo1 DESC";

            if (!datos.consultaSQL(ref dt, true))
            {
                MessageBox.Show(datos.p_error, "Mensaje");
            }
            else
            {
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        tcFechas.TabPages.Add(row["fijo1"].ToString().Substring(6, 2)
                            + "/" + row["fijo1"].ToString().Substring(4, 2)
                            + "/" + row["fijo1"].ToString().Substring(0, 4)
                            );
                    }
                }
                else 
                {
                    tcFechas.TabPages.Add(DateTime.Now.ToString("dd/MM/yyyy"));
                }

            }

        }

        private void tcFechas_Selected(object sender, TabControlEventArgs e)
        {

            if (tcFechas.TabPages.Count>0) 
            {
                EtiquetaFecha.Text = tcFechas.TabPages[e.TabPageIndex].Text;
            }

            visualizar2();

        }

        private void btnUbicaciones_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            String msgerr = "";

            Cursor = Cursors.WaitCursor;

            if (MessageBox.Show("¿ Desea actualizar ubicaciones ?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                leerWsdlUbicacion(ref dt, ref msgerr);

                if (dt.Rows.Count > 0)
                {

                    guardaUbicaciones(dt);
                    //consultaUbicaciones();
                    //cargarUbicaciones();

                    MessageBox.Show("Listo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                }
                else
                {
                    MessageBox.Show("No actualizo ninguna ubicacion " + msgerr, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            Cursor = Cursors.Default;

        }

        private void leerWsdlUbicacion(ref DataTable dt, ref String msgerr)
        {

            //Cursor = Cursors.WaitCursor;
            
            ArrayList lista = new ArrayList();

            string seleccion = "ALMACENES";

            Thread t = new Thread(() => { cargarWSDLSel(seleccion, DateTime.Today, equipo, ""); });

            t.Name = seleccion;
            t.IsBackground = true;
            t.Start();

            //while (t.IsAlive)
            //{
            //    Thread.Sleep(50);//50
            //    Application.DoEvents();
            //}

            t.Join();


            lista = connectar.getList();
            String errormsg = connectar.getError();
            String emsg = connectar.getEmsg();

            //if (!errormsg.Equals(""))
            //{
            //    MessageBox.Show(errormsg, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            //}


            try
            {

                DataTable dttmp = new DataTable();
                dttmp.Columns.Add("corral");
                dttmp.Columns.Add("name");
                dttmp.Columns.Add("lat");
                dttmp.Columns.Add("lng");
                dttmp.Columns.Add("lat1");
                dttmp.Columns.Add("lng1");
                dttmp.Columns.Add("lat2");
                dttmp.Columns.Add("lng2");
                dttmp.Columns.Add("lat3");
                dttmp.Columns.Add("lng3");
                dttmp.Columns.Add("lat4");
                dttmp.Columns.Add("lng4");
                dttmp.Columns.Add("type");

                foreach (String listar in lista)
                {

                    string[] lines = listar.Split('|');

                    DataRow newRow = dttmp.NewRow();
                    newRow["corral"] = lines[0].Trim();
                    newRow["name"] = lines[0].Trim();
                    newRow["lat"] = lines[1].Trim();
                    newRow["lng"] = lines[2].Trim();
                    newRow["lat1"] = lines[3].Trim();
                    newRow["lng1"] = lines[4].Trim();
                    newRow["lat2"] = lines[5].Trim();
                    newRow["lng2"] = lines[6].Trim();
                    newRow["lat3"] = lines[7].Trim();
                    newRow["lng3"] = lines[8].Trim();
                    newRow["lat4"] = lines[9].Trim();
                    newRow["lng4"] = lines[10].Trim();
                    newRow["type"] = "";

                    dttmp.Rows.Add(newRow);

                }

                dt = dttmp;

            }
            catch (Exception e)
            {
                //if (!errormsg.Equals(""))
                //{
                //    MessageBox.Show(errormsg, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                //}
            }


        }

        private void guardaUbicaciones(DataTable dtentrada)
        {

            Datos datos = new Datos();
            DataTable dt = new DataTable();

            //this.Cursor = Cursors.WaitCursor;

            datos.p_sql = "DELETE FROM ubicacion";

            if (!datos.consultaSQL(ref dt, true))
            {
                //MessageBox.Show(datos.p_error, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                MessageBox.Show(datos.p_error, "Mensaje");
            }


            List<string> dbOperations = new List<string>();

            foreach (DataRow row in dtentrada.Rows)
            {
                dbOperations.Add("insert into ubicacion (corral,latitud,longitud,latitud1,longitud1,latitud2,longitud2,latitud3,longitud3,latitud4,longitud4) values('" + row["corral"].ToString() + "', " + row["lat"].ToString() + "," + row["lng"].ToString() + "," + row["lat1"].ToString() + "," + row["lng1"].ToString() + "," + row["lat2"].ToString() + "," + row["lng2"].ToString() + "," + row["lat3"].ToString() + "," + row["lng3"].ToString() + "," + row["lat4"].ToString() + "," + row["lng4"].ToString() + ")");
            }


            datos.p_sql_list = dbOperations;

            if (!datos.consultaSQLs(ref dt))
            {
                //MessageBox.Show(datos.p_error, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                MessageBox.Show(datos.p_error, "Mensaje");
            }
            else
            {

            }

            //this.Cursor = Cursors.Default;

        }

        

        private void cargaMapa()
        {


            GMaps.Instance.Mode = AccessMode.CacheOnly;
            gMapControl1.CacheLocation = @"mapa";

            gMapControl1.Position = new PointLatLng(gLatitud, gLongitud);
            //gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.MapProvider = GMapProviders.GoogleChinaSatelliteMap;

            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;

            gMapControl1.MinZoom = 15;//15
            gMapControl1.MaxZoom = 20;//17
            gMapControl1.Zoom = 17;//15;
            gMapControl1.Bearing = -50;
            gMapControl1.AutoScroll = true;


            overlayCeldas = new GMapOverlay("celdas");
            gMapControl1.Overlays.Add(overlayCeldas);

            overlaylabelCeldas = new GMapOverlay("labelceldas");
            gMapControl1.Overlays.Add(overlaylabelCeldas);



            //trackBar1.Value = Convert.ToInt32(gMapControl1.Zoom);


            //corralActividadInicio();

            //corralesActividadNombre();


        }

        
        private void corralActividadInicio()
        {

            Color vcolor = Color.White;

            for (int i = 0; i < overlayCeldas.Polygons.Count; i++)
            {
                overlayCeldas.Polygons.ElementAt(i).Fill = new SolidBrush(vcolor);
                overlayCeldas.Polygons.ElementAt(i).Tag = Color.White.Name;
            }

        }

        private void corralesActividadNombre()
        {

            if (overlayCeldas != null)
            {
                overlaylabelCeldas.Markers.Clear();

                for (int i = 0; i < overlayCeldas.Polygons.Count; i++)
                {
                    //corralActividadNombre(overlayCeldas.Polygons.ElementAt(i).Name, overlayCeldas.Polygons.ElementAt(i).Points, Color.White);

                    //corralActividadNombres(overlayCeldas.Polygons.ElementAt(i), "", Color.White);
                    corralActividadNombres(overlayCeldas.Polygons.ElementAt(i).Name, overlayCeldas.Polygons.ElementAt(i).Points, Color.White);


                }

            }

        }

        private void corralActividadNombres(string nombre, List<PointLatLng> points, Color color)
        {

            int tamano;
            int ancho = 40;
            int alto = 23;

            if (!(gMapControl1.Zoom >= 16 && gMapControl1.Zoom <= 20)) { return; }

            switch (gMapControl1.Zoom)//(Convert.ToInt32(trackBar1.Value))
            {
                case 20:
                    tamano = 10;
                    //    ancho += 32;
                    //    alto += 27;
                    break;
                case 19:
                    tamano = 10;
                //    ancho += 32;
                //    alto += 27;
                    break;
                case 18:
                    tamano = 10;
                //    ancho += 12;
                //    alto += 11;
                    break;
                case 17:
                    tamano = 10;
                    //ancho = 40;
                    //alto = 23;
                    break;
                case 16:
                    tamano = 10;
                    //ancho = 27;
                    //alto = 15;
                    break;
                //case 15:
                //    tamano = 1;
                //    ancho = 40;
                //    alto = 23;
                //    break;
                default:
                    tamano = 10;
                    //ancho = 40;
                    //alto = 23;
                    break;
            }

            Bitmap bmpmarker = new Bitmap(ancho, alto);
            Graphics graphicImage = Graphics.FromImage(bmpmarker);
            graphicImage.SmoothingMode = SmoothingMode.AntiAlias;
            graphicImage.DrawString(nombre, new Font("Cambria", tamano, FontStyle.Bold), SystemBrushes.WindowText, new Point(3, 10));
            graphicImage.Dispose();

            PointLatLng centerPoint = GetZoneCenter(points);

            centerPoint.Lat -= 0.000000;
            centerPoint.Lng += 0.000000;

            markerlabelCelda = new GMarkerGoogle(centerPoint, bmpmarker);
            overlaylabelCeldas.Markers.Add(markerlabelCelda);

        }

        /*
        private void corralActividadNombres(GMapPolygon polygon, string valor, Color color)
        {

            int tamano = 8;
            int ancho = 40;
            int alto = 22; //11;

            int tmin = trackBar1.Minimum;
            int ttam = trackBar1.Value - tmin;

            if (ttam >= 0 && ttam <= 1) { return; }

            //tamano = Convert.ToInt32(Math.Pow(2,ttam+1));
            //lblErrores.Text = "escala"+ttam.ToString()+",letra:"+tamano.ToString() + ",a" + ancho.ToString() + ",h" + alto.ToString();


            //valor = "";

            Bitmap bmpmarker = new Bitmap(ancho, alto);
            Graphics graphicImage = Graphics.FromImage(bmpmarker);
            graphicImage.SmoothingMode = SmoothingMode.AntiAlias;
            graphicImage.DrawString(valor, new Font("Tamoha", tamano, FontStyle.Bold), SystemBrushes.WindowText, new Point(3, 0));
            graphicImage.DrawString(polygon.Name, new Font("Tamoha", tamano, FontStyle.Bold), SystemBrushes.WindowText, new Point(0, 10));
            graphicImage.Dispose();


            PointLatLng centerPoint = GetZoneCenter(polygon.Points);
            //double dist = getDistancia(polygon.Points.ElementAt(0).Lat, polygon.Points.ElementAt(0).Lng, centerPoint.Lat, centerPoint.Lng);
            //lblErrores.Text = dist.ToString();

            PointLatLng ladoPoint = new PointLatLng();

            int p1 = 0, p2 = 0;

            switch (gorientacion)
            {
                case 0:
                    p1 = 2;
                    p2 = 3;
                    break;
                case 1:
                    p1 = 3;
                    p2 = 0;
                    break;
                case 2:
                    p1 = 0;
                    p2 = 1;
                    break;
                case 3:
                    p1 = 1;
                    p2 = 2;
                    break;
            }

            ladoPoint.Lat = (polygon.Points.ElementAt(p1).Lat + polygon.Points.ElementAt(p2).Lat) / 2;
            ladoPoint.Lng = (polygon.Points.ElementAt(p1).Lng + polygon.Points.ElementAt(p2).Lng) / 2;

            if (ttam == 2 && valor.Length > 0)
            {
                markerlabelCelda = new GMarkerGoogle(ladoPoint, bmpmarker);
            }
            else
            {
                markerlabelCelda = new GMarkerGoogle(centerPoint, bmpmarker);
            }

            overlaylabelCeldas.Markers.Add(markerlabelCelda);



        }
        */

        private PointLatLng GetZoneCenter(List<PointLatLng> vertexes)
        {

            PointLatLng centerPoint = new PointLatLng();
            int sum = 0;
            double lat = 0;
            double lng = 0;

            foreach (var point in vertexes)
            {
                sum += 1;
                lat += point.Lat;
                lng += point.Lng;
            }

            lat = lat / sum;
            lng = lng / sum;

            centerPoint.Lat = lat;
            centerPoint.Lng = lng;

            return centerPoint;

        }
        

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            if (gMapControl1.Zoom <= 19)
            {
                gMapControl1.Zoom += 1;
            }
        }

        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {
            if (gMapControl1.Zoom >= 15)
            {
                gMapControl1.Zoom -= 1;
            }
        }

        private void toolStripButton4_Click_1(object sender, EventArgs e)
        {
            gMapControl1.Bearing += 90;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackMover();
        }

        private void trackMover()
        {
            gMapControl1.Zoom = trackBar1.Value;
            //lblZoom.Text = valorPorcZoom() + "%";
        }

        private string valorPorcZoom()
        {

            string valor;

            switch (Convert.ToInt32(trackBar1.Value))
            {
                case 20:
                    valor = "175";
                    break;
                case 19:
                    valor = "150";
                    break;
                case 18:
                    valor = "125";
                    break;
                case 17:
                    valor = "100";
                    break;
                case 16:
                    valor = "75";
                    break;
                case 15:
                    valor = "50";
                    break;

                default:
                    valor = "0";
                    break;
            }

            return valor;

        }
        
        private void botonCeldas()
        {

            this.Cursor = Cursors.WaitCursor;

            //if (!celdaActivo)
            //{
                DataTable dt = new DataTable();


                consultaUbicaciones(ref dt);
                //leerWsdlUbicacion(ref dt);

                //leerWsUbicacion(ref dt);

                quitarMarcadorCeldas();

                dtUbictmp.Clear();


                foreach (DataRow row in dt.Rows)
                {
                    agregaractualizarMarcadorCelda(
                        row["corral"].ToString(),
                        row["name"].ToString(),
                        Convert.ToDouble(row["lat"]),
                        Convert.ToDouble(row["lng"]),
                        Convert.ToDouble(row["lat1"]),
                        Convert.ToDouble(row["lng1"]),
                        Convert.ToDouble(row["lat2"]),
                        Convert.ToDouble(row["lng2"]),
                        Convert.ToDouble(row["lat3"]),
                        Convert.ToDouble(row["lng3"]),
                        Convert.ToDouble(row["lat4"]),
                        Convert.ToDouble(row["lng4"]));



                    DataRow newRow = dtUbictmp.NewRow();

                    newRow["corral"] = row["corral"];
                    newRow["lat"] = row["lat"];
                    newRow["lng"] = row["lng"];
                    newRow["lat1"] = row["lat1"];
                    newRow["lng1"] = row["lng1"];
                    newRow["lat2"] = row["lat2"];
                    newRow["lng2"] = row["lng2"];
                    newRow["lat3"] = row["lat3"];
                    newRow["lng3"] = row["lng3"];
                    newRow["lat4"] = row["lat4"];
                    newRow["lng4"] = row["lng4"];

                    newRow["lat1m"] = (Convert.ToDouble(row["lat1"]) + Convert.ToDouble(row["lat2"])) / 2;
                    newRow["lng1m"] = (Convert.ToDouble(row["lng1"]) + Convert.ToDouble(row["lng2"])) / 2;
                    newRow["lat2m"] = (Convert.ToDouble(row["lat2"]) + Convert.ToDouble(row["lat3"])) / 2;
                    newRow["lng2m"] = (Convert.ToDouble(row["lng2"]) + Convert.ToDouble(row["lng3"])) / 2;
                    newRow["lat3m"] = (Convert.ToDouble(row["lat3"]) + Convert.ToDouble(row["lat4"])) / 2;
                    newRow["lng3m"] = (Convert.ToDouble(row["lng3"]) + Convert.ToDouble(row["lng4"])) / 2;
                    newRow["lat4m"] = (Convert.ToDouble(row["lat4"]) + Convert.ToDouble(row["lat1"])) / 2;
                    newRow["lng4m"] = (Convert.ToDouble(row["lng4"]) + Convert.ToDouble(row["lng1"])) / 2;

                    newRow["lat1a"] = (Convert.ToDouble(row["lat1"]) + Convert.ToDouble(newRow["lat1m"])) / 2;
                    newRow["lng1a"] = (Convert.ToDouble(row["lng1"]) + Convert.ToDouble(newRow["lng1m"])) / 2;
                    newRow["lat1b"] = (Convert.ToDouble(newRow["lat1m"]) + Convert.ToDouble(row["lat2"])) / 2;
                    newRow["lng1b"] = (Convert.ToDouble(newRow["lng1m"]) + Convert.ToDouble(row["lng2"])) / 2;
                    newRow["lat2a"] = (Convert.ToDouble(row["lat2"]) + Convert.ToDouble(newRow["lat2m"])) / 2;
                    newRow["lng2a"] = (Convert.ToDouble(row["lng2"]) + Convert.ToDouble(newRow["lng2m"])) / 2;
                    newRow["lat2b"] = (Convert.ToDouble(newRow["lat2m"]) + Convert.ToDouble(row["lat3"])) / 2;
                    newRow["lng2b"] = (Convert.ToDouble(newRow["lng2m"]) + Convert.ToDouble(row["lng3"])) / 2;
                    newRow["lat3a"] = (Convert.ToDouble(row["lat3"]) + Convert.ToDouble(newRow["lat3m"])) / 2;
                    newRow["lng3a"] = (Convert.ToDouble(row["lng3"]) + Convert.ToDouble(newRow["lng3m"])) / 2;
                    newRow["lat3b"] = (Convert.ToDouble(newRow["lat3m"]) + Convert.ToDouble(row["lat4"])) / 2;
                    newRow["lng3b"] = (Convert.ToDouble(newRow["lng3m"]) + Convert.ToDouble(row["lng4"])) / 2;
                    newRow["lat4a"] = (Convert.ToDouble(row["lat4"]) + Convert.ToDouble(newRow["lat4m"])) / 2;
                    newRow["lng4a"] = (Convert.ToDouble(row["lng4"]) + Convert.ToDouble(newRow["lng4m"])) / 2;
                    newRow["lat4b"] = (Convert.ToDouble(newRow["lat4m"]) + Convert.ToDouble(row["lat1"])) / 2;
                    newRow["lng4b"] = (Convert.ToDouble(newRow["lng4m"]) + Convert.ToDouble(row["lng1"])) / 2;





                    dtUbictmp.Rows.Add(newRow);

                }

                corralesActividadNombre();

            

            this.Cursor = Cursors.Default;

        }

        private void tablaUbicTemp()
        {

            dtUbictmp = new DataTable();

            dtUbictmp.Columns.Add("corral");
            dtUbictmp.Columns.Add("lat");
            dtUbictmp.Columns.Add("lng");
            dtUbictmp.Columns.Add("lat1");
            dtUbictmp.Columns.Add("lng1");
            dtUbictmp.Columns.Add("lat2");
            dtUbictmp.Columns.Add("lng2");
            dtUbictmp.Columns.Add("lat3");
            dtUbictmp.Columns.Add("lng3");
            dtUbictmp.Columns.Add("lat4");
            dtUbictmp.Columns.Add("lng4");

            dtUbictmp.Columns.Add("lat1m");
            dtUbictmp.Columns.Add("lng1m");
            dtUbictmp.Columns.Add("lat2m");
            dtUbictmp.Columns.Add("lng2m");
            dtUbictmp.Columns.Add("lat3m");
            dtUbictmp.Columns.Add("lng3m");
            dtUbictmp.Columns.Add("lat4m");
            dtUbictmp.Columns.Add("lng4m");

            dtUbictmp.Columns.Add("lat1a");
            dtUbictmp.Columns.Add("lng1a");
            dtUbictmp.Columns.Add("lat1b");
            dtUbictmp.Columns.Add("lng1b");
            dtUbictmp.Columns.Add("lat2a");
            dtUbictmp.Columns.Add("lng2a");
            dtUbictmp.Columns.Add("lat2b");
            dtUbictmp.Columns.Add("lng2b");
            dtUbictmp.Columns.Add("lat3a");
            dtUbictmp.Columns.Add("lng3a");
            dtUbictmp.Columns.Add("lat3b");
            dtUbictmp.Columns.Add("lng3b");
            dtUbictmp.Columns.Add("lat4a");
            dtUbictmp.Columns.Add("lng4a");
            dtUbictmp.Columns.Add("lat4b");
            dtUbictmp.Columns.Add("lng4b");

            dtUbictmp.Columns.Add("distancia");


        }

        private void quitarMarcadorCeldas()
        {
            overlayCeldas.Polygons.Clear();
            overlaylabelCeldas.Markers.Clear();
        }

        private void agregaractualizarMarcadorCelda(string id, string name, double lat, double lng, double lat1, double lng1, double lat2, double lng2, double lat3, double lng3, double lat4, double lng4)
        {

            _points.Clear();
            _points.Add(new PointLatLng(lat1, lng1));
            _points.Add(new PointLatLng(lat2, lng2));
            _points.Add(new PointLatLng(lat3, lng3));
            _points.Add(new PointLatLng(lat4, lng4));

            corralActividad(id, _points, Color.White);
            //corralActividadNombre(id, _points, Color.White);

        }


        private void corralActividad(string nombre, List<PointLatLng> points, Color color)
        {

            polygonCelda = new GMapPolygon(points, nombre)
            {
                Stroke = new Pen(Color.Black, 2),
                Fill = new SolidBrush(color), //Brushes.Transparent,
                //Fill = new SolidBrush(Color.FromArgb(50, Color.Red)), //Brushes.Transparent,
                Tag = nombre,
            };

            overlayCeldas.Polygons.Add(polygonCelda);

            //Bitmap bmpmarker = new Bitmap(40, 23);
            //Graphics graphicImage = Graphics.FromImage(bmpmarker);
            //graphicImage.SmoothingMode = SmoothingMode.AntiAlias;
            //graphicImage.DrawString(nombre, new Font("Arial", 10, FontStyle.Regular), SystemBrushes.WindowText, new Point(5, 10));
            //graphicImage.Dispose();

            //PointLatLng centerPoint = GetZoneCenter(points);
            //markerlabelCelda = new GMarkerGoogle(centerPoint, bmpmarker);
            //overlaylabelCeldas.Markers.Add(markerlabelCelda);

        }

        private void consultaUbicaciones(ref DataTable dt)
        {

            Datos datos = new Datos();
            DataTable dt2 = new DataTable();

            this.Cursor = Cursors.WaitCursor;

            datos.p_sql = "SELECT * FROM ubicacion WHERE corral in (SELECT DISTINCT fijo2 FROM historial)";

            if (!datos.consultaSQL(ref dt2, true))
            {
                MessageBox.Show(datos.p_error, "Mensaje");
            }
            else
            {

                DataTable dttmp = new DataTable();
                dttmp.Columns.Add("corral");
                dttmp.Columns.Add("name");
                dttmp.Columns.Add("lat");
                dttmp.Columns.Add("lng");
                dttmp.Columns.Add("lat1");
                dttmp.Columns.Add("lng1");
                dttmp.Columns.Add("lat2");
                dttmp.Columns.Add("lng2");
                dttmp.Columns.Add("lat3");
                dttmp.Columns.Add("lng3");
                dttmp.Columns.Add("lat4");
                dttmp.Columns.Add("lng4");

                foreach (DataRow row in dt2.Rows)
                {

                    DataRow newRow = dttmp.NewRow();

                    newRow["corral"] = row["corral"];
                    newRow["name"] = row["corral"];
                    newRow["lat"] = row["latitud"];
                    newRow["lng"] = row["longitud"];
                    newRow["lat1"] = row["latitud1"];
                    newRow["lng1"] = row["longitud1"];
                    newRow["lat2"] = row["latitud2"];
                    newRow["lng2"] = row["longitud2"];
                    newRow["lat3"] = row["latitud3"];
                    newRow["lng3"] = row["longitud3"];
                    newRow["lat4"] = row["latitud4"];
                    newRow["lng4"] = row["longitud4"];

                    dttmp.Rows.Add(newRow);

                }

                dt = dttmp;

            }

            this.Cursor = Cursors.Default;

        }


        private void cambioZoomMapa()
        {

            trackBar1.Value = Convert.ToInt32(gMapControl1.Zoom);
            lblZoom.Text = valorPorcZoom() + "%";
            corralesActividadNombre();

            //nombresCorral();

            //lblZomm.Text = valorPorcZomm() + "%";

        }

        private void ubicaCorralMapa()
        {

            //if (lblLatitud.Text.Equals("0"))
            //{

                DataRow row = consultaUbicacion(_TextoAlmacen.Text);

                if (row != null)
                {
                    gMapControl1.Position = new PointLatLng(double.Parse(row["lat1"].ToString()), double.Parse(row["lng1"].ToString()));
                }
            //}

        }

        private DataRow consultaUbicacion(String corral)
        {

            Datos datos = new Datos();
            DataTable dt = new DataTable();

            //this.Cursor = Cursors.WaitCursor;

            datos.p_sql = "SELECT TOP 1 * FROM ubicacion WHERE corral ='" + corral + "'";

            if (!datos.consultaSQL(ref dt, true))
            {
                //MessageBox.Show(datos.p_error, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //msgErrores(datos.p_error, Constants.MSG_ERROR);
            }
            else
            {

                //dtUbictmp.Clear();

                foreach (DataRow row in dt.Rows)
                {

                    DataRow newRow = dtUbictmp.NewRow();

                    newRow["corral"] = row["corral"];
                    newRow["lat"] = row["latitud"];
                    newRow["lng"] = row["longitud"];
                    newRow["lat1"] = row["latitud1"];
                    newRow["lng1"] = row["longitud1"];
                    newRow["lat2"] = row["latitud2"];
                    newRow["lng2"] = row["longitud2"];
                    newRow["lat3"] = row["latitud3"];
                    newRow["lng3"] = row["longitud3"];
                    newRow["lat4"] = row["latitud4"];
                    newRow["lng4"] = row["longitud4"];


                    newRow["lat1m"] = (Convert.ToDouble(row["latitud1"]) + Convert.ToDouble(row["latitud2"])) / 2;
                    newRow["lng1m"] = (Convert.ToDouble(row["longitud1"]) + Convert.ToDouble(row["longitud2"])) / 2;
                    newRow["lat2m"] = (Convert.ToDouble(row["latitud2"]) + Convert.ToDouble(row["latitud3"])) / 2;
                    newRow["lng2m"] = (Convert.ToDouble(row["longitud2"]) + Convert.ToDouble(row["longitud3"])) / 2;
                    newRow["lat3m"] = (Convert.ToDouble(row["latitud3"]) + Convert.ToDouble(row["latitud4"])) / 2;
                    newRow["lng3m"] = (Convert.ToDouble(row["longitud3"]) + Convert.ToDouble(row["longitud4"])) / 2;
                    newRow["lat4m"] = (Convert.ToDouble(row["latitud4"]) + Convert.ToDouble(row["latitud1"])) / 2;
                    newRow["lng4m"] = (Convert.ToDouble(row["longitud4"]) + Convert.ToDouble(row["longitud1"])) / 2;

                    newRow["lat1a"] = (Convert.ToDouble(row["latitud1"]) + Convert.ToDouble(newRow["lat1m"])) / 2;
                    newRow["lng1a"] = (Convert.ToDouble(row["longitud1"]) + Convert.ToDouble(newRow["lng1m"])) / 2;
                    newRow["lat1b"] = (Convert.ToDouble(newRow["lat1m"]) + Convert.ToDouble(row["latitud2"])) / 2;
                    newRow["lng1b"] = (Convert.ToDouble(newRow["lng1m"]) + Convert.ToDouble(row["longitud2"])) / 2;
                    newRow["lat2a"] = (Convert.ToDouble(row["latitud2"]) + Convert.ToDouble(newRow["lat2m"])) / 2;
                    newRow["lng2a"] = (Convert.ToDouble(row["longitud2"]) + Convert.ToDouble(newRow["lng2m"])) / 2;
                    newRow["lat2b"] = (Convert.ToDouble(newRow["lat2m"]) + Convert.ToDouble(row["latitud3"])) / 2;
                    newRow["lng2b"] = (Convert.ToDouble(newRow["lng2m"]) + Convert.ToDouble(row["longitud3"])) / 2;
                    newRow["lat3a"] = (Convert.ToDouble(row["latitud3"]) + Convert.ToDouble(newRow["lat3m"])) / 2;
                    newRow["lng3a"] = (Convert.ToDouble(row["longitud3"]) + Convert.ToDouble(newRow["lng3m"])) / 2;
                    newRow["lat3b"] = (Convert.ToDouble(newRow["lat3m"]) + Convert.ToDouble(row["latitud4"])) / 2;
                    newRow["lng3b"] = (Convert.ToDouble(newRow["lng3m"]) + Convert.ToDouble(row["longitud4"])) / 2;
                    newRow["lat4a"] = (Convert.ToDouble(row["latitud4"]) + Convert.ToDouble(newRow["lat4m"])) / 2;
                    newRow["lng4a"] = (Convert.ToDouble(row["longitud4"]) + Convert.ToDouble(newRow["lng4m"])) / 2;
                    newRow["lat4b"] = (Convert.ToDouble(newRow["lat4m"]) + Convert.ToDouble(row["latitud1"])) / 2;
                    newRow["lng4b"] = (Convert.ToDouble(newRow["lng4m"]) + Convert.ToDouble(row["longitud1"])) / 2;



                    //dtUbictmp.Rows.Add(newRow);
                    return newRow;

                }

                //dataGridUbicaciones.DataSource = dtUbictmp;
                //formatoubicacionesGrid();
                //lblCantidad.Text = dataGridUbicaciones.RowCount.ToString();

            }

            //this.Cursor = Cursors.Default;

            return null;

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            ruta2();
            busca();
        }
    }
}