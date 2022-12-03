using OnlineCinema.Example.Dtos;
using OnlineCinema.Example.Data.Context;
using OnlineCinema.Example.Core.Query;
using OnlineCinema.Example.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace OnlineCinema.Example.Queries.GetUserSubscriptionById;

public sealed class GetUserSubscriptionByIdQueryHandler : IQueryHandler<GetUserSubscriptionByIdQuery, UserSubscriptionDto>
{
    private readonly JournalContextDb _context;

    public GetUserSubscriptionByIdQueryHandler(JournalContextDb context)
    {
        _context = context;
    }

    public async Task<UserSubscriptionDto?> Handle(GetUserSubscriptionByIdQuery query)
    {
        UserPaymentInfoEntity? userPaymentInfo = await _context.UserPaymentInfo.FirstOrDefaultAsync(p => p.Id == query.UserId);

        if (userPaymentInfo == null)
        {
            return null;
        }

        SubscriptionEntity subscription = await _context.Subscriptions.FirstAsync(p => p.Id == userPaymentInfo.SubscriptionId);

        return new UserSubscriptionDto { 
            Id = subscription.Id, 
            UserId = query.UserId, 
            ExpiresAt = userPaymentInfo.ExpiresAt, 
            Price = subscription.Price,
            DurationInMonth = subscription.DurationInMonth 
        };
    }
}