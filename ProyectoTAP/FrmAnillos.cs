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
		string nombre, descripcion, tipoPieza, ruta;
		int id, costo;
		Producto producto = new Producto();
		ConexionDB conexion = new ConexionDB();
		public FrmAnillos()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			dgvAnillos.DataSource=conexion.cargarDatos("Select cod_producto, tipo_pieza, nombre, Descripcion, precio, ruta from productos"+
			                                          "	WHERE tipo_pieza = 'Anillo'");
			dgvAnillos.Columns[5].Visible = false;
			this.WindowState = FormWindowState.Maximized;
			dgvAnillos.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.AllCells;
			
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
		
		
		void TbxBuscarTextChanged(object sender, EventArgs e)
		{
			dgvAnillos.DataSource = conexion.cargarDatos("SELECT * FROM productos WHERE descripcion LIKE '%"+tbxBuscar.Text+"%'"+
			                                             " AND tipo_pieza = 'anillo'");
		}
		
		void BtnAnilloCarritoClick(object sender, EventArgs e)
		{
			id = Convert.ToInt32(renglonSeleccionado.Cells["cod_producto"].Value.ToString());
			nombre = renglonSeleccionado.Cells["nombre"].Value.ToString();
			descripcion = renglonSeleccionado.Cells["descripcion"].Value.ToString();
			tipoPieza =renglonSeleccionado.Cells["tipo_pieza"].Value.ToString();
			costo = Convert.ToInt32(renglonSeleccionado.Cells["precio"].Value.ToString());
			ruta = renglonSeleccionado.Cells["ruta"].Value.ToString();
			Producto prod = new Producto(id, tipoPieza, nombre, descripcion, costo, ruta);
			producto.agregarLista(prod);
		}
		
		void RegresarClick(object sender, EventArgs e)
		{
			MainForm mainform= new MainForm();
			mainform.Show();
			this.Hide();
		}
	}
}