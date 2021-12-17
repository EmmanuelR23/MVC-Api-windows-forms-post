using PersonaForm.Models.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace PersonaForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_Enviar_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:44326/api/Transporte";

            TransporteRequest oTransporte = new TransporteRequest();
            oTransporte.producto = txt_producto.Text;
            oTransporte.cantidad = int.Parse(txt_cantidad.Text);
            oTransporte.nombreCliente = txt_nombreCliente.Text;
            oTransporte.Fecha = DateTime.Parse(txt_Fecha.Text);
            oTransporte.teléfono = int.Parse(txt_teléfono.Text); ;
            oTransporte.dirección= txt_dirección.Text;
            string resultado = Send<TransporteRequest>(url, oTransporte, "POST");

        }
        public string Send<T>(string url, T objectRequest, string method = "POST")
        {
            string result = "";
            try
            {
                JavaScriptSerializer js = new JavaScriptSerializer();

                //serializamos el objeto
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(objectRequest);

                //peticion
                WebRequest request = WebRequest.Create(url);

                //headers
                request.Method = method;
                request.PreAuthenticate = true;
                request.ContentType = "application/json;charset=utf-8'";
                request.Timeout = 10000; //esto es opcional

                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamWriter.Write(json);
                    streamWriter.Flush();
                }
                var httpResponse = (HttpWebResponse)request.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                result = e.Message;

            }
            return result;
        }
    }
}
