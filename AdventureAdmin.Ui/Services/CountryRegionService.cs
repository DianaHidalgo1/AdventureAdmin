using AdventureAdmin.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AdventureAdmin.Ui.Services;

public class CountryRegionService(
     Data.Context.AdventureWorksContext context
     ) : Aplicada1.Core.IService<AdventureAdmin.Data.Models.CountryRegion, string>
{
    public Task<CountryRegion?> Buscar(string id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Eliminar(string id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<CountryRegion>> GetList(Expression<Func<CountryRegion, bool>> criterio)
    {
        return await context.CountryRegions
            .Where(criterio)
            .ToListAsync();
    }

    public Task<bool> Guardar(CountryRegion entidad)
    {
        throw new NotImplementedException();
    }
}
