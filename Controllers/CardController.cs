using Microsoft.AspNetCore.Mvc;
using PointFood.Dto;
using PointFood.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Controllers
{
    [ApiController]
    [Route("cards")]
    public class CardController : ControllerBase
    {
        private readonly ICardService _cardService;

        public CardController(ICardService cardService)
        {
            _cardService = cardService;
        }

        [HttpPost]
        public ActionResult Create(CardCreateDto card)
        {
            var result = _cardService.Create(card);

            return CreatedAtAction("GetById", new { cardId = result.CardId}, result);
        }

        [HttpGet("{cardId}")]
        public ActionResult<CardDto> GetById(int cardId)
        {
            return _cardService.GetById(cardId);
        }

        [HttpPut("{cardId}")]
        public ActionResult Update(int cardId, CardUpdateDto model)
        {
            _cardService.Update(cardId, model);
            return Ok();
        }


        [HttpDelete("{cardId}")]
        public ActionResult Remove(int cardId)
        {
            _cardService.Remove(cardId);
            return Ok();
        }
    }
}
