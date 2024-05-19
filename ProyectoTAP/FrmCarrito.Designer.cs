/*
 * Created by SharpDevelop.
 * User: carlo
 * Date: 17/05/2024
 * Time: 09:22 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoTAP
{
	partial class FrmCarrito
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
			this.dgvCarrito = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.tbxTotal = new System.Windows.Forms.TextBox();
			this.pbCarrito = new System.Windows.Forms.PictureBox();
			this.btnEliminarProductoCarrito = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbCarrito)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvCarrito
			// 
			this.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCarrito.Location = new System.Drawing.Point(31, 31);
			this.dgvCarrito.Name = "dgvCarrito";
			this.dgvCarrito.Size = new System.Drawing.Size(711, 332);
			this.dgvCarrito.TabIndex = 0;
			this.dgvCarrito.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCarritoCellClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(375, 417);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 29);
			this.label1.TabIndex = 4;
			this.label1.Text = "Total";
			// 
			// tbxTotal
			// 
			this.tbxTotal.Enabled = false;
			this.tbxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbxTotal.Location = new System.Drawing.Point(455, 415);
			this.tbxTotal.Margin = new System.Windows.Forms.Padding(2);
			this.tbxTotal.Name = "tbxTotal";
			this.tbxTotal.Size = new System.Drawing.Size(162, 31);
			this.tbxTotal.TabIndex = 3;
			// 
			// pbCarrito
			// 
			this.pbCarrito.Location = new System.Drawing.Point(809, 31);
			this.pbCarrito.Name = "pbCarrito";
			this.pbCarrito.Size = new System.Drawing.Size(228, 332);
			this.pbCarrito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbCarrito.TabIndex = 8;
			this.pbCarrito.TabStop = false;
			// 
			// btnEliminarProductoCarrito
			// 
			this.btnEliminarProductoCarrito.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminarProductoCarrito.Location = new System.Drawing.Point(31, 403);
			this.btnEliminarProductoCarrito.Name = "btnEliminarProductoCarrito";
			this.btnEliminarProductoCarrito.Size = new System.Drawing.Size(211, 52);
			this.btnEliminarProductoCarrito.TabIndex = 9;
			this.btnEliminarProductoCarrito.Text = "Sacar del Carrito";
			this.btnEliminarProductoCarrito.UseVisualStyleBackColor = true;
			this.btnEliminarProductoCarrito.Click += new System.EventHandler(this.BtnEliminarProductoCarritoClick);
			// 
			// FrmCarrito
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1117, 510);
			this.Controls.Add(this.btnEliminarProductoCarrito);
			this.Controls.Add(this.pbCarrito);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbxTotal);
			this.Controls.Add(this.dgvCarrito);
			this.Name = "FrmCarrito";
			this.Text = "FrmCarrito";
			((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbCarrito)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnEliminarProductoCarrito;
		private System.Windows.Forms.PictureBox pbCarrito;
		private System.Windows.Forms.TextBox tbxTotal;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvCarrito;
	}
}
