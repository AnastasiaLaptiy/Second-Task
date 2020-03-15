using System.Linq;
using System.Collections.Generic;
using System;
using SecondTask.TeaSorting.Models;

namespace SecondTask.TeaSorting.Managers
{
    public class TeaManager
    {
        public TeaModel CreateTea(int id, string name, string country, TeaGradesModel grades)
        {
            TeaModel teaModel = new TeaModel
            {
                Id = id,
                Name = name,
                Country = country,
                Grades = grades
            };
            return teaModel;
        }

        public List<TeaModel> GetListTea()
        {
            List<TeaModel> listTeaModel = new List<TeaModel>();

            listTeaModel.Add(new TeaModel { Id = 1, Name = "black tea", Country = "chinese", Grades = TeaGradesModel.Mix });
            listTeaModel.Add(new TeaModel { Id = 2, Name = "black tea", Country = "japanese", Grades = TeaGradesModel.White });
            listTeaModel.Add(new TeaModel { Id = 3, Name = "green tea", Country = "swedish", Grades = TeaGradesModel.Red });
            listTeaModel.Add(new TeaModel { Id = 4, Name = "green tea", Country = "chinese", Grades = TeaGradesModel.Red });

            return listTeaModel;
        }

        public void GroupingTeaItem(List<TeaModel> listTeaModel)
        {
            var result = listTeaModel.GroupBy(tea => tea.Grades)
                .Select(teaItem => new { Name = teaItem.Key, Count = teaItem.Count() });

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name}, {item.Count}");
            }
        }
    }
}
