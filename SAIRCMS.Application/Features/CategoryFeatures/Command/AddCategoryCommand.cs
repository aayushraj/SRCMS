using SAIRCMS.Domain.Entities;
using MediatR;
using SAIRCMS.Application.Interfaces;
using System.Threading.Tasks;
using System.Threading;
using SAIRCMS.Application.Utility;
using System;

namespace SAIRCMS.Application
{
    public record AddCategoryCommand(Category category) : IRequest<Category>;

    public class AddCategoryCommandHandler : IRequestHandler<AddCategoryCommand, Category>
    {
        private readonly IDapperService _dapperService;
        public AddCategoryCommandHandler(IDapperService dapperService)
        {
            _dapperService = dapperService;
        }
        public async Task<Category> Handle(AddCategoryCommand request, CancellationToken cancellationToken)
        {
            var qb = new QueryBuilder();
            string message = "";
            try
            {
                int result;
                if (request.category.Id.Equals(0))
                {
                    string sql = qb.Query<Category>(QueryBuilder.Operation.Insert, request.category, false);
                    result = await _dapperService.InsertAsync(sql, request.category);
                    if (result > 0)
                    {
                        message = "Inserted Successfully";
                    }
                }

                else
                {
                    string sql = qb.Query<Category>(QueryBuilder.Operation.Update, request.category, false);
                    result = await _dapperService.UpdateAsync(sql, request.category);
                    if (result > 0)
                    {
                        message = "Updated Successfully.";
                    }
                }

                return _ = new Category()
                {
                    SuccessMessage = message,
                    IsSuccess = true
                };

            }
            catch (Exception ex)
            {
                return _ = new Category()
                {
                    SuccessMessage = ex.Message,
                    IsSuccess = false
                };
            }
        }
    }
}