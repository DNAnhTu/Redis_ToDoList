using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedisTodoList
{
    public partial class Profile : MetroFramework.Forms.MetroForm
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            fMain form = new fMain();
            Hide();
            form.ShowDialog();
            Show();
        }
    }
}
