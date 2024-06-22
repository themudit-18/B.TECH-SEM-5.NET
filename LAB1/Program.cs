using LAB1;

public class program
{
    public static void Main(string[] args)
    {
        //Cadidate c1 = new Cadidate();
        //c1.GetCandidateDetails();
        //c1.DisplayCandidateDetails();

        //Staff s1 = new Staff();
        //s1.getStaffDetails();
        //s1.DisplayStaffDetails();

        //Bank_Account account = new Bank_Account();
        //account.GetAccountDetails();
        //account.DisplayAccountDetails();

        //Student s1 = new Student(607,"Mudit",5,9.87,10);
        //s1.Display();

        //Rectangle r1 = new Rectangle(7.5,5.3);
        //r1.AreaOfRect();

        //Account_Details d1 = new Account_Details();

        //Interest i1 = new Interest();
        //i1.GetData();
        //i1.Display();

        //Salary sl1 = new Salary(2000,100000);
        //sl1.CalculateTotalSalary();


        //Distance d1 = new Distance(257.33, 100.00);
        //d1.totalDistance();

        //Furniture f1=new Furniture("xyz", 44.45);
        //Table t1 = new Table(6.16,"asdf","xyz",44.45);
        //t1.display();

        Salary_I si1 = new Salary_I("add","asdf","ad");

        Employee e1 = new Employee("asd", "asfgwaf", "awr", "wr");
        e1.Basic_sal();
        e1.Gross_sal();
        e1.DisplayEmployeeDetails();
    }
}