using System;
using System.Collections.Generic;

namespace ProjectPractice.Domain.Entities.Public;

public partial class Vehicle
{
    public int VehiId { get; set; }

    public string VehiPlate { get; set; } = null!;

    public int? UserId { get; set; }

    public int? BrandId { get; set; }

    public int? VsId { get; set; }

    public virtual Brand? Brand { get; set; }

    public virtual User? User { get; set; }

    public virtual VehicleStatus? Vs { get; set; }
}
