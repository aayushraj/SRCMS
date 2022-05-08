using SAIRCMS.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using SAIRCMS.Application.Interfaces;
using SAIRCMS.Application.Utility;
using System;

namespace SAIRCMS.Application
{
    public record GetAllCategoryQuery : IRequest<Category>;

    public class GetAllCategoryQueryHandler : IRequestHandler<GetAllCategoryQuery, Category>
    {
        private readonly IDapperService _dapperService;
        public GetAllCategoryQueryHandler(IDapperService dapperService)
        {
            _dapperService = dapperService;
        }
        public async Task<Category> Handle(GetAllCategoryQuery request, CancellationToken cancellationToken)
        {
            var qb = new QueryBuilder();
            var query = qb.Query<Category>(operation: QueryBuilder.Operation.Select, null, IsPredicate: false);
            try
            {
                Category category = new()
                {
                    List = await _dapperService.QueryAsync<Category>(query),
                    SuccessMessage = "Successful",
                    IsSuccess = true
                };

                return category;
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