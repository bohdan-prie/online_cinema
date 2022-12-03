namespace OnlineCinema.Example.Core.Query;

public interface IQueryHandler<in TQuery, TResult>
    where TQuery : IQuery
    where TResult : class
{
    Task<TResult> Handle(TQuery query);
}