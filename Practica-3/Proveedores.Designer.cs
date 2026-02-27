namespace Practica_3
{
    partial class Proveedores
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
            label2 = new Label();
            label1 = new Label();
            txtCodigo = new TextBox();
            txtDireccion = new TextBox();
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
            menuStrip1.Size = new Size(985, 28);
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
            groupBox2.Location = new Point(12, 361);
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
            btnCargar.Location = new Point(567, 551);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(412, 55);
            btnCargar.TabIndex = 11;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = false;
            btnCargar.Click += btnCargar_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtCodigo);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(btnActualizar);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(brnAgregar);
            groupBox1.Location = new Point(8, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(553, 318);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insertar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 115);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 10;
            label2.Text = "Direccion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 32);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 9;
            label1.Text = "Nombre";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(21, 210);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(199, 27);
            txtCodigo.TabIndex = 8;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(21, 138);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(199, 27);
            txtDireccion.TabIndex = 7;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(403, 262);
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
            brnAgregar.Location = new Point(260, 262);
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
            lbxAgregar.Location = new Point(567, 41);
            lbxAgregar.Name = "lbxAgregar";
            lbxAgregar.Size = new Size(412, 504);
            lbxAgregar.TabIndex = 10;
            // 
            // Proveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(985, 611);
            Controls.Add(groupBox2);
            Controls.Add(btnCargar);
            Controls.Add(groupBox1);
            Controls.Add(lbxAgregar);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Proveedores";
            Text = "Proveedores";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Label label1;
        private TextBox txtCodigo;
        private TextBox txtDireccion;
        private Button btnActualizar;
        private TextBox txtNombre;
        private Button brnAgregar;
        private ListBox lbxAgregar;
        private Label label2;
    }
}