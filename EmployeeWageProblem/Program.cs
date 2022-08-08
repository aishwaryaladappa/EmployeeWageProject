namespace EmployeeWageProblem
{
    class program
    {
        public static void Main(string[] args)
        {

            EmployeePresentOrAbsent.Attendance();
            EmployeeWage.Wage();


            Parttime.EmpParttime();
            Switchcase.EmpWageSwitch();
            ForTwentyDays.EmpWageSwitch();
            TotalWorkingHourPerMonth.TotalWorkingHrs();
        }
    }
}