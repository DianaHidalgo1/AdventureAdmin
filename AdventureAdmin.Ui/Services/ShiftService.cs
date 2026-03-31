using AdventureAdmin.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureAdmin.Ui.Services;

public class ShiftService(
     Data.Context.AdventureWorksContext context
     ) : Aplicada1.Core.IService<Shift, int>
{
    public Task<Shift?> Buscar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Eliminar(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Shift>> GetList(System.Linq.Expressions.Expression<Func<Shift, bool>> criterio)
    {
        return await context.Shifts
            .Where(criterio)
            .ToListAsync();
    }

    public Task<bool> Guardar(Shift entidad)
    {
        throw new NotImplementedException();
    }
}

