using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace HomeBank1
{
    public partial class NamingFileForm : Form {
        public NamingFileForm() {
            InitializeComponent();
        }

        private void NamingForm_Load(object sender, EventArgs e){
            this.MaximizeBox = this.MinimizeBox = false;
        }
        private void CompleteButton_Click(object sender, EventArgs e){
            if (NameBox.Text == "") { return; }
            if (ComMthd.RaiseQuestion("新しく作るノートの名前は　" + NameBox.Text + "　でよろしいですか？")
                == DialogResult.Yes){
                //SavedData.activeFilePass = 
                //    Path.Combine(Application.StartupPath, NameBox.Text + ".xml");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        private void ExitButton_Click(object sender, EventArgs e){
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
