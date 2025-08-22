namespace VistaMadrid.Vista.RegistroMovimiento
{
    partial class frmRegistroMovimiento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnSuperior = new System.Windows.Forms.Panel();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnProducto = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.GRD = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnProcesarMovimiento = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnCliente = new System.Windows.Forms.Panel();
            this.TObservaciones = new ReaLTaiizor.Controls.CyberRichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CID_MovimientoTipo = new System.Windows.Forms.ComboBox();
            this.pnMesa = new System.Windows.Forms.Panel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.NUMCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.CID_Producto = new System.Windows.Forms.ComboBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pnSuperior.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnProducto.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRD)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnCliente.SuspendLayout();
            this.pnMesa.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUMCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // pnSuperior
            // 
            this.pnSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnSuperior.Controls.Add(this.lblEmpleado);
            this.pnSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnSuperior.Name = "pnSuperior";
            this.pnSuperior.Size = new System.Drawing.Size(1144, 70);
            this.pnSuperior.TabIndex = 20;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.lblEmpleado.Location = new System.Drawing.Point(5, 10);
            this.lblEmpleado.Margin = new System.Windows.Forms.Padding(5);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(408, 40);
            this.lblEmpleado.TabIndex = 18;
            this.lblEmpleado.Text = "Movimiento de Inventario";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 70);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1144, 683);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnProducto);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(27, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 653);
            this.panel1.TabIndex = 0;
            // 
            // pnProducto
            // 
            this.pnProducto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnProducto.Controls.Add(this.tableLayoutPanel4);
            this.pnProducto.Controls.Add(this.tableLayoutPanel3);
            this.pnProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnProducto.Location = new System.Drawing.Point(0, 266);
            this.pnProducto.Name = "pnProducto";
            this.pnProducto.Size = new System.Drawing.Size(1090, 387);
            this.pnProducto.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel4.Controls.Add(this.GRD, 1, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1090, 338);
            this.tableLayoutPanel4.TabIndex = 62;
            // 
            // GRD
            // 
            this.GRD.AllowUserToDeleteRows = false;
            this.GRD.AllowUserToResizeRows = false;
            this.GRD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GRD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GRD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GRD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GRD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.GRD.ColumnHeadersHeight = 33;
            this.GRD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GRD.DefaultCellStyle = dataGridViewCellStyle8;
            this.GRD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GRD.EnableHeadersVisualStyles = false;
            this.GRD.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GRD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GRD.Location = new System.Drawing.Point(16, 16);
            this.GRD.Margin = new System.Windows.Forms.Padding(4);
            this.GRD.Name = "GRD";
            this.GRD.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GRD.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.GRD.RowHeadersWidth = 45;
            this.GRD.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GRD.RowTemplate.Height = 35;
            this.GRD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GRD.Size = new System.Drawing.Size(1058, 306);
            this.GRD.TabIndex = 59;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnProcesarMovimiento, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 338);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1090, 49);
            this.tableLayoutPanel3.TabIndex = 61;
            // 
            // btnProcesarMovimiento
            // 
            this.btnProcesarMovimiento.AutoSize = true;
            this.btnProcesarMovimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(42)))));
            this.btnProcesarMovimiento.CausesValidation = false;
            this.btnProcesarMovimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcesarMovimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProcesarMovimiento.FlatAppearance.BorderSize = 0;
            this.btnProcesarMovimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesarMovimiento.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesarMovimiento.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProcesarMovimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcesarMovimiento.Location = new System.Drawing.Point(448, 3);
            this.btnProcesarMovimiento.Name = "btnProcesarMovimiento";
            this.btnProcesarMovimiento.Size = new System.Drawing.Size(194, 43);
            this.btnProcesarMovimiento.TabIndex = 62;
            this.btnProcesarMovimiento.Text = "Registrar Movimiento";
            this.btnProcesarMovimiento.UseVisualStyleBackColor = false;
            this.btnProcesarMovimiento.Click += new System.EventHandler(this.btnProcesarMovimiento_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.pnCliente, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pnMesa, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1090, 266);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // pnCliente
            // 
            this.pnCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnCliente.Controls.Add(this.TObservaciones);
            this.pnCliente.Controls.Add(this.label7);
            this.pnCliente.Controls.Add(this.label1);
            this.pnCliente.Controls.Add(this.CID_MovimientoTipo);
            this.pnCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCliente.Location = new System.Drawing.Point(549, 6);
            this.pnCliente.Name = "pnCliente";
            this.pnCliente.Size = new System.Drawing.Size(535, 254);
            this.pnCliente.TabIndex = 1;
            // 
            // TObservaciones
            // 
            this.TObservaciones.Alpha = 20;
            this.TObservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TObservaciones.BackColor = System.Drawing.Color.Transparent;
            this.TObservaciones.Background_WidthPen = 1F;
            this.TObservaciones.BackgroundPen = true;
            this.TObservaciones.ColorBackground = System.Drawing.SystemColors.Window;
            this.TObservaciones.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(42)))));
            this.TObservaciones.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.TObservaciones.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.TObservaciones.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.TObservaciones.CyberRichTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.TObservaciones.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TObservaciones.ForeColor = System.Drawing.Color.Black;
            this.TObservaciones.Lighting = false;
            this.TObservaciones.LinearGradientPen = false;
            this.TObservaciones.Location = new System.Drawing.Point(10, 141);
            this.TObservaciones.Name = "TObservaciones";
            this.TObservaciones.PenWidth = 10;
            this.TObservaciones.RGB = false;
            this.TObservaciones.Rounding = true;
            this.TObservaciones.RoundingInt = 20;
            this.TObservaciones.Size = new System.Drawing.Size(512, 84);
            this.TObservaciones.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.TObservaciones.TabIndex = 53;
            this.TObservaciones.Tag = "Cyber";
            this.TObservaciones.TextButton = "";
            this.TObservaciones.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.TObservaciones.Timer_RGB = 300;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.label7.Location = new System.Drawing.Point(6, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 23);
            this.label7.TabIndex = 52;
            this.label7.Text = "Observaciones";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 23);
            this.label1.TabIndex = 31;
            this.label1.Text = "Tipo de Movimiento*";
            // 
            // CID_MovimientoTipo
            // 
            this.CID_MovimientoTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CID_MovimientoTipo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CID_MovimientoTipo.FormattingEnabled = true;
            this.CID_MovimientoTipo.Location = new System.Drawing.Point(10, 74);
            this.CID_MovimientoTipo.Name = "CID_MovimientoTipo";
            this.CID_MovimientoTipo.Size = new System.Drawing.Size(512, 28);
            this.CID_MovimientoTipo.TabIndex = 30;
            // 
            // pnMesa
            // 
            this.pnMesa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnMesa.Controls.Add(this.tableLayoutPanel9);
            this.pnMesa.Controls.Add(this.btnAgregarProducto);
            this.pnMesa.Controls.Add(this.label6);
            this.pnMesa.Controls.Add(this.CID_Producto);
            this.pnMesa.Controls.Add(this.lblInfo);
            this.pnMesa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMesa.Location = new System.Drawing.Point(6, 6);
            this.pnMesa.Name = "pnMesa";
            this.pnMesa.Size = new System.Drawing.Size(534, 254);
            this.pnMesa.TabIndex = 0;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel9.ColumnCount = 3;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.NUMCantidad, 0, 1);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(10, 116);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(511, 65);
            this.tableLayoutPanel9.TabIndex = 66;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.label11.Location = new System.Drawing.Point(5, 5);
            this.label11.Margin = new System.Windows.Forms.Padding(5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 20);
            this.label11.TabIndex = 59;
            this.label11.Text = "Cantidad";
            // 
            // NUMCantidad
            // 
            this.NUMCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NUMCantidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NUMCantidad.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUMCantidad.Location = new System.Drawing.Point(3, 33);
            this.NUMCantidad.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.NUMCantidad.MaximumSize = new System.Drawing.Size(120, 0);
            this.NUMCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUMCantidad.MinimumSize = new System.Drawing.Size(110, 0);
            this.NUMCantidad.Name = "NUMCantidad";
            this.NUMCantidad.Size = new System.Drawing.Size(120, 27);
            this.NUMCantidad.TabIndex = 58;
            this.NUMCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.AutoSize = true;
            this.btnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.btnAgregarProducto.CausesValidation = false;
            this.btnAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProducto.FlatAppearance.BorderSize = 0;
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarProducto.Location = new System.Drawing.Point(10, 199);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(173, 40);
            this.btnAgregarProducto.TabIndex = 60;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.label6.Location = new System.Drawing.Point(6, 43);
            this.label6.Margin = new System.Windows.Forms.Padding(5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 23);
            this.label6.TabIndex = 29;
            this.label6.Text = "Producto*";
            // 
            // CID_Producto
            // 
            this.CID_Producto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CID_Producto.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CID_Producto.FormattingEnabled = true;
            this.CID_Producto.Location = new System.Drawing.Point(10, 74);
            this.CID_Producto.Name = "CID_Producto";
            this.CID_Producto.Size = new System.Drawing.Size(512, 28);
            this.CID_Producto.TabIndex = 28;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.lblInfo.Location = new System.Drawing.Point(5, 5);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(5);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(200, 27);
            this.lblInfo.TabIndex = 19;
            this.lblInfo.Text = "Agregar Productos";
            // 
            // frmRegistroMovimiento
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1144, 753);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnSuperior);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistroMovimiento";
            this.Text = "frmRegistroMovimiento";
            this.pnSuperior.ResumeLayout(false);
            this.pnSuperior.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnProducto.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GRD)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnCliente.ResumeLayout(false);
            this.pnCliente.PerformLayout();
            this.pnMesa.ResumeLayout(false);
            this.pnMesa.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUMCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnSuperior;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnProducto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel pnMesa;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.ComboBox CID_Producto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown NUMCantidad;
        private System.Windows.Forms.Panel pnCliente;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ComboBox CID_MovimientoTipo;
        internal ReaLTaiizor.Controls.CyberRichTextBox TObservaciones;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnProcesarMovimiento;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        internal ReaLTaiizor.Controls.PoisonDataGridView GRD;
    }
}