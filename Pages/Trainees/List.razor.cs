using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using BlazorApp1.Models;
using CrudInBlazorServerApp.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
namespace BlazorApp1.Pages.Trainees
{
    public partial class List
    {
        [Inject]
        protected ITraineeService TraineeService { get; set; }
        private List<Trainee> Trainees { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Trainees = await TraineeService.GetTraineesList();
        }
        public async Task DeleteTrainee(int traineeId)
        {
            var trainee = await TraineeService.GetTraineeById(traineeId);
            if (trainee != null)
            {
                await TraineeService.DeleteTrainee(trainee);
                Trainees.RemoveAll(x => x.Id == traineeId);
            }
        }
    }
}