
namespace Practica_3
{
    partial class Categorias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            groupBox2 = new GroupBox();
            btnEliminar = new Button();
            txtEliminar = new TextBox();
            btnCargar = new Button();
            groupBox1 = new GroupBox();
            txtCodigo = new TextBox();
            txtDescripcion = new TextBox();
            btnActualizar = new Button();
            txtNombre = new TextBox();
            brnAgregar = new Button();
            lbxAgregar = new ListBox();
            menuStrip1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { opcionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(986, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            opcionesToolStripMenuItem.Size = new Size(85, 24);
            opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(121, 26);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(btnEliminar);
            groupBox2.Controls.Add(txtEliminar);
            groupBox2.Location = new Point(13, 362);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(549, 245);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Eliminar";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(48, 157);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(383, 37);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // txtEliminar
            // 
            txtEliminar.Location = new Point(27, 57);
            txtEliminar.Name = "txtEliminar";
            txtEliminar.Size = new Size(496, 27);
            txtEliminar.TabIndex = 8;
            // 
            // btnCargar
            // 
            btnCargar.BackColor = Color.AntiqueWhite;
            btnCargar.Location = new Point(568, 552);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(412, 55);
            btnCargar.TabIndex = 11;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(txtCodigo);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(btnActualizar);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(brnAgregar);
            groupBox1.Location = new Point(9, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(553, 318);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insertar";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(21, 140);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(199, 27);
            txtCodigo.TabIndex = 8;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(21, 214);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(199, 27);
            txtDescripcion.TabIndex = 7;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(393, 262);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(106, 37);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(21, 55);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(199, 27);
            txtNombre.TabIndex = 5;
            // 
            // brnAgregar
            // 
            brnAgregar.Location = new Point(245, 262);
            brnAgregar.Name = "brnAgregar";
            brnAgregar.Size = new Size(106, 37);
            brnAgregar.TabIndex = 1;
            brnAgregar.Text = "Agregar";
            brnAgregar.UseVisualStyleBackColor = true;
            brnAgregar.Click += brnAgregar_Click;
            // 
            // lbxAgregar
            // 
            lbxAgregar.FormattingEnabled = true;
            lbxAgregar.Location = new Point(568, 42);
            lbxAgregar.Name = "lbxAgregar";
            lbxAgregar.Size = new Size(412, 504);
            lbxAgregar.TabIndex = 10;
            // 
            // Categorias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(986, 611);
            Controls.Add(groupBox2);
            Controls.Add(btnCargar);
            Controls.Add(groupBox1);
            Controls.Add(lbxAgregar);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Categorias";
            Text = "Categorias";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void brnAgregar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private GroupBox groupBox2;
        private Button btnEliminar;
        private TextBox txtEliminar;
        private Button btnCargar;
        private GroupBox groupBox1;
        private TextBox txtCodigo;
        private TextBox txtDescripcion;
        private Button btnActualizar;
        private TextBox txtNombre;
        private Button brnAgregar;
        private ListBox lbxAgregar;
    }
}