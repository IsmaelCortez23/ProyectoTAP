/*
 * Created by SharpDevelop.
 * User: Ismae
 * Date: 14/05/2024
 * Time: 12:29 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoTAP
{
	partial class FrmDije
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
			this.btnDijeCarrito = new System.Windows.Forms.Button();
			this.pbDije = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbxDescripcionDije = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbxBuscarDije = new System.Windows.Forms.TextBox();
			this.dgvDije = new System.Windows.Forms.DataGridView();
			this.Regresar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pbDije)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDije)).BeginInit();
			this.SuspendLayout();
			// 
			// btnDijeCarrito
			// 
			this.btnDijeCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDijeCarrito.Location = new System.Drawing.Point(647, 399);
			this.btnDijeCarrito.Name = "btnDijeCarrito";
			this.btnDijeCarrito.Size = new System.Drawing.Size(203, 42);
			this.btnDijeCarrito.TabIndex = 29;
			this.btnDijeCarrito.Text = "&Agregar al Carrito";
			this.btnDijeCarrito.UseVisualStyleBackColor = true;
			// 
			// pbDije
			// 
			this.pbDije.Location = new System.Drawing.Point(646, 58);
			this.pbDije.Name = "pbDije";
			this.pbDije.Size = new System.Drawing.Size(203, 214);
			this.pbDije.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbDije.TabIndex = 28;
			this.pbDije.TabStop = false;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(678, 292);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(138, 23);
			this.label2.TabIndex = 27;
			this.label2.Text = "Descripcion Del Producto";
			// 
			// tbxDescripcionDije
			// 
			this.tbxDescripcionDije.Location = new System.Drawing.Point(646, 327);
			this.tbxDescripcionDije.Name = "tbxDescripcionDije";
			this.tbxDescripcionDije.Size = new System.Drawing.Size(204, 20);
			this.tbxDescripcionDije.TabIndex = 26;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(62, 410);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 20);
			this.label1.TabIndex = 25;
			this.label1.Text = "Buscar: ";
			// 
			// tbxBuscarDije
			// 
			this.tbxBuscarDije.Location = new System.Drawing.Point(154, 414);
			this.tbxBuscarDije.Name = "tbxBuscarDije";
			this.tbxBuscarDije.Size = new System.Drawing.Size(419, 20);
			this.tbxBuscarDije.TabIndex = 24;
			// 
			// dgvDije
			// 
			this.dgvDije.AllowUserToAddRows = false;
			this.dgvDije.AllowUserToDeleteRows = false;
			this.dgvDije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvDije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvDije.DefaultCellStyle = dataGridViewCellStyle1;
			this.dgvDije.Location = new System.Drawing.Point(62, 48);
			this.dgvDije.Name = "dgvDije";
			this.dgvDije.Size = new System.Drawing.Size(511, 297);
			this.dgvDije.TabIndex = 23;
			this.dgvDije.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDijeCellContentClick);
			// 
			// Regresar
			// 
			this.Regresar.Location = new System.Drawing.Point(723, 468);
			this.Regresar.Name = "Regresar";
			this.Regresar.Size = new System.Drawing.Size(75, 23);
			this.Regresar.TabIndex = 30;
			this.Regresar.Text = "Regresar";
			this.Regresar.UseVisualStyleBackColor = true;
			this.Regresar.Click += new System.EventHandler(this.RegresarClick);
			// 
			// FrmDije
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(911, 522);
			this.Controls.Add(this.Regresar);
			this.Controls.Add(this.btnDijeCarrito);
			this.Controls.Add(this.pbDije);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbxDescripcionDije);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbxBuscarDije);
			this.Controls.Add(this.dgvDije);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "FrmDije";
			this.Text = "FrmDije";
			((System.ComponentModel.ISupportInitialize)(this.pbDije)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDije)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button Regresar;
		private System.Windows.Forms.DataGridView dgvDije;
		private System.Windows.Forms.TextBox tbxBuscarDije;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbxDescripcionDije;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pbDije;
		private System.Windows.Forms.Button btnDijeCarrito;
	}
}