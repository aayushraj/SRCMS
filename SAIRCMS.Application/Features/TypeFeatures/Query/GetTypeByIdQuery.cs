using SAIRCMS.Domain.Entities;
using MediatR;
using SAIRCMS.Application.Interfaces;
using System.Threading;
using SAIRCMS.Application.Utility;
using System;
using System.Threading.Tasks;
using Type = SAIRCMS.Domain.Entities.Type;

namespace SAIRCMS.Application
{
    public record GetTypeByIdQuery(dynamic id) : IRequest<Type>;
    public class GetTypeByIdQueryHandler : IRequestHandler<GetTypeByIdQuery, Type>
    {
        private readonly IDapperService _service;
        public GetTypeByIdQueryHandler(IDapperService service) => _service = service;
        public async Task<Type> Handle(GetTypeByIdQuery request, CancellationToken cancellationToken)
        {
            //string sql = "select * From SRF_BRAND_INFO where Id=@Id";

            var qb = new QueryBuilder();
            string sql = qb.Query(QueryBuilder.Operation.Select, request.id, IsPredicate: true);

            try
            {
                var result = await _service.QueryAsync<Type>(sql, request.id);
                result.SuccessMessage = "Successful";
                result.IsSuccess = true;

                return result;
            }
            catch (Exception ex)
            {
                return new Type
                {
                    List = null,
                    FailureMessage = ex.Message,
                    IsSuccess = false
                };
            }

        }
    }
}