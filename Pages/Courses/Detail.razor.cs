using BlazorApp1.Models;
using BlazorApp1.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Pages.Courses
{
    public partial class Detail
    {
        [Inject]
        protected ICourseService CourseService { get; set; }
        public Course Course { get; set; }
        [Parameter]
        public int Id { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Course = await CourseService.GetCourseById(Id);
        }
    }
}
