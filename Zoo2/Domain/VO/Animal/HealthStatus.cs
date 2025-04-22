namespace Zoo2.Domain.VO.Animal;

/// <summary>
/// Prototype class (extremely likely to get expanded in future versions).
/// </summary>
public struct HealthStatus
{
    public bool IsHealthy { get; }

    public HealthStatus(bool isHealthy)
    {
        IsHealthy = isHealthy;
    }
}