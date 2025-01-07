using System;
using MediatR;
using Microsoft.Extensions.Logging;

namespace ResultGroupNamespace;

public class RequestGroupRequestTypeHandler : IRequestHandler<RequestGroupRequestType, RequestGroupRequestTypeVM>
{
  private readonly ILogger<RequestGroupRequestTypeHandler> _logger;

  public RequestGroupRequestTypeHandler(ILogger<RequestGroupRequestTypeHandler> logger)
  {
    _logger = logger;
  }

  public Task<RequestGroupRequestTypeVM> Handle(CreateEquipmentNoteCommand request, CancellationToken cancellationToken)
  {
    throw new NotImplementedException();
  }
}