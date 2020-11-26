using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PointFood.Commons;
using PointFood.Dto;
using PointFood.Model;
using PointFood.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Service.Impl
{
    public class ClientServiceImpl : IClientService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ClientServiceImpl(ApplicationDbContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ClientDto Create(ClientCreateDto model)
        {
            var entry = _mapper.Map<Client>(model);
            entry.SignedUpAt = DateTime.Now;

            _context.Add(entry);
            _context.SaveChanges();

            return _mapper.Map<ClientDto>(GetById(entry.ClientId));
        }

        public ClientDto GetById(int id)
        {
            return _mapper.Map<ClientDto>(
                _context.Clients
                .Include(x => x.Cards)
                .Single(x => x.ClientId == id)
                );
        }

        public void Remove(int id)
        {
            _context.Remove(new Client
            {
                ClientId = id
            });

            _context.SaveChanges();
        }

        public void Update(int id, ClientUpdateDto model)
        {
            var entry = _context.Clients.Single(x => x.ClientId == id);
            entry.Name = model.Name;
            entry.Email = model.Email;
            entry.PhoneNumber = model.PhoneNumber;
            entry.Username = model.Username;
            entry.Password = model.Password;

            _context.SaveChanges();
        }

        public ClientDto GetByUsernameAndPassword(ClientLoginDto model)
        {
            return _mapper.Map<ClientDto>(
                _context.Clients
                .Include(x => x.Cards)
                .Single(x => (x.Username == model.Username) && (x.Password == model.Password))
                );
        }

        public DataCollection<ClientDto> GetAll(int page, int take)
        {
            return _mapper.Map<DataCollection<ClientDto>>(
                _context.Clients
                .Include(x => x.Cards)
                .OrderBy(x => x.ClientId)
                .AsQueryable()
                .Paged(page, take)
                );
        }
    }
}
