namespace DevTools.UserControls
{
    partial class UcPageConvert
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
            labelDecimal = new System.Windows.Forms.Label();
            textBoxDecimal = new System.Windows.Forms.TextBox();
            labelHex = new System.Windows.Forms.Label();
            textBoxHex = new System.Windows.Forms.TextBox();
            labelBinary = new System.Windows.Forms.Label();
            textBoxBinary = new System.Windows.Forms.TextBox();
            buttonDecToOthers = new System.Windows.Forms.Button();
            buttonOthersToDec = new System.Windows.Forms.Button();

            labelAscii = new System.Windows.Forms.Label();
            textBoxAsciiInput = new System.Windows.Forms.TextBox();
            buttonStringToAscii = new System.Windows.Forms.Button();
            buttonAsciiToString = new System.Windows.Forms.Button();
            textBoxAsciiOutput = new System.Windows.Forms.TextBox();

            SuspendLayout();
            // 
            // UcPageConvert
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Name = "UcPageConvert";
            Size = new Size(1050, 697);
            // 
            // labelDecimal
            // 
            labelDecimal.AutoSize = true;
            labelDecimal.Font = new Font("メイリオ", 12F);
            labelDecimal.Location = new Point(30, 30);
            labelDecimal.Name = "labelDecimal";
            labelDecimal.Size = new Size(60, 24);
            labelDecimal.Text = "10進数";
            // 
            // textBoxDecimal
            // 
            textBoxDecimal.Font = new Font("メイリオ", 12F);
            textBoxDecimal.Location = new Point(110, 27);
            textBoxDecimal.Name = "textBoxDecimal";
            textBoxDecimal.Size = new Size(200, 31);
            // 
            // labelHex
            // 
            labelHex.AutoSize = true;
            labelHex.Font = new Font("メイリオ", 12F);
            labelHex.Location = new Point(30, 70);
            labelHex.Name = "labelHex";
            labelHex.Size = new Size(60, 24);
            labelHex.Text = "16進数";
            // 
            // textBoxHex
            // 
            textBoxHex.Font = new Font("メイリオ", 12F);
            textBoxHex.Location = new Point(110, 67);
            textBoxHex.Name = "textBoxHex";
            textBoxHex.Size = new Size(200, 31);
            // 
            // labelBinary
            // 
            labelBinary.AutoSize = true;
            labelBinary.Font = new Font("メイリオ", 12F);
            labelBinary.Location = new Point(30, 110);
            labelBinary.Name = "labelBinary";
            labelBinary.Size = new Size(60, 24);
            labelBinary.Text = "2進数";
            // 
            // textBoxBinary
            // 
            textBoxBinary.Font = new Font("メイリオ", 12F);
            textBoxBinary.Location = new Point(110, 107);
            textBoxBinary.Name = "textBoxBinary";
            textBoxBinary.Size = new Size(200, 31);
            // 
            // buttonDecToOthers
            // 
            buttonDecToOthers.Font = new Font("メイリオ", 11F);
            buttonDecToOthers.Location = new Point(330, 27);
            buttonDecToOthers.Name = "buttonDecToOthers";
            buttonDecToOthers.Size = new Size(120, 31);
            buttonDecToOthers.Text = "10進数→他進数";
            buttonDecToOthers.UseVisualStyleBackColor = true;
            // 
            // buttonOthersToDec
            // 
            buttonOthersToDec.Font = new Font("メイリオ", 11F);
            buttonOthersToDec.Location = new Point(330, 67);
            buttonOthersToDec.Name = "buttonOthersToDec";
            buttonOthersToDec.Size = new Size(120, 71);
            buttonOthersToDec.Text = "他進数→10進数";
            buttonOthersToDec.UseVisualStyleBackColor = true;
            // 
            // labelAscii
            // 
            labelAscii.AutoSize = true;
            labelAscii.Font = new Font("メイリオ", 12F);
            labelAscii.Location = new Point(30, 180);
            labelAscii.Name = "labelAscii";
            labelAscii.Size = new Size(60, 24);
            labelAscii.Text = "ASCII";
            // 
            // textBoxAsciiInput
            // 
            textBoxAsciiInput.Font = new Font("メイリオ", 12F);
            textBoxAsciiInput.Location = new Point(30, 210);
            textBoxAsciiInput.Name = "textBoxAsciiInput";
            textBoxAsciiInput.Size = new Size(420, 31);
            textBoxAsciiInput.PlaceholderText = "文字列またはASCIIコード列";
            // 
            // buttonStringToAscii
            // 
            buttonStringToAscii.Font = new Font("メイリオ", 11F);
            buttonStringToAscii.Location = new Point(470, 210);
            buttonStringToAscii.Name = "buttonStringToAscii";
            buttonStringToAscii.Size = new Size(110, 31);
            buttonStringToAscii.Text = "→ ASCII";
            buttonStringToAscii.UseVisualStyleBackColor = true;
            // 
            // buttonAsciiToString
            // 
            buttonAsciiToString.Font = new Font("メイリオ", 11F);
            buttonAsciiToString.Location = new Point(590, 210);
            buttonAsciiToString.Name = "buttonAsciiToString";
            buttonAsciiToString.Size = new Size(110, 31);
            buttonAsciiToString.Text = "→ 文字列";
            buttonAsciiToString.UseVisualStyleBackColor = true;
            // 
            // textBoxAsciiOutput
            // 
            textBoxAsciiOutput.Font = new Font("メイリオ", 12F);
            textBoxAsciiOutput.Location = new Point(30, 250);
            textBoxAsciiOutput.Name = "textBoxAsciiOutput";
            textBoxAsciiOutput.Size = new Size(670, 31);
            textBoxAsciiOutput.ReadOnly = true;
            // 
            // UcPageConvert
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelDecimal);
            Controls.Add(textBoxDecimal);
            Controls.Add(labelHex);
            Controls.Add(textBoxHex);
            Controls.Add(labelBinary);
            Controls.Add(textBoxBinary);
            Controls.Add(buttonDecToOthers);
            Controls.Add(buttonOthersToDec);
            Controls.Add(labelAscii);
            Controls.Add(textBoxAsciiInput);
            Controls.Add(buttonStringToAscii);
            Controls.Add(buttonAsciiToString);
            Controls.Add(textBoxAsciiOutput);
            Name = "UcPageConvert";
            Size = new Size(1050, 697);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelDecimal;
        private System.Windows.Forms.TextBox textBoxDecimal;
        private System.Windows.Forms.Label labelHex;
        private System.Windows.Forms.TextBox textBoxHex;
        private System.Windows.Forms.Label labelBinary;
        private System.Windows.Forms.TextBox textBoxBinary;
        private System.Windows.Forms.Button buttonDecToOthers;
        private System.Windows.Forms.Button buttonOthersToDec;

        private System.Windows.Forms.Label labelAscii;
        private System.Windows.Forms.TextBox textBoxAsciiInput;
        private System.Windows.Forms.Button buttonStringToAscii;
        private System.Windows.Forms.Button buttonAsciiToString;
        private System.Windows.Forms.TextBox textBoxAsciiOutput;
    }
}
