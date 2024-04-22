using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
namespace E_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await ObtenerDatos();
        }
        private async void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private async Task ObtenerDatos()
        {
            try
            {
                using (HttpClient cliente = new HttpClient())
                {
                    HttpResponseMessage respuesta = await cliente.GetAsync("http://localhost/multimedial/INF-E-4-2PHP/index.php");

                    if (respuesta.IsSuccessStatusCode)
                    {
                        string contenido = await respuesta.Content.ReadAsStringAsync();
                        var datos = JsonConvert.DeserializeObject<dynamic[]>(contenido);

                        foreach (var dato in datos)
                        {
                            dataGridView1.Rows.Add(
                                dato.nombre.ToString(),
                                dato.ap_paterno.ToString(),
                                dato.ap_materno.ToString(),
                                dato.correo.ToString(),
                                dato.tipo.ToString(),
                                dato.departamento.ToString()
                            );
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al obtener los datos: " + respuesta.ReasonPhrase);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
