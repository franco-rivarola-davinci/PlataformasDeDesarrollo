﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ventaVideojuegos.Modelo;

namespace ventaVideojuegos.UsersControls
{
    public partial class UC_Admin : UserControl
    {

        private static Producto filtro = new Producto();      
        private List<Producto> Productos_Completo = new List<Producto>();
        private List<Producto> Productos_Filtrado = new List<Producto>();
        private List<Producto> Productos_Paginados = new List<Producto>();

        private static int current = 0;
        private static int paginador = 10;
        private static int total = 0;
        private static int last_pag = 0;
        private static int current_pag = 0;

        public UC_Admin()
        {
            InitializeComponent();
            ControladorCategorias.IniciarRepositorio();
            ControladorConsola.IniciarRepositorio();
            ControladorProductos.IniciarRepositorio();
            Productos_Completo = ControladorProductos.Productos;
            Productos_Completo = ControladorProductos.Productos;
            Productos_Filtrado = ControladorProductos.Productos;
            
            total = Productos_Completo.Count(prod => prod.Vista == true);
              
        
            
            
            last_pag = total / paginador;
            paginar(Productos_Completo);

            llenarCombos();

            VisualizarCategorias();
            VisualizarConsolas();
            VisualizarProductos();
        }

        private void VisualizarProductos()
        {
            dataGridView1.Rows.Clear();
            foreach (Producto prod in ControladorProductos.Productos)
            {
                if (prod.Vista == true)
                {
                    int rowIndex = dataGridView1.Rows.Add();
                    dataGridView1.Rows[rowIndex].Cells[0].Value = prod.Id.ToString();
                    dataGridView1.Rows[rowIndex].Cells[1].Value = prod.Nombre.ToString();
                    dataGridView1.Rows[rowIndex].Cells[2].Value = prod.Precio.ToString();
                    dataGridView1.Rows[rowIndex].Cells[3].Value = prod.Stock.ToString();
                    dataGridView1.Rows[rowIndex].Cells[4].Value = prod.Categoria.Nombre.ToString();
                    dataGridView1.Rows[rowIndex].Cells[5].Value = prod.Consola.Nombre.ToString();
                    dataGridView1.Rows[rowIndex].Cells[6].Value = prod.Conexion.ToString();
                    dataGridView1.Rows[rowIndex].Cells[7].Value = prod.ModoJuego.ToString();
                    // Bitmap img;
                    // img = new Bitmap("RUTA" + prod.Imagen + ".jpg");
                    // dataGridView1.Rows[rowIndex].Cells[8].Value = img;
                }
            }


        }

        private void VisualizarCategorias()
        {
            dataGridViewCat.Rows.Clear();
            foreach (Categoria cat in ControladorCategorias.Categorias)
            {

                if (cat.Vista == true)
                {
                    int rowIndex = dataGridViewCat.Rows.Add();
                    dataGridViewCat.Rows[rowIndex].Cells[0].Value = cat.Id.ToString();
                    dataGridViewCat.Rows[rowIndex].Cells[1].Value = cat.Nombre.ToString();
                }
            }
        }

        private void VisualizarConsolas()
        {
            dataGridViewCon.Rows.Clear();
            foreach (Consola con in ControladorConsola.Consolas)
            {
                if (con.Vista == true)
                {
                    int rowIndex = dataGridViewCon.Rows.Add();
                    dataGridViewCon.Rows[rowIndex].Cells[0].Value = con.Id.ToString();
                    dataGridViewCon.Rows[rowIndex].Cells[1].Value = con.Nombre.ToString();
                }
            }
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormProducto productForm = new FormProducto();
            DialogResult dialogResult = productForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                ControladorProductos.AñandirProducto(productForm.productoNuevo);
            }
            VisualizarCategorias();
            VisualizarConsolas();
            VisualizarProductos();
        }

