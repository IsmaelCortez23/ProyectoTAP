/*
 * Created by SharpDevelop.
 * User: carlo
 * Date: 17/05/2024
 * Time: 01:15 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;


namespace ProyectoTAP
{
	/// <summary>
	/// Description of Producto.
	/// </summary>
	public class Producto
	{
		public int id, precio;
		public string nombre, descripcion, tipoPieza, ruta;
		public static List<Producto> productos = new List<Producto>();
		
		public Producto(int id,string tipoPieza, string nombre, string descripcion, int precio, string ruta)
		{
			this.id = id;
			this.tipoPieza = tipoPieza;
			this.nombre = nombre;
			this.descripcion = descripcion;
			this.precio = precio;			
			this.ruta = ruta;
		}
		
		public Producto(){
			
		}
		
		public void agregarLista(Producto prod){
			productos.Add(prod);
		}
		
		
	}
	
}
