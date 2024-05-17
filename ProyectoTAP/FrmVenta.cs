/*
 * Created by SharpDevelop.
 * User: Ismae
 * Date: 15/05/2024
 * Time: 08:46 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Paso_de_datos
{
	/// <summary>
	/// Description of Venta.
	/// </summary>
	public partial class Venta : Form
	{
		public Venta()
	    {
	        InitializeComponent();
	        // Agregar las columnas al DataGridView
	        dataGridView1.Columns.Add("id", "id");
	        dataGridView1.Columns.Add("Nombre", "Nombre");
	        dataGridView1.Columns.Add("Costo", "Costo");
	    }
	
	    public void CargarDatosVenta(int id, string nombre, decimal costo)
        {
            dataGridView1.Rows.Add(id, nombre, costo);
            CalcularTotal();
        }
	    
	    public void CalcularTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                total += Convert.ToDecimal(fila.Cells["Costo"].Value);
            }
            Total.Text = total.ToString();
        }
		
		public void PagarClick(object sender, EventArgs e)
		{
			decimal total = 0;
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                total += Convert.ToDecimal(fila.Cells["Costo"].Value);
            }

            decimal cantidadPagada;
            if (decimal.TryParse(Dinero.Text, out cantidadPagada))
            {
                decimal cambio = cantidadPagada - total;
                Cambio.Text = cambio.ToString();
            }
            else
            {
                Cambio.Text = "";
            }
		}
	}
}