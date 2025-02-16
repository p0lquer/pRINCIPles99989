


namespace DRY
{

    public class Paytoroll
    {
        public decimal CalcPay(decimal baseSalary)
        {
            decimal tax = 0.18m * baseSalary;
            decimal bonus = baseSalary * 0.5m;
            return baseSalary - tax + bonus;
        }

        public decimal CalcPayHour(decimal hoursWorked, decimal hourlyRate)
        {
            decimal salary = hoursWorked * hourlyRate;
            CalcPay(salary);
            return salary;
        }
    }
   
}
