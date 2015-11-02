using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShawInterviewExercise.API.Models
{
    public class Show
    {
        public Show() { }
        public Show(int id, string Name, string descp){
            this.Id = id;
            this.Name = Name;
            this.Description = descp;
        }
        
        
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}