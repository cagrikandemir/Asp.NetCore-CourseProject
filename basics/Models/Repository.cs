namespace basics.Models
{
    public class Repository
    {
        private static readonly List<Course> _courses=new();


        static Repository()
        {
            _courses=new List<Course>(){
                new Course(){
                id=1,
                Title="Java",
                Description="Spring Boot Bootcamp",
                Image="image1.jpg",
                Tags=new string[] {"Java","Web Geliştirme"},
                isActive=true,
                isHome=true
                },
                new Course(){id=2,
                Title="Php",
                Description="Laravel Bootcamp",
                Image="image2.jpg",
                Tags=new string[] {"Php","Web Geliştirme"},
                isActive=true,
                isHome=false
                },
                new Course(){id=3,
                Title=".Net",
                Description="Asp.Net Core Bootcamp",
                Image="image3.jpg",
                Tags=new string[] {"C#","Web Geliştirme"},
                isActive=true,
                isHome=true
                },
                new Course(){id=4,
                Title="Go",
                Description="Go Bootcamp",
                Image="image2.jpg",
                Tags=new string[] {"Go","Web Geliştirme"},
                isActive=true,
                isHome=true
                }
            };
        }

        public static List<Course> Courses{
            get{
                return _courses;
            }
        }

        public static Course? GetById(int? id){
            return _courses.FirstOrDefault(c=>c.id==id);
        }
    }
}