using BlazorApp1.Models;
using BlazorApp1.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Pages.Courses
{
    public partial class Edit
    {
        [Inject]
        protected ICourseService CourseService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Parameter]
        public int Id { get; set; }
        public Course Course { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Course = await CourseService.GetCourseById(Id);
        }
        private async void SubmitCourse()
        {
            await CourseService.UpdateCourse(Course);
            NavigationManager.NavigateTo("/courses");
        }
    }
}
