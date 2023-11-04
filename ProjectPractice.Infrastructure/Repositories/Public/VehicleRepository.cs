using EFCommonCRUD.Interfaces;
using EFCommonCRUD.Models;
using Microsoft.EntityFrameworkCore;
using ProjectPractice.Domain.Entities.Public;
using ProjectPractice.Domain.Interfaces.Repositories.Public;
using ProjectPractice.Domain.Reducers;
using ProjectPractice.Infrastructure.Repositories.Generic;

namespace ProjectPractice.Infrastructure.Repositories.Public
{
    public class VehicleRepository: NPRepository<Vehicle, int>, IVehicleRepository
    {
        private readonly FirstContext _context;
        public VehicleRepository(FirstContext context): base (context) { 
            _context = context;
        }

        public async Task<IEnumerable<VehicleInformation>> FindAllByFilter()
        {
            var result = await _context.Vehicles
                .AsNoTracking()
                .Select(v => new VehicleInformation
                {
                    VehiPlate = v.VehiPlate,
                    UserUsername = v.User!.UserUsername,
                    BrandName = v.Brand!.BrandName!,
                    VsName = v.Vs!.VsName

                }).ToListAsync();
            return result;
        }

        public async Task<IPage<Vehicle>> FindAllPageableAsync(IPageable pageable)
        {
            IQueryable<Vehicle> query = _context.Vehicles.AsNoTracking();
            List<Vehicle> data = await query
                .OrderBy(t => t.UserId)
                .Skip(Convert.ToInt32(pageable.GetOffset()))
                .Take(pageable.GetPageSize()).ToListAsync();
            return new Page<Vehicle>(data, pageable, await query.CountAsync());
        }

        public async Task<IEnumerable<Vehicle>> FindByBrand(string brand_name)
        {
            var result = await _context.Vehicles.AsNoTracking()
                .Include(t => t.User)
                .Where(t => t.Brand!.BrandName!.Equals(brand_name))
                .OrderBy(t => t.VehiId)
                .ToListAsync();
            return result;
        }
    }
}
