﻿namespace sistemaCompra
{
    partial class CtrlCliente
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
            pboxEliminar = new PictureBox();
            pboxEditar = new PictureBox();
            pnlDesplegar = new Panel();
            lblTelefono = new Label();
            cboxTipoIdentificacion = new ComboBox();
            txtDireccion = new TextBox();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtIdentificacion = new TextBox();
            lblDireccion = new Label();
            lblCorreo = new Label();
            lblIdentificacion = new Label();
            lblContribuyenteEspecial = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            pboxCancelar = new PictureBox();
            pboxAceptar = new PictureBox();
            pboxNo = new PictureBox();
            pboxSi = new PictureBox();
            pboxBarra6 = new PictureBox();
            pboxBarra5 = new PictureBox();
            pboxBarra4 = new PictureBox();
            pboxBarra3 = new PictureBox();
            pboxBarra2 = new PictureBox();
            pboxBarra = new PictureBox();
            pboxDatos = new PictureBox();
            pboxAgregar = new PictureBox();
            pboxCtrlClientes = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pboxEliminar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxEditar).BeginInit();
            pnlDesplegar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxCancelar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxAceptar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxNo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxSi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxDatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxAgregar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxCtrlClientes).BeginInit();
            SuspendLayout();
            // 
            // pboxEliminar
            // 
            pboxEliminar.Image = Properties.Resources.ControlEliminar;
            pboxEliminar.Location = new Point(161, 85);
            pboxEliminar.Name = "pboxEliminar";
            pboxEliminar.Size = new Size(46, 51);
            pboxEliminar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxEliminar.TabIndex = 62;
            pboxEliminar.TabStop = false;
            // 
            // pboxEditar
            // 
            pboxEditar.Image = Properties.Resources.VentasEditar;
            pboxEditar.Location = new Point(90, 85);
            pboxEditar.Name = "pboxEditar";
            pboxEditar.Size = new Size(46, 51);
            pboxEditar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxEditar.TabIndex = 61;
            pboxEditar.TabStop = false;
            pboxEditar.Click += pboxEditar_Click;
            // 
            // pnlDesplegar
            // 
            pnlDesplegar.Controls.Add(lblTelefono);
            pnlDesplegar.Controls.Add(cboxTipoIdentificacion);
            pnlDesplegar.Controls.Add(txtDireccion);
            pnlDesplegar.Controls.Add(txtCorreo);
            pnlDesplegar.Controls.Add(txtTelefono);
            pnlDesplegar.Controls.Add(txtApellido);
            pnlDesplegar.Controls.Add(txtNombre);
            pnlDesplegar.Controls.Add(txtIdentificacion);
            pnlDesplegar.Controls.Add(lblDireccion);
            pnlDesplegar.Controls.Add(lblCorreo);
            pnlDesplegar.Controls.Add(lblIdentificacion);
            pnlDesplegar.Controls.Add(lblContribuyenteEspecial);
            pnlDesplegar.Controls.Add(lblApellido);
            pnlDesplegar.Controls.Add(lblNombre);
            pnlDesplegar.Controls.Add(pboxCancelar);
            pnlDesplegar.Controls.Add(pboxAceptar);
            pnlDesplegar.Controls.Add(pboxNo);
            pnlDesplegar.Controls.Add(pboxSi);
            pnlDesplegar.Controls.Add(pboxBarra6);
            pnlDesplegar.Controls.Add(pboxBarra5);
            pnlDesplegar.Controls.Add(pboxBarra4);
            pnlDesplegar.Controls.Add(pboxBarra3);
            pnlDesplegar.Controls.Add(pboxBarra2);
            pnlDesplegar.Controls.Add(pboxBarra);
            pnlDesplegar.Controls.Add(pboxDatos);
            pnlDesplegar.Location = new Point(243, 85);
            pnlDesplegar.Margin = new Padding(3, 4, 3, 4);
            pnlDesplegar.Name = "pnlDesplegar";
            pnlDesplegar.Size = new Size(431, 321);
            pnlDesplegar.TabIndex = 60;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("OCR A Extended", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblTelefono.Location = new Point(66, 131);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(80, 17);
            lblTelefono.TabIndex = 75;
            lblTelefono.Text = "Teléfono";
            // 
            // cboxTipoIdentificacion
            // 
            cboxTipoIdentificacion.FormattingEnabled = true;
            cboxTipoIdentificacion.Items.AddRange(new object[] { "V", "E", "J" });
            cboxTipoIdentificacion.Location = new Point(43, 55);
            cboxTipoIdentificacion.Margin = new Padding(3, 4, 3, 4);
            cboxTipoIdentificacion.Name = "cboxTipoIdentificacion";
            cboxTipoIdentificacion.Size = new Size(41, 28);
            cboxTipoIdentificacion.TabIndex = 63;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(286, 164);
            txtDireccion.Margin = new Padding(3, 4, 3, 4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(114, 27);
            txtDireccion.TabIndex = 74;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(165, 164);
            txtCorreo.Margin = new Padding(3, 4, 3, 4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(114, 27);
            txtCorreo.TabIndex = 73;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(43, 164);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(114, 27);
            txtTelefono.TabIndex = 72;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(286, 55);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(114, 27);
            txtApellido.TabIndex = 71;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(165, 55);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(114, 27);
            txtNombre.TabIndex = 70;
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(82, 55);
            txtIdentificacion.Margin = new Padding(3, 4, 3, 4);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(75, 27);
            txtIdentificacion.TabIndex = 58;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("OCR A Extended", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblDireccion.Location = new Point(303, 131);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(89, 17);
            lblDireccion.TabIndex = 69;
            lblDireccion.Text = "Dirección";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("OCR A Extended", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblCorreo.Location = new Point(189, 131);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(62, 17);
            lblCorreo.TabIndex = 68;
            lblCorreo.Text = "E-mail";
            // 
            // lblIdentificacion
            // 
            lblIdentificacion.AutoSize = true;
            lblIdentificacion.Font = new Font("OCR A Extended", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblIdentificacion.Location = new Point(38, 21);
            lblIdentificacion.Name = "lblIdentificacion";
            lblIdentificacion.Size = new Size(134, 17);
            lblIdentificacion.TabIndex = 67;
            lblIdentificacion.Text = "Identificación";
            // 
            // lblContribuyenteEspecial
            // 
            lblContribuyenteEspecial.AutoSize = true;
            lblContribuyenteEspecial.Font = new Font("OCR A Extended", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblContribuyenteEspecial.Location = new Point(39, 244);
            lblContribuyenteEspecial.Name = "lblContribuyenteEspecial";
            lblContribuyenteEspecial.Size = new Size(44, 17);
            lblContribuyenteEspecial.TabIndex = 66;
            lblContribuyenteEspecial.Text = "C.E.";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("OCR A Extended", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblApellido.Location = new Point(303, 21);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(80, 17);
            lblApellido.TabIndex = 65;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("OCR A Extended", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblNombre.Location = new Point(189, 21);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(62, 17);
            lblNombre.TabIndex = 64;
            lblNombre.Text = "Nombre";
            // 
            // pboxCancelar
            // 
            pboxCancelar.Image = Properties.Resources.BotonCancelar1;
            pboxCancelar.Location = new Point(310, 244);
            pboxCancelar.Name = "pboxCancelar";
            pboxCancelar.Size = new Size(90, 43);
            pboxCancelar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxCancelar.TabIndex = 63;
            pboxCancelar.TabStop = false;
            pboxCancelar.Click += pboxCancelar_Click;
            // 
            // pboxAceptar
            // 
            pboxAceptar.Image = Properties.Resources.BotonAceptar1;
            pboxAceptar.Location = new Point(213, 244);
            pboxAceptar.Name = "pboxAceptar";
            pboxAceptar.Size = new Size(90, 43);
            pboxAceptar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxAceptar.TabIndex = 56;
            pboxAceptar.TabStop = false;
            // 
            // pboxNo
            // 
            pboxNo.Image = Properties.Resources.BotonCheckbox2;
            pboxNo.Location = new Point(145, 244);
            pboxNo.Name = "pboxNo";
            pboxNo.Size = new Size(61, 32);
            pboxNo.SizeMode = PictureBoxSizeMode.Zoom;
            pboxNo.TabIndex = 62;
            pboxNo.TabStop = false;
            // 
            // pboxSi
            // 
            pboxSi.Image = Properties.Resources.BotonCheckbox1;
            pboxSi.Location = new Point(78, 244);
            pboxSi.Name = "pboxSi";
            pboxSi.Size = new Size(61, 32);
            pboxSi.SizeMode = PictureBoxSizeMode.Zoom;
            pboxSi.TabIndex = 56;
            pboxSi.TabStop = false;
            // 
            // pboxBarra6
            // 
            pboxBarra6.Image = Properties.Resources.ControlDato2;
            pboxBarra6.Location = new Point(286, 187);
            pboxBarra6.Margin = new Padding(3, 4, 3, 4);
            pboxBarra6.Name = "pboxBarra6";
            pboxBarra6.Size = new Size(114, 36);
            pboxBarra6.SizeMode = PictureBoxSizeMode.Zoom;
            pboxBarra6.TabIndex = 61;
            pboxBarra6.TabStop = false;
            // 
            // pboxBarra5
            // 
            pboxBarra5.Image = Properties.Resources.ControlDato2;
            pboxBarra5.Location = new Point(165, 187);
            pboxBarra5.Margin = new Padding(3, 4, 3, 4);
            pboxBarra5.Name = "pboxBarra5";
            pboxBarra5.Size = new Size(114, 36);
            pboxBarra5.SizeMode = PictureBoxSizeMode.Zoom;
            pboxBarra5.TabIndex = 60;
            pboxBarra5.TabStop = false;
            // 
            // pboxBarra4
            // 
            pboxBarra4.Image = Properties.Resources.ControlDato2;
            pboxBarra4.Location = new Point(43, 187);
            pboxBarra4.Margin = new Padding(3, 4, 3, 4);
            pboxBarra4.Name = "pboxBarra4";
            pboxBarra4.Size = new Size(114, 36);
            pboxBarra4.SizeMode = PictureBoxSizeMode.Zoom;
            pboxBarra4.TabIndex = 59;
            pboxBarra4.TabStop = false;
            // 
            // pboxBarra3
            // 
            pboxBarra3.Image = Properties.Resources.ControlDato2;
            pboxBarra3.Location = new Point(286, 79);
            pboxBarra3.Margin = new Padding(3, 4, 3, 4);
            pboxBarra3.Name = "pboxBarra3";
            pboxBarra3.Size = new Size(114, 36);
            pboxBarra3.SizeMode = PictureBoxSizeMode.Zoom;
            pboxBarra3.TabIndex = 58;
            pboxBarra3.TabStop = false;
            // 
            // pboxBarra2
            // 
            pboxBarra2.Image = Properties.Resources.ControlDato2;
            pboxBarra2.Location = new Point(165, 79);
            pboxBarra2.Margin = new Padding(3, 4, 3, 4);
            pboxBarra2.Name = "pboxBarra2";
            pboxBarra2.Size = new Size(114, 36);
            pboxBarra2.SizeMode = PictureBoxSizeMode.Zoom;
            pboxBarra2.TabIndex = 57;
            pboxBarra2.TabStop = false;
            // 
            // pboxBarra
            // 
            pboxBarra.Image = Properties.Resources.ControlDato2;
            pboxBarra.Location = new Point(82, 79);
            pboxBarra.Margin = new Padding(3, 4, 3, 4);
            pboxBarra.Name = "pboxBarra";
            pboxBarra.Size = new Size(75, 36);
            pboxBarra.SizeMode = PictureBoxSizeMode.Zoom;
            pboxBarra.TabIndex = 56;
            pboxBarra.TabStop = false;
            // 
            // pboxDatos
            // 
            pboxDatos.Image = Properties.Resources.ControlDesplegar;
            pboxDatos.Location = new Point(17, 0);
            pboxDatos.Name = "pboxDatos";
            pboxDatos.Size = new Size(414, 307);
            pboxDatos.SizeMode = PictureBoxSizeMode.Zoom;
            pboxDatos.TabIndex = 54;
            pboxDatos.TabStop = false;
            // 
            // pboxAgregar
            // 
            pboxAgregar.Image = Properties.Resources.ControlAñadir;
            pboxAgregar.Location = new Point(19, 85);
            pboxAgregar.Name = "pboxAgregar";
            pboxAgregar.Size = new Size(46, 51);
            pboxAgregar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxAgregar.TabIndex = 59;
            pboxAgregar.TabStop = false;
            pboxAgregar.Click += pboxAgregar_Click;
            // 
            // pboxCtrlClientes
            // 
            pboxCtrlClientes.Image = Properties.Resources.ControlClientes;
            pboxCtrlClientes.Location = new Point(150, 11);
            pboxCtrlClientes.Margin = new Padding(3, 4, 3, 4);
            pboxCtrlClientes.Name = "pboxCtrlClientes";
            pboxCtrlClientes.Size = new Size(338, 40);
            pboxCtrlClientes.SizeMode = PictureBoxSizeMode.Zoom;
            pboxCtrlClientes.TabIndex = 58;
            pboxCtrlClientes.TabStop = false;
            // 
            // CtrlCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 417);
            Controls.Add(pboxEliminar);
            Controls.Add(pboxEditar);
            Controls.Add(pnlDesplegar);
            Controls.Add(pboxAgregar);
            Controls.Add(pboxCtrlClientes);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CtrlCliente";
            Text = "CtrlCliente";
            Load += CtrlCliente_Load;
            ((System.ComponentModel.ISupportInitialize)pboxEliminar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxEditar).EndInit();
            pnlDesplegar.ResumeLayout(false);
            pnlDesplegar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pboxCancelar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxAceptar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxNo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxSi).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxDatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxAgregar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxCtrlClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pboxEliminar;
        private PictureBox pboxEditar;
        private Panel pnlDesplegar;
        private TextBox txtDireccion;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtIdentificacion;
        private Label lblDireccion;
        private Label lblCorreo;
        private Label lblIdentificacion;
        private Label lblContribuyenteEspecial;
        private Label lblApellido;
        private Label lblNombre;
        private PictureBox pboxCancelar;
        private PictureBox pboxAceptar;
        private PictureBox pboxNo;
        private PictureBox pboxSi;
        private PictureBox pboxBarra6;
        private PictureBox pboxBarra5;
        private PictureBox pboxBarra4;
        private PictureBox pboxBarra3;
        private PictureBox pboxBarra2;
        private PictureBox pboxBarra;
        private PictureBox pboxDatos;
        private PictureBox pboxAgregar;
        private PictureBox pboxCtrlClientes;
        private ComboBox cboxTipoIdentificacion;
        private Label lblTelefono;
    }
}