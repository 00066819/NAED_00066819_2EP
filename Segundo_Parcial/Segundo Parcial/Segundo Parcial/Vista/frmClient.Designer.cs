namespace Segundo_Parcial.Vista
{
    partial class frmClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClient));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ordersMaintenance1 = new Segundo_Parcial.Vista.OrdersMaintenance();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.directionsMaintenance1 = new Segundo_Parcial.Vista.DirectionsMaintenance();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.allMyOrders1 = new Segundo_Parcial.Vista.AllMyOrders();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(777, 492);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(29)))), ((int)(((byte)(98)))));
            this.tabPage1.Controls.Add(this.ordersMaintenance1);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(769, 466);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Orden";
            // 
            // ordersMaintenance1
            // 
            this.ordersMaintenance1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ordersMaintenance1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersMaintenance1.Location = new System.Drawing.Point(3, 3);
            this.ordersMaintenance1.Name = "ordersMaintenance1";
            this.ordersMaintenance1.Size = new System.Drawing.Size(763, 460);
            this.ordersMaintenance1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(29)))), ((int)(((byte)(98)))));
            this.tabPage2.Controls.Add(this.directionsMaintenance1);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(769, 466);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Direcciones";
            // 
            // directionsMaintenance1
            // 
            this.directionsMaintenance1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.directionsMaintenance1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.directionsMaintenance1.Location = new System.Drawing.Point(3, 3);
            this.directionsMaintenance1.Name = "directionsMaintenance1";
            this.directionsMaintenance1.Size = new System.Drawing.Size(763, 460);
            this.directionsMaintenance1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(29)))), ((int)(((byte)(98)))));
            this.tabPage3.Controls.Add(this.allMyOrders1);
            this.tabPage3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(769, 466);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Registro";
            // 
            // allMyOrders1
            // 
            this.allMyOrders1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.allMyOrders1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allMyOrders1.Location = new System.Drawing.Point(3, 3);
            this.allMyOrders1.Name = "allMyOrders1";
            this.allMyOrders1.Size = new System.Drawing.Size(763, 460);
            this.allMyOrders1.TabIndex = 0;
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(29)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(777, 492);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hugo";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private OrdersMaintenance ordersMaintenance1;
        private DirectionsMaintenance directionsMaintenance1;
        private AllMyOrders allMyOrders1;
    }
}