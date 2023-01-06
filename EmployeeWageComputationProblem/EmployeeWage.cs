

namespace EmployeeWageComputationProblem
{
    public class EmployeWage
    {
        public static void EmpoyeStatus()
        {
            int IS_FULL_TIME = 1;
            Random random = new Random();
            int empCheck = random.Next();
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employe is present");
            }
            else
            {
                Console.WriteLine("Employe is absent");
            }

        }
    }
}
