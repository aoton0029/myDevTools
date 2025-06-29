using CoreLibWinforms.Navigations;
using CoreLibWinforms.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevTools.UserControls
{
    public partial class UcPageApiRequest : UcPageBase
    {
        private static HttpClient _client = new HttpClient();

        public UcPageApiRequest(NavigationService navigationService) : base(navigationService)
        {
            InitializeComponent();
        }

        private async void buttonSend_Click(object sender, EventArgs e)
        {
            // UIから値を取得
            var url = textBoxUrl.Text.Trim();
            var method = comboBoxMethod.SelectedItem?.ToString() ?? "GET";
            var requestBody = textBoxRequestBody.Text;

            // 入力チェック
            if (string.IsNullOrWhiteSpace(url))
            {
                MessageBox.Show("URLを入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            buttonSend.Enabled = false;
            textBoxResponse.Text = "リクエスト送信中...";

            try
            {
                HttpResponseMessage response;

                if (method == "GET")
                {
                    response = await _client.GetAsync(url);
                }
                else // POST
                {
                    // Content-Type: application/json で送信
                    var content = new StringContent(requestBody, Encoding.UTF8, "application/json");
                    response = await _client.PostAsync(url, content);
                }

                var responseText = await response.Content.ReadAsStringAsync();
                textBoxResponse.Text = $"Status: {(int)response.StatusCode} {response.ReasonPhrase}\r\n\r\n{responseText}";
            }
            catch (Exception ex)
            {
                textBoxResponse.Text = $"エラー: {ex.Message}";
            }
            finally
            {
                buttonSend.Enabled = true;
            }
        }
    }
}
