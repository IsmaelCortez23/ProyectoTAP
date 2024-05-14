/*
 * Created by SharpDevelop.
 * User: 52331
 * Date: 14/05/2024
 * Time: 07:30 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoTAP
{
	partial class FrmAretes
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
			this.dgvAretes = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.txtBuscarAretes = new System.Windows.Forms.TextBox();
			this.ptrFotos = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbxDescripciónAretes = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvAretes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ptrFotos)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvAretes
			// 
			this.dgvAretes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAretes.Location = new System.Drawing.Point(29, 39);
			this.dgvAretes.Margin = new System.Windows.Forms.Padding(2);
			this.dgvAretes.Name = "dgvAretes";
			this.dgvAretes.RowTemplate.Height = 24;
			this.dgvAretes.Size = new System.Drawing.Size(494, 255);
			this.dgvAretes.TabIndex = 0;
			this.dgvAretes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAretesCellContentClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(35, 359);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 19);
			this.label1.TabIndex = 1;
			this.label1.Text = "Buscar";
			// 
			// txtBuscarAretes
			// 
			this.txtBuscarAretes.Location = new System.Drawing.Point(90, 362);
			this.txtBuscarAretes.Margin = new System.Windows.Forms.Padding(2);
			this.txtBuscarAretes.Name = "txtBuscarAretes";
			this.txtBuscarAretes.Size = new System.Drawing.Size(418, 20);
			this.txtBuscarAretes.TabIndex = 2;
			this.txtBuscarAretes.TextChanged += new System.EventHandler(this.TxtBuscarTextChanged);
			// 
			// ptrFotos
			// 
			this.ptrFotos.Location = new System.Drawing.Point(570, 39);
			this.ptrFotos.Margin = new System.Windows.Forms.Padding(2);
			this.ptrFotos.Name = "ptrFotos";
			this.ptrFotos.Size = new System.Drawing.Size(196, 255);
			this.ptrFotos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ptrFotos.TabIndex = 3;
			this.ptrFotos.TabStop = false;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(575, 341);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 19);
			this.label2.TabIndex = 4;
			this.label2.Text = "Descripción";
			// 
			// tbxDescripciónAretes
			// 
			this.tbxDescripciónAretes.Location = new System.Drawing.Point(644, 345);
			this.tbxDescripciónAretes.Margin = new System.Windows.Forms.Padding(2);
			this.tbxDescripciónAretes.Name = "tbxDescripciónAretes";
			this.tbxDescripciónAretes.Size = new System.Drawing.Size(76, 20);
			this.tbxDescripciónAretes.TabIndex = 5;
			// 
			// FrmAretes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(818, 416);
			this.Controls.Add(this.tbxDescripciónAretes);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.ptrFotos);
			this.Controls.Add(this.txtBuscarAretes);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvAretes);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FrmAretes";
			this.Text = "FrmAretes";
			((System.ComponentModel.ISupportInitialize)(this.dgvAretes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ptrFotos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox tbxDescripciónAretes;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox ptrFotos;
		private System.Windows.Forms.TextBox txtBuscarAretes;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvAretes;
	}
}
