using SAIRCMS.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using SAIRCMS.Application.Interfaces;
using System.Threading.Tasks;
using System.Threading;
using SAIRCMS.Application.Utility;
using System;
using Type = SAIRCMS.Domain.Entities.Type;

namespace SAIRCMS.Application
{
    public record GetAllTypeQuery : IRequest<Type>;
    public class GetAllTypeHandler : IRequestHandler<GetAllTypeQuery, Type>
    {
        private readonly IDapperService _dapperService;
        public GetAllTypeHandler(IDapperService dapperService) => _dapperService = dapperService;

        public async Task<Type> Handle(GetAllTypeQuery request, CancellationToken cancellationToken)
        {
            var qb = new QueryBuilder();
            try
            {
                var query = qb.Query<Type>(operation: QueryBuilder.Operation.Select, null, IsPredicate: false);

                return _ = new Type()
                {
                    List = await _dapperService.QueryAsync<Type>(query),
                    SuccessMessage = "Successful",
                    IsSuccess = true
                };
            }

            catch (Exception ex)
            {
                return _ = new Type()
                {
                    List = null,
                    FailureMessage = ex.Message,
                    IsSuccess = false
                };
            }

        }
    }

}