using Common.Repository;
using Common.Service;
using Model;
using RequestModel;
using ViewModel;

namespace Service
{
    public class TeacherService : BaseService<Teacher, TeacherRequestModel, TeacherViewModel>
    {
        public TeacherService(BaseRepository<Teacher> repository) : base(repository)
        {
        }
    }
}
