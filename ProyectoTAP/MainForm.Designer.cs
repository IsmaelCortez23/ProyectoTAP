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
			this.menuStrip1.SuspendLayout();
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
									this.esclavasToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(181, 398);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// cadenasToolStripMenuItem
			// 
			this.cadenasToolStripMenuItem.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cadenasToolStripMenuItem.Name = "cadenasToolStripMenuItem";
			this.cadenasToolStripMenuItem.Size = new System.Drawing.Size(174, 54);
			this.cadenasToolStripMenuItem.Text = "Cadenas";
			this.cadenasToolStripMenuItem.Click += new System.EventHandler(this.CadenasToolStripMenuItemClick);
			// 
			// anillosToolStripMenuItem
			// 
			this.anillosToolStripMenuItem.Font = new System.Drawing.Font("Nirmala UI", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.anillosToolStripMenuItem.Name = "anillosToolStripMenuItem";
			this.anillosToolStripMenuItem.Size = new System.Drawing.Size(174, 52);
			this.anillosToolStripMenuItem.Text = "Anillos";
			this.anillosToolStripMenuItem.Click += new System.EventHandler(this.AnillosToolStripMenuItemClick);
			// 
			// aretesToolStripMenuItem
			// 
			this.aretesToolStripMenuItem.Font = new System.Drawing.Font("Nirmala UI", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.aretesToolStripMenuItem.Name = "aretesToolStripMenuItem";
			this.aretesToolStripMenuItem.Size = new System.Drawing.Size(174, 52);
			this.aretesToolStripMenuItem.Text = "Aretes";
			this.aretesToolStripMenuItem.Click += new System.EventHandler(this.AretesToolStripMenuItemClick);
			// 
			// esclavasToolStripMenuItem
			// 
			this.esclavasToolStripMenuItem.Name = "esclavasToolStripMenuItem";
			this.esclavasToolStripMenuItem.Size = new System.Drawing.Size(174, 19);
			this.esclavasToolStripMenuItem.Text = "Esclavas";
			this.esclavasToolStripMenuItem.Click += new System.EventHandler(this.EsclavasToolStripMenuItemClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(729, 398);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "ProyectoTAP";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem esclavasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aretesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem anillosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cadenasToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
