﻿using System;
using System.Threading.Tasks;
using MassTransit;
using Microsoft.Extensions.Configuration;

namespace WebShopApplication.Producer
{
    public class BookRequestProducer
    {
        private readonly ISendEndpointProvider _sendEndpointProvider;
        private readonly IConfiguration _configuration;

        public BookRequestProducer(ISendEndpointProvider sendEndpointProvider, IConfiguration configuration)
        {
            _sendEndpointProvider = sendEndpointProvider;
            _configuration = configuration;
        }

        public async Task SentBookRequest(int bookCount)
        {
            Console.Out.WriteLine("Запрос на книги");
            var message = new BookRequest(bookCount);
            
            var hostConfig = new MassTransitConfiguration();
            _configuration.GetSection("MassTransit").Bind(hostConfig);
            var endpoint = await _sendEndpointProvider.GetSendEndpoint(hostConfig.GetQueueAddress("book-shop-queue"));
            await endpoint.Send(message);
            
        }
    }
}