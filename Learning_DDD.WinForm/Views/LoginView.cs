using LeaningDDD.Domain;

namespace Learning_DDD.WinForm.Views
{
    public partial class LoginView : BaseForm
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void Login(object sender, System.EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, System.EventArgs e)
        {
            Shared.LoginId = LoginIDTextBox.Text;

            using (var f = new LatestView())
            {
                f.ShowDialog();
            }
        }
    }
}
