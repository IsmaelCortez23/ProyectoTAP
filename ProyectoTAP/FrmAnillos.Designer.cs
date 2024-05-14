/*
 * Created by SharpDevelop.
 * User: gabyp
 * Date: 14/05/2024
 * Time: 9:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoTAP
{
	partial class FrmAnillos
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
			this.dgvAnillos = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.tbxBuscar = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbxDescripcionAnillos = new System.Windows.Forms.TextBox();
			this.pbAnillos = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvAnillos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbAnillos)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvAnillos
			// 
			this.dgvAnillos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAnillos.Location = new System.Drawing.Point(26, 33);
			this.dgvAnillos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dgvAnillos.Name = "dgvAnillos";
			this.dgvAnillos.RowTemplate.Height = 24;
			this.dgvAnillos.Size = new System.Drawing.Size(490, 253);
			this.dgvAnillos.TabIndex = 0;
			this.dgvAnillos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAnillosCellContentClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(61, 327);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 33);
			this.label1.TabIndex = 1;
			this.label1.Text = "Buscar:";
			// 
			// tbxBuscar
			// 
			this.tbxBuscar.Location = new System.Drawing.Point(150, 330);
			this.tbxBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tbxBuscar.Name = "tbxBuscar";
			this.tbxBuscar.Size = new System.Drawing.Size(283, 20);
			this.tbxBuscar.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(588, 285);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(150, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Descripcion Del Producto";
			// 
			// tbxDescripcionAnillos
			// 
			this.tbxDescripcionAnillos.Location = new System.Drawing.Point(588, 318);
			this.tbxDescripcionAnillos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tbxDescripcionAnillos.Name = "tbxDescripcionAnillos";
			this.tbxDescripcionAnillos.Size = new System.Drawing.Size(151, 20);
			this.tbxDescripcionAnillos.TabIndex = 4;
			// 
			// pbAnillos
			// 
			this.pbAnillos.Location = new System.Drawing.Point(566, 24);
			this.pbAnillos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.pbAnillos.Name = "pbAnillos";
			this.pbAnillos.Size = new System.Drawing.Size(172, 228);
			this.pbAnillos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbAnillos.TabIndex = 5;
			this.pbAnillos.TabStop = false;
			// 
			// FrmAnillos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(808, 429);
			this.Controls.Add(this.pbAnillos);
			this.Controls.Add(this.tbxDescripcionAnillos);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbxBuscar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvAnillos);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "FrmAnillos";
			this.Text = "FrmAnillos";
			((System.ComponentModel.ISupportInitialize)(this.dgvAnillos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbAnillos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox pbAnillos;
		private System.Windows.Forms.TextBox tbxDescripcionAnillos;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbxBuscar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvAnillos;
	}
}