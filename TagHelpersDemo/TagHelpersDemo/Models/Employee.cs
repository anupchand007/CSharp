namespace TagHelpersDemo.Models
{


    public enum Month   //enum is use to represent constant value
    {
        Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sept, Oct, Nov, Dec
    }


    public class Employee
    {
        public string Name { get; set; }
        public int EmpID { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }

        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public string Description { get; set; }
    }
   
}
