using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GD
{
	public partial class SplashScreen : Form
	{
		public SplashScreen()
		{
			InitializeComponent();
		}

		private void SplashScreen_Load(object sender, EventArgs e)
		{
			label1.Text = "";
			label2.Text = "";
			label3.Text = "";
			label4.Text = "";
			label5.Text = "";
			label6.Text = "";
			label1.BackColor = Color.Transparent;
			label2.BackColor = Color.Transparent;
			label3.BackColor = Color.Transparent;
			label4.BackColor = Color.Transparent;
			label5.BackColor = Color.Transparent;
			label6.BackColor = Color.Transparent;
			label1.ForeColor = Color.White;
			label2.ForeColor = Color.White;
			label3.ForeColor = Color.White;
			label4.ForeColor = Color.White;
			label5.ForeColor = Color.Red;
			label5.Font = new Font(label5.Font, FontStyle.Underline);
			label6.ForeColor = Color.LightGray;

			SetAuthorText();
		}

		private async void SetAuthorText()
		{
			await Task.Run(() =>
			{
				Thread.Sleep(1000);
				label1.Text = "NIKITA KRUZHIKIN";
				Thread.Sleep(1000);
				label2.Text = "AND";
				Thread.Sleep(1000);
				label3.Text = "OLEG SERGUSHIN";
				Thread.Sleep(1000);
				label4.Text = "PERESNTS";
				Thread.Sleep(1000);
				label5.Text = "Project 'AFCTNOEMAITT'";
				Thread.Sleep(500);
				label6.Text = "application for counting the number of e-mail addresses in the text";
			});
            Thread.Sleep(3000);
            StartTheProgram();
        }

		private void StartTheProgram()
        {
			FindMailsInTheTextForm formFind = new FindMailsInTheTextForm();
			formFind.Show();
			this.Hide();
		}
	}
}
