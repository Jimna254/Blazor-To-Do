namespace Blazor_To_Do.Model
{
    public class ToDoDTO
    {
        public Guid Id { get; set; }  

        public string Title { get; set; }

        public string Description { get; set; }

        public string Priority { get; set; }

        public DateTime DateCreated { get; set; }  = DateTime.Now;


    }
}
