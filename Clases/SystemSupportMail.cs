using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_de_gestion_de_ventas
{
    class SystemSupportMail : MasterMailServer
    {
        public SystemSupportMail()
        {
            senderMail = "soporteSystemSanMiguel@gmail.com";
            password = "admin9494";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;

            initializeSmtpClient();
        }
    }
}
