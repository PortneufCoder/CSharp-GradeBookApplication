

using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook // this inherits the BaseGradeBook class
    {
        public RankedGradeBook(string name) : base(name) // create call to base constructor
        {
            Type = GradeBookType.Ranked;
        }
    }
}
