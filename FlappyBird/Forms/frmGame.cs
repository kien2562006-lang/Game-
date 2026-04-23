using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird.Forms
{
    public partial class frmGame : Form
    {
        public frmGame()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("Resources/Background/forest.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;

        }

        private void frmGame_Load(object sender, EventArgs e)
        {

        }
    }
}
