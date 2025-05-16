//using DM106ProjectMgmt.Shared.Models;
//using Microsoft.Data.SqlClient;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DM106ProjectMgmt.Shared.Data.DB
//{
 
//    public class JobTaskDAL
//    {
//        private readonly DM106ProjectMgmtContext context;
//        public JobTaskDAL(DM106ProjectMgmtContext context)
//        {
//            this.context = context;
//        }
//        public void Create(JobTask task)
//        {            
//            context.JobTask.Add(task);
//            context.SaveChanges();
//        }
//        public void Update(JobTask task)
//        {
//            context.JobTask.Update(task);
//            context.SaveChanges();
//        }
//        public void Delete(JobTask task)
//        {
//            context.JobTask.Remove(task);
//            context.SaveChanges();
//        }
//        public IEnumerable<JobTask> Read()
//        {
//            return context.JobTask.ToList();
//        }
//        public JobTask? ReadByName(string title)
//        {
//            return context.JobTask.FirstOrDefault(x => x.Title == title);
//        }

//    }
//}

