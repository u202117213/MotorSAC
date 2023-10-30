using MotorSAC.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace MotorSAC
{
    public class Rutinas
    {
        public ComboBox Llena_combo_distritos(ComboBox cbDist)
        {
            List <string> Dist = new List <string> ()
            { "Ancón","Ate","Barranco","Breña","Carabayllo",
                "Cercado de Lima","Chaclacayo","Chorrillos","Cieneguilla",
                "Comas","El Agustino","Independencia","Jesús María",
                "La Molina","La Victoria"};

            for (int i = 0; i < Dist.Count; i++) 
            {
                cbDist.Items.Add(Dist[i]);
            }

            return cbDist;
                        
        }

        public ComboBox Llena_combo_categorias(ComboBox cbCateg)
        {
            List<string> Categ = new List<string>()
            { "Deportivo", "SUV", "Camioneta"};

            for (int i = 0; i < Categ.Count; i++)
            {
                cbCateg.Items.Add(Categ[i]);
            }

            return cbCateg;

        }

        public ComboBox Llena_combo_Sede_Ventas(ComboBox cbsedeventas, List<sedeBE> lista_sedes)
        {   
            cbsedeventas.Items.Clear();
            List<string> sedes = new List<string>();
            
            for (int i = 0; i < lista_sedes.Count; i++)
            {
                cbsedeventas.Items.Add(lista_sedes[i].id_codigo_sede.ToString() + " - " + lista_sedes[i].nombre_sede.ToString() + " - " + lista_sedes[i].distrito_sede).ToString();
            }

            return cbsedeventas;

        }

        public ComboBox Llena_combo_Auto_Ventas(ComboBox cbautoventas, List<autoBE> lista_autos)
        {
            cbautoventas.Items.Clear();
            List<string> autos = new List<string>();

            for (int i = 0; i < lista_autos.Count; i++)
            {
                if (lista_autos[i].id_codigo_sede==0)
                {
                    cbautoventas.Items.Add(lista_autos[i].id_codigo_auto.ToString() + " - " + lista_autos[i].nombre_auto.ToString() + " - " + lista_autos[i].categoria_auto.ToString());
                }
                
            }

            return cbautoventas;

        }

        public void Registra_auto(autoBE auto, List<autoBE> autos)
        {
            int indice = autos.Count()+1;
            auto.id_codigo_auto = indice;
            auto.monto = 0.00M;
            auto.id_codigo_sede = 0;
            autos.Add(auto);

        }

        public void Registra_sede(sedeBE sede, List<sedeBE> sedes) 
        {
            int indice = sedes.Count()+1;
            sede.id_codigo_sede = indice;
            sede.venta_sede = 0.0M;
            sedes.Add(sede);
            
        }

        public ListView Llena_List_View(List<sedeBE> lista_sedes, ListView lisview)
        {
            lisview.Items.Clear();

            for (int i = 0;i < lista_sedes.Count;i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = lista_sedes[i].id_codigo_sede.ToString();
                item.SubItems.Add(lista_sedes[i].nombre_sede);
                item.SubItems.Add(lista_sedes[i].distrito_sede);
                item.SubItems.Add("0.00");
                lisview.Items.Add(item);

            }
            return lisview;
        }

        public List<decimal> Totales(List<autoBE> lista_autos)
        {
            List<decimal> result = new List<decimal>();
            decimal tventas = 0;
            int tunidades = 0;
            for (int i = 0; i < lista_autos.Count; i++)
            {
                if (lista_autos[i].id_codigo_sede != 0)
                {
                    tventas = tventas + lista_autos[i].monto;
                    tunidades++;
                }

            }
            result.Add(tventas);
            result.Add(tunidades);
            return result;
        }

        public ListView Llena_List_View_Con_Ventas(List<sedeBE> lista_sedes, List<autoBE> lista_autos, ListView lisview)
        {
            lisview.Items.Clear();

            for (int i = 0; i < lista_sedes.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = lista_sedes[i].id_codigo_sede.ToString();
                item.SubItems.Add(lista_sedes[i].nombre_sede);
                item.SubItems.Add(lista_sedes[i].distrito_sede);
                decimal venta = 0;
                for (int j = 0; j < lista_autos.Count; j++)
                {
                    if (lista_autos[j].id_codigo_sede.ToString() == lista_sedes[i].id_codigo_sede.ToString())
                    {
                        venta = venta + lista_autos[j].monto;
                    }
                }
                item.SubItems.Add(venta.ToString());
                lisview.Items.Add(item);

            }
            return lisview;
        }

        public ListView Llena_List_View_Con_Ventas2(List<sedeBE> lista_sedes, List<autoBE> lista_autos, ListView lisview)
        {
            lisview.Items.Clear();

            for (int i = 0; i < lista_autos.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = lista_autos[i].id_codigo_auto.ToString();
                item.SubItems.Add(lista_autos[i].nombre_auto);
                item.SubItems.Add(lista_autos[i].categoria_auto);
                string nomsede = "No Vendido";
                for (int j = 0; j < lista_sedes.Count; j++)
                {
                    if (lista_autos[i].id_codigo_sede.ToString() == lista_sedes[j].id_codigo_sede.ToString())
                    {
                        nomsede = lista_sedes[j].nombre_sede;
                    }
                }
                item.SubItems.Add(nomsede);
                lisview.Items.Add(item);

            }
            return lisview;
        }
              
        public void AsignaVehiculo(string comboauto, string combosede, decimal monto, List<autoBE> lista_autos)
        {
            
            string id_auto = comboauto.Split('-')[0].Trim();
            string str_sede = combosede.Split('-')[0].Trim();
            int id_sede;
            int.TryParse(str_sede, out id_sede);
            for (int i = 0;i < lista_autos.Count;i++)
            {
                if (lista_autos[i].id_codigo_auto.ToString() == id_auto)
                {
                    lista_autos[i].id_codigo_sede = id_sede;
                    lista_autos[i].monto = monto;
                }
            }

        }

        


    }
}
