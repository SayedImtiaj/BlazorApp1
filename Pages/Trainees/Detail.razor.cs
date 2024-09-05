using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using BlazorApp1.Models;
using CrudInBlazorServerApp.Services;
using Microsoft.AspNetCore.Components;
namespace BlazorApp1.Pages.Trainees
{
    public partial class Detail
    {
        [Inject]
        protected ITraineeService TraineeService { get; set; }
        [Parameter]
        public int Id { get; set; }
        public Trainee Trainee { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Trainee = await TraineeService.GetTraineeById(Id);
        }
    }
}