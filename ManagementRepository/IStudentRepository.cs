﻿using BusinessObject;
using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementRepository
{
    public interface IStudentRepository
    {
        List<Student> GetAll(string search = "");
        List<StudentScoreViewModel> GetStudentScores();
        bool AddStudent(Student student);
        bool DeleteStudent(string id);
        bool UpdateStudent(Student student);
    }
}
