/*
 * Created by SharpDevelop.
 * User: Ismae
 * Date: 14/05/2024
 * Time: 12:05 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoTAP
{
	/// <summary>
	/// Description of FrmJuegos.
	/// </summary>
	public partial class FrmJuegos : Form
	{
		ConexionDB conexion = new ConexionDB();
		public FrmJuegos()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			dgvJuego.DataSource = conexion.cargarDatos("Select cod_producto, tipo_pieza, nombre, Descripcion, precio, ruta from productos"+
			                                          "	WHERE tipo_pieza = 'Juego'");
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		DataGridViewRow renglonSeleccionado;
		
		void DgvJuegoCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			foreach(DataGridViewRow renglon in dgvJuego.Rows){
				renglon.Selected = false;
			}
			dgvJuego.Rows[e.RowIndex].Selected= true;
			renglonSeleccionado = dgvJuego.Rows[e.RowIndex];
			tbxDescripcionJuego.Text=renglonSeleccionado.Cells["Descripcion"].Value.ToString();
			
			int codJuego = Convert.ToInt32(renglonSeleccionado.Cells["cod_producto"].Value.ToString());
			string ruta = renglonSeleccionado.Cells["ruta"].Value.ToString();
			ruta = conexion.rutaDeMiUsuario(ruta, "carlos");
			
			pbJuego.Image = Image.FromFile(ruta);			
		}
	}
}