/*
 * Created by SharpDevelop.
 * User: Ismae
 * Date: 14/05/2024
 * Time: 09:16 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoTAP
{
	/// <summary>
	/// Description of FrmEsclavas.
	/// </summary>
	public partial class FrmEsclavas : Form
	{
		
		ConexionDB conexion = new ConexionDB();
		public FrmEsclavas()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			dgvEsclavas.DataSource=conexion.cargarDatos("Select cod_producto, tipo_pieza, nombre, Descripcion, precio, ruta from productos"+
			                                          "	WHERE tipo_pieza = 'Esclavas'");
			dgvEsclavas.Columns[5].Visible = false;
			this.WindowState = FormWindowState.Maximized;
			dgvEsclavas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		DataGridViewRow renglonSeleccionado;
		void DgvEsclavasCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			foreach(DataGridViewRow renglon in dgvEsclavas.Rows){
				renglon.Selected = false;
			}
			dgvEsclavas.Rows[e.RowIndex].Selected= true;
			renglonSeleccionado = dgvEsclavas.Rows[e.RowIndex];
			tbxDescripcionEsclavas.Text=renglonSeleccionado.Cells["Descripcion"].Value.ToString();
			
			int codEsclavas = Convert.ToInt32(renglonSeleccionado.Cells["cod_producto"].Value.ToString());
			string ruta = renglonSeleccionado.Cells["ruta"].Value.ToString();
			ruta = conexion.rutaDeMiUsuario(ruta, "carlos");
			
			pbEsclavas.Image = Image.FromFile(ruta);
		}
		
		void FrmEsclavasLoad(object sender, EventArgs e)
		{
			
		}
		
		void RegresarClick(object sender, EventArgs e)
		{
			MainForm mainform= new MainForm();
			mainform.Show();
			this.Hide();
		}
	}
}