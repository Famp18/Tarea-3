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
    public partial class Productos : Form
    {
        private TextBox txtDescripcion;
        private TextBox txtPrecio;
        private DataGridView dgvProductos;

        public Productos()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            string connectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=GestionClientes;Data Source=DESKTOP-ASPTDKA\FRANCISCOMATEO;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string querySeleccionarProductos = "SELECT id_producto, nombre_producto, descripcion_producto, precio_producto FROM Producto";
                using (SqlCommand cmd = new SqlCommand(querySeleccionarProductos, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dgvProductos.DataSource = dataTable;
                    }
                }
            }
        }

        // Agregar un nuevo producto a la base de datos. Debes validar que los campos no estén vacíos antes de intentar insertar el nuevo producto.

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string connectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=GestionClientes;Data Source=DESKTOP-ASPTDKA\FRANCISCOMATEO;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string queryInsertarProducto = @"INSERT INTO Producto (nombre_producto, descripcion_producto, precio_producto) VALUES (@nombre, @descripcion, @precio)";
                using (SqlCommand cmd = new SqlCommand(queryInsertarProducto, connection))
                {
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim());
                    cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text.Trim());
                    cmd.Parameters.AddWithValue("@precio", decimal.Parse(txtPrecio.Text.Trim()));
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Se ha agregado el producto a la base de datos.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el producto a la base de datos.");
                    }
                }
            }

            btnAgregar_Click(sender, e);
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProductos.Rows[e.RowIndex];
                txtNombre.Text = row.Cells["nombre_producto"].Value.ToString();
                txtDescripcion.Text = row.Cells["descripcion_producto"].Value.ToString();
                txtPrecio.Text = row.Cells["precio_producto"].Value.ToString();
                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                int idProducto = Convert.ToInt32(dgvProductos.CurrentRow.Cells["id_producto"].Value);
                string connectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=GestionClientes;Data Source=DESKTOP-ASPTDKA\FRANCISCOMATEO;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string queryActualizarProducto = @"UPDATE Producto SET nombre_producto = @nombre, descripcion_producto = @descripcion, precio_producto = @precio WHERE id_producto = @id";
                    using (SqlCommand cmd = new SqlCommand(queryActualizarProducto, connection))
                    {
                        cmd.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim());
                        cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text.Trim());
                        cmd.Parameters.AddWithValue("@precio", decimal.Parse(txtPrecio.Text.Trim()));
                        cmd.Parameters.AddWithValue("@id", idProducto);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Se ha actualizado el producto en la base de datos.");
                            btnCargar_Click(sender, e);
                            btnActualizar.Enabled = false;
                            btnEliminar.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar el producto en la base de datos.");
                        }
                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                int idProducto = Convert.ToInt32(dgvProductos.CurrentRow.Cells["id_producto"].Value);
                string connectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=GestionClientes;Data Source=DESKTOP-ASPTDKA\FRANCISCOMATEO;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string queryEliminarProducto = @"DELETE FROM Producto WHERE id_producto = @id";
                    using (SqlCommand cmd = new SqlCommand(queryEliminarProducto, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", idProducto);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Se ha eliminado el producto de la base de datos.");
                            btnCargar_Click(sender, e);
                            btnActualizar.Enabled = false;
                            btnEliminar.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el producto de la base de datos.");
                        }
                    }
                }
            }
        }


    }
}
