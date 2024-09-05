using BlazorApp1.Data;
using BlazorApp1.Models;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
namespace CrudInBlazorServerApp.Services
{
    public class TraineeService : ITraineeService
    {
        private readonly MyDbContext _context;
        public TraineeService(MyDbContext context)
        {
            _context = context;
        }
        public async Task<List<Trainee>> GetTraineesList()
        {
            return await _context.Trainees
            .Include(x => x.Course)
            .ToListAsync();
        }
        public async Task<Trainee> GetTraineeById(int id)
        {
            return await _context.Trainees
            .Include(x => x.Course)
            .FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<Trainee> CreateTrainee(Trainee trainee)
        {
            _context.Trainees.Add(trainee);
            await _context.SaveChangesAsync();
            return trainee;
        }
        public async Task UpdateTrainee(Trainee trainee)
        {
            _context.Trainees.Update(trainee);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteTrainee(Trainee trainee)
        {
            _context.Trainees.Remove(trainee);
            await _context.SaveChangesAsync();
        }
    }
}