using System;
using System.Linq.Expressions;
using Common.Model;
using Common.RequestModel;
using Model;

namespace RequestModel
{
    public class TeacherRequestModel : BaseRequestModel<Teacher>
    {
        public double mincredit { get; set; }
        public double maxcredit { get; set; }

        public TeacherRequestModel(string keyword, string orderBy = "Modified", string isAscending = "False") : base(
            keyword, orderBy, isAscending)
        {

        }

        protected override Expression<Func<Teacher, bool>> GetExpression()
        {
            Keyword = Keyword.ToLower();
            ExpressionObj = x => x.Name.Contains(Keyword) || x.Phone.Contains(Keyword) || x.Courses.Contains(Keyword);
            if (mincredit > 0) ExpressionObj = ExpressionObj.And(x => x.TotalCredit >= mincredit);
            if (maxcredit > 0) ExpressionObj = ExpressionObj.And(x => x.TotalCredit <= maxcredit);
            return ExpressionObj;
        }

        public override Expression<Func<Teacher, DropdownViewModel>> Dropdown()
        {
            return x => new DropdownViewModel() {Id = x.Id, Text = x.Name, Data = x};
        }
    }
}
