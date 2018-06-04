using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Vertical_List_Maker
{
	public partial class Form1 : Form
	{
		string inputPath;
		string outputPath;
		string whitelistPath;
		string charWhitelist;
		string lineTriggerPath;

		public Form1()
		{
			// Initialize form icon.
			ComponentResourceManager resources = new ComponentResourceManager(typeof(Form));
			Icon = new Icon("Resources/icon.ico");

			InitializeComponent();

			whitelistPath = Path.Combine(Environment.CurrentDirectory, "Settings/defaultWhitelist.txt");
			lineTriggerPath = "Settings/defaultNewLineTrigger.txt";
			textBox1.Text = whitelistPath;
		}

		private void InputFIle_Click(object sender, EventArgs e)
		{
			MenuLoadReadFile(V.Input);
			textBox1.Text = inputPath;			
		}

		private void OutputFile_Click(object sender, EventArgs e)
		{
			MenuLoadReadFile(V.Output);
			textBox2.Text = outputPath;
		}


		/// <summary>
		/// Takes a string of words as an input, outputs a vertical list.
		/// </summary>
		/// <param name="Input"></param>
		/// <returns></returns>
		private string BuildList(string Input)
		{
			StringBuilder list = new StringBuilder();
			char[] input = Input.ToCharArray();

			// Replaces spaces with new lines.
			foreach (char c in input)
			{
				// Ignore commas.
				if (CheckCharWhitelist(c))
				{
					// Newline on spaces, print everything else.
					if (c.ToString().Contains(" ") || c.ToString().Contains(" ") || c.ToString().Contains("	"))
					{
						list.AppendLine();
					}
					else
					{
						list.Append(c);
					}
				}
			}

			// Return list.
			return list.ToString();
		}


		private bool CheckCharWhitelist(char c)
		{
			if (charWhitelist.ToLower().Contains(c.ToString().ToLower()))
			{
				return true;
			}
			return false;
		}


		private void GenerateList_Click(object sender, EventArgs e)
		{
			string list = MenuLoadReadFile(V.Other);
			Console.Write(list);
			// Write modified list to outputh file.
			using (StreamWriter writer = new StreamWriter(outputPath))
			{
				list = BuildList(list);
				writer.Write(list);
			}
		}
		

		private void LoadWhitelist_Click(object sender, EventArgs e)
		{
			charWhitelist = MenuLoadReadFile(V.Whitelist);
		}



		enum V { Input, Output, Whitelist, LineTrigger, Other };
		private string MenuLoadReadFile(V v)
		{
			string path = inputPath;
			

			if(v != V.Other)
			{
				OpenFileDialog fileDialog = new OpenFileDialog
				{
					Filter = "TXT|*.txt"
				};
				// Test result and get file path.
				DialogResult result = fileDialog.ShowDialog();
				if (result == DialogResult.OK)
				{
					// Set file path.
					path = fileDialog.FileName;
				}
			}
			
			

			// Read and add file contents to string.
			StringBuilder sb = new StringBuilder();
			using (StreamReader sr = new StreamReader(path))
			{
				String line;
				while ((line = sr.ReadLine()) != null)
				{
					sb.AppendLine(line);
				}
			}

			// Set path.
			switch (v)
			{
				case V.Input:
					inputPath = path;
					break;
				case V.Output:
					outputPath = path;
					break;
				case V.Whitelist:
					whitelistPath = path;
					break;
				case V.LineTrigger:
					lineTriggerPath = path;
					break;
				default:
					break;
			}

			// Return file contents as string.
			return sb.ToString();
		}


		private void LoadNewLineTrigger_Click(object sender, EventArgs e)
		{

		}
	}
}
