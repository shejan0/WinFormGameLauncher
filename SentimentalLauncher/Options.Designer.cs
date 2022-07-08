/*
 * Created by SharpDevelop.
 * User: Pawn Plus
 * Date: 8/8/2018
 * Time: 6:01 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SentimentalLauncher
{
	partial class Options
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TrackBar volTrack;
		private System.Windows.Forms.Label volLabel;
		private System.Windows.Forms.Label VertLabel;
		private System.Windows.Forms.TextBox verText;
		private System.Windows.Forms.TextBox horText;
		private System.Windows.Forms.Label horLabel;
		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.Label trackLabel;
		private System.Windows.Forms.Label autoSaveLabel;
		
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
			this.volTrack = new System.Windows.Forms.TrackBar();
			this.volLabel = new System.Windows.Forms.Label();
			this.VertLabel = new System.Windows.Forms.Label();
			this.verText = new System.Windows.Forms.TextBox();
			this.horText = new System.Windows.Forms.TextBox();
			this.horLabel = new System.Windows.Forms.Label();
			this.SaveButton = new System.Windows.Forms.Button();
			this.trackLabel = new System.Windows.Forms.Label();
			this.autoSaveLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.volTrack)).BeginInit();
			this.SuspendLayout();
			// 
			// volTrack
			// 
			this.volTrack.Location = new System.Drawing.Point(128, 111);
			this.volTrack.Name = "volTrack";
			this.volTrack.Size = new System.Drawing.Size(104, 45);
			this.volTrack.TabIndex = 0;
			this.volTrack.Value = 5;
			this.volTrack.Scroll += new System.EventHandler(this.VolTrackScroll);
			// 
			// volLabel
			// 
			this.volLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.volLabel.Location = new System.Drawing.Point(22, 111);
			this.volLabel.Name = "volLabel";
			this.volLabel.Size = new System.Drawing.Size(100, 23);
			this.volLabel.TabIndex = 1;
			this.volLabel.Text = "Volume";
			this.volLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// VertLabel
			// 
			this.VertLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.VertLabel.Location = new System.Drawing.Point(22, 66);
			this.VertLabel.Name = "VertLabel";
			this.VertLabel.Size = new System.Drawing.Size(100, 23);
			this.VertLabel.TabIndex = 2;
			this.VertLabel.Text = "Vertical";
			this.VertLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// verText
			// 
			this.verText.Location = new System.Drawing.Point(128, 68);
			this.verText.Name = "verText";
			this.verText.Size = new System.Drawing.Size(100, 20);
			this.verText.TabIndex = 3;
			this.verText.Text = "480";
			this.verText.TextChanged += new System.EventHandler(this.VerTextTextChanged);
			// 
			// horText
			// 
			this.horText.Location = new System.Drawing.Point(128, 24);
			this.horText.Name = "horText";
			this.horText.Size = new System.Drawing.Size(100, 20);
			this.horText.TabIndex = 5;
			this.horText.Text = "640";
			this.horText.TextChanged += new System.EventHandler(this.HorTextTextChanged);
			// 
			// horLabel
			// 
			this.horLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.horLabel.Location = new System.Drawing.Point(20, 22);
			this.horLabel.Name = "horLabel";
			this.horLabel.Size = new System.Drawing.Size(100, 23);
			this.horLabel.TabIndex = 4;
			this.horLabel.Text = "Horizontal";
			this.horLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(96, 176);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(75, 23);
			this.SaveButton.TabIndex = 6;
			this.SaveButton.Text = "OK";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButtonClick);
			// 
			// trackLabel
			// 
			this.trackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.trackLabel.Location = new System.Drawing.Point(128, 150);
			this.trackLabel.Name = "trackLabel";
			this.trackLabel.Size = new System.Drawing.Size(100, 23);
			this.trackLabel.TabIndex = 7;
			this.trackLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// autoSaveLabel
			// 
			this.autoSaveLabel.Location = new System.Drawing.Point(12, 229);
			this.autoSaveLabel.Name = "autoSaveLabel";
			this.autoSaveLabel.Size = new System.Drawing.Size(243, 23);
			this.autoSaveLabel.TabIndex = 8;
			// 
			// Options
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(267, 261);
			this.Controls.Add(this.autoSaveLabel);
			this.Controls.Add(this.trackLabel);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.horText);
			this.Controls.Add(this.horLabel);
			this.Controls.Add(this.verText);
			this.Controls.Add(this.VertLabel);
			this.Controls.Add(this.volLabel);
			this.Controls.Add(this.volTrack);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Options";
			this.Text = "Options";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClose);
			this.Load += new System.EventHandler(this.OptionsLoad);
			((System.ComponentModel.ISupportInitialize)(this.volTrack)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
