using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ventaVideojuegos.Controlers;
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
        private static int current_pag = 1;

        

        public UC_Admin()
        {
            InitializeComponent();
            ControladorCategorias.IniciarRepositorio();
            ControladorConsola.IniciarRepositorio();
            ControladorProductos.IniciarRepositorio();
            ControladorVentas.IniciarRepositorio();
            ControladorClientes.IniciarRepositorio();
            controladorUsuarios.IniciarRepositorio();
            ControladorVentaUnificada.IniciarRepositorio();

            

            Productos_Completo = ControladorProductos.Productos;
            Productos_Filtrado = ControladorProductos.Productos;

            total = Productos_Completo.Count();
            

            paginar(Productos_Completo);
            

            last_pag = total / paginador;

            llenarCombos();
            VisualizarCategorias();
            //VisualizarConsolas();
            visualizarConDB();
            VisualizarClientes();
            VisualizarEmpleados();


        }

        public void VisualizarEmpleados()
        {
            dataGridViewEmp.Rows.Clear();
            foreach (Usuario usr in controladorUsuarios.Usuarios)
            {
                int rowIndex = dataGridViewEmp.Rows.Add();
                dataGridViewEmp.Rows[rowIndex].Cells[0].Value = usr.Id.ToString();
                dataGridViewEmp.Rows[rowIndex].Cells[1].Value = usr.Nombre.ToString();
                if(usr.EsAdmin == true)
                {
                    dataGridViewEmp.Rows[rowIndex].Cells[2].Value = "Administrador";
                }
                else
                {
                    dataGridViewEmp.Rows[rowIndex].Cells[2].Value = "Vendedor";
                }
            }
        }

        public void VisualizarClientes()
        {
            dataGridViewCte.Rows.Clear();
            foreach (Cliente cte in ControladorClientes.Clientes)
            {
                int rowIndex = dataGridViewCte.Rows.Add();
                dataGridViewCte.Rows[rowIndex].Cells[0].Value = cte.Id.ToString();
                dataGridViewCte.Rows[rowIndex].Cells[1].Value = cte.Nombre.ToString();
                dataGridViewCte.Rows[rowIndex].Cells[2].Value = cte.Apellido.ToString();
                dataGridViewCte.Rows[rowIndex].Cells[3].Value = cte.NUsuario.ToString();
                dataGridViewCte.Rows[rowIndex].Cells[4].Value = cte.Email.ToString();
                dataGridViewCte.Rows[rowIndex].Cells[5].Value = cte.Vista.ToString();

            }
        }

        private void VisualizarProductos(List<Producto> listaProductos)
        {
            dataGridView1.Rows.Clear();

            try{

            

            foreach (Producto prod in listaProductos)
            {
                if (prod.Categoria.Vista == true)

                {
                    int rowIndex = dataGridView1.Rows.Add();
                    dataGridView1.Rows[rowIndex].Cells[0].Value = prod.Id.ToString();
                    Bitmap img;
                    img = new Bitmap(Environment.CurrentDirectory + @"\Imgs\" + prod.Imagen);
                    dataGridView1.Rows[rowIndex].Cells[1].Value = img;
                    dataGridView1.Rows[rowIndex].Cells[2].Value = prod.Nombre.ToString();
                    dataGridView1.Rows[rowIndex].Cells[3].Value = prod.Precio.ToString();
                    dataGridView1.Rows[rowIndex].Cells[4].Value = prod.Stock.ToString();
                    dataGridView1.Rows[rowIndex].Cells[5].Value = prod.Categoria.Nombre.ToString();
                    dataGridView1.Rows[rowIndex].Cells[6].Value = prod.Consola.Nombre.ToString();
                    dataGridView1.Rows[rowIndex].Cells[7].Value = prod.Conexion.ToString();
                    dataGridView1.Rows[rowIndex].Cells[8].Value = prod.ModoJuego.ToString();
                    dataGridView1.Rows[rowIndex].Cells[9].Value = prod.Vista.ToString();

                }

                else 
                {

                    int rowIndex = dataGridView1.Rows.Add();
                    dataGridView1.Rows[rowIndex].Cells[0].Value = prod.Id.ToString();
                    dataGridView1.Rows[rowIndex].Cells[1].Value = prod.ModoJuego.ToString();
                    Bitmap img;
                    img = new Bitmap(Environment.CurrentDirectory + @"\Imgs\" + prod.Imagen);
                    dataGridView1.Rows[rowIndex].Cells[2].Value = img;
                    dataGridView1.Rows[rowIndex].Cells[3].Value = prod.Nombre.ToString();
                    dataGridView1.Rows[rowIndex].Cells[4].Value = prod.Precio.ToString();
                    dataGridView1.Rows[rowIndex].Cells[5].Value = prod.Stock.ToString();
                    dataGridView1.Rows[rowIndex].Cells[6].Value = "Categoria no existente";
                    dataGridView1.Rows[rowIndex].Cells[7].Value = prod.Consola.Nombre.ToString();
                    dataGridView1.Rows[rowIndex].Cells[8].Value = prod.Conexion.ToString();
                    dataGridView1.Rows[rowIndex].Cells[9].Value = prod.Vista.ToString();
                }

              }

            }

            catch(Exception e)
            {
                Console.WriteLine("EL ERROR FUE: " + e);
            }

        }

        private void VisualizarCategorias()
        {
            dataGridViewCat.Rows.Clear();
            foreach (Categoria cat in ControladorCategorias.Categorias)
            {
                int rowIndex = dataGridViewCat.Rows.Add();
                dataGridViewCat.Rows[rowIndex].Cells[0].Value = cat.Id.ToString();
                dataGridViewCat.Rows[rowIndex].Cells[1].Value = cat.Nombre.ToString();
                dataGridViewCat.Rows[rowIndex].Cells[2].Value = cat.Vista.ToString();
                

            }
        }
        /*
        private void VisualizarConsolas()
        {
            dataGridViewCon.Rows.Clear();
            foreach (Consola con in ControladorConsola.Consolas)
            {
                int rowIndex = dataGridViewCon.Rows.Add();
                dataGridViewCon.Rows[rowIndex].Cells[0].Value = con.Id.ToString();
                dataGridViewCon.Rows[rowIndex].Cells[1].Value = con.Nombre.ToString();
                dataGridViewCon.Rows[rowIndex].Cells[2].Value = con.Vista.ToString();

            }
        }
        */

        //Sirve para visualizar los registros de la DB
        private void visualizarConDB()
        {
            dataGridViewCon2.DataSource = llenar_grid_consolas();

        }

        //Aca se genera la consulta SQL que llama los registros
        public DataTable llenar_grid_consolas()
        {
            ventaVideojuegos.Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "Use bd_tiendaPdesarrollo; select * from Consola;";
            SqlCommand cmd = new SqlCommand(consulta, ventaVideojuegos.Conexion.Conectar());

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            adapter.Fill(dt);
            return dt;
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
            //VisualizarConsolas();
            paginar(Productos_Completo);
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
            //VisualizarConsolas();

            vaciarCombos();
            llenarCombos();
        }

        private void btnNuevaCon_Click(object sender, EventArgs e)
        {

            FormConsola conForm = new FormConsola();
            DialogResult dialogResult = conForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                ControladorConsola.AñadirConsola(conForm.consolaNueva);
                VisualizarCategorias();
                //VisualizarConsolas();

                vaciarCombos();
                llenarCombos();
            }
        }

        

        private void btnEditarCat_Click(object sender, EventArgs e)
        {
            if (dataGridViewCat.SelectedRows.Count > 0)
            {
                string idCatEditar = dataGridViewCat.SelectedRows[0].Cells[0].Value.ToString();
                string nombreCatEditar = dataGridViewCat.SelectedRows[0].Cells[1].Value.ToString();
                string vistaCatEditar = dataGridViewCat.SelectedRows[0].Cells[2].Value.ToString();

                Categoria catEditar = new Categoria()
                {
                    Id = int.Parse(idCatEditar),
                    Nombre = nombreCatEditar,
                    Vista = bool.Parse(vistaCatEditar)
                };

                FormCategoria formCategoria = new FormCategoria(catEditar);
                DialogResult dialogResult = formCategoria.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    ControladorCategorias.ActualizarCategoria(int.Parse(idCatEditar), formCategoria.categoriaNueva);
                    VisualizarCategorias();
                    //VisualizarConsolas();

                    vaciarCombos();
                    llenarCombos();
                    VisualizarProductos(Productos_Completo);
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar una categoria para Editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        /*
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

                    vaciarCombos();
                    llenarCombos();

                }
                VisualizarCategorias();
                VisualizarConsolas();
            }
            else
            {
                MessageBox.Show("Debes seleccionar una consola para Editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        
        }*/

        private void btnEliminarCat_Click(object sender, EventArgs e)
        {
            if (dataGridViewCat.SelectedRows.Count > 0)
            {
                string idCatEliminar = dataGridViewCat.SelectedRows[0].Cells[0].Value.ToString();
                ControladorCategorias.EliminarCategoria(int.Parse(idCatEliminar));
                VisualizarCategorias();

                vaciarCombos();
                llenarCombos();

                VisualizarProductos(Productos_Completo);
            }
            else
            {
                MessageBox.Show("Debes seleccionar una categoria para Eliminar", "Error", MessageBoxButtons.OK);
            }
        }
        /*
        private void btnEliminarCon_Click(object sender, EventArgs e)
        {
            if (dataGridViewCon.SelectedRows.Count > 0)
            {
                string idConEliminar = dataGridViewCon.SelectedRows[0].Cells[0].Value.ToString();
                ControladorConsola.EliminarConsola(int.Parse(idConEliminar));
                VisualizarConsolas();
                vaciarCombos();
                llenarCombos();
            }
            else
            {
                MessageBox.Show("Debes seleccionar una consola para Eliminar", "Error", MessageBoxButtons.OK);
            }
        }*/

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string idProdEditar = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                
                Producto auxiliar = ControladorProductos.GetProductoById(int.Parse(idProdEditar));

                string nombreProdEditar = auxiliar.Nombre;
                int precioProdEditar = auxiliar.Precio;
                int stockProdEditar = auxiliar.Stock;
                string categoriaProdEditar = auxiliar.Categoria.Nombre;
                string consolaProdEditar = auxiliar.Consola.Nombre;
                string conexionProdEditar = auxiliar.Conexion;
                string modoJuegoProdEditar = auxiliar.ModoJuego;
                bool VistaProdEditar = auxiliar.Vista;
                string imgProdEditar = auxiliar.Imagen;

                Producto prodEditar = new Producto()
                {
                    Id = int.Parse(idProdEditar),
                    Nombre = nombreProdEditar,
                    Precio = precioProdEditar,
                    Stock = stockProdEditar,
                    Categoria = ControladorCategorias.GetCategoriaByName(categoriaProdEditar),
                    Consola = ControladorConsola.GetConsolaByName(consolaProdEditar),
                    Conexion = conexionProdEditar,
                    ModoJuego = modoJuegoProdEditar,
                    Imagen = imgProdEditar,
                    Vista = VistaProdEditar
                };

                FormProducto formProducto = new FormProducto(prodEditar);
                DialogResult dialogResult = formProducto.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    ControladorProductos.ActualizarProductos(int.Parse(idProdEditar), formProducto.productoNuevo);
                    VisualizarCategorias();
                    //VisualizarConsolas();
                    paginar(Productos_Completo);
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
                paginar(Productos_Completo);
            }
            else
            {
                MessageBox.Show("Debes seleccionar un producto para Eliminar", "Error", MessageBoxButtons.OK);
            }
        }

        private void llenarBoxCategorias(List<Categoria> listaCategorias)
        {
            foreach (Categoria cat in listaCategorias)
            {
                if (cat.Vista == true)
                {
                    boxCategorias.Items.Add(cat.Nombre);
                }
            }
        }

        private void llenarBoxConsolas(List<Consola> listaConsolas)
        {
            foreach (Consola con in listaConsolas)
            {
                if (con.Vista == true)
                {
                    boxConsolas.Items.Add(con.Nombre);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                
                filtro.Vista = bool.Parse(comboBox1.Text);
                filtrar();
            }
        }

        private void llenarCombos()
        {
            List<Categoria> listCat = new List<Categoria>();
            listCat = ControladorCategorias.Categorias.Where(x => x.Id != 0).ToList();
            llenarBoxCategorias(listCat);

            List<Consola> listCon = new List<Consola>();
            listCon = ControladorConsola.Consolas.Where(x => x.Id != 0).ToList();
            llenarBoxConsolas(listCon);


            llenarBoxPaginacion();
            llenarBoxEstado();
        }

        private void llenarBoxEstado()
        {
            comboBox1.Items.Add("True");
            comboBox1.Items.Add("False");
        }

        private void vaciarCombos()
        {
            boxCategorias.Items.Clear();
            boxConsolas.Items.Clear();
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

  
       

        private void paginar(List<Producto> prodMostrar)
        {
            Productos_Paginados = prodMostrar.Skip(current).Take(paginador).ToList();
            VisualizarProductos(Productos_Paginados);
            label_paginacion.Text = "Mostrando " + (current + 1) + " - " + (current + paginador) + "de " + total;
            

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

            if (current_pag == last_pag)
            {
                btn_last_page.Hide();
                btn_next_page.Hide();
            }
            else
            {
                btn_last_page.Show();
                btn_next_page.Show();
            }

            if (btn_FirstPage.Text == btn_prev_page.Text)
            {
                btn_FirstPage.Hide();
            }

            if(btn_last_page.Text == btn_next_page.Text)
            {
                btn_last_page.Hide();
            }

            btn_next_page.Text = (current_pag + 1).ToString();
            btn_prev_page.Text = (current_pag - 1).ToString();
            btn_actual_page.Text = (current_pag).ToString();

        }

        private void btn_FirstPage_Click(object sender, EventArgs e)
        {
            current = 0;
            current_pag = 1;
            paginar(Productos_Filtrado);
            btn_actual_page.Text = current_pag.ToString();
        }

        private void btn_prev_page_Click(object sender, EventArgs e)
        {

                current = current - paginador;
                current_pag = (current_pag - 1);
                btn_actual_page.Text = current_pag.ToString();
    
            paginar(Productos_Filtrado);
        }

        private void btn_next_page_Click(object sender, EventArgs e)
        {
            current = current + paginador;
            current_pag = (current_pag + 1);
            btn_actual_page.Text = current_pag.ToString();
            paginar(Productos_Filtrado);
        }

        private void btn_last_page_Click(object sender, EventArgs e)
        {
            current = last_pag + paginador;
            current_pag = last_pag;
            btn_actual_page.Text = current_pag.ToString();
            paginar(Productos_Filtrado);
        }

        private void boxPaginacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            paginador = int.Parse(boxPaginacion.SelectedItem.ToString());
            current = 0;
            last_pag = (total / paginador) + 1;
            paginar(Productos_Filtrado);
        }

        private void boxCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (boxCategorias.SelectedItem != null)
            {
                Categoria seleccionado = ControladorCategorias.GetCategoriaByName(boxCategorias.SelectedItem.ToString());
                filtro.Categoria = seleccionado;
                lblCat.Text = seleccionado.Nombre;
                filtrar();
            }
        }

        private void boxConsolas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (boxConsolas.SelectedItem != null)
            {
                Consola seleccionado = ControladorConsola.GetConsolaByName(boxConsolas.SelectedItem.ToString());
                filtro.Consola = seleccionado;
                lblCon.Text = seleccionado.Nombre;
                filtrar();
            }
        }

        private void filtrar()
        {

            if (filtro.Nombre != null)
            {
                Productos_Filtrado = Productos_Completo.Where(x => x.Nombre.ToLower().Contains(filtro.Nombre)).ToList();
                vaciarCombos();
                llenarCombos();

            }

            if (filtro.Categoria != null)
            {
                Productos_Filtrado = Productos_Filtrado.Where(x => x.Categoria == filtro.Categoria).ToList();
                
            }



            if (filtro.Consola != null)
            {
                Productos_Filtrado = Productos_Filtrado.Where(x => x.Consola == filtro.Consola).ToList();
                
            }

            if(filtro.Vista != false)
            {
                Productos_Filtrado = Productos_Filtrado.Where(x => x.Vista == filtro.Vista).ToList();
            }
 
            total = Productos_Filtrado.Count();
            last_pag = (total / paginador) + 1;
            current = 0;
            current_pag = 1;

            paginar(Productos_Filtrado);

        }

    

        private void btnVaciarFiltros_Click(object sender, EventArgs e)
        {
            boxCategorias.SelectedItem = null;
            boxConsolas.SelectedItem = null;
            filtroNombre.Text = null;
            comboBox1.Text = null;
            
            filtro.Nombre = null;
            filtro.Categoria = null;
            filtro.Consola = null;

            lblCon.Text = "Consola";
            lblCat.Text = "Categoria";

            Productos_Filtrado = Productos_Completo;

            paginar(Productos_Completo);
            btn_last_page.Show();
            btn_next_page.Show();
        }

        private void filtroNombre_TextChanged(object sender, EventArgs e)
        {
            string nombreFiltrar = filtroNombre.Text.ToString().ToLower();

            if(string.IsNullOrEmpty(filtroNombre.Text))
            {
                filtro.Nombre = null;
            }
            else
            {
                filtro.Nombre = nombreFiltrar;
                filtrar();
            }


        }

        private void NuevoCliente_Click(object sender, EventArgs e)
        {
            FormCliente clientForm = new FormCliente();
            DialogResult dialogResult = clientForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                ControladorClientes.AñadirCliente(clientForm.clienteNuevo);
            }

            VisualizarClientes();
        }

        private void EditarCliente_Click(object sender, EventArgs e)
        {
            if (dataGridViewCte.SelectedRows.Count > 0)
            {
                string idCteEditar = dataGridViewCte.SelectedRows[0].Cells[0].Value.ToString();
                string nombreCteEditar = dataGridViewCte.SelectedRows[0].Cells[1].Value.ToString();
                string apellidoCteEditar = dataGridViewCte.SelectedRows[0].Cells[2].Value.ToString();
                string usuarioCteEditar = dataGridViewCte.SelectedRows[0].Cells[3].Value.ToString();
                string emailCteEditar = dataGridViewCte.SelectedRows[0].Cells[4].Value.ToString();
                string vistaCteEditar = dataGridViewCte.SelectedRows[0].Cells[5].Value.ToString();

                Cliente cteEditar = new Cliente()
                {
                    Id = int.Parse(idCteEditar),
                    Nombre = nombreCteEditar,
                    Apellido = apellidoCteEditar,
                    NUsuario = usuarioCteEditar,
                    Email = emailCteEditar,
                    Vista = bool.Parse(vistaCteEditar)
                };

                FormCliente formCliente = new FormCliente(cteEditar);
                DialogResult dialogResult = formCliente.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    ControladorClientes.ActualizarCliente(int.Parse(idCteEditar), formCliente.clienteNuevo);
                    VisualizarClientes();

                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar una cliente para Editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void EliminarCliente_Click(object sender, EventArgs e)
        {
            if (dataGridViewCte.SelectedRows.Count > 0)
            {
                string idCteEliminar = dataGridViewCte.SelectedRows[0].Cells[0].Value.ToString();
                ControladorClientes.EliminarCliente(int.Parse(idCteEliminar));
                VisualizarClientes();

            }
            else
            {
                MessageBox.Show("Debes seleccionar un producto para Eliminar", "Error", MessageBoxButtons.OK);
            }
        }


        private void buttonNuevoConDB_Click(object sender, EventArgs e)
        {

            FormConsola conForm = new FormConsola();
            DialogResult dialogResult = conForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                ControladorConsola.AñadirConsolaDB(conForm.consolaNueva);
                MessageBox.Show("Se agrego correctamente");


                VisualizarCategorias();
                visualizarConDB();

                vaciarCombos();
                llenarCombos();
            }

        }

        private void dataGridViewCon2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridViewCon2.Columns[e.ColumnIndex].Name == "Eliminar_Con")
            {
                if (MessageBox.Show("Seguro que desea eliminar el registro?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    ControladorConsola.EliminarConsolaDB(int.Parse(dataGridViewCon2.Rows[e.RowIndex].Cells[2].Value.ToString()));
                visualizarConDB();
            }


            if (dataGridViewCon2.Columns[e.ColumnIndex].Name == "Editar_Con")
            {
                //MessageBox.Show(dataGridViewCon2.Rows[e.RowIndex].Cells[2].Value.ToString());

                //lo que tiraba error que solicitabamos la ubicacion de la celda y traia eso, nos faltaba agregarle Value para el valor

                //guarda el id que trae como valor de la celda
                int idConEditar = int.Parse(dataGridViewCon2.Rows[e.RowIndex].Cells[2].Value.ToString());

                //string nombreConEditar = dataGridViewCon.SelectedRows[0].Cells[1].Value.ToString();

                //traer los datos de esta consola desde la base de datos
                Consola conEditar = ControladorConsola.GetOne(idConEditar);

                //se pasa la consola x parametro
                FormConsola formConsola = new FormConsola(conEditar);
                DialogResult dialogResult = formConsola.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    //actualiza consolas DB
                    ControladorConsola.ActualizarConsolaDB(idConEditar, formConsola.consolaNueva);

                    vaciarCombos();
                    llenarCombos();

                }
                VisualizarCategorias();
                //visualizar consolas DB
                visualizarConDB();
            }

        }


    }
}
