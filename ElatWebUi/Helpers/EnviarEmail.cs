using ElatWebUi.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;

namespace ElatWebUi.Helpers
{
    public class EnviarEmail
    {

        public EnviarEmail()
        {

        }

        public string EnviarComentarios(Contacto contacto)
        {
            try
            {
                string url = "http://dinamitec.net/EnviaEmailElat.php";
                using (WebClient client = new WebClient())
                {
                    client.Headers.Add("User-Agent: Other");
                    NameValueCollection reqparam = new NameValueCollection();
                    reqparam.Add("emailpara", "escueladetiterestlaxcala@hotmail.com"); //Cambiar por la de la escuela "escueladetiterestlaxcala@hotmail.com"
                    reqparam.Add("asunto", "Contacto titereselat.com");
                    //Creando el cuerpo del correo
                    reqparam.Add("mensaje", "<p><b>Nombre:</b> "+ contacto.Nombre +"</p>" +
                        "<p><b>Lugar de procedencia:</b> " + contacto.Procedencia + "</p>" +
                        "<p><b>Correo electrónico:</b> "+contacto.Email+"</p>" +
                        "<p><b>Perfil:</b> "+contacto.Perfil+"</p>" +
                        "<p><b>Mensaje:</b><br> "+contacto.Mensaje+"</p>" +
                        "<p>Correo enviado desde <a href=\"http://www.titereselat.com/Contacto\">http://www.titereselat.com/Contacto</a></p>");

                    byte[] responsebytes = client.UploadValues(url,"POST" ,reqparam);
                    string responsebody = Encoding.UTF8.GetString(responsebytes);
                }
                return "Comentarios enviados correctamente";
            }
            catch
            {
                return "Ocurrio un problema al enviar tu solicitud";
            }
        }
    }
}