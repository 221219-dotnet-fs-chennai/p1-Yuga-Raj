using System;
using System.Linq;
using Models;
using AutoMapper;
using System.Collections.Generic;
using System.Collections;

using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace BusinessLogic
{
    public class EducationLogic : ICrud<AEduModel, UEduModel>
    {

        public IList GetAll(int id)
        {
            DataEf.Entities.YugrajContext cnt = new DataEf.Entities.YugrajContext();
            var query = (from st in cnt.Edus
                         where st.UsId == id
                         select st).ToList();

            var tr = query.Select(x => new EduModel()
            {
                EduId = x.EduId,
                CourseName = x.CourseName,
                InstitutionName = x.InstitutionName,
                StartDate = x.StartDate,
                EndDate = x.EndDate,
                Cgpa = x.Cgpa,
            }).ToList();
            return tr;
        }

        public bool Add(int id, AEduModel aEduModel)
        {

            DataEf.Entities.Edu edu = new DataEf.Entities.Edu();

            edu.InstitutionName = aEduModel.InstitutionName;
            edu.CourseName = aEduModel.CourseName;
            edu.StartDate = aEduModel.StartDate;
            edu.EndDate = aEduModel.EndDate;
            edu.Cgpa = aEduModel.Cgpa;
            edu.UsId = id;

            DataEf.Entities.YugrajContext YugrajContext = new DataEf.Entities.YugrajContext();
            YugrajContext.Edus.Add(edu);
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
            DataEf.Entities.Edu edu = new DataEf.Entities.Edu() { EduId = id };
            DataEf.Entities.YugrajContext YugrajContext = new DataEf.Entities.YugrajContext();
            YugrajContext.Edus.Attach(edu);
            YugrajContext.Edus.Remove(edu);
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

        public bool Update(int id, UEduModel uEduModel)
        {
            DataEf.Entities.Edu edu = new DataEf.Entities.Edu();
            edu.EduId = uEduModel.EduId;
            edu.CourseName = uEduModel.CourseName;
            edu.InstitutionName = uEduModel.InstitutionName;
            edu.StartDate = uEduModel.StartDate;
            edu.EndDate = uEduModel.EndDate;
            edu.Cgpa = uEduModel.Cgpa;
            edu.UsId = id;
            DataEf.Entities.YugrajContext YugrajContext = new DataEf.Entities.YugrajContext();
            YugrajContext.Edus.Update(edu);
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

