﻿namespace ProyectoGetHospi.Vista
{
    partial class ActualizarA
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
            System.Windows.Forms.Label idArchivoLabel;
            System.Windows.Forms.Label idPacienteLabel;
            System.Windows.Forms.Label pesoLabel;
            System.Windows.Forms.Label presionArterialLabel;
            System.Windows.Forms.Label temperaturaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActualizarA));
            this.archivoDataGridView = new System.Windows.Forms.DataGridView();
            this.archivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idArchivoTextBox = new System.Windows.Forms.TextBox();
            this.idPacienteTextBox = new System.Windows.Forms.TextBox();
            this.pesoTextBox = new System.Windows.Forms.TextBox();
            this.presionArterialTextBox = new System.Windows.Forms.TextBox();
            this.temperaturaTextBox = new System.Windows.Forms.TextBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            idArchivoLabel = new System.Windows.Forms.Label();
            idPacienteLabel = new System.Windows.Forms.Label();
            pesoLabel = new System.Windows.Forms.Label();
            presionArterialLabel = new System.Windows.Forms.Label();
            temperaturaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.archivoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.archivoBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idArchivoLabel
            // 
            idArchivoLabel.AutoSize = true;
            idArchivoLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idArchivoLabel.Location = new System.Drawing.Point(17, 42);
            idArchivoLabel.Name = "idArchivoLabel";
            idArchivoLabel.Size = new System.Drawing.Size(90, 20);
            idArchivoLabel.TabIndex = 0;
            idArchivoLabel.Text = "Id Archivo:";
            // 
            // idPacienteLabel
            // 
            idPacienteLabel.AutoSize = true;
            idPacienteLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idPacienteLabel.Location = new System.Drawing.Point(17, 68);
            idPacienteLabel.Name = "idPacienteLabel";
            idPacienteLabel.Size = new System.Drawing.Size(98, 20);
            idPacienteLabel.TabIndex = 2;
            idPacienteLabel.Text = "Id Paciente:";
            // 
            // pesoLabel
            // 
            pesoLabel.AutoSize = true;
            pesoLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pesoLabel.Location = new System.Drawing.Point(17, 94);
            pesoLabel.Name = "pesoLabel";
            pesoLabel.Size = new System.Drawing.Size(48, 20);
            pesoLabel.TabIndex = 4;
            pesoLabel.Text = "Peso:";
            // 
            // presionArterialLabel
            // 
            presionArterialLabel.AutoSize = true;
            presionArterialLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            presionArterialLabel.Location = new System.Drawing.Point(17, 120);
            presionArterialLabel.Name = "presionArterialLabel";
            presionArterialLabel.Size = new System.Drawing.Size(121, 20);
            presionArterialLabel.TabIndex = 6;
            presionArterialLabel.Text = "Presion Arterial:";
            // 
            // temperaturaLabel
            // 
            temperaturaLabel.AutoSize = true;
            temperaturaLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            temperaturaLabel.Location = new System.Drawing.Point(17, 146);
            temperaturaLabel.Name = "temperaturaLabel";
            temperaturaLabel.Size = new System.Drawing.Size(105, 20);
            temperaturaLabel.TabIndex = 8;
            temperaturaLabel.Text = "Temperatura:";
            // 
            // archivoDataGridView
            // 
            this.archivoDataGridView.AllowUserToAddRows = false;
            this.archivoDataGridView.AllowUserToDeleteRows = false;
            this.archivoDataGridView.AutoGenerateColumns = false;
            this.archivoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.archivoDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(231)))));
            this.archivoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.archivoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.archivoDataGridView.DataSource = this.archivoBindingSource;
            this.archivoDataGridView.Location = new System.Drawing.Point(25, 53);
            this.archivoDataGridView.Name = "archivoDataGridView";
            this.archivoDataGridView.ReadOnly = true;
            this.archivoDataGridView.Size = new System.Drawing.Size(458, 254);
            this.archivoDataGridView.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(idArchivoLabel);
            this.groupBox1.Controls.Add(this.idArchivoTextBox);
            this.groupBox1.Controls.Add(idPacienteLabel);
            this.groupBox1.Controls.Add(this.idPacienteTextBox);
            this.groupBox1.Controls.Add(pesoLabel);
            this.groupBox1.Controls.Add(this.pesoTextBox);
            this.groupBox1.Controls.Add(presionArterialLabel);
            this.groupBox1.Controls.Add(this.presionArterialTextBox);
            this.groupBox1.Controls.Add(temperaturaLabel);
            this.groupBox1.Controls.Add(this.temperaturaTextBox);
            this.groupBox1.Location = new System.Drawing.Point(501, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 183);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // idArchivoTextBox
            // 
            this.idArchivoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idArchivoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.archivoBindingSource, "IdArchivo", true));
            this.idArchivoTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idArchivoTextBox.Location = new System.Drawing.Point(156, 42);
            this.idArchivoTextBox.Name = "idArchivoTextBox";
            this.idArchivoTextBox.Size = new System.Drawing.Size(137, 19);
            this.idArchivoTextBox.TabIndex = 1;
            // 
            // idPacienteTextBox
            // 
            this.idPacienteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idPacienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.archivoBindingSource, "IdPaciente", true));
            this.idPacienteTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idPacienteTextBox.Location = new System.Drawing.Point(156, 68);
            this.idPacienteTextBox.Name = "idPacienteTextBox";
            this.idPacienteTextBox.Size = new System.Drawing.Size(137, 19);
            this.idPacienteTextBox.TabIndex = 3;
            // 
            // pesoTextBox
            // 
            this.pesoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pesoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.archivoBindingSource, "Peso", true));
            this.pesoTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesoTextBox.Location = new System.Drawing.Point(156, 95);
            this.pesoTextBox.Name = "pesoTextBox";
            this.pesoTextBox.Size = new System.Drawing.Size(137, 19);
            this.pesoTextBox.TabIndex = 5;
            // 
            // presionArterialTextBox
            // 
            this.presionArterialTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.presionArterialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.archivoBindingSource, "PresionArterial", true));
            this.presionArterialTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presionArterialTextBox.Location = new System.Drawing.Point(156, 120);
            this.presionArterialTextBox.Name = "presionArterialTextBox";
            this.presionArterialTextBox.Size = new System.Drawing.Size(137, 19);
            this.presionArterialTextBox.TabIndex = 7;
            // 
            // temperaturaTextBox
            // 
            this.temperaturaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.temperaturaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.archivoBindingSource, "Temperatura", true));
            this.temperaturaTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperaturaTextBox.Location = new System.Drawing.Point(156, 146);
            this.temperaturaTextBox.Name = "temperaturaTextBox";
            this.temperaturaTextBox.Size = new System.Drawing.Size(137, 19);
            this.temperaturaTextBox.TabIndex = 9;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionar.Image")));
            this.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionar.Location = new System.Drawing.Point(172, 313);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(117, 35);
            this.btnSeleccionar.TabIndex = 3;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(590, 313);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(101, 35);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(567, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "Actualizar Archivo";
            // 
            // ActualizarA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(231)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(832, 368);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.archivoDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ActualizarA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar";
            ((System.ComponentModel.ISupportInitialize)(this.archivoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.archivoBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource archivoBindingSource;
        private System.Windows.Forms.DataGridView archivoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox idArchivoTextBox;
        private System.Windows.Forms.TextBox idPacienteTextBox;
        private System.Windows.Forms.TextBox pesoTextBox;
        private System.Windows.Forms.TextBox presionArterialTextBox;
        private System.Windows.Forms.TextBox temperaturaTextBox;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
    }
}