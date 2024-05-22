/*
 * Created by SharpDevelop.
 * User: carlo
 * Date: 16/05/2024
 * Time: 08:05 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoTAP
{
	/// <summary>
	/// Description of FrmAgregarProductos.
	/// </summary>
	/// 
	public partial class FrmAgregarProductos : Form
	{
		ConexionDB conexion = new ConexionDB();
		
		public FrmAgregarProductos()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			dgvAgregarProducto.DataSource=conexion.cargarDatos("Select cod_producto, tipo_pieza, nombre, Descripcion, precio, ruta from productos");
			dgvAgregarProducto.Columns[5].Visible = false;
			this.WindowState = FormWindowState.Maximized;
			dgvAgregarProducto.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.AllCells;
			btnAceptar.Enabled = false;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		DataGridViewRow renglonSeleccionado;
		
		void Button1Click(object sender, EventArgs e)
		{
			string query = "INSERT INTO productos (Nombre, Descripcion, Precio, Tipo_Pieza, Ruta) " +
                                          "VALUES ('" + tbxNombre.Text + "','" + tbxDescripcion.Text + "'," + tbxPrecio.Text +
                                          ",'" + tbxPieza.Text + "','" + tbxRuta.Text + "')";
			if (conexion.ejecutarConsulta(query)){
                MessageBox.Show("Se registraron correctamente los datos.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvAgregarProducto.DataSource = conexion.cargarDatos("SELECT * FROM productos");
            }
				else{
				
	                MessageBox.Show("Error al registrar los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
			}
		
		void Button2Click(object sender, EventArgs e)
		{
			if(renglonSeleccionado!=null){
				int idProducto = Convert.ToInt32(renglonSeleccionado.Cells["cod_producto"].Value.ToString());
				string query = "DELETE FROM productos WHERE cod_producto = "+idProducto;
				if (conexion.ejecutarConsulta(query)){
				    MessageBox.Show("Se ha eliminado correctamente el registro");
				    dgvAgregarProducto.DataSource = conexion.cargarDatos("SELECT * FROM productos");
				}
				else{
					MessageBox.Show("Error al borrar el registro");
				}
			}
			else{
				MessageBox.Show("Falta seleccionar un renglon");
			}
		}
		
		void DgvAgregarProductoCellClick(object sender, DataGridViewCellEventArgs e)
		{
			foreach (DataGridViewRow renglon in dgvAgregarProducto.Rows){
				renglon.Selected=false;
			}
			//Seleccionar un renglon y guardarlo en la varible renglonSeleccionado
			dgvAgregarProducto.Rows[e.RowIndex].Selected = true;
			renglonSeleccionado = dgvAgregarProducto.Rows[e.RowIndex];
			string ruta = renglonSeleccionado.Cells["ruta"].Value.ToString();
			try{
				pbAgregarProducto.Image = Image.FromFile(ruta);	
			}catch(Exception ex){
				MessageBox.Show("Error no se encontro la ruta a la imagen \n"+ex);
			}
		}
		
		
		void RegresarClick(object sender, EventArgs e)
		{
			MainForm mainform= new MainForm();
			mainform.Show();
			this.Hide();
		}
		
		
		void BtnModificarClick(object sender, EventArgs e)
		{
			if(renglonSeleccionado!=null){
				btnAceptar.Enabled = true;
				tbxNombre.Text = renglonSeleccionado.Cells["nombre"].Value.ToString();
				tbxDescripcion.Text = renglonSeleccionado.Cells["descripcion"].Value.ToString();
				tbxPrecio.Text = renglonSeleccionado.Cells["precio"].Value.ToString();
				tbxPieza.Text = renglonSeleccionado.Cells["tipo_Pieza"].Value.ToString();
				tbxRuta.Text = renglonSeleccionado.Cells["ruta"].Value.ToString();	
			}
			else{
				MessageBox.Show("Primero seleccione un registro");
			}
			
		}
		
		
		void BtnAceptarClick(object sender, EventArgs e)
		{
			int idModificar = Convert.ToInt32(renglonSeleccionado.Cells["cod_producto"].Value.ToString());
			string query = "UPDATE productos SET tipo_pieza = '"+tbxPieza.Text+"', nombre = '"+tbxNombre.Text+
				"', descripcion = '"+tbxDescripcion.Text+"', precio = "+tbxPrecio.Text+", ruta = '"+tbxRuta.Text+"'"+
				"WHERE cod_producto = "+ idModificar;
			if (conexion.ejecutarConsulta(query)){
				MessageBox.Show("Se modifico el registro con éxito");
			}
			else{
				MessageBox.Show("Error al modificar el renglon selecionado");
			}
			dgvAgregarProducto.DataSource=conexion.cargarDatos("SELECT * FROM productos");
		}
	}
}

