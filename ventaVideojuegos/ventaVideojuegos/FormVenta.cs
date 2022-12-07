using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ventaVideojuegos.Controlers;
using ventaVideojuegos.Modelo;
using ventaVideojuegos.UsersControls;

namespace ventaVideojuegos
{
    public partial class FormVenta : Form
    {
        public UC_Ventas datos;
        public ControladorProductos prodVendido;
        public int cantStock;


        public FormVenta()
        {

            InitializeComponent();
            limpiarErrores();

        }

        public FormVenta(int cantidad)
        {

            InitializeComponent();
            limpiarErrores();
            numCantidad.Text = cantidad.ToString();
        }



        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            bool productoValidado = ValidarProducto(out bool errorMsg);

            if (productoValidado)
            {
                cantStock = int.Parse(numCantidad.Text);
                
               
                bool stockValidado = validarStock(out bool errorMssg);
                if(stockValidado)
                { 
                     this.DialogResult = DialogResult.OK;
                }
            }

        }

        public bool validarStock(out bool errorMssg)
        {
            errorMssg = true;
            Producto auxiliar = ControladorProductos.GetProductoByName(SeleccionarProducto.NombreProdComprar);

            if (auxiliar.Stock < cantStock)
            {

                MessageBox.Show("La cantidad solicitada excede al stock disponible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorMssg = false;

            }

            return errorMssg;

        }

        private void limpiarErrores()
        {
            errCantidad.Text = "";

    
            errCantidad.Hide();


        }
      

        private bool ValidarProducto(out bool errorMsg)
            {
                errorMsg = true;

                if (int.Parse(numCantidad.Text) <= 0)
                {

                    string error = "Debe ingresar la cantidad deseada";
                    errCantidad.Text = error;
                    errCantidad.Show();
                    errorMsg = false;
                }
                else
                {
                    errCantidad.Hide();
                }




            return errorMsg;
            }



        private void numCantidad_ValueChanged(object sender, EventArgs e)
        {

        }


    }
}
     