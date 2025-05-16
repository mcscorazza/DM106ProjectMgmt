//using DM106ProjectMgmt.Shared.Models;
//using Microsoft.Data.SqlClient;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DM106ProjectMgmt.Shared.Data.DB
//{
 
//    public class MachineDesignDAL
//    {
//        private readonly DM106ProjectMgmtContext context;
//        public MachineDesignDAL(DM106ProjectMgmtContext context)
//        {
//            this.context = context;
//        }
//        public void Create(MachineDesign design)
//        {
//            context.MachineDesign.Add(design);
//            context.SaveChanges();
//        }
//        public void Update(MachineDesign design)
//        {
//            context.MachineDesign.Update(design);
//            context.SaveChanges();
//        }
//        public void Delete(MachineDesign design)
//        {
//            context.MachineDesign.Remove(design);
//            context.SaveChanges();
//        }
//        public IEnumerable<MachineDesign> Read()
//        {
//            return context.MachineDesign.ToList();
//        }
//        public MachineDesign? ReadByName(string name)
//        {
//            return context.MachineDesign.FirstOrDefault(x => x.Name == name);
//        }

//    }
//}

