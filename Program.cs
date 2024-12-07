namespace TASK3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new AddDBcontext();

            context.Students.Add(new Student { FirstName = "waleed", LastName = "tantawy", Email = "waleedtantwy" });
            context.Students.Add(new Student { FirstName = "ahmed", LastName = "elrweny", Email = "ahmedrewint" });
            context.Students.Add(new Student { FirstName = "lionel", LastName = "messi", Email = "lm10" });
            context.Students.Add(new Student { FirstName = "cristiano", LastName = "ronaldo", Email = "cr7" });

            context.SaveChanges();
        }
    }
}
