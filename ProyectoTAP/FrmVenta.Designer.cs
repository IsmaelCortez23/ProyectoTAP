/*
 * Created by SharpDevelop.
 * User: Ismae
 * Date: 15/05/2024
 * Time: 08:46 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Paso_de_datos
{
	partial class Venta
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Total = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Dinero = new System.Windows.Forms.TextBox();
			this.Cambio = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.Pagar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(40, 41);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(336, 148);
			this.dataGridView1.TabIndex = 0;
			// 
			// Total
			// 
			this.Total.Location = new System.Drawing.Point(301, 212);
			this.Total.Margin = new System.Windows.Forms.Padding(2);
			this.Total.Name = "Total";
			this.Total.Size = new System.Drawing.Size(76, 20);
			this.Total.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(221, 214);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 19);
			this.label1.TabIndex = 2;
			this.label1.Text = "Total";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(411, 50);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 19);
			this.label2.TabIndex = 3;
			this.label2.Text = "Pagara con:";
			// 
			// Dinero
			// 
			this.Dinero.Location = new System.Drawing.Point(503, 51);
			this.Dinero.Margin = new System.Windows.Forms.Padding(2);
			this.Dinero.Name = "Dinero";
			this.Dinero.Size = new System.Drawing.Size(76, 20);
			this.Dinero.TabIndex = 4;
			// 
			// Cambio
			// 
			this.Cambio.Location = new System.Drawing.Point(503, 93);
			this.Cambio.Margin = new System.Windows.Forms.Padding(2);
			this.Cambio.Name = "Cambio";
			this.Cambio.Size = new System.Drawing.Size(76, 20);
			this.Cambio.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(411, 92);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 19);
			this.label3.TabIndex = 5;
			this.label3.Text = "Cambio:";
			// 
			// Pagar
			// 
			this.Pagar.Location = new System.Drawing.Point(464, 229);
			this.Pagar.Margin = new System.Windows.Forms.Padding(2);
			this.Pagar.Name = "Pagar";
			this.Pagar.Size = new System.Drawing.Size(56, 19);
			this.Pagar.TabIndex = 7;
			this.Pagar.Text = "Pagar";
			this.Pagar.UseVisualStyleBackColor = true;
			this.Pagar.Click += new System.EventHandler(this.PagarClick);
			// 
			// Venta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(601, 358);
			this.Controls.Add(this.Pagar);
			this.Controls.Add(this.Cambio);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Dinero);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Total);
			this.Controls.Add(this.dataGridView1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Venta";
			this.Text = "Venta";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button Pagar;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox Cambio;
		private System.Windows.Forms.TextBox Dinero;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox Total;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}