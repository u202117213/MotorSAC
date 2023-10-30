using MotorSAC.Clases;
using System.Security.Cryptography.X509Certificates;

namespace MotorSAC
{
    public partial class Form1 : Form
    {
        List<sedeBE> sedes = new List<sedeBE>();
        List<autoBE> autos = new List<autoBE>();
        Rutinas metodo = new Rutinas();

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            metodo.Llena_combo_distritos(cbDistritos);
            lvSedes.View = View.Details;
            lvSedes.Columns.Add("Código Sede");
            lvSedes.Columns.Add("Nombre Sede");
            lvSedes.Columns.Add("Distrito Sede");
            lvSedes.Columns.Add("Total Venta");
            lvSedes = metodo.Llena_List_View(sedes, lvSedes);

            metodo.Llena_combo_categorias(cbCateg);
            lvAutos.View = View.Details;
            lvAutos.Columns.Add("Código Auto");
            lvAutos.Columns.Add("Nombre Vehiculo");
            lvAutos.Columns.Add("Categoría");
            lvAutos.Columns.Add("Sede de venta");
            lvAutos = metodo.Llena_List_View_Con_Ventas2(sedes, autos, lvAutos);


        }

        public void btRegistroSede_Click(object sender, EventArgs e)
        {
            if (tbNombreSede.Text.Trim() == "" || cbDistritos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un nombre para la sede y escojer un distrito");
            }
            else
            {
                sedeBE sede = new sedeBE();
                sede.nombre_sede = tbNombreSede.Text;
                sede.distrito_sede = cbDistritos.SelectedItem.ToString().Trim();
                metodo.Registra_sede(sede, sedes);
                MessageBox.Show("Sede registrada correctamente");
                lvSedes = metodo.Llena_List_View_Con_Ventas(sedes, autos, lvSedes);
                tbNombreSede.Text = "";
                cbDistritos.SelectedIndex = -1;
                metodo.Llena_combo_Sede_Ventas(cbSedeVenta, sedes);

            }

        }

        private void btCancelaRegistroSede_Click(object sender, EventArgs e)
        {
            tbNombreSede.Text = "";
            cbDistritos.SelectedIndex = -1;
        }

        private void btRegistrarAuto_Click(object sender, EventArgs e)
        {

            if (tbNombreAuto.Text.Trim() == "" || cbCateg.SelectedIndex == -1)
            {
                MessageBox.Show("Favor Ingrese un nombre para el vehículo y escoja una categoría");
            }
            else
            {
                autoBE auto = new autoBE();
                auto.nombre_auto = tbNombreAuto.Text;
                auto.categoria_auto = cbCateg.SelectedItem.ToString().Trim();
                metodo.Registra_auto(auto, autos);
                MessageBox.Show("Vehículo registrado correctamente");
                lvAutos = metodo.Llena_List_View_Con_Ventas2(sedes, autos, lvAutos);
                tbNombreAuto.Text = "";
                cbCateg.SelectedIndex = -1;
                metodo.Llena_combo_Auto_Ventas(cbAutoVenta, autos);

            }
        }

        private void btCancelaRegistroAuto_Click(object sender, EventArgs e)
        {
            tbNombreAuto.Text = "";
            cbCateg.SelectedIndex = -1;
        }

        private void tbNombreSede_TextChanged(object sender, EventArgs e)
        {

        }

        private void btRegistrarVenta_Click(object sender, EventArgs e)
        {

            decimal monto;

            if (decimal.TryParse(tbVenta.Text, out monto) && monto > 0)
            {
                if (cbSedeVenta.SelectedIndex != -1 && cbAutoVenta.SelectedIndex != -1)
                {
                    metodo.AsignaVehiculo(cbAutoVenta.SelectedItem.ToString(), cbSedeVenta.SelectedItem.ToString(), monto, autos);


                    cbAutoVenta = metodo.Llena_combo_Auto_Ventas(cbAutoVenta, autos);
                    if (cbAutoVenta.Items.Count > 0)
                    {
                        cbAutoVenta.SelectedIndex = 0;
                    }
                    else
                    {
                        cbAutoVenta.Items.Clear();
                        cbAutoVenta.SelectedIndex = -1;
                    }

                    cbSedeVenta.SelectedIndex = -1;
                    lvSedes = metodo.Llena_List_View_Con_Ventas(sedes, autos, lvSedes);
                    lvAutos = metodo.Llena_List_View_Con_Ventas2(sedes, autos, lvAutos);
                    List<decimal> list = new List<decimal>();
                    list = metodo.Totales(autos);
                    lbtv.Text = list[0].ToString();
                    lbtu.Text = list[1].ToString();

                    tbVenta.Text = "";
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una sede y un vehiculo para la asignación de la venta");
                }
            }
            else
            {
                MessageBox.Show("El monto de venta debe ser numérico");
            }


        }

        private void CancelarRegistrarVenta_Click(object sender, EventArgs e)
        {
            tbVenta.Text = "";
            cbAutoVenta.SelectedIndex = -1;
            cbSedeVenta.SelectedIndex = -1;
        }
    }
}