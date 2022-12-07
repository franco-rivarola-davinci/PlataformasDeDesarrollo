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

    
    public partial class FormValidarVenta : Form
    {
        public string nombreV = Login.usuario;
        public string pwV = Login.pw;
        public Venta ventaNueva;
        public string empleado;
        public string cliente;
        public int stockk;

        public FormValidarVenta()
        {
            InitializeComponent();

            controladorUsuarios.IniciarRepositorio();
            ControladorClientes.IniciarRepositorio();
            ControladorProductos.IniciarRepositorio();
            ControladorVentas.IniciarRepositorio();

            limpiarErrores();
            llenarBox();

            txtID.Text = (ControladorVentas.lastId + 1).ToString();
            boxClientes.Text = "consumidor final";
            txtVendedor.Text = nombreV.ToString();
        }

        private void limpiarErrores()
        {
     
            errPw.Text = "";

   
            errPw.Hide();

        }

        private void llenarBox()
        {
            List<Cliente> listCte = new List<Cliente>();
            listCte = ControladorClientes.Clientes.Where(x => x.Id != 0).ToList();
            llenarBoxClientes(listCte);

        }

        private void llenarBoxClientes(List<Cliente> listaClientes)
        {
            foreach (Cliente cte in listaClientes)
            {
                if (cte.Vista == true)
                {
                    boxClientes.Items.Add(cte.NUsuario);
                }
            }
        }



        private void btnFinalCompra_Click(object sender, EventArgs e)
        {
            bool ventaValidada = ValidarVenta(out bool errorMsg);

            if (ventaValidada)
            {
                cliente = boxClientes.Text;
                empleado = txtVendedor.Text;
                stockk = int.Parse(txtID.Text);

                // descontarStock(cantStock);
                MessageBox.Show("Su venta se a realizado con éxito");
                this.DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarVenta(out bool errorMsg)
        {
            errorMsg = true;


                    if (txtPw.Text !=pwV )
                    {
                        string error = "Contraseña incorrecta";
                        errPw.Text = error;
                        errPw.Show();
                        errorMsg = false;

                    }
                    else
                    {
                        errPw.Hide();
                    }

            return errorMsg;
        }

    }
}