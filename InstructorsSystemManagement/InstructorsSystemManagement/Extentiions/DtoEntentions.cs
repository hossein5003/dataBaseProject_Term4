﻿using Models;
using static InstructorsSystemManagement.Dtos;

namespace InstructorsSystemManagement.Extentiions
{
    public static class DtoEntentions
    {
        public static Instructor AsInstructor(this CreatedInstructorDto instructorDto)
            => new()
            {
                Id = Guid.NewGuid(),
                Name = instructorDto.Name,
                Age=instructorDto.Age,
                DeptName = instructorDto.DeptName,
            };

        public static Instructor AsInstructor(this UpdatedInstructorDto instructorDto, Guid id)
            => new()
            {
                Id = id,
                Name = instructorDto.Name,
                Age=instructorDto.Age,
                DeptName = instructorDto.DeptName,
            };

        public static Course AsCourse(this CreatedCourseDto courseDto)
          => new()
          {
              Id = Guid.NewGuid(),
              Title = courseDto.Title,
              Credits = courseDto.Credits,
              DeptName = courseDto.DeptName,
          };

        public static Course AsCourse(this UpdatedCourseDto courseDto, Guid id)
            => new()
            {
                Id = id,
                Title = courseDto.Title,
                Credits = courseDto.Credits,
                DeptName = courseDto.DeptName,
            };

        public static Department AsDepartment(this CreatedDepartmentDto departmentDto)
         => new()
         {
             Id= Guid.NewGuid(),
             Name = departmentDto.Name,
             Building = departmentDto.building,
         };

        public static Department AsDepartment(this UpdatedDepartmentDto departmentDto , Guid id)
            => new ()
            {
                Id= id,
                Name = departmentDto.Name,
                Building = departmentDto.building,
            };

        public static User AsUser(this UserDto userDto)
            => new()
            {
                Id = Guid.NewGuid(),
                Name = userDto.Name,
                Password = BCrypt.Net.BCrypt.HashPassword(userDto.password),
                Email= userDto.email,
            };
    }
}
