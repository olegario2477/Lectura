using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;
using System.Xml;
using System.Xml.Serialization;
using System.Net;
using System.IO;
using System.Windows.Forms;
using System.Web.Services.Protocols;
using Lectura.getSAPData;

namespace Lectura
{
    class ConnectWs
    {

        private String operacion;
        private String catalogo;
        private ArrayList lectura = new ArrayList();
        private String usuario;
        private String contrasena;
        private String fecha;
        private String equipo;
        private String parametros;
        private ArrayList mList = new ArrayList();
        private String errormsg;
        private String emsg;
        private String url;

        String SEPARATOR = ",";



        public ConnectWs(String operacion, String catalogo, String usuario, String contrasena, String fecha, String equipo, String parametros)
        {
            this.operacion = operacion;
            this.catalogo = catalogo;
            this.usuario = usuario;
            this.contrasena = contrasena;
            this.fecha = fecha;
            this.equipo = equipo;
            this.parametros = parametros;
        }

        public ConnectWs(String operacion, ArrayList lectura, String usuario, String contrasena, String equipo, String parametros)
        {
            this.operacion = operacion;
            this.lectura = lectura;
            this.usuario = usuario;
            this.contrasena = contrasena;
            this.equipo = equipo;
            this.parametros = parametros;
        }

        public void connect()
        {

            NetworkCredential cred = new NetworkCredential();
            
            zwsdl_lec zwsdl = new zwsdl_lec();

            url = zwsdl.Url;

            ZWsLectura ZWs_Input = new ZWsLectura();
            ZWsLecturaResponse ZWs_Response = new ZWsLecturaResponse();
            
            cred.UserName = usuario;
            cred.Password = contrasena;
            zwsdl.PreAuthenticate = true;
            zwsdl.Credentials = cred;

            zwsdl.Timeout = 10 * 1000;

            ZstLineasLec[] lineasI = { };
            ZstLineasLec[] lineasE = { };

            errormsg = "";
            emsg = "";

            switch (operacion) {
                case Constants.OPERACION_CATALOGO:

                    ZWs_Input.ICatalogo = catalogo;
                    ZWs_Input.IEquipo = equipo;                     
                    ZWs_Input.IFecha = fecha; //"2020-07-22";
                    ZWs_Input.IOperacion = operacion;
                    ZWs_Input.IParametros = parametros;
                    ZWs_Input.ITabla = lineasI;


                    try
                    {

                        ZWs_Response = zwsdl.ZWsLectura(ZWs_Input);
                        lineasE = ZWs_Response.ETabla;
                        
                        mList = obtenerLista(lineasE);
                        emsg = ZWs_Response.EMsg;
      
                    }
                    catch (SoapHeaderException)
                    {
                        errormsg = "soap fault in the header e.g. auth failed";
                    }
                    catch (SoapException ex)
                    {
                        errormsg = ex.Message;
                    }
                    catch (WebException)
                    {
                        errormsg = "e.g. internet esta caido";
                    }
                    catch (Exception ex2)
                    {
                        errormsg = ex2.Message;
                    }

                    break;

                case Constants.OPERACION_TRANSFERIR:

                    ZWs_Input.ICatalogo = "_";
                    ZWs_Input.IEquipo = equipo;
                    ZWs_Input.IFecha = "0000-00-00"; //"2020-07-22";
                    ZWs_Input.IOperacion = operacion;
                    ZWs_Input.IParametros = "_";
                    ZWs_Input.ITabla = tableData(lectura);

                    try
                    {

                        ZWs_Response = zwsdl.ZWsLectura(ZWs_Input);
                        //lineasE = ZWsMedicamentos_Response.ETabla;

                        //mList = obtenerLista(lineasE);
                        emsg = ZWs_Response.EMsg;

                    }
                    catch (SoapHeaderException)
                    {
                        errormsg = "soap fault in the header e.g. auth failed";
                    }
                    catch (SoapException ex)
                    {
                        errormsg = ex.Message;
                    }
                    catch (WebException)
                    {
                        errormsg = "e.g. internet esta caido";
                    }
                    catch (Exception ex2)
                    {
                        errormsg = ex2.Message;
                    }

                    break;

            }


        }        

        private ArrayList obtenerLista(ZstLineasLec[] lineasE)
        {

            ArrayList lista = new ArrayList();
            
            foreach (ZstLineasLec linease in lineasE)
            {
                lista.Add(linease.Linea);
            }
            
            return lista;

        }

        public ZstLineasLec[] tableData(ArrayList lectura)
        {

            ZstLineasLec[] lineasI2 = new ZstLineasLec[lectura.Count];
           
            int index = 0;


            foreach (String cadena in lectura)
            {       


                string[] valor = cadena.Split('|');

                ZstLineasLec lineasI3 = new ZstLineasLec();
                lineasI3.Linea = cadena;
                lineasI3.Linea2 = "";
                lineasI3.Col01 = "";
                lineasI3.Col02 = "";// "1";
                lineasI3.Col03 = valor[0].ToString(); //DateTime.Now.ToString("dd/mm/yyyy");
                lineasI3.Col04 = valor[1].ToString(); // DateTime.Now.ToString("HH:mm");
                lineasI3.Col05 = valor[2].ToString();
                lineasI3.Col06 = valor[3].ToString();
                lineasI3.Col07 = valor[4].ToString();
                lineasI3.Col08 = valor[5].ToString();
                lineasI3.Col09 = valor[6].ToString();
                lineasI3.Col10 = valor[7].ToString();

                lineasI3.Col11 = valor[8].ToString();
                lineasI3.Col12 = valor[9].ToString();
                lineasI3.Col13 = valor[10].ToString();
                //lineasI3.Col14 = "";
                //lineasI3.Col15 = "";
                //lineasI3.Col16 = "";
                //lineasI3.Col17 = "";
                //lineasI3.Col18 = "";
                //lineasI3.Col19 = "";
                //lineasI3.Col20 = "";

                //lineasI3.Col21 = "";
                //lineasI3.Col22 = "";
                //lineasI3.Col23 = "";
                //lineasI3.Col24 = "";
                //lineasI3.Col25 = "";
                //lineasI3.Col26 = "";
                //lineasI3.Col27 = "";
                //lineasI3.Col28 = "";
                //lineasI3.Col29 = "";
                //lineasI3.Col30 = "";

                //lineasI3.Col31 = "";
                //lineasI3.Col32 = "";
                //lineasI3.Col33 = "";
                //lineasI3.Col34 = "";
                //lineasI3.Col35 = "";
                //lineasI3.Col36 = "";
                //lineasI3.Col37 = "";
                //lineasI3.Col38 = "";
                //lineasI3.Col39 = "";
                //lineasI3.Col40 = "";

                lineasI2[index] = lineasI3;
                index++;
            }
                        


            return lineasI2;

        }

        public ArrayList getList() { return mList; }
        public String getError() { return errormsg; }
        public String getEmsg() { return emsg; }
        public String getUrl() { return url; }

    }

}

    
