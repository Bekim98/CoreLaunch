 using System;
using System.Collections.Generic;
using System.Linq;

namespace CoreLaunch.Domain.ValueObjects;

public abstract class ValueObject : IEquatable<ValueObject>
{
    // Nesnenin eşitliğini kontrol etmek için gerekli olan parçalar
    protected abstract IEnumerable<object> GetEqualityComponents();

    // Eşitlik operatörleri (== ve !=)
    public static bool operator ==(ValueObject? left, ValueObject? right)
        => Equals(left, right);

    public static bool operator !=(ValueObject? left, ValueObject? right)
        => !Equals(left, right);

    // Standar Equals metodunun override edilmesi
    public override bool Equals(object? obj)
        => obj is ValueObject other && Equals(other);

    // IEquatable arayüzü gereği asıl mantık burada
    public bool Equals(ValueObject? other)
    {
        if (other is null) return false;

        return GetEqualityComponents()
            .SequenceEqual(other.GetEqualityComponents());
    }

    // Hash kodu üretimi (Dictionary ve HashSet kullanımı için kritik)
    public override int GetHashCode()
    {
        return GetEqualityComponents()
            .Select(x => x?.GetHashCode() ?? 0)
            .Aggregate(1, (acc, h) => acc ^ h);
    }
}
