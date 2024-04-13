using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioInterfaz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------DESAFIO DE INTERFAZ----------------------------\n");
            NotificacionEmail correoNotificacion = new NotificacionEmail("Marvingudiellopez@gmail.com");
            NotificacionWhatsap whatsappNotificacion = new NotificacionWhatsap("+502 65874241");
            NotificacionTelefono mensajeNotificacion = new NotificacionTelefono("+502 65874241");

            correoNotificacion.Notificacion();
            whatsappNotificacion.Notificacion();
            mensajeNotificacion.Notificacion();
            Console.Read();
        }
    }
    public interface INotificable
    {
        void Notificacion();
    }

    public class NotificacionEmail : INotificable
    {
        private string correoElectronico;

        public NotificacionEmail(string direccionCorreo)
        {
            this.correoElectronico = direccionCorreo;
        }

        public void Notificacion()
        {
            Console.WriteLine("Notificacion por correo electronico: {0}",correoElectronico);
        }
    }

    public class NotificacionWhatsap : INotificable
    {
        private string numeroTelefono;

        public NotificacionWhatsap(string numeroTelefono)
        {
            this.numeroTelefono = numeroTelefono;
        }

        public void Notificacion()
        {
            Console.WriteLine("Notificacion por Whatsapp: {0}",numeroTelefono);
        }
    }

    public class NotificacionTelefono : INotificable
    {
        private string numeroTelefono;

        public NotificacionTelefono(string numeroTelefono)
        {
            this.numeroTelefono = numeroTelefono;
        }

        public void Notificacion()
        {
            Console.WriteLine("Notificacion por Mensaje: {0}",numeroTelefono);
        }
    }
}





