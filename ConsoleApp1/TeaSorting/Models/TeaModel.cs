using SecondTask.TeaSorting.Models;

namespace SecondTask.TeaSorting.Models
{
    public class TeaModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Country { get; set; }

        public TeaGradesModel Grades { get; set; }

    }
}
