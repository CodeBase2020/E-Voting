using System.Collections.Generic;

namespace API.Entities
{
    public class Department
    {
        public int Id { get; set; }  
        public string Name {get;set;}
        public int Votes {get;set;}

        public ICollection<UserVote> UserVotes {get;set;}
       
    }
}