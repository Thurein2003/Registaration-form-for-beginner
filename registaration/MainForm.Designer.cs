/*
 * Created by SharpDevelop.
 * User: User
 * Date: 3/28/2023
 * Time: 8:39 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Regestriation
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
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(199, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(151, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "User Name";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(296, 46);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(156, 20);
			this.textBox1.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(199, 90);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 27);
			this.label2.TabIndex = 2;
			this.label2.Text = "Password";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(296, 88);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(155, 20);
			this.textBox2.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(201, 120);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 28);
			this.label3.TabIndex = 4;
			this.label3.Text = "Email";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(296, 121);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(154, 20);
			this.textBox3.TabIndex = 5;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(309, 197);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(142, 43);
			this.button1.TabIndex = 6;
			this.button1.Text = "Register";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(630, 470);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Regestriation";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
	}
}
