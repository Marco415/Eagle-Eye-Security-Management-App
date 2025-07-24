/* GERDUS ALBERTS – 45076685
CHRISTIAN ENGELS – 37725068
MARCO ENGELS – 45277427
DIRK ODENDAAL – 45790728
JP RETIEF – 38279118
HARDUS STAPELBERG – 34205713
JOHAN STEYN - 45139377
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SecurityPersonnelForm;
using TemplateForm;
using Equipment;

namespace MainForm
{
    public partial class frmMain : Form
    {
        bool showLogin = true;
        public frmMain()
        {
            InitializeComponent();
        }

        public frmMain(bool showLogin)
        {
            this.showLogin = showLogin;
            InitializeComponent();          
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (showLogin)
                createFrom();
            ApplyTheme();

            //user access
            StreamReader userFile = new StreamReader("CurrentUser.txt");
            string line = userFile.ReadLine();
            userFile.Close();
            if (line == "Personnel")
            {
                btnSecurityPersonnel.Enabled = false;
                btnShifts.Enabled = false;
                btnSectors.Enabled = false;
                btnEquipment.Enabled = false;
                btnReports.Enabled = false;
            }
            else if (line == "Secretary")
            {
                btnSecurityPersonnel.Enabled = false;
                btnShifts.Enabled = false;
                btnSectors.Enabled = false;
                btnEquipment.Enabled = false;
                btnIncidents.Enabled = false;
            }
        }

        #region "Create popup for login"
        private void createFrom()
        {
            using (Form popupForm = new Form())
            {
                //create form design
                popupForm.StartPosition = FormStartPosition.CenterScreen;
                popupForm.Width = 500;
                popupForm.Height = 450;
                popupForm.Font = new Font("Arial", 10);
                popupForm.FormBorderStyle = FormBorderStyle.None;
                popupForm.Icon = new Icon("Eagle_Eye_Icon.ico");

                ////add controls////
                //heading
                popupForm.Controls.Add(new Label()
                {
                    Name = "lblHeading",
                    Text = "Login",
                    Left = 210,
                    Top = 20,
                    Font = new Font("Arial", 20),
                    Width = 150,
                    Height = 50
                });
                //labels
                popupForm.Controls.Add(new Label()
                {
                    Name = "lblUsername",
                    Text = "Username: ",
                    Top = 120, //+50 for next label
                    Left = 50
                });
                popupForm.Controls.Add(new Label()
                {
                    Name = "lblPassword",
                    Text = "Password: ",
                    Top = 200, //+50 for next label
                    Left = 50
                });
                //text boxes
                TextBox txtUsername = new TextBox()
                {
                    Top = 115, //+50 for next text box
                    Left = 175,
                    Width = 202,
                    Text = "Admin"
                };
                popupForm.Controls.Add(txtUsername);
                TextBox txtPassword = new TextBox()
                {
                    Top = 195, //+50 for next text box
                    Left = 175,
                    Width = 202,
                    Text = "Gr!8s#l2R0c&X",
                    PasswordChar = '*'
                };
                popupForm.Controls.Add(txtPassword);
                //button
                Button btnLogin = new Button()
                {
                    Text = "Login",
                    Top = 275,
                    Left = 175,
                    Width = 150,
                    Height = 59
                };
                popupForm.Controls.Add(btnLogin);
                btnLogin.Click += new EventHandler(Button_Click);
                Button btnCancel = new Button()
                {
                    Text = "Cancel",
                    Top = 350,
                    Left = 175,
                    Width = 150,
                    Height = 59
                };
                popupForm.Controls.Add(btnCancel);
                btnCancel.Click += new EventHandler(CancelButton_Click);
                //show and hide password buttons
                string path1 = @"ShowPassword.png";
                PictureBox picShowPassword = new PictureBox()
                {
                    Image = Image.FromFile(Path.GetFullPath(path1)),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Top = 198,
                    Left = 400,
                    Height = 20,
                    Width = 30,
                    Visible = true
                };
                popupForm.Controls.Add(picShowPassword);
                string path2 = @"HidePassword.png";
                PictureBox picHidePassword = new PictureBox()
                {
                    Image = Image.FromFile(Path.GetFullPath(path2)),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Top = 198,
                    Left = 400,
                    Height = 20,
                    Width = 30,
                    Visible = false
                };
                popupForm.Controls.Add(picHidePassword);
                picShowPassword.Click += new EventHandler(ShowImage_Click);
                picHidePassword.Click += new EventHandler(HideImage_Click);

                //show form
                popupForm.ShowDialog();

                //button event
                void Button_Click(object sender, EventArgs e)
                {
                    bool validAdmin = checkLoginDetails();

                    if (validAdmin)
                        popupForm.Close();
                }

                //cancel button event
                void CancelButton_Click(object sender, EventArgs e)
                {
                    popupForm.Close();
                    Application.Exit();
                }

                //show button event
                void ShowImage_Click(object sender, EventArgs e)
                {
                    txtPassword.PasswordChar = '\0';
                    picShowPassword.Visible = false;
                    picHidePassword.Visible = true;
                }

                //hide button event
                void HideImage_Click(object sender, EventArgs e)
                {
                    txtPassword.PasswordChar = '*';
                    picHidePassword.Visible = false;
                    picShowPassword.Visible = true;
                }

                //check login details
                bool checkLoginDetails()
                {
                    try
                    {
                        //admin file
                        StreamReader adminFile = new StreamReader("AdminDetails.txt");
                        string usernameAdmin = adminFile.ReadLine();
                        string passwordAdmin = adminFile.ReadLine();

                        //personnel file
                        StreamReader personnelFile = new StreamReader("PersonnelDetails.txt");
                        string usernamePersonnel = personnelFile.ReadLine();
                        string passwordPersonnel = personnelFile.ReadLine();

                        //secretary file
                        StreamReader secretaryFile = new StreamReader("SecretaryDetails.txt");
                        string usernameSecretary = secretaryFile.ReadLine();
                        string passwordSecretary = secretaryFile.ReadLine();

                        bool validUser = false;
                        StreamWriter writeFile = new StreamWriter("CurrentUser.txt");

                        //check for valid user
                        if (usernameAdmin == txtUsername.Text && passwordAdmin == txtPassword.Text)
                        {
                            validUser = true;
                            writeFile.WriteLine("Admin");
                        }
                        else if (usernamePersonnel == txtUsername.Text && passwordPersonnel == txtPassword.Text)
                        {
                            validUser = true;
                            writeFile.WriteLine("Personnel");
                        }
                        else if (usernameSecretary == txtUsername.Text && passwordSecretary == txtPassword.Text)
                        {
                            validUser = true;
                            writeFile.WriteLine("Secretary");
                        }

                        if (validUser == false)
                            MessageBox.Show("Incorrect username or password");
                        adminFile.Close();
                        personnelFile.Close();
                        secretaryFile.Close();
                        writeFile.Close();
                        return validUser;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        throw;
                    }
                }  
            }
        }
        #endregion

        protected void NavigateToForm(Form targetForm)
        {
            targetForm.Show();
            targetForm.Tag = this;
            this.Hide(); // or Close() depending on desired behavior
        }

        private void ApplyTheme()
        {
            this.BackColor = Color.White; // Set a consistent background color
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = Color.LightGray; // Example styling
                    btn.Font = new Font("Arial", 10, FontStyle.Bold);
                }
            }
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            NavigateToForm(new frmReports());
        }

        private void btnEquipment_Click(object sender, EventArgs e)
        {
            NavigateToForm(new frmEquipment());
        }

        private void btnSecurityPersonnel_Click_1(object sender, EventArgs e)
        {
            NavigateToForm(new frmSecurityPersonnel());
        }

        private void btnShifts_Click(object sender, EventArgs e)
        {
            NavigateToForm(new frmShifts());
        }

        private void btnSectors_Click(object sender, EventArgs e)
        {
            NavigateToForm(new frmSectors());
        }

        private void btnIncidents_Click(object sender, EventArgs e)
        {
            NavigateToForm(new frmIncidents());
        }
    }
}
