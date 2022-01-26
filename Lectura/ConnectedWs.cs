using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Lectura
{
    class ConnectedWs
    {

        private String operacion;
        private String catalogo;
        private ArrayList lectura = new ArrayList();
        private String equipo;
        private String usuario;
        private String contrasena;
        private String fecha;
        private String parametros;
        private ArrayList mList = new ArrayList();
        private String errormsg;
        private String emsg;
        private String url;

        ConnectWs connectar;

        String SEPARATOR = ",";


        public ConnectedWs(String operacion, String catalogo, String usuario, String contrasena, String fecha, String equipo, String parametros)
        {
            this.operacion = operacion;
            this.catalogo = catalogo;
            this.usuario = usuario;
            this.contrasena = contrasena;
            this.fecha = fecha;
            this.equipo = equipo;
            this.parametros = parametros;
        }

        public ConnectedWs(String operacion, ArrayList lectura, String usuario, String contrasena, String equipo, String parametros)
        {
            this.operacion = operacion;
            this.lectura = lectura;
            this.usuario = usuario;
            this.contrasena = contrasena;
            this.equipo = equipo;
            this.parametros = parametros;
        }

        public void setDataWs()
        {

            connectar = new ConnectWs(operacion, lectura, usuario, contrasena, equipo, parametros);
            connectar.connect();

            errormsg = connectar.getError();
            emsg = connectar.getEmsg();
            url = connectar.getUrl();
            //mList = connectar.getList();

        }

        public void getDataWs()
        {
            connectar = new ConnectWs(operacion, catalogo, usuario, contrasena, fecha, equipo, parametros);
            connectar.connect();

            errormsg = connectar.getError();
            emsg = connectar.getEmsg();
            url = connectar.getUrl();
            mList = connectar.getList();

        }

        public ArrayList getList() { return mList; }
        public String getError() { return errormsg; }
        public String getEmsg() { return emsg; }
        public String getUrl() { return url; }

    }


}
