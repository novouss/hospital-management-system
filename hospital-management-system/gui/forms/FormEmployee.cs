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
        private EmployeeDetails employee = null;

        /*  public FormEmployee(string function, EmployeeDetails employee = null)
         {
             InitializeComponent();
             InitalizeComboboxItems();
             this.employee = employee;
             loadEmployee(function);
         }

         private void InitalizeComboboxItems()
         {
             // Get Roles
             List<Role> roles = new List<Role>();
             roles = db.getRoles();

             roleCombobox.ValueMember = null;
             roleCombobox.DisplayMember = "Description";
             roleCombobox.DataSource = roles;

             // Get Departments
             List<Department> departments = new List<Department>();
             departments = db.getDepartments();

             departmentCombobox.ValueMember = null;
             departmentCombobox.DisplayMember = "DepartmentName";
             departmentCombobox.DataSource = departments;

         };

         private void loadEmployee(string function)
         {
             switch (function)
             {
                 case "view":
                     employeeForm.Text = "View Employee ID: " + employee.EmployeeID;
                     viewEmployee(this.employee);
                     break;
                 case "modify":
                     employeeForm.Text = "Modify Employee ID: " + employee.EmployeeID;
                     modifyEmployee();
                     break;
                 case "add":
                     employeeForm.Text = "Add Employee";
                     addEmployee();
                     break;
                 default:
                     break;

             }
         }

         private void addEmployee()
         {
             // Visualize information
             infoGroup.Visible = true;
             accountGroup.Visible = true;
             addressGroup.Visible = true;
             departmentGroup.Visible = true;

             confirmPasswordPanel.Visible = false;

             // Allow for user input
             infoGroup.Enabled = true;
             accountGroup.Enabled = true;
             addressGroup.Enabled = true;
             departmentGroup.Enabled = true;

             // Visualize Buttons
             deleteBtn.Visible = false;
             cancelBtn.Visible = true;
             modifyBtn.Visible = false;
             saveBtn.Visible = true;

             //

             // Button Function
             saveBtn.Click += addEmployeeSaveBtn_Click;
             cancelBtn.Click += CancelBtn_Click;
         }

         private void CancelBtn_Click(object sender, EventArgs e)
         {
             this.Close();
         }

         private void addEmployeeSaveBtn_Click(object sender, EventArgs e)
         {
             EmployeeDetails employee = new EmployeeDetails();

             employee.FirstName = firstnameTextbox.Text;
             employee.LastName = lastnameTextbox.Text;
             employee.MiddleName = middlenameTextbox.Text;
             employee.Birthdate = new DateTime(birthdateCalendar.Value.Year, birthdateCalendar.Value.Month, birthdateCalendar.Value.Day);

             if (maleRadio.Checked)
             {
                 employee.Gender = maleRadio.Text;
             } else if (femaleRadio.Checked)
             {
                 employee.Gender = femaleRadio.Text;
             } else if (othersRadio.Checked)
             {
                 employee.Gender = anyGenderTextbox.Text;
             }

             employee.Religion = religionTextbox.Text;
             employee.Email = emailTextbox.Text;
             employee.PhoneNumber = phoneTextbox.Text;

             Role role = (Role)roleCombobox.SelectedValue;
             employee.RoleID = role.RoleID;
             employee.Password = passwordTextbox.Text;

             employee.Address1 = address1Textbox.Text;
             employee.Address2 = address2Textbox.Text;
             employee.City = cityTextbox.Text;
             employee.Province = stateTextbox.Text;
             employee.Zipcode = zipcodeTextbox.Text;
             employee.Country = countryTextbox.Text;

             Department department = (Department)departmentCombobox.SelectedValue;
             employee.DepartmentID = department.DepartmentID;

             db.addEmployee(employee);

             this.Close();
         }

         private void viewEmployee(EmployeeDetails employee)
         {
             this.employee = employee;
             // Visualize information
             infoGroup.Visible = true;
             accountGroup.Visible = true;
             addressGroup.Visible = true;
             departmentGroup.Visible = true;

             confirmPasswordPanel.Visible = false;

             // Do not allow for user input
             infoGroup.Enabled = false;
             accountGroup.Enabled = false;
             addressGroup.Enabled = false;
             departmentGroup.Enabled = false;

             // Visualize Buttons
             deleteBtn.Visible = true;
             cancelBtn.Visible = false;
             modifyBtn.Visible = true;
             saveBtn.Visible = false;

             // Visualize Information
             firstnameTextbox.Text = employee.FirstName;
             lastnameTextbox.Text = employee.LastName;
             middlenameTextbox.Text = employee.MiddleName;
             birthdateCalendar.Value = employee.Birthdate;

             maleRadio.Checked = employee.Gender == "Male";
             femaleRadio.Checked = employee.Gender == "Female";

             if (employee.Gender != "Male" && employee.Gender != "Female")
             {
                 othersRadio.Checked = true;
                 anyGenderTextbox.Text = employee.Gender;
             }

             religionTextbox.Text = employee.Religion;
             emailTextbox.Text = employee.Email;
             phoneTextbox.Text = employee.PhoneNumber;

             Role role = db.findRole(employee.RoleID)[0];
             roleCombobox.Text = role.Description;
             passwordTextbox.Text = employee.Password;

             address1Textbox.Text = employee.Address1;
             address2Textbox.Text = employee.Address2;
             cityTextbox.Text = employee.City;
             stateTextbox.Text = employee.Province;
             zipcodeTextbox.Text = employee.Zipcode;
             countryTextbox.Text = employee.Country;

             Department department = db.findDepartment(employee.DepartmentID)[0];
             departmentCombobox.Text = department.DepartmentName;

             // Button Function
             modifyBtn.Click += modifyEmployeeBtn_Click;
         }

         private void modifyEmployeeBtn_Click(object sender, EventArgs e)
         {
             loadEmployee("modify");
         }

         private void modifyEmployee()
         {
             // Visualize information
             infoGroup.Visible = true;
             accountGroup.Visible = true;
             addressGroup.Visible = true;
             departmentGroup.Visible = true;

             confirmPasswordPanel.Visible = true;

             // Allow for user input
             infoGroup.Enabled = true;
             accountGroup.Enabled = true;
             addressGroup.Enabled = true;
             departmentGroup.Enabled = true;

             // Visualize Buttons
             deleteBtn.Visible = true;
             cancelBtn.Visible = true;
             modifyBtn.Visible = false;
             saveBtn.Visible = true;

             saveBtn.Click += SaveModifiedPaitentBtn_Click;
         }

         private void SaveModifiedPaitentBtn_Click(object sender, EventArgs e)
         {

             if (!passwordTextbox.Text.Equals(confirmPasswordTextbox.Text))
             {
                 HandleIncorrectPassword();
                 return;
             }

             this.employee.FirstName = firstnameTextbox.Text;
             this.employee.LastName = lastnameTextbox.Text;
             this.employee.MiddleName = middlenameTextbox.Text;
             this.employee.Birthdate = new DateTime(birthdateCalendar.Value.Year, birthdateCalendar.Value.Month, birthdateCalendar.Value.Day);

             if (maleRadio.Checked)
             {
                 this.employee.Gender = maleRadio.Text;
             }
             else if (femaleRadio.Checked)
             {
                 this.employee.Gender = femaleRadio.Text;
             }
             else if (othersRadio.Checked)
             {
                 this.employee.Gender = anyGenderTextbox.Text;
             }

             this.employee.Religion = religionTextbox.Text;
             this.employee.Email = emailTextbox.Text;
             this.employee.PhoneNumber = phoneTextbox.Text;

             Role role = (Role)roleCombobox.SelectedValue;
             this.employee.RoleID = role.RoleID;
             this.employee.Password = passwordTextbox.Text;

             this.employee.Address1 = address1Textbox.Text;
             this.employee.Address2 = address2Textbox.Text;
             this.employee.City = cityTextbox.Text;
             this.employee.Province = stateTextbox.Text;
             this.employee.Zipcode = zipcodeTextbox.Text;
             this.employee.Country = countryTextbox.Text;

             Department department = (Department)departmentCombobox.SelectedValue;
             this.employee.DepartmentID = department.DepartmentID;

             db.modifyEmployee(this.employee);

             this.Close();
         }

         private void othersRadio_CheckedChanged(object sender, EventArgs e)
         {
             anyGenderTextbox.Enabled = othersRadio.Checked;
         }

         private void femaleRadio_CheckedChanged(object sender, EventArgs e)
         {
             anyGenderTextbox.Enabled = othersRadio.Checked;
             anyGenderTextbox.Text = "";
         }

         private void maleRadio_CheckedChanged(object sender, EventArgs e)
         {
             anyGenderTextbox.Enabled = othersRadio.Checked;
             anyGenderTextbox.Text = "";
         }

         private void HandleIncorrectPassword()
         {
             passwordLabel.ForeColor = Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
             confirmPasswordLabel.ForeColor = Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
             passwordLabel.Text = "* Confirm Password didn't match";
             confirmPasswordLabel.Text = "* Confirm Password didn't match";
         }

         private void passwordTextbox_TextChanged(object sender, EventArgs e)
         {
             passwordLabel.ForeColor = Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
             passwordLabel.Text = "Password";
         }

         private void confirmPasswordTextbox_TextChanged(object sender, EventArgs e)
         {
             confirmPasswordLabel.ForeColor = Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
             confirmPasswordLabel.Text = "Confirm Password";
         }*/

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void firstnameInfobox_Load(object sender, EventArgs e)
        {

        }

        private void middlenameInfobox_Load(object sender, EventArgs e)
        {

        }

        private void depInfobox_Load(object sender, EventArgs e)
        {

        }
    }
}
