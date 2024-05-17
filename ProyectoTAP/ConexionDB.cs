/*
 * Created by SharpDevelop.
 * User: carlo
 * Date: 02/05/2024
 * Time: 08:07 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.Linq;

namespace ProyectoTAP
{
	/// <summary>
	/// Description of ConexionDB.
	/// </summary>
	/// 
	public class ConexionDB
	{
		//datos para conectarse la base de datos
		//datos para conectarse la base de datos /casa/192.168.1.250 /tecjalisco/172.16.27.254
		string strConection = "server=192.168.1.250; user id=prueba; password=prueba123; database=joyeria";
		MySqlConnection conec;
		MySqlCommand cmd;
		
		string rutaUsuario;
		
		public ConexionDB()
		{
			
		}
		
		//sirve para ejecutar insert, update, delete
		public bool ejecutarConsulta(string query){
			try {
				abrir();
				cmd= new MySqlCommand(query, conec);
				cmd.ExecuteNonQuery();
				cerrar();
				return true;
			} catch (Exception e) {
				MessageBox.Show(e.Message);
				return false;
				throw;
			}
		}
		
		public bool abrir(){
			try{
				conec = new MySqlConnection(strConection);
				conec.Open();
				return true;
			}catch(Exception er){
				MessageBox.Show(er.Message);
				return false;
			}
		}
		
		public void cerrar(){
			conec.Close();
		}
		
		public DataTable cargarDatos(string query){
			try {
				DataTable tabla=new DataTable();
				abrir();
				MySqlDataAdapter da = new MySqlDataAdapter(query,conec);
				da.Fill(tabla);
				cerrar();
				return tabla;
			} catch (Exception ex) {
				MessageBox.Show(ex.Message);
				return null;
				throw;
			}
		}
		
		public string rutaDeMiUsuario(string ruta, string usuario){
			
			switch (usuario){
				case "carlos":
					rutaUsuario = "C:\\Users\\carlo\\OneDrive\\Documentos\\SharpDevelop Projects\\";
					break;
				case "sarai":
					rutaUsuario = "C:\\Users\\52331\\OneDrive - zapopan.tecmm.edu.mx\\Documentos\\SharpDevelop Projects\\";
					break;
				case "gaby":
					rutaUsuario = "C:\\Users\\gabyp\\OneDrive\\Documentos\\SharpDevelop Projects\\";
					break;
				case "isma":
					rutaUsuario = "C:\\Users\\Ismae\\";
					break;
			}
			
			string []division = ruta.Split('\\');
			Array.Reverse(division); 
			string[] ultimos7 = division.Take(5).ToArray();
			Array.Reverse(ultimos7);
			string nuevaRuta = string.Join("\\", ultimos7);

			string rutaCompleta =  rutaUsuario + nuevaRuta;
			
			return rutaCompleta;
			
		}
		//C:\Users\52331\OneDrive - zapopan.tecmm.edu.mx\Documentos\SharpDevelop Projects\ProyectoTAP\ProyectoTAP\ProyectoTAP\Imagenes\Cadenas\eslabon_cartier.jpeg
		//C:\Users\carlo\OneDrive\Documentos\SharpDevelop Projects\ProyectoTAP\ProyectoTAP\Imagenes\Cadenas\eslabon_cartier.jpeg
		
		
	/*	public bool datosVacios(Panel panelCliente){
			foreach(Control control in panelCliente.Controls){
				if(control is TextBox){//si el control del panel es una caa de texto
					TextBox tbx = (TextBox)control;
					if(string.IsNullOrEmpty(tbx.Text)){
						return true;
					}
				}
			}
			return false;
		}
		
		public void limpiarTBX(Panel panellimpiar){
			foreach(Control control in panellimpiar.Controls){
				if(control is TextBox){
					TextBox tbx = (TextBox)control;
					tbx.Text="";
				}
			}
		}
		public void mandarDatosTBX(Panel panelDatos, DataGridViewRow renglon){
			int cont=(Convert.ToInt32(renglon.Cells.Count.ToString()))-1;
			foreach(Control control in panelDatos.Controls){
				if(control is TextBox){
					TextBox tbx = (TextBox)control;
					tbx.Text=renglon.Cells[cont].Value.ToString();
					cont--;
				}
			}
		}*/
	}
}
