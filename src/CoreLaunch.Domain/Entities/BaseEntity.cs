using System.ComponentModel.DataAnnotations;

namespace CoreLaunch.Domain.Entities;

public abstract class BaseEntity
{
    public int Id { get; set; }
}