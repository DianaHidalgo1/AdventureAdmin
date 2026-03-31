using AdventureAdmin.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AdventureAdmin.Ui.Services;

public class AddressTypeService(
     Data.Context.AdventureWorksContext context
     ) : Aplicada1.Core.IService<AdventureAdmin.Data.Models.AddressType, int>
{
    public Task<AddressType?> Buscar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Eliminar(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<AddressType>> GetList(Expression<Func<AddressType, bool>> criterio)
    {
        return await context.AddressTypes
            .Where(criterio)
            .ToListAsync();
    }

    public Task<bool> Guardar(AddressType entidad)
    {
        throw new NotImplementedException();
    }
}
