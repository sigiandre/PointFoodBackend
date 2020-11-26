using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PointFood.Dto;
using PointFood.Model;
using PointFood.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Service.Impl
{
    public class CardServiceImpl : ICardService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CardServiceImpl(ApplicationDbContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public CardDto Create(CardCreateDto model)
        {
            var entry = _mapper.Map<Card>(model);

            _context.Add(entry);
            _context.SaveChanges();

            return _mapper.Map<CardDto>(GetById(entry.CardId));
        }

        public CardDto GetById(int id)
        {
            return _mapper.Map<CardDto>(
                _context.Cards
                .Include(x => x.Client)
                .Single(x => x.CardId == id)
                );
        }

        public void Remove(int id)
        {
            _context.Remove(new Card
            {
                CardId = id
            });
            _context.SaveChanges();
        }

        public void Update(int id, CardUpdateDto model)
        {
            var entry = _context.Cards.Single(x => x.CardId == id);
            entry.Number = model.Number;

            _context.SaveChanges();
        }
    }
}
