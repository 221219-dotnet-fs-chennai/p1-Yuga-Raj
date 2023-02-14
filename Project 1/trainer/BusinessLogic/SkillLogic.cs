using System;
using Models;
using System.Collections;

namespace BusinessLogic
{
    public class SkillLogic
    {
        public IList GetAll(int id)
        {
            DataEf.Entities.YugarajContext cnt = new DataEf.Entities.YugarajContext();
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


            DataEf.Entities.YugarajContext yugarajContext = new DataEf.Entities.YugarajContext();
            yugarajContext.Skills.Add(skill);


            int res = yugarajContext.SaveChanges();

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
            DataEf.Entities.YugarajContext yugarajContext = new DataEf.Entities.YugarajContext();
            yugarajContext.Skills.Attach(skill);
            yugarajContext.Skills.Remove(skill);
            int k = yugarajContext.SaveChanges();
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
            DataEf.Entities.YugarajContext yugarajContext = new DataEf.Entities.YugarajContext();
            yugarajContext.Skills.Update(skill);
            int j = yugarajContext.SaveChanges();
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

