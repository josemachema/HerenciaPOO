using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.PolimorfismoInterface
{
    internal class NotificacionWhatsAPP:iNotificacion
    {
        public void Enviar(string Mensaje)
        {
            MessageBox.Show("Mensaje Enviado por WA:" + Mensaje);
        }
    }
}
