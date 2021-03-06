﻿namespace ProyectoGetHospi.Vista
{
    partial class fArchivos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fArchivos));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.archivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarNuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volverAlMenuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.archivoBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(231)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.archivoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(213, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(543, 271);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(22, 185);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(118, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarNuevoToolStripMenuItem,
            this.actualizarArchivoToolStripMenuItem,
            this.eliminarArchivoToolStripMenuItem,
            this.cambiarUsuarioToolStripMenuItem,
            this.volverAlMenuPrincipalToolStripMenuItem});
            this.opcionesToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("opcionesToolStripMenuItem.Image")));
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(111, 25);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // registrarNuevoToolStripMenuItem
            // 
            this.registrarNuevoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.registrarNuevoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registrarNuevoToolStripMenuItem.Image")));
            this.registrarNuevoToolStripMenuItem.Name = "registrarNuevoToolStripMenuItem";
            this.registrarNuevoToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.registrarNuevoToolStripMenuItem.Text = "Registrar Nuevo";
            this.registrarNuevoToolStripMenuItem.Click += new System.EventHandler(this.registrarNuevoToolStripMenuItem_Click);
            // 
            // actualizarArchivoToolStripMenuItem
            // 
            this.actualizarArchivoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.actualizarArchivoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("actualizarArchivoToolStripMenuItem.Image")));
            this.actualizarArchivoToolStripMenuItem.Name = "actualizarArchivoToolStripMenuItem";
            this.actualizarArchivoToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.actualizarArchivoToolStripMenuItem.Text = "Actualizar Archivo";
            // 
            // eliminarArchivoToolStripMenuItem
            // 
            this.eliminarArchivoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.eliminarArchivoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eliminarArchivoToolStripMenuItem.Image")));
            this.eliminarArchivoToolStripMenuItem.Name = "eliminarArchivoToolStripMenuItem";
            this.eliminarArchivoToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.eliminarArchivoToolStripMenuItem.Text = "Eliminar Archivo";
            // 
            // volverAlMenuPrincipalToolStripMenuItem
            // 
            this.volverAlMenuPrincipalToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.volverAlMenuPrincipalToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("volverAlMenuPrincipalToolStripMenuItem.Image")));
            this.volverAlMenuPrincipalToolStripMenuItem.Name = "volverAlMenuPrincipalToolStripMenuItem";
            this.volverAlMenuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.volverAlMenuPrincipalToolStripMenuItem.Text = "Volver ";
            this.volverAlMenuPrincipalToolStripMenuItem.Click += new System.EventHandler(this.volverAlMenuPrincipalToolStripMenuItem_Click);
            // 
            // cambiarUsuarioToolStripMenuItem
            // 
            this.cambiarUsuarioToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.cambiarUsuarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cambiarUsuarioToolStripMenuItem.Image")));
            this.cambiarUsuarioToolStripMenuItem.Name = "cambiarUsuarioToolStripMenuItem";
            this.cambiarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.cambiarUsuarioToolStripMenuItem.Text = "Cambiar Usuario";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 400);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Archivos";
            // 
            // fArchivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(231)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(783, 400);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fArchivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Archivos";
            this.Load += new System.EventHandler(this.fArchivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.archivoBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArchivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn presionArterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperaturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource archivoBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarNuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volverAlMenuPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarUsuarioToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}