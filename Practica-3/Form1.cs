using System.Windows.Forms;

namespace Practica_3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //configurar la propiedad isMdiContainer = true.
           Clientes frm = new Clientes();
            frm.Show(this); 
            frm.IsMdiContainer = true;

        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categorias frm = new Categorias();
            frm.IsMdiContainer = true;
            frm.Show(this);

        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedores frm = new Proveedores();
            frm.IsMdiContainer = true;
            frm.Show(this);

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos frm = new Productos();
            frm.IsMdiContainer = true;
            frm.Show(this);

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cerrar la aplicación//

            Application.Exit();
        }
    }
}
