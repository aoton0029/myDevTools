namespace DevTools
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlMain = new Panel();
            ucSideMenuRoot1 = new CoreLibWinforms.UcSideMenuRoot();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlMain.Location = new Point(47, 1);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1050, 697);
            pnlMain.TabIndex = 1;
            // 
            // ucSideMenuRoot1
            // 
            ucSideMenuRoot1.BackColor = Color.FromArgb(40, 40, 40);
            ucSideMenuRoot1.Dock = DockStyle.Left;
            ucSideMenuRoot1.Location = new Point(0, 0);
            ucSideMenuRoot1.Name = "ucSideMenuRoot1";
            ucSideMenuRoot1.Size = new Size(50, 698);
            ucSideMenuRoot1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 698);
            Controls.Add(ucSideMenuRoot1);
            Controls.Add(pnlMain);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private CoreLibWinforms.UcSideMenuRoot ucSideMenuRoot1;
    }
}
