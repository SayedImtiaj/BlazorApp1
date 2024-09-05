using BlazorApp1.Models;
using System.Numerics;
namespace CrudInBlazorServerApp.Services
{
    public interface ITraineeService
    {
        Task<List<Trainee>> GetTraineesList();
        Task<Trainee> GetTraineeById(int id);
        Task<Trainee> CreateTrainee(Trainee trainee);
        Task UpdateTrainee(Trainee trainee);
        Task DeleteTrainee(Trainee trainee);
    }
}