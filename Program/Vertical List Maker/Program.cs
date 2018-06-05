using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Vertical_List_Maker
{
	static class Program
	{	
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}


		public static void BuildList(string Input, string outputPath, string whitelist, string newlineTrigger)
		{
			StringBuilder list = new StringBuilder();
			char[] input = Input.ToCharArray();

			// Replaces spaces with new lines.
			foreach (char c in input)
			{				
				if (CheckCharWhitelist(c, whitelist))
				{					
					if (newlineTrigger.Contains(c.ToString()))
					{
						list.AppendLine();
					}
					else
					{
						list.Append(c);
					}
				}
			}

			if(outputPath != null && list != null)
			{
				// Write modified list to outputh file.
				using (StreamWriter writer = new StreamWriter(outputPath))
				{
					writer.Write(list.ToString());
				}
			}			
		}


		private static bool CheckCharWhitelist(char c, string whitelist)
		{
			if (whitelist.ToLower().Contains(c.ToString().ToLower()))
			{
				return true;
			}
			return false;
		}


		public static string[] ReadFile(string path, bool openMenu)
		{
			string _path = path;
			if(openMenu)
			{
				_path = OpenMenu();
			}

			// Read and add file contents to string.
			StringBuilder sb = new StringBuilder();

			if (_path != null)
			{
				using (StreamReader sr = new StreamReader(_path))
				{
					String line;
					while ((line = sr.ReadLine()) != null)
					{
						sb.AppendLine(line);
					}
				}
			}
			// Return file path and contents.
			string[] a = { _path, sb.ToString() };
			return a;
		}


		private static string OpenMenu()
		{			
			OpenFileDialog fileDialog = new OpenFileDialog
			{
				Filter = "TXT|*.txt"
			};

			// Test result and return file path.
			DialogResult result = fileDialog.ShowDialog();
			if (result == DialogResult.OK)
			{			
				return fileDialog.FileName;
			}
			return null;
		}


		public static bool CanBuildList(string inputPath, string outputPath, string whitelistPath, string newlineTriggerPath)
		{
			if (inputPath != null && outputPath != null && whitelistPath != null && newlineTriggerPath != null)
			{
				return true;
			}
			return false;
		}
	}
}
