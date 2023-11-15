/*
 * Created by SharpDevelop.
 * User: SUBWAY
 * Date: 19/11/2022
 * Time: 08:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Par_ou_Ímpar
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		int n;
		void Button1Click(object sender, EventArgs e)
		{
			int n;
			n = int.Parse(textBox1.Text);
			textBox1.Text = n.ToString();
			
			if(n % 2 == 0)
			{
				label2.Text = "O " + n + " é par!";
			}
			else
			{
				label2.Text = "O " + n + " é ímpar!";
			}
		}
	}
}
