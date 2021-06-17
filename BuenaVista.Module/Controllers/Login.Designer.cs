
namespace BuenaVista.Module.Controllers
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.actionLogin = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // actionLogin
            // 
            this.actionLogin.Caption = "action Login";
            this.actionLogin.ConfirmationMessage = null;
            this.actionLogin.Id = "actionLogin";
            this.actionLogin.ToolTip = null;
            this.actionLogin.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.actionLogin_Execute);
            // 
            // Login
            // 
            this.Actions.Add(this.actionLogin);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction actionLogin;
    }
}
