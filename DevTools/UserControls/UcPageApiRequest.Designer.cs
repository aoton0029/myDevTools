namespace DevTools.UserControls
{
    partial class UcPageApiRequest
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
            labelUrl = new Label();
            textBoxUrl = new TextBox();
            labelMethod = new Label();
            comboBoxMethod = new ComboBox();
            labelRequestBody = new Label();
            textBoxRequestBody = new TextBox();
            buttonSend = new Button();
            labelResponse = new Label();
            textBoxResponse = new TextBox();
            SuspendLayout();
            // 
            // labelUrl
            // 
            labelUrl.AutoSize = true;
            labelUrl.Location = new Point(20, 20);
            labelUrl.Name = "labelUrl";
            labelUrl.Size = new Size(28, 15);
            labelUrl.TabIndex = 0;
            labelUrl.Text = "URL";
            // 
            // textBoxUrl
            // 
            textBoxUrl.Location = new Point(80, 17);
            textBoxUrl.Name = "textBoxUrl";
            textBoxUrl.Size = new Size(600, 23);
            textBoxUrl.TabIndex = 1;
            // 
            // labelMethod
            // 
            labelMethod.AutoSize = true;
            labelMethod.Location = new Point(20, 55);
            labelMethod.Name = "labelMethod";
            labelMethod.Size = new Size(49, 15);
            labelMethod.TabIndex = 2;
            labelMethod.Text = "Method";
            // 
            // comboBoxMethod
            // 
            comboBoxMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMethod.Items.AddRange(new object[] { "GET", "POST" });
            comboBoxMethod.Location = new Point(80, 52);
            comboBoxMethod.Name = "comboBoxMethod";
            comboBoxMethod.Size = new Size(100, 23);
            comboBoxMethod.TabIndex = 3;
            // 
            // labelRequestBody
            // 
            labelRequestBody.AutoSize = true;
            labelRequestBody.Location = new Point(20, 90);
            labelRequestBody.Name = "labelRequestBody";
            labelRequestBody.Size = new Size(79, 15);
            labelRequestBody.TabIndex = 4;
            labelRequestBody.Text = "Request Body";
            // 
            // textBoxRequestBody
            // 
            textBoxRequestBody.Location = new Point(20, 110);
            textBoxRequestBody.Multiline = true;
            textBoxRequestBody.Name = "textBoxRequestBody";
            textBoxRequestBody.ScrollBars = ScrollBars.Vertical;
            textBoxRequestBody.Size = new Size(660, 100);
            textBoxRequestBody.TabIndex = 5;
            // 
            // buttonSend
            // 
            buttonSend.Location = new Point(700, 17);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(100, 58);
            buttonSend.TabIndex = 6;
            buttonSend.Text = "送信";
            buttonSend.UseVisualStyleBackColor = true;
            // 
            // labelResponse
            // 
            labelResponse.AutoSize = true;
            labelResponse.Location = new Point(20, 220);
            labelResponse.Name = "labelResponse";
            labelResponse.Size = new Size(57, 15);
            labelResponse.TabIndex = 7;
            labelResponse.Text = "Response";
            // 
            // textBoxResponse
            // 
            textBoxResponse.Font = new Font("Consolas", 9F);
            textBoxResponse.Location = new Point(20, 240);
            textBoxResponse.Multiline = true;
            textBoxResponse.Name = "textBoxResponse";
            textBoxResponse.ReadOnly = true;
            textBoxResponse.ScrollBars = ScrollBars.Both;
            textBoxResponse.Size = new Size(951, 438);
            textBoxResponse.TabIndex = 8;
            // 
            // UcPageApiRequest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelUrl);
            Controls.Add(textBoxUrl);
            Controls.Add(labelMethod);
            Controls.Add(comboBoxMethod);
            Controls.Add(labelRequestBody);
            Controls.Add(textBoxRequestBody);
            Controls.Add(buttonSend);
            Controls.Add(labelResponse);
            Controls.Add(textBoxResponse);
            Name = "UcPageApiRequest";
            Size = new Size(1050, 697);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelUrl;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Label labelMethod;
        private System.Windows.Forms.ComboBox comboBoxMethod;
        private System.Windows.Forms.Label labelRequestBody;
        private System.Windows.Forms.TextBox textBoxRequestBody;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label labelResponse;
        private System.Windows.Forms.TextBox textBoxResponse;
    }
}
