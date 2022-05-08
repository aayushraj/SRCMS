using MediatR;
using SAIRCMS.Application.Interfaces;
using System.Threading.Tasks;
using System.Threading;
using SAIRCMS.Application.Utility;
using System;
using SAIRCMS.Domain.Entities;
using Type = SAIRCMS.Domain.Entities.Type;

namespace SAIRCMS.Application
{
    public record AddProductCommand(Product product) : IRequest<Product>;

    public class AddBrandHandler : IRequestHandler<AddProductCommand, Product>
    {
        private readonly IDapperService _dapperService;
        public AddBrandHandler(IDapperService dapperService)
        {
            _dapperService = dapperService;
        }
        public async Task<Product> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            
            string message = "";
            try
            {
                int result;
                if (request.product.Id.Equals(0))
                {
                    result = await InsertProduct(request);

                    if (result > 0)
                    {
                        message = "Inserted Successfully";
                    }
                }

                //else
                //{
                //    string sql = qb.Query(QueryBuilder.Operation.Update, request.product, false);
                //    result = await _dapperService.UpdateAsync(sql, request.product);
                //    if (result > 0)
                //    {
                //        message = "Updated Successfully.";
                //    }
                //}

                return _ = new Product()
                {
                    SuccessMessage = message,
                    IsSuccess = true
                };

            }
            catch (Exception ex)
            {
                return _ = new Product()
                {
                    FailureMessage = ex.Message,
                    IsSuccess = false
                };
            }
        }

        private async Task<int> InsertProduct(AddProductCommand request)
        {
            QueryBuilder qbBrand = new QueryBuilder();
            QueryBuilder qbCat = new QueryBuilder();
            QueryBuilder qbType = new QueryBuilder();
            QueryBuilder qbProduct = new QueryBuilder();
            string productSql = qbProduct.Query<Product>(QueryBuilder.Operation.Insert, request.product, false);
            string brandSql = qbBrand.Query<Brand>(QueryBuilder.Operation.Insert, request.product.Brand, false);
            string categorySql = qbCat.Query<Category>(QueryBuilder.Operation.Insert, request.product.Category, false);
            string typeSql = qbType.Query<Type>(QueryBuilder.Operation.Insert, request.product.Type, false);
            
            using (var trans = _dapperService)
            {
                try
                {
                    trans.StartTransaction();

                    request.product.Brand.Id = await trans.InsertTransactionAsync(brandSql, request.product.Brand);
                    request.product.Category.Id = await trans.InsertTransactionAsync(categorySql, request.product.Category);
                    request.product.Type.Id = await trans.InsertTransactionAsync(typeSql, request.product.Type);
                    var result = await trans.InsertTransactionAsync(productSql, request.product);

                    trans.CommitTransaction();
                    return result;
                }
                catch
                {
                    trans.RollbackTransaction();
                    throw;
                }
            }
        }
    }
}