/*
 * Created by SharpDevelop.
 * User: Pawn Plus
 * Date: 6/14/2018
 * Time: 4:32 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Diagnostics;
using System.Reflection;

namespace SentimentalLauncher
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		String execline="notepad";
		public MainForm(string[] args)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			SoundPlayer player = new SoundPlayer(Assembly.GetExecutingAssembly().GetManifestResourceStream("SentimentalLauncher.Soba - Gardens.wav"));
			player.PlayLooping();
			if(args.Length!=0){
				execline=args[0];
			}
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void ExitButtonClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void StartButtonClick(object sender, EventArgs e)
		{
			Process.Start(execline);
			Application.Exit();
		}
		void OptionsButtonClick(object sender, EventArgs e)
		{
			Options opt = new Options();
			opt.Show();
	}
	}}
