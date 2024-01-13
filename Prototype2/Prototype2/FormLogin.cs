using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Prototype2
{
    public partial class FormLogin : Form
    {
        
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\Login1.mdf;Integrated Security=True;Connect Timeout=30;");
        public FormLogin()
        {
            InitializeComponent();
            panelLogin.Visible = true;
            panelRegistration.Visible = true;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        

        private void btnSignin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" && txtPassword.Text != "")
            {
                if (txtUserName.Text == "admin") { 
                System.Drawing.Color[] backcolor = new System.Drawing.Color[4] { Color.LightSkyBlue, Color.LightCoral, Color.Blue, Color.LightCyan };
                SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from staff_tbl where username='" + txtUserName.Text + "' and password= '" + txtPassword.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    BackColor = backcolor[1];
                    this.Hide();
                    FormMain newForm = new FormMain();
                    newForm.Show();
                    con.Close();
                }
                else
                {
                    this.BackColor = backcolor[3];
                    MessageBox.Show("Please, check your username and password!");
                }}
                else {
                    System.Drawing.Color[] backcolor = new System.Drawing.Color[4] { Color.LightSkyBlue, Color.LightCoral, Color.Blue, Color.LightCyan };
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from user_tbl where username='" + txtUserName.Text + "' and password= '" + txtPassword.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        BackColor = backcolor[1];
                        this.Hide();
                        MenuUser newForm = new MenuUser();
                        newForm.Show();
                        con.Close();
                        
                    }
                    else
                    {
                        this.BackColor = backcolor[3];
                        MessageBox.Show("Please, check your username and password!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Fill all fields to login.");
            }
        }

        private void lblCreateAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelLogin.Visible = false;
            panelRegistration.Visible = true;

        }

        private static Regex PasswordValidation()
        {
              string pattern = "(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{8,15})$";

              return new Regex(pattern, RegexOptions.IgnoreCase);
        }
        static Regex vaildate_password = PasswordValidation();
        private void btnSave_Click(object sender, EventArgs e)
        {
            var EmailId = txtEmail.Text;
            var username = txtNewUserName.Text;
            var password = txtNewPassword.Text;

            string pattern = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
            Regex eng = new Regex("^[a-zA-Z0-9]*$", RegexOptions.Compiled);

            if (txtNewPassword.Text == txtReEnterP.Text && txtNewUserName.Text != "" && txtNewPassword.Text != "")
            {
                if (Regex.IsMatch(txtNewUserName.Text, "^[a-zA-Z0-9]*$") && Regex.IsMatch(txtNewPassword.Text, "^[a-zA-Z0-9]*$") && Regex.IsMatch(txtEmail.Text, "^[a-zA-Z0-9]*$"))
                {
                    //Password validation
                    if (vaildate_password.IsMatch(txtNewPassword.Text) != true)
                    {
                        MessageBox.Show("Пароль должен быть не менее 8-15 символов. Он должен содержать как минимум один заглавный регистр и цифру.", "Неверный", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtNewPassword.Focus();
                        return;
                    }
                    else
                    {//check the string
                        if (Regex.IsMatch(EmailId, pattern))
                        {//if email is valid
                            con.Open();
                            try
                            {
                                SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO user_tbl(username, email, password) VALUES('" + txtNewUserName.Text + "', '" + txtEmail.Text + "', '" + txtNewPassword.Text + "')", con);
                                DataTable dt = new DataTable();
                                sda.Fill(dt);
                            }
                            finally
                            {
                                con.Close();
                            }
                            MessageBox.Show("Поздравляем! Вы успешно зарегистрировались.");

                        }
                        else
                        {
                            MessageBox.Show("Ошибка! Электронная почта недействительна, пожалуйста, перепишите ее!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка! Все поля должны быть написаны англиским алфовитом!");
                }
            }
            else
            {
                MessageBox.Show("Ошибка! Перепишите пароли и проверьте, совпадают ли они и заполните все поля!");
            }
        }


        private void LabelEffect_Click(object sender, EventArgs e)
        {
            var lbl = sender as Label;
            if (lbl.Location.X == 54)
            {
                lbl.Font = new Font("Century Gothic", 10);
                lbl.Cursor = Cursors.IBeam;
                lbl.Location = new Point(lbl.Location.X - 3, lbl.Location.Y - 140);
                foreach (Control txt in panelLogin.Controls)
                {
                    if (txt.GetType() == typeof(TextBox) && txt.Name == "txt" + lbl.Name.Remove(0, 3))
                    {
                        txt.Focus();
                    }
                }
            }
        }


        private void TextbBox_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;


            foreach (Control ctrl in panelLogin.Controls)
            {
                if (ctrl.GetType() == typeof(Panel) && ctrl.Name == "pnl" + txt.Name.Remove(0, 3))
                {
                    ctrl.BackColor = Color.Lavender;
                }
                if (ctrl.GetType() == typeof(Label) && ctrl.Name == "lbl" + txt.Name.Remove(0, 3))
                {
                    ctrl.ForeColor = Color.Lavender;
                    if (ctrl.Location.X != 51)
                    {
                        ctrl.Font = new Font("Century Gothic", 10);
                        ctrl.Cursor = Cursors.IBeam;
                        ctrl.Location = new Point(ctrl.Location.X - 3, ctrl.Location.Y - 22);
                    }


                }
            }

        }

        private void TextbBox_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;

            foreach (Control ctrl in panelLogin.Controls)
            {
                if (ctrl.GetType() == typeof(Panel) && ctrl.Name == "pnl" + txt.Name.Remove(0, 3))
                {
                    ctrl.BackColor = Color.Lavender;
                }
                if (ctrl.GetType() == typeof(Label) && ctrl.Name == "lbl" + txt.Name.Remove(0, 3))
                {
                    ctrl.ForeColor = Color.Lavender;
                    if (string.IsNullOrWhiteSpace(txt.Text))
                    {
                        txt.Clear();
                        ctrl.Font = new Font("Century Gothic", 10);
                        ctrl.Cursor = Cursors.IBeam;
                        ctrl.Location = new Point(ctrl.Location.X + 3, ctrl.Location.Y + 22);
                    }


                }
            }

        }


        private void LabelEffectReg_Click(object sender, EventArgs e)
        {
            var pic = sender as PictureBox;
            if (pic.Location.X == 54)
            {
                pic.Font = new Font("Century Gothic", 10);
                pic.Cursor = Cursors.IBeam;
                pic.Location = new Point(pic.Location.X - 3, pic.Location.Y - 140);
                foreach (Control txt in panelRegistration.Controls)
                {
                    if (txt.GetType() == typeof(TextBox) && txt.Name == "txt" + pic.Name.Remove(0, 3))
                    {
                        txt.Focus();
                    }
                }
            }
        }


        private void TextbBoxReg_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;

            foreach (Control ctrl in panelRegistration.Controls)
            {
                if (ctrl.GetType() == typeof(Panel) && ctrl.Name == "pnl" + txt.Name.Remove(0, 3))
                {
                    ctrl.BackColor = Color.Lavender;
                }
                if (ctrl.GetType() == typeof(Label) && ctrl.Name == "lbl" + txt.Name.Remove(0, 3))
                {
                    ctrl.ForeColor = Color.Lavender;
                    if (ctrl.Location.X != 51)
                    {
                        ctrl.Font = new Font("Century Gothic", 10);
                        ctrl.Cursor = Cursors.IBeam;
                        ctrl.Location = new Point(ctrl.Location.X - 3, ctrl.Location.Y - 22);
                    }

                }
            }

        }

        private void TextbBoxReg_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;

            foreach (Control ctrl in panelRegistration.Controls)
            {
                if (ctrl.GetType() == typeof(Panel) && ctrl.Name == "pnl" + txt.Name.Remove(0, 3))
                {
                    ctrl.BackColor = Color.Lavender;
                }
                if (ctrl.GetType() == typeof(Label) && ctrl.Name == "lbl" + txt.Name.Remove(0, 3))
                {
                    ctrl.ForeColor = Color.Lavender;
                    if (string.IsNullOrWhiteSpace(txt.Text))
                    {
                        txt.Clear();
                        ctrl.Font = new Font("Century Gothic", 10);
                        ctrl.Cursor = Cursors.IBeam;
                        ctrl.Location = new Point(ctrl.Location.X + 3, ctrl.Location.Y + 22);
                    }

                }
            }

        }

       private void chkShowPassword_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked == false)
            {
                txtPassword.UseSystemPasswordChar = true;
            }

            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }

            if (checkbPassword.Checked == false)
            {
                txtNewPassword.UseSystemPasswordChar = true;
                txtReEnterP.UseSystemPasswordChar = true;
            }

            else
            {
                txtNewPassword.UseSystemPasswordChar = false;
                txtReEnterP.UseSystemPasswordChar = false;
            }
        }
       
        
        //Close-Maximize-Minimize
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;

            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMinimizer_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizer_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;

            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnExitr_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelLogin.Visible = true;
            panelRegistration.Visible = false;
        }

        private void lblForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormForgotPass newForm = new FormForgotPass();
            newForm.Show();
        }
    }

}
