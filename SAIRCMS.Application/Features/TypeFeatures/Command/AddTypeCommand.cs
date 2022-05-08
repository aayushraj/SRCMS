using MediatR;
using SAIRCMS.Application.Interfaces;
using SAIRCMS.Application.Utility;
using SAIRCMS.Domain.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;
using Type = SAIRCMS.Domain.Entities.Type;

namespace SAIRCMS.Application
{
    public record AddTypeCommand(dynamic type) : IRequest<Type>;
    public class AddTypeCommandHandler : IRequestHandler<AddTypeCommand, Type>
    {
        private readonly IDapperService _dapperService;
        public AddTypeCommandHandler(IDapperService dapperService) => _dapperService = dapperService;
        public async Task<Type> Handle(AddTypeCommand request, CancellationToken cancellationToken)
        {
            var qb = new QueryBuilder();
            string message = "";
            try
            {
                int result;
                if (request.type.Id.Equals(0))
                {
                    string sql = qb.Query(QueryBuilder.Operation.Insert, request.type, false);
                    result = await _dapperService.InsertAsync(sql, request.type);
                    if (result > 0)
                    {
                        message = "Inserted Successfully";
                    }
                }

                else
                {
                    string sql = qb.Query(QueryBuilder.Operation.Update, request.type, false);
                    result = await _dapperService.UpdateAsync(sql, request.type);
                    if (result > 0)
                    {
                        message = "Updated Successfully.";
                    }
                }

                return _ = new Type()
                {
                    SuccessMessage = message,
                    IsSuccess = true
                };

            }
            catch (Exception ex)
            {
                return _ = new Type()
                {
                    SuccessMessage = ex.Message,
                    IsSuccess = false
                };
            }
        }
    }
}