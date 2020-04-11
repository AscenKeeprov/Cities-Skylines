using Localizer.Utils;
using System;
using System.Windows.Forms;

namespace Localizer
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

		private void Main_Load(object sender, EventArgs eventArgs)
		{
			Logger.Clear();
			Logger.Log("Loading main form");
		}

		private void Main_FormClosing(object sender, FormClosingEventArgs eventArgs)
		{
			Logger.Log("Closing main form");
		}
	}
}
