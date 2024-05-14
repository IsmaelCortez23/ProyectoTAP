/*
 * Created by SharpDevelop.
 * User: 52331
 * Date: 14/05/2024
 * Time: 07:30 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoTAP
{
	/// <summary>
	/// Description of FrmAretes.
	/// </summary>
	public partial class FrmAretes : Form
	{
		ConexionDB conexion = new ConexionDB();
		
		public FrmAretes()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		     dgvAretes.DataSource=conexion.cargarDatos("Select cod_producto, tipo_pieza, nombre, Descripcion, precio, ruta from productos");
			 dgvAretes.Columns[5].Visible = false;
			this.WindowState = FormWindowState.Maximized;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		DataGridViewRow renglonSeleccionado;
		
		void DgvAretesCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			foreach(DataGridViewRow renglon in dgvAretes.Rows){
			renglon.Selected=false;
			}
			dgvAretes.Rows[e.RowIndex].Selected=true;
			renglonSeleccionado = dgvAretes.Rows[e.RowIndex];
			
			tbxDescripciónAretes.Text=renglonSeleccionado.Cells["Descripcion"].Value.ToString();
			int codAretes = Convert.ToInt32(renglonSeleccionado.Cells["cod_producto"].Value.ToString());
			string ruta =renglonSeleccionado.Cells["ruta"].Value.ToString();
			ruta = conexion.rutaDeMiUsuario(ruta,"carlos");
			
			ptrFotos.Image = Image.FromFile(ruta);
		}
		
		
		void TxtBuscarTextChanged(object sender, EventArgs e)
		{
			dgvAretes.DataSource = conexion.cargarDatos("SELECT * FROM productos WHERE descripcion LIKE '%"+txtBuscarAretes.Text+"%'");
		}
	}
}