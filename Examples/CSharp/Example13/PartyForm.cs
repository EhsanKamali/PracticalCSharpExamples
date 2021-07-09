using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            }
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (buttonNew.Enabled == true)
            {
                MessageBox.Show("Delete record.");
            }
            else
            {
                MessageBox.Show("Do nothing.");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string Script;
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
									" + textBoxTitle.Text + " , " +
									textBoxName.Text + " , " +
									textBoxLastName.Text + " , " +
									"NULL, " +
									textBoxNationalCode.Text + " , " +
									textBoxSex.Text + @" , 
									NULL, 
									NULL, 
									NULL, 
									NULL, " +
									textBoxMobile.Text + ", " +
									textBoxPhone.Text + ", " +
									@"NULL,
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
									comboBoxType.Text + @", 
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

				MessageBox.Show(Script);
				SQLcc.InsertRecord(Script);
				buttonNew.Enabled = true;
				MessageBox.Show("Save new record.");
            }
            else
            {
				Script = @"UPDATE dbo.Party
							SET
							Title = " + textBoxTitle.Text + ", " +
							"FirstName = " + textBoxName.Text + ", " +
							"LastName = " + textBoxLastName.Text + ", " +
							"Alias = NULL, " +
							"NationalID = " + textBoxNationalCode.Text + ", " +
							"Gender = " + textBoxSex.Text + ", " +
							@"Nationality = NULL,
							Allegiance = NULL,
							Religion = NULL,
							Subreligion = NULL,
							Mobile = " + textBoxMobile.Text + ", " +
							"Email = " + textBoxPhone.Text + ", " +
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
							[Type] = " + comboBoxType.Text + @", 
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

				

				SQLcc.ModifyRecord(SQLcc.CorrectText(Script));
				MessageBox.Show("Update record.");
            }
        }

        private void PartyForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cSharpDataBaseDataSet.Party' table. You can move, or remove it, as needed.
            this.partyTableAdapter.Fill(this.cSharpDataBaseDataSet.Party);

        }
    }
}
