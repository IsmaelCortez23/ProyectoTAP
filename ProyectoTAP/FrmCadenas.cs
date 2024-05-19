/*
 * Created by SharpDevelop.
 * User: carlo
 * Date: 02/05/2024
 * Time: 09:40 p. m.
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
	/// Description of FrmCadenas.
	/// </summary>
	public partial class FrmCadenas : Form
	{
		string nombre, descripcion, tipoPieza, ruta;
		int id, costo;
		ConexionDB conexion = new ConexionDB();
		Producto producto = new Producto();
		public FrmCadenas()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			dgvCadenas.DataSource=conexion.cargarDatos("Select cod_producto, tipo_pieza, nombre, Descripcion, precio, ruta from productos"+
			                                          "	WHERE tipo_pieza = 'Cadena'");
			dgvCadenas.Columns[5].Visible = false;
			this.WindowState = FormWindowState.Maximized;
			
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		DataGridViewRow renglonSeleccionado;
		
		void DgvCadenasCellClick(object sender, DataGridViewCellEventArgs e)
		{
			foreach(DataGridViewRow renglon in dgvCadenas.Rows){
			renglon.Selected=false;
			}
			dgvCadenas.Rows[e.RowIndex].Selected=true;//renglon seleccionado de color azul
			renglonSeleccionado = dgvCadenas.Rows[e.RowIndex];
			
			tbxDescripcionCadenas.Text=renglonSeleccionado.Cells["Descripcion"].Value.ToString(); //mostrar la descripcion debajo de la imagen
			
			int codCadena = Convert.ToInt32(renglonSeleccionado.Cells["cod_producto"].Value.ToString());
			string ruta = renglonSeleccionado.Cells["ruta"].Value.ToString();
			ruta = conexion.rutaDeMiUsuario(ruta,"carlos");
			
			pbCadenas.Image = Image.FromFile(ruta);//pictureBox para las imagenes de los productos
		}
		
		void TbxBuscarCadenasTextChanged(object sender, EventArgs e)
		{
			dgvCadenas.DataSource = conexion.cargarDatos("SELECT * FROM productos WHERE descripcion LIKE '%"+tbxBuscarCadenas.Text+"%'");
		}
		
		void BtnCadenaCarritoClick(object sender, EventArgs e)
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
		
		
		
	}
		
}

