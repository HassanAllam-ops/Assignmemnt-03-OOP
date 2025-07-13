using System.Globalization;
namespace Assignmemnt_03_OOP
{
    #region Part 01 (Q 01)
   //ublic enum SecurityLevel
   //
   //   Guest,
   //   Developer,
   //   Secretary,
   //   DBA
   //
   //
   //ublic class Employee
   //
   //   public int ID { get; set; }
   //   public string Name { get; set; }
   //   private char gender;
   //   public char Gender
   //   {
   //       get => gender;
   //       set
   //       {
   //           if (value == 'M' || value == 'F')
   //           {
   //               gender = value;
   //           }
   //           else
   //           {
   //               throw new ArgumentException("Gender Must Be 'M' or 'F' ");
   //           }
   //       }
   //   }
   //   public SecurityLevel Security { get; set; }
   //   public decimal Salary { get; set; }
   //   public DateTime HireDate { get; set; }
   //
   //   public Employee(int id, string name, char gendr, SecurityLevel security, decimal salary, DateTime hireDate)
   //   {
   //       ID = id;
   //       Name = name;
   //       Gender = gender;
   //       Security = security;
   //       Salary = salary;
   //       HireDate = hireDate;
   //   }
   //
   //   public override string ToString()
   //   {
   //       return $"ID: {ID}\nName: {Name}\nGender: {(Gender == 'M' ? "Male" : "Female")}\n" +
   //          $"Security Level: {Security}\nSalary: {String.Format(CultureInfo.CurrentCulture, "{0:C}", Salary)}\n" +
   //          $"Hire Date: {HireDate.ToShortDateString()}";
   //
   //   }
   //
    #endregion

    

    internal class Program
        {
            static void Main(string[] args)
            {

            }
        }
    
}
