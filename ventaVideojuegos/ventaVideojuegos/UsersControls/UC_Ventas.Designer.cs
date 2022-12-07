namespace ventaVideojuegos.UsersControls
{
    partial class UC_Ventas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TabAdmin = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnVerDetalles = new System.Windows.Forms.Button();
            this.dataGridViewCVentas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.editarCant = new System.Windows.Forms.Button();
            this.btnVaciarCarrito = new System.Windows.Forms.Button();
            this.btnQuitarProducto = new System.Windows.Forms.Button();
            this.btnFinalizarCompra = new System.Windows.Forms.Button();
            this.lblValor = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TabAdmin.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCVentas)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TabAdmin
            // 
            this.TabAdmin.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.TabAdmin.Controls.Add(this.tabPage1);
            this.TabAdmin.Controls.Add(this.tabPage2);
            this.TabAdmin.ItemSize = new System.Drawing.Size(180, 40);
            this.TabAdmin.Location = new System.Drawing.Point(8, 18);
            this.TabAdmin.Name = "TabAdmin";
            this.TabAdmin.SelectedIndex = 0;
            this.TabAdmin.Size = new System.Drawing.Size(1401, 664);
            this.TabAdmin.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.TabAdmin.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.TabAdmin.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TabAdmin.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.TabAdmin.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.TabAdmin.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.TabAdmin.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TabAdmin.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TabAdmin.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.TabAdmin.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TabAdmin.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.TabAdmin.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.TabAdmin.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TabAdmin.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.TabAdmin.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.TabAdmin.TabButtonSize = new System.Drawing.Size(180, 40);
            this.TabAdmin.TabIndex = 18;
            this.TabAdmin.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tabPage1.Controls.Add(this.btnVerDetalles);
            this.tabPage1.Controls.Add(this.dataGridViewCVentas);
            this.tabPage1.Location = new System.Drawing.Point(184, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1213, 656);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Ventas";
            // 
            // btnVerDetalles
            // 
            this.btnVerDetalles.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnVerDetalles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerDetalles.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVerDetalles.Location = new System.Drawing.Point(573, 21);
            this.btnVerDetalles.Name = "btnVerDetalles";
            this.btnVerDetalles.Size = new System.Drawing.Size(105, 26);
            this.btnVerDetalles.TabIndex = 15;
            this.btnVerDetalles.Text = "Ver detalles";
            this.btnVerDetalles.UseVisualStyleBackColor = false;
            this.btnVerDetalles.Click += new System.EventHandler(this.btnVerDetalles_Click);
            // 
            // dataGridViewCVentas
            // 
            this.dataGridViewCVentas.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewCVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewCVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCVentas.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridViewCVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.Cliente,
            this.Empleado,
            this.ValorTotal,
            this.dateTime});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCVentas.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewCVentas.EnableHeadersVisualStyles = false;
            this.dataGridViewCVentas.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridViewCVentas.Location = new System.Drawing.Point(16, 21);
            this.dataGridViewCVentas.Name = "dataGridViewCVentas";
            this.dataGridViewCVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewCVentas.RowHeadersVisible = false;
            this.dataGridViewCVentas.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewCVentas.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewCVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCVentas.ShowRowErrors = false;
            this.dataGridViewCVentas.Size = new System.Drawing.Size(464, 278);
            this.dataGridViewCVentas.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn5.HeaderText = "Id Venta";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 71;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.MinimumWidth = 6;
            this.Cliente.Name = "Cliente";
            this.Cliente.Width = 63;
            // 
            // Empleado
            // 
            this.Empleado.HeaderText = "Empleado";
            this.Empleado.MinimumWidth = 6;
            this.Empleado.Name = "Empleado";
            this.Empleado.Width = 78;
            // 
            // ValorTotal
            // 
            this.ValorTotal.HeaderText = "ValorTotal";
            this.ValorTotal.MinimumWidth = 6;
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.Width = 79;
            // 
            // dateTime
            // 
            this.dateTime.HeaderText = "Fecha";
            this.dateTime.MinimumWidth = 6;
            this.dateTime.Name = "dateTime";
            this.dateTime.Width = 61;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tabPage2.Controls.Add(this.guna2HtmlLabel4);
            this.tabPage2.Controls.Add(this.editarCant);
            this.tabPage2.Controls.Add(this.btnVaciarCarrito);
            this.tabPage2.Controls.Add(this.btnQuitarProducto);
            this.tabPage2.Controls.Add(this.btnFinalizarCompra);
            this.tabPage2.Controls.Add(this.lblValor);
            this.tabPage2.Controls.Add(this.lbl);
            this.tabPage2.Controls.Add(this.btnAñadir);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(184, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1213, 656);
            this.tabPage2.TabIndex = 5;
            this.tabPage2.Text = "Nueva venta";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.AutoSize = false;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(472, 19);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(100, 22);
            this.guna2HtmlLabel4.TabIndex = 58;
            this.guna2HtmlLabel4.Text = "Valor Total";
            // 
            // editarCant
            // 
            this.editarCant.BackColor = System.Drawing.SystemColors.HighlightText;
            this.editarCant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editarCant.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.editarCant.Location = new System.Drawing.Point(232, 231);
            this.editarCant.Name = "editarCant";
            this.editarCant.Size = new System.Drawing.Size(100, 26);
            this.editarCant.TabIndex = 57;
            this.editarCant.Text = "Editar cantidad";
            this.editarCant.UseVisualStyleBackColor = false;
            this.editarCant.Click += new System.EventHandler(this.editarCant_Click_1);
            // 
            // btnVaciarCarrito
            // 
            this.btnVaciarCarrito.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnVaciarCarrito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVaciarCarrito.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVaciarCarrito.Location = new System.Drawing.Point(338, 231);
            this.btnVaciarCarrito.Name = "btnVaciarCarrito";
            this.btnVaciarCarrito.Size = new System.Drawing.Size(100, 26);
            this.btnVaciarCarrito.TabIndex = 56;
            this.btnVaciarCarrito.Text = "Vaciar Carrito";
            this.btnVaciarCarrito.UseVisualStyleBackColor = false;
            this.btnVaciarCarrito.Click += new System.EventHandler(this.btnVaciarCarrito_Click_1);
            // 
            // btnQuitarProducto
            // 
            this.btnQuitarProducto.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnQuitarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitarProducto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnQuitarProducto.Location = new System.Drawing.Point(126, 231);
            this.btnQuitarProducto.Name = "btnQuitarProducto";
            this.btnQuitarProducto.Size = new System.Drawing.Size(100, 26);
            this.btnQuitarProducto.TabIndex = 55;
            this.btnQuitarProducto.Text = "Quitar producto";
            this.btnQuitarProducto.UseVisualStyleBackColor = false;
            this.btnQuitarProducto.Click += new System.EventHandler(this.btnQuitarProducto_Click_1);
            // 
            // btnFinalizarCompra
            // 
            this.btnFinalizarCompra.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnFinalizarCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizarCompra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFinalizarCompra.Location = new System.Drawing.Point(578, 19);
            this.btnFinalizarCompra.Name = "btnFinalizarCompra";
            this.btnFinalizarCompra.Size = new System.Drawing.Size(100, 26);
            this.btnFinalizarCompra.TabIndex = 54;
            this.btnFinalizarCompra.Text = "Finalizar Compra";
            this.btnFinalizarCompra.UseVisualStyleBackColor = false;
            this.btnFinalizarCompra.Click += new System.EventHandler(this.btnFinalizarCompra_Click_1);
            // 
            // lblValor
            // 
            this.lblValor.BackColor = System.Drawing.Color.Transparent;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblValor.Location = new System.Drawing.Point(490, 38);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(61, 22);
            this.lblValor.TabIndex = 53;
            this.lblValor.Text = "999.999";
            // 
            // lbl
            // 
            this.lbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl.Location = new System.Drawing.Point(472, 38);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(12, 22);
            this.lbl.TabIndex = 52;
            this.lbl.Text = "$";
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnAñadir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAñadir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAñadir.Location = new System.Drawing.Point(20, 231);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(100, 26);
            this.btnAñadir.TabIndex = 51;
            this.btnAñadir.Text = "Añadir producto";
            this.btnAñadir.UseVisualStyleBackColor = false;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Precio,
            this.Cantidad,
            this.Total});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView1.Location = new System.Drawing.Point(20, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(394, 194);
            this.dataGridView1.TabIndex = 50;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.Width = 74;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.Width = 61;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 73;
            // 
            // Total
            // 
            this.Total.HeaderText = "Valor Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.Width = 82;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(ventaVideojuegos.Modelo.Producto);
            // 
            // UC_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.TabAdmin);
            this.Name = "UC_Ventas";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(1401, 674);
            this.TabAdmin.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCVentas)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource productoBindingSource;
        private Guna.UI2.WinForms.Guna2TabControl TabAdmin;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnVerDetalles;
        private System.Windows.Forms.DataGridView dataGridViewCVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTime;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button editarCant;
        private System.Windows.Forms.Button btnVaciarCarrito;
        private System.Windows.Forms.Button btnQuitarProducto;
        private System.Windows.Forms.Button btnFinalizarCompra;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblValor;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
    }
}
