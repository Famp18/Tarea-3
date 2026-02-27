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

namespace Practica_3
{
    public partial class Proveedores : Form
    {
        private object dgvProveedores;
        private object txtTelefono;

        private void Proveedores_Load(object sender, EventArgs e)
        {
            // Cargar los proveedores existentes desde la base de datos y mostrarlos en el DataGridView al cargar el formulario.
            string connectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=GestionClientes;Data Source=DESKTOP-ASPTDKA\FRANCISCOMATEO;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string querySeleccionarProveedores = "SELECT id_proveedor, nombre_proveedor, direccion_proveedor, telefono_proveedor FROM Proveedor";
                using (SqlCommand cmd = new SqlCommand(querySeleccionarProveedores, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dgvProveedores.DataSource = dataTable;
                    }
                }
            }
        }
        public Proveedores()
        {
            InitializeComponent();
        }

        private void brnAgregar_Click(object sender, EventArgs e)
        {
            //Agregar un nuevo proveedor a la base de datos. Debes validar que los campos no estén vacíos antes de intentar insertar el nuevo proveedor.

            string connectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=GestionClientes;Data Source=DESKTOP-ASPTDKA\FRANCISCOMATEO;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string queryInsertarProveedor = @"INSERT INTO Proveedor (nombre_proveedor, direccion_proveedor, telefono_proveedor) VALUES (@nombre, @direccion, @telefono)";
                using (SqlCommand cmd = new SqlCommand(queryInsertarProveedor, connection))
                {
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim());
                    cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text.Trim());
                    cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text.Trim());
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Se ha agregado el proveedor a la base de datos.");
                        // Aquí podrías limpiar los campos de texto después de agregar el proveedor
                        txtNombre.Clear();
                        txtDireccion.Clear();
                        txtTelegono.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el proveedor. Por favor, inténtalo de nuevo.");
                    }
                }
            }

        }
        


    

        private void btnCargar_Click(object sender, EventArgs e)
        {
            string connectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=GestionClientes;Data Source=DESKTOP-ASPTDKA\FRANCISCOMATEO;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string querySeleccionarProveedores = "SELECT id_proveedor, nombre_proveedor, direccion_proveedor, telefono_proveedor FROM Proveedor";
                using (SqlCommand cmd = new SqlCommand(querySeleccionarProveedores, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dgvProveedores.DataSource = dataTable;
                    }
                }
            }
            lbxAgregar.Enabled = true;
            lbxAgregar.Visible = true;
            lbxAgregar.Text = "Proveedores cargados correctamente.";
            lbxAgregar.Show();
        }
    }
}
