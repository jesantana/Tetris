using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace t1
{
	
	public class HighS : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private string nombre;

		private System.ComponentModel.Container components = null;

		public HighS()
		{
			
			InitializeComponent();

			
		}

		
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(32, 56);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(280, 20);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Lithograph", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label1.Location = new System.Drawing.Point(32, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(280, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "NUEVO RECORD!!!!!!!!!";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(88, 104);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(152, 48);
			this.button1.TabIndex = 2;
			this.button1.Text = "&Aceptar";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// HighS
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(352, 190);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button1,
																		  this.label1,
																		  this.textBox1});
			this.Name = "HighS";
			this.Text = "HighS";
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			if(textBox1.Text.Trim()!=""){
			nombre=textBox1.Text;
			this.Visible=false;			
			}
		}
		public string Nombre{
			get{return nombre;}
		
		}
	
	}
}
