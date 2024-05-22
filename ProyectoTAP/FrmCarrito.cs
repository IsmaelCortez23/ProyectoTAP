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
		int id, costo, total=0;
		string nombre, descripcion, tipoPieza;
		ConexionDB conexion = new ConexionDB();
		DataGridViewRow renglonSeleccionado;
		Producto producto = new Producto();
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
			dgvCarrito.Columns.Add("ruta","ruta");
			llenarDatos();
			dgvCarrito.Columns[5].Visible = false;
			tbxTotal.Text = Convert.ToString(total);
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public void llenarDatos(){
			foreach(Producto prod in Producto.productos){
				dgvCarrito.Rows.Add(prod.id, prod.tipoPieza, prod.nombre, prod.descripcion, prod.precio, prod.ruta);
				total += Convert.ToInt32(prod.precio.ToString());
			}
			tbxTotal.Text=total.ToString();
		
		}
		
		
		void DgvCarritoCellClick(object sender, DataGridViewCellEventArgs e)
		{
			foreach (DataGridViewRow renglon in dgvCarrito.Rows){
				renglon.Selected = false;
			}
			renglonSeleccionado = dgvCarrito.Rows[e.RowIndex];
			dgvCarrito.Rows[e.RowIndex].Selected=true;
			string ruta = renglonSeleccionado.Cells["ruta"].Value.ToString();
			pbCarrito.Image = Image.FromFile(ruta);
		}
		
		void BtnEliminarProductoCarritoClick(object sender, EventArgs e)
		{
			if(renglonSeleccionado!=null){
				total-=Convert.ToInt32(renglonSeleccionado.Cells["costo"].Value);
				tbxTotal.Text=total.ToString();
				dgvCarrito.Rows.Remove(renglonSeleccionado);
				//productos.renglonSeleccionado = null;
				//producto.productos.Remove()
				
			}
			else{
				MessageBox.Show("No hay productos seleccionados para eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		
		
		
		void RegresarClick(object sender, EventArgs e)
		{
			MainForm mainform= new MainForm();
			mainform.Show();
			this.Hide();
		}
		
		void TbxTotalTextChanged(object sender, EventArgs e)
		{
			
		}
	}
}