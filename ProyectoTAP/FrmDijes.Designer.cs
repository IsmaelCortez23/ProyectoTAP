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
			((System.ComponentModel.ISupportInitialize)(this.pbDije)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDije)).BeginInit();
			this.SuspendLayout();
			// 
			// btnDijeCarrito
			// 
			this.btnDijeCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDijeCarrito.Location = new System.Drawing.Point(862, 532);
			this.btnDijeCarrito.Margin = new System.Windows.Forms.Padding(4);
			this.btnDijeCarrito.Name = "btnDijeCarrito";
			this.btnDijeCarrito.Size = new System.Drawing.Size(271, 52);
			this.btnDijeCarrito.TabIndex = 29;
			this.btnDijeCarrito.Text = "&Agregar al Carrito";
			this.btnDijeCarrito.UseVisualStyleBackColor = true;
			// 
			// pbDije
			// 
			this.pbDije.Location = new System.Drawing.Point(862, 72);
			this.pbDije.Margin = new System.Windows.Forms.Padding(4);
			this.pbDije.Name = "pbDije";
			this.pbDije.Size = new System.Drawing.Size(271, 264);
			this.pbDije.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbDije.TabIndex = 28;
			this.pbDije.TabStop = false;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(904, 360);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(184, 28);
			this.label2.TabIndex = 27;
			this.label2.Text = "Descripcion Del Producto";
			// 
			// tbxDescripcionDije
			// 
			this.tbxDescripcionDije.Location = new System.Drawing.Point(862, 402);
			this.tbxDescripcionDije.Margin = new System.Windows.Forms.Padding(4);
			this.tbxDescripcionDije.Name = "tbxDescripcionDije";
			this.tbxDescripcionDije.Size = new System.Drawing.Size(271, 22);
			this.tbxDescripcionDije.TabIndex = 26;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(82, 505);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(116, 25);
			this.label1.TabIndex = 25;
			this.label1.Text = "Buscar: ";
			// 
			// tbxBuscarDije
			// 
			this.tbxBuscarDije.Location = new System.Drawing.Point(206, 509);
			this.tbxBuscarDije.Margin = new System.Windows.Forms.Padding(4);
			this.tbxBuscarDije.Name = "tbxBuscarDije";
			this.tbxBuscarDije.Size = new System.Drawing.Size(557, 22);
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
			this.dgvDije.Location = new System.Drawing.Point(82, 59);
			this.dgvDije.Margin = new System.Windows.Forms.Padding(4);
			this.dgvDije.Name = "dgvDije";
			this.dgvDije.Size = new System.Drawing.Size(681, 365);
			this.dgvDije.TabIndex = 23;
			this.dgvDije.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDijeCellContentClick);
			// 
			// FrmDije
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1215, 642);
			this.Controls.Add(this.btnDijeCarrito);
			this.Controls.Add(this.pbDije);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbxDescripcionDije);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbxBuscarDije);
			this.Controls.Add(this.dgvDije);
			this.Name = "FrmDije";
			this.Text = "FrmDije";
			((System.ComponentModel.ISupportInitialize)(this.pbDije)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDije)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridView dgvDije;
		private System.Windows.Forms.TextBox tbxBuscarDije;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbxDescripcionDije;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pbDije;
		private System.Windows.Forms.Button btnDijeCarrito;
	}
}