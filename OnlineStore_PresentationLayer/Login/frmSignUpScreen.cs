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
    public partial class frmSignUpScreen : Form
    {
        public frmSignUpScreen()
        {
            InitializeComponent();
        }

        clsUser User = new clsUser();
        clsSeller Seller = null;

        void RoundControls()
        {
            Control[] C = { txtPassword, txtUserName, txtFirstName, txtSecondName, txtThirdName
            , txtEmail, txtPhone };

            clsGlobal.RoundControlsByCustomElips(bunifuElipse1, C);
        }

        void LoadCountriesToCB()
        {
            DataTable dtNationalities = clsCountry.GetAllCountries();

            foreach (DataRow row in dtNationalities.Rows)
            {
                cbCountries.Items.Add(row["CountryName"]);
            }

            //to select the first of the countries
            cbCountries.SelectedIndex = 0;
        }

        bool ValidateInfo()
        {
            return

                clsGlobal.ValidateTxtBox(txtUserName, string.IsNullOrEmpty(txtUserName.Text),
             "Please Enter Your User Name!", errorProvider1) &&

             clsGlobal.ValidateTxtBox(txtUserName, clsUser.DoesUserExist(txtUserName.Text),
             "User Name Is Already Taken, Please Choose Another One!", errorProvider1) &&

             clsGlobal.ValidateTxtBox(txtPassword, string.IsNullOrEmpty(txtPassword.Text),
             "Please Enter Your Password!", errorProvider1) &&

             clsGlobal.ValidateTxtBox(txtFirstName, string.IsNullOrEmpty(txtFirstName.Text),
             "Please Enter Your First Name!", errorProvider1) &&

             clsGlobal.ValidateTxtBox(txtSecondName, string.IsNullOrEmpty(txtSecondName.Text),
             "Please Enter Your Second Name!", errorProvider1) &&

             clsGlobal.ValidateTxtBox(txtEmail, string.IsNullOrEmpty(txtEmail.Text),
             "Please Enter Your Email!", errorProvider1) &&

            clsGlobal.ValidateTxtBox(txtEmail, !clsGlobal.IsEmailValid(txtEmail.Text),
             "Please Enter A Valid Email!", errorProvider1) &&

              clsGlobal.ValidateTxtBox(txtPhone, string.IsNullOrEmpty(txtPhone.Text),
             "Please Enter Your Phone Number!", errorProvider1) &&

              clsGlobal.ValidateCustomDatePicker(dpDateOfBirth, DateTime.MinValue, new DateTime(2005, 1, 1),
             "Sorry, Your Age Is Not Allowed!", errorProvider1);


        }

        void LoadUserDataToObj()
        {
            User.FirstName = txtFirstName.Text.Trim();
            User.SecondName = txtSecondName.Text.Trim();
            User.ThirdName = txtThirdName.Text.Trim();
            User.Email = txtEmail.Text.Trim();
            User.Phone = txtPhone.Text.Trim();
            User.UserName = txtUserName.Text.Trim();
            User.Password = clsGlobal.ComputeHash(txtPassword.Text.Trim());
            User.NationalityCountryID = clsCountry.Find(cbCountries.SelectedItem.ToString()).ID;
            User.DateOfBirth = dpDateOfBirth.Value;
            User.Gender = (byte)(rbFemale.Checked ? 1 : 0);
            User.IsActive = true;
        }

        bool PerformSignUpAsUser()
        {
            LoadUserDataToObj();
            return User.Save();
        }

        bool PerformSignUpAsSeller()
        {
            LoadUserDataToObj();
            User.Save();

            clsSeller Seller = new clsSeller();
            Seller.UserID = User.UserID;
            return Seller.Save();
        }

        void SignUp(bool IsSeller)
        {

            if (ValidateInfo())
            {
                if (IsSeller ? PerformSignUpAsSeller() : PerformSignUpAsUser())
                {
                    MessageBox.Show("Your Account Has Been Created Successfully", "Successeded",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clsGlobal.CurrentUser = this.User;
                    //if the current login as a seller then the object would be 'null'
                    clsGlobal.CurrentSeller = Seller;

                    clsGlobal.WriteEntry(clsGlobal.EntrySource,
                    $@"Account '{User.UserName}' Has been created successfully", System.Diagnostics.EventLogEntryType.Information);

                }
                else
                {
                    MessageBox.Show("Error, Failed To Create Your Account\n\nPlease Try Again", "Failed",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);

                    clsGlobal.WriteEntry(clsGlobal.EntrySource,
                    $@"Failed to create '{User.UserName}' account", System.Diagnostics.EventLogEntryType.Error);
                }
            }

        }




        private void frmSignUpScreen_Load(object sender, EventArgs e)
        {
            RoundControls();
            LoadCountriesToCB();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp(false);
        }

        private void klblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp(true);
        }

        private void klblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
