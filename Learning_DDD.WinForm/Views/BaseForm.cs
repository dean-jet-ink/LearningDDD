using LeaningDDD.Domain;
using LeaningDDD.Domain.Exceptions;
using System;
using System.Windows.Forms;

namespace Learning_DDD.WinForm.Views
{
    public partial class BaseForm : Form
    {
        private static log4net.ILog _logger =
            log4net.LogManager.GetLogger(
                System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BaseForm()
        {
            InitializeComponent();

            toolStripStatusLabel1.Visible = false;
#if DEBUG
            toolStripStatusLabel1.Visible = true;
#endif

            UserIdLabel.Text = Shared.LoginId;
        }

        protected void ExceptionProc(Exception ex)
        {
            MessageBoxIcon icon = MessageBoxIcon.Error;
            string caption = "Error";

            var exceptionBase = ex as ExceptionBase;

            if (exceptionBase != null)
            {
                if (exceptionBase.Type == ExceptionBase.ExceptionType.Info)
                {
                    _logger.Info(ex.Message, ex);

                    icon = MessageBoxIcon.Information;
                    caption = "Info";
                } else if (exceptionBase.Type == ExceptionBase.ExceptionType.Warning)
                {
                    _logger.Warn(ex.Message, ex);

                    icon = MessageBoxIcon.Warning;
                    caption = "Warning";
                } else
                {
                    _logger.Error(ex.Message, ex);
                }
            }

            MessageBox.Show(ex.Message, caption, MessageBoxButtons.OK, icon);
        }
    }
}
