using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pdiez
{
	public partial class Form1 : Form
	{

		private int a;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + "1";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + "2";
		}

		private void button11_Click(object sender, EventArgs e) // boton =
		{
			textBox1.Text = textBox1.Text + "=";
		}

		private void button10_Click(object sender, EventArgs e) //boton 0
		{
			textBox1.Text = textBox1.Text + "0";
		}

		private void button3_Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + "3";
		}

		private void button4_Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + "4";
		}

		private void button5_Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + "5";
		}

		private void button6_Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + "6";
		}

		private void button7_Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + "7";
		}

		private void button8_Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + "8";
		}

		private void button9_Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + "9";
		}

		private void button11_Click_1(object sender, EventArgs e)
		{
			lista.Items.Clear();
			a = int.Parse(textBox1.Text);

			int n;

			for (n = 0; n <= 10; n++)
			{

				int b = a*n;

				lista.Items.Add(b.ToString());

			}

		}

		private void Bborrar_Click(object sender, EventArgs e)
		{

			textBox1.Clear();
			lista.Items.Clear();

		}

		private void multiploSerie_Click(object sender, EventArgs e)
		{
			lista.Items.Clear();
			a = int.Parse(textBox1.Text);
			int n;
			for ( n =0; n<= a; n++) {
				double b = Math.Pow(n,2);

				lista.Items.Add(b.ToString());
}
		}

		private void Fibonacci_Click(object sender, EventArgs e)
		{
			a = int.Parse(textBox1.Text);

			lista.Items.Clear();

			int x = 0;
			int y = 1;
			int z = 1;

			for (int b = 0; b <= a;b++)
			{
				lista.Items.Add(x.ToString());

				x = y;
				y = z;
				z = x + y;
			}

		}

		private void Factoriales_Click(object sender, EventArgs e)
		{
			a = int.Parse(textBox1.Text);

			int c = 1;
			lista.Items.Clear();
			for (int b = a; b >= 1; b--)
			{

				c = c * b;

				textBox1.Text = c.ToString();

			}


		}
	}
}
