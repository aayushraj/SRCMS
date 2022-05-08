using SAIRCMS.Domain.Entities;
using MediatR;
using System.Threading.Tasks;
using System.Threading;
using SAIRCMS.Application.Utility;
using System;
using SAIRCMS.Application.Interfaces;

namespace SAIRCMS.Application
{
    public record GetCategoryByIdQuery(dynamic id) : IRequest<Category>;
    public class GetIdCategoryQueryHandler : IRequestHandler<GetCategoryByIdQuery, Category>
    {
        private readonly IDapperService _service;
        public GetIdCategoryQueryHandler(IDapperService service)
        {
            _service = service;
        }
        public async Task<Category> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            //string sql = "select * From SRF_BRAND_INFO where Id=@Id";

            var qb = new QueryBuilder();
            string sql = qb.Query<Category>(QueryBuilder.Operation.Select, request.id, IsPredicate: true);

            try
            {
                var result = await _service.QueryAsync<Category>(sql, request.id);
                result.SuccessMessage = "Successful";
                result.IsSuccess = true;

                return result;
            }
            catch (Exception ex)
            {
                return new Category
                {
                    List = null,
                    FailureMessage = ex.Message,
                    IsSuccess = false
                };
            }

        }
    }
}