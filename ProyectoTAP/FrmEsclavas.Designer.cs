/*
 * Created by SharpDevelop.
 * User: Ismae
 * Date: 14/05/2024
 * Time: 09:16 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoTAP
{
	partial class FrmEsclavas
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
			this.btnCadenaCarrito = new System.Windows.Forms.Button();
			this.pbEsclavas = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbxDescripcionEsclavas = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbxBuscarEsclavas = new System.Windows.Forms.TextBox();
			this.dgvEsclavas = new System.Windows.Forms.DataGridView();
			this.Regresar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pbEsclavas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvEsclavas)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCadenaCarrito
			// 
			this.btnCadenaCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCadenaCarrito.Location = new System.Drawing.Point(620, 369);
			this.btnCadenaCarrito.Name = "btnCadenaCarrito";
			this.btnCadenaCarrito.Size = new System.Drawing.Size(203, 42);
			this.btnCadenaCarrito.TabIndex = 15;
			this.btnCadenaCarrito.Text = "&Agregar al Carrito";
			this.btnCadenaCarrito.UseVisualStyleBackColor = true;
			// 
			// pbEsclavas
			// 
			this.pbEsclavas.Location = new System.Drawing.Point(620, 39);
			this.pbEsclavas.Name = "pbEsclavas";
			this.pbEsclavas.Size = new System.Drawing.Size(203, 214);
			this.pbEsclavas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbEsclavas.TabIndex = 14;
			this.pbEsclavas.TabStop = false;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(652, 273);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(138, 23);
			this.label2.TabIndex = 13;
			this.label2.Text = "Descripcion Del Producto";
			// 
			// tbxDescripcionEsclavas
			// 
			this.tbxDescripcionEsclavas.Location = new System.Drawing.Point(620, 307);
			this.tbxDescripcionEsclavas.Name = "tbxDescripcionEsclavas";
			this.tbxDescripcionEsclavas.Size = new System.Drawing.Size(204, 20);
			this.tbxDescripcionEsclavas.TabIndex = 12;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(35, 391);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 20);
			this.label1.TabIndex = 11;
			this.label1.Text = "Buscar: ";
			// 
			// tbxBuscarEsclavas
			// 
			this.tbxBuscarEsclavas.Location = new System.Drawing.Point(128, 394);
			this.tbxBuscarEsclavas.Name = "tbxBuscarEsclavas";
			this.tbxBuscarEsclavas.Size = new System.Drawing.Size(419, 20);
			this.tbxBuscarEsclavas.TabIndex = 10;
			// 
			// dgvEsclavas
			// 
			this.dgvEsclavas.AllowUserToAddRows = false;
			this.dgvEsclavas.AllowUserToDeleteRows = false;
			this.dgvEsclavas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvEsclavas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvEsclavas.DefaultCellStyle = dataGridViewCellStyle1;
			this.dgvEsclavas.Location = new System.Drawing.Point(35, 28);
			this.dgvEsclavas.Name = "dgvEsclavas";
			this.dgvEsclavas.Size = new System.Drawing.Size(511, 297);
			this.dgvEsclavas.TabIndex = 9;
			this.dgvEsclavas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEsclavasCellContentClick);
			// 
			// Regresar
			// 
			this.Regresar.Location = new System.Drawing.Point(686, 431);
			this.Regresar.Name = "Regresar";
			this.Regresar.Size = new System.Drawing.Size(75, 23);
			this.Regresar.TabIndex = 16;
			this.Regresar.Text = "Regresar";
			this.Regresar.UseVisualStyleBackColor = true;
			this.Regresar.Click += new System.EventHandler(this.RegresarClick);
			// 
			// FrmEsclavas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(859, 483);
			this.Controls.Add(this.Regresar);
			this.Controls.Add(this.btnCadenaCarrito);
			this.Controls.Add(this.pbEsclavas);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbxDescripcionEsclavas);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbxBuscarEsclavas);
			this.Controls.Add(this.dgvEsclavas);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FrmEsclavas";
			this.Text = "FrmEsclavas";
			this.Load += new System.EventHandler(this.FrmEsclavasLoad);
			((System.ComponentModel.ISupportInitialize)(this.pbEsclavas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvEsclavas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button Regresar;
		private System.Windows.Forms.DataGridView dgvEsclavas;
		private System.Windows.Forms.TextBox tbxBuscarEsclavas;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbxDescripcionEsclavas;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pbEsclavas;
		private System.Windows.Forms.Button btnCadenaCarrito;
	}
}