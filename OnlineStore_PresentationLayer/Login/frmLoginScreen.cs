using DVLD_BusinessLayer;
using DVLD_PresentationLayer;
using OnlineStore_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStore_PresentationLayer.Login
{
    public partial class frmLoginScreen : Form
    {
        public frmLoginScreen()
        {
            InitializeComponent();
            clsGlobal.LoginScreen = this;
        }

        clsUser _CurrentUser = new clsUser();

        void ShowMainScreen()
        {
            this.Hide();
            frmMainScreen frmMainScreen_v = new frmMainScreen();
            clsGlobal.ShowForm(frmMainScreen_v);
        }

        void RoundControls()
        {
            Control[] C = { txtPassword, this, txtUserName };

            clsGlobal.RoundControlsByCustomElips(bunifuElipse1, C);
        }

        void DisplayUserInfo(string UserName, string Password)
        {
            txtUserName.Text = UserName;
            txtPassword.Text = Password;
        }

        void DispalyUserInfoFromRegIfAny()
        {
            //string TextFileContent = clsGlobal.GetFileTextContent(clsGlobal.UserInfoFilePath);

            //if (!string.IsNullOrEmpty(TextFileContent))
            //{
            //    string UserName = "", Password = "";
            //    clsGlobal.GetUserInfoByFile(ref UserName, ref Password,
            //        clsGlobal.UserInfoFilePath, clsGlobal.Seperator);
            //    DisplayUserInfo(UserName, Password);
            //}

            string UserName = "", Password = "";

            if (clsGlobal.GetUserInfoFromReg(ref UserName, ref Password))
            {
                DisplayUserInfo(UserName, clsGlobal.Decrypt(Password, clsGlobal.Key));
            }
        }

        bool ValidateInfoCompletion()
        {
            return clsGlobal.ValidateTxtBox(txtUserName, string.IsNullOrEmpty(txtUserName.Text),
              "Please Enter Your User Name!", errorProvider1) &&

              clsGlobal.ValidateTxtBox(txtPassword, string.IsNullOrEmpty(txtPassword.Text),
              "Please Enter Your Password!", errorProvider1);

        }

        void LoadDataToUserObj()
        {
            _CurrentUser = clsUser.FindByUserName(txtUserName.Text.Trim());
        }

        bool ValidateIfUserExists()
        {
            return _CurrentUser != null;
        }

        bool ValidatePassword()
        {
            return _CurrentUser.Password == clsGlobal.ComputeHash(txtPassword.Text.Trim());
        }

        bool ValidateIfUserActive()
        {
            return _CurrentUser.IsActive;
        }

        bool ValidateInfo()
        {
            if (ValidateInfoCompletion())
            {
                LoadDataToUserObj();

                if (ValidateIfUserExists() && ValidatePassword())
                {
                    if (ValidateIfUserActive())
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Your Account Has Been Suspended, Please Contact Your Admin", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Account Does Not Exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return false;
        }

        void RememberUser()
        {
            //clsGlobal.SaveUserInfoToLogin(txtUserName.Text, txtPassword.Text,
            //    clsGlobal.UserInfoFilePath, clsGlobal.Seperator);

            clsGlobal.SaveCurrentLoggedUserInfoToReg(_CurrentUser.UserName,
                clsGlobal.Encrypt(txtPassword.Text.Trim(), clsGlobal.Key));
        }

        void MakeLoggerCurrentUser()
        {
            clsGlobal.CurrentUser = _CurrentUser;
        }

        void LoadSellerDataIfUserIsSeller()
        {
            clsSeller seller = clsSeller.FindByUserID(_CurrentUser.UserID);
            if (seller != null)
                clsGlobal.CurrentSeller = seller;
        }

        void PerformSignIn()
        {
            if (ValidateInfo())
            {
                if (cbRememberMe.Checked) RememberUser();
                else
                {
                    clsGlobal.ClearCurrentLoggedUserInfoInReg();
                }

                MakeLoggerCurrentUser();
                LoadSellerDataIfUserIsSeller();
                ShowMainScreen();
                clsGlobal.WriteEntry(clsGlobal.EntrySource,
                    $@"{_CurrentUser.UserName} Loged in", System.Diagnostics.EventLogEntryType.Information);
            }
        }







        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmLoginScreen_Load(object sender, EventArgs e)
        {
            RoundControls();
            DispalyUserInfoFromRegIfAny();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            PerformSignIn();
        }

        private void klblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSignUpScreen frmSignUpScreen_v = new frmSignUpScreen();
            frmSignUpScreen_v.ShowDialog();
        }
    }
}
