namespace ventaVideojuegos
{
    partial class FormValidarVenta
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
            this.txtID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.boxClientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errPw = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPw = new System.Windows.Forms.Label();
            this.txtPw = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnFinalCompra = new Guna.UI2.WinForms.Guna2Button();
            this.txtVendedor = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.DefaultText = "";
            this.txtID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.Enabled = false;
            this.txtID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.Location = new System.Drawing.Point(239, 28);
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.PlaceholderText = "";
            this.txtID.SelectedText = "";
            this.txtID.Size = new System.Drawing.Size(119, 22);
            this.txtID.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "ID VENTA";
            // 
            // boxClientes
            // 
            this.boxClientes.FormattingEnabled = true;
            this.boxClientes.Location = new System.Drawing.Point(239, 85);
            this.boxClientes.Name = "boxClientes";
            this.boxClientes.Size = new System.Drawing.Size(121, 21);
            this.boxClientes.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Seleccione el cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Vendedor";
            // 
            // errPw
            // 
            this.errPw.BackColor = System.Drawing.Color.Transparent;
            this.errPw.Font = new System.Drawing.Font("Open Sans Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errPw.ForeColor = System.Drawing.Color.Red;
            this.errPw.Location = new System.Drawing.Point(239, 229);
            this.errPw.Name = "errPw";
            this.errPw.Size = new System.Drawing.Size(119, 17);
            this.errPw.TabIndex = 46;
            this.errPw.Text = "Contraseña incorrecta";
            // 
            // lblPw
            // 
            this.lblPw.AutoSize = true;
            this.lblPw.Location = new System.Drawing.Point(83, 202);
            this.lblPw.Name = "lblPw";
            this.lblPw.Size = new System.Drawing.Size(61, 13);
            this.lblPw.TabIndex = 45;
            this.lblPw.Text = "Contraseña";
            // 
            // txtPw
            // 
            this.txtPw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPw.DefaultText = "";
            this.txtPw.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPw.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPw.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPw.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPw.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPw.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPw.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPw.Location = new System.Drawing.Point(239, 202);
            this.txtPw.Name = "txtPw";
            this.txtPw.PasswordChar = '●';
            this.txtPw.PlaceholderText = "";
            this.txtPw.SelectedText = "";
            this.txtPw.Size = new System.Drawing.Size(121, 21);
            this.txtPw.TabIndex = 44;
            this.txtPw.UseSystemPasswordChar = true;
            // 
            // btnFinalCompra
            // 
            this.btnFinalCompra.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFinalCompra.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFinalCompra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFinalCompra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFinalCompra.FillColor = System.Drawing.Color.White;
            this.btnFinalCompra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFinalCompra.ForeColor = System.Drawing.Color.Black;
            this.btnFinalCompra.Location = new System.Drawing.Point(157, 282);
            this.btnFinalCompra.Name = "btnFinalCompra";
            this.btnFinalCompra.Size = new System.Drawing.Size(141, 30);
            this.btnFinalCompra.TabIndex = 43;
            this.btnFinalCompra.Text = "Finalizar Compra";
            this.btnFinalCompra.Click += new System.EventHandler(this.btnFinalCompra_Click);
            // 
            // txtVendedor
            // 
            this.txtVendedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVendedor.DefaultText = "";
            this.txtVendedor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtVendedor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtVendedor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVendedor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVendedor.Enabled = false;
            this.txtVendedor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVendedor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtVendedor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVendedor.Location = new System.Drawing.Point(239, 144);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.PasswordChar = '\0';
            this.txtVendedor.PlaceholderText = "";
            this.txtVendedor.SelectedText = "";
            this.txtVendedor.Size = new System.Drawing.Size(119, 22);
            this.txtVendedor.TabIndex = 47;
            // 
            // FormValidarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 343);
            this.Controls.Add(this.txtVendedor);
            this.Controls.Add(this.errPw);
            this.Controls.Add(this.lblPw);
            this.Controls.Add(this.txtPw);
            this.Controls.Add(this.btnFinalCompra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxClientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Name = "FormValidarVenta";
            this.Text = "FormValidarVenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox boxClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2HtmlLabel errPw;
        private System.Windows.Forms.Label lblPw;
        private Guna.UI2.WinForms.Guna2TextBox txtPw;
        private Guna.UI2.WinForms.Guna2Button btnFinalCompra;
        private Guna.UI2.WinForms.Guna2TextBox txtVendedor;
    }
}