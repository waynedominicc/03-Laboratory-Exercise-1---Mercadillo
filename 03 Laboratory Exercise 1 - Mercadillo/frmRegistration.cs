using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_Laboratory_Exercise_1___Mercadillo
{
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }

        private string _FullName;
        private int _Age;
        private long _ContactNo;
        private long _StudentNo;

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            string[] ListOfProgram = new string[]{
                "BS Information Technology",
                "BS Computer Science",
                "BS Information Systems",
                "BS in Accountancy",
                "BS in Hospitality Management",
                "BS in Tourism Management"
            };

            for (int i = 0; i < 6; i++)
            {
                cbPrograms.Items.Add(ListOfProgram[i].ToString());
            }

            string[] Gender = new string[]
            {
                "Male",
                "Female"
            };

            for (int i = 0; i < 2; i++)
            {
                cbGender.Items.Add(Gender[i].ToString());
            }
        }

        public long StudentNumber(string studNum)
        {
            _StudentNo = long.Parse(studNum);
            return _StudentNo;
        }

        public long ContactNo(string Contact)
        {
            if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
            {
                _ContactNo = long.Parse(Contact);
            }
            else
            {
                throw new IndexOutOfRangeException();
            }

            return _ContactNo;
        }

        public string FullName(string LastName, string FirstName, string MiddleInitial)
        {
            if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$") || Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") || Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
            {
                _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
            }
            else
            {
                throw new ArgumentNullException();
            }

            return _FullName;
        }

        public int Age(string age)
        {
            try
            {
                if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
                {
                    _Age = Int32.Parse(age);
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid age format. Input is not a valid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

            return _Age;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                StudentInformationClass.SetFullName = FullName(txtLastName.Text, txtFirstName.Text, txtMiddleInitial.Text);
                StudentInformationClass.SetStudentNo = Convert.ToInt32(StudentNumber(txtStudentNo.Text));
                StudentInformationClass.SetProgram = cbPrograms.Text;
                StudentInformationClass.SetGender = cbGender.Text;
                StudentInformationClass.SetContactNo = Convert.ToInt32(ContactNo(txtContactNo.Text));
                StudentInformationClass.SetAge = Age(txtAge.Text);
                StudentInformationClass.SetBirthday = datePickerBirthday.Value.ToString("yyyy-MM-dd");
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Invalid student number format. Input is too large.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Full name cannot be null!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Invalid contact number format. Input doesn't have the required number of digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                frmConfirmation frm = new frmConfirmation();
                frm.ShowDialog();
            }
        }
    }
}
