/*
 * Created by SharpDevelop.
 * User: Ismae
 * Date: 14/05/2024
 * Time: 12:05 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoTAP
{
	partial class FrmJuegos
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnJuegoCarrito = new System.Windows.Forms.Button();
			this.pbJuego = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbxDescripcionJuego = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbxBuscarJuego = new System.Windows.Forms.TextBox();
			this.dgvJuego = new System.Windows.Forms.DataGridView();
			this.Regresar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pbJuego)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvJuego)).BeginInit();
			this.SuspendLayout();
			// 
			// btnJuegoCarrito
			// 
			this.btnJuegoCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnJuegoCarrito.Location = new System.Drawing.Point(643, 387);
			this.btnJuegoCarrito.Name = "btnJuegoCarrito";
			this.btnJuegoCarrito.Size = new System.Drawing.Size(203, 42);
			this.btnJuegoCarrito.TabIndex = 22;
			this.btnJuegoCarrito.Text = "&Agregar al Carrito";
			this.btnJuegoCarrito.UseVisualStyleBackColor = true;
			// 
			// pbJuego
			// 
			this.pbJuego.Location = new System.Drawing.Point(643, 48);
			this.pbJuego.Name = "pbJuego";
			this.pbJuego.Size = new System.Drawing.Size(203, 214);
			this.pbJuego.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbJuego.TabIndex = 21;
			this.pbJuego.TabStop = false;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(674, 282);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(138, 23);
			this.label2.TabIndex = 20;
			this.label2.Text = "Descripcion Del Producto";
			// 
			// tbxDescripcionJuego
			// 
			this.tbxDescripcionJuego.Location = new System.Drawing.Point(643, 316);
			this.tbxDescripcionJuego.Name = "tbxDescripcionJuego";
			this.tbxDescripcionJuego.Size = new System.Drawing.Size(204, 20);
			this.tbxDescripcionJuego.TabIndex = 19;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(58, 400);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 20);
			this.label1.TabIndex = 18;
			this.label1.Text = "Buscar: ";
			// 
			// tbxBuscarJuego
			// 
			this.tbxBuscarJuego.Location = new System.Drawing.Point(151, 403);
			this.tbxBuscarJuego.Name = "tbxBuscarJuego";
			this.tbxBuscarJuego.Size = new System.Drawing.Size(419, 20);
			this.tbxBuscarJuego.TabIndex = 17;
			// 
			// dgvJuego
			// 
			this.dgvJuego.AllowUserToAddRows = false;
			this.dgvJuego.AllowUserToDeleteRows = false;
			this.dgvJuego.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvJuego.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvJuego.DefaultCellStyle = dataGridViewCellStyle1;
			this.dgvJuego.Location = new System.Drawing.Point(58, 37);
			this.dgvJuego.Name = "dgvJuego";
			this.dgvJuego.Size = new System.Drawing.Size(511, 297);
			this.dgvJuego.TabIndex = 16;
			this.dgvJuego.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvJuegoCellContentClick);
			// 
			// Regresar
			// 
			this.Regresar.Location = new System.Drawing.Point(709, 459);
			this.Regresar.Name = "Regresar";
			this.Regresar.Size = new System.Drawing.Size(75, 23);
			this.Regresar.TabIndex = 23;
			this.Regresar.Text = "Regresar";
			this.Regresar.UseVisualStyleBackColor = true;
			this.Regresar.Click += new System.EventHandler(this.RegresarClick);
			// 
			// FrmJuegos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(903, 500);
			this.Controls.Add(this.Regresar);
			this.Controls.Add(this.btnJuegoCarrito);
			this.Controls.Add(this.pbJuego);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbxDescripcionJuego);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbxBuscarJuego);
			this.Controls.Add(this.dgvJuego);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "FrmJuegos";
			this.Text = "FrmJuegos";
			((System.ComponentModel.ISupportInitialize)(this.pbJuego)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvJuego)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button Regresar;
		private System.Windows.Forms.DataGridView dgvJuego;
		private System.Windows.Forms.TextBox tbxBuscarJuego;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbxDescripcionJuego;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pbJuego;
		private System.Windows.Forms.Button btnJuegoCarrito;
	}
}