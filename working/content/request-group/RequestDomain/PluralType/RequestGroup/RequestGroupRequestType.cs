using MediatR;
using AppNamespace.Domain.ValueObjects;

namespace ResultGroupNamespace.RequestDomain.RequestType;

#if includeViewModel
public sealed record RequestGroupRequestType : IRequest<Result<RequestGroupRequestTypeVM>>
#else
public sealed record RequestGroupRequestType : IRequest<Result>
#endif
{

}
