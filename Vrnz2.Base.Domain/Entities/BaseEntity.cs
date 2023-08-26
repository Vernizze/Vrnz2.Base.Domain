namespace Vrnz2.Base.Domain.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public bool Deleted { get; set; } = false;
        public bool Active { get; set; } = true;
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? LastUpdate { get; set; }
        public DateTimeOffset? DeletedAt { get; set; }
    }
}
