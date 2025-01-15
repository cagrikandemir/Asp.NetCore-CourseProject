namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _user=new();

        static Repository(){
            _user.Add(new UserInfo(){Name="Çağrı Kandemir",Phone="5415223858",Mail="cagrikandemir58@hotmail.com",WillAttend=true}) ;
             _user.Add(new UserInfo(){Name="Buse Gökmen",Phone="05305100678",Mail="cagrikandemir58@hotmail.com",WillAttend=true}) ;
            _user.Add(new UserInfo(){Name="Yiğit Kandemir",Phone="5585885858",Mail="cagrikandemir58@hotmail.com",WillAttend=true}) ;

        }
        public static List<UserInfo> User{
            get{
                return _user;
            }
        }

        public static void CreateUser(UserInfo user){
            _user.Add(user);
        }
    }
}