using OnlineCinema.Example.Data.Context;
using OnlineCinema.Example.Core.Command;
using OnlineCinema.Example.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace OnlineCinema.Example.Commands.AddMovie;

public sealed class SubscribeUserCommandHandler : ICommandHandler<SubscribeUserCommand>
{
    private readonly JournalContextDb _context;

    public SubscribeUserCommandHandler(JournalContextDb context)
    {
        _context = context;
    }

    public async Task Handle(SubscribeUserCommand command)
    {
        UserEntity? user = await _context.Users.FirstOrDefaultAsync(p => p.Id == command.UserId);
        SubscriptionEntity? subscription = await _context.Subscriptions.FirstOrDefaultAsync(p => p.Id == command.SubscriptionId);

        if (user != null || subscription != null)
        {
            return;
        }

        UserPaymentInfoEntity? paymentInfo = await _context.UserPaymentInfo.FirstOrDefaultAsync(p => p.Id == command.UserId);
        DateTime expiresAt = DateTime.Now.AddMonths(subscription.DurationInMonth);
        if (paymentInfo == null)
        {
            paymentInfo = new UserPaymentInfoEntity(
                command.UserId,
                subscription.Id,
                expiresAt
                );

            _context.UserPaymentInfo.Add(paymentInfo);
        } else
        {
            paymentInfo.SubscriptionId = subscription.Id;
            paymentInfo.ExpiresAt = expiresAt;

            _context.UserPaymentInfo.Update(paymentInfo);
        }

        await _context.SaveChangesAsync();
    }
}