/*
 * Created by SharpDevelop.
 * User: carlo
 * Date: 30/04/2024
 * Time: 05:58 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoTAP
{
	partial class MainForm
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.cadenasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.anillosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aretesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.esclavasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.juegoDeAretesCadenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.digesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip2 = new System.Windows.Forms.MenuStrip();
			this.agregarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.menuStrip2.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
			this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.cadenasToolStripMenuItem,
									this.anillosToolStripMenuItem,
									this.aretesToolStripMenuItem,
									this.esclavasToolStripMenuItem,
									this.juegoDeAretesCadenaToolStripMenuItem,
									this.digesToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(442, 342);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// cadenasToolStripMenuItem
			// 
			this.cadenasToolStripMenuItem.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cadenasToolStripMenuItem.Name = "cadenasToolStripMenuItem";
			this.cadenasToolStripMenuItem.Size = new System.Drawing.Size(435, 54);
			this.cadenasToolStripMenuItem.Text = "Cadenas";
			this.cadenasToolStripMenuItem.Click += new System.EventHandler(this.CadenasToolStripMenuItemClick);
			// 
			// anillosToolStripMenuItem
			// 
			this.anillosToolStripMenuItem.Font = new System.Drawing.Font("Nirmala UI", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.anillosToolStripMenuItem.Name = "anillosToolStripMenuItem";
			this.anillosToolStripMenuItem.Size = new System.Drawing.Size(435, 52);
			this.anillosToolStripMenuItem.Text = "Anillos";
			this.anillosToolStripMenuItem.Click += new System.EventHandler(this.AnillosToolStripMenuItemClick);
			// 
			// aretesToolStripMenuItem
			// 
			this.aretesToolStripMenuItem.Font = new System.Drawing.Font("Nirmala UI", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.aretesToolStripMenuItem.Name = "aretesToolStripMenuItem";
			this.aretesToolStripMenuItem.Size = new System.Drawing.Size(435, 52);
			this.aretesToolStripMenuItem.Text = "Aretes";
			this.aretesToolStripMenuItem.Click += new System.EventHandler(this.AretesToolStripMenuItemClick);
			// 
			// esclavasToolStripMenuItem
			// 
			this.esclavasToolStripMenuItem.Font = new System.Drawing.Font("Nirmala UI", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.esclavasToolStripMenuItem.Name = "esclavasToolStripMenuItem";
			this.esclavasToolStripMenuItem.Size = new System.Drawing.Size(435, 52);
			this.esclavasToolStripMenuItem.Text = "Esclavas";
			this.esclavasToolStripMenuItem.Click += new System.EventHandler(this.EsclavasToolStripMenuItemClick);
			// 
			// juegoDeAretesCadenaToolStripMenuItem
			// 
			this.juegoDeAretesCadenaToolStripMenuItem.Font = new System.Drawing.Font("Nirmala UI", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.juegoDeAretesCadenaToolStripMenuItem.Name = "juegoDeAretesCadenaToolStripMenuItem";
			this.juegoDeAretesCadenaToolStripMenuItem.Size = new System.Drawing.Size(435, 52);
			this.juegoDeAretesCadenaToolStripMenuItem.Text = "Juego de Aretes-Cadena";
			this.juegoDeAretesCadenaToolStripMenuItem.Click += new System.EventHandler(this.JuegoDeAretesCadenaToolStripMenuItemClick);
			// 
			// digesToolStripMenuItem
			// 
			this.digesToolStripMenuItem.Font = new System.Drawing.Font("Nirmala UI", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.digesToolStripMenuItem.Name = "digesToolStripMenuItem";
			this.digesToolStripMenuItem.Size = new System.Drawing.Size(435, 52);
			this.digesToolStripMenuItem.Text = "Dijes";
			this.digesToolStripMenuItem.Click += new System.EventHandler(this.DigesToolStripMenuItemClick);
			// 
			// menuStrip2
			// 
			this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.agregarProductosToolStripMenuItem});
			this.menuStrip2.Location = new System.Drawing.Point(0, 342);
			this.menuStrip2.Name = "menuStrip2";
			this.menuStrip2.Size = new System.Drawing.Size(729, 56);
			this.menuStrip2.TabIndex = 1;
			this.menuStrip2.Text = "menuStrip2";
			// 
			// agregarProductosToolStripMenuItem
			// 
			this.agregarProductosToolStripMenuItem.Font = new System.Drawing.Font("Nirmala UI", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.agregarProductosToolStripMenuItem.Name = "agregarProductosToolStripMenuItem";
			this.agregarProductosToolStripMenuItem.Size = new System.Drawing.Size(348, 52);
			this.agregarProductosToolStripMenuItem.Text = "Agregar Productos";
			this.agregarProductosToolStripMenuItem.Click += new System.EventHandler(this.AgregarProductosToolStripMenuItemClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(729, 398);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.menuStrip2);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "ProyectoTAP";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.menuStrip2.ResumeLayout(false);
			this.menuStrip2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem agregarProductosToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip2;
		private System.Windows.Forms.ToolStripMenuItem digesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem juegoDeAretesCadenaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem esclavasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aretesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem anillosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cadenasToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
