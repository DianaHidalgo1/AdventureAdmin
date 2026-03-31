using AdventureAdmin.Data.Context;
using AdventureAdmin.Data.Models;
using Aplicada1.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AdventureAdmin.Ui.Services;

public class CultureService (
   AdventureWorksContext context    
    ): IService<Culture, int>
{
    public Task<Culture?> Buscar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Eliminar(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Culture>> GetList(Expression<Func<Culture, bool>> criterio)
    {
       return await context.Cultures
            .Where(criterio)
            .ToListAsync();
    }

    public async Task<bool> Guardar(Culture entidad)
    {
        await context.Cultures.AddAsync(entidad);
        var cantidad = await context.SaveChangesAsync();
        return cantidad > 0;
    }
}
