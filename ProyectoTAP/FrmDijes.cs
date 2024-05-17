/*
 * Created by SharpDevelop.
 * User: Ismae
 * Date: 14/05/2024
 * Time: 12:29 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoTAP
{
	/// <summary>
	/// Description of FrmDije.
	/// </summary>
	public partial class FrmDije : Form
	{
		ConexionDB conexion = new ConexionDB();
		public FrmDije()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			dgvDije.DataSource = conexion.cargarDatos("Select cod_producto, tipo_pieza, nombre, Descripcion, precio, ruta from productos"+
			                                          "	WHERE tipo_pieza = 'Dije'");
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		DataGridViewRow renglonSeleccionado;
		
		void DgvDijeCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			foreach(DataGridViewRow renglon in dgvDije.Rows){
				renglon.Selected = false;
			}
			dgvDije.Rows[e.RowIndex].Selected= true;
			renglonSeleccionado = dgvDije.Rows[e.RowIndex];
			tbxDescripcionDije.Text=renglonSeleccionado.Cells["Descripcion"].Value.ToString();
			
			int codDije = Convert.ToInt32(renglonSeleccionado.Cells["cod_producto"].Value.ToString());
			string ruta = renglonSeleccionado.Cells["ruta"].Value.ToString();
			ruta = conexion.rutaDeMiUsuario(ruta, "carlos");
			
			pbDije.Image = Image.FromFile(ruta);
		}
	}
}
