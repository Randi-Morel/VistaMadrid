namespace VistaMadrid
{
    partial class frmPrincipal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.pnCentral = new System.Windows.Forms.Panel();
            this.pnLateral = new System.Windows.Forms.Panel();
            this.pnLatBotones = new System.Windows.Forms.Panel();
            this.pnSubCxC = new System.Windows.Forms.Panel();
            this.btnDeudaCliente = new System.Windows.Forms.Button();
            this.btnCuentasVencidas = new System.Windows.Forms.Button();
            this.btnEstadoCuenta = new System.Windows.Forms.Button();
            this.btnCuentasPorCobrar = new System.Windows.Forms.Button();
            this.btnRegistroPago = new System.Windows.Forms.Button();
            this.btnMetodosPago = new System.Windows.Forms.Button();
            this.btnCondicionesPago = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnCxC = new System.Windows.Forms.Button();
            this.pnSubInventario = new System.Windows.Forms.Panel();
            this.btnEntradasYSalidas = new System.Windows.Forms.Button();
            this.btnStockActual = new System.Windows.Forms.Button();
            this.btnMovimiento = new System.Windows.Forms.Button();
            this.btnTiposMovimiento = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnUnidadesMedida = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.pnSubRestaurante = new System.Windows.Forms.Panel();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnMesas = new System.Windows.Forms.Button();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.btnRestaurante = new System.Windows.Forms.Button();
            this.pnSuperior = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.ptbUsuario = new System.Windows.Forms.PictureBox();
            this.tlpPrincipal.SuspendLayout();
            this.pnLateral.SuspendLayout();
            this.pnLatBotones.SuspendLayout();
            this.pnSubCxC.SuspendLayout();
            this.pnSubInventario.SuspendLayout();
            this.pnSubRestaurante.SuspendLayout();
            this.pnSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.BackColor = System.Drawing.Color.Gainsboro;
            this.tlpPrincipal.ColumnCount = 2;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tlpPrincipal.Controls.Add(this.pnCentral, 1, 0);
            this.tlpPrincipal.Controls.Add(this.pnLateral, 0, 0);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 52);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 1;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.90909F));
            this.tlpPrincipal.Size = new System.Drawing.Size(1126, 654);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // pnCentral
            // 
            this.pnCentral.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCentral.Location = new System.Drawing.Point(171, 3);
            this.pnCentral.Name = "pnCentral";
            this.pnCentral.Size = new System.Drawing.Size(952, 648);
            this.pnCentral.TabIndex = 1;
            // 
            // pnLateral
            // 
            this.pnLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnLateral.Controls.Add(this.pnLatBotones);
            this.pnLateral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLateral.Location = new System.Drawing.Point(3, 3);
            this.pnLateral.Name = "pnLateral";
            this.pnLateral.Size = new System.Drawing.Size(162, 648);
            this.pnLateral.TabIndex = 2;
            // 
            // pnLatBotones
            // 
            this.pnLatBotones.Controls.Add(this.pnSubCxC);
            this.pnLatBotones.Controls.Add(this.btnCxC);
            this.pnLatBotones.Controls.Add(this.pnSubInventario);
            this.pnLatBotones.Controls.Add(this.btnInventario);
            this.pnLatBotones.Controls.Add(this.pnSubRestaurante);
            this.pnLatBotones.Controls.Add(this.btnRestaurante);
            this.pnLatBotones.Location = new System.Drawing.Point(9, 17);
            this.pnLatBotones.Name = "pnLatBotones";
            this.pnLatBotones.Size = new System.Drawing.Size(144, 622);
            this.pnLatBotones.TabIndex = 4;
            // 
            // pnSubCxC
            // 
            this.pnSubCxC.AutoScroll = true;
            this.pnSubCxC.Controls.Add(this.btnDeudaCliente);
            this.pnSubCxC.Controls.Add(this.btnCuentasVencidas);
            this.pnSubCxC.Controls.Add(this.btnEstadoCuenta);
            this.pnSubCxC.Controls.Add(this.btnCuentasPorCobrar);
            this.pnSubCxC.Controls.Add(this.btnRegistroPago);
            this.pnSubCxC.Controls.Add(this.btnMetodosPago);
            this.pnSubCxC.Controls.Add(this.btnCondicionesPago);
            this.pnSubCxC.Controls.Add(this.btnClientes);
            this.pnSubCxC.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSubCxC.Location = new System.Drawing.Point(0, 364);
            this.pnSubCxC.Name = "pnSubCxC";
            this.pnSubCxC.Size = new System.Drawing.Size(144, 122);
            this.pnSubCxC.TabIndex = 11;
            this.pnSubCxC.Visible = false;
            // 
            // btnDeudaCliente
            // 
            this.btnDeudaCliente.CausesValidation = false;
            this.btnDeudaCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeudaCliente.FlatAppearance.BorderSize = 0;
            this.btnDeudaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeudaCliente.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeudaCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeudaCliente.Location = new System.Drawing.Point(0, 280);
            this.btnDeudaCliente.Name = "btnDeudaCliente";
            this.btnDeudaCliente.Size = new System.Drawing.Size(123, 40);
            this.btnDeudaCliente.TabIndex = 11;
            this.btnDeudaCliente.Text = "Deuda por Cliente";
            this.btnDeudaCliente.UseVisualStyleBackColor = true;
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
            this.btnCuentasVencidas.Location = new System.Drawing.Point(0, 240);
            this.btnCuentasVencidas.Name = "btnCuentasVencidas";
            this.btnCuentasVencidas.Size = new System.Drawing.Size(123, 40);
            this.btnCuentasVencidas.TabIndex = 10;
            this.btnCuentasVencidas.Text = "Cuentas Vencidas";
            this.btnCuentasVencidas.UseVisualStyleBackColor = true;
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
            this.btnEstadoCuenta.Location = new System.Drawing.Point(0, 200);
            this.btnEstadoCuenta.Name = "btnEstadoCuenta";
            this.btnEstadoCuenta.Size = new System.Drawing.Size(123, 40);
            this.btnEstadoCuenta.TabIndex = 9;
            this.btnEstadoCuenta.Text = "Estado de Cuenta";
            this.btnEstadoCuenta.UseVisualStyleBackColor = true;
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
            this.btnCuentasPorCobrar.Location = new System.Drawing.Point(0, 160);
            this.btnCuentasPorCobrar.Name = "btnCuentasPorCobrar";
            this.btnCuentasPorCobrar.Size = new System.Drawing.Size(123, 40);
            this.btnCuentasPorCobrar.TabIndex = 8;
            this.btnCuentasPorCobrar.Text = "Cuentas por Cobrar";
            this.btnCuentasPorCobrar.UseVisualStyleBackColor = true;
            // 
            // btnRegistroPago
            // 
            this.btnRegistroPago.CausesValidation = false;
            this.btnRegistroPago.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistroPago.FlatAppearance.BorderSize = 0;
            this.btnRegistroPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroPago.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroPago.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRegistroPago.Location = new System.Drawing.Point(0, 120);
            this.btnRegistroPago.Name = "btnRegistroPago";
            this.btnRegistroPago.Size = new System.Drawing.Size(123, 40);
            this.btnRegistroPago.TabIndex = 7;
            this.btnRegistroPago.Text = "Registro de Pago";
            this.btnRegistroPago.UseVisualStyleBackColor = true;
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
            this.btnMetodosPago.Location = new System.Drawing.Point(0, 80);
            this.btnMetodosPago.Name = "btnMetodosPago";
            this.btnMetodosPago.Size = new System.Drawing.Size(123, 40);
            this.btnMetodosPago.TabIndex = 6;
            this.btnMetodosPago.Text = "Metodos de Pago";
            this.btnMetodosPago.UseVisualStyleBackColor = true;
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
            this.btnCondicionesPago.Location = new System.Drawing.Point(0, 40);
            this.btnCondicionesPago.Name = "btnCondicionesPago";
            this.btnCondicionesPago.Size = new System.Drawing.Size(123, 40);
            this.btnCondicionesPago.TabIndex = 5;
            this.btnCondicionesPago.Text = "Condiciones de Pago";
            this.btnCondicionesPago.UseVisualStyleBackColor = true;
            // 
            // btnClientes
            // 
            this.btnClientes.CausesValidation = false;
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClientes.Location = new System.Drawing.Point(0, 0);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(123, 40);
            this.btnClientes.TabIndex = 4;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            // 
            // btnCxC
            // 
            this.btnCxC.CausesValidation = false;
            this.btnCxC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCxC.FlatAppearance.BorderSize = 0;
            this.btnCxC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCxC.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCxC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCxC.Location = new System.Drawing.Point(0, 324);
            this.btnCxC.Name = "btnCxC";
            this.btnCxC.Size = new System.Drawing.Size(144, 40);
            this.btnCxC.TabIndex = 10;
            this.btnCxC.Text = "CxC";
            this.btnCxC.UseVisualStyleBackColor = true;
            this.btnCxC.Click += new System.EventHandler(this.btnCxC_Click);
            // 
            // pnSubInventario
            // 
            this.pnSubInventario.AutoScroll = true;
            this.pnSubInventario.Controls.Add(this.btnEntradasYSalidas);
            this.pnSubInventario.Controls.Add(this.btnStockActual);
            this.pnSubInventario.Controls.Add(this.btnMovimiento);
            this.pnSubInventario.Controls.Add(this.btnTiposMovimiento);
            this.pnSubInventario.Controls.Add(this.btnProveedores);
            this.pnSubInventario.Controls.Add(this.btnUnidadesMedida);
            this.pnSubInventario.Controls.Add(this.btnCategorias);
            this.pnSubInventario.Controls.Add(this.btnProductos);
            this.pnSubInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSubInventario.Location = new System.Drawing.Point(0, 202);
            this.pnSubInventario.Name = "pnSubInventario";
            this.pnSubInventario.Size = new System.Drawing.Size(144, 122);
            this.pnSubInventario.TabIndex = 7;
            this.pnSubInventario.Visible = false;
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
            this.btnEntradasYSalidas.TabIndex = 11;
            this.btnEntradasYSalidas.Text = "Entradas y Salidas";
            this.btnEntradasYSalidas.UseVisualStyleBackColor = true;
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
            this.btnStockActual.TabIndex = 10;
            this.btnStockActual.Text = "Stock Actual";
            this.btnStockActual.UseVisualStyleBackColor = true;
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
            this.btnMovimiento.TabIndex = 9;
            this.btnMovimiento.Text = "Movimiento";
            this.btnMovimiento.UseVisualStyleBackColor = true;
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
            this.btnTiposMovimiento.TabIndex = 8;
            this.btnTiposMovimiento.Text = "Tipos de Movimientos";
            this.btnTiposMovimiento.UseVisualStyleBackColor = true;
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
            this.btnProveedores.TabIndex = 7;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = true;
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
            this.btnUnidadesMedida.TabIndex = 6;
            this.btnUnidadesMedida.Text = "Unidades de Medida";
            this.btnUnidadesMedida.UseVisualStyleBackColor = true;
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
            this.btnCategorias.TabIndex = 5;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.UseVisualStyleBackColor = true;
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
            this.btnProductos.TabIndex = 4;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            // 
            // btnInventario
            // 
            this.btnInventario.CausesValidation = false;
            this.btnInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInventario.Location = new System.Drawing.Point(0, 162);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(144, 40);
            this.btnInventario.TabIndex = 2;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // pnSubRestaurante
            // 
            this.pnSubRestaurante.Controls.Add(this.btnEmpleados);
            this.pnSubRestaurante.Controls.Add(this.btnMesas);
            this.pnSubRestaurante.Controls.Add(this.btnFacturacion);
            this.pnSubRestaurante.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSubRestaurante.Location = new System.Drawing.Point(0, 40);
            this.pnSubRestaurante.Name = "pnSubRestaurante";
            this.pnSubRestaurante.Size = new System.Drawing.Size(144, 122);
            this.pnSubRestaurante.TabIndex = 3;
            this.pnSubRestaurante.Visible = false;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.CausesValidation = false;
            this.btnEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEmpleados.Location = new System.Drawing.Point(0, 82);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(144, 40);
            this.btnEmpleados.TabIndex = 5;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            // 
            // btnMesas
            // 
            this.btnMesas.CausesValidation = false;
            this.btnMesas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMesas.FlatAppearance.BorderSize = 0;
            this.btnMesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesas.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMesas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMesas.Location = new System.Drawing.Point(0, 40);
            this.btnMesas.Name = "btnMesas";
            this.btnMesas.Size = new System.Drawing.Size(144, 42);
            this.btnMesas.TabIndex = 6;
            this.btnMesas.Text = "Mesas";
            this.btnMesas.UseVisualStyleBackColor = true;
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.CausesValidation = false;
            this.btnFacturacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFacturacion.FlatAppearance.BorderSize = 0;
            this.btnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturacion.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturacion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFacturacion.Location = new System.Drawing.Point(0, 0);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(144, 40);
            this.btnFacturacion.TabIndex = 4;
            this.btnFacturacion.Text = "Facturacion";
            this.btnFacturacion.UseVisualStyleBackColor = true;
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
            this.btnRestaurante.Size = new System.Drawing.Size(144, 40);
            this.btnRestaurante.TabIndex = 0;
            this.btnRestaurante.Text = "Restaurante";
            this.btnRestaurante.UseVisualStyleBackColor = true;
            this.btnRestaurante.Click += new System.EventHandler(this.btnRestaurante_Click);
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
            this.pnSuperior.TabIndex = 1;
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
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 706);
            this.Controls.Add(this.tlpPrincipal);
            this.Controls.Add(this.pnSuperior);
            this.MinimumSize = new System.Drawing.Size(840, 540);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.frmPrincipal_Resize);
            this.tlpPrincipal.ResumeLayout(false);
            this.pnLateral.ResumeLayout(false);
            this.pnLatBotones.ResumeLayout(false);
            this.pnSubCxC.ResumeLayout(false);
            this.pnSubInventario.ResumeLayout(false);
            this.pnSubRestaurante.ResumeLayout(false);
            this.pnSuperior.ResumeLayout(false);
            this.pnSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Panel pnCentral;
        private System.Windows.Forms.Panel pnSuperior;
        private System.Windows.Forms.PictureBox ptbUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Panel pnLateral;
        private System.Windows.Forms.Button btnRestaurante;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnCxC;
        private System.Windows.Forms.Panel pnSubRestaurante;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnFacturacion;
        private System.Windows.Forms.Button btnMesas;
        private System.Windows.Forms.Panel pnLatBotones;
        private System.Windows.Forms.Panel pnSubInventario;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnMovimiento;
        private System.Windows.Forms.Button btnTiposMovimiento;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnUnidadesMedida;
        private System.Windows.Forms.Button btnEntradasYSalidas;
        private System.Windows.Forms.Button btnStockActual;
        private System.Windows.Forms.Panel pnSubCxC;
        private System.Windows.Forms.Button btnDeudaCliente;
        private System.Windows.Forms.Button btnCuentasVencidas;
        private System.Windows.Forms.Button btnEstadoCuenta;
        private System.Windows.Forms.Button btnCuentasPorCobrar;
        private System.Windows.Forms.Button btnRegistroPago;
        private System.Windows.Forms.Button btnMetodosPago;
        private System.Windows.Forms.Button btnCondicionesPago;
        private System.Windows.Forms.Button btnClientes;
    }
}

