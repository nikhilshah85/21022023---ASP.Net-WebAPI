namespace DI_DemowebAPI.Models
{
    public class Employee
    {
        public int eNo { get; set; }
        public string eName { get; set; }
        public string eDesigantion { get; set; }
        public double eSalary { get; set; }
        public bool eIsPermenant { get; set; }

        static List<Employee> eList = new List<Employee>()
        {
            new Employee(){ eNo=101, eName="Karan", eDesigantion="Sales", eIsPermenant=true, eSalary=8000},
            new Employee(){ eNo=102, eName="Mohan", eDesigantion="Sales", eIsPermenant=true, eSalary=8000},
            new Employee(){ eNo=103, eName="Rohan", eDesigantion="Sales", eIsPermenant=true, eSalary=8000},
            new Employee(){ eNo=104, eName="Rajesh", eDesigantion="Sales", eIsPermenant=true, eSalary=8000},
            new Employee(){ eNo=105, eName="Sumit", eDesigantion="Sales", eIsPermenant=true, eSalary=8000}
        };

        public List<Employee> GetAllEmployees()
        {
            return eList;
        }

        public Employee GetEmpById(int no)
        {
            var emp = eList.Find(e => e.eNo == no);
            if (emp!=null)
            {
                return emp;
            }
            throw new Exception("Employee Not found");
        }
    }
}
