using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWages
{
    public interface IComputeEmpwage
    {
        public void CalculateEmpWages(String CompanyName, int EmpRatePerHour, int MaxNumberOfWrkinDays, int MaxHrPerMonth);

    }
    class ComputeEmpWage
    {
        private String CompanyName;
        private int EmpRatePerHour;
        private int MaxNumberOfWrkinDays;
        private int MaxHrPerMonth;
        private int totalEmpWage;

        public ComputeEmpWage(String CompanyName, int EmpRatePerHour, int MaxNumberOfWrkinDays, int MaxHrPerMonth)
        {
            this.CompanyName = CompanyName;
            this.EmpRatePerHour = EmpRatePerHour;
            this.MaxNumberOfWrkinDays = MaxNumberOfWrkinDays;
            this.MaxHrPerMonth = MaxHrPerMonth;
        }
        public String GetCompany()
        {
            return this.CompanyName;
        }
        public int GetTotalEmpWage()
        {
            return this.totalEmpWage;
        }

    }
}
