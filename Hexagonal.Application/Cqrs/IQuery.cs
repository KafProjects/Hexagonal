using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hexagonal.Application.Cqrs
{
    public interface IQuery<TResult>
    {
    }

    public interface IQueryHandler<TQuery, TResult> where TQuery: IQuery<TResult>
    {
        TResult Handle(TQuery query);
    }
}
