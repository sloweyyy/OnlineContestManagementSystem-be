using OnlineContestManagement.Data.Models;

namespace OnlineContestManagement.Data.Repositories
{
  public interface IPaymentRepository
  {
    Task<Payment> CreatePaymentAsync(Payment payment);

  }
}