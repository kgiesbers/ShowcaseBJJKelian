﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure;

namespace ShowcaseBJJKelian
{
    public class Dojo
    {
        private string name;
        private List<Teacher> teachers = new List<Teacher>();
        private List<Student> students = new List<Student>();
        private List<Technique> techniques = new List<Technique>();
        private List<Training> trainings = new List<Training>();

        public Dojo(string name)
        {
            this.name = name;
        }

        public void addTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }
        public void addStudent(Student student)
        {
            students.Add(student);
        }
        public void addTechnique(Technique technique)
        {
            techniques.Add(technique);
        }
        public void addTraining(Training training)
        {
            trainings.Add(training);
        }
        public void RecommendTechnique()
        {

        }
    }
}