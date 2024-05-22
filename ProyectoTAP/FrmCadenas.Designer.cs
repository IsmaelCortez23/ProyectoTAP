/*
 * Created by SharpDevelop.
 * User: carlo
 * Date: 02/05/2024
 * Time: 09:40 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoTAP
{
	partial class FrmCadenas
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
			this.dgvCadenas = new System.Windows.Forms.DataGridView();
			this.tbxBuscarCadenas = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbxDescripcionCadenas = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.pbCadenas = new System.Windows.Forms.PictureBox();
			this.btnCadenaCarrito = new System.Windows.Forms.Button();
			this.Regresar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvCadenas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbCadenas)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvCadenas
			// 
			this.dgvCadenas.AllowUserToAddRows = false;
			this.dgvCadenas.AllowUserToDeleteRows = false;
			this.dgvCadenas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvCadenas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvCadenas.DefaultCellStyle = dataGridViewCellStyle1;
			this.dgvCadenas.Location = new System.Drawing.Point(36, 33);
			this.dgvCadenas.Name = "dgvCadenas";
			this.dgvCadenas.Size = new System.Drawing.Size(777, 332);
			this.dgvCadenas.TabIndex = 0;
			this.dgvCadenas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCadenasCellClick);
			// 
			// tbxBuscarCadenas
			// 
			this.tbxBuscarCadenas.Location = new System.Drawing.Point(129, 426);
			this.tbxBuscarCadenas.Name = "tbxBuscarCadenas";
			this.tbxBuscarCadenas.Size = new System.Drawing.Size(356, 20);
			this.tbxBuscarCadenas.TabIndex = 2;
			this.tbxBuscarCadenas.TextChanged += new System.EventHandler(this.TbxBuscarCadenasTextChanged);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(36, 426);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "Buscar: ";
			// 
			// tbxDescripcionCadenas
			// 
			this.tbxDescripcionCadenas.Location = new System.Drawing.Point(950, 432);
			this.tbxDescripcionCadenas.Name = "tbxDescripcionCadenas";
			this.tbxDescripcionCadenas.Size = new System.Drawing.Size(138, 20);
			this.tbxDescripcionCadenas.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(950, 406);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(138, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Descripcion Del Producto";
			// 
			// pbCadenas
			// 
			this.pbCadenas.Location = new System.Drawing.Point(901, 33);
			this.pbCadenas.Name = "pbCadenas";
			this.pbCadenas.Size = new System.Drawing.Size(228, 332);
			this.pbCadenas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbCadenas.TabIndex = 7;
			this.pbCadenas.TabStop = false;
			// 
			// btnCadenaCarrito
			// 
			this.btnCadenaCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCadenaCarrito.Location = new System.Drawing.Point(605, 470);
			this.btnCadenaCarrito.Name = "btnCadenaCarrito";
			this.btnCadenaCarrito.Size = new System.Drawing.Size(244, 42);
			this.btnCadenaCarrito.TabIndex = 8;
			this.btnCadenaCarrito.Text = "&Agregar al Carrito";
			this.btnCadenaCarrito.UseVisualStyleBackColor = true;
			this.btnCadenaCarrito.Click += new System.EventHandler(this.BtnCadenaCarritoClick);
			// 
			// Regresar
			// 
			this.Regresar.Location = new System.Drawing.Point(978, 477);
			this.Regresar.Name = "Regresar";
			this.Regresar.Size = new System.Drawing.Size(75, 23);
			this.Regresar.TabIndex = 9;
			this.Regresar.Text = "Regresar";
			this.Regresar.UseVisualStyleBackColor = true;
			this.Regresar.Click += new System.EventHandler(this.RegresarClick);
			// 
			// FrmCadenas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1187, 524);
			this.Controls.Add(this.Regresar);
			this.Controls.Add(this.btnCadenaCarrito);
			this.Controls.Add(this.pbCadenas);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbxDescripcionCadenas);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbxBuscarCadenas);
			this.Controls.Add(this.dgvCadenas);
			this.Name = "FrmCadenas";
			this.Text = "FrmCadenas";
			((System.ComponentModel.ISupportInitialize)(this.dgvCadenas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbCadenas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button Regresar;
		private System.Windows.Forms.Button btnCadenaCarrito;
		private System.Windows.Forms.PictureBox pbCadenas;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbxDescripcionCadenas;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbxBuscarCadenas;
		private System.Windows.Forms.DataGridView dgvCadenas;
		
		
	}
}
