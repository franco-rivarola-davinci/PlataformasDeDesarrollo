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
using Microsoft.Win32;
using ventaVideojuegos;
using ventaVideojuegos.Modelo;

namespace ventaVideojuegos
{
    public partial class Login : Form
    {
        

        public static string usuario = "";
        public static string pw = "";
        public static bool esAdm=false;
        public Login()
        {

            InitializeComponent();
            limpiarErrores();

        }


        private void limpiarErrores()
        {
            errLogin.Text = "";
            errLogin.Hide();
        }

        private void bttnAcceder_Click_1(object sender, EventArgs e)
        {

            bool usuarioValidado = ValidarUsuario(out bool errorMsg);

            if (usuarioValidado)
            {
                bool valido = false;

                if (!File.Exists("usuarios.txt"))
                {
                    StreamWriter archivo = new StreamWriter("usuarios.txt");
                    archivo.Close();
                }
                else
                {


                    StreamReader archivo = new StreamReader("usuarios.txt");
                    while (!archivo.EndOfStream)
                    {
                        string usuario = archivo.ReadLine();
                        string[] datos = usuario.Split(',');

                        if (datos[1].Equals(txtUsuarioLogin.Text) && datos[2].Equals(txtContrasenaLogin.Text))
                        {
                            usuario = txtUsuarioLogin.Text;
                            pw = txtContrasenaLogin.Text;
                            esAdm = bool.Parse(datos[3]);
                            valido = true;


                        }

                    }

                    archivo.Close();
                }


                    if (valido)
                    {
                        usuario = txtUsuarioLogin.Text;
                        this.Hide();
                        Form1 form = new Form1();
                        form.Show();


                    }
                    else
                    {
                        string error = "Credenciales invalidas";
                        errLogin.Text = error;
                        errLogin.Show();
                    }
                
            }
            
        }


        private void txtUsuarioLogin_TextChanged(object sender, EventArgs e)
        {

        }
        private bool ValidarUsuario(out bool errorMsg)
        {
            errorMsg = true;

            if (string.IsNullOrEmpty(txtUsuarioLogin.Text) && string.IsNullOrEmpty(txtContrasenaLogin.Text))
            {
                string error = "Debe ingresar usuario y contraseña";
                errLogin.Text = error;
                errLogin.Show();
                errorMsg = false;
            }
            else if (string.IsNullOrEmpty(txtUsuarioLogin.Text))
            {
                string error = "Debe ingresar el usuario";
                errLogin.Text = error;
                errLogin.Show();
                errorMsg = false;
            }
            else if (string.IsNullOrEmpty(txtContrasenaLogin.Text))
            {
                string error = "Debe ingresar la contraseña";
                errLogin.Text = error;
                errLogin.Show();
                errorMsg = false;
            }
            else
            {
                errLogin.Hide();
            }

            /*if (txtContrasenaLogin.Text)
            {
                string error = "Debe ingresar el usuario";
                errLogin.Text = error;
                errLogin.Show();
                errorMsg = false;
            }
            else
            {
                errLogin.Hide();
            }*/


            return errorMsg;
        }
    }
}