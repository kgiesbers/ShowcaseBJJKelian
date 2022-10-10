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
            Teacher teacher = new Teacher("teacher1");
            Student student = new Student("student1", 25, Beltlevel.White);
        }
    }
}