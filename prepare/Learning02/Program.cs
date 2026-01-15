using System;
// I have been told in other classes to use more comments, so I am making an effort to do so.

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobRole = "Software Developer";
        job1._companyName = "Tech Solutions";
        job1._startYear = 2018;
        job1._endYear = 2021;

        Job job2 = new Job();
        job2._jobRole = "Senior Developer";
        job2._companyName = "Innovatech";
        job2._startYear = 2021;
        job2._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "John Doe";
        //adds jobs to resume
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        //displays resume
        myResume.Display();
    }
}