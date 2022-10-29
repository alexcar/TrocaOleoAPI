namespace Entities.Responses
{
    public sealed class Company1NotFoundResponse : ApiNotFoundResponse
    {
        public Company1NotFoundResponse(Guid id) 
            : base($"Company with id: {id} is not found in db.")
        {
        }
    }
}
