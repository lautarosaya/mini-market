using Minimarket.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimarket.Negocio
{
    public class N_Categorias
    {
        public static DataTable GetDatosCategorias(string cText)
        {
            D_Categorias Datos = new D_Categorias();
            return Datos.Listado_ca(cText);
        }        
    }   
}
