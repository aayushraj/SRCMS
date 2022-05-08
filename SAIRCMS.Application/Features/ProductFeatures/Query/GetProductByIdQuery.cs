using SAIRCMS.Domain.Entities;
using MediatR;
using SAIRCMS.Application.Interfaces;
using SAIRCMS.Application.Utility;
using System.Threading.Tasks;
using System.Threading;
using System;

namespace SAIRCMS.Application
{
    public record GetProductByIdQuery(dynamic id) : IRequest<Product>;
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Product>
    {
        private readonly IDapperService _service;
        public GetProductByIdQueryHandler(IDapperService service) => _service = service;
        public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            //string sql = "select * From SRF_BRAND_INFO where Id=@Id";

            var qb = new QueryBuilder();
            string sql = qb.Query(QueryBuilder.Operation.Select, request.id, IsPredicate: true);

            try
            {
                var result = await _service.QueryAsync<Product>(sql, request.id);
                result.SuccessMessage = "Fetched Successfully.";
                result.IsSuccess = true;

                return result;
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