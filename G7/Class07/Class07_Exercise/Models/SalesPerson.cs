namespace Models
{
    public class SalesPerson : Employee
    {
        private double SuccessSaleRevenue { get; set; }

        public SalesPerson(string firstName, string lastName) : base(firstName, lastName, RoleEnum.Sales, 500)
        {
            SuccessSaleRevenue = 0;
        }

        public void AddSuccessRevenue(double revenue)
        {
            SuccessSaleRevenue += revenue;
        }

        public override double GetSalary()
        {
            //double basicSalary = 500;
            //double basicSalary = Salary;

            double basicSalary = base.GetSalary();

            //if(SuccessSaleRevenue <= 2000)
            //{
            //    return basicSalary + 500;
            //} else if(SuccessSaleRevenue > 2000 && SuccessSaleRevenue <= 5000)
            //{
            //    return basicSalary + 1000;
            //} else
            //{
            //    return basicSalary + 1500;
            //}

            double salaryPlusBonus = 0;

            if (SuccessSaleRevenue <= 2000)
            {
                salaryPlusBonus = basicSalary + 500;
            }
            else if (SuccessSaleRevenue > 2000 && SuccessSaleRevenue <= 5000)
            {
                salaryPlusBonus = basicSalary + 1000;
            }
            else
            {
                salaryPlusBonus = basicSalary + 1500;
            }

            return salaryPlusBonus;
        }
    }
}
