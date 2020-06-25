namespace ProyectoGetHospi.Vista
{
    partial class RegistrarMed
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
            System.Windows.Forms.Label cedulaMedicoLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label dUILabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarMed));
            this.grbMed = new System.Windows.Forms.GroupBox();
            this.cedulaMedicoTextBox = new System.Windows.Forms.TextBox();
            this.médicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.dUITextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.btnNuevoMed = new System.Windows.Forms.Button();
            this.btnGuardarMed = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            cedulaMedicoLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            dUILabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            this.grbMed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.médicoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cedulaMedicoLabel
            // 
            cedulaMedicoLabel.AutoSize = true;
            cedulaMedicoLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cedulaMedicoLabel.Location = new System.Drawing.Point(16, 32);
            cedulaMedicoLabel.Name = "cedulaMedicoLabel";
            cedulaMedicoLabel.Size = new System.Drawing.Size(129, 20);
            cedulaMedicoLabel.TabIndex = 0;
            cedulaMedicoLabel.Text = "Cedula Médico:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            direccionLabel.Location = new System.Drawing.Point(17, 121);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(84, 20);
            direccionLabel.TabIndex = 2;
            direccionLabel.Text = "Direccion:";
            // 
            // dUILabel
            // 
            dUILabel.AutoSize = true;
            dUILabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dUILabel.Location = new System.Drawing.Point(17, 95);
            dUILabel.Name = "dUILabel";
            dUILabel.Size = new System.Drawing.Size(40, 20);
            dUILabel.TabIndex = 4;
            dUILabel.Text = "DUI:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(17, 63);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(72, 20);
            nombreLabel.TabIndex = 8;
            nombreLabel.Text = "Nombre:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefonoLabel.Location = new System.Drawing.Point(17, 151);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(75, 20);
            telefonoLabel.TabIndex = 10;
            telefonoLabel.Text = "Telefono:";
            // 
            // grbMed
            // 
            this.grbMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(231)))), ((int)(((byte)(159)))));
            this.grbMed.Controls.Add(cedulaMedicoLabel);
            this.grbMed.Controls.Add(this.cedulaMedicoTextBox);
            this.grbMed.Controls.Add(direccionLabel);
            this.grbMed.Controls.Add(this.direccionTextBox);
            this.grbMed.Controls.Add(dUILabel);
            this.grbMed.Controls.Add(this.dUITextBox);
            this.grbMed.Controls.Add(nombreLabel);
            this.grbMed.Controls.Add(this.nombreTextBox);
            this.grbMed.Controls.Add(telefonoLabel);
            this.grbMed.Controls.Add(this.telefonoTextBox);
            this.grbMed.Location = new System.Drawing.Point(43, 41);
            this.grbMed.Name = "grbMed";
            this.grbMed.Size = new System.Drawing.Size(361, 185);
            this.grbMed.TabIndex = 0;
            this.grbMed.TabStop = false;
            // 
            // cedulaMedicoTextBox
            // 
            this.cedulaMedicoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cedulaMedicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.médicoBindingSource, "CedulaMedico", true));
            this.cedulaMedicoTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cedulaMedicoTextBox.Location = new System.Drawing.Point(167, 34);
            this.cedulaMedicoTextBox.Name = "cedulaMedicoTextBox";
            this.cedulaMedicoTextBox.Size = new System.Drawing.Size(166, 19);
            this.cedulaMedicoTextBox.TabIndex = 1;
            this.cedulaMedicoTextBox.TextChanged += new System.EventHandler(this.cedulaMedicoTextBox_TextChanged);
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.médicoBindingSource, "Direccion", true));
            this.direccionTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccionTextBox.Location = new System.Drawing.Point(167, 124);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(166, 19);
            this.direccionTextBox.TabIndex = 3;
            this.direccionTextBox.TextChanged += new System.EventHandler(this.direccionTextBox_TextChanged);
            // 
            // dUITextBox
            // 
            this.dUITextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dUITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.médicoBindingSource, "DUI", true));
            this.dUITextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dUITextBox.Location = new System.Drawing.Point(167, 95);
            this.dUITextBox.Name = "dUITextBox";
            this.dUITextBox.Size = new System.Drawing.Size(166, 19);
            this.dUITextBox.TabIndex = 5;
            this.dUITextBox.TextChanged += new System.EventHandler(this.dUITextBox_TextChanged);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.médicoBindingSource, "Nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(167, 63);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(166, 19);
            this.nombreTextBox.TabIndex = 9;
            this.nombreTextBox.TextChanged += new System.EventHandler(this.nombreTextBox_TextChanged);
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.médicoBindingSource, "Telefono", true));
            this.telefonoTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonoTextBox.Location = new System.Drawing.Point(167, 151);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(166, 19);
            this.telefonoTextBox.TabIndex = 11;
            this.telefonoTextBox.TextChanged += new System.EventHandler(this.telefonoTextBox_TextChanged);
            // 
            // btnNuevoMed
            // 
            this.btnNuevoMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.btnNuevoMed.FlatAppearance.BorderSize = 0;
            this.btnNuevoMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoMed.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoMed.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoMed.Image")));
            this.btnNuevoMed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoMed.Location = new System.Drawing.Point(433, 76);
            this.btnNuevoMed.Name = "btnNuevoMed";
            this.btnNuevoMed.Size = new System.Drawing.Size(98, 39);
            this.btnNuevoMed.TabIndex = 1;
            this.btnNuevoMed.Text = "Nuevo";
            this.btnNuevoMed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoMed.UseVisualStyleBackColor = false;
            this.btnNuevoMed.Click += new System.EventHandler(this.btnNuevoMed_Click);
            // 
            // btnGuardarMed
            // 
            this.btnGuardarMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.btnGuardarMed.FlatAppearance.BorderSize = 0;
            this.btnGuardarMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarMed.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarMed.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarMed.Image")));
            this.btnGuardarMed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarMed.Location = new System.Drawing.Point(433, 154);
            this.btnGuardarMed.Name = "btnGuardarMed";
            this.btnGuardarMed.Size = new System.Drawing.Size(98, 39);
            this.btnGuardarMed.TabIndex = 2;
            this.btnGuardarMed.Text = "Guardar";
            this.btnGuardarMed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarMed.UseVisualStyleBackColor = false;
            this.btnGuardarMed.Click += new System.EventHandler(this.btnGuardarMed_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Registro Médico";
            // 
            // RegistrarMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(231)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(566, 254);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardarMed);
            this.Controls.Add(this.btnNuevoMed);
            this.Controls.Add(this.grbMed);
            this.Name = "RegistrarMed";
            this.Text = "Registrar";
            this.Load += new System.EventHandler(this.RegistrarMed_Load);
            this.grbMed.ResumeLayout(false);
            this.grbMed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.médicoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbMed;
        private System.Windows.Forms.TextBox cedulaMedicoTextBox;
        private System.Windows.Forms.BindingSource médicoBindingSource;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox dUITextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.Button btnNuevoMed;
        private System.Windows.Forms.Button btnGuardarMed;
        private System.Windows.Forms.Label label1;
    }
}