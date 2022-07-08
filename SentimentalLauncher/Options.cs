/*
 * Created by SharpDevelop.
 * User: Pawn Plus
 * Date: 8/8/2018
 * Time: 6:01 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text;
namespace SentimentalLauncher
{
	/// <summary>
	/// Description of Options.
	/// </summary>
	public partial class Options : Form
	{
		FileStream configfile;
		Timer timer;
		public Options()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			timer = new Timer();
			timer.Interval=60000;
			timer.Tick+=AutoSaveFunction;
			timer.Start();
			configfile = File.Open("game_config.cfg",FileMode.OpenOrCreate);
			BinaryReader reader = new BinaryReader(configfile,Encoding.UTF8,true);
			if(configfile.Length!=0){
				horText.Text=reader.ReadInt32().ToString();
				verText.Text=reader.ReadInt32().ToString();
				volTrack.Value = reader.ReadByte();
				trackLabel.Text=volTrack.Value.ToString();
				updateSaveLabel(File.GetLastWriteTime("game_config.cfg"));
			}
		}
		void saveFile(){
			configfile.Seek(0,SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(configfile,Encoding.UTF8,true);
			writer.Write(Int32.Parse(horText.Text));
			writer.Write(Int32.Parse(verText.Text));
			writer.Write((byte)volTrack.Value);
		}
		void updateSaveLabel(DateTime time){
			autoSaveLabel.Text = "Last Saved: "+time.ToString();
		}
		void VolTrackScroll(object sender, EventArgs e)
		{
			trackLabel.Text=volTrack.Value.ToString();
		}
		void VerTextTextChanged(object sender, EventArgs e)
		{
			
		}
		void HorTextTextChanged(object sender, EventArgs e)
		{
	
		}
		void SaveButtonClick(object sender, EventArgs e)
		{
			saveAndClose();
		}
		void saveAndClose(){
			timer.Stop();
			saveFile();
			configfile.Close();
			this.Close();
		}
		void AutoSaveFunction(object sender, EventArgs e)
		{
			saveFile();
			updateSaveLabel(DateTime.Now);
		}
		void FormClose(object sender, FormClosingEventArgs e){
			configfile.Close();
		}
		void OptionsLoad(object sender, EventArgs e)
		{
			
		}
	}
}
