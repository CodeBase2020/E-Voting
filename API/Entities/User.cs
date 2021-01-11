using System;

namespace API.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name {get;set;}
        public string UserId {get;set;}
        public string EmailId{get;set;}
        public string Mobile {get;set;}
        public string State {get;set;}
        public string City {get;set;}
        public byte[] PasswordHash {get;set;}
        public byte[] PasswordSalt {get;set;}
        public DateTime DateOfBirth {get;set;}
        public String Address {get;set;}
        public  UserVote UserVote {get;set;}
    }
}