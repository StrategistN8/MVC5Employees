using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC5Employees.Models
{
    public class Employee
    {

        #region PROPERTIES
        public int Id { get; set; }
        public int Salary { get; set; }
        public string Name { get; set; }
        #endregion

        #region CONSTRUCTORS
        
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Employee()
        {

        }

        #endregion
    }
}