using System;
using AutoMapper;
using BecketLee.Data;
using BecketLee.Models;
using BecketLee.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BecketLee.Controllers.Api
{
    public class EventApiController : Controller
    {
        private readonly IEventRepository _repository;
        private readonly ILogger<EventApiController> _logger;

        public EventApiController(IEventRepository repository, ILogger<EventApiController> logger)
        {
            _repository = repository;
            _logger = logger;
        }

		

        [HttpGet("api/events")]
        public IActionResult Get()
        {
            try
            {
                return Ok( _repository.GetEvents() );
            }
            catch (Exception exception)
            {
                _logger.LogError(exception.Message);
                return BadRequest( "Unable to get the events listing.");
            }
        }

        [HttpPost( "api/event" )]
        public IActionResult Post([FromBody] EventViewModel eventSent)
        {
            if( ModelState.IsValid )
            {
                var newEvent = Mapper.Map<Event>( eventSent );
                return Created( $"api/events/{newEvent.EventId}", Mapper.Map<EventViewModel>( newEvent ) );
            }

            return BadRequest(ModelState);
        }

    }
}