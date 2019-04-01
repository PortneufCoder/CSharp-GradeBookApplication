

using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook( string name)
        {
            Type = GradeBookType.Ranked;
        }
    }
}
