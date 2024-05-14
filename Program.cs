using System;
using Balta.ContentContext;
using Balta.SharedContext;
using Balta.SubscriptionContext;


namespace Balta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP","orientacao-objetos"));
            articles.Add(new Article("Artigo sobre C#","scharp"));
            articles.Add(new Article("Artigo sobre .NET","dot-net"));

            // foreach (var article in articles)
            // {
            //     Console.WriteLine(article.Id);
            //     Console.WriteLine(article.Title);
            //     Console.WriteLine(article.Url);

            // }
            
            var courses = new List<Course>();
            var courseOOP = new Course("Fundamentos OPP","fundamentos-oop");
            var courseCsharp = new Course("Fundamentos C#","fundamentos-csharp");
            var courseAspNet = new Course("Fundamentos ASP.NET","fundamentos-dot-net");

            courses.Add(courseOOP);
            courses.Add(courseCsharp);
            courses.Add(courseAspNet);

            
            
            var careers = new List<Career>();
            var careerDotnet = new Career("Especialista .NET","especialista-dot-net");
            //Fora de ordem propositalmente para testar OrderBy
            var careerItem2 = new CareerItem(2,"Aprenda OOP","",null);
            var careerItem = new CareerItem(1,"Comece por aqui","",courseCsharp);
            var careerItem3 = new CareerItem(3,"Aprenda .NET","",courseAspNet);

            careerDotnet.Items.Add(careerItem2);
            careerDotnet.Items.Add(careerItem);
            careerDotnet.Items.Add(careerItem3);


            careers.Add(careerDotnet);

            foreach(var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach(var item in career.Items.OrderBy(x=>x.Ordem))
                {
                    Console.WriteLine($"{item.Ordem} - {item.Title}");
                    Console.WriteLine(item.Course?.Title);
                    Console.WriteLine(item.Course?.Level);

                    foreach(var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }

                }

                var payPalSubscription = new PayPalSubscription();
                var student = new Student();
                student.Subscriptions.Add(payPalSubscription);
            }



            
        }
    }
}