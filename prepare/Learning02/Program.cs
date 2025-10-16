using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobtitle = "Electrical Engineer";
        job1._company = "Lockheed Martin";
        job1._startyear = 2028;
        job1._endyear = 2038;


        Job job2 = new Job();
        job2._jobtitle = "Unemployed";
        job2._company = "None";
        job2._startyear = 2025;
        job2._endyear = 2026;

        Resume myresume = new Resume();
        myresume._name = "Jack Watson";

        myresume._listofjobs.Add(job1);
        myresume._listofjobs.Add(job2);

        myresume.Display();
    }
}