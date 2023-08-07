using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            QRCoder.QRCodeGenerator QRgen = new QRCoder.QRCodeGenerator();

            var data = QRgen.CreateQrCode(txtData.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(data);
            pcbxQR.Image = code.GetGraphic(50);
        }
    }
}
