﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Informacionpacientemedico : Form
    {
        public Informacionpacientemedico()
        {
            InitializeComponent();
        }

        private void bttregresar_Click(object sender, EventArgs e)
        {
            form5 x = new form5();
            x.Show();
            Hide();
        }

        private void bttguardar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                return;
            }
            string Nombrescompletos = txtnombrescompletos.Text;
            string tipodeIdentificacion = cbxtipodeidentificacion.SelectedItem as string;
            string numerodeindentificacion = mtxtnumerodeIdentificacion.Text;
            string Genero = cbxgenero.SelectedItem as string;
            DateTime fechadenacimiento = dtpfechadenacimiento.Value;
            string edad = mtxtEdad.Text;
            string EstadoCivil = cbxestadocivil.SelectedItem as string;
            string DireccionResidencia = txtdireccion.Text;
            string BarrioResidencia = txtbarrio.Text;
            string TelefonoContacto = mtxtTelefonodecontacto.Text;
            string Ocupacion = cbxocupacion.SelectedItem as string;
            string Nivelescolaridad = cbxnivelescolaridad.SelectedItem as string;
            string Correoeletronico = txtcorreoelectronico.Text;
            string EPS = cbxEps.SelectedItem as string;
            string Regimen = cbxregimen.SelectedItem as string;
            string Tratamientoarealizar = txttratamiento.Text;
            string Antecedentesmedicos = txtantecedentes.Text;
            string Contactoenemergencia = txtcontactoemergencia.Text;
        
        Form2 control = new Form2();
            
        MessageBox.Show("Los datos se han guardado exitosamente");
            }





        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(txtnombrescompletos.Text.Trim()))
            {
                errorMensaje.SetError(txtnombrescompletos, "Por favor ingrese el nombre completo");
                return false;
            }
            else
            {
                errorMensaje.SetError(txtnombrescompletos, null);
            }


            if (cbxtipodeidentificacion.SelectedItem == null)
            {
                errorMensaje.SetError(cbxtipodeidentificacion, "Por favor seleccione el tipo de identificación");
                return false;
            }
            else
            {
                errorMensaje.SetError(cbxtipodeidentificacion, null);
            }

            if (string.IsNullOrEmpty(mtxtnumerodeIdentificacion.Text.Trim()))
            {
                errorMensaje.SetError(mtxtnumerodeIdentificacion, "Por favor ingrese el número de identificación");
                return false;
            }
            else
            {
                errorMensaje.SetError(mtxtnumerodeIdentificacion, null);
            }

            if (cbxgenero.SelectedItem == null)
            {
                errorMensaje.SetError(cbxgenero, "Por favor seleccione el genero");
                return false;
            }
            else
            {
                errorMensaje.SetError(cbxgenero, null);
            }
            DateTime fechaNacimiento = dtpfechadenacimiento.Value;
            if (fechaNacimiento > DateTime.Now)
            {
                errorMensaje.SetError(dtpfechadenacimiento, "La fecha de nacimiento no debe ser mayor a la fecha del sistema");
                return false;
            }
            else
            {
                errorMensaje.SetError(dtpfechadenacimiento, null);
            }

            if (string.IsNullOrEmpty(mtxtEdad.Text.Trim()))
            {
                errorMensaje.SetError(mtxtEdad, "Por favor ingrese la edad");
                return false;
            }
            else
            {
                errorMensaje.SetError(mtxtEdad, null);
            }

            if (cbxestadocivil.SelectedItem == null)
            {
                errorMensaje.SetError(cbxestadocivil, "Por favor seleccione el estado civil");
                return false;
            }
            else
            {
                errorMensaje.SetError(cbxestadocivil, null);
            }

            if (string.IsNullOrEmpty(txtdireccion.Text.Trim()))
            {
                errorMensaje.SetError(txtdireccion, "Por favor ingrese la dirección de residencia");
                return false;
            }
            else
            {
                errorMensaje.SetError(txtdireccion, null);
            }

            if (string.IsNullOrEmpty(txtbarrio.Text.Trim()))
            {
                errorMensaje.SetError(txtbarrio, "Por favor ingrese el barrio de residencia");
                return false;
            }
            else
            {
                errorMensaje.SetError(txtbarrio, null);
            }

            if (string.IsNullOrEmpty(mtxtTelefonodecontacto.Text.Trim()))
            {
                errorMensaje.SetError(mtxtTelefonodecontacto, "Por favor ingrese telefono de contacto");
                return false;
            }
            else
            {
                errorMensaje.SetError(mtxtTelefonodecontacto, null);
            }
            if (string.IsNullOrEmpty(cbxocupacion.Text.Trim()))
            {
                errorMensaje.SetError(cbxocupacion, "Por favor ingrese la ocupación");
                return false;
            }
            else
            {
                errorMensaje.SetError(cbxocupacion, null);
            }

            if (cbxnivelescolaridad.SelectedItem == null)
            {
                errorMensaje.SetError(cbxnivelescolaridad, "Por favor seleccione el nivel de escolaridad");
                return false;
            }
            else
            {
                errorMensaje.SetError(cbxnivelescolaridad, null);
            }


            if (string.IsNullOrEmpty(txtcorreoelectronico.Text.Trim()))
            {
                errorMensaje.SetError(txtcorreoelectronico, "Por favor ingrese correo electronico");
                return false;
            }
            else
            {
                errorMensaje.SetError(txtcorreoelectronico, null);
            }

            if (string.IsNullOrEmpty(cbxEps.Text.Trim()))
            {
                errorMensaje.SetError(cbxEps, "Por favor ingrese la EPS");
                return false;
            }
            else
            {
                errorMensaje.SetError(cbxEps, null);
            }

            if (cbxregimen.SelectedItem == null)
            {
                errorMensaje.SetError(cbxregimen, "Por favor seleccione el regimen");
                return false;
            }
            else
            {
                errorMensaje.SetError(cbxregimen, null);
            }
            if (string.IsNullOrEmpty(txttratamiento.Text.Trim()))
            {
                errorMensaje.SetError(txttratamiento, "Por favor ingrese el tratamiento");
                return false;
            }
            else
            {
                errorMensaje.SetError(txttratamiento, null);
            }
            if (string.IsNullOrEmpty(txtantecedentes.Text.Trim()))
            {
                errorMensaje.SetError(txtantecedentes, "Por favor ingrese los antecedentes medicos");
                return false;
            }
            else
            {
                errorMensaje.SetError(txtantecedentes, null);
            }
            return true;
        }

        private void txtnombrescompletos_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxtipodeidentificacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txttelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxnivelescolaridad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbltratamiento_Click(object sender, EventArgs e)
        {

        }

        private void cbxregimen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblestadocivil_Click(object sender, EventArgs e)
        {

        }

        private void cbxestadocivil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
   

        }
    

