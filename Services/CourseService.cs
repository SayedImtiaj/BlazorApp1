using BlazorApp1.Data;
using BlazorApp1.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Services
{
    public class CourseService : ICourseService
    {
        private readonly MyDbContext _context;
        public CourseService(MyDbContext context)
        {
            _context = context;
        }
        public async Task<Course> CreateCourse(Course course)
        {
            _context.Courses.Add(course);
            await _context.SaveChangesAsync();
            return course;
        }
        public async Task DeleteCourse(Course course)
        {
            _context.Courses.Remove(course);
            await _context.SaveChangesAsync();
        }
        public async Task<Course> GetCourseById(int id)
        {
            return await _context.Courses.FirstOrDefaultAsync(c => c.Id == id);
        }
        public async Task<List<Course>> GetCourseList()
        {
            return await _context.Courses.OrderBy(c => c.Id).ToListAsync();
        }
        public async Task UpdateCourse(Course course)
        {
            _context.Courses.Update(course);
            await _context.SaveChangesAsync();
        }
    }
}
