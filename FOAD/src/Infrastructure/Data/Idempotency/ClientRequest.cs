﻿namespace FOAD.Infrastructure.Idempotency;

public class ClientRequest
{
    public Guid Id { get; set; }
    [Required]
    public required string Name { get; set; }
    public DateTime Time { get; set; }
}
