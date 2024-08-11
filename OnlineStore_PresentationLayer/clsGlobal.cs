using Bunifu.Framework.UI;
using DVLD_BusinessLayer;
using MaterialSkin.Controls;
using Microsoft.Win32;
using OnlineStore_BusinessLayer;
using OnlineStore_PresentationLayer;
using OnlineStore_PresentationLayer.Login;
using OnlineStore_PresentationLayer.Products_List;
using OnlineStore_PresentationLayer.Properties;
using OnlineStore_PresentationLayer.User_Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using ComboBox = System.Windows.Forms.ComboBox;
using TextBox = System.Windows.Forms.TextBox;

namespace DVLD_PresentationLayer
{
    public class clsGlobal
    {
        public static clsUser CurrentUser = null;

        public static clsSeller CurrentSeller = null;

        public static string UserInfoFilePath = @"F:\Projects\My Projects With C#\Online Store\LastUserLoginInfo.txt";

        public static string ProductsImagesFilePath = @"F:\Projects\My Projects With C#\Online Store\Products Images\";

        public static string AdsImagesFilePath 
            = @"F:\Projects\My Projects With C#\Online Store\Ads Images\";


        public static string UserInfoRegPath = @"HKEY_CURRENT_USER\SOFTWARE\OnlineStore_CurrentUser";

        public static string UserNameValName = @"UserName";

        public static string PasswordValName = @"Password";

        public static string EntrySource = "OnlineStore_C#_ByMomenNasr";

        public static string EntryLogName = "Application";

        public static string Key = "1234567890123456";

        public static decimal AddingNewProductFeePerc = 5;





        public static char Seperator = '#';

        public static List<ctrlProductThumbNail> ctrlProductThumbNailsList = new List<ctrlProductThumbNail>();


        public static frmMainScreen MainScreenFormObj = new frmMainScreen();

        public static Form CurrentOpendForm = new Form();

        public static frmProductsList frmProductsList = new frmProductsList();
        public static frmLoginScreen LoginScreen = new frmLoginScreen();


        public static int GetProductIndexInList(clsProduct Product)
        {
            int Index = 0;
            foreach (ctrlProductThumbNail prdct in clsGlobal.ctrlProductThumbNailsList)
            {

                if (prdct.CurrentProduct.ProductID == Product.ProductID)
                {
                    return Index;
                }

                Index++;
            }

            return -1;
        }

        public static int GetProductRiviewIndexInList(ctrlProductReview ProductReview,
            List<ctrlProductReview> ProductsCtrlList)
        {
            int Index = 0;
            foreach (ctrlProductReview prdct in ProductsCtrlList)
            {

                if (prdct.ProductReview.ProductReviewID == ProductReview.ProductReview.ProductReviewID)
                {
                    return Index;
                }

                Index++;
            }

            return -1;
        }


        //file functions
        public static void GetUserInfoByFile(ref string UserName, ref string Password, string FilePath, char Sep)
        {
            string FileContent = GetFileTextContent(FilePath);
          
            UserName = FileContent.Split(Sep)[0];
            Password = FileContent.Split(Sep)[1];
        }

        public static void ClearFileContent(string FilePath)
        {
            string text = "";

            using (StreamWriter writer = new StreamWriter(FilePath))
            {
                // Write the text to the file
                writer.Write(text);
            }
        }

        public static string GetFileTextContent(string FilePath)
        {
            // Create a new instance of StreamReader and specify the file path
            using (StreamReader reader = new StreamReader(FilePath))
            {
                // Read the entire content of the file
                string text = reader.ReadToEnd();

                // Display the text
                return text;
            }
        }

        public static void SaveUserInfoToLogin(string UserName, string Password, string FilePath, char Sep)
        {
            string text = UserName + Sep + Password;

            using (StreamWriter writer = new StreamWriter(FilePath))
            {
                // Write the text to the file
                writer.Write(text);
            }
        }

