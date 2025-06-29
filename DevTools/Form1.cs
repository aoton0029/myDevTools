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
            var catScript = new SideMenuCategory("�X�N���v�g");
            catScript.AddChild(new SideMenuItem("�X�N���v�g", () => _nav.NavigateTo<UcPageConvert>()));
            catScript.AddChild(new SideMenuItem("�X�g�A�h", () => _nav.NavigateTo<UcPageScriptStored>()));
            var catApi = new SideMenuCategory("API");
            catApi.AddChild(new SideMenuItem("API���N�G�X�g", () => _nav.NavigateTo<UcPageApiRequest>()));
            var catQR = new SideMenuCategory("QR");
            catQR.AddChild(new SideMenuItem("QR�R�[�h", () => _nav.NavigateTo<UcPageQR>()));
            var catConvert = new SideMenuCategory("Convert");
            catConvert.AddChild(new SideMenuItem("���l", () => _nav.NavigateTo<UcPageConvert>()));
            catConvert.AddChild(new SideMenuItem("�e�L�X�g", () => _nav.NavigateTo<UcPageTextFormat>()));
            catConvert.AddChild(new SideMenuItem("�F", () => _nav.NavigateTo<UcPageColor>()));
            catConvert.AddChild(new SideMenuItem("���K�\��", () => _nav.NavigateTo<UcPageRegex>()));
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
