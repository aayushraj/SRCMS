using SAIRCMS.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using SAIRCMS.Application.Interfaces;
using System.Threading.Tasks;
using System.Threading;
using SAIRCMS.Application.Utility;
using System;

namespace SAIRCMS.Application
{
    public record GetAllProductQuery : IRequest<Product>;
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, Product>
    {
        private readonly IDapperService _dapperService;
        public GetAllProductQueryHandler(IDapperService dapperService) => _dapperService = dapperService;
        public async Task<Product> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            var qb = new QueryBuilder();
            var query = qb.Query<Product>(operation: QueryBuilder.Operation.Select, null, IsPredicate: false);
            try
            {
                Product product = new()
                {
                    List = await _dapperService.QueryAsync<Product>(query),
                    SuccessMessage = "Successful",
                    IsSuccess = true
                };

                return product;
            }

            catch (Exception ex)
            {
                return new Product
                {
                    List = null,
                    FailureMessage = ex.Message,
                    IsSuccess = false
                };
            }
        }
    }
}