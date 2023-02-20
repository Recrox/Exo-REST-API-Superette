﻿using AutoMapper;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using Technocite.Auchan.Superette.Core.Models;

namespace Providers.Repositories
{
    public class TicketRepository : ITicketRepository
    {
        private readonly WebSuperetteContext webSuperetteContext;
        private readonly IMapper mapper;

        public TicketRepository(WebSuperetteContext webSuperetteContext,IMapper mapper)
        {
            this.webSuperetteContext = webSuperetteContext;
            this.mapper = mapper;
        }

        public async Task AddAsync(Ticket ticket)
        {
            await this.webSuperetteContext.Ticket.AddAsync(this.mapper.Map<Models.Ticket>(ticket));
            try
            {
                await this.webSuperetteContext.SaveChangesAsync();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message, e);
            }
            
            
        }

        public IEnumerable<Ticket> GetAll()
        {
            return this.mapper.Map<IEnumerable<Ticket>>(this.webSuperetteContext.Ticket);
        }

        public async Task<Ticket> GetByIdAsync(int id)
        {
            var result = await this.webSuperetteContext.Ticket.
                FirstOrDefaultAsync(ca => ca.Id == id);

            return this.mapper.Map<Ticket>(result);
        }

        public Task RemoveByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Ticket ticket)
        {
            throw new NotImplementedException();
        }
    }
}