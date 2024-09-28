using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Samsung";
        job1._jobTitle = "Tech Support";
        job1._startYear = "2018";
        job1._endYear = "2022";

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Sales Manager";
        job2._startYear = "2022";
        job2._endYear = "2024";

        Job job3 = new Job();
        job3._company = "Apple";
        job3._jobTitle = "VP Of Sales";
        job3._startYear = "2024";
        job3._endYear = "Present";

        Resume myResume = new Resume();
        myResume._name = "Cameron Burton";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);

        myResume.Display();
    }
}