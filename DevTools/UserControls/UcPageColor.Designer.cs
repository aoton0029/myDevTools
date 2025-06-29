namespace DevTools.UserControls
{
    partial class UcPageColor
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            labelRgb = new Label();
            textBoxR = new TextBox();
            textBoxG = new TextBox();
            textBoxB = new TextBox();
            labelHex = new Label();
            textBoxHex = new TextBox();
            buttonRgbToHex = new Button();
            buttonHexToRgb = new Button();
            panelColorPreview = new Panel();
            SuspendLayout();
            // 
            // labelRgb
            // 
            labelRgb.AutoSize = true;
            labelRgb.Font = new Font("メイリオ", 14.25F);
            labelRgb.Location = new Point(30, 156);
            labelRgb.Name = "labelRgb";
            labelRgb.Size = new Size(52, 28);
            labelRgb.TabIndex = 0;
            labelRgb.Text = "RGB";
            // 
            // textBoxR
            // 
            textBoxR.Font = new Font("メイリオ", 14.25F);
            textBoxR.Location = new Point(88, 148);
            textBoxR.Name = "textBoxR";
            textBoxR.PlaceholderText = "R";
            textBoxR.Size = new Size(66, 36);
            textBoxR.TabIndex = 1;
            // 
            // textBoxG
            // 
            textBoxG.Font = new Font("メイリオ", 14.25F);
            textBoxG.Location = new Point(160, 148);
            textBoxG.Name = "textBoxG";
            textBoxG.PlaceholderText = "G";
            textBoxG.Size = new Size(66, 36);
            textBoxG.TabIndex = 2;
            // 
            // textBoxB
            // 
            textBoxB.Font = new Font("メイリオ", 14.25F);
            textBoxB.Location = new Point(232, 148);
            textBoxB.Name = "textBoxB";
            textBoxB.PlaceholderText = "B";
            textBoxB.Size = new Size(66, 36);
            textBoxB.TabIndex = 3;
            // 
            // labelHex
            // 
            labelHex.AutoSize = true;
            labelHex.Font = new Font("メイリオ", 14.25F);
            labelHex.Location = new Point(30, 198);
            labelHex.Name = "labelHex";
            labelHex.Size = new Size(51, 28);
            labelHex.TabIndex = 5;
            labelHex.Text = "HEX";
            // 
            // textBoxHex
            // 
            textBoxHex.Font = new Font("メイリオ", 14.25F);
            textBoxHex.Location = new Point(88, 190);
            textBoxHex.Name = "textBoxHex";
            textBoxHex.PlaceholderText = "#RRGGBB";
            textBoxHex.Size = new Size(210, 36);
            textBoxHex.TabIndex = 6;
            // 
            // buttonRgbToHex
            // 
            buttonRgbToHex.Font = new Font("メイリオ", 14.25F);
            buttonRgbToHex.Location = new Point(304, 148);
            buttonRgbToHex.Name = "buttonRgbToHex";
            buttonRgbToHex.Size = new Size(164, 36);
            buttonRgbToHex.TabIndex = 4;
            buttonRgbToHex.Text = "→ HEX";
            buttonRgbToHex.UseVisualStyleBackColor = true;
            // 
            // buttonHexToRgb
            // 
            buttonHexToRgb.Font = new Font("メイリオ", 14.25F);
            buttonHexToRgb.Location = new Point(304, 190);
            buttonHexToRgb.Name = "buttonHexToRgb";
            buttonHexToRgb.Size = new Size(164, 36);
            buttonHexToRgb.TabIndex = 7;
            buttonHexToRgb.Text = "→ RGB";
            buttonHexToRgb.UseVisualStyleBackColor = true;
            // 
            // panelColorPreview
            // 
            panelColorPreview.BorderStyle = BorderStyle.FixedSingle;
            panelColorPreview.Location = new Point(30, 22);
            panelColorPreview.Name = "panelColorPreview";
            panelColorPreview.Size = new Size(668, 101);
            panelColorPreview.TabIndex = 8;
            // 
            // UcPageColor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelRgb);
            Controls.Add(textBoxR);
            Controls.Add(textBoxG);
            Controls.Add(textBoxB);
            Controls.Add(buttonRgbToHex);
            Controls.Add(labelHex);
            Controls.Add(textBoxHex);
            Controls.Add(buttonHexToRgb);
            Controls.Add(panelColorPreview);
            Name = "UcPageColor";
            Size = new Size(1050, 697);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelRgb;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.TextBox textBoxG;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label labelHex;
        private System.Windows.Forms.TextBox textBoxHex;
        private System.Windows.Forms.Button buttonRgbToHex;
        private System.Windows.Forms.Button buttonHexToRgb;
        private System.Windows.Forms.Panel panelColorPreview;
    }
}
