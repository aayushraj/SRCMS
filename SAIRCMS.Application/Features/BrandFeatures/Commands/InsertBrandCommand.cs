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

namespace SAIRCMS.Application.Features.BrandFeatures.Commands
{
    public record AddBrandCommand (dynamic brand):IRequest<Brand>;

    public class AddBrandHandler : IRequestHandler<AddBrandCommand, Brand>
    {
        private readonly IDapperService _dapperService;
        public AddBrandHandler(IDapperService dapperService)
        {
            _dapperService = dapperService;
        }
        public async Task<Brand> Handle(AddBrandCommand request, CancellationToken cancellationToken)
        {
            var qb = new QueryBuilder();
            string message = "";
            try
            {
                int result;
                if (request.brand.Id.Equals(0))
                {
                    string sql = qb.Query(QueryBuilder.Operation.Insert, request.brand, false);
                    result = await _dapperService.InsertAsync(sql, request.brand);
                    if (result > 0)
                    {
                        message = "Inserted Successfully";
                    }
                }

                else
                {
                    string sql = qb.Query(QueryBuilder.Operation.Update, request.brand, false);
                    result = await _dapperService.UpdateAsync(sql, request.brand);
                    if (result > 0)
                    {
                        message = "Updated Successfully.";
                    }
                }

                return _ = new Brand()
                {
                    SuccessMessage = message,
                    IsSuccess = true
                };

            }
            catch (Exception ex)
            {
                return _ = new Brand()
                {
                    SuccessMessage = ex.Message,
                    IsSuccess = false
                };
            }
        }
    }
}
