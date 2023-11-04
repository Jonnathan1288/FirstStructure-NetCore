using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ProjectPractice.Domain.Entities.Public;

public partial class User
{
    public int UserId { get; set; }

    public string UserUsername { get; set; } = null!;

    public bool UserStatus { get; set; }

    [JsonIgnore]
    public virtual ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
}
