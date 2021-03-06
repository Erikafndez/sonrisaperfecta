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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void bttRegresar_Click(object sender, EventArgs e)
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
            string Nombrescompletos = txtNombres.Text;
            string numerodeindentificacion = mtxtnumerodeidentificacion.Text;
            string TelefonoContacto = mtxtTelefono.Text;
            DateTime fechacita = dtpFechacita.Value;
            string Horacita = txtHoracita.Text;
            string Procedimiento = cbxprocedimiento.Text;

            Form2 control = new Form2();


            MessageBox.Show("Los datos se han guardado exitosamente");
        }
                          



        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(txtNombres.Text.Trim()))
            {
                errorMensaje.SetError(txtNombres, "Por favor ingrese nombre completo");
                return false;
            }
            else
            {
                errorMensaje.SetError(txtNombres, null);
            }


            if (string.IsNullOrEmpty(mtxtnumerodeidentificacion.Text.Trim()))
            {
                errorMensaje.SetError(mtxtnumerodeidentificacion, "Por favor ingrese el número de identificación");
                return false;
            }
            else
            {
                errorMensaje.SetError(mtxtnumerodeidentificacion, null);
            }

            if (string.IsNullOrEmpty(mtxtTelefono.Text.Trim()))
            {
                errorMensaje.SetError(mtxtTelefono, "Por favor ingrese el número de teléfono");
                return false;
            }
            else
            {
                errorMensaje.SetError(mtxtTelefono, null);
            }
            DateTime fechacita = dtpFechacita.Value;
            if (fechacita < DateTime.Now)
            {
                errorMensaje.SetError(dtpFechacita, "Por favor ingrese la fecha de la cita");
                return false;
            }
            else
            {
                errorMensaje.SetError(dtpFechacita, null);
            }
            if (string.IsNullOrEmpty(txtHoracita.Text.Trim()))
            {
                errorMensaje.SetError(txtHoracita, "Por favor ingrese la hora de la cita");
                return false;
            }
            else
            {
                errorMensaje.SetError(txtHoracita, null);

            }
            if (string.IsNullOrEmpty(cbxprocedimiento.Text.Trim()))
            {
                errorMensaje.SetError(cbxprocedimiento, "Por favor ingrese el procedimiento a realizar");
                return false;
            }
            else
            {
                errorMensaje.SetError(cbxprocedimiento, null);

            }
            return true;
        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNombres_Click(object sender, EventArgs e)
        {

        }

        private void txtHoracita_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblHoracita_Click(object sender, EventArgs e)
        {

        }

        private void dtpFechacita_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblFechacita_Click(object sender, EventArgs e)
        {

        }

        private void txtProcedimiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblProcedimiento_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTelefono_Click(object sender, EventArgs e)
        {

        }

        private void txtIdentificacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblIdentificacion_Click(object sender, EventArgs e)
        {

        }
    }
}