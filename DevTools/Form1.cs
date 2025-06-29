using CoreLibWinforms;
using CoreLibWinforms.Navigations;
using DevTools.UserControls;

namespace DevTools
{
    public partial class Form1 : Form
    {
        NavigationService _nav;

        public Form1()
        {
            InitializeComponent();

            _nav = new NavigationService(pnlMain);
            _nav.RegisterPage<UcPageApiRequest>(new UcPageApiRequest(_nav));
            _nav.RegisterPage<UcPageConvert>(new UcPageConvert(_nav));
            _nav.RegisterPage<UcPageColor>(new UcPageColor(_nav));
            _nav.RegisterPage<UcPageQR>(new UcPageQR(_nav));
            _nav.RegisterPage<UcPageRegex>(new UcPageRegex(_nav));
            _nav.RegisterPage<UcPageScript>(new UcPageScript(_nav));
            _nav.RegisterPage<UcPageScriptStored>(new UcPageScriptStored(_nav));
            _nav.RegisterPage<UcPageSerialize>(new UcPageSerialize(_nav));
            _nav.RegisterPage<UcPageTextFormat>(new UcPageTextFormat(_nav));


            SideMenuRoot sideMenu = new SideMenuRoot();
            var catScript = new SideMenuCategory("スクリプト");
            catScript.AddChild(new SideMenuItem("スクリプト", () => _nav.NavigateTo<UcPageConvert>()));
            catScript.AddChild(new SideMenuItem("ストアド", () => _nav.NavigateTo<UcPageScriptStored>()));
            var catApi = new SideMenuCategory("API");
            catApi.AddChild(new SideMenuItem("APIリクエスト", () => _nav.NavigateTo<UcPageApiRequest>()));
            var catQR = new SideMenuCategory("QR");
            catQR.AddChild(new SideMenuItem("QRコード", () => _nav.NavigateTo<UcPageQR>()));
            var catConvert = new SideMenuCategory("Convert");
            catConvert.AddChild(new SideMenuItem("数値", () => _nav.NavigateTo<UcPageConvert>()));
            catConvert.AddChild(new SideMenuItem("テキスト", () => _nav.NavigateTo<UcPageTextFormat>()));
            catConvert.AddChild(new SideMenuItem("色", () => _nav.NavigateTo<UcPageColor>()));
            catConvert.AddChild(new SideMenuItem("正規表現", () => _nav.NavigateTo<UcPageRegex>()));
            var catSerialize = new SideMenuCategory("Serialize");
            catSerialize.AddChild(new SideMenuItem("Serialize", () => _nav.NavigateTo<UcPageSerialize>()));

            sideMenu.AddChild(catScript);
            sideMenu.AddChild(catConvert);
            sideMenu.AddChild(catApi);
            sideMenu.AddChild(catQR);
            sideMenu.AddChild(catSerialize);

            ucSideMenuRoot1.FromSideMenu(sideMenu);
        }
    }
}
