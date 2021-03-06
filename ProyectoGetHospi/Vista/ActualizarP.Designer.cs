﻿namespace ProyectoGetHospi.Vista
{
    partial class ActualizarP
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
            System.Windows.Forms.Label cédulaPacienteLabel;
            System.Windows.Forms.Label direcciónLabel;
            System.Windows.Forms.Label fechaNcimientoLabel;
            System.Windows.Forms.Label grupoSanguineoLabel;
            System.Windows.Forms.Label idPacienteLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label nombreMadreLabel;
            System.Windows.Forms.Label nombrePadreLabel;
            System.Windows.Forms.Label numRegistroLabel;
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActualizarP));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cédulaPacienteTextBox = new System.Windows.Forms.TextBox();
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.direcciónTextBox = new System.Windows.Forms.TextBox();
            this.fechaNcimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.grupoSanguineoTextBox = new System.Windows.Forms.TextBox();
            this.idPacienteTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.nombreMadreTextBox = new System.Windows.Forms.TextBox();
            this.nombrePadreTextBox = new System.Windows.Forms.TextBox();
            this.numRegistroTextBox = new System.Windows.Forms.TextBox();
            this.sexoTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnGuardarP = new System.Windows.Forms.Button();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            cédulaPacienteLabel = new System.Windows.Forms.Label();
            direcciónLabel = new System.Windows.Forms.Label();
            fechaNcimientoLabel = new System.Windows.Forms.Label();
            grupoSanguineoLabel = new System.Windows.Forms.Label();
            idPacienteLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            nombreMadreLabel = new System.Windows.Forms.Label();
            nombrePadreLabel = new System.Windows.Forms.Label();
            numRegistroLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // cédulaPacienteLabel
            // 
            cédulaPacienteLabel.AutoSize = true;
            cédulaPacienteLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cédulaPacienteLabel.Location = new System.Drawing.Point(21, 82);
            cédulaPacienteLabel.Name = "cédulaPacienteLabel";
            cédulaPacienteLabel.Size = new System.Drawing.Size(137, 20);
            cédulaPacienteLabel.TabIndex = 0;
            cédulaPacienteLabel.Text = "Cédula Paciente:";
            // 
            // direcciónLabel
            // 
            direcciónLabel.AutoSize = true;
            direcciónLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            direcciónLabel.Location = new System.Drawing.Point(21, 204);
            direcciónLabel.Name = "direcciónLabel";
            direcciónLabel.Size = new System.Drawing.Size(84, 20);
            direcciónLabel.TabIndex = 2;
            direcciónLabel.Text = "Dirección:";
            // 
            // fechaNcimientoLabel
            // 
            fechaNcimientoLabel.AutoSize = true;
            fechaNcimientoLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaNcimientoLabel.Location = new System.Drawing.Point(21, 144);
            fechaNcimientoLabel.Name = "fechaNcimientoLabel";
            fechaNcimientoLabel.Size = new System.Drawing.Size(147, 20);
            fechaNcimientoLabel.TabIndex = 4;
            fechaNcimientoLabel.Text = "Fecha Nacimiento:";
            // 
            // grupoSanguineoLabel
            // 
            grupoSanguineoLabel.AutoSize = true;
            grupoSanguineoLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            grupoSanguineoLabel.Location = new System.Drawing.Point(21, 315);
            grupoSanguineoLabel.Name = "grupoSanguineoLabel";
            grupoSanguineoLabel.Size = new System.Drawing.Size(141, 20);
            grupoSanguineoLabel.TabIndex = 6;
            grupoSanguineoLabel.Text = "Grupo Sanguineo:";
            // 
            // idPacienteLabel
            // 
            idPacienteLabel.AutoSize = true;
            idPacienteLabel.Enabled = false;
            idPacienteLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idPacienteLabel.Location = new System.Drawing.Point(21, 50);
            idPacienteLabel.Name = "idPacienteLabel";
            idPacienteLabel.Size = new System.Drawing.Size(98, 20);
            idPacienteLabel.TabIndex = 8;
            idPacienteLabel.Text = "Id Paciente:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(21, 115);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(72, 20);
            nombreLabel.TabIndex = 10;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreMadreLabel
            // 
            nombreMadreLabel.AutoSize = true;
            nombreMadreLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreMadreLabel.Location = new System.Drawing.Point(21, 286);
            nombreMadreLabel.Name = "nombreMadreLabel";
            nombreMadreLabel.Size = new System.Drawing.Size(126, 20);
            nombreMadreLabel.TabIndex = 12;
            nombreMadreLabel.Text = "Nombre Madre:";
            // 
            // nombrePadreLabel
            // 
            nombrePadreLabel.AutoSize = true;
            nombrePadreLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombrePadreLabel.Location = new System.Drawing.Point(21, 258);
            nombrePadreLabel.Name = "nombrePadreLabel";
            nombrePadreLabel.Size = new System.Drawing.Size(120, 20);
            nombrePadreLabel.TabIndex = 14;
            nombrePadreLabel.Text = "Nombre Padre:";
            // 
            // numRegistroLabel
            // 
            numRegistroLabel.AutoSize = true;
            numRegistroLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numRegistroLabel.Location = new System.Drawing.Point(21, 16);
            numRegistroLabel.Name = "numRegistroLabel";
            numRegistroLabel.Size = new System.Drawing.Size(108, 20);
            numRegistroLabel.TabIndex = 16;
            numRegistroLabel.Text = "Num Registro:";
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sexoLabel.Location = new System.Drawing.Point(21, 230);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(47, 20);
            sexoLabel.TabIndex = 18;
            sexoLabel.Text = "Sexo:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefonoLabel.Location = new System.Drawing.Point(21, 172);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(75, 20);
            telefonoLabel.TabIndex = 20;
            telefonoLabel.Text = "Telefono:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(cédulaPacienteLabel);
            this.groupBox1.Controls.Add(this.cédulaPacienteTextBox);
            this.groupBox1.Controls.Add(direcciónLabel);
            this.groupBox1.Controls.Add(fechaNcimientoLabel);
            this.groupBox1.Controls.Add(this.sexoTextBox);
            this.groupBox1.Controls.Add(idPacienteLabel);
            this.groupBox1.Controls.Add(this.numRegistroTextBox);
            this.groupBox1.Controls.Add(this.direcciónTextBox);
            this.groupBox1.Controls.Add(this.nombrePadreTextBox);
            this.groupBox1.Controls.Add(this.idPacienteTextBox);
            this.groupBox1.Controls.Add(this.nombreMadreTextBox);
            this.groupBox1.Controls.Add(grupoSanguineoLabel);
            this.groupBox1.Controls.Add(this.nombreTextBox);
            this.groupBox1.Controls.Add(nombreLabel);
            this.groupBox1.Controls.Add(this.fechaNcimientoDateTimePicker);
            this.groupBox1.Controls.Add(this.grupoSanguineoTextBox);
            this.groupBox1.Controls.Add(nombreMadreLabel);
            this.groupBox1.Controls.Add(nombrePadreLabel);
            this.groupBox1.Controls.Add(numRegistroLabel);
            this.groupBox1.Controls.Add(sexoLabel);
            this.groupBox1.Controls.Add(telefonoLabel);
            this.groupBox1.Controls.Add(this.telefonoTextBox);
            this.groupBox1.Location = new System.Drawing.Point(483, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 341);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // cédulaPacienteTextBox
            // 
            this.cédulaPacienteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cédulaPacienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "CédulaPaciente", true));
            this.cédulaPacienteTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cédulaPacienteTextBox.Location = new System.Drawing.Point(196, 82);
            this.cédulaPacienteTextBox.Name = "cédulaPacienteTextBox";
            this.cédulaPacienteTextBox.Size = new System.Drawing.Size(200, 19);
            this.cédulaPacienteTextBox.TabIndex = 1;
            // 
            // direcciónTextBox
            // 
            this.direcciónTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.direcciónTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "Dirección", true));
            this.direcciónTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direcciónTextBox.Location = new System.Drawing.Point(196, 204);
            this.direcciónTextBox.Name = "direcciónTextBox";
            this.direcciónTextBox.Size = new System.Drawing.Size(200, 19);
            this.direcciónTextBox.TabIndex = 3;
            // 
            // fechaNcimientoDateTimePicker
            // 
            this.fechaNcimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pacientesBindingSource, "FechaNcimiento", true));
            this.fechaNcimientoDateTimePicker.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaNcimientoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaNcimientoDateTimePicker.Location = new System.Drawing.Point(196, 146);
            this.fechaNcimientoDateTimePicker.Name = "fechaNcimientoDateTimePicker";
            this.fechaNcimientoDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.fechaNcimientoDateTimePicker.TabIndex = 5;
            // 
            // grupoSanguineoTextBox
            // 
            this.grupoSanguineoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grupoSanguineoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "GrupoSanguineo", true));
            this.grupoSanguineoTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoSanguineoTextBox.Location = new System.Drawing.Point(196, 315);
            this.grupoSanguineoTextBox.Name = "grupoSanguineoTextBox";
            this.grupoSanguineoTextBox.Size = new System.Drawing.Size(200, 19);
            this.grupoSanguineoTextBox.TabIndex = 7;
            // 
            // idPacienteTextBox
            // 
            this.idPacienteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idPacienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "IdPaciente", true));
            this.idPacienteTextBox.Enabled = false;
            this.idPacienteTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idPacienteTextBox.Location = new System.Drawing.Point(196, 50);
            this.idPacienteTextBox.Name = "idPacienteTextBox";
            this.idPacienteTextBox.Size = new System.Drawing.Size(200, 19);
            this.idPacienteTextBox.TabIndex = 9;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "Nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(196, 117);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 19);
            this.nombreTextBox.TabIndex = 11;
            // 
            // nombreMadreTextBox
            // 
            this.nombreMadreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombreMadreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "NombreMadre", true));
            this.nombreMadreTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreMadreTextBox.Location = new System.Drawing.Point(196, 286);
            this.nombreMadreTextBox.Name = "nombreMadreTextBox";
            this.nombreMadreTextBox.Size = new System.Drawing.Size(200, 19);
            this.nombreMadreTextBox.TabIndex = 13;
            // 
            // nombrePadreTextBox
            // 
            this.nombrePadreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombrePadreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "NombrePadre", true));
            this.nombrePadreTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrePadreTextBox.Location = new System.Drawing.Point(196, 256);
            this.nombrePadreTextBox.Name = "nombrePadreTextBox";
            this.nombrePadreTextBox.Size = new System.Drawing.Size(200, 19);
            this.nombrePadreTextBox.TabIndex = 15;
            // 
            // numRegistroTextBox
            // 
            this.numRegistroTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numRegistroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "NumRegistro", true));
            this.numRegistroTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numRegistroTextBox.Location = new System.Drawing.Point(196, 18);
            this.numRegistroTextBox.Name = "numRegistroTextBox";
            this.numRegistroTextBox.Size = new System.Drawing.Size(200, 19);
            this.numRegistroTextBox.TabIndex = 17;
            // 
            // sexoTextBox
            // 
            this.sexoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sexoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "Sexo", true));
            this.sexoTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexoTextBox.Location = new System.Drawing.Point(196, 230);
            this.sexoTextBox.Name = "sexoTextBox";
            this.sexoTextBox.Size = new System.Drawing.Size(200, 19);
            this.sexoTextBox.TabIndex = 19;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "Telefono", true));
            this.telefonoTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonoTextBox.Location = new System.Drawing.Point(196, 174);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(200, 19);
            this.telefonoTextBox.TabIndex = 21;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionar.Image")));
            this.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionar.Location = new System.Drawing.Point(180, 419);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(113, 30);
            this.btnSeleccionar.TabIndex = 3;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnGuardarP
            // 
            this.btnGuardarP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.btnGuardarP.FlatAppearance.BorderSize = 0;
            this.btnGuardarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarP.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarP.Image")));
            this.btnGuardarP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarP.Location = new System.Drawing.Point(666, 419);
            this.btnGuardarP.Name = "btnGuardarP";
            this.btnGuardarP.Size = new System.Drawing.Size(97, 30);
            this.btnGuardarP.TabIndex = 4;
            this.btnGuardarP.Text = "Guardar";
            this.btnGuardarP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarP.UseVisualStyleBackColor = false;
            this.btnGuardarP.Click += new System.EventHandler(this.btnGuardarP_Click);
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.AllowUserToAddRows = false;
            this.dgvPacientes.AllowUserToDeleteRows = false;
            this.dgvPacientes.AutoGenerateColumns = false;
            this.dgvPacientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(231)))));
            this.dgvPacientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.DataSource = this.pacientesBindingSource;
            this.dgvPacientes.Location = new System.Drawing.Point(50, 72);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.ReadOnly = true;
            this.dgvPacientes.Size = new System.Drawing.Size(395, 341);
            this.dgvPacientes.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(619, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Actualizar Pacientes";
            // 
            // ActualizarP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(231)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(960, 456);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPacientes);
            this.Controls.Add(this.btnGuardarP);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ActualizarP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar";
            this.Load += new System.EventHandler(this.ActualizarP_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnGuardarP;
        private System.Windows.Forms.TextBox cédulaPacienteTextBox;
        private System.Windows.Forms.TextBox direcciónTextBox;
        private System.Windows.Forms.DateTimePicker fechaNcimientoDateTimePicker;
        private System.Windows.Forms.TextBox grupoSanguineoTextBox;
        private System.Windows.Forms.TextBox idPacienteTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox nombreMadreTextBox;
        private System.Windows.Forms.TextBox nombrePadreTextBox;
        private System.Windows.Forms.TextBox numRegistroTextBox;
        private System.Windows.Forms.TextBox sexoTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Label label1;
    }
}