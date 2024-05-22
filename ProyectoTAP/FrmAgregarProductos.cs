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
			
			pbAgregarProducto.Image = Image.FromFile(ruta);
		}
		
		void RegresarClick(object sender, EventArgs e)
		{
			MainForm mainform= new MainForm();
			mainform.Show();
			this.Hide();
		}
		
	}
}

