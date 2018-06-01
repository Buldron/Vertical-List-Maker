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
		public Form1()
		{
			// Initialize form icon.
			ComponentResourceManager resources = new ComponentResourceManager(typeof(Form));
			Icon = new Icon("Resources/icon.ico");

			InitializeComponent();
		}
		
		string inputPath;
		string outputPath;
				
		private void inputFIle_Click(object sender, EventArgs e)
		{			
			OpenFileDialog fileDialog = new OpenFileDialog();
			fileDialog.Filter = "TXT|*.txt";
			DialogResult result = fileDialog.ShowDialog();

			// Test result.
			if (result == DialogResult.OK)
			{
				// Set file path.
				inputPath = fileDialog.FileName;
				textBox1.Text = inputPath;
			}
		}

		private void outputFile_Click(object sender, EventArgs e)
		{
			// Show folder dialog.
			OpenFileDialog fileDialog = new OpenFileDialog();
			fileDialog.Filter = "TXT|*.txt";
			DialogResult result = fileDialog.ShowDialog();
			
			// Test result.
			if (result == DialogResult.OK)
			{
				// Construct file path and contents.			
				outputPath = fileDialog.FileName;
				textBox2.Text = outputPath;
			}
		}


		/// <summary>
		/// Takes a string of words as an input, outputs a vertical list.
		/// </summary>
		/// <param name="Input"></param>
		/// <returns></returns>
		private string BuildList(StringBuilder Input)
		{
			StringBuilder list = new StringBuilder();
			char[] input = Input.ToString().ToCharArray();

			// Replaces spaces with new lines.
			foreach (char c in input)
			{
				// Ignore commas.
				if (!c.ToString().Contains(",") && !c.ToString().Contains("'") && !c.ToString().Contains(".") && !c.ToString().Contains("-") && !c.ToString().Contains("\""))
				{
					if (!c.ToString().Contains("(") && !c.ToString().Contains(")") && !c.ToString().Contains(";") && !c.ToString().Contains("�"))
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
			}

			// Return list.
			return list.ToString();
		}

		private void GenerateList_Click(object sender, EventArgs e)
		{
			StringBuilder sb = new StringBuilder();

			// Read and add file contents to StringBuilder.
			using (StreamReader sr = new StreamReader(inputPath))
			{
				String line;
				while ((line = sr.ReadLine()) != null)
				{
					sb.AppendLine(line);
				}

				using (StreamWriter writer = new StreamWriter(outputPath))
				{
					string list = BuildList(sb);
					writer.Write(list);
				}				
			}
		}
	}
}
