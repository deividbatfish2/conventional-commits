using FluentAssertions;
using GatewayPagamentos.Application.Model;
using Xunit;

namespace GatewayPagamentos.UnitTest.Model
{
    public class TransactionTest
    {
        [Fact]
        public void ShouldCreateATransactionWithStatusOpen()
        {
            var transaction = new Transaction();
            transaction.Status.Should().Be(TransactionStatus.OPEN);
        }
    }
}