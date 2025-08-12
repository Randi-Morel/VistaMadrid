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
            this.pnInferior = new System.Windows.Forms.Panel();
            this.tblCentral = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.nudDiasCredito = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new ReaLTaiizor.Controls.CyberRichTextBox();
            this.rbInactivo = new ReaLTaiizor.Controls.FoxRadioButton();
            this.rbActivo = new ReaLTaiizor.Controls.FoxRadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblMesa = new System.Windows.Forms.Label();
            this.cbSala = new System.Windows.Forms.ComboBox();
            this.tblCentral.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiasCredito)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnInferior
            // 
            this.pnInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnInferior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnInferior.Location = new System.Drawing.Point(0, 398);
            this.pnInferior.Name = "pnInferior";
            this.pnInferior.Size = new System.Drawing.Size(1144, 355);
            this.pnInferior.TabIndex = 11;
            // 
            // tblCentral
            // 
            this.tblCentral.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tblCentral.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tblCentral.ColumnCount = 1;
            this.tblCentral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCentral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblCentral.Controls.Add(this.panel6, 0, 0);
            this.tblCentral.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblCentral.Location = new System.Drawing.Point(0, 93);
            this.tblCentral.Name = "tblCentral";
            this.tblCentral.RowCount = 1;
            this.tblCentral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCentral.Size = new System.Drawing.Size(1144, 305);
            this.tblCentral.TabIndex = 12;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.Controls.Add(this.cbSala);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.nudDiasCredito);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.txtDescripcion);
            this.panel6.Controls.Add(this.rbInactivo);
            this.panel6.Controls.Add(this.rbActivo);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(5, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1134, 295);
            this.panel6.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(650, 57);
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
            this.nudDiasCredito.Location = new System.Drawing.Point(654, 83);
            this.nudDiasCredito.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nudDiasCredito.Name = "nudDiasCredito";
            this.nudDiasCredito.Size = new System.Drawing.Size(120, 27);
            this.nudDiasCredito.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(341, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 23);
            this.label1.TabIndex = 52;
            this.label1.Text = "Sala";
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
            this.txtDescripcion.Location = new System.Drawing.Point(48, 83);
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
            this.rbInactivo.Location = new System.Drawing.Point(955, 83);
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
            this.rbActivo.Location = new System.Drawing.Point(849, 83);
            this.rbActivo.Name = "rbActivo";
            this.rbActivo.Size = new System.Drawing.Size(89, 27);
            this.rbActivo.TabIndex = 49;
            this.rbActivo.Text = "Activo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.label7.Location = new System.Drawing.Point(44, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 23);
            this.label7.TabIndex = 45;
            this.label7.Text = "Descripción";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.label6.Location = new System.Drawing.Point(845, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 23);
            this.label6.TabIndex = 36;
            this.label6.Text = "Estado";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panel4.Controls.Add(this.lblMesa);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1144, 93);
            this.panel4.TabIndex = 13;
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.BackColor = System.Drawing.Color.Transparent;
            this.lblMesa.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.lblMesa.Location = new System.Drawing.Point(5, 5);
            this.lblMesa.Margin = new System.Windows.Forms.Padding(5);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(382, 40);
            this.lblMesa.TabIndex = 17;
            this.lblMesa.Text = "Mantenimiento de Mesa";
            // 
            // cbSala
            // 
            this.cbSala.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSala.FormattingEnabled = true;
            this.cbSala.Location = new System.Drawing.Point(345, 83);
            this.cbSala.Name = "cbSala";
            this.cbSala.Size = new System.Drawing.Size(255, 28);
            this.cbSala.TabIndex = 58;
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
            this.tblCentral.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiasCredito)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnInferior;
        private System.Windows.Forms.TableLayoutPanel tblCentral;
        private System.Windows.Forms.Panel panel6;
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
    }
}