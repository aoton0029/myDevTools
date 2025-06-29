using CoreLibWinforms.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTools.Core
{
    public class AppContext
    {
        private static Lazy<AppContext> _instance = new Lazy<AppContext>(() => new AppContext());
        public static AppContext Instance => _instance.Value;

        private ClipboardMonitor _clipboardMonitor;

        public AppContext()
        {
            _clipboardMonitor = new ClipboardMonitor();
            _clipboardMonitor.ClipboardChanged += _clipboardMonitor_ClipboardChanged;
        }

        private void _clipboardMonitor_ClipboardChanged(object? sender, ClipboardChangedEventArgs e)
        {
            // クリップボードデータを取得
            if (e.DataObject.GetDataPresent(DataFormats.Text))
            {
                string text = (string)e.DataObject.GetData(DataFormats.Text);
                // テキストデータの処理
                Console.WriteLine($"クリップボードのテキスト: {text}");
            }
            else if (e.DataObject.GetDataPresent(DataFormats.Bitmap))
            {
                // 画像データの処理
                Console.WriteLine("クリップボードに画像データがあります");
            }
        }
    }
}
