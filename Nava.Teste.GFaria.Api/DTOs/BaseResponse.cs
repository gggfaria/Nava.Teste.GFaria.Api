namespace Nava.Teste.GFaria.Api.DTOs
{
    public class BaseResponse<TEntity> 
    {
        public BaseResponse(int statusCode, TEntity entity)
        {
            StatusCode = statusCode;
            Entity = entity;
        }

        public int StatusCode { get; set; }
        public TEntity Entity { get; set; }
    }
}
