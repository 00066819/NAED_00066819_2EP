namespace Segundo_Parcial
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUserMaintenance = new System.Windows.Forms.Button();
            this.btnViewUsers = new System.Windows.Forms.Button();
            this.usersMaintenance1 = new Segundo_Parcial.Vista.UsersMaintenance();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.commerceMaintenance1 = new Segundo_Parcial.Vista.CommerceMaintenance();
            this.productMaintenance1 = new Segundo_Parcial.Vista.ProductMaintenance();
            this.allOrders1 = new Segundo_Parcial.Vista.AllOrders();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(777, 492);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(29)))), ((int)(((byte)(98)))));
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(769, 466);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Usuarios";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnUserMaintenance, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnViewUsers, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.usersMaintenance1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(763, 460);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnUserMaintenance
            // 
            this.btnUserMaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(95)))), ((int)(((byte)(230)))));
            this.btnUserMaintenance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUserMaintenance.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUserMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserMaintenance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserMaintenance.ForeColor = System.Drawing.Color.White;
            this.btnUserMaintenance.Location = new System.Drawing.Point(3, 3);
            this.btnUserMaintenance.Name = "btnUserMaintenance";
            this.btnUserMaintenance.Size = new System.Drawing.Size(375, 40);
            this.btnUserMaintenance.TabIndex = 0;
            this.btnUserMaintenance.Text = "Administrar usuarios";
            this.btnUserMaintenance.UseVisualStyleBackColor = false;
            this.btnUserMaintenance.Click += new System.EventHandler(this.btnUserMaintenance_Click);
            // 
            // btnViewUsers
            // 
            this.btnViewUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(95)))), ((int)(((byte)(230)))));
            this.btnViewUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnViewUsers.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnViewUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewUsers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewUsers.ForeColor = System.Drawing.Color.White;
            this.btnViewUsers.Location = new System.Drawing.Point(384, 3);
            this.btnViewUsers.Name = "btnViewUsers";
            this.btnViewUsers.Size = new System.Drawing.Size(376, 40);
            this.btnViewUsers.TabIndex = 0;
            this.btnViewUsers.Text = "Ver usuarios";
            this.btnViewUsers.UseVisualStyleBackColor = false;
            this.btnViewUsers.Click += new System.EventHandler(this.btnViewUsers_Click);
            // 
            // usersMaintenance1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.usersMaintenance1, 2);
            this.usersMaintenance1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersMaintenance1.Location = new System.Drawing.Point(3, 49);
            this.usersMaintenance1.Name = "usersMaintenance1";
            this.usersMaintenance1.Size = new System.Drawing.Size(757, 408);
            this.usersMaintenance1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(29)))), ((int)(((byte)(98)))));
            this.tabPage2.Controls.Add(this.commerceMaintenance1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(769, 466);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Negocios";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(29)))), ((int)(((byte)(98)))));
            this.tabPage3.Controls.Add(this.productMaintenance1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(769, 466);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Productos";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(29)))), ((int)(((byte)(98)))));
            this.tabPage4.Controls.Add(this.allOrders1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(769, 466);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Órdenes";
            // 
            // commerceMaintenance1
            // 
            this.commerceMaintenance1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.commerceMaintenance1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commerceMaintenance1.Location = new System.Drawing.Point(3, 3);
            this.commerceMaintenance1.Name = "commerceMaintenance1";
            this.commerceMaintenance1.Size = new System.Drawing.Size(763, 460);
            this.commerceMaintenance1.TabIndex = 0;
            // 
            // productMaintenance1
            // 
            this.productMaintenance1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.productMaintenance1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productMaintenance1.Location = new System.Drawing.Point(3, 3);
            this.productMaintenance1.Name = "productMaintenance1";
            this.productMaintenance1.Size = new System.Drawing.Size(763, 460);
            this.productMaintenance1.TabIndex = 0;
            // 
            // allOrders1
            // 
            this.allOrders1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.allOrders1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allOrders1.Location = new System.Drawing.Point(3, 3);
            this.allOrders1.Name = "allOrders1";
            this.allOrders1.Size = new System.Drawing.Size(763, 460);
            this.allOrders1.TabIndex = 0;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(29)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(777, 492);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hugo - Admin";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnUserMaintenance;
        private System.Windows.Forms.Button btnViewUsers;
        private Vista.UsersMaintenance usersMaintenance1;
        private Vista.CommerceMaintenance commerceMaintenance1;
        private Vista.ProductMaintenance productMaintenance1;
        private Vista.AllOrders allOrders1;
    }
}