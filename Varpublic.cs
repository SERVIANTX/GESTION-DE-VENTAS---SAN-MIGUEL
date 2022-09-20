using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_de_gestion_de_ventas
{
    class Varpublic
    {
        public static SqlConnection cadconex = new SqlConnection("Server=(local);database=Gestion_VentaBD; Integrated Security = true");


    }
}
