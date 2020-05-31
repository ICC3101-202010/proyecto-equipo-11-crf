using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Entrega3
{
    public partial class UCLoading : UserControl
    {
        public UCLoading()
        {
            InitializeComponent();
        }

        private void labelLoading_Click(object sender, EventArgs e)
        {

        }

        public void UCLoading_Load(object sender, EventArgs e)
        {

        }
        public void Label_pause() 
        {
            labelLoading.Visible = true;
            
        }
        
        
    }
}
