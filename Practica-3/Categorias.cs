using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3
{
    public partial class Categorias : Form
    {

        private struct categorias
        {
            public string nombre;
            public string descripcion;
            public string Codigo;

        }

        private const bool V = true;
        private static readonly categorias[] categorias1 = new categorias[10];
        private readonly categorias[] categoriasArray;
        private string rutaArchivo = "lbxRegistro.text";
        private int contador;
        private StringBuilder RutaArchivo;
        private string descripcion;

        public string nombre { get; private set; }
        public string Codigo { get; private set; }
        public object MessageBoxButton { get; private set; }

        public Categorias()
        {
            InitializeComponent();
            categoriasArray = categorias1;
        }

        private void GuardarEnArchivo(Categorias est)
        {
            using (System.IO.StringWriter sw = new System.IO.StringWriter(RutaArchivo))
            {
                sw.WriteLine($"{est.txtNombre},{est.txtDescripcion},{est.txtCodigo}");
            }

        }

        private void Mostrarcategorias(Categorias est, string categorias)
        {
            lbxAgregar.Items.Clear();

            string cabecera = string.Format("{0,-15} {1,-15} {2,-30}", "Nombre", "Apellido", "Descripcion");
            lbxAgregar.Items.Add(cabecera);
            lbxAgregar.Items.Add(new string('-', 60));

            for (int i = 0; i < categoriasArray.Length; i++)
            {
                string linea = string.Format("{0,-15} {1,-15} {2,-30}",
                    categoriasArray[i].nombre,
                    categoriasArray[i].Codigo,
                    categoriasArray[i].descripcion);

                lbxAgregar.Items.Add(linea);
            }
        }


        private void brnAgregar_Click(object sender, EventArgs e, Categorias, categorias categorias)
        {
            if (contador < 10)
            {
                if (txtNombre.Text == "" || txtCodigo.Text == "" || txtDescripcion.Text == "")
                {
                    MessageBox.Show("Por favor complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Categorias est = new Categorias();

                est.nombre = txtNombre.Text;
                est.Codigo = txtCodigo.Text;

                if (!int.TryParse(txtDescripcion.Text, out int nombre) || nombre <= 0)
                {
                    MessageBox.Show("Por favor, ingrese una edad valida,", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!int.TryParse(txtCodigo.Text, out int Codigo) || Codigo <= 0)
                {
                    MessageBox.Show("Por favor, Ingrese un Codigo valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                est = new Categorias();
                est.descripcion = txtDescripcion.Text;
                est.Codigo = txtCodigo.Text;

                nombre[contador] = est;
                contador++;

                GuardarEnArchivo(est);

                MessageBox.Show("Categoria agrada correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("No se puede agregar max categorias. Limite Alcanzado.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            var cs = $"Data Source=DESKTOP-ASPTDKA\\FRANCISCOMATEO;Initial Catalog=GestionClientes;Integrated Security=True;Persist Security Info=False;";
            Console.WriteLine(cs);
            using var conn = new SqlConnection(cs);
            conn.Open();

            System.String queryCliente = "SELECT * FROM CLIENTE;";

            using (SqlCommand CMD = new SqlCommand(queryCliente))
            {
                using (SqlCommand adapter = new SqlCommand())
                {
                    {
                        DataTable dt = new DataTable();
                        adapter.CommandText = queryCliente;
                    }

                }


            }

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (File.Exists(rutaArchivo) == false || contador == 0)
            {
                MessageBox.Show("No hay categorias para mostrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            Mostrarcategorias(this, rutaArchivo);
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe introducir un ID Valido.");
                return;

            }

            string connectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=GestionClientes;Data Source=DESKTOP-ASPTDKA\FRANCISCOMATEO;";

            using (SqlConnection connection = SqlConnection(connectionString))
            {
                connection.Open();

                string queryEliminarCliente = @"DELETE FROM Cliente WHERE id_cliente = '" + txtEliminar + "'";

                using (SqlCommand cmd = new SqlCommand(queryEliminarCliente, connection))
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Se ha eliminado el cliente en la base de datos.");
                    }
                }
                connection.Close();
            }

            if (contador == 0)
            {
                MessageBox.Show("No hay categorias para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string codigoAEliminar = txtEliminar.Text;
            int indice = Array.FindIndex(categoriasArray, c => c.Codigo == codigoAEliminar);
            if (indice >= 0)
            {
                for (int i = indice; i < contador - 1; i++)
                {
                    categoriasArray[i] = categoriasArray[i + 1];
                }
                contador--;
                MessageBox.Show("Categoria eliminada correctamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Codigo no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private SqlConnection SqlConnection(string connectionString)
        {
            throw new NotImplementedException();
        }

    } 
}
