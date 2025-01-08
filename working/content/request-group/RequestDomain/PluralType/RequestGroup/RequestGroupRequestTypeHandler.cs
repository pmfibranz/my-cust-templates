using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;
using AppNamespace.Domain.ValueObjects;

namespace ResultGroupNamespace.RequestDomain.RequestType;

#if includeViewModel
public sealed class RequestGroupRequestTypeHandler : IRequestHandler<RequestGroupRequestType, Result<RequestGroupRequestTypeVM>>
#else
public sealed class RequestGroupRequestTypeHandler : IRequestHandler<RequestGroupRequestType, Result>
#endif
{
  private readonly ILogger<RequestGroupRequestTypeHandler> _logger;

  public RequestGroupRequestTypeHandler(ILogger<RequestGroupRequestTypeHandler> logger)
  {
    _logger = logger;
  }

#if includeViewModel
  public Task<Result<RequestGroupRequestTypeVM>> Handle(RequestGroupRequestType request, CancellationToken cancellationToken)
#else
  public Task<Result> Handle(RequestGroupRequestType request, CancellationToken cancellationToken)
#endif
  {
    throw new NotImplementedException();
  }
}