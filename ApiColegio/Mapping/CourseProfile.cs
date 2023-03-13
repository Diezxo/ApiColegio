using Application.Dtos.CourseDtos;
using AutoMapper;
using Domain.Entities.Models;

namespace ApiColegio.Mapping
{
    public class CourseProfile: Profile
    {
        public CourseProfile()
        {
            CreateMap<Course, CourseResponse>().ReverseMap();
                
        }
    }
}
