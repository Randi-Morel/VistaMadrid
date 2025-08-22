namespace VistaMadrid.Vista.Mantenimientos.MetodoPago
{
    partial class frmMetodoPago
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
            this.pnInferior = new System.Windows.Forms.Panel();
            this.GRD = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBuscar = new ReaLTaiizor.Controls.ParrotButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TConsultaDescripcion = new System.Windows.Forms.TextBox();
            this.tblCentral = new System.Windows.Forms.TableLayoutPanel();
            this.pnEstado = new System.Windows.Forms.Panel();
            this.CHKActivo = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.TID_MetodoPago = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnDescripcion = new System.Windows.Forms.Panel();
            this.TDescripcion = new ReaLTaiizor.Controls.CyberRichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblMesa = new System.Windows.Forms.Label();
            this.pnInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRD)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tblCentral.SuspendLayout();
            this.pnEstado.SuspendLayout();
            this.panel6.SuspendLayout();
            this.pnDescripcion.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnInferior
            // 
            this.pnInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnInferior.Controls.Add(this.GRD);
            this.pnInferior.Controls.Add(this.tableLayoutPanel1);
            this.pnInferior.Controls.Add(this.tblCentral);
            this.pnInferior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnInferior.Location = new System.Drawing.Point(0, 70);
            this.pnInferior.Name = "pnInferior";
            this.pnInferior.Size = new System.Drawing.Size(1144, 683);
            this.pnInferior.TabIndex = 14;
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
            this.GRD.Location = new System.Drawing.Point(0, 281);
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
            this.GRD.Size = new System.Drawing.Size(1144, 402);
            this.GRD.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 276F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.btnBuscar, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TConsultaDescripcion, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 209);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.627119F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.54802F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.19774F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.627119F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1144, 72);
            this.tableLayoutPanel1.TabIndex = 66;
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
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnBuscar.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(42)))));
            this.btnBuscar.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnBuscar.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnBuscar.Location = new System.Drawing.Point(938, 36);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(165, 26);
            this.btnBuscar.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnBuscar.TabIndex = 62;
            this.btnBuscar.TextColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscar.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnBuscar.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.label11.Location = new System.Drawing.Point(3, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 58;
            this.label11.Text = "Buscar por:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.label4.Location = new System.Drawing.Point(142, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 23);
            this.label4.TabIndex = 61;
            this.label4.Text = "Descripción";
            // 
            // TConsultaDescripcion
            // 
            this.TConsultaDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TConsultaDescripcion.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TConsultaDescripcion.Location = new System.Drawing.Point(142, 36);
            this.TConsultaDescripcion.MaximumSize = new System.Drawing.Size(255, 27);
            this.TConsultaDescripcion.MinimumSize = new System.Drawing.Size(185, 27);
            this.TConsultaDescripcion.Name = "TConsultaDescripcion";
            this.TConsultaDescripcion.Size = new System.Drawing.Size(254, 27);
            this.TConsultaDescripcion.TabIndex = 59;
            // 
            // tblCentral
            // 
            this.tblCentral.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tblCentral.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tblCentral.ColumnCount = 3;
            this.tblCentral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.06655F));
            this.tblCentral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.69002F));
            this.tblCentral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.24343F));
            this.tblCentral.Controls.Add(this.pnEstado, 2, 0);
            this.tblCentral.Controls.Add(this.panel6, 0, 0);
            this.tblCentral.Controls.Add(this.pnDescripcion, 1, 0);
            this.tblCentral.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblCentral.Location = new System.Drawing.Point(0, 0);
            this.tblCentral.Name = "tblCentral";
            this.tblCentral.RowCount = 1;
            this.tblCentral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCentral.Size = new System.Drawing.Size(1144, 209);
            this.tblCentral.TabIndex = 67;
            // 
            // pnEstado
            // 
            this.pnEstado.Controls.Add(this.CHKActivo);
            this.pnEstado.Controls.Add(this.label6);
            this.pnEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnEstado.Location = new System.Drawing.Point(675, 5);
            this.pnEstado.Name = "pnEstado";
            this.pnEstado.Size = new System.Drawing.Size(464, 199);
            this.pnEstado.TabIndex = 51;
            // 
            // CHKActivo
            // 
            this.CHKActivo.AutoSize = true;
            this.CHKActivo.Checked = true;
            this.CHKActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHKActivo.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.CHKActivo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F);
            this.CHKActivo.Location = new System.Drawing.Point(17, 57);
            this.CHKActivo.Name = "CHKActivo";
            this.CHKActivo.Size = new System.Drawing.Size(82, 26);
            this.CHKActivo.TabIndex = 50;
            this.CHKActivo.Text = "Activo";
            this.CHKActivo.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.label6.Location = new System.Drawing.Point(13, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 23);
            this.label6.TabIndex = 36;
            this.label6.Text = "Estado";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.Controls.Add(this.TID_MetodoPago);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(5, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(244, 199);
            this.panel6.TabIndex = 2;
            // 
            // TID_MetodoPago
            // 
            this.TID_MetodoPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TID_MetodoPago.Enabled = false;
            this.TID_MetodoPago.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TID_MetodoPago.Location = new System.Drawing.Point(17, 57);
            this.TID_MetodoPago.Name = "TID_MetodoPago";
            this.TID_MetodoPago.ReadOnly = true;
            this.TID_MetodoPago.Size = new System.Drawing.Size(106, 27);
            this.TID_MetodoPago.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(13, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 23);
            this.label3.TabIndex = 52;
            this.label3.Text = "Id";
            // 
            // pnDescripcion
            // 
            this.pnDescripcion.Controls.Add(this.TDescripcion);
            this.pnDescripcion.Controls.Add(this.label7);
            this.pnDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDescripcion.Location = new System.Drawing.Point(257, 5);
            this.pnDescripcion.Name = "pnDescripcion";
            this.pnDescripcion.Size = new System.Drawing.Size(410, 199);
            this.pnDescripcion.TabIndex = 0;
            // 
            // TDescripcion
            // 
            this.TDescripcion.Alpha = 20;
            this.TDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.TDescripcion.Background_WidthPen = 1F;
            this.TDescripcion.BackgroundPen = true;
            this.TDescripcion.ColorBackground = System.Drawing.SystemColors.Window;
            this.TDescripcion.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(42)))));
            this.TDescripcion.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.TDescripcion.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.TDescripcion.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.TDescripcion.CyberRichTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.TDescripcion.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TDescripcion.ForeColor = System.Drawing.Color.Black;
            this.TDescripcion.Lighting = false;
            this.TDescripcion.LinearGradientPen = false;
            this.TDescripcion.Location = new System.Drawing.Point(17, 57);
            this.TDescripcion.Name = "TDescripcion";
            this.TDescripcion.PenWidth = 10;
            this.TDescripcion.RGB = false;
            this.TDescripcion.Rounding = true;
            this.TDescripcion.RoundingInt = 20;
            this.TDescripcion.Size = new System.Drawing.Size(255, 101);
            this.TDescripcion.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.TDescripcion.TabIndex = 51;
            this.TDescripcion.Tag = "Cyber";
            this.TDescripcion.TextButton = "";
            this.TDescripcion.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.TDescripcion.Timer_RGB = 300;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.label7.Location = new System.Drawing.Point(13, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 23);
            this.label7.TabIndex = 45;
            this.label7.Text = "Descripción*";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panel4.Controls.Add(this.lblMesa);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1144, 70);
            this.panel4.TabIndex = 16;
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.BackColor = System.Drawing.Color.Transparent;
            this.lblMesa.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.lblMesa.Location = new System.Drawing.Point(5, 10);
            this.lblMesa.Margin = new System.Windows.Forms.Padding(5);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(554, 40);
            this.lblMesa.TabIndex = 17;
            this.lblMesa.Text = "Mantenimiento de Método de Pago";
            // 
            // frmMetodoPago
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1144, 753);
            this.Controls.Add(this.pnInferior);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMetodoPago";
            this.Text = "frmMetodoPago";
            this.Resize += new System.EventHandler(this.frmMetodoPago_Resize);
            this.pnInferior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GRD)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tblCentral.ResumeLayout(false);
            this.pnEstado.ResumeLayout(false);
            this.pnEstado.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.pnDescripcion.ResumeLayout(false);
            this.pnDescripcion.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnInferior;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblMesa;
        internal ReaLTaiizor.Controls.PoisonDataGridView GRD;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        internal ReaLTaiizor.Controls.ParrotButton btnBuscar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox TConsultaDescripcion;
        private System.Windows.Forms.TableLayoutPanel tblCentral;
        private System.Windows.Forms.Panel pnEstado;
        internal System.Windows.Forms.CheckBox CHKActivo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        internal System.Windows.Forms.TextBox TID_MetodoPago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnDescripcion;
        internal ReaLTaiizor.Controls.CyberRichTextBox TDescripcion;
        private System.Windows.Forms.Label label7;
    }
}