namespace VistaMadrid.Vista.RegistroPagos
{
    partial class frmRegistroPagos
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnProducto = new System.Windows.Forms.Panel();
            this.GRD = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnCliente = new System.Windows.Forms.Panel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRegistrarPago = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.TMontoTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CID_MetodoPago = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnMesa = new System.Windows.Forms.Panel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAgregarOrden = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.CID_Orden = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.LTotal = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.LSubtotal = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRD)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnCliente.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.pnMesa.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
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
            this.tableLayoutPanel1.TabIndex = 22;
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
            this.pnProducto.Controls.Add(this.GRD);
            this.pnProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnProducto.Location = new System.Drawing.Point(0, 285);
            this.pnProducto.Name = "pnProducto";
            this.pnProducto.Size = new System.Drawing.Size(1090, 368);
            this.pnProducto.TabIndex = 2;
            // 
            // GRD
            // 
            this.GRD.AllowUserToDeleteRows = false;
            this.GRD.AllowUserToResizeRows = false;
            this.GRD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.GRD.Location = new System.Drawing.Point(0, 0);
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
            this.GRD.Size = new System.Drawing.Size(1090, 368);
            this.GRD.TabIndex = 63;
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
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 282F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1090, 285);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // pnCliente
            // 
            this.pnCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnCliente.Controls.Add(this.tableLayoutPanel6);
            this.pnCliente.Controls.Add(this.tableLayoutPanel4);
            this.pnCliente.Controls.Add(this.label4);
            this.pnCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCliente.Location = new System.Drawing.Point(549, 6);
            this.pnCliente.Name = "pnCliente";
            this.pnCliente.Size = new System.Drawing.Size(535, 273);
            this.pnCliente.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.btnRegistrarPago, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 143);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(535, 130);
            this.tableLayoutPanel6.TabIndex = 62;
            // 
            // btnRegistrarPago
            // 
            this.btnRegistrarPago.AutoSize = true;
            this.btnRegistrarPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(42)))));
            this.btnRegistrarPago.CausesValidation = false;
            this.btnRegistrarPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRegistrarPago.FlatAppearance.BorderSize = 0;
            this.btnRegistrarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarPago.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPago.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegistrarPago.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrarPago.Location = new System.Drawing.Point(170, 3);
            this.btnRegistrarPago.Name = "btnRegistrarPago";
            this.btnRegistrarPago.Size = new System.Drawing.Size(194, 45);
            this.btnRegistrarPago.TabIndex = 62;
            this.btnRegistrarPago.Text = "Registrar Pago";
            this.btnRegistrarPago.UseVisualStyleBackColor = false;
            this.btnRegistrarPago.Click += new System.EventHandler(this.btnProcesarMovimiento_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.TMontoTotal, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.CID_MetodoPago, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(10, 33);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(518, 77);
            this.tableLayoutPanel4.TabIndex = 30;
            // 
            // TMontoTotal
            // 
            this.TMontoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TMontoTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.TMontoTotal.Location = new System.Drawing.Point(272, 39);
            this.TMontoTotal.Name = "TMontoTotal";
            this.TMontoTotal.ReadOnly = true;
            this.TMontoTotal.Size = new System.Drawing.Size(243, 27);
            this.TMontoTotal.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.label7.Location = new System.Drawing.Point(5, 5);
            this.label7.Margin = new System.Windows.Forms.Padding(5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 23);
            this.label7.TabIndex = 28;
            this.label7.Text = "Método de Pago*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.label5.Location = new System.Drawing.Point(274, 5);
            this.label5.Margin = new System.Windows.Forms.Padding(5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 23);
            this.label5.TabIndex = 64;
            this.label5.Text = "Monto*";
            // 
            // CID_MetodoPago
            // 
            this.CID_MetodoPago.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CID_MetodoPago.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CID_MetodoPago.FormattingEnabled = true;
            this.CID_MetodoPago.Location = new System.Drawing.Point(3, 39);
            this.CID_MetodoPago.Name = "CID_MetodoPago";
            this.CID_MetodoPago.Size = new System.Drawing.Size(243, 28);
            this.CID_MetodoPago.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.label4.Location = new System.Drawing.Point(5, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 27);
            this.label4.TabIndex = 20;
            this.label4.Text = "Pago";
            // 
            // pnMesa
            // 
            this.pnMesa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnMesa.Controls.Add(this.tableLayoutPanel7);
            this.pnMesa.Controls.Add(this.tableLayoutPanel3);
            this.pnMesa.Controls.Add(this.lblInfo);
            this.pnMesa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMesa.Location = new System.Drawing.Point(6, 6);
            this.pnMesa.Name = "pnMesa";
            this.pnMesa.Size = new System.Drawing.Size(534, 273);
            this.pnMesa.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel7.Controls.Add(this.btnAgregarOrden, 2, 1);
            this.tableLayoutPanel7.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.CID_Orden, 0, 1);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(9, 31);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(509, 65);
            this.tableLayoutPanel7.TabIndex = 64;
            // 
            // btnAgregarOrden
            // 
            this.btnAgregarOrden.AutoSize = true;
            this.btnAgregarOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.btnAgregarOrden.CausesValidation = false;
            this.btnAgregarOrden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarOrden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgregarOrden.FlatAppearance.BorderSize = 0;
            this.btnAgregarOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarOrden.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarOrden.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregarOrden.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarOrden.Location = new System.Drawing.Point(324, 34);
            this.btnAgregarOrden.Name = "btnAgregarOrden";
            this.btnAgregarOrden.Size = new System.Drawing.Size(182, 28);
            this.btnAgregarOrden.TabIndex = 63;
            this.btnAgregarOrden.Text = "Agregar orden";
            this.btnAgregarOrden.UseVisualStyleBackColor = false;
            this.btnAgregarOrden.Click += new System.EventHandler(this.btnAgregarOrden_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.label6.Location = new System.Drawing.Point(5, 5);
            this.label6.Margin = new System.Windows.Forms.Padding(5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 21);
            this.label6.TabIndex = 27;
            this.label6.Text = "Ordenes con saldo pendiente*";
            // 
            // CID_Orden
            // 
            this.CID_Orden.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CID_Orden.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CID_Orden.FormattingEnabled = true;
            this.CID_Orden.Location = new System.Drawing.Point(3, 34);
            this.CID_Orden.Name = "CID_Orden";
            this.CID_Orden.Size = new System.Drawing.Size(275, 28);
            this.CID_Orden.TabIndex = 20;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 100);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(534, 173);
            this.tableLayoutPanel3.TabIndex = 21;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.LTotal, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.label16, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.LSubtotal, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label13, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label14, 0, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(15, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(504, 155);
            this.tableLayoutPanel5.TabIndex = 62;
            // 
            // LTotal
            // 
            this.LTotal.AutoSize = true;
            this.LTotal.BackColor = System.Drawing.Color.Transparent;
            this.LTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.LTotal.Location = new System.Drawing.Point(257, 107);
            this.LTotal.Margin = new System.Windows.Forms.Padding(5);
            this.LTotal.Name = "LTotal";
            this.LTotal.Size = new System.Drawing.Size(45, 24);
            this.LTotal.TabIndex = 26;
            this.LTotal.Text = "0.00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.label16.Location = new System.Drawing.Point(257, 56);
            this.label16.Margin = new System.Windows.Forms.Padding(5);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 23);
            this.label16.TabIndex = 25;
            this.label16.Text = "0.00";
            // 
            // LSubtotal
            // 
            this.LSubtotal.AutoSize = true;
            this.LSubtotal.BackColor = System.Drawing.Color.Transparent;
            this.LSubtotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.LSubtotal.Location = new System.Drawing.Point(257, 5);
            this.LSubtotal.Margin = new System.Windows.Forms.Padding(5);
            this.LSubtotal.Name = "LSubtotal";
            this.LSubtotal.Size = new System.Drawing.Size(44, 23);
            this.LSubtotal.TabIndex = 24;
            this.LSubtotal.Text = "0.00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.label12.Location = new System.Drawing.Point(5, 5);
            this.label12.Margin = new System.Windows.Forms.Padding(5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 23);
            this.label12.TabIndex = 21;
            this.label12.Text = "Subtotal:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.label13.Location = new System.Drawing.Point(5, 56);
            this.label13.Margin = new System.Windows.Forms.Padding(5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 23);
            this.label13.TabIndex = 22;
            this.label13.Text = "Impuesto:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.label14.Location = new System.Drawing.Point(5, 107);
            this.label14.Margin = new System.Windows.Forms.Padding(5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 24);
            this.label14.TabIndex = 23;
            this.label14.Text = "Total:";
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
            this.lblInfo.Size = new System.Drawing.Size(196, 27);
            this.lblInfo.TabIndex = 19;
            this.lblInfo.Text = "Saldos Pendientes";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panel4.Controls.Add(this.lblEmpleado);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1144, 70);
            this.panel4.TabIndex = 21;
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
            this.lblEmpleado.Size = new System.Drawing.Size(291, 40);
            this.lblEmpleado.TabIndex = 18;
            this.lblEmpleado.Text = "Registro de Pagos";
            // 
            // frmRegistroPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 753);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistroPagos";
            this.Text = "frmRegistroPagos";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnProducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GRD)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnCliente.ResumeLayout(false);
            this.pnCliente.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.pnMesa.ResumeLayout(false);
            this.pnMesa.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnProducto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        internal System.Windows.Forms.Label LTotal;
        private System.Windows.Forms.Label label16;
        internal System.Windows.Forms.Label LSubtotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel pnCliente;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.ComboBox CID_MetodoPago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnMesa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        internal System.Windows.Forms.ComboBox CID_Orden;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Button btnAgregarOrden;
        internal ReaLTaiizor.Controls.PoisonDataGridView GRD;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button btnRegistrarPago;
        internal System.Windows.Forms.TextBox TMontoTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
    }
}