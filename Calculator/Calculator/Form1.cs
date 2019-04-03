using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		public static string previusEq = "", prevOperation = "", operation = "";
		public static double answer = 0;

		private void Operation_Click(object sender, EventArgs e)
		{
			Button opr = sender as Button;

			// dont repeat yourself W SWITCHU OPR.TEXT
			 void Operacja(string znak)
			{
				if (textDisplay1.Text.Length > 0)
				{
					if (operation == "" || operation == "=")
					{
						operation = znak;
						prevOperation = operation;
						previusEq = textDisplay1.Text;
						textDisplay2.Text = previusEq + operation;
						textDisplay1.ResetText();
					}
				}
				else
				{
					operation = znak;
					multi_eq();
				}
			}
			switch (opr.Text)
			{
				case "+":
					Operacja("+");							
					break;
				case "-":
					Operacja("-");
					break;
				case "/":
					Operacja("/");
					break;
				case "X":
					Operacja("X");
					break;
				case "=":
					if (textDisplay1.Text.Length > 0)
					{
						operation = "=";
						multi_eq();
						textDisplay2.ResetText();
						textDisplay1.Text = answer.ToString();
					}
					break;
				default:
					break;
			}
		}
		private void AllBtn_Click (object sender, EventArgs e)
		{
			Button btn = sender as Button;

			switch (btn.Name)
			{
				case "btnDel":
					if (textDisplay1.Text.Length > 0)
					{
						textDisplay1.Text = textDisplay1.Text.Substring(0, textDisplay1.Text.Length - 1);
					}
					break;
				case "btnCE":
					operation = "";
					textDisplay1.ResetText();
					textDisplay2.ResetText();
					break;
				case "btnC":
					textDisplay1.ResetText();
					break;
				case "btnKropka":
					if (!textDisplay1.Text.Contains(".")){
						textDisplay1.Text += ",";
					}
					break;
				default:
					if(operation == "=")
					{
						operation = "";
						textDisplay1.ResetText();
					}

					textDisplay1.Text += btn.Text;
					break;
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void textDisplay2_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			// close
			Application.Exit();
		}

		private void multi_eq()
		{
			if (prevOperation == "+")
			{
				prevOperation = operation;
				answer = Convert.ToDouble(previusEq) + Convert.ToDouble(textDisplay1.Text);
				Rozwin();
			}
			else if (prevOperation=="-")
			{
				prevOperation = operation;
				answer = Convert.ToDouble(previusEq) - Convert.ToDouble(textDisplay1.Text);
				Rozwin();
			}
			else if (prevOperation=="/")
			{
				prevOperation = operation;
				answer = Convert.ToDouble(previusEq) / Convert.ToDouble(textDisplay1.Text);
				Rozwin();
			}
			else if(prevOperation=="X")
			{
				prevOperation = operation;
				answer = Convert.ToDouble(previusEq) * Convert.ToDouble(textDisplay1.Text);
				Rozwin();
			}
		}

		private void Rozwin()
		{			
			previusEq = answer.ToString();
			textDisplay2.Text = previusEq + operation;
			textDisplay1.ResetText();
		}
	}
}
