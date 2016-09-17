namespace HomeBank1
{
    partial class MenuForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelWrite = new System.Windows.Forms.Label();
            this.labelAnalyze = new System.Windows.Forms.Label();
            this.labelMakeNew = new System.Windows.Forms.Label();
            this.labelOpen = new System.Windows.Forms.Label();
            this.topPictureBox = new System.Windows.Forms.PictureBox();
            this.BackLabelAnalyze = new System.Windows.Forms.Label();
            this.BackLabelWrite = new System.Windows.Forms.Label();
            this.BackLabelOpen = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.openDataFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.BackLabelNew = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.topPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWrite
            // 
            this.labelWrite.BackColor = System.Drawing.SystemColors.Window;
            this.labelWrite.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelWrite.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelWrite.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.labelWrite.Location = new System.Drawing.Point(78, 147);
            this.labelWrite.Name = "labelWrite";
            this.labelWrite.Size = new System.Drawing.Size(107, 49);
            this.labelWrite.TabIndex = 1;
            this.labelWrite.Text = "書き込む";
            this.labelWrite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAnalyze
            // 
            this.labelAnalyze.BackColor = System.Drawing.SystemColors.Window;
            this.labelAnalyze.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelAnalyze.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelAnalyze.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.labelAnalyze.Location = new System.Drawing.Point(78, 209);
            this.labelAnalyze.Name = "labelAnalyze";
            this.labelAnalyze.Size = new System.Drawing.Size(107, 49);
            this.labelAnalyze.TabIndex = 2;
            this.labelAnalyze.Text = "分析する";
            this.labelAnalyze.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMakeNew
            // 
            this.labelMakeNew.BackColor = System.Drawing.SystemColors.Window;
            this.labelMakeNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMakeNew.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelMakeNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelMakeNew.Location = new System.Drawing.Point(201, 209);
            this.labelMakeNew.Name = "labelMakeNew";
            this.labelMakeNew.Size = new System.Drawing.Size(107, 49);
            this.labelMakeNew.TabIndex = 3;
            this.labelMakeNew.Text = "新しくノートを作る";
            this.labelMakeNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOpen
            // 
            this.labelOpen.BackColor = System.Drawing.SystemColors.Window;
            this.labelOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelOpen.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelOpen.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelOpen.Location = new System.Drawing.Point(78, 85);
            this.labelOpen.Name = "labelOpen";
            this.labelOpen.Size = new System.Drawing.Size(107, 49);
            this.labelOpen.TabIndex = 0;
            this.labelOpen.Text = "ノートを開く";
            this.labelOpen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // topPictureBox
            // 
            this.topPictureBox.Location = new System.Drawing.Point(198, 12);
            this.topPictureBox.Name = "topPictureBox";
            this.topPictureBox.Size = new System.Drawing.Size(109, 117);
            this.topPictureBox.TabIndex = 4;
            this.topPictureBox.TabStop = false;
            // 
            // BackLabelAnalyze
            // 
            this.BackLabelAnalyze.BackColor = System.Drawing.SystemColors.Window;
            this.BackLabelAnalyze.Location = new System.Drawing.Point(77, 208);
            this.BackLabelAnalyze.Name = "BackLabelAnalyze";
            this.BackLabelAnalyze.Size = new System.Drawing.Size(111, 53);
            this.BackLabelAnalyze.TabIndex = 5;
            // 
            // BackLabelWrite
            // 
            this.BackLabelWrite.BackColor = System.Drawing.SystemColors.Window;
            this.BackLabelWrite.Location = new System.Drawing.Point(77, 146);
            this.BackLabelWrite.Name = "BackLabelWrite";
            this.BackLabelWrite.Size = new System.Drawing.Size(111, 53);
            this.BackLabelWrite.TabIndex = 6;
            // 
            // BackLabelOpen
            // 
            this.BackLabelOpen.BackColor = System.Drawing.SystemColors.Window;
            this.BackLabelOpen.Location = new System.Drawing.Point(77, 84);
            this.BackLabelOpen.Name = "BackLabelOpen";
            this.BackLabelOpen.Size = new System.Drawing.Size(111, 53);
            this.BackLabelOpen.TabIndex = 7;
            // 
            // openDataFileDialog
            // 
            this.openDataFileDialog.FileName = "openFileDialog";
            // 
            // BackLabelNew
            // 
            this.BackLabelNew.BackColor = System.Drawing.SystemColors.Window;
            this.BackLabelNew.Location = new System.Drawing.Point(200, 208);
            this.BackLabelNew.Name = "BackLabelNew";
            this.BackLabelNew.Size = new System.Drawing.Size(111, 53);
            this.BackLabelNew.TabIndex = 8;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(320, 271);
            this.Controls.Add(this.topPictureBox);
            this.Controls.Add(this.labelOpen);
            this.Controls.Add(this.labelMakeNew);
            this.Controls.Add(this.labelAnalyze);
            this.Controls.Add(this.labelWrite);
            this.Controls.Add(this.BackLabelAnalyze);
            this.Controls.Add(this.BackLabelWrite);
            this.Controls.Add(this.BackLabelOpen);
            this.Controls.Add(this.BackLabelNew);
            this.Name = "MenuForm";
            this.Text = "かけいぼ　～メニュー画面～";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.topPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelWrite;
        private System.Windows.Forms.Label labelAnalyze;
        private System.Windows.Forms.Label labelMakeNew;
        private System.Windows.Forms.Label labelOpen;
        private System.Windows.Forms.PictureBox topPictureBox;
        private System.Windows.Forms.Label BackLabelAnalyze;
        private System.Windows.Forms.Label BackLabelWrite;
        private System.Windows.Forms.Label BackLabelOpen;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.OpenFileDialog openDataFileDialog;
        private System.Windows.Forms.Label BackLabelNew;
    }
}

