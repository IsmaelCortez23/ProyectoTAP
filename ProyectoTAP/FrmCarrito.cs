/*
 * Created by SharpDevelop.
 * User: carlo
 * Date: 17/05/2024
 * Time: 09:22 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;


namespace ProyectoTAP
{
	/// <summary>
	/// Description of FrmCarrito.
	/// </summary>
	public partial class FrmCarrito : Form
	{
		int id, costo, contado;
		string nombre, descripcion, tipoPieza;
		ConexionDB conexion = new ConexionDB();
		
		
		public FrmCarrito()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			dgvCarrito.Columns.Add("cod_producto","cod_producto");
			dgvCarrito.Columns.Add("tipo_pieza","tipo_pieza");
			dgvCarrito.Columns.Add("nombre","nombre");
			dgvCarrito.Columns.Add("descripcion","descipcion");
			dgvCarrito.Columns.Add("costo","costo");
			llenarDatos();
				
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public void llenarDatos(){
			foreach(Producto prod in Producto.productos){
				dgvCarrito.Rows.Add(prod.id, prod.tipoPieza, prod.nombre, prod.descripcion, prod.precio);
			}
		}
		
	}
}
