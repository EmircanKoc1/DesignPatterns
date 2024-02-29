using BuilderPattern.Method1;

namespace BuilderPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var eb = new EndpointBuilder("https://localhost");

            //eb
            //  .Append("api")
            //  .Append("v1")
            //  .Append("user")
            //  .AppendParam("id", "5");

            //var url = eb.Build();

            //Console.WriteLine("Final Url: " + url);


            var empBuilder = new EmployeeBuilderM1();

            empBuilder
                .SetFullName("Emircan Koç")
                .SetUserName("emircantr")
                .SetEmailAddress("emircantr@gmail.com");

            var employee = empBuilder.BuildEmployee();

            Console.WriteLine(employee.ToString());



        }
    }
}