        private void btnNuevaCat_Click(object sender, EventArgs e)
        {

            FormCategoria catForm = new FormCategoria();
            DialogResult dialogResult = catForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                ControladorCategorias.AñadirCategoria(catForm.categoriaNueva);
            }
            VisualizarCategorias();
            VisualizarConsolas();
            VisualizarProductos();
        }

        private void btnNuevaCon_Click(object sender, EventArgs e)
        {

            FormConsola conForm = new FormConsola();
            DialogResult dialogResult = conForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                ControladorConsola.AñadirConsola(conForm.consolaNueva);
                VisualizarCategorias();
                VisualizarConsolas();
                VisualizarProductos();
            }
        }

        private void btnEditarCat_Click(object sender, EventArgs e)
        {
            if(dataGridViewCat.SelectedRows.Count > 0)
            {
                string idCatEditar = dataGridViewCat.SelectedRows[0].Cells[0].Value.ToString();
                string nombreCatEditar = dataGridViewCat.SelectedRows[0].Cells[1].Value.ToString();

                Categoria catEditar = new Categoria()
                {
                    Id = int.Parse(idCatEditar),
                    Nombre = nombreCatEditar
                };

                FormCategoria formCategoria = new FormCategoria(catEditar);
                DialogResult dialogResult = formCategoria.ShowDialog();

                if(dialogResult == DialogResult.OK)
                {
                    ControladorCategorias.ActualizarCategoria(int.Parse(idCatEditar), formCategoria.categoriaNueva);
                    VisualizarCategorias();
                    VisualizarConsolas();
                    VisualizarProductos();
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar una categoria para Editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }

        private void btnEditarCon_Click(object sender, EventArgs e)
        {
            if (dataGridViewCon.SelectedRows.Count > 0)
            {
                string idConEditar = dataGridViewCon.SelectedRows[0].Cells[0].Value.ToString();
                string nombreConEditar = dataGridViewCon.SelectedRows[0].Cells[1].Value.ToString();

                Consola conEditar = new Consola()
                {
                    Id = int.Parse(idConEditar),
                    Nombre = nombreConEditar
                };

                FormConsola formConsola = new FormConsola(conEditar);
                DialogResult dialogResult = formConsola.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    ControladorConsola.ActualizarConsola(int.Parse(idConEditar), formConsola.consolaNueva);

                }
                VisualizarCategorias();
                VisualizarConsolas();
                VisualizarProductos();
            }
            else
            {
                MessageBox.Show("Debes seleccionar una consola para Editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnEliminarCat_Click(object sender, EventArgs e)
        {
            if (dataGridViewCat.SelectedRows.Count > 0)
            {
                string idCatEliminar = dataGridViewCat.SelectedRows[0].Cells[0].Value.ToString();
                ControladorCategorias.EliminarCategoria(int.Parse(idCatEliminar));
                VisualizarCategorias();
            }
            else
            {
                MessageBox.Show("Debes seleccionar una categoria para Eliminar", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnEliminarCon_Click(object sender, EventArgs e)
        {
            if (dataGridViewCon.SelectedRows.Count > 0)
            {
                string idConEliminar = dataGridViewCon.SelectedRows[0].Cells[0].Value.ToString();
                ControladorConsola.EliminarConsola(int.Parse(idConEliminar));
                VisualizarConsolas();
            }
            else
            {
                MessageBox.Show("Debes seleccionar una consola para Eliminar", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string idProdEditar = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string nombreProdEditar = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string precioProdEditar = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string stockProdEditar = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string categoriaProdEditar = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                string consolaProdEditar = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                string conexionProdEditar = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                string modoJuegoProdEditar = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();

                Producto prodEditar = new Producto()
                {
                    Id = int.Parse(idProdEditar),
                    Nombre = nombreProdEditar,
                    Precio = int.Parse(precioProdEditar),
                    Stock = int.Parse(stockProdEditar),
                    Categoria = ControladorCategorias.GetCategoriaByName(categoriaProdEditar),
                    Consola = ControladorConsola.GetConsolaByName(consolaProdEditar),
                    Conexion = conexionProdEditar,
                    ModoJuego = modoJuegoProdEditar
                };

                FormProducto formProducto = new FormProducto(prodEditar);
                DialogResult dialogResult = formProducto.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    ControladorProductos.ActualizarProductos(int.Parse(idProdEditar), formProducto.productoNuevo);
                    VisualizarCategorias();
                    VisualizarConsolas();
                    VisualizarProductos();
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar un producto para Editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string idProdEliminar = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                ControladorProductos.EliminarProducto(int.Parse(idProdEliminar));
                VisualizarCategorias();
                VisualizarConsolas();
                VisualizarProductos();
            }
            else
            {
                MessageBox.Show("Debes seleccionar un producto para Eliminar", "Error", MessageBoxButtons.OK);
            }
        }
        
        private void llenarBoxCategorias()
        {
            foreach(Categoria cat in ControladorCategorias.Categorias)
            {
                if (cat.Vista == true)
                {
                    boxCategorias.Items.Add(cat.Nombre);
                }
            }
        }

        private void llenarBoxConsolas()
        {
            foreach (Consola con in ControladorConsola.Consolas)
            {
                if (con.Vista == true)
                {
                    boxConsolas.Items.Add(con.Nombre);
                }
            }
        }

        private void llenarCombos()
        {
            llenarBoxCategorias();
            llenarBoxConsolas();
            llenarBoxPaginacion();
        }

        private void llenarBoxPaginacion()
        {
            boxPaginacion.Items.Add("10");
            boxPaginacion.Items.Add("20");
            boxPaginacion.Items.Add("30");
            boxPaginacion.Items.Add("40");
            boxPaginacion.Items.Add("50");
            boxPaginacion.SelectedItem = "10";
        }

        private void paginar (List<Producto> prodMostrar)
        {
            Productos_Paginados = prodMostrar.Skip(current).Take(paginador).ToList();
            VisualizarProductos();
            label_paginacion.Text = "Mostrando " + (current + 1) + "-" + (current + paginador) + "de " + total;

            if (current_pag == 1)
            {
                btn_FirstPage.Hide();
                btn_prev_page.Hide();
            }
            else
            {
                btn_FirstPage.Show();
                btn_FirstPage.Text = "1";
                btn_prev_page.Show();
                btn_prev_page.Text = (current_pag - 1).ToString();
            }

            if(current_pag == last_pag)
            {
                btn_last_page.Hide();
            }
            else
            {
                btn_last_page.Show();
            }

            btn_next_page.Text = (current_pag + 1).ToString();
            btn_last_page.Text = (current_pag - 1).ToString();
        }

    
    }
}
