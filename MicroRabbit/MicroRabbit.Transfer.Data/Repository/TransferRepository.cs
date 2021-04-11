using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private TransferDbContext _ctx;

        public TransferRepository(TransferDbContext ctx){
            _ctx = ctx;
        }
        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _ctx.TransferLogs;
        }
    }
}
