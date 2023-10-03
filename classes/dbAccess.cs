using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace hospital_management_system
{
    public class dbAccess
    {

        #region Get Functions

        /*
        * Get Functions consists of public functions that returns one specific class based on their 'id.'
        * 
        * Region Contents:
        *     GetPatient(int id)               - Returns Patient Information from 'id' parameter.
        *     GetEmployee(int id)              - Returns Employee Information from 'id' parameter.
        *     GetAddresses(int id)             - Returns Addresses Information from 'id' parameter.
        *     GetRoles(int id)                 - Returns Roles Information from 'id' parameter.
        *     GetDepartments(int id)           - Returns Departments Information from 'id' parameter.
        *     GetRegistration(int id)          - Returns Registration Information from 'id' parameter.
        *     GetRooms(int id)                 - Returns Rooms Information from 'id' parameter.
        *     GetLaboratories(int id)          - Returns Laboratories Information from 'id' parameter.
        *     GetReport(int id)                - Returns Laboratories Report Information from 'id' parameter.
        *     GetBillings(int id)              - Returns Billings Information from 'id' parameter.
        *      
        * Special Cases Functions:
        *      GetEmployeeLogin(string email, string password)
        *      - Returns Employee Details based on 'email' and 'password'
        */

        public Patients GetPatient(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Patients>($"dbo.USP_GetPaitentInformation @PatientID = '{ id }'");

                return (output as List<Patients>)[0];
            }
        }

        public Employees GetEmployee(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Employees>($"dbo.USP_GetEmployeeInformation @EmployeeID = '{ id }'");

                return (output as List<Employees>)[0];
            }
        }

        public Addresses GetAddress(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Addresses>($"dbo.USP_GetAddressInformation @AddressID = '{ id }'");

                return (output as List<Addresses>)[0];
            }
        }

        public Roles GetRoles(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Roles>($"dbo.USP_GetRoleInformation @RoleID = '{ id }'");

                return (output as List<Roles>)[0];
            }
        }

        public Departments GetDepartments(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Departments>($"dbo.USP_GetDepartmentInformation @DepartmentID = '{ id }'");

                return (output as List<Departments>)[0];
            }
        }

        public Registrations GetRegistration(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Registrations>($"dbo.USP_GetRegistrationInformation @RegistrationID = '{ id }'");

                return (output as List<Registrations>)[0];
            }
        }

        public Rooms GetRooms(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Rooms>($"dbo.USP_GetRoomInformation @RoomID = '{ id }'");

                return (output as List<Rooms>)[0];
            }
        }

        public Laboratories GetLaboratories(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Laboratories>($"dbo.USP_GetLaboratoryInformation @LaboratoryID = '{ id }'");

                return (output as List<Laboratories>)[0];
            }
        }

        public Reports GetReport(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Reports>($"dbo.USP_FindReports @ResultID = '{ id }'");

                return (Reports)output;
            }
        }

        public Billings GetBillings(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Billings>($"dbo.USP_FindBillings @BillingsID = '{ id }'");

                return (Billings)output;
            }
        }

        public List<Employees> GetEmployeeLogin(string email, string password)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Employees>($"dbo.USP_GetEmployeeLogin @Email = '{ email }', @Password = '{ password }'");

                return (List<Employees>)output;
            }
        }

        #endregion

        #region Get List Functions

        /*
        * Get List Functions consists of public functions that returns a list of one specific class,
        * or depending on the parameters and conditions needed.
        * 
        * Region Contents:
        *      GetListPatients()        - Returns a List of Patient Information.
        *      GetListEmployees()       - Returns a List of Employee Information.
        *      GetListAddresses()       - Returns a List of Address Information.
        *      GetListRoless()          - Returns a List of Role Information.
        *      GetListDepartmentss()    - Returns a List of Department Information.
        *      GetListRegistrations()   - Returns a List of Registration Information.
        *      GetListRooms()           - Returns a List of Room Information.
        *      GetListLaboratories()    - Returns a List of Laboratory Information.
        *      GetListReports()         - Returns a List of Report Information.
        *      GetListBillings()        - Returns a List of Billing Information.
        * 
        *      Special Open Functions:
        *           GetListPatientRegistrations(int id)
        *           - Returns a List of Registrations of a Patient from 'id' parameter.
        *           GetListOpenRooms(int status)
        *           - Returns a List of Open Roomss from 'status' parameter.
        *           GetListOpenLaboratories(int status)
        *           - Returns a List of Open Laboratories from 'status' parameter.
        *           GetListOpenEmployeeDepartments(int dep_id, int status)
        *           - Returns a List of Open Employees from 'dep_id' and 'status' parameter.
        *           GetListRegistrationReport(int reg_id)
        *           - Returns a List of Report Details from 'reg_id' parameter.
        *           GetListFinishedRegistration(int status)
        *           - Returns a List of Finished Registrations from 'status' parameter.
        *           
        */

        public List<Patients> GetListPatients()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Patients>($"SELECT * FROM dbo.V_Patients");

                return (List<Patients>)output;
            }
        }

        public List<Employees> GetListEmployees()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Employees>($"SELECT * FROM dbo.V_Employees");

                return (List<Employees>)output;
            }
        }

        public List<Addresses> GetListAddresses()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Addresses>($"SELECT * FROM dbo.V_Addresses");

                return (List<Addresses>)output;
            }
        }

        public List<Roles> GetListRoles()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Roles>($"SELECT * FROM dbo.V_Roles");

                return (List<Roles>)output;
            }
        }

        public List<Departments> GetListDepartments()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Departments>($"SELECT * FROM dbo.V_Departments");

                return (List<Departments>)output;
            }
        }

        public List<Registrations> GetListRegistrations()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Registrations>($"SELECT * FROM dbo.V_Registrations");

                return (List<Registrations>)output;
            }
        }

        public List<Rooms> GetListRooms()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Rooms>($"SELECT * FROM dbo.V_Rooms");

                return (List<Rooms>)output;
            }
        }

        public List<Laboratories> GetListLaboratories()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Laboratories>($"SELECT * FROM dbo.V_Laboratories");

                return (List<Laboratories>)output;
            }
        }

        public List<Reports> GetListReports()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Reports>($"SELECT * FROM dbo.V_Reports");

                return (List<Reports>)output;
            }
        }

        public List<Billings> GetListBillings()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Billings>($"SELECT * FROM dbo.V_Billings");

                return (List<Billings>)output;
            }
        }

        public List<Registrations> GetListPatientRegistrations(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Registrations>($"dbo.USP_GetPatientRegistration @PatientID = { id }");

                return (List<Registrations>)output;
            }
        }

        public List<Rooms> GetListOpenRooms(int status)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Rooms>($"dbo.USP_OpenRoom @Status = '{ status }'");

                return (List<Rooms>)output;
            }
        }

        public List<Laboratories> GetListOpenLaboratories(int status)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Laboratories>($"dbo.USP_OpenLaboratory @Status = '{ status }'");

                return (List<Laboratories>)output;
            }
        }

        public List<Employees> GetListOpenDepartmentsEmployee(int dep_id, int status)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Employees>($"dbo.USP_OpenDepartmentEmployees @DepartmentID = '{ dep_id }', @Status = '{ status }'");

                return (List<Employees>)output;
            }
        }

        public List<Reports> GetListRegistrationReport(int reg_id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Reports>($"dbo.USP_GetRegistrationReport @RegistrationID = '{ reg_id }'");

                return (List<Reports>)output;
            }
        }

        public List<Registrations> GetListFinishedRegistration(int status)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var output = connection.Query<Registrations>($"dbo.USP_FinishedRegistration @Status = { status }");

                return (List<Registrations>)output;
            }
        }

        #endregion

        #region Patient Functions

        /*
         * Patient Functions consist of public functions that executes user stored procedures from the database.
         * 
         * Region Contents:
         *      AddPatient(Patient patient, Addresses address)        
         *      - Adds a patient record and address to the database.
         *      EditPatient(Patient patient)
         *      - Updates patient and address details.
         *      RemovePatient(Patient patient)
         *      - Removes patient and assigned address from database.
         * 
         */

        public void AddPatient(Patients patient, Addresses address)
        {
            
            
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var parameters = new {
                    FirstName = patient.FirstName,
                    MiddleName = patient.MiddleName,
                    LastName = patient.LastName,
                    Birthdate = patient.Birthdate,
                    Gender = patient.Gender,
                    Religion = patient.Religion,
                    Email = patient.Email,
                    PhoneNumber = patient.PhoneNumber,
                    Address1 = address.Address1,
                    Address2 = address.Address2,
                    City = address.City,
                    Province = address.Province,
                    Zipcode = address.Zipcode,
                    Country = address.Country
                };

                connection.Execute("dbo.USP_CreatePatient @FirstName, @LastName, @MiddleName, @Birthdate, @Gender, @Religion, @Email, @PhoneNumber, @Address1, @Address2, @City, @Province, @Zipcode, @Country", parameters);
            }
        }

        public void EditPatient(Patients patient, Addresses address)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var parameters = new
                {
                    PatientID = patient.PatientID,
                    FirstName = patient.FirstName,
                    MiddleName = patient.MiddleName,
                    LastName = patient.LastName,
                    Birthdate = patient.Birthdate,
                    Gender = patient.Gender,
                    Religion = patient.Religion,
                    Email = patient.Email,
                    PhoneNumber = patient.PhoneNumber,
                    Address1 = address.Address1,
                    Address2 = address.Address2,
                    City = address.City,
                    Province = address.Province,
                    Zipcode = address.Zipcode,
                    Country = address.Country
                };

                connection.Execute("dbo.USP_UpdatePatient @PatientID, @FirstName, @MiddleName, @LastName, @Birthdate, @Gender, @Religion, @Email, @PhoneNumber, @Address1, @Address2, @City, @Province, @Zipcode, @Country", parameters);
            }
        }

        public void RemovePatient(Patients patient)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var parameters = new
                {
                    PatientID = patient.PatientID
                };

                connection.Execute("dbo.USP_DropPatient @PatientID", parameters);
            }
        }

        #endregion

        #region Employee Functions

        /*
         * Employee Functions consist of public functions that executes user stored procedures from the database.
         * 
         * Region Contents:
         *      AddEmployee(Employees employee, Addresses address)        
         *      - Adds a employee record and address to the database.
         *      EditEmployee(Employees Employee)
         *      - Updates employee and address details.
         *      RemoveEmployee(Employees Employee)
         *      - Removes employee and assigned address from database.
         * 
         */
        public void AddEmployee(Employees employee, Addresses address)
        {


            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var parameters = new
                {
                    RoleID = employee.RoleID,
                    DepartmentID = employee.DepartmentID,
                    Password = employee.Password,
                    FirstName = employee.FirstName,
                    MiddleName = employee.MiddleName,
                    LastName = employee.LastName,
                    Birthdate = employee.Birthdate,
                    Gender = employee.Gender,
                    Religion = employee.Religion,
                    Email = employee.Email,
                    PhoneNumber = employee.PhoneNumber,
                    Address1 = address.Address1,
                    Address2 = address.Address2,
                    City = address.City,
                    Province = address.Province,
                    Zipcode = address.Zipcode,
                    Country = address.Country
                };

                connection.Execute("dbo.USP_CreateEmployee @RoleID, @DepartmentID, @Password, @FirstName, @MiddleName, @LastName, @Birthdate, @Gender, @Religion, @Email, @PhoneNumber, @Address1, @Address2, @City, @Province, @Zipcode, @Country", parameters);
            }
        }

        public void EditEmployee(Employees employee, Addresses address)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var parameters = new
                {
                    EmployeeID = employee.EmployeeID,
                    RoleID = employee.RoleID,
                    DepartmentID = employee.DepartmentID,
                    Status = employee.Status,
                    Password = employee.Password,
                    FirstName = employee.FirstName,
                    MiddleName = employee.MiddleName,
                    LastName = employee.LastName,
                    Birthdate = employee.Birthdate,
                    Gender = employee.Gender,
                    Religion = employee.Religion,
                    Email = employee.Email,
                    PhoneNumber = employee.PhoneNumber,
                    Address1 = address.Address1,
                    Address2 = address.Address2,
                    City = address.City,
                    Province = address.Province,
                    Zipcode = address.Zipcode,
                    Country = address.Country
                };

                connection.Execute("dbo.USP_UpdateEmployee @EmployeeID, @RoleID, @DepartmentID, @Status, @Password, @FirstName, @MiddleName, @LastName, @Birthdate, @Gender, @Religion, @Email, @PhoneNumber, @Address1, @Address2, @City, @Province, @Zipcode, @Country", parameters);
            }
        }

        public void RemoveEmployee(Employees employee)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var parameters = new
                {
                    EmployeeID = employee.EmployeeID
                };

                connection.Execute("dbo.USP_DropEmployee @EmployeeID", parameters);
            }
        }


        #endregion

        // TODO: Is Missing Documentation. Requesting @Karl-Duldulao
        #region Registration Functions

        public void AddRegistration(Registrations registration)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var parameters = new
                {
                    PatientID = registration.PatientID,
                    RoomID = registration.RoomID,
                    AdmissionOn = registration.AdmissionOn,
                    DischargeOn = registration.DischargeOn
                };

                connection.Execute("dbo.USP_CreateRegistration @PatientID, @RoomID, @AdmissionOn, @DischargeOn", parameters);
            }

        }

        public void EditRegistration(Registrations registration)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var parameters = new
                {
                    RegistrationID = registration.RegistrationID,
                    PatientID = registration.PatientID,
                    RoomID = registration.RoomID,
                    Status = registration.Status,
                    AdmissionOn = registration.AdmissionOn,
                    DischargeOn = registration.DischargeOn
                };
                connection.Execute("dbo.USP_UpdateRegistration @RegistrationID, @PatientID, @RoomID, @Status, @AdmissionOn, @DischargeOn", parameters);
            }

        }

        public void RemoveRegistration(Registrations registrations)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var parameters = new
                {
                    RegistrationID = registrations.RegistrationID
                };

                connection.Execute("dbo.USP_DropRegistration @RegistrationID", parameters);
            }
        }

        #endregion

        // TODO: Is Missing Documentation. Requesting @kinleo
        #region Report Functions

        public void AddReport(Reports report)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var parameters = new
                {
                    RegistrationID = report.RegistrationID,
                    DepartmentID = report.DepartmentID,
                    EmployeeID = report.EmployeeID,
                    LaboratoryID = report.LaboratoryID,
                    Report = report.Report
                };

                connection.Execute("dbo.USP_CreateReport @RegistrationID, @DepartmentID, @EmployeeID, @LaboratoryID, @Report", parameters);
            }
        }

        public void EditReport(Reports report)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var parameters = new
                {
                    ReportID = report.ReportID,
                    RegistrationID = report.RegistrationID,
                    DepartmentID = report.DepartmentID,
                    EmployeeID = report.EmployeeID,
                    LaboratoryID = report.LaboratoryID,
                    Report = report.Report
                };

                connection.Execute("dbo.USP_UpdateReport @ReportID, @RegistrationID, @DepartmentID, @EmployeeID, @LaboratoryID, @Report", parameters);
            }
        }

        public void RemoveReport(Reports report)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var parameters = new
                {
                    ReportID = report.ReportID
                };

                connection.Execute("dbo.USP_DropReport @ReportID", parameters);
            }
        }

        #endregion

        #region Billing Functions

        /*
         * Billing Functions consist of public functions that executes user stored procedures from the database.
         * 
         * Region Contents:
         *      AddBilling(Billings billing)        
         *      - Adds a billing record to the database.
         *      UpdateBilling(Billings billing)
         *      - Updates billing record.
         *      RemoveBilling(Billings billing) 
         *      - Removes billing record from database.
         * 
         */

        public void AddBilling(Billings billing)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var parameters = new
                {
                    RegistrationID = billing.RegistrationID,
                    Status = billing.Status
                };

                connection.Execute("dbo.USP_CreateBilling @RegistrationID, @Status", parameters);
            }
        }

        public void UpdateBilling(Billings billing)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var parameters = new
                {
                    BillingID = billing.BillingID,
                    Status = billing.Status
                };

                connection.Execute("dbo.USP_UpdateBilling @BillingID, @Status", parameters);
            }
        }

        public void RemoveBillings(Billings billing)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbConnection.ConnectionValue("HospitalDB")))
            {
                var parameters = new
                {
                    BillingID = billing.BillingID
                };

                connection.Execute("dbo.USP_DropBilling @BillingID", parameters);
            }
        }

        #endregion
    }
}
