using System;
using Models;
using System.Collections;

namespace BusinessLogic
{
    public class CompLogic : ICrud<ACompModel, UCompModel>
    {

        public IList GetAll(int id)
        {
            DataEf.Entities.YugrajContext YugrajContext = new DataEf.Entities.YugrajContext();
            var query = (from st in YugrajContext.Comps
                         where st.UsId == id
                         select st).ToList();
            var tr = query.Select(x => new CompModel()
            {
                CompId = x.CompId,
                CompName = x.CompName,
                About = x.About,
                StartDate = x.StartDate,
                EndDate = x.EndDate,

            }).ToList();
            return tr;

        }

        public bool Add(int id, ACompModel aCompModel)
        {
            DataEf.Entities.Comp comp = new DataEf.Entities.Comp();
            comp.About = aCompModel.About;
            comp.CompName = aCompModel.CompName;
            comp.StartDate = aCompModel.StartDate;
            comp.EndDate = aCompModel.EndDate;
            comp.UsId = id;

            DataEf.Entities.YugrajContext YugrajContext = new DataEf.Entities.YugrajContext();
            YugrajContext.Comps.Add(comp);
            int res = YugrajContext.SaveChanges();
            if (res > 0)
            {
                return true;
            }
            else
            {
                return false;
            };
        }



        public bool Delete(int id)
        {
            DataEf.Entities.Comp comp = new DataEf.Entities.Comp() { CompId = id };
            DataEf.Entities.YugrajContext YugrajContext = new DataEf.Entities.YugrajContext();
            YugrajContext.Comps.Attach(comp);
            YugrajContext.Comps.Remove(comp);
            int k = YugrajContext.SaveChanges();
            if (k > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }




        public bool Update(int id, UCompModel uCompModel)
        {
            DataEf.Entities.Comp comp = new DataEf.Entities.Comp();
            comp.CompId = uCompModel.CompId;
            comp.About = uCompModel.About;
            comp.CompName = uCompModel.CompName;
            comp.StartDate = uCompModel.StartDate;
            comp.EndDate = uCompModel.EndDate;
            comp.UsId = id;
            DataEf.Entities.YugrajContext YugrajContext = new DataEf.Entities.YugrajContext();
            YugrajContext.Comps.Update(comp);
            int j = YugrajContext.SaveChanges();
            if (j > 0)
            {
                return true;

            }
            else
            {
                return false;
            }
        }



    }
}

