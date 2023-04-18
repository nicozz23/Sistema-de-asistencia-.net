namespace SistemaAsistencias.Presentacion
{
    partial class Personal
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personal));
            panel1 = new Panel();
            label1 = new Label();
            PbBuscar = new PictureBox();
            BtnAgregar = new Button();
            BtnMostrar = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            txtBuscar = new TextBox();
            dataGridView1 = new DataGridView();
            PanelPaginado = new Panel();
            panel7 = new Panel();
            button1 = new Button();
            button8 = new Button();
            button13 = new Button();
            button2 = new Button();
            BtnGuardarPersonal = new Button();
            button7 = new Button();
            BtnGuardarCambios = new Button();
            button5 = new Button();
            button6 = new Button();
            PanelCargos = new Panel();
            txtSueldog = new TextBox();
            txtCargog = new TextBox();
            button12 = new Button();
            flowLayoutPanel7 = new FlowLayoutPanel();
            lblAgregarPersonal = new Label();
            flowLayoutPanel4 = new FlowLayoutPanel();
            label11 = new Label();
            flowLayoutPanel11 = new FlowLayoutPanel();
            flowLayoutPanel10 = new FlowLayoutPanel();
            flowLayoutPanel9 = new FlowLayoutPanel();
            flowLayoutPanel8 = new FlowLayoutPanel();
            cmbPais = new ComboBox();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            PanelRegistro = new Panel();
            label2 = new Label();
            txtSueldo = new TextBox();
            txtCargo = new TextBox();
            txtIdentificacion = new TextBox();
            txtNombres = new TextBox();
            datalistadocargo = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbBuscar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            PanelPaginado.SuspendLayout();
            panel7.SuspendLayout();
            PanelCargos.SuspendLayout();
            PanelRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datalistadocargo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(PbBuscar);
            panel1.Controls.Add(BtnAgregar);
            panel1.Controls.Add(BtnMostrar);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(txtBuscar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(2184, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1013, 32);
            label1.Name = "label1";
            label1.Size = new Size(141, 21);
            label1.TabIndex = 16;
            label1.Text = "Agregar Personal";
            // 
            // PbBuscar
            // 
            PbBuscar.Image = (Image)resources.GetObject("PbBuscar.Image");
            PbBuscar.InitialImage = null;
            PbBuscar.Location = new Point(548, 29);
            PbBuscar.Name = "PbBuscar";
            PbBuscar.Size = new Size(44, 37);
            PbBuscar.SizeMode = PictureBoxSizeMode.Zoom;
            PbBuscar.TabIndex = 15;
            PbBuscar.TabStop = false;
            // 
            // BtnAgregar
            // 
            BtnAgregar.BackColor = SystemColors.InactiveCaption;
            BtnAgregar.BackgroundImage = (Image)resources.GetObject("BtnAgregar.BackgroundImage");
            BtnAgregar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnAgregar.FlatAppearance.BorderSize = 0;
            BtnAgregar.FlatStyle = FlatStyle.Flat;
            BtnAgregar.Location = new Point(1188, 17);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(56, 54);
            BtnAgregar.TabIndex = 13;
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // BtnMostrar
            // 
            BtnMostrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnMostrar.Location = new Point(639, 31);
            BtnMostrar.Name = "BtnMostrar";
            BtnMostrar.Size = new Size(179, 39);
            BtnMostrar.TabIndex = 12;
            BtnMostrar.Text = "Mostrar registros";
            BtnMostrar.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Navy;
            flowLayoutPanel1.Location = new Point(282, 66);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(260, 2);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // txtBuscar
            // 
            txtBuscar.BorderStyle = BorderStyle.None;
            txtBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscar.Location = new Point(282, 31);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(260, 22);
            txtBuscar.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.MintCream;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 100);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(2184, 1319);
            dataGridView1.TabIndex = 1;
            // 
            // PanelPaginado
            // 
            PanelPaginado.BackColor = Color.SteelBlue;
            PanelPaginado.Controls.Add(panel7);
            PanelPaginado.Controls.Add(button13);
            PanelPaginado.Dock = DockStyle.Bottom;
            PanelPaginado.Location = new Point(0, 1314);
            PanelPaginado.Name = "PanelPaginado";
            PanelPaginado.Size = new Size(2184, 105);
            PanelPaginado.TabIndex = 32;
            // 
            // panel7
            // 
            panel7.Controls.Add(button1);
            panel7.Controls.Add(button8);
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(363, 105);
            panel7.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(187, 33);
            button1.Name = "button1";
            button1.Size = new Size(145, 36);
            button1.TabIndex = 16;
            button1.Text = "Siguiente";
            button1.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(19, 33);
            button8.Name = "button8";
            button8.Size = new Size(145, 36);
            button8.TabIndex = 15;
            button8.Text = "Anterior";
            button8.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.Location = new Point(87, 35);
            button13.Name = "button13";
            button13.Size = new Size(145, 36);
            button13.TabIndex = 13;
            button13.Text = "Pagina Anterior";
            button13.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(799, 378);
            button2.Name = "button2";
            button2.Size = new Size(145, 36);
            button2.TabIndex = 11;
            button2.Text = "+ Agregar Cargo";
            button2.UseVisualStyleBackColor = true;
            // 
            // BtnGuardarPersonal
            // 
            BtnGuardarPersonal.BackgroundImage = (Image)resources.GetObject("BtnGuardarPersonal.BackgroundImage");
            BtnGuardarPersonal.BackgroundImageLayout = ImageLayout.Stretch;
            BtnGuardarPersonal.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnGuardarPersonal.FlatStyle = FlatStyle.Flat;
            BtnGuardarPersonal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnGuardarPersonal.ForeColor = Color.White;
            BtnGuardarPersonal.Location = new Point(426, 588);
            BtnGuardarPersonal.Name = "BtnGuardarPersonal";
            BtnGuardarPersonal.Size = new Size(140, 41);
            BtnGuardarPersonal.TabIndex = 12;
            BtnGuardarPersonal.Text = "Guardar";
            BtnGuardarPersonal.UseVisualStyleBackColor = true;
            BtnGuardarPersonal.Click += BtnGuardarPersonal_Click;
            // 
            // button7
            // 
            button7.BackgroundImage = (Image)resources.GetObject("button7.BackgroundImage");
            button7.BackgroundImageLayout = ImageLayout.Zoom;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.White;
            button7.Location = new Point(844, 241);
            button7.Name = "button7";
            button7.Size = new Size(117, 54);
            button7.TabIndex = 16;
            button7.UseVisualStyleBackColor = true;
            // 
            // BtnGuardarCambios
            // 
            BtnGuardarCambios.BackgroundImage = (Image)resources.GetObject("BtnGuardarCambios.BackgroundImage");
            BtnGuardarCambios.BackgroundImageLayout = ImageLayout.Stretch;
            BtnGuardarCambios.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnGuardarCambios.FlatStyle = FlatStyle.Flat;
            BtnGuardarCambios.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnGuardarCambios.ForeColor = Color.White;
            BtnGuardarCambios.Location = new Point(637, 588);
            BtnGuardarCambios.Name = "BtnGuardarCambios";
            BtnGuardarCambios.Size = new Size(140, 41);
            BtnGuardarCambios.TabIndex = 17;
            BtnGuardarCambios.Text = "Guardar*";
            BtnGuardarCambios.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(882, 588);
            button5.Name = "button5";
            button5.Size = new Size(140, 41);
            button5.TabIndex = 18;
            button5.Text = "Guardar";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.BackgroundImage = (Image)resources.GetObject("button6.BackgroundImage");
            button6.BackgroundImageLayout = ImageLayout.Stretch;
            button6.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(1121, 588);
            button6.Name = "button6";
            button6.Size = new Size(140, 41);
            button6.TabIndex = 19;
            button6.Text = "Guardar";
            button6.UseVisualStyleBackColor = true;
            // 
            // PanelCargos
            // 
            PanelCargos.BackColor = SystemColors.InactiveCaption;
            PanelCargos.Controls.Add(txtSueldog);
            PanelCargos.Controls.Add(txtCargog);
            PanelCargos.Controls.Add(button12);
            PanelCargos.Controls.Add(flowLayoutPanel7);
            PanelCargos.Controls.Add(lblAgregarPersonal);
            PanelCargos.Controls.Add(flowLayoutPanel4);
            PanelCargos.Controls.Add(label11);
            PanelCargos.Location = new Point(1309, 258);
            PanelCargos.Name = "PanelCargos";
            PanelCargos.Size = new Size(309, 243);
            PanelCargos.TabIndex = 20;
            // 
            // txtSueldog
            // 
            txtSueldog.BorderStyle = BorderStyle.None;
            txtSueldog.Location = new Point(33, 125);
            txtSueldog.Name = "txtSueldog";
            txtSueldog.Size = new Size(260, 22);
            txtSueldog.TabIndex = 33;
            // 
            // txtCargog
            // 
            txtCargog.BorderStyle = BorderStyle.None;
            txtCargog.Location = new Point(33, 49);
            txtCargog.Name = "txtCargog";
            txtCargog.Size = new Size(260, 22);
            txtCargog.TabIndex = 32;
            // 
            // button12
            // 
            button12.BackgroundImage = (Image)resources.GetObject("button12.BackgroundImage");
            button12.BackgroundImageLayout = ImageLayout.Stretch;
            button12.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button12.ForeColor = Color.White;
            button12.Location = new Point(90, 174);
            button12.Name = "button12";
            button12.Size = new Size(140, 41);
            button12.TabIndex = 19;
            button12.Text = "Guardar";
            button12.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.BackColor = Color.Navy;
            flowLayoutPanel7.Location = new Point(33, 154);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Size = new Size(260, 1);
            flowLayoutPanel7.TabIndex = 10;
            // 
            // lblAgregarPersonal
            // 
            lblAgregarPersonal.AutoSize = true;
            lblAgregarPersonal.Location = new Point(90, 91);
            lblAgregarPersonal.Name = "lblAgregarPersonal";
            lblAgregarPersonal.Size = new Size(125, 21);
            lblAgregarPersonal.TabIndex = 7;
            lblAgregarPersonal.Text = "Sueldo por hora:";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.BackColor = Color.Navy;
            flowLayoutPanel4.Location = new Point(33, 75);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(260, 1);
            flowLayoutPanel4.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(130, 18);
            label11.Name = "label11";
            label11.Size = new Size(55, 21);
            label11.TabIndex = 4;
            label11.Text = "Cargo:";
            // 
            // flowLayoutPanel11
            // 
            flowLayoutPanel11.BackColor = Color.Navy;
            flowLayoutPanel11.Location = new Point(501, 277);
            flowLayoutPanel11.Name = "flowLayoutPanel11";
            flowLayoutPanel11.Size = new Size(260, 1);
            flowLayoutPanel11.TabIndex = 21;
            // 
            // flowLayoutPanel10
            // 
            flowLayoutPanel10.BackColor = Color.Navy;
            flowLayoutPanel10.Location = new Point(501, 322);
            flowLayoutPanel10.Name = "flowLayoutPanel10";
            flowLayoutPanel10.Size = new Size(260, 1);
            flowLayoutPanel10.TabIndex = 22;
            // 
            // flowLayoutPanel9
            // 
            flowLayoutPanel9.BackColor = Color.Navy;
            flowLayoutPanel9.Location = new Point(501, 405);
            flowLayoutPanel9.Name = "flowLayoutPanel9";
            flowLayoutPanel9.Size = new Size(260, 1);
            flowLayoutPanel9.TabIndex = 23;
            // 
            // flowLayoutPanel8
            // 
            flowLayoutPanel8.BackColor = Color.Navy;
            flowLayoutPanel8.Location = new Point(501, 451);
            flowLayoutPanel8.Name = "flowLayoutPanel8";
            flowLayoutPanel8.Size = new Size(260, 1);
            flowLayoutPanel8.TabIndex = 24;
            // 
            // cmbPais
            // 
            cmbPais.FormattingEnabled = true;
            cmbPais.Items.AddRange(new object[] { "Argentina", "Bolivia", " Brasil", "Chile", "Colombia", " Ecuador", "Guyana", " Paraguay", " Perú", "Surinam", " Trinidad y Tobago", " Uruguay", "Venezuela" });
            cmbPais.Location = new Point(501, 343);
            cmbPais.Name = "cmbPais";
            cmbPais.Size = new Size(260, 29);
            cmbPais.TabIndex = 25;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(284, 258);
            label17.Name = "label17";
            label17.Size = new Size(151, 21);
            label17.TabIndex = 26;
            label17.Text = "Nombre y Apellidos:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(330, 302);
            label16.Name = "label16";
            label16.Size = new Size(105, 21);
            label16.TabIndex = 27;
            label16.Text = "Identificacion:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(380, 343);
            label15.Name = "label15";
            label15.Size = new Size(40, 21);
            label15.TabIndex = 28;
            label15.Text = "Pais:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(380, 386);
            label14.Name = "label14";
            label14.Size = new Size(55, 21);
            label14.TabIndex = 29;
            label14.Text = "Cargo:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(310, 431);
            label13.Name = "label13";
            label13.Size = new Size(125, 21);
            label13.TabIndex = 30;
            label13.Text = "Sueldo por hora:";
            // 
            // PanelRegistro
            // 
            PanelRegistro.BackColor = SystemColors.ButtonHighlight;
            PanelRegistro.Controls.Add(datalistadocargo);
            PanelRegistro.Controls.Add(label2);
            PanelRegistro.Controls.Add(txtSueldo);
            PanelRegistro.Controls.Add(txtCargo);
            PanelRegistro.Controls.Add(txtIdentificacion);
            PanelRegistro.Controls.Add(txtNombres);
            PanelRegistro.Controls.Add(label13);
            PanelRegistro.Controls.Add(label14);
            PanelRegistro.Controls.Add(label15);
            PanelRegistro.Controls.Add(label16);
            PanelRegistro.Controls.Add(label17);
            PanelRegistro.Controls.Add(cmbPais);
            PanelRegistro.Controls.Add(flowLayoutPanel8);
            PanelRegistro.Controls.Add(flowLayoutPanel9);
            PanelRegistro.Controls.Add(flowLayoutPanel10);
            PanelRegistro.Controls.Add(flowLayoutPanel11);
            PanelRegistro.Controls.Add(PanelCargos);
            PanelRegistro.Controls.Add(button6);
            PanelRegistro.Controls.Add(button5);
            PanelRegistro.Controls.Add(BtnGuardarCambios);
            PanelRegistro.Controls.Add(button7);
            PanelRegistro.Controls.Add(BtnGuardarPersonal);
            PanelRegistro.Controls.Add(button2);
            PanelRegistro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PanelRegistro.Location = new Point(67, 116);
            PanelRegistro.Name = "PanelRegistro";
            PanelRegistro.Size = new Size(2047, 1165);
            PanelRegistro.TabIndex = 3;
            PanelRegistro.Paint += PanelRegistro_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 40F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(501, 67);
            label2.Name = "label2";
            label2.Size = new Size(547, 72);
            label2.TabIndex = 35;
            label2.Text = "Registro de Personal";
            // 
            // txtSueldo
            // 
            txtSueldo.BorderStyle = BorderStyle.None;
            txtSueldo.Location = new Point(501, 423);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(260, 22);
            txtSueldo.TabIndex = 34;
            // 
            // txtCargo
            // 
            txtCargo.BorderStyle = BorderStyle.None;
            txtCargo.Location = new Point(501, 377);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(260, 22);
            txtCargo.TabIndex = 33;
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.BorderStyle = BorderStyle.None;
            txtIdentificacion.Location = new Point(501, 294);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(260, 22);
            txtIdentificacion.TabIndex = 32;
            // 
            // txtNombres
            // 
            txtNombres.BorderStyle = BorderStyle.None;
            txtNombres.Location = new Point(501, 249);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(260, 22);
            txtNombres.TabIndex = 31;
            // 
            // datalistadocargo
            // 
            datalistadocargo.AllowUserToAddRows = false;
            datalistadocargo.AllowUserToDeleteRows = false;
            datalistadocargo.AllowUserToResizeRows = false;
            datalistadocargo.BackgroundColor = SystemColors.InactiveCaption;
            datalistadocargo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datalistadocargo.Location = new Point(996, 258);
            datalistadocargo.Name = "datalistadocargo";
            datalistadocargo.RowTemplate.Height = 25;
            datalistadocargo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datalistadocargo.Size = new Size(298, 243);
            datalistadocargo.TabIndex = 36;
            // 
            // Personal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PanelPaginado);
            Controls.Add(PanelRegistro);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "Personal";
            Size = new Size(2184, 1419);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PbBuscar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            PanelPaginado.ResumeLayout(false);
            panel7.ResumeLayout(false);
            PanelCargos.ResumeLayout(false);
            PanelCargos.PerformLayout();
            PanelRegistro.ResumeLayout(false);
            PanelRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datalistadocargo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox txtBuscar;
        private Button BtnMostrar;
        private Label label6;
        private Button BtnAgregar;
        private Panel PanelPaginado;
        private Panel panel7;
        private Button button1;
        private Button button8;
        private Button button13;
        private PictureBox PbBuscar;
        private Button button2;
        private Button BtnGuardarPersonal;
        private Button button7;
        private Button BtnGuardarCambios;
        private Button button5;
        private Button button6;
        private Panel PanelCargos;
        private Button button12;
        private FlowLayoutPanel flowLayoutPanel7;
        private Label lblAgregarPersonal;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label label11;
        private FlowLayoutPanel flowLayoutPanel11;
        private FlowLayoutPanel flowLayoutPanel10;
        private FlowLayoutPanel flowLayoutPanel9;
        private FlowLayoutPanel flowLayoutPanel8;
        private ComboBox cmbPais;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Panel PanelRegistro;
        private Label label1;
        private TextBox txtSueldo;
        private TextBox txtCargo;
        private TextBox txtIdentificacion;
        private TextBox txtNombres;
        private Label label2;
        private TextBox txtSueldog;
        private TextBox txtCargog;
        private DataGridView datalistadocargo;
    }
}
