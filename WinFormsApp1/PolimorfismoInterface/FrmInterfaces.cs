using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.PolimorfismoInterface
{
    public partial class FrmInterfaces : Form
    {
        public FrmInterfaces()
        {
            InitializeComponent();
        }

        private void FrmInterfaces_Load(object sender, EventArgs e)
        {
            List<iNotificacion> iNotificacions = new List<iNotificacion>
            {
                new NotificacionSms(),
                new NotificacionWhatsAPP()
            };
            foreach (var item in iNotificacions)
            {
                item.Enviar("Hola, te mando este mensaje");
            }
        }
    }
}
