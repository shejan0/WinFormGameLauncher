/*
 * Created by SharpDevelop.
 * User: Pawn Plus
 * Date: 6/14/2018
 * Time: 4:32 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SentimentalLauncher
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button StartButton;
		private System.Windows.Forms.Button OptionsButton;
		private System.Windows.Forms.Button ExitButton;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.StartButton = new System.Windows.Forms.Button();
			this.OptionsButton = new System.Windows.Forms.Button();
			this.ExitButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// StartButton
			// 
			this.StartButton.BackColor = System.Drawing.Color.Transparent;
			this.StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.StartButton.FlatAppearance.BorderSize = 0;
			this.StartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.StartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.StartButton.Font = new System.Drawing.Font("Monofonto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StartButton.Location = new System.Drawing.Point(12, 176);
			this.StartButton.Name = "StartButton";
			this.StartButton.Size = new System.Drawing.Size(213, 48);
			this.StartButton.TabIndex = 0;
			this.StartButton.Text = "Start Game";
			this.StartButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.StartButton.UseVisualStyleBackColor = false;
			this.StartButton.Click += new System.EventHandler(this.StartButtonClick);
			// 
			// OptionsButton
			// 
			this.OptionsButton.BackColor = System.Drawing.Color.Transparent;
			this.OptionsButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.OptionsButton.FlatAppearance.BorderSize = 0;
			this.OptionsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.OptionsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.OptionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.OptionsButton.Font = new System.Drawing.Font("Monofonto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OptionsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.OptionsButton.Location = new System.Drawing.Point(12, 226);
			this.OptionsButton.Name = "OptionsButton";
			this.OptionsButton.Size = new System.Drawing.Size(213, 38);
			this.OptionsButton.TabIndex = 1;
			this.OptionsButton.Text = "Options";
			this.OptionsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.OptionsButton.UseVisualStyleBackColor = false;
			this.OptionsButton.Click += new System.EventHandler(this.OptionsButtonClick);
			// 
			// ExitButton
			// 
			this.ExitButton.BackColor = System.Drawing.Color.Transparent;
			this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ExitButton.FlatAppearance.BorderSize = 0;
			this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ExitButton.Font = new System.Drawing.Font("Monofonto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ExitButton.Location = new System.Drawing.Point(12, 270);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(213, 34);
			this.ExitButton.TabIndex = 2;
			this.ExitButton.Text = "Exit";
			this.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ExitButton.UseVisualStyleBackColor = false;
			this.ExitButton.Click += new System.EventHandler(this.ExitButtonClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(838, 396);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.OptionsButton);
			this.Controls.Add(this.StartButton);
			this.Cursor = System.Windows.Forms.Cursors.No;
			this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SentimentalLauncher";
			this.ResumeLayout(false);

		}
	}
}
