namespace VistaMadrid
{
    partial class frmPrincipal2
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
            this.pnSuperior = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.ptbUsuario = new System.Windows.Forms.PictureBox();
            this.pnSeparador = new System.Windows.Forms.Panel();
            this.pnLateral = new System.Windows.Forms.Panel();
            this.pnSubBotones = new System.Windows.Forms.Panel();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnMesas = new System.Windows.Forms.Button();
            this.btnDeudaCliente = new System.Windows.Forms.Button();
            this.btnCuentasVencidas = new System.Windows.Forms.Button();
            this.btnEstadoCuenta = new System.Windows.Forms.Button();
            this.btnCuentasPorCobrar = new System.Windows.Forms.Button();
            this.btnRegistroPago = new System.Windows.Forms.Button();
            this.btnMetodosPago = new System.Windows.Forms.Button();
            this.btnCondicionesPago = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnEntradasYSalidas = new System.Windows.Forms.Button();
            this.btnStockActual = new System.Windows.Forms.Button();
            this.btnMovimiento = new System.Windows.Forms.Button();
            this.btnTiposMovimiento = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnUnidadesMedida = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.pnLatBotones = new System.Windows.Forms.Panel();
            this.pnSubCxC = new System.Windows.Forms.Panel();
            this.btnReportesCxC = new System.Windows.Forms.Button();
            this.btnProcesosCxC = new System.Windows.Forms.Button();
            this.btnMantenimientosCxC = new System.Windows.Forms.Button();
            this.btnCxC = new System.Windows.Forms.Button();
            this.pnSubInventario = new System.Windows.Forms.Panel();
            this.btnReportesInventario = new System.Windows.Forms.Button();
            this.btnProcesosInventario = new System.Windows.Forms.Button();
            this.btnMantenimientosInventario = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.pnSubRestaurante = new System.Windows.Forms.Panel();
            this.btnProcesosRestaurante = new System.Windows.Forms.Button();
            this.btnMantemimientosRestaurante = new System.Windows.Forms.Button();
            this.btnRestaurante = new System.Windows.Forms.Button();
            this.spLateral = new System.Windows.Forms.Splitter();
            this.pnCentral = new System.Windows.Forms.Panel();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.pnContenedorLateral = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUsuario)).BeginInit();
            this.pnLateral.SuspendLayout();
            this.pnSubBotones.SuspendLayout();
            this.pnLatBotones.SuspendLayout();
            this.pnSubCxC.SuspendLayout();
            this.pnSubInventario.SuspendLayout();
            this.pnSubRestaurante.SuspendLayout();
            this.pnContenedorLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSuperior
            // 
            this.pnSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnSuperior.Controls.Add(this.lblUsuario);
            this.pnSuperior.Controls.Add(this.ptbUsuario);
            this.pnSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnSuperior.Name = "pnSuperior";
            this.pnSuperior.Size = new System.Drawing.Size(1126, 52);
            this.pnSuperior.TabIndex = 2;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(56, 15);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(64, 20);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            // 
            // ptbUsuario
            // 
            this.ptbUsuario.Image = global::VistaMadrid.Properties.Resources.usericon;
            this.ptbUsuario.Location = new System.Drawing.Point(12, 10);
            this.ptbUsuario.Name = "ptbUsuario";
            this.ptbUsuario.Size = new System.Drawing.Size(38, 34);
            this.ptbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbUsuario.TabIndex = 0;
            this.ptbUsuario.TabStop = false;
            // 
            // pnSeparador
            // 
            this.pnSeparador.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnSeparador.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSeparador.Location = new System.Drawing.Point(0, 52);
            this.pnSeparador.Name = "pnSeparador";
            this.pnSeparador.Size = new System.Drawing.Size(1126, 4);
            this.pnSeparador.TabIndex = 3;
            // 
            // pnLateral
            // 
            this.pnLateral.Controls.Add(this.pnContenedorLateral);
            this.pnLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLateral.Location = new System.Drawing.Point(0, 56);
            this.pnLateral.Name = "pnLateral";
            this.pnLateral.Size = new System.Drawing.Size(162, 650);
            this.pnLateral.TabIndex = 4;
            // 
            // pnSubBotones
            // 
            this.pnSubBotones.AutoScroll = true;
            this.pnSubBotones.Controls.Add(this.btnFacturacion);
            this.pnSubBotones.Controls.Add(this.btnEmpleados);
            this.pnSubBotones.Controls.Add(this.btnMesas);
            this.pnSubBotones.Controls.Add(this.btnDeudaCliente);
            this.pnSubBotones.Controls.Add(this.btnCuentasVencidas);
            this.pnSubBotones.Controls.Add(this.btnEstadoCuenta);
            this.pnSubBotones.Controls.Add(this.btnCuentasPorCobrar);
            this.pnSubBotones.Controls.Add(this.btnRegistroPago);
            this.pnSubBotones.Controls.Add(this.btnMetodosPago);
            this.pnSubBotones.Controls.Add(this.btnCondicionesPago);
            this.pnSubBotones.Controls.Add(this.btnClientes);
            this.pnSubBotones.Controls.Add(this.btnEntradasYSalidas);
            this.pnSubBotones.Controls.Add(this.btnStockActual);
            this.pnSubBotones.Controls.Add(this.btnMovimiento);
            this.pnSubBotones.Controls.Add(this.btnTiposMovimiento);
            this.pnSubBotones.Controls.Add(this.btnProveedores);
            this.pnSubBotones.Controls.Add(this.btnUnidadesMedida);
            this.pnSubBotones.Controls.Add(this.btnCategorias);
            this.pnSubBotones.Controls.Add(this.btnProductos);
            this.pnSubBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSubBotones.Location = new System.Drawing.Point(0, 0);
            this.pnSubBotones.Name = "pnSubBotones";
            this.pnSubBotones.Size = new System.Drawing.Size(144, 206);
            this.pnSubBotones.TabIndex = 6;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.CausesValidation = false;
            this.btnEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEmpleados.Location = new System.Drawing.Point(0, 682);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(123, 40);
            this.btnEmpleados.TabIndex = 29;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Visible = false;
            // 
            // btnMesas
            // 
            this.btnMesas.CausesValidation = false;
            this.btnMesas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMesas.FlatAppearance.BorderSize = 0;
            this.btnMesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesas.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMesas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMesas.Location = new System.Drawing.Point(0, 640);
            this.btnMesas.Name = "btnMesas";
            this.btnMesas.Size = new System.Drawing.Size(123, 42);
            this.btnMesas.TabIndex = 30;
            this.btnMesas.Text = "Mesas";
            this.btnMesas.UseVisualStyleBackColor = true;
            this.btnMesas.Visible = false;
            // 
            // btnDeudaCliente
            // 
            this.btnDeudaCliente.CausesValidation = false;
            this.btnDeudaCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeudaCliente.FlatAppearance.BorderSize = 0;
            this.btnDeudaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeudaCliente.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeudaCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeudaCliente.Location = new System.Drawing.Point(0, 600);
            this.btnDeudaCliente.Name = "btnDeudaCliente";
            this.btnDeudaCliente.Size = new System.Drawing.Size(123, 40);
            this.btnDeudaCliente.TabIndex = 27;
            this.btnDeudaCliente.Text = "Deuda por Cliente";
            this.btnDeudaCliente.UseVisualStyleBackColor = true;
            this.btnDeudaCliente.Visible = false;
            // 
            // btnCuentasVencidas
            // 
            this.btnCuentasVencidas.AutoEllipsis = true;
            this.btnCuentasVencidas.CausesValidation = false;
            this.btnCuentasVencidas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCuentasVencidas.FlatAppearance.BorderSize = 0;
            this.btnCuentasVencidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuentasVencidas.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuentasVencidas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCuentasVencidas.Location = new System.Drawing.Point(0, 560);
            this.btnCuentasVencidas.Name = "btnCuentasVencidas";
            this.btnCuentasVencidas.Size = new System.Drawing.Size(123, 40);
            this.btnCuentasVencidas.TabIndex = 26;
            this.btnCuentasVencidas.Text = "Cuentas Vencidas";
            this.btnCuentasVencidas.UseVisualStyleBackColor = true;
            this.btnCuentasVencidas.Visible = false;
            // 
            // btnEstadoCuenta
            // 
            this.btnEstadoCuenta.AutoEllipsis = true;
            this.btnEstadoCuenta.CausesValidation = false;
            this.btnEstadoCuenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstadoCuenta.FlatAppearance.BorderSize = 0;
            this.btnEstadoCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadoCuenta.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadoCuenta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEstadoCuenta.Location = new System.Drawing.Point(0, 520);
            this.btnEstadoCuenta.Name = "btnEstadoCuenta";
            this.btnEstadoCuenta.Size = new System.Drawing.Size(123, 40);
            this.btnEstadoCuenta.TabIndex = 25;
            this.btnEstadoCuenta.Text = "Estado de Cuenta";
            this.btnEstadoCuenta.UseVisualStyleBackColor = true;
            this.btnEstadoCuenta.Visible = false;
            // 
            // btnCuentasPorCobrar
            // 
            this.btnCuentasPorCobrar.AutoEllipsis = true;
            this.btnCuentasPorCobrar.CausesValidation = false;
            this.btnCuentasPorCobrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCuentasPorCobrar.FlatAppearance.BorderSize = 0;
            this.btnCuentasPorCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuentasPorCobrar.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuentasPorCobrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCuentasPorCobrar.Location = new System.Drawing.Point(0, 480);
            this.btnCuentasPorCobrar.Name = "btnCuentasPorCobrar";
            this.btnCuentasPorCobrar.Size = new System.Drawing.Size(123, 40);
            this.btnCuentasPorCobrar.TabIndex = 24;
            this.btnCuentasPorCobrar.Text = "Cuentas por Cobrar";
            this.btnCuentasPorCobrar.UseVisualStyleBackColor = true;
            this.btnCuentasPorCobrar.Visible = false;
            // 
            // btnRegistroPago
            // 
            this.btnRegistroPago.CausesValidation = false;
            this.btnRegistroPago.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistroPago.FlatAppearance.BorderSize = 0;
            this.btnRegistroPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroPago.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroPago.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRegistroPago.Location = new System.Drawing.Point(0, 440);
            this.btnRegistroPago.Name = "btnRegistroPago";
            this.btnRegistroPago.Size = new System.Drawing.Size(123, 40);
            this.btnRegistroPago.TabIndex = 23;
            this.btnRegistroPago.Text = "Registro de Pago";
            this.btnRegistroPago.UseVisualStyleBackColor = true;
            this.btnRegistroPago.Visible = false;
            // 
            // btnMetodosPago
            // 
            this.btnMetodosPago.AutoEllipsis = true;
            this.btnMetodosPago.CausesValidation = false;
            this.btnMetodosPago.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMetodosPago.FlatAppearance.BorderSize = 0;
            this.btnMetodosPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMetodosPago.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMetodosPago.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMetodosPago.Location = new System.Drawing.Point(0, 400);
            this.btnMetodosPago.Name = "btnMetodosPago";
            this.btnMetodosPago.Size = new System.Drawing.Size(123, 40);
            this.btnMetodosPago.TabIndex = 22;
            this.btnMetodosPago.Text = "Metodos de Pago";
            this.btnMetodosPago.UseVisualStyleBackColor = true;
            this.btnMetodosPago.Visible = false;
            // 
            // btnCondicionesPago
            // 
            this.btnCondicionesPago.AutoEllipsis = true;
            this.btnCondicionesPago.CausesValidation = false;
            this.btnCondicionesPago.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCondicionesPago.FlatAppearance.BorderSize = 0;
            this.btnCondicionesPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCondicionesPago.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCondicionesPago.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCondicionesPago.Location = new System.Drawing.Point(0, 360);
            this.btnCondicionesPago.Name = "btnCondicionesPago";
            this.btnCondicionesPago.Size = new System.Drawing.Size(123, 40);
            this.btnCondicionesPago.TabIndex = 21;
            this.btnCondicionesPago.Text = "Condiciones de Pago";
            this.btnCondicionesPago.UseVisualStyleBackColor = true;
            this.btnCondicionesPago.Visible = false;
            // 
            // btnClientes
            // 
            this.btnClientes.CausesValidation = false;
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClientes.Location = new System.Drawing.Point(0, 320);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(123, 40);
            this.btnClientes.TabIndex = 20;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Visible = false;
            // 
            // btnEntradasYSalidas
            // 
            this.btnEntradasYSalidas.AutoEllipsis = true;
            this.btnEntradasYSalidas.CausesValidation = false;
            this.btnEntradasYSalidas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEntradasYSalidas.FlatAppearance.BorderSize = 0;
            this.btnEntradasYSalidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntradasYSalidas.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntradasYSalidas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEntradasYSalidas.Location = new System.Drawing.Point(0, 280);
            this.btnEntradasYSalidas.Name = "btnEntradasYSalidas";
            this.btnEntradasYSalidas.Size = new System.Drawing.Size(123, 40);
            this.btnEntradasYSalidas.TabIndex = 19;
            this.btnEntradasYSalidas.Text = "Entradas y Salidas";
            this.btnEntradasYSalidas.UseVisualStyleBackColor = true;
            this.btnEntradasYSalidas.Visible = false;
            // 
            // btnStockActual
            // 
            this.btnStockActual.CausesValidation = false;
            this.btnStockActual.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStockActual.FlatAppearance.BorderSize = 0;
            this.btnStockActual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockActual.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockActual.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStockActual.Location = new System.Drawing.Point(0, 240);
            this.btnStockActual.Name = "btnStockActual";
            this.btnStockActual.Size = new System.Drawing.Size(123, 40);
            this.btnStockActual.TabIndex = 18;
            this.btnStockActual.Text = "Stock Actual";
            this.btnStockActual.UseVisualStyleBackColor = true;
            this.btnStockActual.Visible = false;
            // 
            // btnMovimiento
            // 
            this.btnMovimiento.CausesValidation = false;
            this.btnMovimiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMovimiento.FlatAppearance.BorderSize = 0;
            this.btnMovimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovimiento.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovimiento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMovimiento.Location = new System.Drawing.Point(0, 200);
            this.btnMovimiento.Name = "btnMovimiento";
            this.btnMovimiento.Size = new System.Drawing.Size(123, 40);
            this.btnMovimiento.TabIndex = 17;
            this.btnMovimiento.Text = "Movimiento";
            this.btnMovimiento.UseVisualStyleBackColor = true;
            this.btnMovimiento.Visible = false;
            // 
            // btnTiposMovimiento
            // 
            this.btnTiposMovimiento.AutoEllipsis = true;
            this.btnTiposMovimiento.CausesValidation = false;
            this.btnTiposMovimiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTiposMovimiento.FlatAppearance.BorderSize = 0;
            this.btnTiposMovimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTiposMovimiento.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiposMovimiento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTiposMovimiento.Location = new System.Drawing.Point(0, 160);
            this.btnTiposMovimiento.Name = "btnTiposMovimiento";
            this.btnTiposMovimiento.Size = new System.Drawing.Size(123, 40);
            this.btnTiposMovimiento.TabIndex = 16;
            this.btnTiposMovimiento.Text = "Tipos de Movimientos";
            this.btnTiposMovimiento.UseVisualStyleBackColor = true;
            this.btnTiposMovimiento.Visible = false;
            // 
            // btnProveedores
            // 
            this.btnProveedores.CausesValidation = false;
            this.btnProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnProveedores.Location = new System.Drawing.Point(0, 120);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(123, 40);
            this.btnProveedores.TabIndex = 15;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Visible = false;
            // 
            // btnUnidadesMedida
            // 
            this.btnUnidadesMedida.AutoEllipsis = true;
            this.btnUnidadesMedida.CausesValidation = false;
            this.btnUnidadesMedida.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUnidadesMedida.FlatAppearance.BorderSize = 0;
            this.btnUnidadesMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnidadesMedida.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnidadesMedida.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUnidadesMedida.Location = new System.Drawing.Point(0, 80);
            this.btnUnidadesMedida.Name = "btnUnidadesMedida";
            this.btnUnidadesMedida.Size = new System.Drawing.Size(123, 40);
            this.btnUnidadesMedida.TabIndex = 14;
            this.btnUnidadesMedida.Text = "Unidades de Medida";
            this.btnUnidadesMedida.UseVisualStyleBackColor = true;
            this.btnUnidadesMedida.Visible = false;
            // 
            // btnCategorias
            // 
            this.btnCategorias.CausesValidation = false;
            this.btnCategorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategorias.FlatAppearance.BorderSize = 0;
            this.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorias.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCategorias.Location = new System.Drawing.Point(0, 40);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(123, 40);
            this.btnCategorias.TabIndex = 13;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Visible = false;
            // 
            // btnProductos
            // 
            this.btnProductos.CausesValidation = false;
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnProductos.Location = new System.Drawing.Point(0, 0);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(123, 40);
            this.btnProductos.TabIndex = 12;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Visible = false;
            // 
            // pnLatBotones
            // 
            this.pnLatBotones.AutoScroll = true;
            this.pnLatBotones.Controls.Add(this.pnSubCxC);
            this.pnLatBotones.Controls.Add(this.btnCxC);
            this.pnLatBotones.Controls.Add(this.pnSubInventario);
            this.pnLatBotones.Controls.Add(this.btnInventario);
            this.pnLatBotones.Controls.Add(this.pnSubRestaurante);
            this.pnLatBotones.Controls.Add(this.btnRestaurante);
            this.pnLatBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLatBotones.Location = new System.Drawing.Point(0, 216);
            this.pnLatBotones.Name = "pnLatBotones";
            this.pnLatBotones.Size = new System.Drawing.Size(144, 399);
            this.pnLatBotones.TabIndex = 5;
            // 
            // pnSubCxC
            // 
            this.pnSubCxC.Controls.Add(this.btnReportesCxC);
            this.pnSubCxC.Controls.Add(this.btnProcesosCxC);
            this.pnSubCxC.Controls.Add(this.btnMantenimientosCxC);
            this.pnSubCxC.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSubCxC.Location = new System.Drawing.Point(0, 320);
            this.pnSubCxC.Name = "pnSubCxC";
            this.pnSubCxC.Size = new System.Drawing.Size(123, 120);
            this.pnSubCxC.TabIndex = 0;
            // 
            // btnReportesCxC
            // 
            this.btnReportesCxC.CausesValidation = false;
            this.btnReportesCxC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportesCxC.FlatAppearance.BorderSize = 0;
            this.btnReportesCxC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportesCxC.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportesCxC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReportesCxC.Location = new System.Drawing.Point(0, 80);
            this.btnReportesCxC.Name = "btnReportesCxC";
            this.btnReportesCxC.Size = new System.Drawing.Size(123, 40);
            this.btnReportesCxC.TabIndex = 28;
            this.btnReportesCxC.Text = "Reportes";
            this.btnReportesCxC.UseVisualStyleBackColor = true;
            this.btnReportesCxC.Click += new System.EventHandler(this.btnReportesCxC_Click);
            // 
            // btnProcesosCxC
            // 
            this.btnProcesosCxC.CausesValidation = false;
            this.btnProcesosCxC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProcesosCxC.FlatAppearance.BorderSize = 0;
            this.btnProcesosCxC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesosCxC.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesosCxC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnProcesosCxC.Location = new System.Drawing.Point(0, 40);
            this.btnProcesosCxC.Name = "btnProcesosCxC";
            this.btnProcesosCxC.Size = new System.Drawing.Size(123, 40);
            this.btnProcesosCxC.TabIndex = 27;
            this.btnProcesosCxC.Text = "Procesos";
            this.btnProcesosCxC.UseVisualStyleBackColor = true;
            this.btnProcesosCxC.Click += new System.EventHandler(this.btnProcesosCxC_Click);
            // 
            // btnMantenimientosCxC
            // 
            this.btnMantenimientosCxC.CausesValidation = false;
            this.btnMantenimientosCxC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMantenimientosCxC.FlatAppearance.BorderSize = 0;
            this.btnMantenimientosCxC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantenimientosCxC.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenimientosCxC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMantenimientosCxC.Location = new System.Drawing.Point(0, 0);
            this.btnMantenimientosCxC.Name = "btnMantenimientosCxC";
            this.btnMantenimientosCxC.Size = new System.Drawing.Size(123, 40);
            this.btnMantenimientosCxC.TabIndex = 26;
            this.btnMantenimientosCxC.Text = "Mantenimientos";
            this.btnMantenimientosCxC.UseVisualStyleBackColor = true;
            this.btnMantenimientosCxC.Click += new System.EventHandler(this.btnMantenimientosCxC_Click);
            // 
            // btnCxC
            // 
            this.btnCxC.CausesValidation = false;
            this.btnCxC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCxC.FlatAppearance.BorderSize = 0;
            this.btnCxC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCxC.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCxC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCxC.Location = new System.Drawing.Point(0, 280);
            this.btnCxC.Name = "btnCxC";
            this.btnCxC.Size = new System.Drawing.Size(123, 40);
            this.btnCxC.TabIndex = 10;
            this.btnCxC.Text = "CxC";
            this.btnCxC.UseVisualStyleBackColor = true;
            // 
            // pnSubInventario
            // 
            this.pnSubInventario.Controls.Add(this.btnReportesInventario);
            this.pnSubInventario.Controls.Add(this.btnProcesosInventario);
            this.pnSubInventario.Controls.Add(this.btnMantenimientosInventario);
            this.pnSubInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSubInventario.Location = new System.Drawing.Point(0, 160);
            this.pnSubInventario.Name = "pnSubInventario";
            this.pnSubInventario.Size = new System.Drawing.Size(123, 120);
            this.pnSubInventario.TabIndex = 24;
            // 
            // btnReportesInventario
            // 
            this.btnReportesInventario.CausesValidation = false;
            this.btnReportesInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportesInventario.FlatAppearance.BorderSize = 0;
            this.btnReportesInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportesInventario.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportesInventario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReportesInventario.Location = new System.Drawing.Point(0, 80);
            this.btnReportesInventario.Name = "btnReportesInventario";
            this.btnReportesInventario.Size = new System.Drawing.Size(123, 40);
            this.btnReportesInventario.TabIndex = 25;
            this.btnReportesInventario.Text = "Reportes";
            this.btnReportesInventario.UseVisualStyleBackColor = true;
            this.btnReportesInventario.Click += new System.EventHandler(this.btnReportesInventario_Click);
            // 
            // btnProcesosInventario
            // 
            this.btnProcesosInventario.CausesValidation = false;
            this.btnProcesosInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProcesosInventario.FlatAppearance.BorderSize = 0;
            this.btnProcesosInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesosInventario.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesosInventario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnProcesosInventario.Location = new System.Drawing.Point(0, 40);
            this.btnProcesosInventario.Name = "btnProcesosInventario";
            this.btnProcesosInventario.Size = new System.Drawing.Size(123, 40);
            this.btnProcesosInventario.TabIndex = 24;
            this.btnProcesosInventario.Text = "Procesos";
            this.btnProcesosInventario.UseVisualStyleBackColor = true;
            this.btnProcesosInventario.Click += new System.EventHandler(this.btnProcesosInventario_Click);
            // 
            // btnMantenimientosInventario
            // 
            this.btnMantenimientosInventario.CausesValidation = false;
            this.btnMantenimientosInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMantenimientosInventario.FlatAppearance.BorderSize = 0;
            this.btnMantenimientosInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantenimientosInventario.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenimientosInventario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMantenimientosInventario.Location = new System.Drawing.Point(0, 0);
            this.btnMantenimientosInventario.Name = "btnMantenimientosInventario";
            this.btnMantenimientosInventario.Size = new System.Drawing.Size(123, 40);
            this.btnMantenimientosInventario.TabIndex = 23;
            this.btnMantenimientosInventario.Text = "Mantenimientos";
            this.btnMantenimientosInventario.UseVisualStyleBackColor = true;
            this.btnMantenimientosInventario.Click += new System.EventHandler(this.btnMantenimientosInventario_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.CausesValidation = false;
            this.btnInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInventario.Location = new System.Drawing.Point(0, 120);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(123, 40);
            this.btnInventario.TabIndex = 2;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = true;
            // 
            // pnSubRestaurante
            // 
            this.pnSubRestaurante.Controls.Add(this.btnProcesosRestaurante);
            this.pnSubRestaurante.Controls.Add(this.btnMantemimientosRestaurante);
            this.pnSubRestaurante.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSubRestaurante.Location = new System.Drawing.Point(0, 40);
            this.pnSubRestaurante.Name = "pnSubRestaurante";
            this.pnSubRestaurante.Size = new System.Drawing.Size(123, 80);
            this.pnSubRestaurante.TabIndex = 23;
            // 
            // btnProcesosRestaurante
            // 
            this.btnProcesosRestaurante.CausesValidation = false;
            this.btnProcesosRestaurante.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProcesosRestaurante.FlatAppearance.BorderSize = 0;
            this.btnProcesosRestaurante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesosRestaurante.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesosRestaurante.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnProcesosRestaurante.Location = new System.Drawing.Point(0, 40);
            this.btnProcesosRestaurante.Name = "btnProcesosRestaurante";
            this.btnProcesosRestaurante.Size = new System.Drawing.Size(123, 40);
            this.btnProcesosRestaurante.TabIndex = 22;
            this.btnProcesosRestaurante.Text = "Procesos";
            this.btnProcesosRestaurante.UseVisualStyleBackColor = true;
            this.btnProcesosRestaurante.Click += new System.EventHandler(this.btnProcesosRestaurante_Click);
            // 
            // btnMantemimientosRestaurante
            // 
            this.btnMantemimientosRestaurante.CausesValidation = false;
            this.btnMantemimientosRestaurante.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMantemimientosRestaurante.FlatAppearance.BorderSize = 0;
            this.btnMantemimientosRestaurante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantemimientosRestaurante.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantemimientosRestaurante.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMantemimientosRestaurante.Location = new System.Drawing.Point(0, 0);
            this.btnMantemimientosRestaurante.Name = "btnMantemimientosRestaurante";
            this.btnMantemimientosRestaurante.Size = new System.Drawing.Size(123, 40);
            this.btnMantemimientosRestaurante.TabIndex = 21;
            this.btnMantemimientosRestaurante.Text = "Mantenimientos";
            this.btnMantemimientosRestaurante.UseVisualStyleBackColor = true;
            this.btnMantemimientosRestaurante.Click += new System.EventHandler(this.btnMantemimientosRestaurante_Click);
            // 
            // btnRestaurante
            // 
            this.btnRestaurante.CausesValidation = false;
            this.btnRestaurante.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRestaurante.FlatAppearance.BorderSize = 0;
            this.btnRestaurante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurante.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurante.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRestaurante.Location = new System.Drawing.Point(0, 0);
            this.btnRestaurante.Name = "btnRestaurante";
            this.btnRestaurante.Size = new System.Drawing.Size(123, 40);
            this.btnRestaurante.TabIndex = 0;
            this.btnRestaurante.Text = "Restaurante";
            this.btnRestaurante.UseVisualStyleBackColor = true;
            // 
            // spLateral
            // 
            this.spLateral.BackColor = System.Drawing.SystemColors.ControlLight;
            this.spLateral.Location = new System.Drawing.Point(162, 56);
            this.spLateral.Name = "spLateral";
            this.spLateral.Size = new System.Drawing.Size(4, 650);
            this.spLateral.TabIndex = 5;
            this.spLateral.TabStop = false;
            this.spLateral.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.spLateral_SplitterMoved);
            // 
            // pnCentral
            // 
            this.pnCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCentral.Location = new System.Drawing.Point(166, 56);
            this.pnCentral.Name = "pnCentral";
            this.pnCentral.Size = new System.Drawing.Size(960, 650);
            this.pnCentral.TabIndex = 6;
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.CausesValidation = false;
            this.btnFacturacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFacturacion.FlatAppearance.BorderSize = 0;
            this.btnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturacion.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturacion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFacturacion.Location = new System.Drawing.Point(0, 722);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(123, 42);
            this.btnFacturacion.TabIndex = 31;
            this.btnFacturacion.Text = "Facturacion";
            this.btnFacturacion.UseVisualStyleBackColor = true;
            this.btnFacturacion.Visible = false;
            // 
            // pnContenedorLateral
            // 
            this.pnContenedorLateral.Controls.Add(this.pnLatBotones);
            this.pnContenedorLateral.Controls.Add(this.panel1);
            this.pnContenedorLateral.Controls.Add(this.pnSubBotones);
            this.pnContenedorLateral.Location = new System.Drawing.Point(9, 17);
            this.pnContenedorLateral.Name = "pnContenedorLateral";
            this.pnContenedorLateral.Size = new System.Drawing.Size(144, 616);
            this.pnContenedorLateral.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 10);
            this.panel1.TabIndex = 4;
            // 
            // frmPrincipal2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 706);
            this.Controls.Add(this.pnCentral);
            this.Controls.Add(this.spLateral);
            this.Controls.Add(this.pnLateral);
            this.Controls.Add(this.pnSeparador);
            this.Controls.Add(this.pnSuperior);
            this.MinimumSize = new System.Drawing.Size(840, 540);
            this.Name = "frmPrincipal2";
            this.Text = "frmPrincipal2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.frmPrincipal2_Resize);
            this.pnSuperior.ResumeLayout(false);
            this.pnSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUsuario)).EndInit();
            this.pnLateral.ResumeLayout(false);
            this.pnSubBotones.ResumeLayout(false);
            this.pnLatBotones.ResumeLayout(false);
            this.pnSubCxC.ResumeLayout(false);
            this.pnSubInventario.ResumeLayout(false);
            this.pnSubRestaurante.ResumeLayout(false);
            this.pnContenedorLateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnSuperior;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox ptbUsuario;
        private System.Windows.Forms.Panel pnSeparador;
        private System.Windows.Forms.Panel pnLateral;
        private System.Windows.Forms.Splitter spLateral;
        private System.Windows.Forms.Panel pnCentral;
        private System.Windows.Forms.Panel pnLatBotones;
        private System.Windows.Forms.Button btnCxC;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnRestaurante;
        private System.Windows.Forms.Panel pnSubBotones;
        private System.Windows.Forms.Button btnDeudaCliente;
        private System.Windows.Forms.Button btnCuentasVencidas;
        private System.Windows.Forms.Button btnEstadoCuenta;
        private System.Windows.Forms.Button btnCuentasPorCobrar;
        private System.Windows.Forms.Button btnRegistroPago;
        private System.Windows.Forms.Button btnMetodosPago;
        private System.Windows.Forms.Button btnCondicionesPago;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnEntradasYSalidas;
        private System.Windows.Forms.Button btnStockActual;
        private System.Windows.Forms.Button btnMovimiento;
        private System.Windows.Forms.Button btnTiposMovimiento;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnUnidadesMedida;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnMantemimientosRestaurante;
        private System.Windows.Forms.Panel pnSubInventario;
        private System.Windows.Forms.Panel pnSubRestaurante;
        private System.Windows.Forms.Button btnProcesosRestaurante;
        private System.Windows.Forms.Button btnReportesInventario;
        private System.Windows.Forms.Button btnProcesosInventario;
        private System.Windows.Forms.Button btnMantenimientosInventario;
        private System.Windows.Forms.Panel pnSubCxC;
        private System.Windows.Forms.Button btnReportesCxC;
        private System.Windows.Forms.Button btnProcesosCxC;
        private System.Windows.Forms.Button btnMantenimientosCxC;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnMesas;
        private System.Windows.Forms.Button btnFacturacion;
        private System.Windows.Forms.Panel pnContenedorLateral;
        private System.Windows.Forms.Panel panel1;
    }
}