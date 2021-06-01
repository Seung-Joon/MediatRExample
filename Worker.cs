using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MediatRExample.Queries;

namespace MediatRExample
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly MediatR.IMediator _mediator;

        public Worker(ILogger<Worker> logger, INotifierMediatorService notifierMediatorService, MediatR.IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                var test = await _mediator.Send(new GetLotInformationQuery(){
                    LotId="AA"
                });

                System.Console.WriteLine(test.CustId);

                await Task.Delay(1000, stoppingToken);

            }
        }
    }
}
