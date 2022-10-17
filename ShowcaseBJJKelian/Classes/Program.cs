namespace ShowcaseBJJKelian
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            Dojo dojo = new Dojo("dojo1");
            Teacher teacher1 = new Teacher("teacher1");
            Student student1 = new Student("student1", Beltlevel.White);
            Technique mount = new Technique("mount", Difficulty.Basic);
            dojo.addTeacher(teacher1);
            dojo.addStudent(student1);
            dojo.addTechnique(mount);

        }
    }
}