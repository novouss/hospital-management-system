using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using hospital_management_system.classes;

namespace hospital_management_system
{
    public partial class FormEmployee : Form
    {

        private dbAccess db = new dbAccess();
        private Employees employee = null;

        public FormEmployee(string function, Employees employee = null)
        {
            InitializeComponent();
            InitalizeComboboxItems();
            this.employee = employee;

            switch (function)
            {
                case "view":
                    LoadViewEmployee();
                    break;
                case "edit":
                    LoadEditEmployee();
                    break;
                case "add":
                    LoadAddEmployee();
                    break;
            }
        }

        private void LoadAddEmployee()
        {
            employeeForm.Text = "Add Employee";
            // Visualizes Information and record
            personalGroupbox.Visible = true;
            addressGroupbox.Visible = true;
            staffGroupbox.Visible = true;
            // Configure user input
            personalGroupbox.Enabled = true;
            addressGroupbox.Enabled = true;
            staffGroupbox.Enabled = true;
            // Configure buttons
            deleteBtn.Visible = false;
            cancelBtn.Visible = true;
            modifyBtn.Visible = false;
            saveBtn.Visible = true;

            saveBtn.Click += SaveNewEmployee;
        }

        private void SaveNewEmployee(object sender, EventArgs e)
        {
            this.employee = new Employees();
            this.employee.FirstName = firstnameInfobox.TextboxText;
            this.employee.MiddleName = middlenameInfobox.TextboxText;
            this.employee.LastName = lastnameInfobox.TextboxText;
            this.employee.Birthdate = birthdateInfobox.GetDate();
            this.employee.Gender = genderInfobox.GetCheckedRadio();
            this.employee.Religion = religionInfobox.TextboxText;
            this.employee.Email = emailInfobox.TextboxText;
            this.employee.PhoneNumber = numberInfobox.TextboxText;
            this.employee.DepartmentID = (departmentInfobox.SelectedValue as Departments).DepartmentID;
            this.employee.RoleID = (roleInfobox.SelectedValue as Roles).RoleID;
            this.employee.Password = passwordInfobox.TextboxText;

            Addresses address = new Addresses();
            address.Address1 = address1Infobox.TextboxText;
            address.Address2 = address2Infobox.TextboxText;
            address.City = cityInfobox.TextboxText;
            address.Province = provinceInfobox.TextboxText;
            address.Zipcode = zipcodeInfobox.TextboxText;
            address.Country = countryInfobox.TextboxText;

            db.AddEmployee(this.employee, address);

            this.Close();
        }

        private void LoadEditEmployee()
        {
            employeeForm.Text = "Edit Employee: " + this.employee.EmployeeID;
            // Visualizes Information and record
            personalGroupbox.Visible = true;
            addressGroupbox.Visible = true;
            staffGroupbox.Visible = true;
            // Configure user input
            personalGroupbox.Enabled = true;
            addressGroupbox.Enabled = true;
            staffGroupbox.Enabled = true;
            // Configure buttons
            deleteBtn.Visible = true;
            cancelBtn.Visible = true;
            modifyBtn.Visible = false;
            saveBtn.Visible = true;

            saveBtn.Click += SaveEditEmployee_Click;
        }

        private void SaveEditEmployee_Click(object sender, EventArgs e)
        {
            this.employee.FirstName = firstnameInfobox.TextboxText;
            this.employee.MiddleName = middlenameInfobox.TextboxText;
            this.employee.LastName = lastnameInfobox.TextboxText;
            this.employee.Birthdate = birthdateInfobox.GetDate();
            this.employee.Gender = genderInfobox.GetCheckedRadio();
            this.employee.Religion = religionInfobox.TextboxText;
            this.employee.Email = emailInfobox.TextboxText;
            this.employee.PhoneNumber = numberInfobox.TextboxText;
            this.employee.DepartmentID = (departmentInfobox.SelectedValue as Departments).DepartmentID;
            this.employee.RoleID = (roleInfobox.SelectedValue as Roles).RoleID;
            this.employee.Password = passwordInfobox.TextboxText;
            // this.employee.Status = statusInfobox.Checked;

            Addresses address = new Addresses();
            address.Address1 = address1Infobox.TextboxText;
            address.Address2 = address2Infobox.TextboxText;
            address.City = cityInfobox.TextboxText;
            address.Province = provinceInfobox.TextboxText;
            address.Zipcode = zipcodeInfobox.TextboxText;
            address.Country = countryInfobox.TextboxText;

            db.EditEmployee(this.employee, address);

            this.Close();
        }

        private void LoadViewEmployee()
        {
            employeeForm.Text = "Viewing Employee: " + this.employee.EmployeeID;
            // Visualizes Information and record
            personalGroupbox.Visible = true;
            addressGroupbox.Visible = true;
            staffGroupbox.Visible = true;
            // Configure user input
            personalGroupbox.Enabled = false;
            addressGroupbox.Enabled = false;
            staffGroupbox.Enabled = false;
            // Configure buttons
            deleteBtn.Visible = false;
            cancelBtn.Visible = true;
            modifyBtn.Visible = true;
            saveBtn.Visible = false;

            // Display Information
            Addresses address = db.GetAddress(this.employee.AddressID)[0];

            firstnameInfobox.TextboxText = this.employee.FirstName;
            middlenameInfobox.TextboxText = this.employee.MiddleName;
            lastnameInfobox.TextboxText = this.employee.LastName;
            birthdateInfobox.DateText = this.employee.Birthdate;
            switch (this.employee.Gender)
            {
                case "Male":
                    genderInfobox.RadioChecked1 = true;
                    break;
                case "Female":
                    genderInfobox.RadioChecked2 = true;
                    break;
                default:
                    genderInfobox.RadioChecked3 = true;
                    genderInfobox.TextboxText = this.employee.Gender;
                    break;
            }
            religionInfobox.TextboxText = this.employee.Religion;
            emailInfobox.TextboxText = this.employee.Email;
            numberInfobox.TextboxText = this.employee.PhoneNumber;
            departmentInfobox.ComboboxText = db.GetDepartments(this.employee.DepartmentID)[0].Description;
            roleInfobox.ComboboxText = db.GetRoles(this.employee.RoleID)[0].Description;
            passwordInfobox.TextboxText = this.employee.Password;
            // this.employee.Status = statusInfobox.Checked;

            address1Infobox.TextboxText = address.Address1;
            address2Infobox.TextboxText = address.Address2;
            cityInfobox.TextboxText = address.City;
            provinceInfobox.TextboxText = address.Province;
            zipcodeInfobox.TextboxText = address.Zipcode;
            countryInfobox.TextboxText = address.Country;
        }

        private void InitalizeComboboxItems()
        {
            // Initalize Deparmtent

            List<Departments> departments = db.GetListDepartments();

            departmentInfobox.ValueMemeber = null;
            departmentInfobox.DisplayMember = "Description";
            departmentInfobox.DataSource = departments;


            // Inialize Roels

            List<Roles> roles = db.GetListRoles();

            roleInfobox.ValueMemeber = null;
            roleInfobox.DisplayMember = "Description";
            roleInfobox.DataSource = roles;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            // TODO: Create Messagebox warning
            db.RemoveEmployee(this.employee);

            this.Close();
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            LoadEditEmployee();
        }
    }
}
