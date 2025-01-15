namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _user=new();

        static Repository(){
            _user.Add(new UserInfo(){Id=1,Name="Çağrı Kandemir",Phone="5415223858",Mail="cagrikandemir58@hotmail.com",WillAttend=true}) ;
             _user.Add(new UserInfo(){Id=2,Name="Buse Gökmen",Phone="05305100678",Mail="cagrikandemir58@hotmail.com",WillAttend=true}) ;
            _user.Add(new UserInfo(){Id=3,Name="Yiğit Kandemir",Phone="5585885858",Mail="cagrikandemir58@hotmail.com",WillAttend=true}) ;

        }
        public static List<UserInfo> User{
            get{
                return _user;
            }
        }

        public static void CreateUser(UserInfo user){
            user.Id=User.Count+1;
            _user.Add(user);
        }

        public static UserInfo? GetById(int id){
            return _user.FirstOrDefault(user=>user.Id==id);
        }
    }
}