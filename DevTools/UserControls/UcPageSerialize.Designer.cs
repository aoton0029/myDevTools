namespace DevTools.UserControls
{
    partial class UcPageSerialize
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
            labelInput = new System.Windows.Forms.Label();
            richTextBoxInput = new System.Windows.Forms.RichTextBox();
            labelFormat = new System.Windows.Forms.Label();
            comboBoxFormat = new System.Windows.Forms.ComboBox();
            buttonSerialize = new System.Windows.Forms.Button();
            buttonDeserialize = new System.Windows.Forms.Button();
            labelOutput = new System.Windows.Forms.Label();
            richTextBoxOutput = new System.Windows.Forms.RichTextBox();

            SuspendLayout();
            // 
            // UcPageSerialize
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Name = "UcPageSerialize";
            Size = new Size(1050, 697);
            // 
            // labelInput
            // 
            labelInput.AutoSize = true;
            labelInput.Font = new Font("メイリオ", 12F);
            labelInput.Location = new Point(30, 30);
            labelInput.Name = "labelInput";
            labelInput.Size = new Size(92, 24);
            labelInput.Text = "入力テキスト";
            // 
            // richTextBoxInput
            // 
            richTextBoxInput.Font = new Font("メイリオ", 12F);
            richTextBoxInput.Location = new Point(30, 60);
            richTextBoxInput.Name = "richTextBoxInput";
            richTextBoxInput.Size = new Size(700, 120);
            // 
            // labelFormat
            // 
            labelFormat.AutoSize = true;
            labelFormat.Font = new Font("メイリオ", 12F);
            labelFormat.Location = new Point(30, 200);
            labelFormat.Name = "labelFormat";
            labelFormat.Size = new Size(72, 24);
            labelFormat.Text = "フォーマット";
            // 
            // comboBoxFormat
            // 
            comboBoxFormat.Font = new Font("メイリオ", 12F);
            comboBoxFormat.Location = new Point(120, 197);
            comboBoxFormat.Name = "comboBoxFormat";
            comboBoxFormat.Size = new Size(150, 32);
            comboBoxFormat.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFormat.Items.AddRange(new object[] { "JSON", "CSV", "HTML" });
            // 
            // buttonSerialize
            // 
            buttonSerialize.Font = new Font("メイリオ", 12F);
            buttonSerialize.Location = new Point(300, 195);
            buttonSerialize.Name = "buttonSerialize";
            buttonSerialize.Size = new Size(120, 36);
            buttonSerialize.Text = "シリアライズ";
            buttonSerialize.UseVisualStyleBackColor = true;
            // 
            // buttonDeserialize
            // 
            buttonDeserialize.Font = new Font("メイリオ", 12F);
            buttonDeserialize.Location = new Point(430, 195);
            buttonDeserialize.Name = "buttonDeserialize";
            buttonDeserialize.Size = new Size(140, 36);
            buttonDeserialize.Text = "デシリアライズ";
            buttonDeserialize.UseVisualStyleBackColor = true;
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.Font = new Font("メイリオ", 12F);
            labelOutput.Location = new Point(30, 250);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(92, 24);
            labelOutput.Text = "出力テキスト";
            // 
            // richTextBoxOutput
            // 
            richTextBoxOutput.Font = new Font("メイリオ", 12F);
            richTextBoxOutput.Location = new Point(30, 280);
            richTextBoxOutput.Name = "richTextBoxOutput";
            richTextBoxOutput.Size = new Size(700, 120);
            richTextBoxOutput.ReadOnly = true;
            // 
            // UcPageSerialize
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelInput);
            Controls.Add(richTextBoxInput);
            Controls.Add(labelFormat);
            Controls.Add(comboBoxFormat);
            Controls.Add(buttonSerialize);
            Controls.Add(buttonDeserialize);
            Controls.Add(labelOutput);
            Controls.Add(richTextBoxOutput);
            Name = "UcPageSerialize";
            Size = new Size(1050, 697);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.RichTextBox richTextBoxInput;
        private System.Windows.Forms.Label labelFormat;
        private System.Windows.Forms.ComboBox comboBoxFormat;
        private System.Windows.Forms.Button buttonSerialize;
        private System.Windows.Forms.Button buttonDeserialize;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.RichTextBox richTextBoxOutput;
    }
}
