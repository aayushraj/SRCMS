using SAIRCMS.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SAIRCMS.Application.Utility;
using SAIRCMS.Domain.Entities;

namespace SAIRCMS.Application.Features.BrandFeatures.Queries
{
    public record GetAllBrandQuery() : IRequest<Brand>;

    //public class GetAllBrandQuery : IRequest<Brand>
    //{
    //    public IList<Brand> List { get; set; }
    //}

    public class GetAllBrandHandler : IRequestHandler<GetAllBrandQuery, Brand>
    {
        private readonly IDapperService _dapperService;
        public GetAllBrandHandler(IDapperService dapperService)
        {
            _dapperService = dapperService;
        }
        public async Task<Brand> Handle(GetAllBrandQuery request, CancellationToken cancellationToken)
        {
            var qb = new QueryBuilder();
            var query = qb.Query<Brand>(operation: QueryBuilder.Operation.Select,null, IsPredicate: false);
            try
            {
                Brand brand = new()
                {
                    List = await _dapperService.QueryAsync<Brand>(query),
                    SuccessMessage = "Successful",
                    IsSuccess = true
                };

                //var brandResult = await _dapperService.QueryAsync<Brand>(query);
                //brandResult

                return brand;
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
