using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Genius
{
    public partial class frRecordes : Form
    {
        public frRecordes()
        {
            InitializeComponent();
            this.TransparencyKey = this.BackColor = Color.Turquoise;
            if(File.Exists("RECORDES.txt"))
            {
                string [] texto = File.ReadAllLines("RECORDES.txt");



               // string[] dados = texto.Split('|');
            }
        }

        
    }
}
