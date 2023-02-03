using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessRandom
{

	public partial class Form1 : Form
	{
		Random rnd = new Random();

		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			bool guessed = false;
			int startNum = 1;
			int endNum = 100;

			while (guessed != true)
			{
				int num = rnd.Next(startNum, endNum);
				int range = endNum - startNum;
				var result = MessageBox.Show($"Is your number higher than {num}?",
											 "Guess your number!",
											 MessageBoxButtons.YesNo,
											 MessageBoxIcon.Question);

				if (range == 1)
				{
					MessageBox.Show($"Your number is {num}!");
					guessed = true;
				}
				else
				{
					if (result == DialogResult.Yes)
					{
						startNum = num;
					}
					else if (result == DialogResult.No)
					{
						endNum = num;
					}
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
