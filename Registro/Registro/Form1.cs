using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
            IniciarDatos();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(validar());
        }

        private void IniciarDatos() 
        {
            cbRango.SelectedIndex = 0;
            cbTipoDocumento.SelectedIndex = 0;
        }

        /// <summary>
        /// Metodo para validar los campos del formulario.
        /// </summary>
        /// <returns></returns>
        private string validar()
        {
            //Valida el nombre
            if (string.IsNullOrEmpty(txtNombre.Text))
                return "Error: El campo NOMBRE no puede estar vacío.";

            //Valida que el tipo de documento no este vacío
            if (cbTipoDocumento.SelectedItem == null)
                return "Error: El campo TIPO DE DOCUMENTO no puede estar vacío y debe ser uno de los valores de la lista.";

            //Valida el el numero de documento
            if (string.IsNullOrEmpty(txtNroDocumento.Text) || !IsNumber(txtNroDocumento.Text))
                return "Error: El campo NÚMERO DE DOCUMENTO no puede estar vacío y debe ser numerico.";
            else if (Int64.Parse(txtNroDocumento.Text) < 0)
                return "Error: El campo NÚMERO DE DOCUMENTO debe ser mayor a cero.";

            //Valida el valida el numero de documento cuando es NUIP
            if (cbTipoDocumento.SelectedItem.ToString() == "NUIP" &&
                (Int64.Parse(txtNroDocumento.Text) < 1000000000 || Int64.Parse(txtNroDocumento.Text) > 9999999999))
                return "Error: Para el tipo de documento NUIP solo se puede ingresar un NÚMERO DE DOCUMENTO entre 1000000000 y 9999999999";

            //Valida el RANGO
            if (cbRango.SelectedItem == null)
                return "Error: El campo RANGO no puede estar vacío  y debe ser uno de los valores de la lista.";

            //Valida el Costo
            if (string.IsNullOrEmpty(txtCostoServicio.Text) || !IsNumber(txtCostoServicio.Text))
                return "Error: El campo COSTO SERVICIO no puede estar vacío y debe ser numerico.";
            else if (int.Parse(txtCostoServicio.Text) <= 0)
                return "Error: El campo COSTO SERVICIO debe ser igual o mayor a cero.";

            //Si Todo esta bien Retorna un mensaje Exitoso de validación
            return "Validación exitosa";
        }

        /// <summary>
        /// Valida si el parametro de entrada es numerico o no y retorna True o False debendiendo del resultado
        /// </summary>
        /// <param name="inputvalue"></param>
        /// <returns></returns>
        public bool IsNumber(string inputvalue)
        {
            Regex isnumber = new Regex("[^0-9]");
            return !isnumber.IsMatch(inputvalue);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcularPago_Click(object sender, EventArgs e)
        {
            if (validar() != "Validación exitosa")
            {
                MessageBox.Show(validar());
                return;
            }

            double CostoBruto = double.Parse(txtCostoServicio.Text);
            double CostoTotal = 0;

            switch (cbRango.SelectedItem.ToString())
            {
                case "A":
                    CostoTotal = CostoBruto * 0.70;
                    break;
                case "B":
                    CostoTotal = CostoBruto * 0.80;
                    break;
                case "C":
                    CostoTotal = CostoBruto * 0.90;
                    break;
                default:
                    CostoTotal = CostoBruto;
                    break;
            }

            MessageBox.Show("El costo total del servicio es: $" + CostoTotal);
        }
    }
}
