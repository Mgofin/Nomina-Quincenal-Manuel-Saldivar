namespace NOMINA_QUINCENAL
{
    public partial class Form1 : Form
    {
        const int HORAS_REGULARES = 88;
        const double FACTOR_EXTRA = 1.35;
        const double INCENTIVO = 1500;
        const double AFP = 0.0287;
        const double SFS = 0.0304;

        int empleados = 0;
        double totalBruto = 0;
        double totalDeducciones = 0;
        double totalNeto = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtHoras.Clear();

            rdbFijo.Checked = false;
            rdbTemporal.Checked = false;

            cmbCargo.SelectedIndex = -1;

            chkTransporte.Checked = false;

            txtNombre.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCargo.Items.Add("Auxiliar");
            cmbCargo.Items.Add("Técnico");
            cmbCargo.Items.Add("Supervisor");
            cmbCargo.Items.Add("Gerente");

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el nombre del empleado");
                txtNombre.Focus();
                return;
            }
            if (!rdbFijo.Checked && !rdbTemporal.Checked)
            {
                MessageBox.Show("Seleccione un contrato");
                return;
            }
            if (cmbCargo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un cargo");
                return;
            }
            int horas;

            if (!int.TryParse(txtHoras.Text, out horas) || horas < 1 || horas > 120)
            {
                MessageBox.Show("Ingrese horas válidas entre 1 y 120");
                txtHoras.Focus();
                return;
            }
            double tarifa = 0;

            switch (cmbCargo.Text)
            {
                case "Auxiliar":
                    tarifa = 180;
                    break;

                case "Técnico":
                    tarifa = 250;
                    break;

                case "Supervisor":
                    tarifa = 350;
                    break;

                case "Gerente":
                    tarifa = 500;
                    break;
            }
            double salarioRegular;
            double pagoExtras = 0;

            if (horas <= HORAS_REGULARES)
            {
                salarioRegular = horas * tarifa;
            }
            else
            {
                salarioRegular = HORAS_REGULARES * tarifa;

                int horasExtra = horas - HORAS_REGULARES;

                pagoExtras = horasExtra * tarifa * FACTOR_EXTRA;
            }
            double incentivo = 0;

            if (chkTransporte.Checked)
            {
                incentivo = INCENTIVO;
            }
            double bruto = salarioRegular + pagoExtras + incentivo;

            double deducciones = 0;

            if (rdbFijo.Checked)
            {
                deducciones = (salarioRegular + pagoExtras) * (AFP + SFS);
            }
            double neto = bruto - deducciones;

            lstNomina.Items.Add(
                txtNombre.Text + " - " +
                cmbCargo.Text + " - RD$ " +
                neto.ToString("N2"));

            empleados++;

            totalBruto += bruto;
            totalDeducciones += deducciones;
            totalNeto += neto;

            txtNombre.Clear();
            txtHoras.Clear();

            rdbFijo.Checked = false;
            rdbTemporal.Checked = false;

            cmbCargo.SelectedIndex = -1;

            chkTransporte.Checked = false;

            txtNombre.Focus();
        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            if (empleados == 0)
            {
                MessageBox.Show("No hay empleados registrados");
                return;
            }
            lblEmpleados.Text = empleados.ToString();

            lblBruto.Text = "RD$ " + totalBruto.ToString("N2");

            lblDeducciones.Text = "RD$ " + totalDeducciones.ToString("N2");

            lblNeto.Text = "RD$ " + totalNeto.ToString("N2");
        }
    }
}
