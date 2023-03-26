using System;
using System.Diagnostics;


public class JobCollection : IJobCollection {
	private IJob[] jobs;
	private uint count;

	public JobCollection( uint capacity ) {
		if( !( capacity >= 1 ) ) throw new ArgumentException();
		jobs = new IJob[capacity];
        count = 0;
	}

	public uint Capacity {
		get { return (uint) jobs.Length; }
	}

	public uint Count {
		get { return count; }
	}

	public bool Add( IJob job ) {
        //To be implemented by students
        if(Count < Capacity)
        {
            for (int i = 0; i < Capacity; i++)
            {
                if (jobs[i].Id == job.Id)
                {                 
                    return true;
                }
                else
                {
                    return false;
                }

            }

            //   Count = Count + 1;
            // Capacity = Capacity;
        }
        throw new System.NotImplementedException();
    }

    public bool Contains(uint id) {
        //To be implemented by students
        throw new System.NotImplementedException();

    }

    public IJob? Find( uint id ) {
        //To be implemented by students
        throw new System.NotImplementedException();

    }

    public bool Remove(uint id) {
        //To be implemented by students
        throw new System.NotImplementedException();
    }

    public IJob[] ToArray() {
        //To be implemented by students
        throw new System.NotImplementedException();
    }
}
