using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyTestApp.Models
{   
    public class Todo
    {
        public int Id { get; set; }
        
        [DisplayName("Titulo")]
        [Required(ErrorMessage="Campo obrigatório")]
        public string Title { get; set; }
        
        [DisplayName("Concluído")]
        public bool Done { get; set; }
        public DateTime CreatedAt {get ; set;} = DateTime.Now;
        public DateTime LastUpadateDate { get; set; } = DateTime.Now;
        public string User {get; set;}

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
