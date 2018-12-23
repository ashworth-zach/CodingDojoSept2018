namespace viewmodelfun.Models
{
    public class User
    {
        public string[] users {get;set;}
        public string user1{get;set;}
        public User(string[] people){
            users= people;
            
        }
        public User(string person){
            user1= person;
            
        }
    }
}