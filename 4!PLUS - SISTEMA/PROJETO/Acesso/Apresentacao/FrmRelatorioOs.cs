using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmRelatorioOs : Form
    {
        public FrmRelatorioOs()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void FrmRelatorioOs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'OFICINADataSet10.OS' table. You can move, or remove it, as needed.
            this.OSTableAdapter.Fill(this.OFICINADataSet10.OS);

            this.reportViewer1.RefreshReport();
        }

        protected override void WndProc(ref Message message)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            base.WndProc(ref message);
        }
    }
}
