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
			this.Total = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvCarrito
			// 
			this.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCarrito.Location = new System.Drawing.Point(31, 31);
			this.dgvCarrito.Name = "dgvCarrito";
			this.dgvCarrito.Size = new System.Drawing.Size(748, 279);
			this.dgvCarrito.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(374, 351);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 19);
			this.label1.TabIndex = 4;
			this.label1.Text = "Total";
			// 
			// Total
			// 
			this.Total.Location = new System.Drawing.Point(454, 349);
			this.Total.Margin = new System.Windows.Forms.Padding(2);
			this.Total.Name = "Total";
			this.Total.Size = new System.Drawing.Size(136, 20);
			this.Total.TabIndex = 3;
			// 
			// FrmCarrito
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1042, 510);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Total);
			this.Controls.Add(this.dgvCarrito);
			this.Name = "FrmCarrito";
			this.Text = "FrmCarrito";
			((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox Total;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvCarrito;
	}
}
