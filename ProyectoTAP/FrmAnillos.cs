/*
 * Created by SharpDevelop.
 * User: gabyp
 * Date: 14/05/2024
 * Time: 9:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace ProyectoTAP
{
	/// <summary>
	/// Description of FrmAnillos.
	/// </summary>
	public partial class FrmAnillos : Form
	{
		ConexionDB conexion = new ConexionDB();
		public FrmAnillos()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			dgvAnillos.DataSource=conexion.cargarDatos("Select cod_producto, tipo_pieza, nombre, Descripcion, precio, ruta from productos");
			dgvAnillos.Columns[5].Visible = false;
			this.WindowState = FormWindowState.Maximized;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		DataGridViewRow renglonSeleccionado;
		
		
		void DgvAnillosCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			foreach(DataGridViewRow renglon in dgvAnillos.Rows){
				renglon.Selected = false;
			}
			dgvAnillos.Rows[e.RowIndex].Selected= true;
			renglonSeleccionado = dgvAnillos.Rows[e.RowIndex];
			tbxDescripcionAnillos.Text = renglonSeleccionado.Cells["Descripcion"].Value.ToString();
			
			int codAnillo = Convert.ToInt32(renglonSeleccionado.Cells["cod_producto"].Value.ToString());
			string ruta = renglonSeleccionado.Cells["ruta"].Value.ToString();
			ruta = conexion.rutaDeMiUsuario(ruta, "carlos");
			
			pbAnillos.Image = Image.FromFile(ruta);
		}
	}
}