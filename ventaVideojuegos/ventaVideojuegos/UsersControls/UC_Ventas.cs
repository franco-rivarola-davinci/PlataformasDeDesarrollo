using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ventaVideojuegos;
using ventaVideojuegos.Controlers;
using ventaVideojuegos.Modelo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ventaVideojuegos.UsersControls
{
    public partial class UC_Ventas : UserControl
    {

       public FormValidarVenta datos;
        public Venta ventaNueva;
        public VentaUnificada ventaUnueva;
        public static string NombreProdComprar;
        public static string PrecioProdComprar;
        public static string StockProdComprar;
        public static int precioParcial;
        public static int precioVenta = 0;
        public static int restar;




        public UC_Ventas()
        {
            InitializeComponent();
            ControladorVentas.IniciarRepositorio();
            ControladorVentaUnificada.IniciarRepositorio();
            lblValor.Text = precioVenta.ToString();
            VisualizarVentas();
        }

       public void descontarStock(int cantStock, string nameProd)
       {
           Producto auxiliar = ControladorProductos.GetProductoByName(nameProd);
           if (auxiliar.Stock > cantStock)
           {
               auxiliar.Stock = auxiliar.Stock - cantStock;
               ControladorProductos.ActualizarProductos(auxiliar.Id, auxiliar);
           }

       }

        public void generarPDF(Venta venta)
        {
            List<Venta> lista = ControladorVentas.GetVentaById(venta.Id);
            int total = 0;
           

            //ruta y nombre  //a esta ruta cambiarla segun el usuario
            System.IO.FileStream fs = new FileStream( Environment.CurrentDirectory + @"\Facturas\" + "Factura_" + venta.Id + ".pdf", FileMode.Create );
            

            // tamaño del pdf
            Document document = new Document(PageSize.A4, 25, 25, 30, 30);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);

            // metadata
            document.AddAuthor("K Racer");
            document.AddTitle("Factura_" + venta.Id);

            document.Open();
            // escribimos en el pdf

            document.Add(new Paragraph(DateTime.Now.ToString()));
            // Texto hardcode con el nombre de la empresa
            document.Add(new Paragraph("K Racer - CUIT : 302202929910"));

            //NUMERO DE VENTA
            document.Add(new Paragraph("Factura: " + venta.Id));
            //cliente
            document.Add(new Paragraph("Cliente: " + venta.nombreCliente));

            document.Add(new Paragraph("Conceptos: "));
            //foearch de los productos en la venta:

            foreach (Venta v in lista)
            {
                document.Add(new Paragraph(v.nombreProducto + " : " + "     " +"Valor unitario: "+v.precioProducto+"   "+"Cantidad: "+v.cantidadProducto+"   "+"Valor Total: "+v.valorTotal));
                total += v.valorTotal;
            }

            document.Add(new Paragraph("total: " + "     "+total /*el total*/));

            document.Close();
            writer.Close();
            fs.Close();

        }

        private void VisualizarVentas()
        {
            dataGridViewCVentas.Rows.Clear();
            foreach (VentaUnificada vtaU in ControladorVentaUnificada.VentasUnificadas)
            {

                int rowIndex = dataGridViewCVentas.Rows.Add();
                dataGridViewCVentas.Rows[rowIndex].Cells[0].Value = vtaU.Id.ToString();
                dataGridViewCVentas.Rows[rowIndex].Cells[1].Value = vtaU.nombreEmpleado.ToString();
                dataGridViewCVentas.Rows[rowIndex].Cells[2].Value = vtaU.nombreCliente.ToString();
                dataGridViewCVentas.Rows[rowIndex].Cells[3].Value = vtaU.valorTotal.ToString();
                dataGridViewCVentas.Rows[rowIndex].Cells[4].Value = vtaU.DateTime.ToString();

            }
        }

        private void btnVaciarCarrito_Click_1(object sender, EventArgs e)
        {
            precioVenta = 0;
            lblValor.Text = precioVenta.ToString();
            dataGridView1.Rows.Clear();
        }

        private void btnQuitarProducto_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int precioDescontar = int.Parse(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());

                precioVenta = precioVenta - precioDescontar;
                lblValor.Text = precioVenta.ToString();

                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

            }
            else
            {
                MessageBox.Show("Debes seleccionar un producto para quitar del carrito", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnAñadir_Click_1(object sender, EventArgs e)
        {

            SeleccionarProducto formSelecProd = new SeleccionarProducto();
            DialogResult dialogResult = formSelecProd.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                int rowIndex = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowIndex].Cells[0].Value = SeleccionarProducto.NombreProdComprar.ToString();
                dataGridView1.Rows[rowIndex].Cells[1].Value = SeleccionarProducto.PrecioProdComprar.ToString();
                dataGridView1.Rows[rowIndex].Cells[2].Value = SeleccionarProducto.StockProdComprar.ToString();
                precioParcial = int.Parse(SeleccionarProducto.StockProdComprar) * int.Parse(SeleccionarProducto.PrecioProdComprar);
                dataGridView1.Rows[rowIndex].Cells[3].Value = precioParcial.ToString();


                NombreProdComprar = SeleccionarProducto.NombreProdComprar.ToString();
                PrecioProdComprar = SeleccionarProducto.StockProdComprar.ToString();
                StockProdComprar = SeleccionarProducto.PrecioProdComprar.ToString();

                precioVenta = precioVenta + precioParcial;

                lblValor.Text = precioVenta.ToString();

            }
        }

        private void editarCant_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int cantidadVtaAnterior = int.Parse(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
                FormVenta formEditVenta = new FormVenta(cantidadVtaAnterior);

                DialogResult dialogResult = formEditVenta.ShowDialog();

                int precioVtaAnterior = int.Parse(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());


                if (dialogResult == DialogResult.OK)
                {

                    string editStockProdComprar = formEditVenta.cantStock.ToString();

                    dataGridView1.SelectedRows[0].Cells[0].Value = SeleccionarProducto.NombreProdComprar.ToString();
                    dataGridView1.SelectedRows[0].Cells[1].Value = SeleccionarProducto.PrecioProdComprar.ToString();
                    dataGridView1.SelectedRows[0].Cells[2].Value = editStockProdComprar.ToString();
                    precioParcial = int.Parse(editStockProdComprar) * int.Parse(SeleccionarProducto.PrecioProdComprar);
                    dataGridView1.SelectedRows[0].Cells[3].Value = precioParcial.ToString();


                    NombreProdComprar = SeleccionarProducto.NombreProdComprar.ToString();
                    PrecioProdComprar = SeleccionarProducto.StockProdComprar.ToString();
                    StockProdComprar = editStockProdComprar.ToString();

                    precioVenta = precioVenta - precioVtaAnterior;
                    precioVenta = precioVenta + precioParcial;

                    lblValor.Text = precioVenta.ToString();


                }

            }
            else
            {
                MessageBox.Show("Debes seleccionar un producto editar", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnFinalizarCompra_Click_1(object sender, EventArgs e)
        {

            dataGridView1.AllowUserToAddRows = false;

            if (dataGridView1.Rows.Count > 0)
            {
                FormValidarVenta formVenta = new FormValidarVenta();
                DialogResult dialogResult = formVenta.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {

                    ventaUnueva = new VentaUnificada
                    {
                        Id = formVenta.stockk,
                        nombreCliente = formVenta.cliente,
                        nombreEmpleado = formVenta.empleado,
                        valorTotal = precioVenta,
                        DateTime = DateTime.Now,
                    };

                    ControladorVentaUnificada.AñadirVentaUnificada(ventaUnueva);

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        ventaNueva = new Venta
                        {
                            Id = formVenta.stockk,
                            nombreCliente = formVenta.cliente,
                            nombreEmpleado = formVenta.empleado,
                            nombreProducto = row.Cells["Producto"].Value.ToString(),
                            precioProducto = int.Parse(row.Cells["Precio"].Value.ToString()),
                            cantidadProducto = int.Parse(row.Cells["Cantidad"].Value.ToString()),
                            valorTotal = int.Parse(row.Cells["Total"].Value.ToString()),
                            DateTime = DateTime.Now,

                        };
                        ControladorVentas.AñadirVenta(ventaNueva);
                        descontarStock(int.Parse(row.Cells["Cantidad"].Value.ToString()), row.Cells["Producto"].Value.ToString());

                    }

                    precioVenta = 0;
                    lblValor.Text = precioVenta.ToString();
                    dataGridView1.Rows.Clear();
                    dataGridView1.AllowUserToAddRows = true;

                }
                generarPDF(ventaNueva);
            }
            else
            {
                MessageBox.Show("El carrito se encuentra vacío", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnVerDetalles_Click(object sender, EventArgs e)
        {

            if (dataGridViewCVentas.SelectedRows.Count == 1)
            {
                int idVentaU = int.Parse(dataGridViewCVentas.SelectedRows[0].Cells[0].Value.ToString());

                VerDetalles formVerDetalles = new VerDetalles(idVentaU);
                DialogResult dialogResult = formVerDetalles.ShowDialog();



            }
            else
            {
                MessageBox.Show("Debes seleccionar una venta para ver sus detalles", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
            
