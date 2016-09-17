using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace HomeBank1
{
    public static class ComMthd{//means "CommonMethod"
        //Constants Expresses Message-Type
        public const string TYPE_ERROR = "Error";
        public const string TYPE_INFORMATION = "Information";
        //
        public const double formOpacity = 0.92;

        //Method Generating MessageBox
        public static DialogResult RaiseQuestion(string msg){
            DialogResult result = MessageBox.Show(msg, "確認", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            return result;
        }
        public static void ShowMsgBox(string msg, string ComMethodMsgType){
            using (MsgForm msgForm = new MsgForm()){
                if (Form.ActiveForm != null) {
                    Form nowForm = Form.ActiveForm;
                    SetSamePosistion(msgForm, nowForm.Left, nowForm.Top, nowForm.Width, nowForm.Height);
                }
                switch (ComMethodMsgType)
                {
                    case TYPE_ERROR:
                        msgForm.ReInitializeForm(msg, "エラー", SystemIcons.Exclamation);
                        System.Media.SystemSounds.Exclamation.Play();
                        break;
                    case TYPE_INFORMATION:
                        msgForm.ReInitializeForm(msg, "通知", SystemIcons.Information);
                        System.Media.SystemSounds.Asterisk.Play();
                        break;

                    default:
                        break;
                }
                msgForm.ShowDialog();
            }
        }
        public static DialogResult ShowHandMadeDialog(Form presentForm, Form nextForm) {
            presentForm.Opacity = 0.85;
            SetSamePosistion(nextForm, presentForm.Left, presentForm.Top, presentForm.Width, presentForm.Height);
            DialogResult result = nextForm.ShowDialog();
            presentForm.Opacity = ComMthd.formOpacity;
            return result;
        }

/*        public static void ShowDataProperty(string TargetTableName) {
            if (SavedData.dataSet == null) {
                ShowMsgBox("DataSet is null.", TYPE_ERROR);
                return;
            }
            string msg = "SavedData.DataSet.Tables.Count = ";
            msg += (SavedData.dataSet.Tables.Count.ToString() + "\r\n");
            foreach (DataTable table in SavedData.dataSet.Tables){
                msg += ("Tables[x].name : " + table.TableName.ToString() + "\r\n");
            }
            msg += ("Tables[" + TargetTableName + "].Rows.Count = "
                  + SavedData.dataSet.Tables[TargetTableName].Rows.Count + "\r\n");
            ShowMsgBox(msg, TYPE_INFORMATION);
        }*/
        public static void SetSamePosistion(Form nextForm, int oldX, int oldY, int oldWid, int oldHei) {
            nextForm.StartPosition = FormStartPosition.Manual;
            nextForm.Left = oldX + (oldWid / 2) - (nextForm.Width / 2);
            nextForm.Top = oldY + (oldHei / 2) - (nextForm.Height / 2);
        }
    }
}
