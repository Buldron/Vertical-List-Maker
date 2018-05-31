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

		/// <summary>
		/// Opens a dialog menu to select a text file, then calls list creation method.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GetFile_Click(object sender, EventArgs e)
		{
			// Show folder dialog.
			OpenFileDialog fileDialog = new OpenFileDialog();
			DialogResult result = fileDialog.ShowDialog(); 

			// Test result.
			if (result == DialogResult.OK) 
			{
				// Construct file path and contents.
				string file = fileDialog.FileName;
				StringBuilder sb = new StringBuilder();

				// Read and add file contents to StringBuilder.
				using (StreamReader sr = new StreamReader(file))
				{
					String line;
					while ((line = sr.ReadLine()) != null)
					{
						sb.AppendLine(line);
					}

					// Build and print list.
					richTextBox1.Text = BuildList(sb);
				}
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
						if (c.ToString().Contains(" ") || c.ToString().Contains(" "))
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
	}
}