        //reg functions
        public static bool GetUserInfoFromReg(ref string UserName, ref string Password)
        {
            // Specify the Registry key and path

            try
            {
                // Read the value from the Registry
                UserName = Registry.GetValue(UserInfoRegPath, UserNameValName, null) as string;
                Password = Registry.GetValue(UserInfoRegPath, PasswordValName, null) as string;

                if (UserName != null && Password != null)
                {               
                    return true;
                }
                else
                {
                    return false;
                }
              

               
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool SaveCurrentLoggedUserInfoToReg(string UserName, string Password)
        {          
            try
            {
                // Write the value to the Registry
                Registry.SetValue(UserInfoRegPath, UserNameValName, UserName, RegistryValueKind.String);
                Registry.SetValue(UserInfoRegPath, PasswordValName, Password, RegistryValueKind.String);
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool ClearCurrentLoggedUserInfoInReg()
        {
            try
            {
                // Write the value to the Registry
                Registry.SetValue(UserInfoRegPath, UserNameValName, string.Empty, RegistryValueKind.String);
                Registry.SetValue(UserInfoRegPath, PasswordValName, string.Empty, RegistryValueKind.String);
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public static void AddColumnToDataTable(string ColumnName, Type ColumnType, ref DataTable DT)
        {
            DataColumn dataColumn = new DataColumn(ColumnName, ColumnType);        
            DT.Columns.Add(dataColumn);
        }

        public static void AddColumnToDataBunifuGridView(string ColumnName, Type ColumnType, ref BunifuCustomDataGrid DG, DataGridViewImageCellLayout Layout = DataGridViewImageCellLayout.Stretch)
        {
            if (ColumnType == typeof(Image))
            {
                DataGridViewImageColumn ImgColmn = new DataGridViewImageColumn();
                ImgColmn.HeaderText = ColumnName;
                ImgColmn.Name = ColumnName;
                ImgColmn.ImageLayout = Layout;
                DG.Columns.Add(ImgColmn);
            }
            else
            {
                DataGridViewColumn dataColumn = new DataGridViewColumn();
                dataColumn.Name = ColumnName;
                dataColumn.ValueType = ColumnType;
                DG.Columns.Add(dataColumn);
            }
        }


        public static void AddValueToDataTable(int Row, int Column, dynamic Value, ref DataTable DT)
        {
            DT.Rows[Row][Column] = Value;
        }

        public static void AddValueToDataTable(int Row, string ColumnName, dynamic Value, ref DataTable DT)
        {
            DT.Rows[Row][ColumnName] = Value;
        }

        public static void AddValueToBunifuGridView(int Row, string ColumnName, dynamic Value, ref BunifuCustomDataGrid DG)
        {
            DG.Rows[Row].Cells[ColumnName].Value = Value;
        }

        public static void AddImageToBunifuGridView(int Row, string ColumnName, Image Img, ref BunifuCustomDataGrid DG)
        {

            DG.Rows[Row].Cells[ColumnName].Value = Img;
        }


        public static void ChangeColumnNameInDataTable(int Column, string NewName, ref DataTable DT)
        {
            DT.Columns[Column].ColumnName = NewName;
        }

        public static void ChangeColumnNameInDataTable(string ColumnName, string NewName, ref DataTable DT)
        {
            DT.Columns[ColumnName].ColumnName = NewName;
        }

        public static void ShowFormInPanel(Panel pnl, Form frm)
        {
            pnl.Controls.Clear();
            frm.Dock = DockStyle.Fill; frm.TopLevel = false; frm.TopMost = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnl.Controls.Add(frm);
            try
            {
                frm.Show();
            }
            catch (Exception ex)
            {
                string EntryExMessage = 
                    WriteEntry("OnlineStore_C#_ByMomenNasr", "Error showing form in panel",
                    EventLogEntryType.Error);          

                if (MessageBox.Show(ex.Message + "\n" + EntryExMessage,
                    "Error Just Occured", MessageBoxButtons.OKCancel)
                    == DialogResult.OK)
                {
                    Application.Restart();
                }
                else
                {
                    CurrentOpendForm.Close();
                    LoginScreen.Close();
                }
            }
        }

        public static Image GetImageByPath(string Path)
        {
            try
            {
                return Image.FromFile(Path);
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public static void ShowDataOnCustomDataGridView(BunifuCustomDataGrid DG, DataTable DT)
        {
            DG.DataSource = DT;
        }

        public static void RoundControlsByCustomElips(BunifuElipse bElips , Control[] C)
        {
            for (int i = 0; i < C.Length;i++)
            {
                bElips.ApplyElipse(C[i]);
            }
        }

        public static void StyleBunifuThinButtonIDLE(BunifuThinButton2 BTN, Color idleFillColor, Color idleForeColor, Color idleLineColor)
        {
            BTN.IdleFillColor = idleFillColor;
            BTN.IdleForecolor = idleForeColor;
            BTN.IdleLineColor = idleLineColor;
        }

        public static bool IsNumber(string UserInput)
        {
            double number;
            if (double.TryParse(UserInput, out number))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void ShowDataOnContolText(Control LBL, dynamic Data)
        {
            LBL.Text = Data.ToString();
        }

        public static void ShowDateOnCustomDatePicker(BunifuDatepicker DT, DateTime Date)
        {
            DT.Value = Date;
        }  

        public static string GetPersonGender(clsPerson Person)
        {
            if (Person.Gender == 0)
                return "Male";
            else if (Person.Gender == 1)
                return "Female";
            else
                return "Other";
        }

        public static void DispalyProfilePicForUser(PictureBox pbPersonPic, clsPerson Person)
        {
            if (string.IsNullOrEmpty(Person.ProfilePic))
            {
                if (Person.Gender == 0)
                    pbPersonPic.Image = Resources.MaleUser1;

                else if (Person.Gender == 1)

                    pbPersonPic.Image = Resources.femaleUser;
                else
                    pbPersonPic.Image = null;
            }
            else
            {
                pbPersonPic.ImageLocation = Person.ProfilePic;

            }
        }

        public static void DispalyDefaultImageForUser(PictureBox pbPersonPic, clsPerson Person)
        {

            if (Person.Gender == 0)
                pbPersonPic.Image = Resources.MaleUser1;

            else if (Person.Gender == 1)

                pbPersonPic.Image = Resources.femaleUser;
            else
                pbPersonPic.Image = null;
           
        }

        public static void DispalyDefaultImageForUser(PictureBox pbPersonPic, int Gender)
        {

            if (Gender == 0)
                pbPersonPic.Image = Resources.MaleUser1;

            else if (Gender == 1)

                pbPersonPic.Image = Resources.femaleUser;
            else
                pbPersonPic.Image = null;

        }



        public static void ShowItemAsSelectedOnComboBoxByName(ref ComboBox CB, string ItemName)
        {
            for (int i = 0; i < CB.Items.Count; i++) 
            {
                if (CB.GetItemText(CB.Items[i]) == ItemName)
                {
                    CB.SelectedIndex = i;
                    return;
                }
            }
        }

        public static void ShowItemAsSelectedOnComboBoxByName(ref MaterialComboBox CB, string ItemName)
        {
            for (int i = 0; i < CB.Items.Count; i++)
            {
                if (CB.GetItemText(CB.Items[i]) == ItemName)
                {
                    CB.SelectedIndex = i;
                    return;
                }
            }
        }


        public static bool ValidateIfTxtBoxIsNotNumber(Control txtBox, string ErrorText, ErrorProvider errorProvider)
        {
            if (!IsNumber(txtBox.Text))
            {
                errorProvider.SetError(txtBox, ErrorText);
                return false;
            }

            return true;
        }

        public static bool ValidateTxtBox(TextBox txtBox, string ErrorCase, string ErrorText, ErrorProvider errorProvider)
        {
            if (txtBox.Text == ErrorCase)
            {
                errorProvider.SetError(txtBox, ErrorText);
                return false;
            }

            return true;
        }

        public static bool ValidateTxt(Control C, string ErrorCase, string ErrorText, ErrorProvider errorProvider)
        {
            if (C.Text == ErrorCase)
            {
                errorProvider.SetError(C, ErrorText);
                return false;
            }

            return true;
        }


        public static bool ValidateTxtBox(BunifuTextbox txtBox, string ErrorCase, string ErrorText, ErrorProvider errorProvider)
        {
            if (txtBox.Text == ErrorCase)
            {
                errorProvider.SetError(txtBox, ErrorText);
                return false;
            }

            return true;
        }

        public static bool ValidateCustomRadioButton(MaterialRadioButton bCtrl, bool ErrorCase, string ErrorText, ErrorProvider errorProvider)
        {
            if (bCtrl.Checked == ErrorCase)
            {
                errorProvider.SetError(bCtrl, ErrorText);
                return false;
            }

            return true;
        }


        public static bool ValidateTxtBox(Control txtBox, bool ErrorCase, string ErrorText, ErrorProvider errorProvider)
        {
            if (ErrorCase)
            {
                errorProvider.SetError(txtBox, ErrorText);
                return false;
            }

            return true;
        }

        public static bool ValidateCustomDatePicker(BunifuDatepicker bDatePicker, DateTime minDate, DateTime maxDate, string ErrorText, ErrorProvider errorProvider)
        {
            if (bDatePicker.Value > maxDate || bDatePicker.Value < minDate)
            {
                errorProvider.SetError(bDatePicker, ErrorText);
                return false;
            }

            return true;
        }


        public static DateTime GetBirthDateFor18YearsAgo()
        {
            DateTime today = DateTime.Today;
            DateTime birthDate = today.AddYears(-18);
            return birthDate;
        }

        public static DateTime GetBirthDateFor110YearsAgo()
        {
            DateTime today = DateTime.Today;
            DateTime maxAgeDate = today.AddYears(-110);
            return maxAgeDate;
        }


        public static bool IsEmailValid(string Email)
        {
            Email = Email.ToLower();
            return (Email.Contains("@") && Email.EndsWith(".com"));
        }

        public static bool IsDate1GreaterThanDate2(DateTime date1, DateTime date2)
        {
            return (date1 > date2);
        }

        public static void ImportDataToPersonObj(dynamic Val, ref dynamic Varible)
        {
            Varible = Val;
        }

        public static byte GetGenderIndexByName(string GenderName)
        {
            if (GenderName == "Male")
                return 0;
            else if (GenderName == "Female")
                return 1;
            else
                return 2;
        }

        public static void ImportNationalitiesToComboBox(ComboBox cbNationalities, DataTable dtCountries)
        {
            foreach (DataRow Row in dtCountries.Rows)
            {
                cbNationalities.Items.Add(Row["CountryName"].ToString());
            }
        }

        public static void ImportDataToComboBox(ComboBox CB, DataTable dtData, string ImportFromColumnName)
        {
            foreach (DataRow Row in dtData.Rows)
            {
                CB.Items.Add(Row[ImportFromColumnName].ToString());
            }
        }


        public static void DeleteOldPersonProfilePicFromSource(clsPerson Person)
        {
            if (!string.IsNullOrEmpty(Person.ProfilePic))
            {
                File.Delete(Person.ProfilePic);
            }
        }

        public static void ResetString(ref string S)
        {
            S = "";
        }

        public static void ResetCustomSearchBar(BunifuTextbox bTextBox, Label lblSearchBar)
        {
            bTextBox.text = "";
            lblSearchBar.Text = "Search";
        }

        public static void ResetCustomSearchBar(BunifuTextbox bTextBox, Label lblSearchBar, string SearchBarTxt)
        {
            bTextBox.text = "";
            lblSearchBar.Text = SearchBarTxt;
        }

        public static void ShowIndexOnSearchFilter(ComboBox cbSearchFilter, int Index)
        {
            cbSearchFilter.SelectedIndex = Index;

        }

        public static void Dis_EnableContol(Control Ctrl, bool Enable)
        {
            Ctrl.Enabled = Enable;
        }

        public static void In_VisibleControl(Control Ctrl, bool Visible)
        {
            Ctrl.Visible = Visible;
        }

        public static void ShowForm(Form FRM)
        {
            FRM.Show();
        }

        public static void PerfomTwoStatesButtonStyle(BunifuImageButton Button, Image OffStateImage, Image OnStateImage)
        {
            if (Button.Tag.ToString() == "0")
            {
                Button.Image = OnStateImage;
                Button.Tag = "1";

            }
            else
            {
                Button.Image = OffStateImage;
                Button.Tag = "0";

            }
        }

        public static bool CreateNonExistedEventSource(string Source, string LogName)
        {
            // Create the event source if it does not exist
            if (!EventLog.SourceExists(Source))
            {
                EventLog.CreateEventSource(Source, LogName);
                return true;
            }

            return false;
        }

        public static string WriteEntry(string Source, string Message, EventLogEntryType Type)
        {
            try
            {
                EventLog.WriteEntry(Source, Message, Type);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public static string ComputeHash(string Input)
        {
            //SHA is Secutred Hash Algorithm.
            // Create an instance of the SHA-256 algorithm
            using (SHA256 sha256 = SHA256.Create())
            {
                // Compute the hash value from the UTF-8 encoded input string
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(Input));


                // Convert the byte array to a lowercase hexadecimal string
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

        public static string Encrypt(string plainText, string key)
        {
            using (Aes aesAlg = Aes.Create())
            {
                // Set the key and IV for AES encryption
                aesAlg.Key = Encoding.UTF8.GetBytes(key);

                /*
                Here, you are setting the IV of the AES algorithm to a block of bytes 
                with a size equal to the block size of the algorithm divided by 8. 
                The block size of AES is typically 128 bits (16 bytes), 
                so the IV size is 128 bits / 8 = 16 bytes.
                 */
                aesAlg.IV = new byte[aesAlg.BlockSize / 8];


                // Create an encryptor
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);


                // Encrypt the data
                using (var msEncrypt = new System.IO.MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    using (var swEncrypt = new System.IO.StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(plainText);
                    }

                    // Return the encrypted data as a Base64-encoded string
                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }

        public static string Decrypt(string cipherText, string key)
        {
            using (Aes aesAlg = Aes.Create())
            {
                // Set the key and IV for AES decryption
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = new byte[aesAlg.BlockSize / 8];


                // Create a decryptor
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);


                // Decrypt the data
                using (var msDecrypt = new System.IO.MemoryStream(Convert.FromBase64String(cipherText)))
                using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                using (var srDecrypt = new System.IO.StreamReader(csDecrypt))
                {
                    // Read the decrypted data from the StreamReader
                    return srDecrypt.ReadToEnd();
                }
            }
        }

        public static bool ValidateSellerVisaForAddingProduct(clsSeller seller, int ProductPrice)
        {
            if (seller.User.Visas.Rows.Count > 0)
            {
                decimal TotalFee = AddingNewProductFeePerc / 100 * ProductPrice;

                if (Convert.ToInt32(seller.User.Visas.Rows[0]["TotalAmount"]) < TotalFee)
                {
                    MessageBox.Show($"Your Balance Is Not Enough To Proceed The Adding Process \nYou Need {TotalFee} To Add This Product", "Card Declined");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                MessageBox.Show($@"You Need A Card To Complete The Process", "No Card Available");
                return false;
            }
        }

        public static bool ValidateSellerVisaForMarketingProduct(clsSeller seller, int MarketingPrice)
        {
            if (seller.User.Visas.Rows.Count > 0)
            {
                int SellerTotalBalance = Convert.ToInt32(seller.User.Visas.Rows[0]["TotalAmount"]);
                if (SellerTotalBalance < MarketingPrice)
                {
                    MessageBox.Show($"Your Balance Is Not Enough To Proceed The Adding Process" +
                        $" \nYou Need {MarketingPrice - SellerTotalBalance} To Add This Product", "Card Declined",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                MessageBox.Show($@"You Need A Card To Complete The Process", "No Card Available");
                return false;
            }
        }

        public static bool ValidateUserVisaForBuyingProduct(clsUser User, decimal TotalPrice)
        {
            if (User.Visas.Rows.Count > 0)
            {
                decimal SellerTotalBalance = Convert.ToDecimal(User.Visas.Rows[0]["TotalAmount"]);
                if (SellerTotalBalance < TotalPrice)
                {
                    MessageBox.Show($"Your Balance Is Not Enough To Proceed The Buying Process" +
                        $" \nYou Need {TotalPrice - SellerTotalBalance} To Buy This Product", "Card Declined",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                MessageBox.Show($@"You Need A Card To Complete The Process", "No Card Available");
                return false;
            }
        }


        public static void DeleteOldSourceFile(string FilePath)
        {
            if (!string.IsNullOrEmpty(FilePath))
            {
                System.IO.File.Delete(FilePath);
            }
        }


        public static void AddProductToMainCtrlProductsList(clsProduct Product)
        {
            ctrlProductThumbNail productThumbNail = new ctrlProductThumbNail();
            productThumbNail.DisplayProductData(Product);

            productThumbNail.OnProductClick += frmProductsList.ProductClick;
            productThumbNail.OnFavouritClick += frmProductsList.FavouritClick;
            productThumbNail.OnAddToCartClick += frmProductsList.AddToCartClick;

            ctrlProductThumbNailsList.Add(productThumbNail);
        }

        public static void UpdateProductInMainList(clsProduct product)
        {
            int ProductIndex = GetProductIndexInList(product);

            ctrlProductThumbNail productThumbNail = new ctrlProductThumbNail();
            productThumbNail.DisplayProductData(product);

            productThumbNail.OnProductClick += frmProductsList.ProductClick;
            productThumbNail.OnFavouritClick += frmProductsList.FavouritClick;
            productThumbNail.OnAddToCartClick += frmProductsList.AddToCartClick;

            ctrlProductThumbNailsList[ProductIndex] = productThumbNail;
        }

    }
}
