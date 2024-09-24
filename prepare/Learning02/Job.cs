using System;
using System.ComponentModel.DataAnnotations;

public class Job
    {
        // Responsibilities
        public string _company;
        public string _jobTitle;
        public string _startYear;
        public string _endYear;

        // Display method
        public void Display()
        {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        }
    }