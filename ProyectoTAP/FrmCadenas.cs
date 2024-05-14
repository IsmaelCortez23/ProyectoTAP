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
		ConexionDB conexion = new ConexionDB();
		public FrmCadenas()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			dgvCadenas.DataSource=conexion.cargarDatos("Select cod_producto, tipo_pieza, nombre, Descripcion, precio, ruta from productos");
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		DataGridViewRow renglonSeleccionado;
		
		//cuando el usuario de doble click podra ver la imagen y la descripcion
		void DgvCadenasCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			foreach(DataGridViewRow renglon in dgvCadenas.Rows){
			renglon.Selected=false;
			}
			dgvCadenas.Rows[e.RowIndex].Selected=true;//renglon seleccionado de color azul
			renglonSeleccionado = dgvCadenas.Rows[e.RowIndex];
			
			tbxDescripcionCadenas.Text=renglonSeleccionado.Cells["Descripcion"].Value.ToString(); //mostrar la descripcion debajo de la imagen
			
			int codCadena = Convert.ToInt32(renglonSeleccionado.Cells["cod_producto"].Value.ToString());
			string ruta = renglonSeleccionado.Cells["ruta"].Value.ToString();
			ruta = conexion.rutaDeMiUsuario(ruta,"sarai");
			
			pbCadenas.Image = Image.FromFile(ruta);//pictureBox para las imagenes de los productos
			
		}
		
	}
		
}

