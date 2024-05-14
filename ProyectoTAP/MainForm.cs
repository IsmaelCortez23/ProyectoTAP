/*
 * Created by SharpDevelop.
 * User: carlo
 * Date: 30/04/2024
 * Time: 05:58 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoTAP
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.WindowState = FormWindowState.Maximized;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void CadenasToolStripMenuItemClick(object sender, EventArgs e)
		{
			FrmCadenas cadena = new FrmCadenas();
			cadena.ShowDialog();
		}
	}
	
	
	
}
