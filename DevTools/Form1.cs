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
            
            SideMenuRoot sideMenu = new SideMenuRoot();
            var catScript = new SideMenuCategory("�X�N���v�g");
            catScript.AddChild(new SideMenuItem("�X�N���v�g", () => _nav.NavigateTo<UcPageConvert>()));
            catScript.AddChild(new SideMenuItem("�X�g�A�h", () => _nav.NavigateTo<UcPageScriptStored>()));
            var catConvert = new SideMenuCategory("API");
            catConvert.AddChild(new SideMenuItem("API���N�G�X�g", () => _nav.NavigateTo<UcPageApiRequest>()));
            sideMenu.AddChild(catScript);
            sideMenu.AddChild(catConvert);

            ucSideMenuRoot1.FromSideMenu(sideMenu);
        }
    }
}
