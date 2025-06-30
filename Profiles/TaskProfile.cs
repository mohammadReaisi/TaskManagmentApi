using AutoMapper;
using TaskManagementApi.Models;

namespace TaskManagementApi.Profiles;

public class TaskProfile : Profile
{
    public TaskProfile()
    {
        CreateMap<Task, TaskDto>();
        CreateMap<CreateTaskDto, Task>();
        CreateMap<UpdateTaskDto, Task>();
    }
}