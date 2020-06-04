using Microsoft.EntityFrameworkCore;
using QLSV.Data;
using QLSV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Threading.Tasks;

namespace QLSV.Service
{
    public class SchoolService : ISchoolService
    {
        private readonly QLSVDbContext _qLSVDbContext;

        public SchoolService(QLSVDbContext qLSVDbContext)
        {
            _qLSVDbContext = qLSVDbContext;
        }

        public  School AddSchool(School school)
        {
            var Result =  _qLSVDbContext.Add(school);
            _qLSVDbContext.SaveChanges();
            return Result.Entity;
        }

        public void DeleteSchool(int ID)
        {
            var Result = _qLSVDbContext.Schools.Where(x => x.ID == ID).FirstOrDefault();
            if (Result != null)
            {
                _qLSVDbContext.Remove(Result);
                _qLSVDbContext.SaveChanges();
            }
        }

        public  IEnumerable<School> GetShools()
        {
            var Data = _qLSVDbContext.Schools.ToList();
            return Data;
        }

        public School GetSchool(int ID)
        {
            var Data = _qLSVDbContext.Schools.Where(x => x.ID == ID).FirstOrDefault();
            if (Data != null)
            {
                return Data;
            }
            return null;
        }

        public void EditSchool(School school)
        {
            var Data = _qLSVDbContext.Schools.Find(school.ID);
            if(Data !=null)
            {
                _qLSVDbContext.Entry(school).State = EntityState.Modified;
                _qLSVDbContext.SaveChanges();
            }
        }
    }
}