/*
 * Created by SharpDevelop.
 * User: carlo
 * Date: 16/05/2024
 * Time: 08:05 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoTAP
{
	partial class FrmAgregarProductos
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
			this.label1 = new System.Windows.Forms.Label();
			this.dgvAgregarProducto = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.tbxNombre = new System.Windows.Forms.TextBox();
			this.tbxDescripcion = new System.Windows.Forms.TextBox();
			this.tbxPrecio = new System.Windows.Forms.TextBox();
			this.tbxPieza = new System.Windows.Forms.TextBox();
			this.tbxRuta = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.pbAgregarProducto = new System.Windows.Forms.PictureBox();
			this.Regresar = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnAceptar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvAgregarProducto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbAgregarProducto)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(27, 405);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre";
			// 
			// dgvAgregarProducto
			// 
			this.dgvAgregarProducto.AllowUserToAddRows = false;
			this.dgvAgregarProducto.AllowUserToDeleteRows = false;
			this.dgvAgregarProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvAgregarProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvAgregarProducto.DefaultCellStyle = dataGridViewCellStyle1;
			this.dgvAgregarProducto.Location = new System.Drawing.Point(23, 31);
			this.dgvAgregarProducto.Name = "dgvAgregarProducto";
			this.dgvAgregarProducto.Size = new System.Drawing.Size(831, 330);
			this.dgvAgregarProducto.TabIndex = 1;
			this.dgvAgregarProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAgregarProductoCellClick);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(27, 514);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(27, 443);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Descripcion:";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(27, 481);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "Precio:";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(27, 514);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 5;
			this.label5.Text = "Tipo Pieza:";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(27, 541);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 6;
			this.label6.Text = "Ruta:";
			// 
			// tbxNombre
			// 
			this.tbxNombre.Location = new System.Drawing.Point(149, 405);
			this.tbxNombre.Name = "tbxNombre";
			this.tbxNombre.Size = new System.Drawing.Size(100, 20);
			this.tbxNombre.TabIndex = 7;
			// 
			// tbxDescripcion
			// 
			this.tbxDescripcion.Location = new System.Drawing.Point(149, 443);
			this.tbxDescripcion.Name = "tbxDescripcion";
			this.tbxDescripcion.Size = new System.Drawing.Size(100, 20);
			this.tbxDescripcion.TabIndex = 8;
			// 
			// tbxPrecio
			// 
			this.tbxPrecio.Location = new System.Drawing.Point(149, 470);
			this.tbxPrecio.Name = "tbxPrecio";
			this.tbxPrecio.Size = new System.Drawing.Size(100, 20);
			this.tbxPrecio.TabIndex = 9;
			// 
			// tbxPieza
			// 
			this.tbxPieza.Location = new System.Drawing.Point(149, 496);
			this.tbxPieza.Name = "tbxPieza";
			this.tbxPieza.Size = new System.Drawing.Size(100, 20);
			this.tbxPieza.TabIndex = 10;
			// 
			// tbxRuta
			// 
			this.tbxRuta.Location = new System.Drawing.Point(149, 538);
			this.tbxRuta.Name = "tbxRuta";
			this.tbxRuta.Size = new System.Drawing.Size(100, 20);
			this.tbxRuta.TabIndex = 11;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(463, 417);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(118, 49);
			this.button1.TabIndex = 12;
			this.button1.Text = "Agregar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(604, 414);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(118, 49);
			this.button2.TabIndex = 13;
			this.button2.Text = "Eliminar";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// pbAgregarProducto
			// 
			this.pbAgregarProducto.Location = new System.Drawing.Point(936, 31);
			this.pbAgregarProducto.Name = "pbAgregarProducto";
			this.pbAgregarProducto.Size = new System.Drawing.Size(203, 330);
			this.pbAgregarProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbAgregarProducto.TabIndex = 14;
			this.pbAgregarProducto.TabStop = false;
			// 
			// Regresar
			// 
			this.Regresar.Location = new System.Drawing.Point(817, 428);
			this.Regresar.Name = "Regresar";
			this.Regresar.Size = new System.Drawing.Size(75, 23);
			this.Regresar.TabIndex = 15;
			this.Regresar.Text = "Regresar";
			this.Regresar.UseVisualStyleBackColor = true;
			this.Regresar.Click += new System.EventHandler(this.RegresarClick);
			// 
			// btnModificar
			// 
			this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModificar.Location = new System.Drawing.Point(463, 488);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(118, 49);
			this.btnModificar.TabIndex = 16;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.BtnModificarClick);
			// 
			// btnAceptar
			// 
			this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAceptar.Location = new System.Drawing.Point(604, 488);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(118, 49);
			this.btnAceptar.TabIndex = 17;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// FrmAgregarProductos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1191, 600);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.Regresar);
			this.Controls.Add(this.pbAgregarProducto);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.tbxRuta);
			this.Controls.Add(this.tbxPieza);
			this.Controls.Add(this.tbxPrecio);
			this.Controls.Add(this.tbxDescripcion);
			this.Controls.Add(this.tbxNombre);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dgvAgregarProducto);
			this.Controls.Add(this.label1);
			this.Name = "FrmAgregarProductos";
			this.Text = "FrmAgregarProductos";
			((System.ComponentModel.ISupportInitialize)(this.dgvAgregarProducto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbAgregarProducto)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button Regresar;
		private System.Windows.Forms.PictureBox pbAgregarProducto;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox tbxRuta;
		private System.Windows.Forms.TextBox tbxPieza;
		private System.Windows.Forms.TextBox tbxPrecio;
		private System.Windows.Forms.TextBox tbxDescripcion;
		private System.Windows.Forms.TextBox tbxNombre;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dgvAgregarProducto;
		private System.Windows.Forms.Label label1;
	}
}
