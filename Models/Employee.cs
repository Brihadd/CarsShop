﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Employee
    {
      
        public int Id { get; set; }
       
        public string Login { get; set; }
        
        public string EmployeePassword { get; set; }
        
        public string Name { get; set; }
        
        public string Surname { get; set; }
      
        public UserStatus UserStatus { get; set; }
        
        public string Email { get; set; }
        
        public DateTime BirthDate { get; set; }

        public bool Deleted { get; set; }
       
    }
    public enum UserStatus
    {
        Admin,
        CrmManager,
        Buyer,
        Seller,
        Pricer,
        SeniorPricer
    }
    
}
