using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Minimarket.Datos
{
    public class Conexion
    {
        //DESKTOP-A2D95M4\SQLEXPRESS

        private string baseDatos;
        private string servidor;
        private string usuario;
        private string password;
        private bool seguridad;
        private static Conexion conexion = null;

        private Conexion()
        {
            this.baseDatos = "BD_MINIMARKET";
            this.servidor = "DESKTOP-A2D95M4\\SQLEXPRESS";
            this.usuario = "sa";
            this.password = "123456";
            this.seguridad = true;
        }
    }
}
