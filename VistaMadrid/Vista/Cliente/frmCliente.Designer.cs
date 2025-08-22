namespace VistaMadrid.Vista.Mantenimientos.Cliente
{
    partial class frmCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tblCentral = new System.Windows.Forms.TableLayoutPanel();
            this.tblAccesibilidad = new System.Windows.Forms.TableLayoutPanel();
            this.pn3 = new System.Windows.Forms.Panel();
            this.CHKActivo = new System.Windows.Forms.CheckBox();
            this.CID_Condicion = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tblInfoEmpleado = new System.Windows.Forms.TableLayoutPanel();
            this.pn2 = new System.Windows.Forms.Panel();
            this.TDireccion = new ReaLTaiizor.Controls.CyberRichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TTelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pn1 = new System.Windows.Forms.Panel();
            this.TID_Cliente = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnSuperior = new System.Windows.Forms.Panel();
            this.lblAccesibilidad = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.pnInferior = new System.Windows.Forms.Panel();
            this.GRD = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtConsulta1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBuscar = new ReaLTaiizor.Controls.ParrotButton();
            this.txtConsulta2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConsulta3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tblCentral.SuspendLayout();
            this.tblAccesibilidad.SuspendLayout();
            this.pn3.SuspendLayout();
            this.tblInfoEmpleado.SuspendLayout();
            this.pn2.SuspendLayout();
            this.pn1.SuspendLayout();
            this.pnSuperior.SuspendLayout();
            this.pnInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRD)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblCentral
            // 
            this.tblCentral.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tblCentral.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tblCentral.ColumnCount = 2;
            this.tblCentral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCentral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCentral.Controls.Add(this.tblAccesibilidad, 1, 0);
            this.tblCentral.Controls.Add(this.tblInfoEmpleado, 0, 0);
            this.tblCentral.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblCentral.Location = new System.Drawing.Point(0, 93);
            this.tblCentral.Name = "tblCentral";
            this.tblCentral.RowCount = 1;
            this.tblCentral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCentral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 361F));
            this.tblCentral.Size = new System.Drawing.Size(1144, 271);
            this.tblCentral.TabIndex = 5;
            // 
            // tblAccesibilidad
            // 
            this.tblAccesibilidad.ColumnCount = 1;
            this.tblAccesibilidad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblAccesibilidad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblAccesibilidad.Controls.Add(this.pn3, 0, 0);
            this.tblAccesibilidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblAccesibilidad.Location = new System.Drawing.Point(576, 5);
            this.tblAccesibilidad.Name = "tblAccesibilidad";
            this.tblAccesibilidad.RowCount = 1;
            this.tblAccesibilidad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblAccesibilidad.Size = new System.Drawing.Size(563, 261);
            this.tblAccesibilidad.TabIndex = 1;
            // 
            // pn3
            // 
            this.pn3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pn3.Controls.Add(this.CHKActivo);
            this.pn3.Controls.Add(this.CID_Condicion);
            this.pn3.Controls.Add(this.label8);
            this.pn3.Controls.Add(this.label6);
            this.pn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn3.Location = new System.Drawing.Point(3, 3);
            this.pn3.Name = "pn3";
            this.pn3.Size = new System.Drawing.Size(557, 255);
            this.pn3.TabIndex = 0;
            // 
            // CHKActivo
            // 
            this.CHKActivo.AutoSize = true;
            this.CHKActivo.Checked = true;
            this.CHKActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHKActivo.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.CHKActivo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F);
            this.CHKActivo.Location = new System.Drawing.Point(157, 41);
            this.CHKActivo.Name = "CHKActivo";
            this.CHKActivo.Size = new System.Drawing.Size(69, 22);
            this.CHKActivo.TabIndex = 60;
            this.CHKActivo.Text = "Activo";
            this.CHKActivo.UseVisualStyleBackColor = true;
            // 
            // CID_Condicion
            // 
            this.CID_Condicion.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CID_Condicion.FormattingEnabled = true;
            this.CID_Condicion.Location = new System.Drawing.Point(157, 159);
            this.CID_Condicion.Name = "CID_Condicion";
            this.CID_Condicion.Size = new System.Drawing.Size(255, 25);
            this.CID_Condicion.TabIndex = 59;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.label8.Location = new System.Drawing.Point(153, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 38;
            this.label8.Text = "Condición";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.label6.Location = new System.Drawing.Point(153, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Estado";
            // 
            // tblInfoEmpleado
            // 
            this.tblInfoEmpleado.ColumnCount = 2;
            this.tblInfoEmpleado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblInfoEmpleado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblInfoEmpleado.Controls.Add(this.pn2, 1, 0);
            this.tblInfoEmpleado.Controls.Add(this.pn1, 0, 0);
            this.tblInfoEmpleado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblInfoEmpleado.Location = new System.Drawing.Point(5, 5);
            this.tblInfoEmpleado.Name = "tblInfoEmpleado";
            this.tblInfoEmpleado.RowCount = 1;
            this.tblInfoEmpleado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblInfoEmpleado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 353F));
            this.tblInfoEmpleado.Size = new System.Drawing.Size(563, 261);
            this.tblInfoEmpleado.TabIndex = 0;
            // 
            // pn2
            // 
            this.pn2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pn2.Controls.Add(this.TDireccion);
            this.pn2.Controls.Add(this.label5);
            this.pn2.Controls.Add(this.TTelefono);
            this.pn2.Controls.Add(this.label3);
            this.pn2.Location = new System.Drawing.Point(284, 3);
            this.pn2.Name = "pn2";
            this.pn2.Size = new System.Drawing.Size(276, 255);
            this.pn2.TabIndex = 1;
            // 
            // TDireccion
            // 
            this.TDireccion.Alpha = 20;
            this.TDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TDireccion.BackColor = System.Drawing.Color.Transparent;
            this.TDireccion.Background_WidthPen = 1F;
            this.TDireccion.BackgroundPen = true;
            this.TDireccion.ColorBackground = System.Drawing.SystemColors.Window;
            this.TDireccion.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(42)))));
            this.TDireccion.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.TDireccion.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.TDireccion.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.TDireccion.CyberRichTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.TDireccion.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TDireccion.ForeColor = System.Drawing.Color.Black;
            this.TDireccion.Lighting = false;
            this.TDireccion.LinearGradientPen = false;
            this.TDireccion.Location = new System.Drawing.Point(13, 142);
            this.TDireccion.Name = "TDireccion";
            this.TDireccion.PenWidth = 10;
            this.TDireccion.RGB = false;
            this.TDireccion.Rounding = true;
            this.TDireccion.RoundingInt = 20;
            this.TDireccion.Size = new System.Drawing.Size(255, 101);
            this.TDireccion.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.TDireccion.TabIndex = 0;
            this.TDireccion.Tag = "Cyber";
            this.TDireccion.TextButton = "";
            this.TDireccion.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.TDireccion.Timer_RGB = 300;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.label5.Location = new System.Drawing.Point(9, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "Dirección";
            // 
            // TTelefono
            // 
            this.TTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TTelefono.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTelefono.Location = new System.Drawing.Point(13, 41);
            this.TTelefono.Name = "TTelefono";
            this.TTelefono.Size = new System.Drawing.Size(255, 23);
            this.TTelefono.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(9, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Teléfono";
            // 
            // pn1
            // 
            this.pn1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pn1.Controls.Add(this.TID_Cliente);
            this.pn1.Controls.Add(this.label11);
            this.pn1.Controls.Add(this.TEmail);
            this.pn1.Controls.Add(this.label4);
            this.pn1.Controls.Add(this.TNombre);
            this.pn1.Controls.Add(this.label2);
            this.pn1.Location = new System.Drawing.Point(3, 3);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(275, 255);
            this.pn1.TabIndex = 0;
            // 
            // TID_Cliente
            // 
            this.TID_Cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TID_Cliente.Enabled = false;
            this.TID_Cliente.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TID_Cliente.Location = new System.Drawing.Point(13, 41);
            this.TID_Cliente.Name = "TID_Cliente";
            this.TID_Cliente.ReadOnly = true;
            this.TID_Cliente.Size = new System.Drawing.Size(106, 23);
            this.TID_Cliente.TabIndex = 55;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.label11.Location = new System.Drawing.Point(9, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 20);
            this.label11.TabIndex = 54;
            this.label11.Text = "Id";
            // 
            // TEmail
            // 
            this.TEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TEmail.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEmail.Location = new System.Drawing.Point(9, 217);
            this.TEmail.Name = "TEmail";
            this.TEmail.Size = new System.Drawing.Size(255, 23);
            this.TEmail.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.label4.Location = new System.Drawing.Point(9, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Email";
            // 
            // TNombre
            // 
            this.TNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TNombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TNombre.Location = new System.Drawing.Point(9, 116);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(255, 23);
            this.TNombre.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(9, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nombre*";
            // 
            // pnSuperior
            // 
            this.pnSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnSuperior.Controls.Add(this.lblAccesibilidad);
            this.pnSuperior.Controls.Add(this.lblInfo);
            this.pnSuperior.Controls.Add(this.lblCliente);
            this.pnSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnSuperior.Name = "pnSuperior";
            this.pnSuperior.Size = new System.Drawing.Size(1144, 93);
            this.pnSuperior.TabIndex = 6;
            // 
            // lblAccesibilidad
            // 
            this.lblAccesibilidad.AutoSize = true;
            this.lblAccesibilidad.BackColor = System.Drawing.Color.Transparent;
            this.lblAccesibilidad.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccesibilidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.lblAccesibilidad.Location = new System.Drawing.Point(576, 63);
            this.lblAccesibilidad.Margin = new System.Windows.Forms.Padding(5);
            this.lblAccesibilidad.Name = "lblAccesibilidad";
            this.lblAccesibilidad.Size = new System.Drawing.Size(117, 22);
            this.lblAccesibilidad.TabIndex = 19;
            this.lblAccesibilidad.Text = "Accesibilidad";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.lblInfo.Location = new System.Drawing.Point(3, 61);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(5);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(196, 22);
            this.lblInfo.TabIndex = 18;
            this.lblInfo.Text = "Informacion del cliente";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.lblCliente.Location = new System.Drawing.Point(5, 10);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(5);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(331, 31);
            this.lblCliente.TabIndex = 17;
            this.lblCliente.Text = "Mantenimiento de Cliente";
            // 
            // pnInferior
            // 
            this.pnInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnInferior.Controls.Add(this.GRD);
            this.pnInferior.Controls.Add(this.tableLayoutPanel1);
            this.pnInferior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnInferior.Location = new System.Drawing.Point(0, 364);
            this.pnInferior.Name = "pnInferior";
            this.pnInferior.Size = new System.Drawing.Size(1144, 389);
            this.pnInferior.TabIndex = 7;
            // 
            // GRD
            // 
            this.GRD.AllowUserToDeleteRows = false;
            this.GRD.AllowUserToResizeRows = false;
            this.GRD.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.GRD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GRD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GRD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GRD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GRD.ColumnHeadersHeight = 33;
            this.GRD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GRD.DefaultCellStyle = dataGridViewCellStyle2;
            this.GRD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GRD.EnableHeadersVisualStyles = false;
            this.GRD.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GRD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GRD.Location = new System.Drawing.Point(0, 72);
            this.GRD.Margin = new System.Windows.Forms.Padding(4);
            this.GRD.Name = "GRD";
            this.GRD.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GRD.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GRD.RowHeadersWidth = 45;
            this.GRD.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GRD.RowTemplate.Height = 35;
            this.GRD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GRD.Size = new System.Drawing.Size(1144, 317);
            this.GRD.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 320F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 320F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 320F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.label10, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtConsulta1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnBuscar, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtConsulta2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtConsulta3, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.627119F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.54802F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.19774F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.627119F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1144, 72);
            this.tableLayoutPanel1.TabIndex = 55;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.label10.Location = new System.Drawing.Point(716, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 20);
            this.label10.TabIndex = 61;
            this.label10.Text = "Campo 3";
            // 
            // txtConsulta1
            // 
            this.txtConsulta1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsulta1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsulta1.Location = new System.Drawing.Point(76, 36);
            this.txtConsulta1.MaximumSize = new System.Drawing.Size(255, 27);
            this.txtConsulta1.MinimumSize = new System.Drawing.Size(185, 27);
            this.txtConsulta1.Name = "txtConsulta1";
            this.txtConsulta1.Size = new System.Drawing.Size(255, 27);
            this.txtConsulta1.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.label7.Location = new System.Drawing.Point(396, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 60;
            this.label7.Text = "Campo 2 ";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBuscar.ButtonImage = global::VistaMadrid.Properties.Resources.Search;
            this.btnBuscar.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnBuscar.ButtonText = "Buscar";
            this.btnBuscar.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(42)))));
            this.btnBuscar.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnBuscar.CornerRadius = 2;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnBuscar.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(42)))));
            this.btnBuscar.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnBuscar.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnBuscar.Location = new System.Drawing.Point(1036, 36);
            this.btnBuscar.MaximumSize = new System.Drawing.Size(150, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(105, 26);
            this.btnBuscar.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnBuscar.TabIndex = 62;
            this.btnBuscar.TextColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscar.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnBuscar.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // txtConsulta2
            // 
            this.txtConsulta2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsulta2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsulta2.Location = new System.Drawing.Point(396, 36);
            this.txtConsulta2.MaximumSize = new System.Drawing.Size(255, 27);
            this.txtConsulta2.MinimumSize = new System.Drawing.Size(185, 27);
            this.txtConsulta2.Name = "txtConsulta2";
            this.txtConsulta2.Size = new System.Drawing.Size(255, 27);
            this.txtConsulta2.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(76, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 59;
            this.label1.Text = "Campo 1";
            // 
            // txtConsulta3
            // 
            this.txtConsulta3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsulta3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsulta3.Location = new System.Drawing.Point(716, 36);
            this.txtConsulta3.MaximumSize = new System.Drawing.Size(255, 27);
            this.txtConsulta3.MinimumSize = new System.Drawing.Size(185, 27);
            this.txtConsulta3.Name = "txtConsulta3";
            this.txtConsulta3.Size = new System.Drawing.Size(255, 27);
            this.txtConsulta3.TabIndex = 54;
            // 
            // label9
            // 
            this.label9.AutoEllipsis = true;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.label9.Location = new System.Drawing.Point(3, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 28);
            this.label9.TabIndex = 58;
            this.label9.Text = "Buscar por:";
            // 
            // frmCliente
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1144, 753);
            this.Controls.Add(this.pnInferior);
            this.Controls.Add(this.tblCentral);
            this.Controls.Add(this.pnSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCliente";
            this.Text = "frmCliente";
            this.ResizeBegin += new System.EventHandler(this.frmCliente_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.frmCliente_ResizeEnd);
            this.tblCentral.ResumeLayout(false);
            this.tblAccesibilidad.ResumeLayout(false);
            this.pn3.ResumeLayout(false);
            this.pn3.PerformLayout();
            this.tblInfoEmpleado.ResumeLayout(false);
            this.pn2.ResumeLayout(false);
            this.pn2.PerformLayout();
            this.pn1.ResumeLayout(false);
            this.pn1.PerformLayout();
            this.pnSuperior.ResumeLayout(false);
            this.pnSuperior.PerformLayout();
            this.pnInferior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GRD)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblCentral;
        private System.Windows.Forms.TableLayoutPanel tblAccesibilidad;
        private System.Windows.Forms.Panel pn3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tblInfoEmpleado;
        private System.Windows.Forms.Panel pn2;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox TTelefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pn1;
        internal System.Windows.Forms.TextBox TEmail;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnSuperior;
        private System.Windows.Forms.Label lblAccesibilidad;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Panel pnInferior;
        internal ReaLTaiizor.Controls.CyberRichTextBox TDireccion;
        internal System.Windows.Forms.ComboBox CID_Condicion;
        private System.Windows.Forms.TextBox txtConsulta1;
        internal ReaLTaiizor.Controls.PoisonDataGridView GRD;
        private System.Windows.Forms.TextBox txtConsulta3;
        private System.Windows.Forms.TextBox txtConsulta2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        internal System.Windows.Forms.CheckBox CHKActivo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private ReaLTaiizor.Controls.ParrotButton btnBuscar;
        internal System.Windows.Forms.TextBox TID_Cliente;
        private System.Windows.Forms.Label label11;
    }
}