namespace Segundo_Parcial.Vista
{
    partial class CommerceMaintenance
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCommerceName = new System.Windows.Forms.Label();
            this.lblCommerceDescription = new System.Windows.Forms.Label();
            this.txtCommerceName = new System.Windows.Forms.TextBox();
            this.txtCommerceDescription = new System.Windows.Forms.TextBox();
            this.btnAddCommerce = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDeleteCommerce = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbDeleteCommerce = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(95)))), ((int)(((byte)(230)))));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(748, 435);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(40, 24);
            this.groupBox1.Name = "groupBox1";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox1, 2);
            this.groupBox1.Size = new System.Drawing.Size(330, 384);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar negocio";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.lblCommerceName, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblCommerceDescription, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtCommerceName, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtCommerceDescription, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnAddCommerce, 0, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 21);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(324, 360);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblCommerceName
            // 
            this.lblCommerceName.AutoSize = true;
            this.lblCommerceName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCommerceName.Location = new System.Drawing.Point(3, 72);
            this.lblCommerceName.Name = "lblCommerceName";
            this.lblCommerceName.Size = new System.Drawing.Size(220, 36);
            this.lblCommerceName.TabIndex = 0;
            this.lblCommerceName.Text = "Nombre del negocio:";
            this.lblCommerceName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCommerceDescription
            // 
            this.lblCommerceDescription.AutoSize = true;
            this.lblCommerceDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCommerceDescription.Location = new System.Drawing.Point(3, 144);
            this.lblCommerceDescription.Name = "lblCommerceDescription";
            this.lblCommerceDescription.Size = new System.Drawing.Size(220, 36);
            this.lblCommerceDescription.TabIndex = 1;
            this.lblCommerceDescription.Text = "Descripción del negocio:";
            this.lblCommerceDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCommerceName
            // 
            this.txtCommerceName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.SetColumnSpan(this.txtCommerceName, 2);
            this.txtCommerceName.Location = new System.Drawing.Point(48, 113);
            this.txtCommerceName.Name = "txtCommerceName";
            this.txtCommerceName.Size = new System.Drawing.Size(228, 25);
            this.txtCommerceName.TabIndex = 2;
            // 
            // txtCommerceDescription
            // 
            this.txtCommerceDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.SetColumnSpan(this.txtCommerceDescription, 2);
            this.txtCommerceDescription.Location = new System.Drawing.Point(50, 185);
            this.txtCommerceDescription.Name = "txtCommerceDescription";
            this.txtCommerceDescription.Size = new System.Drawing.Size(224, 25);
            this.txtCommerceDescription.TabIndex = 2;
            // 
            // btnAddCommerce
            // 
            this.btnAddCommerce.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddCommerce.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddCommerce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(29)))), ((int)(((byte)(98)))));
            this.tableLayoutPanel2.SetColumnSpan(this.btnAddCommerce, 2);
            this.btnAddCommerce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCommerce.Location = new System.Drawing.Point(67, 219);
            this.btnAddCommerce.Name = "btnAddCommerce";
            this.btnAddCommerce.Size = new System.Drawing.Size(190, 30);
            this.btnAddCommerce.TabIndex = 3;
            this.btnAddCommerce.Text = "Agregar negocio";
            this.btnAddCommerce.UseVisualStyleBackColor = false;
            this.btnAddCommerce.Click += new System.EventHandler(this.btnAddCommerce_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(376, 24);
            this.groupBox2.Name = "groupBox2";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox2, 2);
            this.groupBox2.Size = new System.Drawing.Size(330, 384);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eliminar negocio";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.Controls.Add(this.lblDeleteCommerce, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.button1, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.cmbDeleteCommerce, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 21);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(324, 360);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // lblDeleteCommerce
            // 
            this.lblDeleteCommerce.AutoSize = true;
            this.lblDeleteCommerce.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDeleteCommerce.Location = new System.Drawing.Point(3, 108);
            this.lblDeleteCommerce.Name = "lblDeleteCommerce";
            this.lblDeleteCommerce.Size = new System.Drawing.Size(220, 36);
            this.lblDeleteCommerce.TabIndex = 0;
            this.lblDeleteCommerce.Text = "Negocio a eliminar:";
            this.lblDeleteCommerce.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(29)))), ((int)(((byte)(98)))));
            this.tableLayoutPanel3.SetColumnSpan(this.button1, 2);
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(67, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Eliminar negocio";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbDeleteCommerce
            // 
            this.cmbDeleteCommerce.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel3.SetColumnSpan(this.cmbDeleteCommerce, 2);
            this.cmbDeleteCommerce.FormattingEnabled = true;
            this.cmbDeleteCommerce.Location = new System.Drawing.Point(42, 151);
            this.cmbDeleteCommerce.Name = "cmbDeleteCommerce";
            this.cmbDeleteCommerce.Size = new System.Drawing.Size(239, 25);
            this.cmbDeleteCommerce.TabIndex = 4;
            this.cmbDeleteCommerce.SelectedIndexChanged += new System.EventHandler(this.cmbDeleteCommerce_SelectedIndexChanged);
            // 
            // CommerceMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CommerceMaintenance";
            this.Size = new System.Drawing.Size(748, 435);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblCommerceName;
        private System.Windows.Forms.Label lblCommerceDescription;
        private System.Windows.Forms.TextBox txtCommerceName;
        private System.Windows.Forms.TextBox txtCommerceDescription;
        private System.Windows.Forms.Button btnAddCommerce;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblDeleteCommerce;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbDeleteCommerce;
    }
}
