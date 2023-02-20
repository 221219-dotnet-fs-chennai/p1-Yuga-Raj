using System;
using Models;
using System.Collections;

namespace BusinessLogic
{
    public class SkillLogic : ICrud<ASkillModel, USkillModel>
    {
        public IList GetAll(int id)
        {
            DataEf.Entities.YugrajContext cnt = new DataEf.Entities.YugrajContext();
            var query = (from st in cnt.Skills
                         where st.UsId == id
                         select st).ToList();

            var tr = query.Select(x => new SkillModel()
            {
                SkillId = x.SkillId,
                SkillName = x.SkillName,
                SkillExperience = x.SkillExperience
            }).ToList();
            return tr;
        }

        public bool Add(int id, ASkillModel aSkillModel)
        {

            DataEf.Entities.Skill skill = new DataEf.Entities.Skill();



            skill.SkillName = aSkillModel.SkillName;
            skill.SkillExperience = aSkillModel.SkillExperience;
            skill.UsId = id;


            DataEf.Entities.YugrajContext YugrajContext = new DataEf.Entities.YugrajContext();
            YugrajContext.Skills.Add(skill);


            int res = YugrajContext.SaveChanges();

            if (res > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool Delete(int id)
        {
            DataEf.Entities.Skill skill = new DataEf.Entities.Skill() { SkillId = id };
            DataEf.Entities.YugrajContext YugrajContext = new DataEf.Entities.YugrajContext();
            YugrajContext.Skills.Attach(skill);
            YugrajContext.Skills.Remove(skill);
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


        public bool Update(int id, USkillModel uSkillModel)
        {
            DataEf.Entities.Skill skill = new DataEf.Entities.Skill();
            skill.SkillId = uSkillModel.SkillId;
            skill.SkillName = uSkillModel.SkillName;
            skill.SkillExperience = uSkillModel.SkillExperience;
            skill.UsId = id;
            DataEf.Entities.YugrajContext YugrajContext = new DataEf.Entities.YugrajContext();
            YugrajContext.Skills.Update(skill);
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

