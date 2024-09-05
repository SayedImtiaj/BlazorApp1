using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using BlazorApp1.Models;
using BlazorApp1.Services;
using CrudInBlazorServerApp.Services;
using Microsoft.AspNetCore.Components;
namespace BlazorApp1.Pages.Trainees
{
    public partial class Edit
    {
        [Inject]
        protected ITraineeService TraineeService { get; set; }
        [Inject]
        protected ICourseService CourseService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Parameter]
        public int Id { get; set; }
        public Trainee Trainee { get; set; }
        private List<Course> Courses { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Trainee = await TraineeService.GetTraineeById(Id);
            Courses = await CourseService.GetCourseList();
        }
        private async void SubmitTrainee()
        {
            await TraineeService.UpdateTrainee(Trainee);
            NavigationManager.NavigateTo("/trainees");
        }
    }
}