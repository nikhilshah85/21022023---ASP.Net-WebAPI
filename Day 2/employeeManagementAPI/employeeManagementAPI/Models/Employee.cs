namespace employeeManagementAPI.Models
{
    public class Employee
    {
        public int empId { get; set; }
        public string empName { get; set; }
        public string empDesignation { get; set; }
        public double empSalary { get; set; }
        public bool empIsPermenant { get; set; }

        static List<Employee> eList = new List<Employee>()
        {
            new Employee(){ empId=101, empName="Sumit", empDesignation="Sales", empIsPermenant=true, empSalary=12000 },
            new Employee(){ empId=102, empName="Rakesh", empDesignation="HR", empIsPermenant=true, empSalary=18000 },
            new Employee(){ empId=103, empName="Mahesh", empDesignation="Sales", empIsPermenant=false, empSalary=9000 },
            new Employee(){ empId=104, empName="Mohan", empDesignation="Sales", empIsPermenant=true, empSalary=24000 },
            new Employee(){ empId=105, empName="Rohan", empDesignation="Accounts", empIsPermenant=true, empSalary=34000 },
            new Employee(){ empId=106, empName="Akshit", empDesignation="HR", empIsPermenant=false, empSalary=16000 },
        };


        public List<Employee> GetAllEmployees()
        {
            return eList;
        }

        public Employee GetEmpById(int id)
        {
            var emp = eList.Find(e => e.empId == id);
            if (emp != null)
            {
                return emp;
            }
            throw new Exception("Employee not found");

        }

        public string AddNewEmployee(Employee newEmp)
        {
            eList.Add(newEmp);
            return "Employee Added Successfully";
        }


        public string DeleteEmployee(int id)
        {
            var emp = eList.Find(e => e.empId == id);
            if (emp != null)
            {
                eList.Remove(emp);
                return "Employee Deleted Successfully";
            }
            throw new Exception("Employee Not found in system");
        }

        public string EditEmployee(Employee changes)
        {
            var emp = eList.Find(e => e.empId == changes.empId);
            if (emp != null)
            {
                emp.empName = changes.empName;
                emp.empDesignation = changes.empDesignation;
                emp.empSalary = changes.empSalary;
                emp.empIsPermenant = changes.empIsPermenant;
                return "Employee Updated Successfully";
            }
            throw new Exception("Employee Not found");
        }
    }
}










































