/*
 * Created by SharpDevelop.
 * User: 52331
 * Date: 20/05/2024
 * Time: 12:33 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoTAP
{
	partial class FrmClientes
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.tbxUsuarios = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbxTelefonos = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbxDirección = new System.Windows.Forms.TextBox();
			this.btnCrear = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.tbxUsuario = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(42, 136);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(202, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Ingresa tu nombre de usuario";
			// 
			// tbxUsuarios
			// 
			this.tbxUsuarios.Location = new System.Drawing.Point(260, 137);
			this.tbxUsuarios.Name = "tbxUsuarios";
			this.tbxUsuarios.Size = new System.Drawing.Size(258, 22);
			this.tbxUsuarios.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(31, 200);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(213, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Ingrese su Numero de Telefono:";
			// 
			// tbxTelefonos
			// 
			this.tbxTelefonos.Location = new System.Drawing.Point(260, 197);
			this.tbxTelefonos.Name = "tbxTelefonos";
			this.tbxTelefonos.Size = new System.Drawing.Size(258, 22);
			this.tbxTelefonos.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(73, 271);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(171, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Ingrese su Dirección:";
			// 
			// tbxDirección
			// 
			this.tbxDirección.Location = new System.Drawing.Point(260, 271);
			this.tbxDirección.Name = "tbxDirección";
			this.tbxDirección.Size = new System.Drawing.Size(258, 22);
			this.tbxDirección.TabIndex = 6;
			// 
			// btnCrear
			// 
			this.btnCrear.Location = new System.Drawing.Point(131, 371);
			this.btnCrear.Name = "btnCrear";
			this.btnCrear.Size = new System.Drawing.Size(138, 53);
			this.btnCrear.TabIndex = 7;
			this.btnCrear.Text = "Crear";
			this.btnCrear.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(140, 62);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(352, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "¿NO TIENES UNA CUENTA? CREA TU CUENTA!\r\n\r\n\r\n\r\n\r\n\r\n";
			this.label4.Click += new System.EventHandler(this.Label4Click);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(722, 62);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(308, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = "¿YA TIENES UNA CUENTA? INICIA SESION!";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(590, 140);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(208, 23);
			this.label6.TabIndex = 10;
			this.label6.Text = "Ingresa tu nombre de usuario:\r\n";
			// 
			// tbxUsuario
			// 
			this.tbxUsuario.Location = new System.Drawing.Point(804, 136);
			this.tbxUsuario.Name = "tbxUsuario";
			this.tbxUsuario.Size = new System.Drawing.Size(163, 22);
			this.tbxUsuario.TabIndex = 11;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(783, 281);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(138, 53);
			this.button1.TabIndex = 12;
			this.button1.Text = "Continuar";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// FrmClientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 499);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.tbxUsuario);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnCrear);
			this.Controls.Add(this.tbxDirección);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbxTelefonos);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbxUsuarios);
			this.Controls.Add(this.label1);
			this.Name = "FrmClientes";
			this.Load += new System.EventHandler(this.FrmClientesLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox tbxUsuario;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnCrear;
		private System.Windows.Forms.TextBox tbxDirección;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbxTelefonos;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbxUsuarios;
		private System.Windows.Forms.Label label1;
	}
}
