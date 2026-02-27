using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Practica_3
{
    public partial class Clientes : Form
    {

        private TextBox txtDescripcion;
        private TextBox txtPrecio;
        private DataGridView dgvProductos;


        public Clientes()
        {
            InitializeComponent();
        }

        private void brnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                string.IsNullOrWhiteSpace(cmbSexo.Text))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            var builder = new SqlConnectionStringBuilder
            {
                IntegratedSecurity = true,
                InitialCatalog = "GestionClientes",
                DataSource = @"DESKTOP-ASPTDKA\FRANCISCOMATEO",
                PersistSecurityInfo = false
            };
            using (var connection = new SqlConnection(builder.ConnectionString))
            using (var cmd = connection.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO cliente (nombre, apellido, direccion, sexo) VALUES (@nombre, @apellido, @direccion, @sexo);";
                cmd.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim());
                cmd.Parameters.AddWithValue("@apellido", txtApellido.Text.Trim());
                cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text.Trim());
                cmd.Parameters.AddWithValue("@sexo", cmbSexo.Items);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0) MessageBox.Show("Client inserted.");

                lbxAgregar.Enabled = true;
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            // TODO:  Debes cambiar esta variable connectionString para que pueda conectarse a tu base de datos.
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
        }

        private SqlConnection SqlConnection(string connectionString)
        {
            throw new NotImplementedException();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //Este comando actualizara los datos agregados//

            lbxAgregar.Items.Add(txtNombre);
            lbxAgregar.Items.Add(txtApellido);
            lbxAgregar.Items.Add(txtDireccion);
            lbxAgregar.Items.Add(txtEliminar);

            MessageBox.Show("El campo esta vacio para actualizar");

            return;

        }
    }
}
