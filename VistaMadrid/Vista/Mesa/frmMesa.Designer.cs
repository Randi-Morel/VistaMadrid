namespace VistaMadrid.Vista.Mantenimientos.Mesa
{
    partial class frmMesa
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
            this.poisonDataGridView1 = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtConsultaSala = new System.Windows.Forms.TextBox();
            this.txtConsultaDescripcion = new System.Windows.Forms.TextBox();
            this.npConsultaAsientos = new System.Windows.Forms.NumericUpDown();
            this.tblCentral = new System.Windows.Forms.TableLayoutPanel();
            this.pnDescripcion = new System.Windows.Forms.Panel();
            this.txtDescripcion = new ReaLTaiizor.Controls.CyberRichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnSala = new System.Windows.Forms.Panel();
            this.cbSala = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnEstado = new System.Windows.Forms.Panel();
            this.rbInactivo = new ReaLTaiizor.Controls.FoxRadioButton();
            this.rbActivo = new ReaLTaiizor.Controls.FoxRadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.pnAsientos = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.nudDiasCredito = new System.Windows.Forms.NumericUpDown();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblMesa = new System.Windows.Forms.Label();
            this.pnInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poisonDataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npConsultaAsientos)).BeginInit();
            this.tblCentral.SuspendLayout();
            this.pnDescripcion.SuspendLayout();
            this.pnSala.SuspendLayout();
            this.pnEstado.SuspendLayout();
            this.pnAsientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiasCredito)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnInferior
            // 
            this.pnInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnInferior.Controls.Add(this.poisonDataGridView1);
            this.pnInferior.Controls.Add(this.tableLayoutPanel1);
            this.pnInferior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnInferior.Location = new System.Drawing.Point(0, 279);
            this.pnInferior.Name = "pnInferior";
            this.pnInferior.Size = new System.Drawing.Size(1144, 474);
            this.pnInferior.TabIndex = 11;
            // 
            // poisonDataGridView1
            // 
            this.poisonDataGridView1.AllowUserToDeleteRows = false;
            this.poisonDataGridView1.AllowUserToResizeRows = false;
            this.poisonDataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.poisonDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.poisonDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.poisonDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.poisonDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.poisonDataGridView1.ColumnHeadersHeight = 33;
            this.poisonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.poisonDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column6,
            this.Column8,
            this.Column9});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.poisonDataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.poisonDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.poisonDataGridView1.EnableHeadersVisualStyles = false;
            this.poisonDataGridView1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.poisonDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.poisonDataGridView1.Location = new System.Drawing.Point(0, 59);
            this.poisonDataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.poisonDataGridView1.Name = "poisonDataGridView1";
            this.poisonDataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.poisonDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.poisonDataGridView1.RowHeadersWidth = 45;
            this.poisonDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.poisonDataGridView1.RowTemplate.Height = 35;
            this.poisonDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.poisonDataGridView1.Size = new System.Drawing.Size(1144, 415);
            this.poisonDataGridView1.TabIndex = 56;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Column8";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Column9";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Controls.Add(this.label10, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtConsultaSala, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtConsultaDescripcion, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.npConsultaAsientos, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1144, 59);
            this.tableLayoutPanel1.TabIndex = 57;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.label10.Location = new System.Drawing.Point(718, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 23);
            this.label10.TabIndex = 57;
            this.label10.Text = "Asientos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(432, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 23);
            this.label3.TabIndex = 56;
            this.label3.Text = "Sala";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.label4.Location = new System.Drawing.Point(146, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 23);
            this.label4.TabIndex = 55;
            this.label4.Text = "Descripción";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 52;
            this.label9.Text = "Buscar por:";
            // 
            // txtConsultaSala
            // 
            this.txtConsultaSala.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsultaSala.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultaSala.Location = new System.Drawing.Point(432, 32);
            this.txtConsultaSala.MaximumSize = new System.Drawing.Size(255, 27);
            this.txtConsultaSala.MinimumSize = new System.Drawing.Size(185, 27);
            this.txtConsultaSala.Name = "txtConsultaSala";
            this.txtConsultaSala.Size = new System.Drawing.Size(255, 27);
            this.txtConsultaSala.TabIndex = 53;
            // 
            // txtConsultaDescripcion
            // 
            this.txtConsultaDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsultaDescripcion.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultaDescripcion.Location = new System.Drawing.Point(146, 32);
            this.txtConsultaDescripcion.MaximumSize = new System.Drawing.Size(255, 27);
            this.txtConsultaDescripcion.MinimumSize = new System.Drawing.Size(185, 27);
            this.txtConsultaDescripcion.Name = "txtConsultaDescripcion";
            this.txtConsultaDescripcion.Size = new System.Drawing.Size(255, 27);
            this.txtConsultaDescripcion.TabIndex = 34;
            // 
            // npConsultaAsientos
            // 
            this.npConsultaAsientos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.npConsultaAsientos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.npConsultaAsientos.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npConsultaAsientos.Location = new System.Drawing.Point(718, 32);
            this.npConsultaAsientos.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.npConsultaAsientos.MaximumSize = new System.Drawing.Size(120, 0);
            this.npConsultaAsientos.MinimumSize = new System.Drawing.Size(110, 0);
            this.npConsultaAsientos.Name = "npConsultaAsientos";
            this.npConsultaAsientos.Size = new System.Drawing.Size(120, 27);
            this.npConsultaAsientos.TabIndex = 58;
            // 
            // tblCentral
            // 
            this.tblCentral.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tblCentral.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tblCentral.ColumnCount = 4;
            this.tblCentral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblCentral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblCentral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblCentral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblCentral.Controls.Add(this.pnDescripcion, 0, 0);
            this.tblCentral.Controls.Add(this.pnSala, 1, 0);
            this.tblCentral.Controls.Add(this.pnEstado, 3, 0);
            this.tblCentral.Controls.Add(this.pnAsientos, 2, 0);
            this.tblCentral.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblCentral.Location = new System.Drawing.Point(0, 70);
            this.tblCentral.Name = "tblCentral";
            this.tblCentral.RowCount = 1;
            this.tblCentral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCentral.Size = new System.Drawing.Size(1144, 209);
            this.tblCentral.TabIndex = 12;
            // 
            // pnDescripcion
            // 
            this.pnDescripcion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnDescripcion.Controls.Add(this.txtDescripcion);
            this.pnDescripcion.Controls.Add(this.label7);
            this.pnDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDescripcion.Location = new System.Drawing.Point(5, 5);
            this.pnDescripcion.Name = "pnDescripcion";
            this.pnDescripcion.Size = new System.Drawing.Size(277, 199);
            this.pnDescripcion.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Alpha = 20;
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.txtDescripcion.Background_WidthPen = 1F;
            this.txtDescripcion.BackgroundPen = true;
            this.txtDescripcion.ColorBackground = System.Drawing.SystemColors.Window;
            this.txtDescripcion.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(42)))));
            this.txtDescripcion.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txtDescripcion.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txtDescripcion.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.txtDescripcion.CyberRichTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.Black;
            this.txtDescripcion.Lighting = false;
            this.txtDescripcion.LinearGradientPen = false;
            this.txtDescripcion.Location = new System.Drawing.Point(13, 61);
            this.txtDescripcion.MaximumSize = new System.Drawing.Size(255, 101);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PenWidth = 10;
            this.txtDescripcion.RGB = false;
            this.txtDescripcion.Rounding = true;
            this.txtDescripcion.RoundingInt = 20;
            this.txtDescripcion.Size = new System.Drawing.Size(255, 101);
            this.txtDescripcion.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.txtDescripcion.TabIndex = 51;
            this.txtDescripcion.Tag = "Cyber";
            this.txtDescripcion.TextButton = "";
            this.txtDescripcion.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.txtDescripcion.Timer_RGB = 300;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.label7.Location = new System.Drawing.Point(13, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 23);
            this.label7.TabIndex = 45;
            this.label7.Text = "Descripción";
            // 
            // pnSala
            // 
            this.pnSala.Controls.Add(this.cbSala);
            this.pnSala.Controls.Add(this.label1);
            this.pnSala.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSala.Location = new System.Drawing.Point(290, 5);
            this.pnSala.Name = "pnSala";
            this.pnSala.Size = new System.Drawing.Size(277, 199);
            this.pnSala.TabIndex = 1;
            // 
            // cbSala
            // 
            this.cbSala.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSala.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSala.FormattingEnabled = true;
            this.cbSala.Location = new System.Drawing.Point(13, 61);
            this.cbSala.MaximumSize = new System.Drawing.Size(255, 0);
            this.cbSala.Name = "cbSala";
            this.cbSala.Size = new System.Drawing.Size(255, 28);
            this.cbSala.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 23);
            this.label1.TabIndex = 52;
            this.label1.Text = "Sala";
            // 
            // pnEstado
            // 
            this.pnEstado.Controls.Add(this.rbInactivo);
            this.pnEstado.Controls.Add(this.rbActivo);
            this.pnEstado.Controls.Add(this.label6);
            this.pnEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnEstado.Location = new System.Drawing.Point(860, 5);
            this.pnEstado.Name = "pnEstado";
            this.pnEstado.Size = new System.Drawing.Size(279, 199);
            this.pnEstado.TabIndex = 1;
            // 
            // rbInactivo
            // 
            this.rbInactivo.BackColor = System.Drawing.Color.Transparent;
            this.rbInactivo.BorderColor = System.Drawing.Color.DarkGray;
            this.rbInactivo.Checked = false;
            this.rbInactivo.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(42)))));
            this.rbInactivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbInactivo.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.rbInactivo.DisabledCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.rbInactivo.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(178)))), ((int)(((byte)(190)))));
            this.rbInactivo.EnabledCalc = true;
            this.rbInactivo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInactivo.ForeColor = System.Drawing.Color.Black;
            this.rbInactivo.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.rbInactivo.Location = new System.Drawing.Point(123, 61);
            this.rbInactivo.Name = "rbInactivo";
            this.rbInactivo.Size = new System.Drawing.Size(106, 27);
            this.rbInactivo.TabIndex = 50;
            this.rbInactivo.Text = "Inactivo";
            // 
            // rbActivo
            // 
            this.rbActivo.BackColor = System.Drawing.Color.Transparent;
            this.rbActivo.BorderColor = System.Drawing.Color.DarkGray;
            this.rbActivo.Checked = false;
            this.rbActivo.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(42)))));
            this.rbActivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbActivo.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.rbActivo.DisabledCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.rbActivo.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(178)))), ((int)(((byte)(190)))));
            this.rbActivo.EnabledCalc = true;
            this.rbActivo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbActivo.ForeColor = System.Drawing.Color.Black;
            this.rbActivo.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.rbActivo.Location = new System.Drawing.Point(13, 61);
            this.rbActivo.Name = "rbActivo";
            this.rbActivo.Size = new System.Drawing.Size(89, 27);
            this.rbActivo.TabIndex = 49;
            this.rbActivo.Text = "Activo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.label6.Location = new System.Drawing.Point(13, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 23);
            this.label6.TabIndex = 36;
            this.label6.Text = "Estado";
            // 
            // pnAsientos
            // 
            this.pnAsientos.Controls.Add(this.label2);
            this.pnAsientos.Controls.Add(this.nudDiasCredito);
            this.pnAsientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnAsientos.Location = new System.Drawing.Point(575, 5);
            this.pnAsientos.Name = "pnAsientos";
            this.pnAsientos.Size = new System.Drawing.Size(277, 199);
            this.pnAsientos.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(13, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 56;
            this.label2.Text = "Asientos";
            // 
            // nudDiasCredito
            // 
            this.nudDiasCredito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudDiasCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudDiasCredito.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDiasCredito.Location = new System.Drawing.Point(13, 61);
            this.nudDiasCredito.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nudDiasCredito.MaximumSize = new System.Drawing.Size(120, 0);
            this.nudDiasCredito.MinimumSize = new System.Drawing.Size(110, 0);
            this.nudDiasCredito.Name = "nudDiasCredito";
            this.nudDiasCredito.Size = new System.Drawing.Size(120, 27);
            this.nudDiasCredito.TabIndex = 55;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panel4.Controls.Add(this.lblMesa);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1144, 70);
            this.panel4.TabIndex = 13;
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
            this.lblMesa.Size = new System.Drawing.Size(382, 40);
            this.lblMesa.TabIndex = 17;
            this.lblMesa.Text = "Mantenimiento de Mesa";
            // 
            // frmMesa
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1144, 753);
            this.Controls.Add(this.pnInferior);
            this.Controls.Add(this.tblCentral);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMesa";
            this.Text = "frmMesa";
            this.Resize += new System.EventHandler(this.frmMesa_Resize);
            this.pnInferior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.poisonDataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npConsultaAsientos)).EndInit();
            this.tblCentral.ResumeLayout(false);
            this.pnDescripcion.ResumeLayout(false);
            this.pnDescripcion.PerformLayout();
            this.pnSala.ResumeLayout(false);
            this.pnSala.PerformLayout();
            this.pnEstado.ResumeLayout(false);
            this.pnEstado.PerformLayout();
            this.pnAsientos.ResumeLayout(false);
            this.pnAsientos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiasCredito)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnInferior;
        private System.Windows.Forms.TableLayoutPanel tblCentral;
        private System.Windows.Forms.Panel pnDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudDiasCredito;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.CyberRichTextBox txtDescripcion;
        private ReaLTaiizor.Controls.FoxRadioButton rbInactivo;
        private ReaLTaiizor.Controls.FoxRadioButton rbActivo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblMesa;
        private System.Windows.Forms.ComboBox cbSala;
        private System.Windows.Forms.Panel pnSala;
        private System.Windows.Forms.Panel pnAsientos;
        private System.Windows.Forms.Panel pnEstado;
        private ReaLTaiizor.Controls.PoisonDataGridView poisonDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column8;
        private System.Windows.Forms.DataGridViewImageColumn Column9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtConsultaSala;
        private System.Windows.Forms.TextBox txtConsultaDescripcion;
        private System.Windows.Forms.NumericUpDown npConsultaAsientos;
    }
}