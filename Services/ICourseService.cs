using BlazorApp1.Models;

namespace BlazorApp1.Services
{
    public interface ICourseService
    {
        Task<List<Course>> GetCourseList();
        Task<Course> GetCourseById(int id);
        Task<Course> CreateCourse(Course course);
        Task UpdateCourse(Course course);
        Task DeleteCourse(Course course);
    }
}
