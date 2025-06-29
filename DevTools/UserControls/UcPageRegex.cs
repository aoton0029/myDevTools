using CoreLibWinforms.Navigations;
using CoreLibWinforms.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevTools.UserControls
{
    public partial class UcPageRegex : UcPageBase
    {
        public UcPageRegex(NavigationService navigationService) : base(navigationService)
        {
            InitializeComponent();
        }

        private void buttonMatch_Click(object sender, EventArgs e)
        {
            // 入力取得
            string pattern = textBoxPattern.Text;
            string input = richTextBoxInput.Text;

            // 前回のハイライトをクリア
            richTextBoxInput.SelectAll();
            richTextBoxInput.SelectionBackColor = richTextBoxInput.BackColor;

            listBoxMatches.Items.Clear();

            if (string.IsNullOrEmpty(pattern) || string.IsNullOrEmpty(input))
                return;

            try
            {
                var regex = new Regex(pattern);
                var matches = regex.Matches(input);

                foreach (Match match in matches)
                {
                    // マッチ箇所をハイライト
                    richTextBoxInput.Select(match.Index, match.Length);
                    richTextBoxInput.SelectionBackColor = Color.Yellow;

                    // マッチ内容をリストに追加
                    listBoxMatches.Items.Add($"[{match.Index}-{match.Index + match.Length - 1}]: {match.Value}");
                }

                // カーソル位置を戻す
                richTextBoxInput.SelectionStart = 0;
                richTextBoxInput.SelectionLength = 0;
                richTextBoxInput.SelectionBackColor = richTextBoxInput.BackColor;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"正規表現エラー: {ex.Message}", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
