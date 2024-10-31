using FluentValidation;
using System.Data;

namespace PostItNoteBack.Models
{
    public class PostIt
    {
        public int Id { get; set; }
        public string Message {  get; set; }
        public DateTime CreateTime { get; set; }
        public bool IsDeleted { get; set; }
    }


    public class PostItValidator : AbstractValidator<PostIt>
    {
        public PostItValidator()
        {
            RuleFor(x=>x.Message).NotEmpty();
        }
    }
}
