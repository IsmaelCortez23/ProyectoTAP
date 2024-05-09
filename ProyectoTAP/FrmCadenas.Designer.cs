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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvCadenas = new System.Windows.Forms.DataGridView();
			this.tbxBuscarCadenas = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbxDescripcionCadenas = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.pbCadenas = new System.Windows.Forms.PictureBox();
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
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvCadenas.DefaultCellStyle = dataGridViewCellStyle4;
			this.dgvCadenas.Location = new System.Drawing.Point(36, 33);
			this.dgvCadenas.Name = "dgvCadenas";
			this.dgvCadenas.Size = new System.Drawing.Size(453, 283);
			this.dgvCadenas.TabIndex = 0;
			this.dgvCadenas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCadenasCellDoubleClick);
			// 
			// tbxBuscarCadenas
			// 
			this.tbxBuscarCadenas.Location = new System.Drawing.Point(151, 356);
			this.tbxBuscarCadenas.Name = "tbxBuscarCadenas";
			this.tbxBuscarCadenas.Size = new System.Drawing.Size(356, 20);
			this.tbxBuscarCadenas.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(36, 356);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "Buscar: ";
			// 
			// tbxDescripcionCadenas
			// 
			this.tbxDescripcionCadenas.Location = new System.Drawing.Point(550, 296);
			this.tbxDescripcionCadenas.Name = "tbxDescripcionCadenas";
			this.tbxDescripcionCadenas.Size = new System.Drawing.Size(138, 20);
			this.tbxDescripcionCadenas.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(568, 264);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(138, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Descripcion Del Producto";
			// 
			// pbCadenas
			// 
			this.pbCadenas.Location = new System.Drawing.Point(568, 33);
			this.pbCadenas.Name = "pbCadenas";
			this.pbCadenas.Size = new System.Drawing.Size(153, 194);
			this.pbCadenas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbCadenas.TabIndex = 7;
			this.pbCadenas.TabStop = false;
			// 
			// FrmCadenas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(779, 415);
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
		private System.Windows.Forms.PictureBox pbCadenas;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbxDescripcionCadenas;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbxBuscarCadenas;
		private System.Windows.Forms.DataGridView dgvCadenas;
		
		
	}
}
