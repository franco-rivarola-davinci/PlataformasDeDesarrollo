namespace ventaVideojuegos
{
    partial class SeleccionarProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.filtroNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCon = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.btnVaciarFiltros = new System.Windows.Forms.Button();
            this.boxConsolas = new System.Windows.Forms.ComboBox();
            this.boxCategorias = new System.Windows.Forms.ComboBox();
            this.btn_actual_page = new Guna.UI2.WinForms.Guna2Button();
            this.btn_FirstPage = new Guna.UI2.WinForms.Guna2Button();
            this.btn_prev_page = new Guna.UI2.WinForms.Guna2Button();
            this.btn_next_page = new Guna.UI2.WinForms.Guna2Button();
            this.btn_last_page = new Guna.UI2.WinForms.Guna2Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Conexion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModoJuego = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelContainer = new Guna.UI2.WinForms.Guna2GradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // filtroNombre
            // 
            this.filtroNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.filtroNombre.DefaultText = "";
            this.filtroNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.filtroNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.filtroNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.filtroNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.filtroNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.filtroNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.filtroNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.filtroNombre.Location = new System.Drawing.Point(161, 33);
            this.filtroNombre.Name = "filtroNombre";
            this.filtroNombre.PasswordChar = '\0';
            this.filtroNombre.PlaceholderText = "";
            this.filtroNombre.SelectedText = "";
            this.filtroNombre.Size = new System.Drawing.Size(84, 23);
            this.filtroNombre.TabIndex = 43;
            this.filtroNombre.TextChanged += new System.EventHandler(this.filtroNombre_TextChanged);
            // 
            // lblCon
            // 
            this.lblCon.AutoSize = true;
            this.lblCon.BackColor = System.Drawing.Color.Transparent;
            this.lblCon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCon.Location = new System.Drawing.Point(597, 16);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(45, 13);
            this.lblCon.TabIndex = 42;
            this.lblCon.Text = "Consola";
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.BackColor = System.Drawing.Color.Transparent;
            this.lblCat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCat.Location = new System.Drawing.Point(496, 16);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(52, 13);
            this.lblCat.TabIndex = 41;
            this.lblCat.Text = "Categoria";
            // 
            // btnVaciarFiltros
            // 
            this.btnVaciarFiltros.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnVaciarFiltros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVaciarFiltros.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVaciarFiltros.Location = new System.Drawing.Point(752, 34);
            this.btnVaciarFiltros.Name = "btnVaciarFiltros";
            this.btnVaciarFiltros.Size = new System.Drawing.Size(100, 23);
            this.btnVaciarFiltros.TabIndex = 40;
            this.btnVaciarFiltros.Text = "Reiniciar filtros";
            this.btnVaciarFiltros.UseVisualStyleBackColor = false;
            this.btnVaciarFiltros.Click += new System.EventHandler(this.btnVaciarFiltros_Click);
            // 
            // boxConsolas
            // 
            this.boxConsolas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxConsolas.FormattingEnabled = true;
            this.boxConsolas.Location = new System.Drawing.Point(594, 33);
            this.boxConsolas.Name = "boxConsolas";
            this.boxConsolas.Size = new System.Drawing.Size(84, 21);
            this.boxConsolas.TabIndex = 39;
            this.boxConsolas.SelectedIndexChanged += new System.EventHandler(this.boxConsolas_SelectedIndexChanged);
            // 
            // boxCategorias
            // 
            this.boxCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxCategorias.FormattingEnabled = true;
            this.boxCategorias.Location = new System.Drawing.Point(493, 33);
            this.boxCategorias.Name = "boxCategorias";
            this.boxCategorias.Size = new System.Drawing.Size(84, 21);
            this.boxCategorias.TabIndex = 38;
            this.boxCategorias.SelectedIndexChanged += new System.EventHandler(this.boxCategorias_SelectedIndexChanged);
            // 
            // btn_actual_page
            // 
            this.btn_actual_page.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_actual_page.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_actual_page.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_actual_page.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_actual_page.FillColor = System.Drawing.Color.Silver;
            this.btn_actual_page.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_actual_page.ForeColor = System.Drawing.Color.White;
            this.btn_actual_page.Location = new System.Drawing.Point(459, 481);
            this.btn_actual_page.Name = "btn_actual_page";
            this.btn_actual_page.Size = new System.Drawing.Size(39, 21);
            this.btn_actual_page.TabIndex = 37;
            this.btn_actual_page.Click += new System.EventHandler(this.btn_actual_page_Click);
            // 
            // btn_FirstPage
            // 
            this.btn_FirstPage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_FirstPage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_FirstPage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_FirstPage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_FirstPage.FillColor = System.Drawing.Color.Silver;
            this.btn_FirstPage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_FirstPage.ForeColor = System.Drawing.Color.Black;
            this.btn_FirstPage.Location = new System.Drawing.Point(335, 481);
            this.btn_FirstPage.Name = "btn_FirstPage";
            this.btn_FirstPage.Size = new System.Drawing.Size(43, 21);
            this.btn_FirstPage.TabIndex = 36;
            this.btn_FirstPage.Text = "<<";
            this.btn_FirstPage.Click += new System.EventHandler(this.btn_FirstPage_Click);
            // 
            // btn_prev_page
            // 
            this.btn_prev_page.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_prev_page.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_prev_page.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_prev_page.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_prev_page.FillColor = System.Drawing.Color.Silver;
            this.btn_prev_page.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_prev_page.ForeColor = System.Drawing.Color.Black;
            this.btn_prev_page.Location = new System.Drawing.Point(398, 481);
            this.btn_prev_page.Name = "btn_prev_page";
            this.btn_prev_page.Size = new System.Drawing.Size(39, 21);
            this.btn_prev_page.TabIndex = 35;
            this.btn_prev_page.Text = " <";
            this.btn_prev_page.Click += new System.EventHandler(this.btn_prev_page_Click);
            // 
            // btn_next_page
            // 
            this.btn_next_page.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_next_page.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_next_page.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_next_page.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_next_page.FillColor = System.Drawing.Color.Silver;
            this.btn_next_page.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_next_page.ForeColor = System.Drawing.Color.Black;
            this.btn_next_page.Location = new System.Drawing.Point(525, 482);
            this.btn_next_page.Name = "btn_next_page";
            this.btn_next_page.Size = new System.Drawing.Size(39, 21);
            this.btn_next_page.TabIndex = 34;
            this.btn_next_page.Text = ">";
            this.btn_next_page.Click += new System.EventHandler(this.btn_next_page_Click);
            // 
            // btn_last_page
            // 
            this.btn_last_page.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_last_page.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_last_page.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_last_page.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_last_page.FillColor = System.Drawing.Color.Silver;
            this.btn_last_page.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_last_page.ForeColor = System.Drawing.Color.Black;
            this.btn_last_page.Location = new System.Drawing.Point(585, 482);
            this.btn_last_page.Name = "btn_last_page";
            this.btn_last_page.Size = new System.Drawing.Size(43, 21);
            this.btn_last_page.TabIndex = 33;
            this.btn_last_page.Text = ">>";
            this.btn_last_page.Click += new System.EventHandler(this.btn_last_page_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregar.Location = new System.Drawing.Point(752, 477);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 26);
            this.btnAgregar.TabIndex = 32;
            this.btnAgregar.Text = "Agregar al carrito";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Imagen,
            this.Nombre,
            this.Precio,
            this.Stock,
            this.Categoria,
            this.Consola,
            this.Conexion,
            this.ModoJuego,
            this.Estado});
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(88, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(766, 405);
            this.dataGridView1.TabIndex = 44;
            // 
            // Id
            // 
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            this.Id.DefaultCellStyle = dataGridViewCellStyle21;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 41;
            // 
            // Imagen
            // 
            this.Imagen.FillWeight = 500F;
            this.Imagen.HeaderText = "Imagen";
            this.Imagen.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Imagen.MinimumWidth = 6;
            this.Imagen.Name = "Imagen";
            this.Imagen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Imagen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Imagen.Width = 67;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 69;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.Width = 62;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.MinimumWidth = 6;
            this.Stock.Name = "Stock";
            this.Stock.Width = 60;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            this.Categoria.Width = 77;
            // 
            // Consola
            // 
            this.Consola.HeaderText = "Consola";
            this.Consola.MinimumWidth = 6;
            this.Consola.Name = "Consola";
            this.Consola.Width = 70;
            // 
            // Conexion
            // 
            this.Conexion.HeaderText = "Conexion";
            this.Conexion.MinimumWidth = 6;
            this.Conexion.Name = "Conexion";
            this.Conexion.Width = 76;
            // 
            // ModoJuego
            // 
            this.ModoJuego.HeaderText = "ModoJuego";
            this.ModoJuego.MinimumWidth = 6;
            this.ModoJuego.Name = "ModoJuego";
            this.ModoJuego.Width = 88;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Activo";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.Width = 62;
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainer.BackColor = System.Drawing.Color.Transparent;
            this.panelContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelContainer.BorderColor = System.Drawing.Color.Teal;
            this.panelContainer.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.panelContainer.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelContainer.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.panelContainer.FillColor = System.Drawing.Color.Teal;
            this.panelContainer.FillColor2 = System.Drawing.Color.LightCyan;
            this.panelContainer.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelContainer.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.panelContainer.Location = new System.Drawing.Point(-239, -50);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1425, 709);
            this.panelContainer.TabIndex = 45;
            this.panelContainer.UseTransparentBackground = true;
            // 
            // SeleccionarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(946, 609);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.filtroNombre);
            this.Controls.Add(this.lblCon);
            this.Controls.Add(this.lblCat);
            this.Controls.Add(this.btnVaciarFiltros);
            this.Controls.Add(this.boxConsolas);
            this.Controls.Add(this.boxCategorias);
            this.Controls.Add(this.btn_actual_page);
            this.Controls.Add(this.btn_FirstPage);
            this.Controls.Add(this.btn_prev_page);
            this.Controls.Add(this.btn_next_page);
            this.Controls.Add(this.btn_last_page);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.panelContainer);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "SeleccionarProducto";
            this.Text = "SeleccionarProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox filtroNombre;
        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Button btnVaciarFiltros;
        private System.Windows.Forms.ComboBox boxConsolas;
        private System.Windows.Forms.ComboBox boxCategorias;
        private Guna.UI2.WinForms.Guna2Button btn_actual_page;
        private Guna.UI2.WinForms.Guna2Button btn_FirstPage;
        private Guna.UI2.WinForms.Guna2Button btn_prev_page;
        private Guna.UI2.WinForms.Guna2Button btn_next_page;
        private Guna.UI2.WinForms.Guna2Button btn_last_page;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewImageColumn Imagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consola;
        private System.Windows.Forms.DataGridViewTextBoxColumn Conexion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModoJuego;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private Guna.UI2.WinForms.Guna2GradientPanel panelContainer;
    }
}