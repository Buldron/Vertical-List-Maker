using System;

namespace Vertical_List_Maker
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.GetInput = new System.Windows.Forms.ToolStripMenuItem();
			this.loadWhitelist = new System.Windows.Forms.ToolStripMenuItem();
			this.loadNewLineTrigger = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.inputLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.outputFile = new System.Windows.Forms.Button();
			this.GenerateList = new System.Windows.Forms.Button();
			this.inputFIle = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GetInput,
            this.aboutToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(388, 24);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// GetInput
			// 
			this.GetInput.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadWhitelist,
            this.loadNewLineTrigger});
			this.GetInput.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.GetInput.Name = "GetInput";
			this.GetInput.Size = new System.Drawing.Size(37, 20);
			this.GetInput.Text = "File";
			// 
			// loadWhitelist
			// 
			this.loadWhitelist.Name = "loadWhitelist";
			this.loadWhitelist.Size = new System.Drawing.Size(186, 22);
			this.loadWhitelist.Text = "Load Whitelist";
			this.loadWhitelist.Click += new System.EventHandler(this.LoadWhitelist_Click);
			// 
			// loadNewLineTrigger
			// 
			this.loadNewLineTrigger.Name = "loadNewLineTrigger";
			this.loadNewLineTrigger.Size = new System.Drawing.Size(186, 22);
			this.loadNewLineTrigger.Text = "Load Newline Trigger";
			this.loadNewLineTrigger.Click += new System.EventHandler(this.LoadNewLineTrigger_Click);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.aboutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.aboutToolStripMenuItem.Text = "About";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(57, 49);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(167, 20);
			this.textBox1.TabIndex = 4;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(57, 96);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(167, 20);
			this.textBox2.TabIndex = 5;
			// 
			// inputLabel
			// 
			this.inputLabel.AutoSize = true;
			this.inputLabel.BackColor = System.Drawing.Color.WhiteSmoke;
			this.inputLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.inputLabel.Location = new System.Drawing.Point(54, 33);
			this.inputLabel.Name = "inputLabel";
			this.inputLabel.Size = new System.Drawing.Size(106, 13);
			this.inputLabel.TabIndex = 6;
			this.inputLabel.Text = "Input text file to read:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.Location = new System.Drawing.Point(54, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Output file for list:";
			// 
			// outputFile
			// 
			this.outputFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.outputFile.Location = new System.Drawing.Point(230, 96);
			this.outputFile.Name = "outputFile";
			this.outputFile.Size = new System.Drawing.Size(68, 20);
			this.outputFile.TabIndex = 8;
			this.outputFile.Text = "Select File";
			this.outputFile.UseVisualStyleBackColor = true;
			this.outputFile.Click += new System.EventHandler(this.OutputFile_Click);
			// 
			// GenerateList
			// 
			this.GenerateList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.GenerateList.Location = new System.Drawing.Point(57, 138);
			this.GenerateList.Name = "GenerateList";
			this.GenerateList.Size = new System.Drawing.Size(75, 23);
			this.GenerateList.TabIndex = 9;
			this.GenerateList.Text = "Generate";
			this.GenerateList.UseVisualStyleBackColor = true;
			this.GenerateList.Click += new System.EventHandler(this.GenerateList_Click);
			// 
			// inputFIle
			// 
			this.inputFIle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.inputFIle.Location = new System.Drawing.Point(230, 49);
			this.inputFIle.Name = "inputFIle";
			this.inputFIle.Size = new System.Drawing.Size(68, 20);
			this.inputFIle.TabIndex = 10;
			this.inputFIle.Text = "Select File";
			this.inputFIle.UseVisualStyleBackColor = true;
			this.inputFIle.Click += new System.EventHandler(this.InputFIle_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(388, 252);
			this.Controls.Add(this.inputFIle);
			this.Controls.Add(this.GenerateList);
			this.Controls.Add(this.outputFile);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.inputLabel);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.menuStrip1);
			this.ForeColor = System.Drawing.Color.White;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Buldron\'s Vertical List Builder";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		

		#endregion
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem GetInput;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label inputLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button outputFile;
		private System.Windows.Forms.Button GenerateList;
		private System.Windows.Forms.Button inputFIle;
		private System.Windows.Forms.ToolStripMenuItem loadWhitelist;
		private System.Windows.Forms.ToolStripMenuItem loadNewLineTrigger;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}

