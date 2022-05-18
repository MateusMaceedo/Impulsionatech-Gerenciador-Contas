using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Gerenciador.Transferencia.Application.Contracts;
using Gerenciador.Transferencia.Application.Models.Request;
using Gerenciador.Transferencia.Application.UseCases;
using Gerenciador.Transferencia.Repository.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gerenciador.Transferencia.Repository.Repository
{
    public class TransferenciaRepository : ITransferenciaRepository
    {
        private readonly AmazonDynamoDBClient _client;
        private readonly DynamoDBContext _context;

        public TransferenciaRepository()
        {
            _client = new AmazonDynamoDBClient();
            _context = new DynamoDBContext(_client);
        }

        public async Task Add(TransferenciaInputModel entity)
        {
            var transferencia = new TransferenciaRequest
            {
                IdTransferencia = Guid.NewGuid(),
                NomeClienteOrigem = entity.NomeClienteOrigem,
                NomeClienteDestino = entity.NomeClienteDestino,
                ContaClienteOrigem = entity.ContaClienteOrigem,
                ContaClienteDestino = entity.ContaClienteDestino,
                DataHoraTransferencia = DateTime.Now,
            };

            await _context.SaveAsync<TransferenciaRequest>(transferencia);
        }

        public Task<TransferenciaViewModel> All(string paginationToken = "")
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TransferenciaRequest>> Find(BuscaTransferenciaRequest buscaReq)
        {
            throw new NotImplementedException();
        }

        public Task Remove(Guid readerId)
        {
            throw new NotImplementedException();
        }

        public Task<TransferenciaUseCase> Single(Guid readerId)
        {
            throw new NotImplementedException();
        }

        public Task Update(Guid readerId, TransferenciaInputModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
