using System;
using System.Windows.Forms;

namespace Example13
{
    public partial class PartyForm : Form
    {
        private SQLConnectionClass SQLcc =
            new SQLConnectionClass();

        public PartyForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //this.Hide();
            buttonNew.Enabled = true;
            buttonDelete.Enabled = true;
            PartyForm_Load(null, null);
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            if (buttonNew.Enabled == true)
            {
                textBoxID.Text = string.Empty;
                textBoxTitle.Text = string.Empty;
                textBoxName.Text = string.Empty;
                textBoxLastName.Text = string.Empty;
                textBoxNationalCode.Text = string.Empty;
                comboBoxType.Text = string.Empty;
                textBoxPhone.Text = string.Empty;
                textBoxMobile.Text = string.Empty;
                textBoxSex.Text = string.Empty;
                textBoxAddress.Text = string.Empty;

                buttonNew.Enabled = false;
                buttonDelete.Enabled = false;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string Script;

            if (buttonDelete.Enabled == true)
            {
                Script = @"DELETE dbo.Party
							WHERE PartyID = " + textBoxID.Text;
                SQLcc.ModifyRecord(Script);
                MessageBox.Show("Record is deleted.", "Delete Result", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

			this.partyTableAdapter.Fill(this.cSharpDataBaseDataSet.Party);
		}

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //برای ثبت مقدار نوع ابتدا مقدار معادل رو به این متغیر میدیم
            int PartyType;
            //با این شرط مقدار رو بهش میدیم که اگر شخص بود صفر و شرکت بود 1
            PartyType = (comboBoxType.Text == "Persone") ? 0 : 1;
            string Script;

            /*از طریق تعریف متغییرهایی مقدار های خالی برای یک فیلد را مدیریت می کنیم
			 همچنین اگر لازم باشه که قبل و بعدش کوتیشن باشه بهش اضافه می کنیم*/
            string varTitle =
                    (textBoxTitle.Text == string.Empty) ? "NULL" : textBoxTitle.Text;
            string varName =
                (textBoxName.Text == string.Empty) ? "NULL" : "'" + textBoxName.Text + "'";
            string varLastName =
                (textBoxLastName.Text == string.Empty) ? "NULL" : "'" + textBoxLastName.Text + "'";
            string varNationalCode =
                (textBoxNationalCode.Text == string.Empty) 
				? "NULL" : "'" + textBoxNationalCode.Text + "'";
            string varSex =
                (textBoxSex.Text == string.Empty) ? "NULL" : "'" + textBoxSex.Text + "'";
            string varMobile =
                (textBoxMobile.Text == string.Empty) ? "NULL" : "'" + textBoxMobile.Text + "'";
            string varPhone =
                (textBoxPhone.Text == string.Empty) ? "NULL" : "'" + textBoxPhone.Text + "'";

            //اول کنترل میکنیم که دکمه جدید فعاله یا نه. اگر غیر فعال باشه یعنی آیتم جدید
            //هست و باید وارد بشه و اگر فعاله یعنی داره ویرایش میشه
            if (buttonNew.Enabled == false)
            {
                Script = @"INSERT INTO dbo.Party
								(
									Title,
									FirstName,
									LastName,
									Alias,
									NationalID,
									Gender,
									Nationality,
									Allegiance,
									Religion,
									Subreligion,
									Mobile,
									Email,
									IDNumber,
									IDSerial,
									FatherName,
									BirthPlaceRef,
									BirthDate,
									IssuanceDate,
									IssuancePlaceRef,
									CompanyCode,
									Abbreviation,
									EconomicCode,
									RegistrationCode,
									CompanyType,
									ActivityType,
									Website,
									ReferenceCompany,
									[Group],
									CompanyName,
									Number,
									[Type],
									FirstName_EN,
									LastName_EN,
									CompanyName_EN,
									Creator,
									CreationDate,
									LastModifier,
									LastModificationDate,
									Tel,
									MaritalStatus,
									EducationDegree,
									MarriageDate,
									VATCertificateValidityDate
								)
								VALUES
								(
									" + varTitle + " , " +
                                    varName + " , " +
                                    varLastName + " , " +
                                    "NULL, " +
                                    varNationalCode + " , " +
                                    varSex + @" ,
									NULL,
									NULL,
									NULL,
									NULL, " +
                                    varMobile + ", " +
                                    varPhone + @",
                                    NULL,
									NULL,
									NULL,
									NULL,
									NULL,
									NULL,
									NULL,
									NULL,
									NULL,
									NULL,
									NULL,
									NULL,
									NULL,
									NULL,
									NULL,
									NULL,
									NULL,
									NULL, " +
                                    PartyType + @",
									NULL,
									NULL,
									NULL,
									NULL,
									NULL,
									NULL,
									NULL,
									NULL,
									NULL,
									NULL,
									NULL,
									NULL
								)";

                SQLcc.ModifyRecord(Script);
                buttonNew.Enabled = true;
                buttonDelete.Enabled = true;
                MessageBox.Show("New record is saved.", "Saving Result", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                Script = @"UPDATE dbo.Party
							SET
							Title = " + varTitle + ", " +
                            "FirstName = " + varName + ", " +
                            "LastName = " + varLastName + ", " +
                            "Alias = NULL, " +
                            "NationalID = " + varNationalCode + ", " +
                            "Gender = " + varSex + ", " +
                            @"Nationality = NULL,
							Allegiance = NULL,
							Religion = NULL,
							Subreligion = NULL,
							Mobile = " + varMobile + ", " +
                            "Email = " + varPhone + ", " +
                            @"IDNumber = NULL,
							IDSerial = NULL,
							FatherName = NULL,
							BirthPlaceRef = NULL,
							BirthDate = NULL,
							IssuanceDate = NULL,
							IssuancePlaceRef = NULL,
							CompanyCode = NULL,
							Abbreviation = NULL,
							EconomicCode = NULL,
							RegistrationCode = NULL,
							CompanyType = NULL,
							ActivityType = NULL,
							Website = NULL,
							ReferenceCompany = NULL,
							[Group] = NULL,
							CompanyName = NULL,
							Number = NULL,
							[Type] = " + PartyType + @",
							FirstName_EN = NULL,
							LastName_EN = NULL,
							CompanyName_EN = NULL,
							Creator = NULL,
							CreationDate = NULL,
							LastModifier = NULL,
							LastModificationDate = NULL,
							Tel = NULL,
							MaritalStatus = NULL,
							EducationDegree = NULL,
							MarriageDate = NULL,
							VATCertificateValidityDate = NULL

						WHERE PartyID = " + textBoxID.Text;

                SQLcc.ModifyRecord(Script);
                MessageBox.Show("Record is updated.", "Saving Result", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

			this.partyTableAdapter.Fill(this.cSharpDataBaseDataSet.Party);
		}

        private void PartyForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cSharpDataBaseDataSet.Party' table. 
			//You can move, or remove it, as needed.
            this.partyTableAdapter.Fill(this.cSharpDataBaseDataSet.Party);
        }
    }
}