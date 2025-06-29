namespace DevTools.UserControls
{
    partial class UcPageRegex
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
            labelPattern = new Label();
            textBoxPattern = new TextBox();
            labelInput = new Label();
            richTextBoxInput = new RichTextBox();
            buttonMatch = new Button();
            labelResult = new Label();
            listBoxMatches = new ListBox();
            SuspendLayout();
            // 
            // labelPattern
            // 
            labelPattern.AutoSize = true;
            labelPattern.Font = new Font("メイリオ", 12F);
            labelPattern.Location = new Point(30, 30);
            labelPattern.Name = "labelPattern";
            labelPattern.Size = new Size(74, 24);
            labelPattern.TabIndex = 0;
            labelPattern.Text = "正規表現";
            // 
            // textBoxPattern
            // 
            textBoxPattern.Font = new Font("メイリオ", 12F);
            textBoxPattern.Location = new Point(130, 27);
            textBoxPattern.Name = "textBoxPattern";
            textBoxPattern.Size = new Size(600, 31);
            textBoxPattern.TabIndex = 1;
            // 
            // labelInput
            // 
            labelInput.AutoSize = true;
            labelInput.Font = new Font("メイリオ", 12F);
            labelInput.Location = new Point(30, 70);
            labelInput.Name = "labelInput";
            labelInput.Size = new Size(106, 24);
            labelInput.TabIndex = 2;
            labelInput.Text = "入力テキスト";
            // 
            // richTextBoxInput
            // 
            richTextBoxInput.Font = new Font("メイリオ", 12F);
            richTextBoxInput.Location = new Point(30, 100);
            richTextBoxInput.Name = "richTextBoxInput";
            richTextBoxInput.Size = new Size(700, 180);
            richTextBoxInput.TabIndex = 2;
            richTextBoxInput.Text = "";
            // 
            // buttonMatch
            // 
            buttonMatch.Font = new Font("メイリオ", 12F);
            buttonMatch.Location = new Point(750, 100);
            buttonMatch.Name = "buttonMatch";
            buttonMatch.Size = new Size(120, 40);
            buttonMatch.TabIndex = 3;
            buttonMatch.Text = "マッチ実行";
            buttonMatch.UseVisualStyleBackColor = true;
            buttonMatch.Click += buttonMatch_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Font = new Font("メイリオ", 12F);
            labelResult.Location = new Point(30, 300);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(90, 24);
            labelResult.TabIndex = 4;
            labelResult.Text = "マッチ結果";
            // 
            // listBoxMatches
            // 
            listBoxMatches.Font = new Font("メイリオ", 12F);
            listBoxMatches.ItemHeight = 24;
            listBoxMatches.Location = new Point(30, 330);
            listBoxMatches.Name = "listBoxMatches";
            listBoxMatches.Size = new Size(700, 196);
            listBoxMatches.TabIndex = 5;
            // 
            // UcPageRegex
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelPattern);
            Controls.Add(textBoxPattern);
            Controls.Add(labelInput);
            Controls.Add(richTextBoxInput);
            Controls.Add(buttonMatch);
            Controls.Add(labelResult);
            Controls.Add(listBoxMatches);
            Name = "UcPageRegex";
            Size = new Size(1050, 697);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelPattern;
        private System.Windows.Forms.TextBox textBoxPattern;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.RichTextBox richTextBoxInput;
        private System.Windows.Forms.Button buttonMatch;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.ListBox listBoxMatches;
    }
}
