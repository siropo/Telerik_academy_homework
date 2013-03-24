using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.People
{
    public class Worker : Human
    {
        private decimal workSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName, decimal workSalary, double workHoursPerDay) :
            base(firstName, lastName)
        {
            this.WorkSalary = workSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WorkSalary
        {
            get
            {
                return this.workSalary;
            }
            private set
            {
                this.workSalary = value;
            }
        }

        public double WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            private set
            {
                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            return this.WorkSalary / ((decimal)this.WorkHoursPerDay * 5);
        }

        public override string ToString()
        {
            StringBuilder workerInfo = new StringBuilder();
            workerInfo.AppendFormat("{0}", base.ToString());
            workerInfo.AppendFormat("\nWORKER");
            workerInfo.AppendFormat("\nWork salary: {0}", this.WorkSalary);
            workerInfo.AppendFormat("\nHour per day: {0}", this.WorkHoursPerDay);
            workerInfo.AppendFormat("\nMoney per day: {0}", this.MoneyPerHour());
            workerInfo.AppendFormat("\n\n");
            return workerInfo.ToString();
        }

    }
}
