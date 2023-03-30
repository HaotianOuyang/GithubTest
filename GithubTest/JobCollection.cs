using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

public class JobCollection : IJobCollection
{
    private IJob[] jobs;
    private uint count;

    public JobCollection(uint capacity)
    {
        if (!(capacity >= 1)) throw new ArgumentException();
        jobs = new IJob[capacity];
        count = 0;
    }

    public uint Capacity
    {
        get { return (uint)jobs.Length; }
    }

    public uint Count
    {
        get { return count; }
    }

    public bool Add(IJob job)
    {
        //To be implemented by students
        bool added = false;
        foreach(IJob job2 in jobs)
        {
            if(job2.Id == job.Id)
            {
                added = true;
            }
            else
            {
                added = false;
            }
        }

        if (this.Capacity > this.Count || job == null || added)
        {
            return false;
        }
        else
        {
            jobs[count++] = job;
            return true;
        }
    }

    public bool Contains(uint id)
    {
        //To be implemented by students
        for (int i = 0; i < Capacity; i++)
        {
            if (jobs[i].Id == id)
            {
                return true;
            }
        }
        return false;
    }

    public IJob? Find(uint id)
    {
        //To be implemented by students

        for (int i = 0; i < Capacity; i++)
        {
            if (jobs[i].Id == id)
            {
                return jobs[i];
            }
        }
        return null;

    }

    public bool Remove(uint id)
    {
        //To be implemented by students
        IJob job1 = null;
        foreach(IJob job in jobs)
        {
            if(job.Id == id)
            {
                job1 = job;
            }
        }
        if(job1 == null)
        {
            return false;
        }
        int index = Array.IndexOf(jobs, job1);
        for(int i = index; i < count -1; i++)
        {
            jobs[i] = jobs[i + 1];
        }
        jobs[count - 1] = null;
        count--;

        return true;
    }

    public IJob[] ToArray()
    {
        //To be implemented by students
        IJob[] newJobs;
        newJobs = jobs.ToArray();
        return newJobs;
    }
}
