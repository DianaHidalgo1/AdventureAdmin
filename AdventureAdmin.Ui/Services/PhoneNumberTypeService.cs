using AdventureAdmin.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AdventureAdmin.Ui.Services;

public class PhoneNumberTypeService(
     Data.Context.AdventureWorksContext context
     ) : Aplicada1.Core.IService<AdventureAdmin.Data.Models.PhoneNumberType, int>
{
    public Task<PhoneNumberType?> Buscar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Eliminar(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<PhoneNumberType>> GetList(Expression<Func<PhoneNumberType, bool>> criterio)
    {
        return await context.PhoneNumberTypes
            .Where(criterio)
            .ToListAsync();
    }

    public Task<bool> Guardar(PhoneNumberType entidad)
    {
        throw new NotImplementedException();
    }
}
