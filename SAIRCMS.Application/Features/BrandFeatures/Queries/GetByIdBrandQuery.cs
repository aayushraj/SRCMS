using MediatR;
using SAIRCMS.Application.Interfaces;
using SAIRCMS.Application.Utility;
using SAIRCMS.Domain.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SAIRCMS.Application
{
    public record GetByIdBrandQuery(int id) : IRequest<Brand>;


    public class GetIdBrandQueryHandler : IRequestHandler<GetByIdBrandQuery, Brand>
    {
        private readonly IDapperService _service;
        public GetIdBrandQueryHandler(IDapperService service)
        {
            _service = service;
        }
        public async Task<Brand> Handle(GetByIdBrandQuery request, CancellationToken cancellationToken)
        {
            //string sql = "select * From SRF_BRAND_INFO where Id=@Id";
            var qb = new QueryBuilder();
            string sql = qb.Query<Brand>(QueryBuilder.Operation.Select, request.id,IsPredicate:true);

            try
            {
                var result = await _service.QueryAsync<Brand>(sql, request.id);
                if (result!=null)
                {
                    return new Brand
                    {
                        List = result.List,
                        SuccessMessage = "Successfully Fetched",
                        IsSuccess = false
                    };
                }

                return result;
            }
            catch (Exception ex)
            {
                return new Brand
                {
                    List = null,
                    FailureMessage = ex.Message,
                    IsSuccess = false
                };
            }

        }
    }
}