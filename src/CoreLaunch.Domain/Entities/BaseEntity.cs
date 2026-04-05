namespace CoreLaunch.Domain.Entities;

public abstract class BaseEntity
{
    public Guid Id { get; protected set; } = Guid.NewGuid();
    public DateTime CreatedDate { get; protected set; } = DateTime.UtcNow;
    public DateTime? UpdatedDate { get; protected set; }

    // Güncelleme tarihini yönetmek için yardımcı metod
    protected void UpdateDate()
    {
        UpdatedDate = DateTime.UtcNow;
    }
}
