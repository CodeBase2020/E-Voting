using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    public class UserVote
    {
        [ForeignKey("User")]
        public int Id { get; set; }
        public bool IsVoted {get;set;}
        public int UserId {get;set;}
        public  User User {get;set;}
        
        public int  DepartmentId {get;set;}
        public Department department {get;set;}
    }
}