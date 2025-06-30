using AutoMapper;
using TaskManagementApi.Models;

namespace TaskManagementApi.Profiles;

public class TaskProfile : Profile
{
    public TaskProfile()
    {
        CreateMap<Models.Task, TaskDto>();
        CreateMap<CreateTaskDto, Models.Task>();
        CreateMap<UpdateTaskDto, Models.Task>();
    }
}