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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:44326/api/Transaccion";
        
            TransaccionRequest oTransaccion = new TransaccionRequest();
            oTransaccion.IdTarjetaOrigen = txt_IdTarjetaOrigen.Text;
            oTransaccion.IdTarjetaDestino = txt_IdTarjetaOrigen.Text;
            oTransaccion.ccv = txt_cvv.Text;
            oTransaccion.TipoTransaccion = txt_TipoTransaccion.Text;
            oTransaccion.Motivo = txt_Motivo.Text;
            oTransaccion.Monto = txt_Monto.Text;
            oTransaccion.Fecha = txt_Fecha.Text;
            string resultado=Send<TransaccionRequest>(url, oTransaccion, "POST");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
