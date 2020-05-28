namespace Segundo_Parcial.Vista
{
    partial class DirectionsMaintenance
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblNewAdress = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtNewAdress = new System.Windows.Forms.TextBox();
            this.btnAddAdress = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtAdressEdited = new System.Windows.Forms.TextBox();
            this.cmbAllAdress = new System.Windows.Forms.ComboBox();
            this.txtUsername2 = new System.Windows.Forms.TextBox();
            this.btnEditAdress = new System.Windows.Forms.Button();
            this.lblUsername2 = new System.Windows.Forms.Label();
            this.lblAllAdress = new System.Windows.Forms.Label();
            this.lblAdressEdited = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblUsername3 = new System.Windows.Forms.Label();
            this.btnDeleteAdress = new System.Windows.Forms.Button();
            this.txtUsername3 = new System.Windows.Forms.TextBox();
            this.cmbAllAdress2 = new System.Windows.Forms.ComboBox();
            this.lblDeleteAdress = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(95)))), ((int)(((byte)(230)))));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(748, 435);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(40, 24);
            this.groupBox1.Name = "groupBox1";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox1, 2);
            this.groupBox1.Size = new System.Drawing.Size(218, 384);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar dirección";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.lblUsername, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblNewAdress, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtUsername, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtNewAdress, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnAddAdress, 0, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 21);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(212, 360);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsername.Location = new System.Drawing.Point(3, 90);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(206, 36);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Compruebe su usuario:";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNewAdress
            // 
            this.lblNewAdress.AutoSize = true;
            this.lblNewAdress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNewAdress.Location = new System.Drawing.Point(3, 162);
            this.lblNewAdress.Name = "lblNewAdress";
            this.lblNewAdress.Size = new System.Drawing.Size(206, 36);
            this.lblNewAdress.TabIndex = 0;
            this.lblNewAdress.Text = "Ingrese la nueva dirección:";
            this.lblNewAdress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername.Location = new System.Drawing.Point(3, 131);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(206, 25);
            this.txtUsername.TabIndex = 1;
            // 
            // txtNewAdress
            // 
            this.txtNewAdress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNewAdress.Location = new System.Drawing.Point(3, 203);
            this.txtNewAdress.Name = "txtNewAdress";
            this.txtNewAdress.Size = new System.Drawing.Size(206, 25);
            this.txtNewAdress.TabIndex = 1;
            // 
            // btnAddAdress
            // 
            this.btnAddAdress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddAdress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(29)))), ((int)(((byte)(98)))));
            this.btnAddAdress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAdress.Location = new System.Drawing.Point(33, 237);
            this.btnAddAdress.Name = "btnAddAdress";
            this.btnAddAdress.Size = new System.Drawing.Size(146, 30);
            this.btnAddAdress.TabIndex = 2;
            this.btnAddAdress.Text = "Agregar dirección";
            this.btnAddAdress.UseVisualStyleBackColor = false;
            this.btnAddAdress.Click += new System.EventHandler(this.btnAddAdress_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(264, 24);
            this.groupBox2.Name = "groupBox2";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox2, 2);
            this.groupBox2.Size = new System.Drawing.Size(218, 384);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modificar dirección";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.txtAdressEdited, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.cmbAllAdress, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.txtUsername2, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnEditAdress, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.lblUsername2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblAllAdress, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblAdressEdited, 0, 5);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 21);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 9;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(212, 360);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // txtAdressEdited
            // 
            this.txtAdressEdited.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAdressEdited.Location = new System.Drawing.Point(3, 239);
            this.txtAdressEdited.Name = "txtAdressEdited";
            this.txtAdressEdited.Size = new System.Drawing.Size(206, 25);
            this.txtAdressEdited.TabIndex = 1;
            // 
            // cmbAllAdress
            // 
            this.cmbAllAdress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbAllAdress.FormattingEnabled = true;
            this.cmbAllAdress.Location = new System.Drawing.Point(3, 169);
            this.cmbAllAdress.Name = "cmbAllAdress";
            this.cmbAllAdress.Size = new System.Drawing.Size(206, 25);
            this.cmbAllAdress.TabIndex = 2;
            // 
            // txtUsername2
            // 
            this.txtUsername2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername2.Location = new System.Drawing.Point(3, 95);
            this.txtUsername2.Name = "txtUsername2";
            this.txtUsername2.Size = new System.Drawing.Size(206, 25);
            this.txtUsername2.TabIndex = 1;
            // 
            // btnEditAdress
            // 
            this.btnEditAdress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditAdress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(29)))), ((int)(((byte)(98)))));
            this.btnEditAdress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAdress.Location = new System.Drawing.Point(33, 273);
            this.btnEditAdress.Name = "btnEditAdress";
            this.btnEditAdress.Size = new System.Drawing.Size(146, 30);
            this.btnEditAdress.TabIndex = 2;
            this.btnEditAdress.Text = "Modificar dirección";
            this.btnEditAdress.UseVisualStyleBackColor = false;
            // 
            // lblUsername2
            // 
            this.lblUsername2.AutoSize = true;
            this.lblUsername2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsername2.Location = new System.Drawing.Point(3, 54);
            this.lblUsername2.Name = "lblUsername2";
            this.lblUsername2.Size = new System.Drawing.Size(206, 36);
            this.lblUsername2.TabIndex = 3;
            this.lblUsername2.Text = "Compruebe su usuario:";
            this.lblUsername2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAllAdress
            // 
            this.lblAllAdress.AutoSize = true;
            this.lblAllAdress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAllAdress.Location = new System.Drawing.Point(3, 126);
            this.lblAllAdress.Name = "lblAllAdress";
            this.lblAllAdress.Size = new System.Drawing.Size(206, 36);
            this.lblAllAdress.TabIndex = 3;
            this.lblAllAdress.Text = "Elija dirección a editar:";
            this.lblAllAdress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAdressEdited
            // 
            this.lblAdressEdited.AutoSize = true;
            this.lblAdressEdited.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAdressEdited.Location = new System.Drawing.Point(3, 198);
            this.lblAdressEdited.Name = "lblAdressEdited";
            this.lblAdressEdited.Size = new System.Drawing.Size(206, 36);
            this.lblAdressEdited.TabIndex = 3;
            this.lblAdressEdited.Text = "Edite la dirección:";
            this.lblAdressEdited.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.tableLayoutPanel4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(488, 24);
            this.groupBox3.Name = "groupBox3";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox3, 2);
            this.groupBox3.Size = new System.Drawing.Size(218, 384);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Eliminar dirección";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.lblUsername3, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtUsername3, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.lblDeleteAdress, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.btnDeleteAdress, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.cmbAllAdress2, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.btnCheck, 0, 3);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 21);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 9;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(212, 360);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // lblUsername3
            // 
            this.lblUsername3.AutoSize = true;
            this.lblUsername3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsername3.Location = new System.Drawing.Point(3, 54);
            this.lblUsername3.Name = "lblUsername3";
            this.lblUsername3.Size = new System.Drawing.Size(206, 36);
            this.lblUsername3.TabIndex = 3;
            this.lblUsername3.Text = "Compruebe su usuario:";
            this.lblUsername3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDeleteAdress
            // 
            this.btnDeleteAdress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteAdress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(29)))), ((int)(((byte)(98)))));
            this.btnDeleteAdress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAdress.Location = new System.Drawing.Point(33, 237);
            this.btnDeleteAdress.Name = "btnDeleteAdress";
            this.btnDeleteAdress.Size = new System.Drawing.Size(146, 30);
            this.btnDeleteAdress.TabIndex = 2;
            this.btnDeleteAdress.Text = "Eliminar dirección";
            this.btnDeleteAdress.UseVisualStyleBackColor = false;
            this.btnDeleteAdress.Click += new System.EventHandler(this.btnDeleteAdress_Click);
            // 
            // txtUsername3
            // 
            this.txtUsername3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername3.Location = new System.Drawing.Point(3, 95);
            this.txtUsername3.Name = "txtUsername3";
            this.txtUsername3.Size = new System.Drawing.Size(206, 25);
            this.txtUsername3.TabIndex = 1;
            // 
            // cmbAllAdress2
            // 
            this.cmbAllAdress2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbAllAdress2.FormattingEnabled = true;
            this.cmbAllAdress2.Location = new System.Drawing.Point(3, 205);
            this.cmbAllAdress2.Name = "cmbAllAdress2";
            this.cmbAllAdress2.Size = new System.Drawing.Size(206, 25);
            this.cmbAllAdress2.TabIndex = 2;
            // 
            // lblDeleteAdress
            // 
            this.lblDeleteAdress.AutoSize = true;
            this.lblDeleteAdress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDeleteAdress.Location = new System.Drawing.Point(3, 162);
            this.lblDeleteAdress.Name = "lblDeleteAdress";
            this.lblDeleteAdress.Size = new System.Drawing.Size(206, 36);
            this.lblDeleteAdress.TabIndex = 4;
            this.lblDeleteAdress.Text = "Elija dirección a eliminar:";
            this.lblDeleteAdress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCheck
            // 
            this.btnCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(29)))), ((int)(((byte)(98)))));
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Location = new System.Drawing.Point(33, 129);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(146, 30);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Comprobar usuario";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // DirectionsMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DirectionsMaintenance";
            this.Size = new System.Drawing.Size(748, 435);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblNewAdress;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtNewAdress;
        private System.Windows.Forms.Button btnAddAdress;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtAdressEdited;
        private System.Windows.Forms.ComboBox cmbAllAdress;
        private System.Windows.Forms.TextBox txtUsername2;
        private System.Windows.Forms.Button btnEditAdress;
        private System.Windows.Forms.Label lblUsername2;
        private System.Windows.Forms.Label lblAllAdress;
        private System.Windows.Forms.Label lblAdressEdited;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ComboBox cmbAllAdress2;
        private System.Windows.Forms.Button btnDeleteAdress;
        private System.Windows.Forms.Label lblUsername3;
        private System.Windows.Forms.TextBox txtUsername3;
        private System.Windows.Forms.Label lblDeleteAdress;
        private System.Windows.Forms.Button btnCheck;
    }
}
